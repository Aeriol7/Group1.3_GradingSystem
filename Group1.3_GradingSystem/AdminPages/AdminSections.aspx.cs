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
    public partial class AdminSections : System.Web.UI.Page
    {
        public string conStr = "Data Source=DESKTOP-4DSNP2P;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            sections();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

        public void sections()
        {
            SqlConnection con = new SqlConnection(conStr);
            string com = "SELECT * FROM sections";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();
            con.Close();
        }
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView3.Rows[GridView3.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = GridView3.SelectedRow;
                TextBox8.Text = gr.Cells[0].Text;
                TextBox4.Text = gr.Cells[1].Text;
                DropDownList4.SelectedValue = gr.Cells[2].Text;
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
        protected void OnPageIndexChangingsections(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            this.sections();
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView3.Rows[GridView3.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = GridView3.SelectedRow;
            }
        }
        protected void clear()
        {
            TextBox8.Text = String.Empty;
            TextBox4.Text = String.Empty;
            DropDownList4.SelectedValue = null;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 0 || DropDownList4.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please insert section or year level');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO sections (section, year_level_id) VALUES  (@section, @year_level_id)", con);
                cmd.Parameters.AddWithValue("@section", TextBox4.Text);
                cmd.Parameters.AddWithValue("@year_level_id", DropDownList4.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                sections();

                TextBox8.Text = "";
                TextBox4.Text = "";
                DropDownList4.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Length == 0 || TextBox8.Text.Length == 0 || DropDownList4.SelectedIndex == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select section');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE sections SET section = @section, year_level_id = @year_level_id WHERE section_id = @section_id", con);

                cmd.Parameters.AddWithValue("@section_id", TextBox8.Text);
                cmd.Parameters.AddWithValue("@section", TextBox4.Text);
                cmd.Parameters.AddWithValue("@year_level_id", DropDownList4.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                sections();

                TextBox8.Text = "";
                TextBox4.Text = "";
                DropDownList4.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Updated Successfully');", true);
            }

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox8.Text.Length == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Please select section');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM sections WHERE section_id = @section_id", con);

                cmd.Parameters.AddWithValue("@section_id", TextBox8.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                clear();
                sections();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Deleted Successfully');", true);
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox8.Text = String.Empty;
            TextBox4.Text = String.Empty;
            DropDownList4.SelectedValue = null;


            sections();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Cleared Successfully');", true);
        }
    }
}