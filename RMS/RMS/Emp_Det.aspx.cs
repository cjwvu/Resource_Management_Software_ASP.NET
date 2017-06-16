using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RMS
{
    public partial class Emp_Det : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = Global.Select_Where("Employee"," Name,Desig,Exp,email,isAvailable,category ","Eid="+Request.QueryString["id"]);
            int i = 0;
            dr.Read();
            while (i<dr.FieldCount)
            {
                Label1.Text += "<br>"+dr[i].GetType()+": " + dr[i].ToString();
                i++;
            }
        }
    }
}
