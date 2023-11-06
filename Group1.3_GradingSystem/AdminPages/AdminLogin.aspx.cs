using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.AdminPages
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList1.SelectedIndex == 1)
			{
				Response.Redirect("~/TeacherPages/TeacherLoginPage.aspx");
			}
			else if (DropDownList1.SelectedIndex == 2)
			{
				Response.Redirect("~/StudentPages/StudentLoginPage.aspx");
			}
		}
	}
}