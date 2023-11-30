using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics.Tracing;
using System.EnterpriseServices;

namespace Group1._3_GradingSystem.TeacherPages
{
	public partial class TeacherRecords : System.Web.UI.Page
	{

		public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

		protected void Page_Load(object sender, EventArgs e)
		{
			SchoolYears();
		}

		public void SchoolYears()
		{
			SqlConnection con = new SqlConnection(conStr);
			string com = "SELECT * FROM school_years";
			SqlDataAdapter adpt = new SqlDataAdapter(com, con);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlSchoolYear.DataSource = dt;
			ddlSchoolYear.DataTextField = "school_year";
			ddlSchoolYear.DataValueField = "school_year_id";
			ddlSchoolYear.DataBind();
		}

		public void WrittenWorks()
		{

		}

		public void PerformanceTasks()
		{

		}

		public void QuarterlyAssessments()
		{

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
		}
		protected void ddlGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
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
		}
		protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			SqlCommand cmd = new SqlCommand("SELECT * FROM subjects WHERE teacher_id=@teacherid AND year_level_id=@yearlevelid", con);
			cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
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
		}
		protected void ddlSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			ddlQuarter.Enabled = true;
			ddlQuarter.SelectedIndex = 0;
		}

		protected void ddlQuarter_SelectedIndexChanged(object sender, EventArgs e)
		{
			ddlSchoolWork.Enabled = true;
			ddlSchoolWork.SelectedIndex = 0;
		}

		protected void ddlSchoolWork_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlSchoolWork.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd = new SqlCommand("SELECT * FROM written_works WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				con.Close();
				
				if (dt.Rows[0][24].ToString() == "1")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, written_works.ww_1_final_score, ww_final_grade FROM written_works " +
						"INNER JOIN students ON written_works.student_id=students.student_id " +
						"INNER JOIN quarters ON written_works.quarter_id=quarters.quarter_id " +
						"WHERE written_works.subject_id=@subjectid AND written_works.teacher_id=@teacherid AND written_works.section_id=@sectionid AND written_works.quarter_id=@quarterid", con);
					cmdww.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdww.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdww.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdww.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt.Rows[0][24].ToString() == "2")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, written_works.ww_1_final_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, written_works.ww_2_final_score, ww_final_grade FROM written_works " +
						"INNER JOIN students ON written_works.student_id=students.student_id " +
						"INNER JOIN quarters ON written_works.quarter_id=quarters.quarter_id " +
						"WHERE written_works.subject_id=@subjectid AND written_works.teacher_id=@teacherid AND written_works.section_id=@sectionid AND written_works.quarter_id=@quarterid", con);
					cmdww.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdww.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdww.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdww.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt.Rows[0][24].ToString() == "3")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, written_works.ww_1_final_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, written_works.ww_2_final_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, written_works.ww_3_final_score, ww_final_grade FROM written_works " +
						"INNER JOIN students ON written_works.student_id=students.student_id " +
						"INNER JOIN quarters ON written_works.quarter_id=quarters.quarter_id " +
						"WHERE written_works.subject_id=@subjectid AND written_works.teacher_id=@teacherid AND written_works.section_id=@sectionid AND written_works.quarter_id=@quarterid", con);
					cmdww.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdww.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdww.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdww.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt.Rows[0][24].ToString() == "4")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, written_works.ww_1_final_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, written_works.ww_2_final_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, written_works.ww_3_final_score, " +
						"written_works.ww_4_score, written_works.ww_4_total_score, written_works.ww_4_final_score, ww_final_grade FROM written_works " +
						"INNER JOIN students ON written_works.student_id=students.student_id " +
						"INNER JOIN quarters ON written_works.quarter_id=quarters.quarter_id " +
						"WHERE written_works.subject_id=@subjectid AND written_works.teacher_id=@teacherid AND written_works.section_id=@sectionid AND written_works.quarter_id=@quarterid", con);
					cmdww.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdww.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdww.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdww.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt.Rows[0][24].ToString() == "5")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, written_works.ww_1_final_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, written_works.ww_2_final_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, written_works.ww_3_final_score, " +
						"written_works.ww_4_score, written_works.ww_4_total_score, written_works.ww_4_final_score, " +
						"written_works.ww_5_score, written_works.ww_5_total_score, written_works.ww_5_final_score, ww_final_grade FROM written_works " +
						"INNER JOIN students ON written_works.student_id=students.student_id " +
						"INNER JOIN quarters ON written_works.quarter_id=quarters.quarter_id " +
						"WHERE written_works.subject_id=@subjectid AND written_works.teacher_id=@teacherid AND written_works.section_id=@sectionid AND written_works.quarter_id=@quarterid", con);
					cmdww.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdww.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdww.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdww.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					con.Close();
				}
			}
			else if (ddlSchoolWork.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd = new SqlCommand("", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvRecords.DataSource = dt;
				gvRecords.DataBind();
				con.Close();
			}
			else if (ddlSchoolWork.SelectedIndex == 3)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd = new SqlCommand("", con);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				SqlDataAdapter adpt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				gvRecords.DataSource = dt;
				gvRecords.DataBind();
				con.Close();
			}
		}
		protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

		protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			if (ddlSchoolWork.SelectedIndex == 1)
			{
				gvRecords.PageIndex = e.NewPageIndex;
				this.WrittenWorks();
			}
			else if (ddlSchoolWork.SelectedIndex == 2)
			{
				gvRecords.PageIndex = e.NewPageIndex;
				this.PerformanceTasks();
			}
			else if (ddlSchoolWork.SelectedIndex == 3)
			{
				gvRecords.PageIndex = e.NewPageIndex;
				this.QuarterlyAssessments();
			}
		}

		protected void gvRecords_SelectedIndexChanged(object sender, EventArgs e)
		{
			GridViewRow row = gvRecords.Rows[gvRecords.SelectedIndex];
			if (row != null)
			{
				GridViewRow gr = gvRecords.SelectedRow;
				SRtxtRecordID.Text = gr.Cells[0].Text;
				SRtxtFName.Text = gr.Cells[2].Text;
				SRtxtLName.Text = gr.Cells[3].Text;

				
			}
		}
		protected void gvRecords_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.DataRow)
			{
				//Change the mouse cursor to Hand symbol to show the user the cell is selectable
				e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
				e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

				//Attach the click event to each cells
				e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvRecords, "Select$" + e.Row.RowIndex);
			}

			//if (e.Row.RowType == DataControlRowType.Header)
			//{
			//	e.Row.Cells[0].Text = "Grade ID";
			//	e.Row.Cells[1].Text = "Subject";
			//	e.Row.Cells[2].Text = "First Name";
			//	e.Row.Cells[3].Text = "Last Name";
			//	e.Row.Cells[4].Text = "1st Quarter";
			//	e.Row.Cells[5].Text = "2nd Quarter";
			//	e.Row.Cells[6].Text = "3rd Quarter";
			//	e.Row.Cells[7].Text = "4th Quarter";
			//	e.Row.Cells[8].Text = "Average";
			//	e.Row.Cells[9].Text = "Remarks";
			//}
		}

		public void Remarks()
		{

			SqlConnection con = new SqlConnection(conStr);
			con.Open();
			SqlCommand cmd1 = new SqlCommand("IF (SELECT average from grades WHERE grades_id=@gradeid) >= 75" +
				"UPDATE grades SET remarks='PASSED' WHERE grades_id=@gradeid " +
				"ELSE " +
				"UPDATE grades SET remarks='FAILED' WHERE grades_id=@gradeid", con);
			cmd1.Parameters.AddWithValue("@gradeid", SRtxtRecordID.Text);
			cmd1.ExecuteNonQuery();
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
				cmd.Parameters.AddWithValue("@gradeid", SRtxtRecordID.Text);
				cmd.ExecuteNonQuery();
				con.Close();



				SGtxtGrades.Text = string.Empty;
				SRtxtRecordID.Text = string.Empty;
				SRtxtFName.Text = string.Empty;
				SRtxtLName.Text = string.Empty;
				ddlQuarter.SelectedIndex = 0;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlQuarter.Text == "2nd")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET second_quarter = @2ndgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@2ndgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SRtxtRecordID.Text);
				cmd.ExecuteNonQuery();
				con.Close();


				SGtxtGrades.Text = string.Empty;
				SRtxtRecordID.Text = string.Empty;
				SRtxtFName.Text = string.Empty;
				SRtxtLName.Text = string.Empty;
				ddlQuarter.SelectedIndex = 0;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlQuarter.Text == "3rd")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET third_quarter = @3rdgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@3rdgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SRtxtRecordID.Text);
				cmd.ExecuteNonQuery();
				con.Close();


				SGtxtGrades.Text = string.Empty;
				SRtxtRecordID.Text = string.Empty;
				SRtxtFName.Text = string.Empty;
				SRtxtLName.Text = string.Empty;
				ddlQuarter.SelectedIndex = 0;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlQuarter.Text == "4th")
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE grades SET fourth_quarter = @4thgrade WHERE grades_id = @gradeid", con);
				cmd.Parameters.AddWithValue("@4thgrade", SGtxtGrades.Text);
				cmd.Parameters.AddWithValue("@gradeid", SRtxtRecordID.Text);
				cmd.ExecuteNonQuery();
				con.Close();

				Remarks();

				SGtxtGrades.Text = string.Empty;
				SRtxtRecordID.Text = string.Empty;
				SRtxtFName.Text = string.Empty;
				SRtxtLName.Text = string.Empty;
				ddlQuarter.SelectedIndex = 0;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
		}
	}
}