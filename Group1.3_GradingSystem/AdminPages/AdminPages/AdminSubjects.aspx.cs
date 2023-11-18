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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
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
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.GridView3, "Select$" + e.Row.RowIndex);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO subjects (subject_name, year_level_id, teacher_id) VALUES  (@subject_name, @year_level_id, @teacher_id)", con);

            cmd.Parameters.AddWithValue("@subject_name", TextBox3.Text);
            cmd.Parameters.AddWithValue("@teacher_id", TextBox4.Text);
            cmd.Parameters.AddWithValue("@year_level_id", DropDownList1.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();

            subjects();

            TextBox3.Text = "";
            TextBox4.Text = "";
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE subjects SET subject_name = @subject_name, teacher_id = @teacher_id, year_level_id = @year_level_id WHERE subject_id = @subject_id", con);

            cmd.Parameters.AddWithValue("@subject_name", TextBox3.Text);
            cmd.Parameters.AddWithValue("@teacher_id", TextBox4.Text);
            cmd.Parameters.AddWithValue("@year_level_id", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@subject_id", TextBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            subjects();

            TextBox3.Text = "";
            TextBox4.Text = "";
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM subjects WHERE subject_id = @subject_id", con);

            cmd.Parameters.AddWithValue("@subject_id", TextBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            clear();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
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
        }
    }
}