using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group1._3_GradingSystem.TeacherPages
{
	public partial class TeacherSetGradesPage : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O5EH83O;Initial Catalog=HIS_GradingSystem;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True");
			string com = "SELECT * FROM year_levels";
			SqlDataAdapter adpt = new SqlDataAdapter(com, con);
			DataTable dt = new DataTable();
			adpt.Fill(dt);
			ddlGradeLevel.DataSource = dt;
			ddlGradeLevel.DataTextField = "year_level";
			ddlGradeLevel.DataValueField = "year_level_id";
			ddlGradeLevel.DataBind();
		}

		protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HomePage/LoginPage.aspx");
        }

	}
}