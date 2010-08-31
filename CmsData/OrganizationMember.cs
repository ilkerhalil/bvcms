﻿/* Author: David Carroll
 * Copyright (c) 2008, 2009 Bellevue Baptist Church 
 * Licensed under the GNU General Public License (GPL v2)
 * you may not use this code except in compliance with the License.
 * You may obtain a copy of the License at http://bvcms.codeplex.com/license 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilityExtensions;
using System.Web;
using System.Data.SqlClient;

namespace CmsData
{
    public partial class OrganizationMember
    {
        private const string STR_MeetingsToUpdate = "MeetingsToUpdate";
        public enum MemberTypeCode
        {
            Administrator = 100,
            President = 101,
            Leader = 140,
            AssistantLeader = 142,
            Teacher = 160,
            AssistantTeacher = 161,
            Member = 220,
            InActive = 230,
            VisitingMember = 300,
            Visitor = 310,
            InServiceMember = 500,
            VIP = 700,
            Drop = -1,
        }
        private CMSDataContext _Db;
        public CMSDataContext Db
        {
            get
            {
                if (_Db == null)
                    _Db = this.GetDataContext() as CMSDataContext;
                return _Db;
            }
        }
        public EnrollmentTransaction Drop()
        {
            DbUtil.Db.SubmitChanges();
            int ntries = 2;
            while (true)
            {
                try
                {
                    var q = from o in Db.Organizations
                            where o.OrganizationId == OrganizationId
                            let count = Db.Attends.Count(a => a.PeopleId == PeopleId
                                && a.OrganizationId == OrganizationId
                                && (a.MeetingDate < DateTime.Today || a.AttendanceFlag == true))
                            select new { count, Organization.DaysToIgnoreHistory };
                    var i = q.Single();
                    EnrollmentTransaction droptrans = null;
                    if (Util.Now.Subtract(this.EnrollmentDate.Value).TotalDays
                        < (i.DaysToIgnoreHistory ?? 60) 
                        && i.count == 0)
                    {
                        var qe = from et in Db.EnrollmentTransactions
                                 where et.PeopleId == PeopleId
                                    && et.OrganizationId == OrganizationId
                                    && et.EnrollmentDate == this.EnrollmentDate
                                    && et.TransactionTypeId == 1
                                 orderby et.TransactionId
                                 select et.TransactionId;
                        var enrollid = qe.FirstOrDefault();

                        var qt = from et in Db.EnrollmentTransactions
                                 where et.PeopleId == PeopleId && et.OrganizationId == OrganizationId
                                 where et.TransactionId >= enrollid
                                 select et;
                        Db.EnrollmentTransactions.DeleteAllOnSubmit(qt);
                        var qa = from et in Db.Attends
                                 where et.PeopleId == PeopleId && et.OrganizationId == OrganizationId
                                 select et;
                        var smids = HttpContext.Current.Items[STR_MeetingsToUpdate] as List<int>;
                        var mids = qa.Select(a => a.MeetingId).ToList();
                        if (smids != null)
                            smids.AddRange(mids);
                        else
                            HttpContext.Current.Items[STR_MeetingsToUpdate] = mids;
                        Db.Attends.DeleteAllOnSubmit(qa);
                    }
                    else
                    {
                        droptrans = new EnrollmentTransaction
                        {
                            OrganizationId = OrganizationId,
                            PeopleId = PeopleId,
                            MemberTypeId = MemberTypeId,
                            OrganizationName = Organization.OrganizationName,
                            TransactionDate = Util.Now,
                            TransactionTypeId = 5, // drop
                            CreatedBy = Util.UserId1,
                            CreatedDate = Util.Now,
                            Pending = Pending,
                            AttendancePercentage = AttendPct,
                        };
                        Db.EnrollmentTransactions.InsertOnSubmit(droptrans);
                    }
                    Db.OrgMemMemTags.DeleteAllOnSubmit(this.OrgMemMemTags);
                    Db.OrganizationMembers.DeleteOnSubmit(this);
                    return droptrans;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 1205)
                        if (--ntries > 0)
                        {
                            DbUtil.DbDispose();
                            System.Threading.Thread.Sleep(500);
                            continue;
                        }
                    throw;
                }
            }
        }
        public static void UpdateMeetingsToUpdate()
        {
            var mids = HttpContext.Current.Items[STR_MeetingsToUpdate] as List<int>;
            if (mids != null)
                foreach (var mid in mids)
                    DbUtil.Db.UpdateMeetingCounters(mid);
        }
        public bool ToggleGroup(int groupid)
        {
            var group = OrgMemMemTags.SingleOrDefault(g => 
                g.OrgId == OrganizationId && g.PeopleId == PeopleId && g.MemberTagId == groupid);
            if (group == null)
            {
                OrgMemMemTags.Add(new OrgMemMemTag { MemberTagId = groupid });
                return true;
            }
            OrgMemMemTags.Remove(group);
            Db.OrgMemMemTags.DeleteOnSubmit(group);
            return false;
        }
        public void AddToGroup(string name)
        {
            int? n = null;
            AddToGroup(name, n);
        }
        public void AddToGroup(string name, int? n)
        {
            if (!name.HasValue())
                return;
            var mt = DbUtil.Db.MemberTags.SingleOrDefault(t => t.Name == name.Trim() && t.OrgId == OrganizationId);
            if (mt == null)
            {
                mt = new MemberTag { Name = name.Trim(), OrgId = OrganizationId };
                DbUtil.Db.MemberTags.InsertOnSubmit(mt);
                DbUtil.Db.SubmitChanges();
            }
            var omt = DbUtil.Db.OrgMemMemTags.SingleOrDefault(t =>
                t.PeopleId == PeopleId
                && t.MemberTagId == mt.Id
                && t.OrgId == OrganizationId);
            if (omt == null)
                mt.OrgMemMemTags.Add(new OrgMemMemTag
                {
                    PeopleId = PeopleId,
                    OrgId = OrganizationId,
                    Number = n
                });
            DbUtil.Db.SubmitChanges();
        }
        public void RemoveFromGroup(string name)
        {
            var mt = DbUtil.Db.MemberTags.SingleOrDefault(t => t.Name == name && t.OrgId == OrganizationId);
            if (mt == null)
                return;
            var omt = DbUtil.Db.OrgMemMemTags.SingleOrDefault(t => t.PeopleId == PeopleId && t.MemberTagId == mt.Id && t.OrgId == OrganizationId);
            if (omt != null)
            {
                OrgMemMemTags.Remove(omt);
                Db.OrgMemMemTags.DeleteOnSubmit(omt);
                DbUtil.Db.SubmitChanges();
            }
        }
        public void AddToMemberData(string s)
        {
            if (UserData.HasValue())
                UserData += "\n";
            UserData += s;
        }

        public static OrganizationMember InsertOrgMembers
            (int OrganizationId,
            int PeopleId,
            int MemberTypeId,
            DateTime EnrollmentDate,
            DateTime? InactiveDate, bool pending
            )
        {
            DbUtil.Db.SubmitChanges();
            int ntries = 2;
            while (true)
            {
                try
                {
                    var Db = DbUtil.Db;
                    var m = Db.OrganizationMembers.SingleOrDefault(m2 => m2.PeopleId == PeopleId && m2.OrganizationId == OrganizationId);
                    if (m != null)
                    {
                        m.AddToMemberData("insert: {0}".Fmt(EnrollmentDate.ToString()));
                        return m;
                    }
                    var om = new OrganizationMember
                    {
                        OrganizationId = OrganizationId,
                        PeopleId = PeopleId,
                        MemberTypeId = MemberTypeId,
                        EnrollmentDate = EnrollmentDate,
                        InactiveDate = InactiveDate,
                        CreatedDate = Util.Now,
                        Pending = pending,
                    };
                    var name = (from o in Db.Organizations
                                where o.OrganizationId == OrganizationId
                                select o.OrganizationName).Single();
                    var et = new EnrollmentTransaction
                    {
                        OrganizationId = om.OrganizationId,
                        PeopleId = om.PeopleId,
                        MemberTypeId = om.MemberTypeId,
                        OrganizationName = name,
                        TransactionDate = Util.Now,
                        EnrollmentDate = om.EnrollmentDate,
                        TransactionTypeId = 1, // join
                        CreatedBy = Util.UserId1,
                        CreatedDate = Util.Now,
                        Pending = pending,
                        AttendancePercentage = om.AttendPct
                    };
                    Db.OrganizationMembers.InsertOnSubmit(om);
                    Db.EnrollmentTransactions.InsertOnSubmit(et);

                    Db.SubmitChanges();
                    return om;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 1205)
                        if (--ntries > 0)
                        {
                            DbUtil.DbDispose();
                            System.Threading.Thread.Sleep(500);
                            continue;
                        }
                    throw;
                }
            }
        }
    }
}
