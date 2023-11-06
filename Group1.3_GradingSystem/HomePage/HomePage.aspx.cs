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
		protected void btnLogin_Click(object sender, EventArgs e)
		{
			Response.Redirect("LoginPage.aspx");
		}
	}
}