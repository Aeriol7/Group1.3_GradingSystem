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
            cmd.Parameters.AddWithValue("@user_level", "Techer");
            cmd.ExecuteNonQuery();
            con.Close();


            TextBox4.Text = "";
            TextBox8.Text = "";
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Inserted Successfully');", true);
        }
    }
}