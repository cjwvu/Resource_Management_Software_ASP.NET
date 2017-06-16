using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RMS
{
    public partial class Emp_Available : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = Global.Select_Where("Employee","Eid,SkillSet,Exp", "isAvailable = 'true'");
            
            Table t = new Table();
            TableRow R = new TableRow();
            TableCell C = new TableCell();
            C.Controls.Add(new LiteralControl("Employee ID"));
            R.Cells.Add(C);
            C = new TableCell();
            C.Controls.Add(new LiteralControl("Skill Set"));
            R.Cells.Add(C);
            C = new TableCell();
            C.Controls.Add(new LiteralControl("Experience"));
            R.Cells.Add(C);
            C = new TableCell();
            C.Controls.Add(new LiteralControl("Assign"));
            R.Cells.Add(C);
            t.Rows.Add(R);

            while (dr.Read())
            {
                R = new TableRow();
                C = new TableCell();
                HyperLink H = new HyperLink();
                H.Text = dr[0].ToString();
                H.NavigateUrl = "~/Emp_Det.aspx?id="+H.Text+"";
                C.Controls.Add(H);
                R.Cells.Add(C);
                C = new TableCell();
                C.Controls.Add(new LiteralControl(""+dr[1]));
                R.Cells.Add(C);
                C = new TableCell();
                C.Controls.Add(new LiteralControl(""+dr[2]));
                R.Cells.Add(C);
                C = new TableCell();
                CheckBox Cb = new CheckBox();
                Cb.ID = dr[0].ToString();
                C.Controls.Add(Cb);
                R.Cells.Add(C);
                t.Rows.Add(R);
            }
            t.GridLines = GridLines.Both;
            PL.Controls.Add(t);
            dr.Close();
            Global.con.Close();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string pname = Request.QueryString["pname"];

        }
    }
}
