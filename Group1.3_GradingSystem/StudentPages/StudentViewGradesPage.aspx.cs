using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.StudentPages
{
	public partial class StudentViewGradesPage : System.Web.UI.Page
	{

		protected void ddlLogout_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }
    }
}