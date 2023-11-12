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
				//Sections();
				Grades();

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

		public void Sections()
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			string com = "SELECT * FROM sections";
			SqlDataAdapter adpt = new SqlDataAdapter(com, con);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlSection.DataSource = dt;
			ddlSection.DataTextField = "section";
			ddlSection.DataValueField = "section_id";
			ddlSection.DataBind();
		}

		public void Grades()
		{
			
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			string com = "SELECT * FROM grades";
			con.Open();
			SqlDataAdapter adpt = new SqlDataAdapter(com, con);
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
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=1";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;

			}
			else if (ddlGradeLevel.SelectedIndex == 2)
			{
				SqlConnection con = new SqlConnection(conStr);
				string com = "SELECT * FROM sections WHERE year_level_id=2";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "section";
				ddlSection.DataValueField = "section_id";
				ddlSection.DataBind();
				ddlSection.Enabled = true;
			}
			else if (ddlGradeLevel.SelectedIndex == 3)
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
			else if (ddlGradeLevel.SelectedIndex == 4)
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
			else if (ddlGradeLevel.SelectedIndex == 5)
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
			else if (ddlGradeLevel.SelectedIndex == 6)
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
			else if (ddlGradeLevel.SelectedIndex == 7)
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
			else if (ddlGradeLevel.SelectedIndex == 8)
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
			else if (ddlGradeLevel.SelectedIndex == 9)
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
			else if (ddlGradeLevel.SelectedIndex == 10)
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
			else if (ddlGradeLevel.SelectedIndex == 11)
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
			else if (ddlGradeLevel.SelectedIndex == 12)
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
			else if (ddlGradeLevel.SelectedIndex == 13)
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
		protected void ddlSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddlSubjects.SelectedIndex == 0)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				string com = "SELECT * FROM subjects WHERE year_level_id=1";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSubjects.DataSource = dt;
				ddlSubjects.DataTextField = "subject";
				ddlSubjects.DataValueField = "subject_id";
				ddlSubjects.DataBind();
			}
			else if (ddlSubjects.SelectedIndex == 1)
			{
				SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
				string com = "SELECT * FROM subjects WHERE year_level_id=2";
				SqlDataAdapter adpt = new SqlDataAdapter(com, con);
				DataTable dt = new DataTable();
				adpt.Fill(dt);
				ddlSection.DataSource = dt;
				ddlSection.DataTextField = "subject";
				ddlSection.DataValueField = "subject_id";
				ddlSection.DataBind();
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
				SGtxtStuID.Text = gr.Cells[0].Text;
				SGtxtFName.Text = gr.Cells[1].Text;
				SGtxtLName.Text = gr.Cells[2].Text;
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
		}

	}
}