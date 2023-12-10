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
        public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
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
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView3.Rows[GridView3.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = GridView3.SelectedRow;
                TextBox2.Text = gr.Cells[0].Text;
                TextBox3.Text = gr.Cells[1].Text;
                TextBox4.Text = gr.Cells[3].Text;
                DropDownList1.SelectedValue = gr.Cells[2].Text;
                DropDownList3.SelectedValue = gr.Cells[4].Text;
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
        protected void OnPageIndexChangingsubjects(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            this.subjects();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0 || TextBox4.Text.Length == 0 || DropDownList1.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please FIll Needed Information');", true);
            }
             else
             {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO subjects (subject_name, year_level_id, teacher_id, subject_category_id) VALUES  (@subject_name, @year_level_id, @teacher_id, @category)", con);

                cmd.Parameters.AddWithValue("@subject_name", TextBox3.Text);
                cmd.Parameters.AddWithValue("@teacher_id", TextBox4.Text);
                cmd.Parameters.AddWithValue("@year_level_id", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@category", DropDownList3.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                subjects();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
             }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0 || TextBox4.Text.Length == 0 || DropDownList1.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please Select Subject');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE subjects SET subject_name = @subject_name, teacher_id = @teacher_id, year_level_id = @year_level_id, subject_category_id = @category WHERE subject_id = @subject_id", con);

                cmd.Parameters.AddWithValue("@subject_name", TextBox3.Text);
                cmd.Parameters.AddWithValue("@teacher_id", TextBox4.Text);
                cmd.Parameters.AddWithValue("@subject_id", TextBox2.Text);
                cmd.Parameters.AddWithValue("@year_level_id", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@category", DropDownList3.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                subjects();

                TextBox3.Text = "";
                TextBox4.Text = "";
                DropDownList1.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0 || TextBox4.Text.Length == 0 || DropDownList1.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please Select Subject');", true);
            }

            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM subjects WHERE subject_id = @subject_id", con);

                cmd.Parameters.AddWithValue("@subject_id", TextBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                clear();
                subjects();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }
        protected void clear()
        {
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            TextBox4.Text = String.Empty;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            TextBox4.Text = String.Empty;
            DropDownList1.SelectedValue = null;
            DropDownList3.SelectedValue = null;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}