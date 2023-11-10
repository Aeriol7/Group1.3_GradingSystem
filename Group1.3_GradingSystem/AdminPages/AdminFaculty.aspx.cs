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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
            string com = "SELECT * FROM Teacher";
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
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
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected row
            GridViewRow row = GridView3.Rows[GridView3.SelectedIndex];
            if (row != null)
            {
                //Change the cell index(1) of column as per your design
                //Get the Selected row cell values here
                GridViewRow gr = GridView3.SelectedRow;
                TextBox4.Text = gr.Cells[1].Text;
                TextBox8.Text = gr.Cells[2].Text;
                TextBox9.Text = gr.Cells[0].Text;
                

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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE user_id = @userid", con);

            cmd.Parameters.AddWithValue("@userid", TextBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            clear();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
        }
        protected void clear()
        {
            TextBox4.Text = String.Empty;
            TextBox8.Text = String.Empty;
            TextBox9.Text = String.Empty;
        }
    }
}