using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics.Tracing;

namespace Group1._3_GradingSystem.TeacherPages
{
	public partial class TeacherGradesPage : System.Web.UI.Page
	{

		public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		public void Grades()
		{
			if (ddlSortAZ.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(conStr);
				SqlCommand cmd = new SqlCommand("SELECT subjects.subject_name, students.last_name, students.first_name, " +
					"grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks, grades.approval FROM grades " +
					"INNER JOIN students ON grades.student_id=students.student_id " +
					"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
					"WHERE subjects.subject_id=@subjectid AND subjects.teacher_id=@teacherid " +
					"ORDER BY last_name ASC", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentTeacherUser"]);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvGrades.DataSource = dt;
				gvGrades.DataBind();
				if (dt.Rows.Count <= 0)
				{
					gvGrades.DataSource = null;
					gvGrades.DataBind();
					TGNoRecordsLabel.Text = "No Records";
				}
				con.Close();
			}
			else if (ddlSortAZ.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(conStr);
				SqlCommand cmd = new SqlCommand("SELECT subjects.subject_name, students.last_name, students.first_name, " +
					"grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks, grades.approval FROM grades " +
					"INNER JOIN students ON grades.student_id=students.student_id " +
					"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
					"WHERE subjects.subject_id=@subjectid AND subjects.teacher_id=@teacherid " +
					"ORDER BY last_name DESC", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentTeacherUser"]);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvGrades.DataSource = dt;
				gvGrades.DataBind();
				if (dt.Rows.Count <= 0)
				{
					gvGrades.DataSource = null;
					gvGrades.DataBind();
					TGNoRecordsLabel.Text = "No Records";
				}
				con.Close();
			}
		}
		protected void ddlSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conStr);
			string com = "SELECT * FROM year_levels";
			SqlDataAdapter adpt = new SqlDataAdapter(com, con);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlGradeLevel.DataSource = dt;
			ddlGradeLevel.DataTextField = "year_level";
			ddlGradeLevel.DataValueField = "year_level_id";
			ddlGradeLevel.DataBind();
			ddlGradeLevel.Items.Insert(0, new ListItem("Select Grade", "0"));
			ddlSection.SelectedIndex = 0;
			ddlSubjects.SelectedIndex = 0;
			ddlGradeLevel.SelectedIndex = 0;
			ddlGradeLevel.Enabled = true;
			Grades();
			ddlSortAZ.SelectedIndex = 0;
		}
		protected void ddlGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conStr);
			SqlCommand cmd = new SqlCommand("SELECT * FROM sections WHERE year_level_id=@yearlevelid", con);
			cmd.Parameters.AddWithValue("@yearlevelid", ddlGradeLevel.SelectedValue);
			SqlDataAdapter adpt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlSection.DataSource = dt;
			ddlSection.DataTextField = "section";
			ddlSection.DataValueField = "section_id";
			ddlSection.DataBind();
			ddlSection.Items.Insert(0, new ListItem("Select Section"));
			ddlSubjects.SelectedIndex = 0;
			ddlSection.SelectedIndex = 0;
			ddlSection.Enabled = true;
			Grades();
			ddlSortAZ.SelectedIndex = 0;
		}
		protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(conStr);
			SqlCommand cmd = new SqlCommand("SELECT * FROM subjects WHERE teacher_id=@teacherid AND year_level_id=@yearlevelid", con);
			cmd.Parameters.AddWithValue("@teacherid", Session["CurrentTeacherUser"]);
			cmd.Parameters.AddWithValue("@yearlevelid", ddlGradeLevel.SelectedValue);
			SqlDataAdapter adpt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlSubjects.DataSource = dt;
			ddlSubjects.DataTextField = "subject_name";
			ddlSubjects.DataValueField = "subject_id";
			ddlSubjects.DataBind();
			ddlSubjects.Items.Insert(0, new ListItem("Select Subject", "0"));
			ddlSubjects.SelectedIndex = 0;
			ddlSubjects.Enabled = true;
			Grades();
			ddlSortAZ.SelectedIndex = 0;
		}
		protected void ddlSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			Grades();
		}
		protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

		protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gvGrades.PageIndex = e.NewPageIndex;
			this.Grades();
		}

		protected void gvGrades_RowDataBound(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "Subject";
                e.Row.Cells[1].Text = "Last Name";
                e.Row.Cells[2].Text = "First Name";
                e.Row.Cells[3].Text = "1st Quarter";
				e.Row.Cells[4].Text = "2nd Quarter";
				e.Row.Cells[5].Text = "3rd Quarter";
				e.Row.Cells[6].Text = "4th Quarter";
				e.Row.Cells[7].Text = "Average";
				e.Row.Cells[8].Text = "Remarks";
				e.Row.Cells[9].Text = "Status";
            }
		}

		protected void ddlSortAZ_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlSortAZ.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(conStr);
				SqlCommand cmd = new SqlCommand("SELECT subjects.subject_name, students.last_name, students.first_name, " +
					"grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks, grades.approval FROM grades " +
					"INNER JOIN students ON grades.student_id=students.student_id " +
					"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
					"WHERE subjects.subject_id=@subjectid AND subjects.teacher_id=@teacherid " +
					"ORDER BY last_name ASC", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentTeacherUser"]);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvGrades.DataSource = dt;
				gvGrades.DataBind();
				if (dt.Rows.Count <= 0)
				{
					gvGrades.DataSource = null;
					gvGrades.DataBind();
					TGNoRecordsLabel.Text = "No Records";
				}
				con.Close();
			}
			else if (ddlSortAZ.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(conStr);
				SqlCommand cmd = new SqlCommand("SELECT subjects.subject_name, students.last_name, students.first_name, " +
					"grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks, grades.approval FROM grades " +
					"INNER JOIN students ON grades.student_id=students.student_id " +
					"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
					"WHERE subjects.subject_id=@subjectid AND subjects.teacher_id=@teacherid " +
					"ORDER BY last_name DESC", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentTeacherUser"]);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvGrades.DataSource = dt;
				gvGrades.DataBind();
				if (dt.Rows.Count <= 0)
				{
					gvGrades.DataSource = null;
					gvGrades.DataBind();
					TGNoRecordsLabel.Text = "No Records";
				}
				con.Close();
			}
		}
	}
}