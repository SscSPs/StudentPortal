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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtRegis_click(object sender, EventArgs e)
        {
            
            if (Reg_inp_pass1.Text == Reg_inp_pass2.Text)
            {             
                try
                {
                    string path = Server.MapPath(null);
                    string constring = ConfigurationManager.ConnectionStrings["dbconnectionPart1"].ConnectionString + path + ConfigurationManager.ConnectionStrings["dbconnectionPart2"].ConnectionString;
                    SqlConnection con = new SqlConnection(constring);
                    con.Open();
                    string cmd1, cmd2;
                    cmd1 = "Insert into LoginTable values('"
                        + Reg_inp_Rollnumber.Text
                        + "','" + Reg_inp_pass1.Text + "')";
                    cmd2 = "insert into StudentDetails values('"
                        + Reg_inp_Rollnumber.Text
                        + "', '" + Reg_inp_fname.Text
                        + "', '" + Reg_inp_lname.Text
                        + "', '" + Reg_inp_email.Text + "')";
                    SqlCommand cmd = new SqlCommand(cmd1, con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(cmd2, con);
                    cmd.ExecuteNonQuery();

                    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Done')</script>");
                    con.Close();
                }
                catch
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Error')</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Password not same, check that')</script>");
            }
        }

    }
}