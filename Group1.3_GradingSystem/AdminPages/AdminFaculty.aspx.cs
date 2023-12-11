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

namespace Group1._3_GradingSystem.AdminPages
{
    public partial class AdminFaculty : System.Web.UI.Page
    {
        public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            users();
            teachers();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }
        public void users()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT * FROM users WHERE user_level = 'Teacher' ";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();
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
            GridView2.DataSource = dt;
            GridView2.DataBind();
            con.Close();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 0 || TextBox8.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please insert needed information');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo]. [users] (username ,password, user_level) VALUES  (@username, @password,@user_level)", con);

                cmd.Parameters.AddWithValue("@username", TextBox4.Text);
                cmd.Parameters.AddWithValue("@password", TextBox8.Text);
                cmd.Parameters.AddWithValue("@user_level", "Teacher");
                cmd.ExecuteNonQuery();
                con.Close();

                users();

                TextBox4.Text = "";
                TextBox8.Text = "";
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            this.users();
        }
        protected void OnPageIndexChangingTeacher(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            this.teachers();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 0 || TextBox8.Text.Length == 0 || TextBox9.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select needed information');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE users SET username = @username, password = @password WHERE user_id = @userid", con);

                cmd.Parameters.AddWithValue("@username", TextBox4.Text);
                cmd.Parameters.AddWithValue("@password", TextBox8.Text);
                cmd.Parameters.AddWithValue("@userid", TextBox9.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                users();

                TextBox4.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully');", true);
            }
        }

        protected void GridView2_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView2, "Select$" + e.Row.RowIndex);
            }
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.Rows[GridView2.SelectedIndex];
            if (row != null)
            {
                
                GridViewRow gr = GridView2.SelectedRow;
                TextBox6.Text = gr.Cells[2].Text;
                TextBox7.Text = gr.Cells[1].Text;
                TextBox10.Text = gr.Cells[3].Text;

                
            }
        }
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected row
            GridViewRow row = GridView3.Rows[GridView3.SelectedIndex];
            if (row != null)
            {
                
                GridViewRow gr = GridView3.SelectedRow;
                TextBox4.Text = gr.Cells[1].Text;
                TextBox8.Text = gr.Cells[2].Text;
                TextBox9.Text = gr.Cells[0].Text;
                TextBox10.Text = gr.Cells[0].Text;

                TextBox7.Text = string.Empty;
                TextBox6.Text = string.Empty;
                

            }
        }
        protected void GridView3_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView3, "Select$" + e.Row.RowIndex);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 0 || TextBox8.Text.Length == 0 || TextBox9.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select teacher information');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE user_id = @userid", con);

                cmd.Parameters.AddWithValue("@userid", TextBox9.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                users();
                clear();
                
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully');", true);
            }
        }
        protected void clear()
        {
            TextBox4.Text = String.Empty;
            TextBox8.Text = String.Empty;
            TextBox9.Text = String.Empty;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox4.Text = string.Empty;
            TextBox8.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox10.Text = string.Empty;
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox6.Text = string.Empty;
            TextBox7.Text = string.Empty;
            TextBox10.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox7.Text.Length == 0 || TextBox6.Text.Length == 0 || TextBox10.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please insert needed information');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo]. [teachers] (first_name ,last_name, user_id) VALUES  (@Firstname, @Lastname, @user_id)", con);

                cmd.Parameters.AddWithValue("@Firstname", TextBox7.Text);
                cmd.Parameters.AddWithValue("@Lastname", TextBox6.Text);
                cmd.Parameters.AddWithValue("@user_id", TextBox10.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                teachers();

                TextBox7.Text = "";
                TextBox6.Text = "";
                TextBox10.Text = "";
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox7.Text.Length == 0 || TextBox6.Text.Length == 0 || TextBox10.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select needed information');", true);
            }
            else
            {

            
                SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE teachers SET Firstname = @Firstname, Lastname = @Lastname WHERE user_id = @user_id", con);

            cmd.Parameters.AddWithValue("@Firstname", TextBox7.Text);
            cmd.Parameters.AddWithValue("@Lastname", TextBox6.Text);
            cmd.Parameters.AddWithValue("@user_id", TextBox10.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            teachers();

            TextBox7.Text = "";
            TextBox6.Text = "";
            TextBox10.Text = "";
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully');", true);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox10.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select needed information');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM teachers WHERE teacher_id = @ID", con);

                cmd.Parameters.AddWithValue("@ID", TextBox10.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                teachers();

                clear();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully');", true);
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string qry = "SELECT * FROM users WHERE username LIKE '%" + TextBox3.Text + "%'";
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();
            con.Close();
        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string qry = "SELECT * FROM teachers WHERE Firstname LIKE '%" + TextBox11.Text + "%'";
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(qry, con);
            DataTable asd = new DataTable();
            ad.Fill(asd);
            GridView2.DataSource = asd;
            GridView2.DataBind();
            con.Close();
        }
    }
}