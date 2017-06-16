using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection();//estblish connection
        con.ConnectionString = "Data Source=DS-E069959DBE9E;Initial Catalog=Course;Integrated Security=True";
        SqlConnection con2 = new SqlConnection();//estblish connection
        con2.ConnectionString = "Data Source=DS-E069959DBE9E;Initial Catalog=Course;Integrated Security=True";

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT Designation,[Skill set],[Exp in mths],[No of candidates] from [Requirement Details]";
        cmd.Connection = con;//establist connection wid command
        cmd.CommandType = CommandType.Text;
        SqlCommand cmd2 = new SqlCommand();
        cmd2.CommandText = "SELECT [Last Date] from [Project Details]";
        cmd2.Connection = con2;//establist connection wid command
        cmd2.CommandType = CommandType.Text;

        con.Open();
        con2.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        SqlDataReader dr2 = cmd2.ExecuteReader();

        Table t = new Table();
        int serial_no = 1;
        while (dr.Read())//read the first row of the table.. then sec..so on..till false
        {
            TableRow tr = new TableRow();
            TableCell c1 = new TableCell();
            TableCell c2 = new TableCell();
            TableCell c3 = new TableCell();
            TableCell c4 = new TableCell();
            TableCell c5 = new TableCell();
            TableCell c6 = new TableCell();
            TableCell c7 = new TableCell();
            c1.Controls.Add(new LiteralControl(serial_no+""));
            c2.Controls.Add(new LiteralControl(dr[0].ToString()));
            c3.Controls.Add(new LiteralControl(dr[1].ToString()));
            c4.Controls.Add(new LiteralControl(dr[2].ToString()));
            c5.Controls.Add(new LiteralControl(dr[3].ToString()));
            c6.Controls.Add(new LiteralControl(dr[4].ToString()));
            c7.Controls.Add(new LiteralControl(dr2[5].ToString()));
            tr.Cells.Add(c1);
            tr.Cells.Add(c2);
            tr.Cells.Add(c3);
            tr.Cells.Add(c4);
            tr.Cells.Add(c5);
            tr.Cells.Add(c6);
            tr.Cells.Add(c7);
            t.Rows.Add(tr);
            serial_no++;
        }
        con.Close();// button click submits data into the database
    }
}
