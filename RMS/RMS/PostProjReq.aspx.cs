using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RMS
{
    public partial class PostProjReq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Post_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Global.Insert("Project_Det", " name=" + Proj_Name.Text + " code="+Proj_Code.Text+" Location="+Location.Text+" type="+Type_List.SelectedValue+"last_date"+Last_Date.Text+"");
            if (i == 1)
            {

            }
            Global.Insert("Req_det", "Code=" + sno1.Text + " Desig=" + Desig1.Text + " SkillSet" + SkillSet1.Text + " Exp=" + Exp1.Text + "");
            Global.Insert("Req_det", "Code=" + sno2.Text + " Desig=" + Desig2.Text + " SkillSet" + SkillSet2.Text + " Exp=" + Exp2.Text + "");
            Global.Insert("Req_det", "Code=" + sno3.Text + " Desig=" + Desig3.Text + " SkillSet" + SkillSet3.Text + " Exp=" + Exp3.Text + "");
            Global.Insert("Req_det", "Code=" + sno4.Text + " Desig=" + Desig4.Text + " SkillSet" + SkillSet4.Text + " Exp=" + Exp4.Text + "");
            Global.Insert("Req_det", "Code=" + sno5.Text + " Desig=" + Desig5.Text + " SkillSet" + SkillSet5.Text + " Exp=" + Exp5.Text + "");
        }
    }
}