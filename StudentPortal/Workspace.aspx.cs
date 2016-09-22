using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class Workspace : System.Web.UI.Page
    {

        static string path;
        static string constring;
        SqlConnection con;
        public bool loginsuccess = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            if (Login.login_success != true && !this.IsPostBack)
            {
                List<string> presentdays; List<string> totaldays;
                Response.Redirect("Login.aspx");
                {
                    openconnection();
                    totaldays = Reader("select totaldays from StudentDetails where Rollno = '" + Login.person + "'");
                    presentdays = Reader("select presentdays from StudentDetails where Rollno = '" + Login.person + "'");
                    con.Close();
                    Label2.Text = ((int.Parse(presentdays[0])/ int.Parse(totaldays[0]))*100).ToString();
                }
            }
            Login.person = "";
            Login.login_success = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button2.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Success')</script>");
            Button2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
        }


        void openconnection()
        {
            path = Server.MapPath(null);
            constring = ConfigurationManager.ConnectionStrings["dbconnectionPart1"].ConnectionString + path + ConfigurationManager.ConnectionStrings["dbconnectionPart2"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
        }

        private List<string> Reader(string sqCommand)
        {
            using (SqlCommand cmd = new SqlCommand(sqCommand, con))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    string av = null;
                    av = reader[0].ToString();
                    list.Add(av);
                }
                return list;
            }
        }
    }
}