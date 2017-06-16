using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace RMS
{
    public partial class ViewProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!(Session["Login_Category"] + "").Equals("Resource Manager") && !(Session["Login_Category"] + "").Equals("Project Manager"))
            //{
            //    Session["Error"] = "You don't have enough Access Previlages";
            //    Server.Transfer(@"~/Error.aspx");
            //}
            SqlDataReader dr= RMS.Global.Select("Project_Details","Name,Code,Last_Date");
            Table PList = new Table();
            TableRow t1 = new TableRow();
            TableCell C = new TableCell();
            C.Controls.Add(new LiteralControl("Projects"));
            t1.Cells.Add(C); C = new TableCell();
            C.Controls.Add(new LiteralControl("Requirement Details"));
            t1.Cells.Add(C); C = new TableCell();
            C.Controls.Add(new LiteralControl("Last Date"));
            t1.Cells.Add(C); C = new TableCell();
            PList.Rows.Add(t1);

            while (dr.Read())
            {
                TableRow r1=new TableRow();
                TableCell c1 = new TableCell();
                HyperLink H1 = new HyperLink();
                H1.Text = dr[0].ToString();
                H1.NavigateUrl = "~/Emp_Availabe.aspx?pname="+H1.Text;
                if ((Session["Login_Category"] + "").Equals("Project Manager"))
                    H1.Enabled = false;
                HyperLink H2 = new HyperLink();
                H2.Text = "more Details";
                H2.NavigateUrl = "~/Proj_Req?pname="+H1.Text;
                c1.Controls.Add(H1);
                c1.Controls.Add(new LiteralControl("<br><br>"));
                c1.Controls.Add(H2);
                //c1.Controls.Add(new LiteralControl(dr[0].ToString()));
                r1.Cells.Add(c1);
                c1 = new TableCell();
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = RMS.Global.Conn_String;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT SkillSet,Exp,No_Candidates from Req_Details where code=" + dr[1].ToString() + "";// Employee e where "+Condition+"";// and e.category='"+Category.SelectedValue+"'";
                cmd.Connection = con1;
                cmd.CommandType = CommandType.Text;
                con1.Open();
                SqlDataReader dr1 = cmd.ExecuteReader();
                Table inner_Table = new Table();
                TableRow ir = new TableRow();
                TableCell ic = new TableCell();

                ic.Controls.Add(new LiteralControl("Skill Set"));
                ir.Cells.Add(ic); ic = new TableCell();
                ic.Controls.Add(new LiteralControl("Exp"));
                ir.Cells.Add(ic); ic = new TableCell();
                ic.Controls.Add(new LiteralControl("No. of Candidates"));
                ir.Cells.Add(ic); ic = new TableCell();
                inner_Table.Rows.Add(ir);
                while (dr1.Read())
                {
                    ir = new TableRow();
                    ic.Controls.Add(new LiteralControl(dr1[0].ToString()));
                    ir.Cells.Add(ic); ic = new TableCell();
                    ic.Controls.Add(new LiteralControl(dr1[1].ToString()));
                    ir.Cells.Add(ic); ic = new TableCell();
                    ic.Controls.Add(new LiteralControl(dr1[2].ToString()));
                    ir.Cells.Add(ic); ic = new TableCell();
                    inner_Table.Rows.Add(ir);
                }
                inner_Table.Visible = true;
                inner_Table.CellPadding = 5;
                inner_Table.CellSpacing = 5;
                inner_Table.BorderStyle = BorderStyle.Ridge;
                inner_Table.GridLines = GridLines.Both;
                c1.Controls.Add(inner_Table);
                r1.Cells.Add(c1);
                c1 = new TableCell();
                c1.Controls.Add(new LiteralControl(dr[2].ToString()));
                r1.Cells.Add(c1);
                PList.Rows.Add(r1);
                PList.BorderStyle = BorderStyle.Solid;
                PList.GridLines = GridLines.Both;
                //Page.Controls.Add(PList);
                PL.Controls.Add(PList);
                dr1.Close();
                con1.Close();
            }
                dr.Close();
                Global.con.Close();
          }
    }
}

