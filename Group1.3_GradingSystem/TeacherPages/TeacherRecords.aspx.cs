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
using System.Drawing;

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
						"written_works.ww_1_score, written_works.ww_1_total_score, ww_final_grade FROM written_works " +
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
				ddlSWNo.Items.Clear();
				ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
				ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
				ddlSWNo.SelectedIndex = 0;
				con.Close();
			}
			else if (dt.Rows[0][24].ToString() == "2")
			{
				SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, ww_final_grade FROM written_works " +
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
				ddlSWNo.Items.Clear();
				ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
				ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
				ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
				ddlSWNo.SelectedIndex = 0;
				con.Close();
			}
			else if (dt.Rows[0][24].ToString() == "3")
			{
				SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, ww_final_grade FROM written_works " +
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
				ddlSWNo.Items.Clear();
				ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
				ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
				ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
				ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
				ddlSWNo.SelectedIndex = 0;
				con.Close();
			}
			else if (dt.Rows[0][24].ToString() == "4")
			{
				SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, " +
						"written_works.ww_4_score, written_works.ww_4_total_score, ww_final_grade FROM written_works " +
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
				ddlSWNo.Items.Clear();
				ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
				ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
				ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
				ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
				ddlSWNo.Items.Insert(4, new ListItem("4", "4"));
				ddlSWNo.SelectedIndex = 0;
				con.Close();
			}
			else if (dt.Rows[0][24].ToString() == "5")
			{
				SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, " +
						"written_works.ww_4_score, written_works.ww_4_total_score, " +
						"written_works.ww_5_score, written_works.ww_5_total_score, ww_final_grade FROM written_works " +
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
				ddlSWNo.Items.Clear();
				ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
				ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
				ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
				ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
				ddlSWNo.Items.Insert(4, new ListItem("4", "4"));
				ddlSWNo.Items.Insert(5, new ListItem("5", "5"));
				ddlSWNo.SelectedIndex = 0;
				con.Close();
			}
		}

		public void Clear()
		{
			SRtxtFName.Text = string.Empty;
			SRtxtLName.Text = string.Empty;
			SRtxtRecordID.Text = string.Empty;

				
		}
		public void PerformanceTasks()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			SqlCommand cmd2 = new SqlCommand("SELECT * FROM performance_tasks WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
			cmd2.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
			cmd2.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
			cmd2.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
			SqlDataAdapter adpt2 = new SqlDataAdapter(cmd2);
			DataTable dt2 = new DataTable();
			adpt2.Fill(dt2);
			con.Close();

			if (dt2.Rows[0][18].ToString() == "1")
			{
				SqlCommand cmdpt = new SqlCommand("SELECT performance_tasks.performance_task_id, quarters.quarter, students.first_name, students.last_name, " +
					"performance_tasks.pt_1_score, performance_tasks.pt_1_total_score, performance_tasks.pt_1_final_score, pt_final_grade FROM performance_tasks " +
					"INNER JOIN students ON performance_tasks.student_id=students.student_id " +
					"INNER JOIN quarters ON performance_tasks.quarter_id=quarters.quarter_id " +
					"WHERE performance_tasks.subject_id=@subjectid AND performance_tasks.teacher_id=@teacherid AND performance_tasks.section_id=@sectionid AND performance_tasks.quarter_id=@quarterid", con);
				cmdpt.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmdpt.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmdpt.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmdpt.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
				SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
				DataTable dtpt = new DataTable();
				adptpt.Fill(dtpt);
				gvRecords.DataSource = dtpt;
				gvRecords.DataBind();
				con.Close();
			}
			else if (dt2.Rows[0][18].ToString() == "2")
			{
				SqlCommand cmdpt = new SqlCommand("SELECT performance_tasks.performance_task_id, quarters.quarter, students.first_name, students.last_name, " +
					"performance_tasks.pt_1_score, performance_tasks.pt_1_total_score, performance_tasks.pt_1_final_score, " +
					"performance_tasks.pt_2_score, performance_tasks.pt_2_total_score, performance_tasks.pt_2_final_score, performance_tasks.pt_final_grade FROM performance_tasks " +
					"INNER JOIN students ON performance_tasks.student_id=students.student_id " +
					"INNER JOIN quarters ON performance_tasks.quarter_id=quarters.quarter_id " +
					"WHERE performance_tasks.subject_id=@subjectid AND performance_tasks.teacher_id=@teacherid AND performance_tasks.section_id=@sectionid AND performance_tasks.quarter_id=@quarterid", con);
				cmdpt.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmdpt.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmdpt.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmdpt.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
				SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
				DataTable dtpt = new DataTable();
				adptpt.Fill(dtpt);
				gvRecords.DataSource = dtpt;
				gvRecords.DataBind();
				con.Close();
			}
			else if (dt2.Rows[0][18].ToString() == "3")
			{
				SqlCommand cmdpt = new SqlCommand("SELECT performance_tasks.performance_task_id, quarters.quarter, students.first_name, students.last_name, " +
					"performance_tasks.pt_1_score, performance_tasks.pt_1_total_score, performance_tasks.pt_1_final_score, " +
					"performance_tasks.pt_2_score, performance_tasks.pt_2_total_score, performance_tasks.pt_2_final_score, " +
					"performance_tasks.pt_3_score, performance_tasks.pt_3_total_score, performance_tasks.pt_3_final_score, performance_tasks.pt_final_grade FROM performance_tasks " +
					"INNER JOIN students ON performance_tasks.student_id=students.student_id " +
					"INNER JOIN quarters ON performance_tasks.quarter_id=quarters.quarter_id " +
					"WHERE performance_tasks.subject_id=@subjectid AND performance_tasks.teacher_id=@teacherid AND performance_tasks.section_id=@sectionid AND performance_tasks.quarter_id=@quarterid", con);
				cmdpt.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmdpt.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmdpt.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmdpt.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
				SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
				DataTable dtpt = new DataTable();
				adptpt.Fill(dtpt);
				gvRecords.DataSource = dtpt;
				gvRecords.DataBind();
				con.Close();
			}
		}

		public void QuarterlyAssessments()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			SqlCommand cmd3 = new SqlCommand("SELECT * FROM quarterly_test_scores WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid AND quarter_id=@quarter", con);
			cmd3.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
			cmd3.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
			cmd3.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
			cmd3.Parameters.AddWithValue("@quarter", ddlQuarter.SelectedValue);
			SqlDataAdapter adpt3 = new SqlDataAdapter(cmd3);
			DataTable dt3 = new DataTable();
			adpt3.Fill(dt3);
			con.Close();
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
				SqlCommand cmd1 = new SqlCommand("SELECT * FROM written_works WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd1.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd1.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd1.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adpt1.Fill(dt1);
				con.Close();
				
				if (dt1.Rows[0][24].ToString() == "1")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, ww_final_grade FROM written_works " +
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
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "2")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, ww_final_grade FROM written_works " +
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
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "3")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, ww_final_grade FROM written_works " +
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
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "4")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, " +
						"written_works.ww_4_score, written_works.ww_4_total_score, ww_final_grade FROM written_works " +
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
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
					ddlSWNo.Items.Insert(4, new ListItem("4", "4"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "5")
				{
					SqlCommand cmdww = new SqlCommand("SELECT written_works.written_work_id, quarters.quarter, students.first_name, students.last_name, " +
						"written_works.ww_1_score, written_works.ww_1_total_score, " +
						"written_works.ww_2_score, written_works.ww_2_total_score, " +
						"written_works.ww_3_score, written_works.ww_3_total_score, " +
						"written_works.ww_4_score, written_works.ww_4_total_score, " +
						"written_works.ww_5_score, written_works.ww_5_total_score, ww_final_grade FROM written_works " +
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
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
					ddlSWNo.Items.Insert(4, new ListItem("4", "4"));
					ddlSWNo.Items.Insert(5, new ListItem("5", "5"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
			}
			else if (ddlSchoolWork.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd2 = new SqlCommand("SELECT * FROM performance_tasks WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd2.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd2.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd2.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt2 = new SqlDataAdapter(cmd2);
				DataTable dt2= new DataTable();
				adpt2.Fill(dt2);
				con.Close();

				if (dt2.Rows[0][18].ToString() == "1")
				{
					SqlCommand cmdpt = new SqlCommand("SELECT performance_tasks.performance_task_id, quarters.quarter, students.first_name, students.last_name, " +
						"performance_tasks.pt_1_score, performance_tasks.pt_1_total_score, performance_tasks.pt_1_final_score, pt_final_grade FROM performance_tasks " +
						"INNER JOIN students ON performance_tasks.student_id=students.student_id " +
						"INNER JOIN quarters ON performance_tasks.quarter_id=quarters.quarter_id " +
						"WHERE performance_tasks.subject_id=@subjectid AND performance_tasks.teacher_id=@teacherid AND performance_tasks.section_id=@sectionid AND performance_tasks.quarter_id=@quarterid", con);
					cmdpt.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdpt.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdpt.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdpt.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
					DataTable dtpt = new DataTable();
					adptpt.Fill(dtpt);
					gvRecords.DataSource = dtpt;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt2.Rows[0][18].ToString() == "2")
				{
					SqlCommand cmdpt = new SqlCommand("SELECT performance_tasks.performance_task_id, quarters.quarter, students.first_name, students.last_name, " +
						"performance_tasks.pt_1_score, performance_tasks.pt_1_total_score, performance_tasks.pt_1_final_score, " +
						"performance_tasks.pt_2_score, performance_tasks.pt_2_total_score, performance_tasks.pt_2_final_score, performance_tasks.pt_final_grade FROM performance_tasks " +
						"INNER JOIN students ON performance_tasks.student_id=students.student_id " +
						"INNER JOIN quarters ON performance_tasks.quarter_id=quarters.quarter_id " +
						"WHERE performance_tasks.subject_id=@subjectid AND performance_tasks.teacher_id=@teacherid AND performance_tasks.section_id=@sectionid AND performance_tasks.quarter_id=@quarterid", con);
					cmdpt.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdpt.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdpt.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdpt.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
					DataTable dtpt = new DataTable();
					adptpt.Fill(dtpt);
					gvRecords.DataSource = dtpt;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt2.Rows[0][18].ToString() == "3")
				{
					SqlCommand cmdpt = new SqlCommand("SELECT performance_tasks.performance_task_id, quarters.quarter, students.first_name, students.last_name, " +
						"performance_tasks.pt_1_score, performance_tasks.pt_1_total_score, performance_tasks.pt_1_final_score, " +
						"performance_tasks.pt_2_score, performance_tasks.pt_2_total_score, performance_tasks.pt_2_final_score, " +
						"performance_tasks.pt_3_score, performance_tasks.pt_3_total_score, performance_tasks.pt_3_final_score, performance_tasks.pt_final_grade FROM performance_tasks " +
						"INNER JOIN students ON performance_tasks.student_id=students.student_id " +
						"INNER JOIN quarters ON performance_tasks.quarter_id=quarters.quarter_id " +
						"WHERE performance_tasks.subject_id=@subjectid AND performance_tasks.teacher_id=@teacherid AND performance_tasks.section_id=@sectionid AND performance_tasks.quarter_id=@quarterid", con);
					cmdpt.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
					cmdpt.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
					cmdpt.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
					cmdpt.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
					SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
					DataTable dtpt = new DataTable();
					adptpt.Fill(dtpt);
					gvRecords.DataSource = dtpt;
					gvRecords.DataBind();
					con.Close();
				}
			}
			else if (ddlSchoolWork.SelectedIndex == 3)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd3 = new SqlCommand("SELECT * FROM quarterly_test_scores WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid AND quarter_id=@quarter", con);
				cmd3.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd3.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd3.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmd3.Parameters.AddWithValue("@quarter", ddlQuarter.SelectedValue);
				SqlDataAdapter adpt3 = new SqlDataAdapter(cmd3);
				DataTable dt3 = new DataTable();
				adpt3.Fill(dt3);
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


			if (ddlSchoolWork.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd1 = new SqlCommand("SELECT * FROM written_works WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd1.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd1.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd1.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adpt1.Fill(dt1);
				con.Close();
				if (dt1.Rows[0][24].ToString() == "1")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "Final Grade";
					}
				}
				else if (dt1.Rows[0][24].ToString() == "2")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "#2";
						e.Row.Cells[7].Text = "Total";
						e.Row.Cells[8].Text = "Final Grade";
					}
				}
				else if (dt1.Rows[0][24].ToString() == "3")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "#2";
						e.Row.Cells[7].Text = "Total";
						e.Row.Cells[8].Text = "#3";
						e.Row.Cells[9].Text = "Total";
						e.Row.Cells[10].Text = "Final Grade";
					}
				}
				else if (dt1.Rows[0][24].ToString() == "4")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "#2";
						e.Row.Cells[7].Text = "Total";
						e.Row.Cells[8].Text = "#3";
						e.Row.Cells[9].Text = "Total";
						e.Row.Cells[10].Text = "#4";
						e.Row.Cells[11].Text = "Total";
						e.Row.Cells[12].Text = "Final Grade";
					}
				}
				else if (dt1.Rows[0][24].ToString() == "5")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "#2";
						e.Row.Cells[7].Text = "Total";
						e.Row.Cells[8].Text = "#3";
						e.Row.Cells[9].Text = "Total";
						e.Row.Cells[10].Text = "#4";
						e.Row.Cells[11].Text = "Total";
						e.Row.Cells[12].Text = "#5";
						e.Row.Cells[13].Text = "Total";
						e.Row.Cells[14].Text = "Final Grade";
					}
				}
			}
			else if (ddlSchoolWork.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd2 = new SqlCommand("SELECT * FROM performance_tasks WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd2.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd2.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd2.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt2 = new SqlDataAdapter(cmd2);
				DataTable dt2 = new DataTable();
				adpt2.Fill(dt2);
				con.Close();

				if (dt2.Rows[0][24].ToString() == "1")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "Final Grade";
					}
				}
				else if (dt2.Rows[0][24].ToString() == "2")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "#2";
						e.Row.Cells[7].Text = "Total";
						e.Row.Cells[8].Text = "Final Grade";
					}
				}
				else if (dt2.Rows[0][24].ToString() == "3")
				{
					if (e.Row.RowType == DataControlRowType.Header)
					{
						e.Row.Cells[0].Text = "ID";
						e.Row.Cells[1].Text = "Quarter";
						e.Row.Cells[2].Text = "First Name";
						e.Row.Cells[3].Text = "Last Name";
						e.Row.Cells[4].Text = "#1";
						e.Row.Cells[5].Text = "Total";
						e.Row.Cells[6].Text = "#2";
						e.Row.Cells[7].Text = "Total";
						e.Row.Cells[8].Text = "#3";
						e.Row.Cells[9].Text = "Total";
						e.Row.Cells[10].Text = "Final Grade";
					}
				}
			}
		}

		public void WW_FinalGrade()
		{
			if (ddlSchoolWork.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd1 = new SqlCommand("SELECT * FROM written_works WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd1.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd1.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd1.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt1 = new SqlDataAdapter(cmd1);
				DataTable dt1 = new DataTable();
				adpt1.Fill(dt1);
				con.Close();

				if (dt1.Rows[0][24].ToString() == "1")
				{
					SqlCommand cmdww = new SqlCommand("UPDATE written_works SET ww_final_grade = ROUND((written_works.ww_1_final_score * " +
						"(SELECT subject_categories.written_work_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=written_works.subject_id)), 2) from written_works WHERE written_work_id=@wwid", con);
					cmdww.Parameters.AddWithValue("@wwid", SRtxtRecordID.Text);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "2")
				{
					SqlCommand cmdww = new SqlCommand("UPDATE written_works SET ww_final_grade = ROUND(((written_works.ww_1_final_score + written_works.ww_2_final_score) / " +
						"written_works.ww_total_amount) * (SELECT subject_categories.written_work_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=written_works.subject_id), 2) from written_works WHERE written_work_id=@wwid", con);
					cmdww.Parameters.AddWithValue("@wwid", SRtxtRecordID.Text);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "3")
				{
					SqlCommand cmdww = new SqlCommand("UPDATE written_works SET ww_final_grade = ROUND(((written_works.ww_1_final_score + written_works.ww_2_final_score + written_works.ww_3_final_score) / " +
						"written_works.ww_total_amount) * (SELECT subject_categories.written_work_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=written_works.subject_id), 2) from written_works WHERE written_work_id=@wwid", con);
					cmdww.Parameters.AddWithValue("@wwid", SRtxtRecordID.Text);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "4")
				{
					SqlCommand cmdww = new SqlCommand("UPDATE written_works SET ww_final_grade = ROUND(((written_works.ww_1_final_score + written_works.ww_2_final_score + " +
						"written_works.ww_3_final_score + written_works.ww_4_final_score) / " +
						"written_works.ww_total_amount) * (SELECT subject_categories.written_work_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=written_works.subject_id), 2) from written_works WHERE written_work_id=@wwid", con);
					cmdww.Parameters.AddWithValue("@wwid", SRtxtRecordID.Text);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
					ddlSWNo.Items.Insert(4, new ListItem("4", "4"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
				else if (dt1.Rows[0][24].ToString() == "5")
				{
					SqlCommand cmdww = new SqlCommand("UPDATE written_works SET ww_final_grade = ROUND(((written_works.ww_1_final_score + written_works.ww_2_final_score + " +
						"written_works.ww_3_final_score + written_works.ww_4_final_score + written_works.ww_5_final_score) / " +
						"written_works.ww_total_amount) * (SELECT subject_categories.written_work_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=written_works.subject_id), 2) from written_works WHERE written_work_id=@wwid", con);
					cmdww.Parameters.AddWithValue("@wwid", SRtxtRecordID.Text);
					SqlDataAdapter adptww = new SqlDataAdapter(cmdww);
					DataTable dtww = new DataTable();
					adptww.Fill(dtww);
					gvRecords.DataSource = dtww;
					gvRecords.DataBind();
					ddlSWNo.Items.Clear();
					ddlSWNo.Items.Insert(0, new ListItem("Select No.", "0"));
					ddlSWNo.Items.Insert(1, new ListItem("1", "1"));
					ddlSWNo.Items.Insert(2, new ListItem("2", "2"));
					ddlSWNo.Items.Insert(3, new ListItem("3", "3"));
					ddlSWNo.Items.Insert(4, new ListItem("4", "4"));
					ddlSWNo.Items.Insert(5, new ListItem("5", "5"));
					ddlSWNo.SelectedIndex = 0;
					con.Close();
				}
			}
		}

		public void PT_FinalGrade()
		{
			if (ddlSchoolWork.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				SqlCommand cmd2 = new SqlCommand("SELECT * FROM performance_tasks WHERE subject_id=@subjectid AND teacher_id=@teacherid AND section_id=@sectionid", con);
				cmd2.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd2.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd2.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				SqlDataAdapter adpt2 = new SqlDataAdapter(cmd2);
				DataTable dt2 = new DataTable();
				adpt2.Fill(dt2);
				con.Close();

				if (dt2.Rows[0][18].ToString() == "1")
				{
					SqlCommand cmdpt = new SqlCommand("UPDATE performance_tasks SET pt_final_grade = ROUND((performance_tasks.pt_1_final_score * " + 
						"(SELECT subject_categories.performance_task_percentage FROM subjects " + 
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=performance_tasks.subject_id)), 2) from performance_tasks WHERE performance_task_id=@ptid", con);
					cmdpt.Parameters.AddWithValue("@ptid", SRtxtRecordID.Text);
					SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
					DataTable dtpt = new DataTable();
					adptpt.Fill(dtpt);
					gvRecords.DataSource = dtpt;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt2.Rows[0][18].ToString() == "2")
				{
					SqlCommand cmdpt = new SqlCommand("UPDATE performance_tasks SET pt_final_grade = ROUND(((performance_tasks.pt_1_final_score + performance_tasks.pt_2_final_score) / " +
						"performance_tasks.pt_total_amount) * (SELECT subject_categories.performance_task_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=performance_tasks.subject_id), 2) from performance_tasks WHERE performance_task_id=@ptid", con);
					cmdpt.Parameters.AddWithValue("@ptid", SRtxtRecordID.Text);
					SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
					DataTable dtpt = new DataTable();
					adptpt.Fill(dtpt);
					gvRecords.DataSource = dtpt;
					gvRecords.DataBind();
					con.Close();
				}
				else if (dt2.Rows[0][18].ToString() == "3")
				{
					SqlCommand cmdpt = new SqlCommand("UPDATE performance_tasks SET pt_final_grade = ROUND(((performance_tasks.pt_1_final_score + performance_tasks.pt_2_final_score +  performance_tasks.pt_3_final_score) / " +
						"performance_tasks.pt_total_amount) * (SELECT subject_categories.performance_task_percentage FROM subjects " +
						"INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id " +
						"WHERE subject_id=performance_tasks.subject_id), 2) from performance_tasks WHERE performance_task_id=@ptid", con);
					cmdpt.Parameters.AddWithValue("@ptid", SRtxtRecordID.Text);
					SqlDataAdapter adptpt = new SqlDataAdapter(cmdpt);
					DataTable dtpt = new DataTable();
					adptpt.Fill(dtpt);
					gvRecords.DataSource = dtpt;
					gvRecords.DataBind();
					con.Close();
				}
			}
		}
		protected void UpdateTable_Click (object sender, EventArgs e)
		{
			if (ddlSchoolWork.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE written_works SET ww_total_amount=@amount WHERE section_id=@sectionid", con);
				cmd.Parameters.AddWithValue("@amount", ddlAmnt.SelectedValue);
				cmd.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmd.ExecuteNonQuery();
				con.Close();


				SGtxtGrades.Text = string.Empty;
				SRtxtRecordID.Text = string.Empty;
				SRtxtFName.Text = string.Empty;
				SRtxtLName.Text = string.Empty;
				ddlQuarter.SelectedIndex = 0;
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
			}
			else if (ddlSchoolWork.SelectedIndex == 2)
			{

			}
			else if (ddlSchoolWork.SelectedIndex == 3)
			{

			}
		}
		protected void TRInsertRecords_Click(object sender, EventArgs e)
		{
			if (ddlSchoolWork.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO written_works (quarter_id, student_id, subject_id, school_year_id, year_level_id, section_id, teacher_id, ww_total_amount) " +
					"SELECT @quarterid, student_id, @subjectid, school_year_id, year_level_id, section_id, @teacherid, 1 " +
					"FROM students WHERE section_id=@sectionid" +
					"AND NOT EXISTS(SELECT student_id FROM written_works " +
					"WHERE written_works.student_id = students.student_id)", con);
				cmd.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd.ExecuteNonQuery();
				con.Close();
			}
			else if (ddlSchoolWork.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO performance_tasks (quarter_id, student_id, subject_id, school_year_id, year_level_id, section_id, teacher_id, pt_total_amount) " +
					"SELECT @quarterid, student_id, @subjectid, school_year_id, year_level_id, section_id, @teacherid, 1 " +
					"FROM students WHERE section_id=@sectionid" +
					"AND NOT EXISTS(SELECT student_id FROM performance_tasks " +
					"WHERE performance_tasks.student_id = students.student_id)", con);
				cmd.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd.ExecuteNonQuery();
				con.Close();
			}
			else if (ddlSchoolWork.SelectedIndex == 3)
			{
				SqlConnection con = new SqlConnection(conStr);
				con.Open();
				SqlCommand cmd = new SqlCommand("INSERT INTO quarterly_test_scores (quarter_id, student_id, subject_id, school_year_id, year_level_id, section_id, teacher_id) " +
					"SELECT @quarterid, student_id, @subjectid, school_year_id, year_level_id, section_id, @teacherid " +
					"FROM students WHERE section_id=@sectionid " +
					"AND NOT EXISTS(SELECT student_id FROM quarterly_test_scores " +
					"WHERE quarterly_test_scores.student_id = students.student_id)", con);
				cmd.Parameters.AddWithValue("@quarterid", ddlQuarter.SelectedValue);
				cmd.Parameters.AddWithValue("@subjectid", ddlSubjects.SelectedValue);
				cmd.Parameters.AddWithValue("@sectionid", ddlSection.SelectedValue);
				cmd.Parameters.AddWithValue("@teacherid", Session["CurrentUser"]);
				cmd.ExecuteNonQuery();
				con.Close();
			}
		}
	}
}