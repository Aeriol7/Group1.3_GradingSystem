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

			SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
			SqlCommand cmd = new SqlCommand("select * from tbl_data where username=@username and word=@word", con);
			cmd.Parameters.AddWithValue("@username", txtUser.Text);
			cmd.Parameters.AddWithValue("@password", txtPass.Text);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			con.Open();
			int i = cmd.ExecuteNonQuery();
			con.Close();

			//Response.Redirect("TeacherHomePage.aspx");
		}

	}
}