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
    public partial class User_Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["Login_Category"] + "").Equals("Admin"))
            {
                Session["Error"] = "You don't have enough Access Previlages";
                Server.Transfer(@"~/Error.aspx");
            }
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            if (Validate_UserId())
            {
                //Name_Exists.Text = "The Email ID:" + email.Text + " already exists";
                Session["Error"] = "Email Id:"+email.Text+" Already Exists";
                Server.Transfer(@"~/Error.aspx");
            }
            else
            {
                /*
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Global.Conn_String;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert into Employee (username,category,Eid,email,Dob,SkillSet,Exp)
                        Values('" + Name.Text + "','"+Desig_List.SelectedValue+"',"+Eid.Text+",'"+email.Text+"','"+DOB.Text+"','"+Skill_Set.ToString()+"',"+Experiance.Text+")";// and e.category='"+Category.SelectedValue+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                con.Open();*/
                int i=0;
                i = Global.Insert_Values("Employee", "username,category,Eid,email,Dob,SkillSet,Exp", @"'" + Name.Text + "','" + Desig_List.SelectedValue + "','" + Eid.Text + "','"+email.Text+"','"+DOB.Text+"','"+Skill_Set.ToString()+"','"+Experiance.Text+")"); //cmd.ExecuteNonQuery();
                if (i == 1)
                {

                }
                Global.con.Close();
            }
        }

        public bool Validate_UserId()
        {
            /*
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT username from Employee e where e.email='"+email.Text+"'";// and e.category='"+Category.SelectedValue+"'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();*/
            SqlDataReader dr= Global.Select_Where("Employee","username","email='"+email.Text+"'");
            //cmd.ExecuteNonQuery();
            if (dr.Read())
            {
                Global.con.Close();
                return true;
            }
            Global.con.Close();
            return false;
        }
        
    }
}
