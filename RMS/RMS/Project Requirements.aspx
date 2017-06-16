<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Project Requirements.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 40px">
    
        <br />
        <br /><h1>Project Requirements</h1>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Requirement details will be displayed below.<br />
        
        <br />
        <br />
        <asp:Table ID="Table2" runat="server" BorderStyle="Double" GridLines="Vertical" 
            HorizontalAlign="Left" Width="1095px">
             <asp:TableRow ID="TableRow1" runat="server" BorderStyle="Double">
            <asp:TableHeaderCell>Project Name</asp:TableHeaderCell><asp:TableCell Width="500"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow ID="TableRow2" runat="server" BorderStyle="Double">
             <asp:TableHeaderCell>Project Code</asp:TableHeaderCell><asp:TableCell><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow ID="TableRow3" runat="server" BorderStyle="Double">
             <asp:TableHeaderCell>Location</asp:TableHeaderCell><asp:TableCell><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow ID="TableRow4" runat="server" BorderStyle="Double">
             <asp:TableHeaderCell>Project Type</asp:TableHeaderCell><asp:TableCell><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
        
        </asp:Table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" GridLines="Both" Width="1098px">
            <asp:TableRow runat="server" BorderStyle="Double">
            <asp:TableHeaderCell>S.No</asp:TableHeaderCell><asp:TableHeaderCell>Designation</asp:TableHeaderCell><asp:TableHeaderCell>Skill Set</asp:TableHeaderCell><asp:TableHeaderCell>Exp. in mths</asp:TableHeaderCell><asp:TableHeaderCell>No of candidates</asp:TableHeaderCell><asp:TableHeaderCell>Last Date</asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
