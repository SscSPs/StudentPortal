using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Uname.Text = "";
            Pword.Text = "";
        }

        protected void Pword_TextChanged(object sender, EventArgs e)
        {

        }
        protected void ButtLogin_Click(object sender, EventArgs e)
        {
            string path = MapPath(null);
            string constring = ConfigurationManager.ConnectionStrings["dbconnectionPart1"].ConnectionString + path + ConfigurationManager.ConnectionStrings["dbconnectionPart2"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            con.Open(); ;
            SqlCommand cmd = new SqlCommand("select * from LoginTable where Uname=@username and Pword=@password", con);
            cmd.Parameters.AddWithValue("@username", Uname.Text);
            cmd.Parameters.AddWithValue("@password", Pword.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                Response.Redirect("About.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password" + dt.Rows.Count.ToString() + "')</script>");
            }
        }
    }
}