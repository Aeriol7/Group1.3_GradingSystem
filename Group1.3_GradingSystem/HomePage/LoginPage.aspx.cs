using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.HomePage
{
	public partial class LoginPage : System.Web.UI.Page
	{
		protected void btnLogin_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username=@username and password=@password", con);
			cmd.Parameters.AddWithValue("@username", txtUser.Text);
			cmd.Parameters.AddWithValue("@password", txtPass.Text);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			con.Close();

			if (dt.Rows.Count > 0)
			{
				if (dt.Rows[0][3].ToString() == "Admin")
				{
					Response.Redirect("~/AdminPages/AdminHome.aspx");
				}
				else if (dt.Rows[0][3].ToString() == "Teacher")
				{
					Response.Redirect("~/TeacherPages/TeacherHomePage.aspx");
				}
				else if (dt.Rows[0][3].ToString() == "Student")
				{
					Response.Redirect("~/StudentPages/StudentHomePage.aspx");
				}
			}
			else
			{

			}

			//Response.Redirect("TeacherHomePage.aspx");
		}

	}
}