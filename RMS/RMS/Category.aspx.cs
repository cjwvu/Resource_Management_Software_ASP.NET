using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RMS
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string category = Session["Login_Category"] + "";
            log_cat.Text = category;
            if (!IsPostBack)
            {
                categ.Text += Session["Category"] + "";
            }
            Task_List.Items[0].Enabled = false;
            Task_List.Items[2].Enabled = false;
            if (category.Equals("Admin"))
            {
                Task_List.Items[0].Enabled = true;
                Task_List.Items[3].Enabled = false;
            }
            else if (category.Equals("Project Manager"))
            {
                Task_List.Items[2].Enabled = true;
            }
            //else if (category.Equals("Resource Manager"))
            //{
            //}
        }

        protected void Go_Button_Click(object sender, EventArgs e)
        {
            if (Task_List.SelectedIndex == 0)
                Server.Transfer(@"~/User_Create.aspx");
            else if (Task_List.SelectedIndex == 1)
                Server.Transfer(@"~/Skill_Update.aspx");
            else if (Task_List.SelectedIndex == 2)
                Server.Transfer(@"~/Req_Add.aspx");
            else if (Task_List.SelectedIndex == 3)
                Server.Transfer(@"~/Skill_Mapping.aspx");
        }
    }
}
