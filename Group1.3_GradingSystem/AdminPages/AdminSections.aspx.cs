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
        public string conStr = "Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True";
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
            string com = "SELECT sections.section_id, sections.section, year_levels.year_level FROM sections " +
                "INNER JOIN year_levels ON sections.year_level_id=year_levels.year_level_id " +
                "ORDER BY sections.year_level_id ASC";
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            gvSections.DataSource = dt;
            gvSections.DataBind();
            con.Close();
        }
        protected void gvSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvSections.Rows[gvSections.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = gvSections.SelectedRow;
                AtxtSectionID.Text = gr.Cells[0].Text;
                AtxtSection.Text = gr.Cells[1].Text;
                AddlYearLevel.SelectedValue = gr.Cells[2].Text;
            }
        }
        protected void gvSections_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Change the mouse cursor to Hand symbol to show the user the cell is selectable
                e.Row.Attributes["onmouseover"] = "this.style.cursor='hand';this.style.textDecoration='underline';this.style.cursor='Pointer'";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";

                //Attach the click event to each cells
                e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.gvSections, "Select$" + e.Row.RowIndex);
            }
			if (e.Row.RowType == DataControlRowType.Header)
			{
				e.Row.Cells[0].Text = "Section ID";
				e.Row.Cells[1].Text = "Section";
				e.Row.Cells[2].Text = "Year Level";
			}
		}
        protected void OnPageIndexChangingsections(object sender, GridViewPageEventArgs e)
        {
            gvSections.PageIndex = e.NewPageIndex;
            this.sections();
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvSections.Rows[gvSections.SelectedIndex];
            if (row != null)
            {

                GridViewRow gr = gvSections.SelectedRow;
            }
        }
        protected void clear()
        {
            AtxtSectionID.Text = String.Empty;
            AtxtSection.Text = String.Empty;
            AddlYearLevel.SelectedValue = null;
        }
        protected void AbtnAddSection_Click(object sender, EventArgs e)
        {
            string section = AtxtSection.Text.Trim();
			string sectionid = AtxtSectionID.Text.Trim();
			if (section.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Please input section name!','warning');", true);
			}
			else if (AddlYearLevel.SelectedIndex == 0)
            {
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Please select year level!','warning');", true);
			}
			else if (sectionid.Length > 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Section already exist!','warning');", true);
			}
			else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO sections (section, year_level_id) VALUES  (@section, @year_level_id)", con);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@year_level_id", AddlYearLevel.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                sections();

                AtxtSectionID.Text = string.Empty;
                AtxtSection.Text = string.Empty;
                AddlYearLevel.SelectedValue = null;
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Success', 'Section inserted successfully!','success');", true);
			}
        }
        protected void AbtnUpdateSection_Click(object sender, EventArgs e)
        {
			string section = AtxtSection.Text.Trim();
			string sectionid = AtxtSectionID.Text.Trim();
			if (sectionid.Length == 0)
			{
                ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Please select section!','warning');", true);
            }
			else if (section.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Please input section name!','warning');", true);
			}
			else if (AddlYearLevel.SelectedIndex == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Please select year level!','warning');", true);
			}
			else
			{
				SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE sections SET section = @section, year_level_id = @year_level_id WHERE section_id = @section_id", con);

                cmd.Parameters.AddWithValue("@section_id", sectionid);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@year_level_id", AddlYearLevel.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();

                sections();

                AtxtSectionID.Text = string.Empty;
                AtxtSection.Text = string.Empty;
                AddlYearLevel.SelectedValue = null;
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Success', 'Section updated successfully!','success');", true);
			}
        }
        protected void AbtnDeleteSection_Click(object sender, EventArgs e)
        {
			string sectionid = AtxtSectionID.Text.Trim();
			if (sectionid.Length == 0)
			{
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Error', 'Please select section!','warning');", true);
			}
			else
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM sections WHERE section_id = @section_id", con);

                cmd.Parameters.AddWithValue("@section_id", sectionid);
                cmd.ExecuteNonQuery();
                con.Close();

                clear();
                sections();
				ScriptManager.RegisterStartupScript(this, GetType(), "alert", "swal('Success', 'Section deleted successfully!','success');", true);
			}
        }
        protected void AbtnCleatSection_Click(object sender, EventArgs e)
        {
            AtxtSectionID.Text = String.Empty;
            AtxtSection.Text = String.Empty;
            AddlYearLevel.SelectedValue = null;

            sections();
        }
    }
}