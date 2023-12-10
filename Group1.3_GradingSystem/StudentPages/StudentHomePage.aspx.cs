using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.StudentPages
{
	public partial class StudentHomePage : System.Web.UI.Page
	{

		protected void imgHISIcon_Click(object sender, EventArgs e)
		{
			Response.Redirect("StudentLoginPage.aspx");
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

		protected void Page_Load(object sender, EventArgs e)
		{
			StudentUser.Text = (string)Session["Username"];
		}
	}
}