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
            string com = "SELECT * FROM subjects";
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
        }

        protected void AbtnAddSubject_Click(object sender, EventArgs e)
        {
            if (AtxtSubjectName.Text.Length == 0 || AtxtTeacherID.Text.Length == 0 || AddlYearLevel.SelectedIndex == 0 || AddlCategory.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please fIll needed information');", true);
            }
             else
             {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO subjects (subject_name, year_level_id, teacher_id, subject_category_id) VALUES  (@subject_name, @year_level_id, @teacher_id, @category)", con);

                cmd.Parameters.AddWithValue("@subject_name", AtxtSubjectName.Text);
                cmd.Parameters.AddWithValue("@teacher_id", AtxtTeacherID.Text);
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
            if (AtxtSubjectName.Text.Length == 0 || AtxtTeacherID.Text.Length == 0 || AddlYearLevel.SelectedIndex == 0 || AddlCategory.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select subject');", true);
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
            if (AtxtSubjectName.Text.Length == 0 || AtxtTeacherID.Text.Length == 0 || AddlYearLevel.SelectedIndex == 0 || AddlCategory.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select subject');", true);
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

        protected void AddlYearLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}