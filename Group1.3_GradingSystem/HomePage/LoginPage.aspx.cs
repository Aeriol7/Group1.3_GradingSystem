using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group1._3_GradingSystem.TeacherPages;

namespace Group1._3_GradingSystem.HomePage
{
	public partial class LoginPage : System.Web.UI.Page
	{
		public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
		public void btnLogin_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(conStr);
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
					Session["Username"] = dt.Rows[0][1].ToString();
					Session["CurrentUser"] = dt.Rows[0][0].ToString();
					Response.Redirect("~/AdminPages/AdminHome.aspx");
				}
				else if (dt.Rows[0][3].ToString() == "Teacher")
				{
					SqlConnection con1 = new SqlConnection(conStr);
					con.Open();
					SqlCommand cmd1 = new SqlCommand("SELECT * FROM teachers WHERE user_id=@userid", con);
					cmd1.Parameters.AddWithValue("@userid", dt.Rows[0][0].ToString());
					SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
					DataTable dt1 = new DataTable();
					sda1.Fill(dt1);
					cmd1.ExecuteNonQuery();
					Session["Username"] = dt1.Rows[0][1].ToString() + " " + dt1.Rows[0][2].ToString();
					Session["CurrentTeacherUser"] = dt1.Rows[0][0].ToString();
					con.Close();
					Response.Redirect("~/TeacherPages/TeacherHomePage.aspx");
				}
				else if (dt.Rows[0][3].ToString() == "Student")
				{
					SqlConnection con1 = new SqlConnection(conStr);
					con.Open();
					SqlCommand cmd1 = new SqlCommand("SELECT * FROM students WHERE user_id=@userid", con);
					cmd1.Parameters.AddWithValue("@userid", dt.Rows[0][0].ToString());
					SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
					DataTable dt1 = new DataTable();
					sda1.Fill(dt1);
					cmd1.ExecuteNonQuery();
					Session["Username"] = dt1.Rows[0][1].ToString() + " " + dt1.Rows[0][2].ToString();
					Session["CurrentStudentUser"] = dt1.Rows[0][0].ToString();
					con.Close();
					Response.Redirect("~/StudentPages/StudentHomePage.aspx");
				}
			}
			else
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Invalid Login');", true);
			}
		}
	}
}