using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.TeacherPages
{
	public partial class TeacherHomePage : System.Web.UI.Page
	{
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

		protected void Page_Load(object sender, EventArgs e)
		{
			TeacherUser.Text = (string)Session["Username"];
		}
	}
}