using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.HomePage
{
    public partial class HomePage : System.Web.UI.Page
    {
		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList1.SelectedIndex == 1)
			{
				Response.Redirect("~/AdminPages/AdminLogin.aspx");
			}
			else if (DropDownList1.SelectedIndex == 2)
			{
				Response.Redirect("~/TeacherPages/TeacherLoginPage.aspx");
			}
			else if (DropDownList1.SelectedIndex == 3)
			{
				Response.Redirect("~/StudentPages/StudentLoginPage.aspx");
			}
		}
	}
}