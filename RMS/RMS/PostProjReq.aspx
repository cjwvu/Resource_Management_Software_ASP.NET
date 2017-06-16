<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostProjReq.aspx.cs" Inherits="RMS.PostProjReq" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 40px">
    
        Post Project Requirement&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server">Home</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server">Logout</asp:HyperLink>
        <br />
        <br />
        Enter the Details Below.<br />
        <br />
        Project Name:&nbsp;&nbsp;
        <asp:TextBox ID="Proj_Name" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        Project Code:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Proj_Code" runat="server" ></asp:TextBox>
        <br />
        Location:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Location" runat="server"></asp:TextBox>
        <br />
        Project Type:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Type_List" runat="server">
            <asp:ListItem>Development</asp:ListItem>
            <asp:ListItem>Testing</asp:ListItem>
            <asp:ListItem>Maintainance</asp:ListItem>
            <asp:ListItem>Support</asp:ListItem>
        </asp:DropDownList>
        <br />
        Last Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="Last_Date" runat="server"></asp:TextBox>
        <br />
        <br />
        S.No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Designation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Skill Set&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Exp. in Months&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No of Candidates<br />
        <asp:TextBox ID="sno1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Desig1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SkillSet1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Exp1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="No1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="sno2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Desig2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SkillSet2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Exp2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="No2" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="sno3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Desig3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SkillSet3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Exp3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="No3" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="sno4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Desig4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SkillSet4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Exp4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="No4" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="sno5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Desig5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="SkillSet5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Exp5" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="No5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Post" runat="server" Text="Post" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
