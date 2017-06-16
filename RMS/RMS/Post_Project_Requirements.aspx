<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Page112._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server">Home</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server">Logout</asp:HyperLink>
        <br />
        Post Project Requirement         <br />
        <br />
        Enter the details below:<br />
        <br />
        <table class="style1">
            <tr>
                <td>
                    Project Name:</td>
                <td>
                    <asp:TextBox ID="Proj_Name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Project Code:</td>
                <td>
                    <asp:TextBox ID="Proj_Code" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Location:</td>
                <td>
                    <asp:TextBox ID="Location" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Project Type
                </td>
                <td>
                    <asp:DropDownList ID="Type_List" runat="server">
                        <asp:ListItem>Development</asp:ListItem>
                        <asp:ListItem>Testing</asp:ListItem>
                        <asp:ListItem>Maintainance</asp:ListItem>
                        <asp:ListItem>Support</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Last Date:</td>
                <td>
                    <asp:TextBox ID="Last_Date" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    <table class="style1">
        <tr>
            <td>
                S.No</td>
            <td>
                Designation</td>
            <td>
                Skill Set</td>
            <td>
                Exp. in Months</td>
            <td>
                No of Candidates</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="sno1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Desig1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="SkillSet1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Exp1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="No1" runat="server" Height="25px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="sno2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Desig2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="SkillSet2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Exp2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="No2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="sno3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Desig3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="SkillSet3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Exp3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="No3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="sno4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Desig4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="SkillSet4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Exp4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="No4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="sno5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Dseig5" runat="server"></asp:TextBox>
            </td>
            <td style="font-weight: 700">
                <asp:TextBox ID="SkillSet5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Exp5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="No5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Button ID="Post" OnClick="Post_Click" runat="server" Text="Post" style="height: 29px" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
