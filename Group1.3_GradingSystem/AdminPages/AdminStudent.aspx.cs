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

        public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            students();
            sections();
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

        public void students()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT * FROM students";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.Rows[GridView1.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = GridView1.SelectedRow;
                TextBox3.Text = gr.Cells[1].Text;
                TextBox1.Text = gr.Cells[2].Text;
                TextBox5.Text = gr.Cells[3].Text;
                TextBox4.Text = gr.Cells[0].Text;
                DropDownList3.SelectedValue = gr.Cells[6].Text;
            }
        }

        protected void GridView1_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex);
            }
        }

        protected void OnPageIndexChangingstudents(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.students();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0 || TextBox1.Text.Length == 0 || TextBox5.Text.Length == 0 || DropDownList3.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please Insert Needed Information');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO students (first_name, last_name, user_id, year_level_id, section_id, school_year_id) VALUES  (@first_name, @last_name, @user_id, @year_level_id, @sections_id, @school_year_id)", con);

                cmd.Parameters.AddWithValue("@first_name", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Last_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@user_id", TextBox5.Text);
                cmd.Parameters.AddWithValue("@school_year_id", DropDownList3.SelectedValue);
                cmd.Parameters.AddWithValue("@sections_id", ddlSection.SelectedValue);
                cmd.Parameters.AddWithValue("@year_level_id", DropDownList4.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                students();

                TextBox3.Text = "";
                TextBox1.Text = "";
                TextBox5.Text = "";
                DropDownList3.SelectedValue = null;
                DropDownList4.SelectedValue = null;
                ddlSection.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0 || TextBox1.Text.Length == 0 || TextBox5.Text.Length == 0 || DropDownList3.SelectedIndex == 0 || ddlSection.SelectedIndex == 0 || DropDownList4.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please Select Student');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE students SET first_name = @first_name, last_name = @last_name, user_id = @user_id, year_level_id = @year_level_id, section_id = @sections_id, school_year_id = @school_year_id WHERE student_id = @student_id", con);

                cmd.Parameters.AddWithValue("@first_name", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Last_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@user_id", TextBox5.Text);
                cmd.Parameters.AddWithValue("@student_id", TextBox4.Text);
                cmd.Parameters.AddWithValue("@school_year_id", DropDownList3.SelectedValue);
                cmd.Parameters.AddWithValue("@year_level_id", DropDownList4.SelectedValue);
                cmd.Parameters.AddWithValue("@sections_id", ddlSection.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                students();

                TextBox3.Text = "";
                TextBox1.Text = "";
                TextBox5.Text = "";
                DropDownList4.SelectedValue = null;
                DropDownList3.SelectedValue = null;
                ddlSection.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully');", true);
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please Select Student');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE student_id = @student_id", con);

                cmd.Parameters.AddWithValue("@student_id", TextBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                clear();
                students();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully');", true);
            }
        }
        protected void clear()
        {
            TextBox3.Text = String.Empty;
            TextBox1.Text = String.Empty;
            TextBox5.Text = String.Empty;
            TextBox4.Text = String.Empty;
            DropDownList4.SelectedValue = null;
            DropDownList3.SelectedValue = null;
            ddlSection.SelectedValue = null;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox3.Text = String.Empty;
            TextBox1.Text = String.Empty;
            TextBox5.Text = String.Empty;
            TextBox4.Text = String.Empty;
            DropDownList4.SelectedValue = null;
            DropDownList3.SelectedValue = null;
            ddlSection.SelectedValue = null;


            students();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Cleared Successfully');", true);
        }
        public void sections()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT * FROM sections";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            con.Close();
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
        protected void OnPageIndexChangingsections(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            this.sections();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.Rows[GridView2.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = GridView2.SelectedRow;
            }
        }
        public void Sections()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM sections", con);
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

        protected void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sections();
        }
    }
}