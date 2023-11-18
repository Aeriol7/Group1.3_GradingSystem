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
	public partial class TeacherSetGradesPage : System.Web.UI.Page
	{

		public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

		protected void Page_Load(object sender, EventArgs e)
		{
				SchoolYears();
		}

		public void GradeLevel()
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
			
		}

		public void SchoolYears()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			string com = "SELECT * FROM school_years";
			SqlDataAdapter adpt = new SqlDataAdapter(com, con);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlSchoolYear.DataSource = dt;
			ddlSchoolYear.DataTextField = "school_year";
			ddlSchoolYear.DataValueField = "school_year_id";
			ddlSchoolYear.DataBind();
		}

		protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlSection.SelectedIndex == 0)
			{
				ddlSection.DataSource = string.Empty;
				ddlSection.DataBind();
				ddlSection.Enabled = false;
			}
			else if (ddlSection.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd = new SqlCommand("SELECT * FROM subjects WHERE teacher_id=@teacherid AND year_level_id=@yearlevelid AND section_id=@sectionid", con);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd.Parameters.AddWithValue("@yearlevelid", 1);
				cmd.Parameters.AddWithValue("@sectionid", 1);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSubjects.DataSource = dt;
				ddlSubjects.DataTextField = "subject_name";
				ddlSubjects.DataValueField = "subject_id";
				ddlSubjects.DataBind();
				ddlSubjects.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd = new SqlCommand("SELECT * FROM subjects WHERE teacher_id=@teacherid AND year_level_id=@yearlevelid AND section_id=@sectionid", con);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd.Parameters.AddWithValue("@yearlevelid", 2);
				cmd.Parameters.AddWithValue("@sectionid", 2);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSubjects.DataSource = dt;
				ddlSubjects.DataTextField = "subject_name";
				ddlSubjects.DataValueField = "subject_id";
				ddlSubjects.DataBind();
				ddlSubjects.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 3)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=3";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 4)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=4";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 5)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=5";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 6)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=6";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 7)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=7";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 8)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=8";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 9)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=9";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 10)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=10";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 11)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=11";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 12)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=12";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlSection.SelectedIndex == 13)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=13";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
		}

		public void Grades()
		{
			SqlConnection con = new SqlConnection(conStr);
			SqlCommand cmd = new SqlCommand("SELECT grades.grades_id, subjects.subject_name, students.first_name, students.last_name, grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter," +
				"grades.average, grades.remarks FROM grades " +
				"INNER JOIN students ON grades.student_id=students.student_id " +
				"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
				"WHERE subjects.subject_id=@subjectid", con);
			cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
			SqlDataAdapter adpt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			gvGrades.DataSource = dt;
			gvGrades.DataBind();
			con.Close();

		}

		protected void ddlSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd = new SqlCommand("SELECT grades.grades_id, subjects.subject_name, students.first_name, students.last_name, " +
					"grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks FROM grades " +
					"INNER JOIN students ON grades.student_id=students.student_id " +
					"INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
					"WHERE subjects.subject_id=@subjectid", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvGrades.DataSource = dt;
				gvGrades.DataBind();
				con.Close();
			
		}

		protected void ddlGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlGradeLevel.SelectedIndex == 0)
			{
				ddlSection.DataSource = string.Empty;
				ddlSection.DataBind();
				ddlSection.Enabled = false;
			}
			else if (ddlGradeLevel.SelectedIndex == 1)
			{
				ddlSection.Enabled = true;

			}
			else if (ddlGradeLevel.SelectedIndex == 2)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 3)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 4)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 5)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 6)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 7)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 8)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 9)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 10)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 11)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 12)
			{
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 13)
			{
				ddlSection.Enabled = true;
			}
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

		protected void gvGrades_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Get the selected row
			GridViewRow row = gvGrades.Rows[gvGrades.SelectedIndex];
			if (row != null)
			{
				//Change the cell index(1) of column as per your design
				//Get the Selected row cell values here
				GridViewRow gr = gvGrades.SelectedRow;
				SGtxtGradeID.Text = gr.Cells[0].Text;
				SGtxtFName.Text = gr.Cells[2].Text;
				SGtxtLName.Text = gr.Cells[3].Text;

				if (ddlQuarter.SelectedIndex == 1)
				{
					SGtxtGrades.Text = gr.Cells[4].Text;
				}
				else if (ddlQuarter.SelectedIndex == 2)
				{
					SGtxtGrades.Text = gr.Cells[5].Text;
				}
				else if (ddlQuarter.SelectedIndex == 3)
				{
					SGtxtGrades.Text = gr.Cells[6].Text;
				}
				else if (ddlQuarter.SelectedIndex == 4)
				{
					SGtxtGrades.Text = gr.Cells[7].Text;
				}
				else if (ddlQuarter.SelectedIndex == 0)
				{
					
				}
			}
		}
		protected void gvGrades_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.DataRow)
			{
				//Change the mouse cursor to Hand symbol to show the user the cell is selectable
				e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
				e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

				//Attach the click event to each cells
				e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvGrades, "Select$" + e.Row.RowIndex);
			}

			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "Grade ID";
				e.Row.Cells[1].Text = "Subject";
				e.Row.Cells[2].Text = "First Name";
				e.Row.Cells[3].Text = "Last Name";
				e.Row.Cells[4].Text = "1st Quarter";
				e.Row.Cells[5].Text = "2nd Quarter";
				e.Row.Cells[6].Text = "3rd Quarter";
				e.Row.Cells[7].Text = "4th Quarter";
				e.Row.Cells[8].Text = "Average";
				e.Row.Cells[9].Text = "Remarks";
			}
		}

		public void Remarks()
		{
			SqlConnection con = new SqlConnection(conStr);
			con.Open();
			SqlCommand cmd = new SqlCommand("IF (SELECT average from grades WHERE grades_id=@gradeid) >= 75" +
				"UPDATE grades SET remarks='PASSED' WHERE grades_id=@gradeid " +
				"ELSE " +
				"UPDATE grades SET remarks='FAILED' WHERE grades_id=@gradeid", con);
			cmd.Parameters.AddWithValue("@gradeid", SGtxtGradeID.Text);
			cmd.ExecuteNonQuery();
			con.Close();
		}

		protected void SGSaveGrades_Click(object sender, EventArgs e)
		{
			if (ddlQuarter.Text == "1st")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET first_quarter = @1stgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@1stgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SGtxtGradeID.Text);
				cmd.ExecuteNonQuery();
				con.Close();

				Remarks();
				Grades();

				SGtxtGrades.Text = string.Empty; 
				SGtxtGradeID.Text = string.Empty; 
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlQuarter.Text == "2nd")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET second_quarter = @2ndgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@2ndgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SGtxtGradeID.Text);
				cmd.ExecuteNonQuery();
				con.Close();

				Remarks();
				Grades();

				SGtxtGrades.Text = string.Empty;
				SGtxtGradeID.Text = string.Empty;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlQuarter.Text == "3rd")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET third_quarter = @3rdgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@3rdgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SGtxtGradeID.Text);
				cmd.ExecuteNonQuery();
				con.Close();

				Remarks();
				Grades();

				SGtxtGrades.Text = string.Empty;
				SGtxtGradeID.Text = string.Empty;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlQuarter.Text == "4th")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET fourth_quarter = @4thgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@4thgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SGtxtGradeID.Text);
				cmd.ExecuteNonQuery();
				con.Close();

				Remarks();
				Grades();

				SGtxtGrades.Text = string.Empty;
				SGtxtGradeID.Text = string.Empty;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
		}
	}
}