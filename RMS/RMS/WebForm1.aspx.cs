using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Project_Opportunities : System.Web.UI.Page
{
    int size = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataReader dr = RMS.Global.Select_Where("Employee e,[Project Details] p", "e.isAssigned,p.Name,p.Code,p.Location,p.Type,p.[Last Date]", "e.isAssigned ='true'");
        SqlDataReader dr2 = RMS.Global.Select_Where("[Requirement Details] r,[Project Details] p", "r.Designation", "p.Code=r.Code");
        int i = 0;
        RMS.Global.con.Open();
        Table t = new Table();
        Button[] a = new Button[10];
        while (dr.Read() && dr2.Read())
        {
            TableRow tr = new TableRow();
            TableCell c1 = new TableCell();
            TableCell c2 = new TableCell();
            TableCell c3 = new TableCell();
            TableCell c4 = new TableCell();
            TableCell c5 = new TableCell();
            TableCell c6 = new TableCell();
            TableCell c7 = new TableCell();
            TableCell c8 = new TableCell();
            c1.Controls.Add(new LiteralControl(dr[0].ToString()));
            c2.Controls.Add(new LiteralControl(dr[1].ToString()));
            c3.Controls.Add(new LiteralControl(dr[2].ToString()));
            c4.Controls.Add(new LiteralControl(dr[3].ToString()));
            c5.Controls.Add(new LiteralControl(dr[4].ToString()));
            c6.Controls.Add(new LiteralControl(dr2[0].ToString()));
            a[i] = new Button();
            a[i].Text = "Accept";
            i++;
            c7.Controls.Add(a[i]);
            a[i].OnClientClick = "Accept_Click";
            c7.Controls.Add(new LiteralControl("   "));
            a[i] = new Button();
            a[i].OnClientClick = "Reject_Click";
            a[i].Text = "Reject";
            c7.Controls.Add(a[i]);
            tr.Cells.Add(c1);
            tr.Cells.Add(c2);
            tr.Cells.Add(c3);
            tr.Cells.Add(c4);
            tr.Cells.Add(c5);
            tr.Cells.Add(c6);
            tr.Cells.Add(c7);
            tr.Cells.Add(c8);
            t.Rows.Add(tr);
        }
        size = i + 1;

        RMS.Global.con.Close();

    }

    protected void Accept_Click(object sen, EventArgs e)
    {

    }

    protected void Reject_Click(object sen, EventArgs e)
    {

    }
}
