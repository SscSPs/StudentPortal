using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class Registration : System.Web.UI.Page
    {
        static string path;
        static string constring;
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            openconnection();
            Reg_inp_batch.Items.Clear();
            string batchquery = "select BatchName from Batch";
            List<string> batches = Reader(batchquery);
            foreach(string a in batches)
            Reg_inp_batch.Items.Add(a);
            con.Close();
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

        protected void ButtRegis_click(object sender, EventArgs e)
        {
            
            if (Reg_inp_pass1.Text == Reg_inp_pass2.Text)
            {             
               try
                {
                    openconnection();
                    string cmd1, cmd2;
                    cmd1 = "Insert into LoginTable values('"
                        + Reg_inp_Rollnumber.Text
                        + "','" + Reg_inp_pass1.Text + "')";
                    cmd2 = "insert into StudentDetails values('"
                        + Reg_inp_Rollnumber.Text
                        + "', '" + Reg_inp_fname.Text
                        + "', '" + Reg_inp_lname.Text
                        + "', '" + Reg_inp_email.Text
                        + "', '" + Reg_inp_batch.Text + "')";
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

        void openconnection()
        {
            path = Server.MapPath(null);
            constring = ConfigurationManager.ConnectionStrings["dbconnectionPart1"].ConnectionString + path + ConfigurationManager.ConnectionStrings["dbconnectionPart2"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
        }

    }

}