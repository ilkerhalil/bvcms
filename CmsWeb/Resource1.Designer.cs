﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CmsWeb {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CmsWeb.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {name},
        ///&lt;p&gt;Your username is: {username}&lt;/p&gt;
        ///&lt;p&gt;If you did not request this, please disregard this message.&lt;/p&gt;
        ///&lt;p&gt;Thanks,&lt;br /&gt;
        ///The bvCMS Team&lt;/p&gt;
        ///.
        /// </summary>
        internal static string AccountController_ForgotUsername {
            get {
                return ResourceManager.GetString("AccountController_ForgotUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Someone recently requested a new password for this email address {email}.  
        ///However, we could not find an account associated with this email address.
        ///You may try a different email address, or contact the church.&lt;/p&gt;
        ///&lt;p&gt;If this is a mistake, please disregard this message, your password will not be changed.&lt;/p&gt;
        ///&lt;p&gt;Thanks,&lt;br /&gt;
        ///The BVCMS Team&lt;/p&gt;
        ///.
        /// </summary>
        internal static string AccountModel_ForgotPasswordBadEmail {
            get {
                return ResourceManager.GetString("AccountModel_ForgotPasswordBadEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Someone recently requested a new password for this email address {email}.
        ///To set your password, click the link below:&lt;/p&gt;
        ///&lt;blockquote&gt;&lt;a href=&quot;{resetlink}&quot;&gt;New Password&lt;/a&gt;&lt;/blockquote&gt;
        ///&lt;p&gt;If this is a mistake, please disregard this message, your password will not be changed.&lt;/p&gt;
        ///&lt;p&gt;Thanks,&lt;br /&gt;
        ///The BVCMS Team&lt;/p&gt;
        ///.
        /// </summary>
        internal static string AccountModel_ForgotPasswordReset {
            get {
                return ResourceManager.GetString("AccountModel_ForgotPasswordReset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Someone recently requested a new password for {email}.
        ///To set your password, click your username below:&lt;/p&gt;
        ///&lt;blockquote&gt;{resetlink}&lt;/blockquote&gt;
        ///&lt;p&gt;If this is a mistake, please disregard this message, your password will not be changed.&lt;/p&gt;
        ///&lt;p&gt;Thanks,&lt;br /&gt;
        ///The BVCMS Team&lt;/p&gt;
        ///.
        /// </summary>
        internal static string AccountModel_ForgotPasswordReset2 {
            get {
                return ResourceManager.GetString("AccountModel_ForgotPasswordReset2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {name},
        ///&lt;p&gt;You have a new account on our Church Management System. 
        ///Click on your username below to set your password and login to the system.&lt;/p&gt;
        ///&lt;blockquote&gt;
        ///&lt;h3&gt;Your username is: &lt;b&gt;&lt;a href=&quot;{link}&quot;&gt;{username}&lt;/a&gt;&lt;/h3&gt;
        ///&lt;/blockquote&gt;.
        /// </summary>
        internal static string AccountModel_NewUserWelcome {
            get {
                return ResourceManager.GetString("AccountModel_NewUserWelcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;
        ///&lt;TestPlan&gt;
        ///  &lt;Sections&gt;
        ///    &lt;Section name=&quot;Meta&quot;&gt;
        ///      &lt;Tests&gt;
        ///        &lt;test name=&quot;Lookup&quot;&gt;
        ///          &lt;args&gt;
        ///            &lt;name&gt;table&lt;/name&gt;
        ///          &lt;/args&gt;
        ///          &lt;script&gt;
        ///            &lt;![CDATA[
        ///xml = webclient.DownloadString(&apos;APIMeta/lookups/&apos; + table)
        ///return xml
        ///]]&gt;
        ///          &lt;/script&gt;
        ///          &lt;description&gt;
        ///            &lt;![CDATA[
        ///&lt;ul&gt;
        ///&lt;li&gt;These are tables of id / value pairs for look up tables&lt;/li&gt;
        ///&lt;li&gt;Try MemberStatus as a name of a table&lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string APITestPlan {
            get {
                return ResourceManager.GetString("APITestPlan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {	
        ///Comment: &quot;Gives a table 7.5 inches wide suitable for 8x11 portrait&quot;,
        ///PageHeight: 11,
        ///PageWidth: 8.5,
        ///MarginLeft: .5,
        ///MarginRight: .5,
        ///MarginTop: .5,
        ///MarginBottom: .5,
        ///RowHeight: 1.2,
        ///SpacerWidth: 0.04,
        ///LabelWidth: 2.5,
        ///PicWidth: .67,
        ///PicWidthPixels: 62,
        ///FontSizeName: 12,
        ///FontSize: 10,
        ///FontSizeEmail: 9 
        ///}.
        /// </summary>
        internal static string CompactDirectoryParameters {
            get {
                return ResourceManager.GetString("CompactDirectoryParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	Comment: &quot;Gives a table 4.9 inches wide suitable for bi-fold booklet landscape (2 pages per sheet)&quot;,
        ///	PageHeight: 11,
        ///	PageWidth: 8.5,
        ///	MarginLeft: .3,
        ///	MarginRight: .3,
        ///	MarginTop: .4,
        ///	MarginBottom: .4,
        ///	RowHeight: .96,
        ///	SpacerWidth: 0.04,
        ///	LabelWidth: 1.6333,
        ///	PicWidth: .55,
        ///	PicWidthPixels: 50,
        ///	FontSizeName: 7.5,
        ///	FontSize: 7,
        ///	FontSizeEmail: 5.5
        ///}.
        /// </summary>
        internal static string CompactDirectoryParameters2 {
            get {
                return ResourceManager.GetString("CompactDirectoryParameters2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thank you for managing your subscriptions to {org}&lt;br/&gt;
        ///You have the following subscriptions:&lt;br/&gt;
        ///{details}.
        /// </summary>
        internal static string ConfirmSubscriptions {
            get {
                return ResourceManager.GetString("ConfirmSubscriptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;h1&gt;Sample Church&lt;/h1&gt;
        ///&lt;h2&gt;2000 Appling Rd. | Cordova | TN 38088-1210 | (901) 347-2000&lt;/h2&gt;.
        /// </summary>
        internal static string ContributionStatementHeader {
            get {
                return ResourceManager.GetString("ContributionStatementHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;&lt;i&gt;
        ///NOTE: No goods or services were provided to you by the church in connection with any contibution;
        ///any value received consisted entirely of intangible religious benefits.
        ///Sample Church, FEIN # 1234, is a 501(c)(3) organization and
        ///qualifies as a part of the Southern Baptist Convention&apos;s group tax exemption ruling number GEN #1674.
        ///&lt;/i&gt;&lt;/p&gt;
        ///&lt;p&gt;&lt;i&gt;
        ///Thank you for your faithfulness in the giving of your time, talents, and resources. Together we can share the love of Jesus with our city.
        ///&lt;/i&gt;&lt;/p&gt;.
        /// </summary>
        internal static string ContributionStatementNotice {
            get {
                return ResourceManager.GetString("ContributionStatementNotice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {name},
        ///&lt;p&gt;We noticed you already have an account in our church database.&lt;/p&gt;
        ///&lt;p&gt;You can login at &lt;a href=&quot;{host}&quot;&gt;{host}&lt;/a&gt;. 
        ///And if you can&apos;t remember your password or username, click the Forgot Password link when you get there. 
        ///Note: you will need to know your username for this to work. If you do not know your username, then please click forgot username first.
        ///This will send you a link you can use to reset your password.&lt;/p&gt;
        ///&lt;p&gt;You can use your account to help us maintain your correct address, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateAccount_ExistingUser {
            get {
                return ResourceManager.GetString("CreateAccount_ExistingUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;CustomColumns&gt;
        ///  &lt;Joins&gt;
        ///    &lt;join name=&quot;g&quot;&gt;
        ///      LEFT JOIN lookup.Gender g ON g.Id = p.GenderId
        ///    &lt;/join&gt;
        ///    &lt;join name=&quot;mars&quot;&gt;
        ///      LEFT JOIN lookup.MaritalStatus mars ON mars.Id = p.MaritalStatusId
        ///    &lt;/join&gt;
        ///    &lt;join name=&quot;fp&quot;&gt;
        ///      LEFT JOIN lookup.FamilyPosition fp ON fp.Id = p.PositionInFamilyId
        ///    &lt;/join&gt;
        ///    &lt;join name=&quot;rr&quot;&gt;
        ///      left join dbo.recreg rr on rr.peopleid = p.peopleid
        ///    &lt;/join&gt;
        ///    &lt;join name=&quot;mo&quot;&gt;
        ///      left join dbo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CustomColumns {
            get {
                return ResourceManager.GetString("CustomColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {name},
        ///&lt;p&gt;You registered for {org} using a different email address than the one we have on record.
        ///It is important that you call the church &lt;strong&gt;{phone}&lt;/strong&gt; to update our records
        ///so that you will receive future important notices regarding this registration.&lt;/p&gt;.
        /// </summary>
        internal static string DiffEmailMessage {
            get {
                return ResourceManager.GetString("DiffEmailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi {name},
        ///&lt;p&gt;You registered for {org}, and we found your record, 
        ///but there was no email address on your existing record in our database.
        ///If you would like for us to update your record with this email address or another,
        ///Please contact the church at &lt;strong&gt;{phone}&lt;/strong&gt; to let us know.
        ///It is important that we have your email address so that
        ///you will receive future important notices regarding this registration.
        ///But we won&apos;t add that to your record without your permission.
        ///
        ///Thank you&lt;/p&gt;.
        /// </summary>
        internal static string NoEmailMessage {
            get {
                return ResourceManager.GetString("NoEmailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///    &lt;h2&gt;Transaction Completed&lt;/h2&gt;
        ///    &lt;p style=&apos;color: Black&apos;&gt;
        ///        Thank you, your transaction is complete for {org}.
        ///        You should receive a confirmation email at {email} shortly.&lt;br /&gt;&lt;br /&gt;
        ///    &lt;/p&gt;
        ///    &lt;p style=&apos;color: Blue&apos;&gt;&lt;a href=&apos;{url}&apos;&gt;Start a New Transaction&lt;/a&gt;&lt;/p&gt;.
        /// </summary>
        internal static string OnlineRegModel_ThankYouMessage {
            get {
                return ResourceManager.GetString("OnlineRegModel_ThankYouMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;{name},&lt;/p&gt;
        ///&lt;p&gt;You have been assigned to {org} in room {room}. The leader&apos;s name is {leader}.&lt;/p&gt;
        ///&lt;p&gt;Please call {phone} if you have any questions.&lt;/p&gt;
        ///&lt;p&gt;Please print this and bring it with you as a reminder of your room number.&lt;/p&gt;
        ///&lt;p&gt;Thank you!&lt;br/&gt;
        ///{church}&lt;/p&gt;.
        /// </summary>
        internal static string OrgMembersModel_SendMovedNotices {
            get {
                return ResourceManager.GetString("OrgMembersModel_SendMovedNotices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ReportsMenu&gt;
        ///  &lt;Header&gt;Statistics&lt;/Header&gt;
        ///  &lt;Report link=&quot;/Reports/VitalStats&quot;&gt;Vital Stats&lt;/Report&gt;
        ///  &lt;Space&gt;&lt;/Space&gt;
        ///  &lt;Header&gt;Attendance Summary&lt;/Header&gt;
        ///  &lt;Report link=&quot;/Reports/ChurchAttendance&quot; target=&quot;_blank&quot;&gt;Week at a Glance&lt;/Report&gt;
        ///  &lt;Report link=&quot;/Reports/ChurchAttendance2&quot; target=&quot;_blank&quot;&gt;Average Week at a Glance&lt;/Report&gt;
        ///  &lt;Space&gt;&lt;/Space&gt;
        ///  &lt;Header&gt;Decisions&lt;/Header&gt;
        ///  &lt;Report link=&quot;/Reports/WeeklyDecisions&quot; target=&quot;_blank&quot;&gt;Weekly Decisions&lt;/Rep [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReportsMenu {
            get {
                return ResourceManager.GetString("ReportsMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ReportsMenu&gt;
        ///  &lt;Column1&gt;
        ///&lt;!--
        ///    &lt;Header&gt;Statistics&lt;/Header&gt;
        ///    &lt;Report link=&quot;/Reports/VitalStats&quot;&gt;Vital Stats&lt;/Report&gt;
        ///--&gt;
        ///  &lt;/Column1&gt;
        ///  &lt;Column2&gt;
        ///  &lt;/Column2&gt;
        ///&lt;/ReportsMenu&gt;
        ///.
        /// </summary>
        internal static string ReportsMenuCustom {
            get {
                return ResourceManager.GetString("ReportsMenuCustom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Hi {first}
        ///
        ///Here is your confirmation for {org}.
        ///
        ///DETAILS: 
        ///{details}
        ///
        ///Your Ministry Team for {org}
        ///.
        /// </summary>
        internal static string SettingsRegistrationModel_DefaulConfirmation {
            get {
                return ResourceManager.GetString("SettingsRegistrationModel_DefaulConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Hi {first},&lt;/p&gt;
        ///
        ///&lt;p&gt;I need a substitute for {org}&lt;br&gt;
        ///
        ///on {meetingdate} at {meetingtime}&lt;/p&gt;
        ///
        ///&lt;p&gt;DO NOT REPLY. Instead, click one of the links below.&lt;/p&gt;
        ///&lt;blockquote&gt;
        ///
        ///&lt;p&gt;{yeslink}&lt;/p&gt;
        ///
        ///&lt;p&gt;{nolink}&lt;/p&gt;
        ///
        ///&lt;/blockquote&gt;
        ///
        ///&lt;p&gt;
        ///Thank you for your consideration,&lt;br /&gt;
        ///
        ///{sendername}
        ///&lt;/p&gt;.
        /// </summary>
        internal static string VolSubModel_ComposeMessage_Body {
            get {
                return ResourceManager.GetString("VolSubModel_ComposeMessage_Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///&lt;p&gt;Hi {first},&lt;/p&gt;
        ///&lt;p&gt;We need additional volunteers for {org}&lt;br&gt;
        ///on {meetingdate} at {meetingtime}&lt;/p&gt;
        ///
        ///&lt;p&gt;DO NOT REPLY. Instead, click one of the links below.&lt;/p&gt;
        ///&lt;blockquote&gt;
        ///&lt;p&gt;{yeslink}&lt;/p&gt;
        ///&lt;p&gt;{nolink}&lt;/p&gt;
        ///&lt;/blockquote&gt;
        ///&lt;p&gt;
        ///Thank you for your consideration,&lt;br /&gt;
        ///{sendername}
        ///&lt;/p&gt;.
        /// </summary>
        internal static string VolunteerRequestModel_ComposeMessage_Body {
            get {
                return ResourceManager.GetString("VolunteerRequestModel_ComposeMessage_Body", resourceCulture);
            }
        }
    }
}
