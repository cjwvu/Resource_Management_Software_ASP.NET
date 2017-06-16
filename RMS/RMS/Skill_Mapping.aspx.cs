using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RMS
{
    public partial class Skill_Mapping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["Login_Category"] + "").Equals("Employee"))
                Task_List.Items[1].Enabled = false;
            else
                Task_List.Items[0].Enabled = false;
        }

        protected void Go_Click(object sender, EventArgs e)
        {
            if (Task_List.SelectedIndex == 0)
                Server.Transfer(@"~/View_Projects.aspx");
            else
                Server.Transfer(@"~/Project_Opp.aspx");
        }
    }
}
