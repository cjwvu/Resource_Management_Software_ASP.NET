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
    public partial class Skill_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Login_Category"] + "").Equals(""))
            {
                Session["Error"] = "You don't have enough Access Previlages";
                Server.Transfer(@"~/Error.aspx");
            }
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = Global.Conn_String;
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT Eid,email,Dob,category from Employee e where e.username='" + (Session["username"]+"")+ "'";// and e.category='"+Category.SelectedValue+"'";
            //cmd.Connection = con;
            //cmd.CommandType = CommandType.Text;
            //con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            Global.con.Close();
            SqlDataReader dr= Global.Select_Where("Employee","Eid,email,Dob,category","username='" + Session["username"]+ "'");
            if (dr.Read())
            {
                name.Text = Session["username"] + "";
                id.Text = dr[0].ToString();
                email.Text = dr[1].ToString();
                dob.Text = dr[2].ToString();
                desig.Text = dr[3].ToString();
            }
            dr.Close();
            Global.con.Close();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            Global.con.Close();
            if (Global.Update("Employee",("SkillSet='"+Skill_Set.Value+"',Exp="+Experiance.Text+""),("username='"+Session["username"]+"'"))==1)
            {
                Res.Text = "Skill Set and Experience Updated Successfully";
            }
            else
                Res.Text = "Skill Set and Experience Not Updated";
            Global.con.Close();
        }
    }
}
