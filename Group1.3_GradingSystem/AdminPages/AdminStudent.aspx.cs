using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.AdminPages
{
    public partial class AdminStudent : System.Web.UI.Page
    {

        public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            students();
            users();
		}

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

        public void students()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT students.student_id, students.first_name, students.last_name, users.user_id, school_years.school_year, year_levels.year_level, sections.section " +
                "FROM students " +
                "INNER JOIN users ON students.user_id=users.user_id " +
                "INNER JOIN school_years ON students.school_year_id=school_years.school_year_id " +
                "INNER JOIN year_levels ON students.year_level_id=year_levels.year_level_id " +
                "INNER JOIN sections ON students.section_id=sections.section_id";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
            con.Close();
        }

        protected void gvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvStudents.Rows[gvStudents.SelectedIndex];
            if (row != null)
            {
                GridViewRow gr = gvStudents.SelectedRow;
                AtxtFirstName.Text = gr.Cells[1].Text;
                AtxtLastName.Text = gr.Cells[2].Text;
                AtxtUserID.Text = gr.Cells[3].Text;
                AtxtStudentID.Text = gr.Cells[0].Text;
                ddlSchoolYear.Text = gr.Cells[4].Text;
            }
        }
        protected void gvStudents_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvStudents, "Select$" + e.Row.RowIndex);
            }

			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "ID";
				e.Row.Cells[1].Text = "First Name";
				e.Row.Cells[2].Text = "Last Name";
				e.Row.Cells[3].Text = "User ID";
				e.Row.Cells[4].Text = "S.Y.";
				e.Row.Cells[5].Text = "Year Level";
				e.Row.Cells[6].Text = "Section";
			}
		}
        protected void OnPageIndexChangingstudents(object sender, GridViewPageEventArgs e)
        {
            gvStudents.PageIndex = e.NewPageIndex;
            this.students();
        }

        protected void AbtnAdd_Click(object sender, EventArgs e)
        {
            string firstname = AtxtFirstName.Text.Trim();
			string lastname = AtxtLastName.Text.Trim();
			string userid = AtxtUserID.Text.Trim();
			string studentid = AtxtStudentID.Text.Trim();
			if (firstname.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input first name of student!');", true);
			}
			else if (lastname.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input last name of student!');", true);
			}
			else if (userid.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select student!');", true);
			}
			else if (ddlSchoolYear.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the school year of student!');", true);
			}
			else if (ddlYearLevel.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the year level of student!');", true);
			}
			else if (ddlSection.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the section of student!');", true);
			}
			else if (studentid.Length > 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Student already exist!');", true);
			}
			else
			{
				SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO students (first_name, last_name, user_id, year_level_id, section_id, school_year_id) VALUES (@first_name, @last_name, @user_id, @year_level_id, @sections_id, @school_year_id)", con);

                cmd.Parameters.AddWithValue("@first_name", firstname);
                cmd.Parameters.AddWithValue("@last_name", lastname);
                cmd.Parameters.AddWithValue("@user_id", userid);
                cmd.Parameters.AddWithValue("@school_year_id", ddlSchoolYear.SelectedValue);
                cmd.Parameters.AddWithValue("@sections_id", ddlSection.SelectedValue);
                cmd.Parameters.AddWithValue("@year_level_id", ddlYearLevel.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                students();

                AtxtFirstName.Text = string.Empty;
                AtxtLastName.Text = string.Empty;
				AtxtUserID.Text = string.Empty;
				ddlSchoolYear.SelectedValue = null;
                ddlYearLevel.SelectedValue = null;
                ddlSection.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }
        protected void AbtnUpdate_Click(object sender, EventArgs e)
        {
			string firstname = AtxtFirstName.Text.Trim();
			string lastname = AtxtLastName.Text.Trim();
			string userid = AtxtUserID.Text.Trim();
			if (firstname.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input first name of student!');", true);
			}
			else if (lastname.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input last name of student!');", true);
			}
			else if (userid.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select student!');", true);
			}
			else if (ddlSchoolYear.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the school year of student!');", true);
			}
			else if (ddlYearLevel.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the year level of student!');", true);
			}
			else if (ddlSection.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select the section of student!');", true);
			}
			else
			{
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE students SET first_name = @first_name, last_name = @last_name, user_id = @user_id, year_level_id = @year_level_id, section_id = @sections_id, school_year_id = @school_year_id WHERE student_id = @student_id", con);

				cmd.Parameters.AddWithValue("@first_name", firstname);
				cmd.Parameters.AddWithValue("@last_name", lastname);
				cmd.Parameters.AddWithValue("@user_id", userid);
				cmd.Parameters.AddWithValue("@student_id", AtxtStudentID.Text);
                cmd.Parameters.AddWithValue("@school_year_id", ddlSchoolYear.SelectedValue);
                cmd.Parameters.AddWithValue("@year_level_id", ddlYearLevel.SelectedValue);
                cmd.Parameters.AddWithValue("@sections_id", ddlSection.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                students();

                AtxtFirstName.Text = string.Empty;
				AtxtLastName.Text = string.Empty;
				AtxtUserID.Text = string.Empty;
				ddlYearLevel.SelectedValue = null;
                ddlSchoolYear.SelectedValue = null;
                ddlSection.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully');", true);
            }
        }
        protected void AbtnDelete_Click(object sender, EventArgs e)
        {
			string studentid = AtxtStudentID.Text.Trim();
			if (studentid.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select student');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE student_id = @student_id", con);

                cmd.Parameters.AddWithValue("@student_id", studentid);
                cmd.ExecuteNonQuery();
                con.Close();

                clear();
                students();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully');", true);
            }
        }
        protected void clear()
        {
            AtxtFirstName.Text = String.Empty;
            AtxtLastName.Text = String.Empty;
            AtxtUserID.Text = String.Empty;
            AtxtStudentID.Text = String.Empty;
            ddlYearLevel.SelectedValue = null;
            ddlSchoolYear.SelectedValue = null;
            ddlSection.SelectedValue = null;
        }
        protected void AbtnClear_Click(object sender, EventArgs e)
        {
            AtxtFirstName.Text = String.Empty;
            AtxtLastName.Text = String.Empty;
            AtxtUserID.Text = String.Empty;
            AtxtStudentID.Text = String.Empty;
            ddlYearLevel.SelectedValue = null;
            ddlSchoolYear.SelectedValue = null;
            ddlSection.SelectedValue = null;


            students();
        }
        public void users()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT user_id, username FROM users WHERE user_level='Student'";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvUsers.DataSource = dt;
            gvUsers.DataBind();
            con.Close();
        }
        protected void gvUsers_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvUsers, "Select$" + e.Row.RowIndex);
            }
			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "ID";
				e.Row.Cells[1].Text = "User Name";
			}
		}
        protected void OnPageIndexChangingsections(object sender, GridViewPageEventArgs e)
        {
            gvUsers.PageIndex = e.NewPageIndex;
            this.users();

		}

        protected void gvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvUsers.Rows[gvUsers.SelectedIndex];
            if (row != null)
            {
                GridViewRow gr = gvUsers.SelectedRow;
				AtxtUserID.Text = gr.Cells[0].Text;
			}
        }
        public void Sections()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM sections WHERE year_level_id=@yearlevel", con);
			cmd.Parameters.AddWithValue("@yearlevel", ddlYearLevel.SelectedValue);
			SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlSection.DataSource = dt;
            ddlSection.DataTextField = "section";
            ddlSection.DataValueField = "section_id";
            ddlSection.DataBind();
            ddlSection.Items.Insert(0, new ListItem("Select Section"));
            ddlSection.SelectedIndex = 0;
            ddlSection.Enabled = true;
        }

        protected void ddlYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sections();
        }
	}
}