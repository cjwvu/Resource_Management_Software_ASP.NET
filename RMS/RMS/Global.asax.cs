using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Data;

namespace RMS
{
    public class Global : System.Web.HttpApplication
    {
        public static string Conn_String="";
        public static SqlConnection con = new SqlConnection();
        public static SqlConnection con1 = new SqlConnection();
        protected void Application_Start(object sender, EventArgs e)
        {
            Conn_String = "Data Source=DS-E069959DBE11;Initial Catalog=StudentDb;Integrated Security=True";
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Login_Category"] = "";
            Session["Category"] = "";
            Session["Error"] = "No Error";
        }
        public static SqlDataReader Select(string Tab_Name,string Req_Var_List)
        {
            con.Close();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT "+Req_Var_List+" from "+Tab_Name+" ";// Employee e where "+Condition+"";// and e.category='"+Category.SelectedValue+"'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        
        public static SqlDataReader Select_Where(string Tab_Name,string Req_Var_List,string Condition)
        {
            con.Close();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT "+Req_Var_List+" from "+Tab_Name+" where "+Condition+"";// Employee e where "+Condition+"";// and e.category='"+Category.SelectedValue+"'";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            return dr;
        }
        public static int Insert(string Tab_Name,params string[] Values)
        {
            con.Close();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Insert into "+Tab_Name+" Values(";   //Employee (" + Var_List + ") Values(";
            foreach (string s in Values)
            {
                cmd.CommandText += s;
            }
            cmd.CommandText += ")";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            int i = 0;
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public static int Insert_Values(string Tab_Name,string Var_List,params string[] Values)
        {
            con.Close();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Insert into "+Tab_Name+" ("+Var_List+") Values(";   //Employee (" + Var_List + ") Values(";
            foreach (string s in Values)
            {
                cmd.CommandText += s;
            }
            cmd.CommandText += ")";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            int i = 0;
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public static int Update(string Tab_Name,string Values, string condition)
        {
            con.Close();
            con.ConnectionString = Global.Conn_String;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update "+Tab_Name+" set "+Values+" where "+condition;   //Employee set "+Values+" where " + condition;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            con.Open();
            int i = 0;
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}