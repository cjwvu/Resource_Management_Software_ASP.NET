<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Skill_Update.aspx.cs" Inherits="RMS.Skill_Update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 155px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Home" NavigateUrl="~/Category.aspx" runat="server">Home</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="Logout" NavigateUrl="~/Login.aspx" runat="server">Logout</asp:HyperLink>
    
    </div>
    <h3>
        Employee Details:</h3>
    <p>
        &nbsp;</p>
    <p>
        Only Skill Set and Experience can be updated</p>
        <table class="style1">
            <tr>
                <td class="style2">
&nbsp;Name&nbsp;</td>
                <td>
                    &nbsp;<asp:Label ID="name" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Employee ID</td>
                <td>
                    <asp:Label ID="id" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    E-Mail ID</td>
                <td>
                    <asp:Label ID="email" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Date of Birth</td>
                <td>
                    <asp:Label ID="dob" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Skill Set</td>
                <td>
                    <textarea id="Skill_Set" runat="server" cols="20" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="style2">
                    Experiance in months</td>
                <td>
                    <asp:TextBox ID="Experiance" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Designation</td>
                <td>
                    <asp:Label ID="desig" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        &nbsp;<br />
    \&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Update" runat="server" onclick="Update_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Cancel" runat="server" Text="Cancel" />
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Res" runat="server" style="color: #FF0000"></asp:Label>
    </p>
    </form>
</body>
</html>
