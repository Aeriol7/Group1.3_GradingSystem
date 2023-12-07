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
    public partial class AdminApproval : System.Web.UI.Page
    {

        public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }


        protected void ddlSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT * FROM teachers";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlTeacher.DataSource = dt;
            ddlTeacher.DataTextField = "last_name";
            ddlTeacher.DataValueField = "teacher_id";
            ddlTeacher.DataBind();
            ddlTeacher.Items.Insert(0, new ListItem("Select Teacher", "0"));
            ddlSection.SelectedIndex = 0;
            ddlSubject.SelectedIndex = 0;
            ddlTeacher.SelectedIndex = 0;
            ddlTeacher.Enabled = true;
            
        }

        protected void ddlTeacher_SelectedIndexChanged(object sender, EventArgs e)
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
            ddlSubject.SelectedIndex = 0;
            ddlGradeLevel.SelectedIndex = 0;
            ddlGradeLevel.Enabled = true;
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
            ddlSubject.SelectedIndex = 0;
            ddlSection.SelectedIndex = 0;
            ddlSection.Enabled = true;
            
        }

        protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM subjects WHERE teacher_id=@teacherid AND year_level_id=@yearlevelid", con);
            cmd.Parameters.AddWithValue("@teacherid", ddlTeacher.SelectedValue);
            cmd.Parameters.AddWithValue("@yearlevelid", ddlGradeLevel.SelectedValue);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlSubject.DataSource = dt;
            ddlSubject.DataTextField = "subject_name";
            ddlSubject.DataValueField = "subject_id";
            ddlSubject.DataBind();
            ddlSubject.Items.Insert(0, new ListItem("Select Subject", "0"));
            ddlSubject.SelectedIndex = 0;
            ddlSubject.Enabled = true;
        }
        public void Grades()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("SELECT grades.grades_id, subjects.subject_name, students.first_name, students.last_name, " +
                "grades.first_quarter, grades.second_quarter, grades.third_quarter, grades.fourth_quarter, grades.average, grades.remarks, grades.approval FROM grades " +
                "INNER JOIN students ON grades.student_id=students.student_id " +
                "INNER JOIN subjects ON grades.subject_id=subjects.subject_id " +
                "WHERE subjects.subject_id=@subjectid AND subjects.teacher_id=@teacherid", con);
            cmd.Parameters.AddWithValue("@subjectid", ddlSubject.SelectedValue);
            cmd.Parameters.AddWithValue("@teacherid", ddlTeacher.SelectedValue);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvGrades.DataSource = dt;
            gvGrades.DataBind();
            con.Close();
        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grades();
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvGrades.PageIndex = e.NewPageIndex;
            this.Grades();
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
                e.Row.Cells[10].Text = "Approval";
            }
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


                
            }
        }
    }
}