using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.AdminPages
{
    public partial class AdminSubjects : System.Web.UI.Page
    {
        public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            subjects();
            teachers();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }
        public void subjects()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT subjects.subject_id, subjects.subject_name, year_levels.year_level, teachers.last_name, subject_categories.subject_category " +
                "from SUBJECTS " +
                "INNER JOIN year_levels ON subjects.year_level_id=year_levels.year_level_id " +
                "INNER JOIN teachers ON subjects.teacher_id=teachers.teacher_id " +
                "INNER JOIN subject_categories ON subjects.subject_category_id=subject_categories.subject_category_id";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvSubjects.DataSource = dt;
            gvSubjects.DataBind();
            con.Close();
        }
        public void teachers()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT * FROM teachers";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvTeachers.DataSource = dt;
            gvTeachers.DataBind();
            con.Close();
        }
        protected void gvSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvSubjects.Rows[gvSubjects.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = gvSubjects.SelectedRow;
                AtxtSubjectID.Text = gr.Cells[0].Text;
                AtxtSubjectName.Text = gr.Cells[1].Text;
                AtxtTeacherID.Text = gr.Cells[3].Text;
                AddlYearLevel.SelectedValue = gr.Cells[2].Text;
                AddlCategory.SelectedValue = gr.Cells[4].Text;
            }
        }
        protected void gvSubjects_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvSubjects, "Select$" + e.Row.RowIndex);
            }
			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "Subject ID";
				e.Row.Cells[1].Text = "Subject Name";
				e.Row.Cells[2].Text = "Year Level";
				e.Row.Cells[3].Text = "Teacher";
				e.Row.Cells[4].Text = "Subject Category";
			}
		}
        protected void OnPageIndexChangingsubjects(object sender, GridViewPageEventArgs e)
        {
            gvSubjects.PageIndex = e.NewPageIndex;
            this.subjects();
        }
        protected void gvTeachers_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvTeachers, "Select$" + e.Row.RowIndex);
            }
			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "Teacher ID";
				e.Row.Cells[1].Text = "First Name";
				e.Row.Cells[2].Text = "Last Name";
                e.Row.Cells[3].Text = "User ID";
			}
		}
        protected void AbtnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectname = AtxtSubjectName.Text.Trim();
            string teacherid = AtxtTeacherID.Text.Trim();
            if (subjectname.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input subject name!');", true);
            }
            else if (teacherid.Length == 0)
            {
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select teacher to be assigned for subject!');", true);
			}
            else if (AddlYearLevel.SelectedIndex == 0)
            {
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select year level of subject!');", true);
			}
            else if (AddlCategory.SelectedIndex == 0)
            {
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the subject category!');", true);
			}
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO subjects (subject_name, year_level_id, teacher_id, subject_category_id) VALUES  (@subject_name, @year_level_id, @teacher_id, @category)", con);

                cmd.Parameters.AddWithValue("@subject_name", subjectname);
                cmd.Parameters.AddWithValue("@teacher_id", teacherid);
                cmd.Parameters.AddWithValue("@year_level_id", AddlYearLevel.SelectedValue);
                cmd.Parameters.AddWithValue("@category", AddlCategory.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                subjects();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }

        protected void AbtnUpdateSubject_Click(object sender, EventArgs e)
        {
			string subjectid = AtxtSubjectID.Text.Trim();
			string subjectname = AtxtSubjectName.Text.Trim();
			string teacherid = AtxtTeacherID.Text.Trim();
			if (subjectid.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select subject!');", true);
			}
			else if (subjectname.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input subject name!');", true);
			}
			else if (teacherid.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select teacher to be assigned for subject!');", true);
			}
			else if (AddlYearLevel.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select year level of subject!');", true);
			}
			else if (AddlCategory.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the subject category!');", true);
			}
			else
			{
				SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE subjects SET subject_name = @subject_name, teacher_id = @teacher_id, year_level_id = @year_level_id, subject_category_id = @category WHERE subject_id = @subject_id", con);

                cmd.Parameters.AddWithValue("@subject_name", AtxtSubjectName.Text);
                cmd.Parameters.AddWithValue("@teacher_id", AtxtTeacherID.Text);
                cmd.Parameters.AddWithValue("@subject_id", AtxtSubjectID.Text);
                cmd.Parameters.AddWithValue("@year_level_id", AddlYearLevel.SelectedValue);
                cmd.Parameters.AddWithValue("@category", AddlCategory.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                subjects();

                AtxtSubjectName.Text = string.Empty;
                AtxtTeacherID.Text = string.Empty;
                AddlYearLevel.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }
        protected void AbtnDeleteSubject_Click(object sender, EventArgs e)
        {
			string subjectid = AtxtSubjectID.Text.Trim();
            if (subjectid.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select subject!');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM subjects WHERE subject_id = @subject_id", con);

                cmd.Parameters.AddWithValue("@subject_id", AtxtSubjectID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                clear();
                subjects();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }
        protected void clear()
        {
            AtxtSubjectID.Text = String.Empty;
            AtxtSubjectName.Text = String.Empty;
            AtxtTeacherID.Text = String.Empty;
        }
        protected void AbtnClearSubject_Click(object sender, EventArgs e)
        {
            AtxtSubjectID.Text = String.Empty;
            AtxtSubjectName.Text = String.Empty;
            AtxtTeacherID.Text = String.Empty;
            AddlYearLevel.SelectedValue = null;
            AddlCategory.SelectedValue = null;
        }
    }
}