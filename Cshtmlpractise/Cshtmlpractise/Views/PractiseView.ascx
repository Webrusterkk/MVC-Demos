<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%Html.ValidationSummary(true); %>

<fieldset>
        <legend>Log in Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" ID="lbllogin" Text= "UserName"></asp:Label>
                <asp:TextBox runat="server" ID="txtlogin"></asp:TextBox>
              
            </li>
            <li>
                @Html.LabelFor(m => m.Password)
                @Html.PasswordFor(m => m.Password)
                @Html.ValidationMessageFor(m => m.Password)
            </li>
            <li>
                @Html.CheckBoxFor(m => m.RememberMe)
                @Html.LabelFor(m => m.RememberMe, new { @class = "checkbox" })
            </li>
        </ol>
    </fieldset>