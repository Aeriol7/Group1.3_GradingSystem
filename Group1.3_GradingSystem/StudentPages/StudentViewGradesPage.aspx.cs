using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;
using System.Reflection;

namespace Group1._3_GradingSystem.StudentPages
{
	public partial class StudentViewGradesPage : System.Web.UI.Page
	{
		public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

		protected void Button1_Click(object sender, EventArgs e)
		{
			Response.Redirect("/HomePage/LoginPage.aspx");
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			StudentInfo();
			StudentGrades();
		}

		public void StudentInfo()
		{
			SqlConnection con = new SqlConnection(conStr);
			SqlCommand cmdsi = new SqlCommand("SELECT students.first_name, students.last_name, sections.section, year_levels.year_level, school_years.school_year FROM students " +
				"INNER JOIN sections ON students.section_id = sections.section_id " +
				"INNER JOIN year_levels ON students.year_level_id = year_levels.year_level_id " +
				"INNER JOIN school_years ON students.school_year_id = school_years.school_year_id " +
				"WHERE student_id=@studentid", con);
			cmdsi.Parameters.AddWithValue("@studentid", Session["CurrentStudentUser"]);
			SqlDataAdapter adptsi = new SqlDataAdapter(cmdsi);
			DataTable dtsi = new DataTable();
			adptsi.Fill(dtsi);
			lblStudentName.Text = dtsi.Rows[0][1].ToString() + ", " + dtsi.Rows[0][0].ToString();
			lblStudentSection.Text = dtsi.Rows[0][2].ToString();
		}

        public void StudentGrades()
        {
			SqlConnection con = new SqlConnection(conStr);
			SqlCommand cmd = new SqlCommand("SELECT subjects.subject_name, " +
				"grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks FROM grades " +
				"INNER JOIN students ON grades.student_id=students.student_id " +
				"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
				"WHERE grades.student_id=@studentid AND grades.school_year_id=students.school_year_id AND grades.section_id=students.section_id AND grades.year_level_id=students.year_level_id AND grades.approval='Approved'", con);
			cmd.Parameters.AddWithValue("@studentid", Session["CurrentStudentUser"]);
			SqlDataAdapter adpt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			if (dt.Rows.Count <= 0)
			{
				gvGrades.DataSource = null;
				gvGrades.DataBind();
				SNotYetReleased.Text = "Grades Not Yet Released";
			}
			else
			{
				gvGrades.DataSource = dt;
				gvGrades.DataBind();
			}
			con.Close();
		}
		protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gvGrades.PageIndex = e.NewPageIndex;
			this.StudentGrades();
		}
		protected void gvGrades_RowDataBound(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "Subject";
				e.Row.Cells[1].Text = "1st Quarter";
				e.Row.Cells[2].Text = "2nd Quarter";
				e.Row.Cells[3].Text = "3rd Quarter";
				e.Row.Cells[4].Text = "4th Quarter";
				e.Row.Cells[5].Text = "Average";
				e.Row.Cells[6].Text = "Remarks";
			}
		}
	}
}