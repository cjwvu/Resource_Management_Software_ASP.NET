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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Login_Category"] = "";
            Session["Category"] = "";
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT password,category from Employee e where e.username='" + user_name.Text + "'";// and e.category='"+Category.SelectedValue+"'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();*/
            SqlDataReader dr = Global.Select_Where("Employee", "password,category", "username='" + user_name.Text + "'");
            //cmd.ExecuteNonQuery();
            if (dr.Read())
            {
                if (dr[0].ToString().Equals(password.Text))
                {
                    Session["Login_Category"] = Category.SelectedValue;
                    Session["Category"] = dr[1].ToString();
                    Session["username"] = user_name.Text;
                    if (dr[1].ToString().Equals(Category.SelectedValue))
                        Server.Transfer(@"~/Category.aspx");
                    else if (!(dr[1].ToString().Equals("Employee")) && Category.SelectedValue.Equals("Employee"))
                        Server.Transfer(@"~/Category.aspx");
                    else
                    {
                        Invalid_Login.Text = "You don't have enough access previlages";
                        Category.SelectedIndex = -1;
                    }
                }
                else
                {
                    Reset();
                }
            }
            else
            {
            }
            dr.Close();
            Global.con.Close();
        }

        protected void Re_set_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            user_name.Text = "";
            password.Text = "";
            Category.SelectedIndex = -1;
        }

    }
}
