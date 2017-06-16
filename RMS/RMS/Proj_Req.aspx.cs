using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Page16
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DS-E0699598D787;Initial Catalog=StudentDB;Integrated Security=True";
            //SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "SELECT sid, age, sname FROM Student";
            //cmd.Connection = con;
            //cmd.CommandType = CommandType.Text;
            //con.Open();
            SqlDataReader dr = RMS.Global.Select("Project_Details","Name,Code,Location,Type");//cmd.ExecuteReader();
            nam
            Table t = new Table();
            TableRow R = new TableRow();
            TableCell C = new TableCell();


            dr.Close();
            RMS.Global.con.Close();
            TableRow t1 = new TableRow();
            TableCell[] tc1 = new TableCell[dr.FieldCount];

            for (int z = 0; z < dr.FieldCount; z++)
            {
                tc1[z] = new TableCell();
                tc1[z].Controls.Add(new LiteralControl(dr.GetName(z)));
                t1.Controls.Add(tc1[z]);
            }
            Table1.Rows.Add(t1);

            while (dr.Read())
            {
                TableRow tr = new TableRow();
                TableCell[] c1 = new TableCell[dr.FieldCount];

                for (int i = 0; i <= c1.Length - 1; i++)
                {
                    c1[i] = new TableCell();
                }

                for (int j = 0; j <= c1.Length-1; j++)
                {
                    c1[j].Controls.Add(new LiteralControl(dr[j].ToString()));

                }
                
                for (int k = 0; k <= c1.Length - 1; k++)
                    tr.Cells.Add(c1[k]);

                Table1.Rows.Add(tr);
            }

        }
    }
}
