using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RMS
{
    public partial class Req_Addtion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Go_Click(object sender, EventArgs e)
        {
            if (Req_list.SelectedIndex == 0)
                Server.Transfer(@"~/Project_Req_Add.aspx");
            else
                Server.Transfer(@"~/View_Projects.aspx");
        }
    }
}
