﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CmsWeb.Models.SearchModel>" %>
<input type="hidden" name="m.type" value="<%=Model.type%>" />
<input type="hidden" name="m.typeid" value="<%=Model.typeid%>" />
<input type="hidden" name="m.from" value="<%=Model.from%>" />
<input type="hidden" name="m.name" value="<%=Model.name%>" />
<input type="hidden" name="m.dob" value="<%=Model.dob%>" />
<input type="hidden" name="m.address" value="<%=Model.address%>" />
<input type="hidden" name="m.phone" value="<%=Model.phone%>" />
<% 
    var n = 0;
    for (; n < Model.List.Count - 1; n++)
    {
        var p = Model.List[n];
        p.index = n;
        Html.RenderPartial("HiddenPerson", p);
    }
    var np = Model.List[n];
    np.index = n;
%>
<input type="hidden" name="m.List.Index" value="<%=n %>" />
<input type="hidden" name="m.List[<%=n %>].FamilyId" value="<%=np.FamilyId %>" />
<h4>Add Person To New Family</h4>
<a class="helplink" target="_blank" href='<%=Model.HelpLink("NewFamily") %>'>help</a>
<table width="100%">
<% Html.RenderPartial("EditPerson", np);
   Html.RenderPartial("EditAddress", np);
%>
</table>
<div align="right" >
<a href="/SearchAdd/AddNewFamily/" class="bt formlink default">Submit</a>
<a href="/SearchAdd/PersonCancel/<%=n %>" class="bt formlink" title="<%=Model.List.Count > 0 ? "back to selections" : "back to search person"%>">go back</a></td>
</div>