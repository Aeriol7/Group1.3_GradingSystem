using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;
using System.Web.Services.Description;
using System.Net;

namespace Group1._3_GradingSystem.AdminPages
{
    public partial class AdminFaculty : System.Web.UI.Page
    {
        public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            users();
            teachers();
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }
        public void users()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT user_id, username, user_level FROM users";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvUsers.DataSource = dt;
            gvUsers.DataBind();
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
        protected void AAddUserbtn_Click(object sender, EventArgs e)
        {
            if (AtxtUserName.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input username!');", true);
            }
            else if (AtxtPassword.Text.Length == 0)
            {
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input password!');", true);
			}
			else if (AtxtPassword.Text != AtxtConfirmPassword.Text)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Passwords do not match!');", true);
			}
			else if (AddlUserLevel.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select user level!');", true);
			}
			else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO users (username, password, user_level) VALUES (@username, @password, @user_level)", con);

                cmd.Parameters.AddWithValue("@username", AtxtUserName.Text);
                cmd.Parameters.AddWithValue("@password", AtxtPassword.Text);
                cmd.Parameters.AddWithValue("@user_level", AddlUserLevel.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                users();

                AtxtUserName.Text = string.Empty;
                AtxtPassword.Text = string.Empty;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully!');", true);
            }
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsers.PageIndex = e.NewPageIndex;
            this.users();
        }
        protected void OnPageIndexChangingTeacher(object sender, GridViewPageEventArgs e)
        {
            gvTeachers.PageIndex = e.NewPageIndex;
            this.teachers();
        }
        protected void AUpdateUserbtn_Click(object sender, EventArgs e)
        {
			if (AtxtUserID.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select user!');", true);
			}
			else if (AtxtUserName.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input username!');", true);
			}
			else if (AtxtPassword.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input password!');", true);
			}
			else if (AtxtPassword.Text != AtxtConfirmPassword.Text)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Passwords do not match!');", true);
			}
			else if (AddlUserLevel.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select user level!');", true);
			}
			else
			{
				SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE users SET username = @username, password = @password WHERE user_id = @userid", con);

                cmd.Parameters.AddWithValue("@username", AtxtUserName.Text);
                cmd.Parameters.AddWithValue("@password", AtxtPassword.Text);
                cmd.Parameters.AddWithValue("@userid", AtxtUserID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                users();

                AtxtUserName.Text = string.Empty;
                AtxtPassword.Text = string.Empty;
                AtxtUserID.Text = string.Empty;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully!');", true);
            }
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
        protected void gvTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvTeachers.Rows[gvTeachers.SelectedIndex];
            if (row != null)
            {
                GridViewRow gr = gvTeachers.SelectedRow;
                AtxtLastName.Text = gr.Cells[2].Text;
                AtxtFirstName.Text = gr.Cells[1].Text;
                AtxtTeacherUserID.Text = gr.Cells[3].Text;
            }
        }
        protected void gvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected row
            GridViewRow row = gvUsers.Rows[gvUsers.SelectedIndex];
            if (row != null)
            { 
                GridViewRow gr = gvUsers.SelectedRow;
                AtxtUserName.Text = gr.Cells[1].Text;
                AtxtPassword.Text = gr.Cells[2].Text;
                AtxtUserID.Text = gr.Cells[0].Text;
                AtxtTeacherUserID.Text = gr.Cells[0].Text;

                AtxtFirstName.Text = string.Empty;
                AtxtLastName.Text = string.Empty;
            }
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
				e.Row.Cells[0].Text = "User ID";
				e.Row.Cells[1].Text = "User Name";
				e.Row.Cells[2].Text = "User Level";
			}	
		}
        protected void ADeleteUserbtn_Click(object sender, EventArgs e)
        {
			if (AtxtUserID.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select user!');", true);
			}
			else
			{
				SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE user_id = @userid", con);

                cmd.Parameters.AddWithValue("@userid", AtxtUserID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                users();
                clear();
                
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully!');", true);
            }
        }
        protected void clear()
        {
            AtxtUserName.Text = String.Empty;
            AtxtPassword.Text = String.Empty;
            AtxtUserID.Text = String.Empty;
        }
        protected void AClearUserbtn_Click(object sender, EventArgs e)
        {
            AtxtUserName.Text = string.Empty;
            AtxtPassword.Text = string.Empty;
            AtxtUserID.Text = string.Empty;
            AtxtTeacherUserID.Text = string.Empty;
            AtxtLastName.Text = string.Empty;
            AtxtFirstName.Text = string.Empty;
        }
        protected void AbtnClearTeacher_Click(object sender, EventArgs e)
        {
            AtxtLastName.Text = string.Empty;
            AtxtFirstName.Text = string.Empty;
            AtxtTeacherUserID.Text = string.Empty;
        }
        protected void AbtnAddTeacher_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO teachers (first_name ,last_name, user_id) VALUES  (@Firstname, @Lastname, @user_id)", con);

                cmd.Parameters.AddWithValue("@Firstname", AtxtFirstName.Text);
                cmd.Parameters.AddWithValue("@Lastname", AtxtLastName.Text);
                cmd.Parameters.AddWithValue("@user_id", AtxtTeacherUserID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                teachers();

                AtxtFirstName.Text = string.Empty;
                AtxtLastName.Text = string.Empty;
                AtxtTeacherUserID.Text = string.Empty;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully!');", true);
            }
        }
        protected void AbtnUpdateTeacher_Click(object sender, EventArgs e)
        {
			if (AtxtTeacherUserID.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select teacher!');", true);
			}
			else if (AtxtFirstName.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input teacher first name!');", true);
			}
			else if (AtxtLastName.Text.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please input teacher last name!');", true);
			}
			else
            {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE teachers SET firstname = @firstname, lastname = @lastname WHERE user_id = @user_id", con);

            cmd.Parameters.AddWithValue("@firstname", AtxtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", AtxtLastName.Text);
            cmd.Parameters.AddWithValue("@user_id", AtxtTeacherUserID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            teachers();

            AtxtFirstName.Text = string.Empty;
            AtxtLastName.Text = string.Empty;
            AtxtTeacherUserID.Text = string.Empty;
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully!');", true);
            }
        }
        protected void AbtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (AtxtTeacherUserID.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select teacher!');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM teachers WHERE teacher_id = @ID", con);

                cmd.Parameters.AddWithValue("@ID", AtxtTeacherUserID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                teachers();

                clear();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully!');", true);
            }
        }   
	}
}