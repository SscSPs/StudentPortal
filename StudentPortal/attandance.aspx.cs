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
    public partial class attandance : System.Web.UI.Page
    {
        static string path;
        static string constring;
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            openconnection();
            if (!this.IsPostBack)
            {
                Batch.Items.Clear();
                Subject.Items.Clear();
                Batch.Items.Add("select one..");
                string batchquery = "select BatchName from Batch";
                List<string> batches = Reader(batchquery);
                foreach (string a in batches)
                    Batch.Items.Add(a);
            }
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
                    string av;
                    av = reader[0].ToString();
                    list.Add(av);
                }
                return list;
            }
        }


        void openconnection()
        {
            path = Server.MapPath(null);
            constring = ConfigurationManager.ConnectionStrings["dbconnectionPart1"].ConnectionString + path + ConfigurationManager.ConnectionStrings["dbconnectionPart2"].ConnectionString;
            con = new SqlConnection(constring);
            con.Open();
        }

        protected void Batch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Batch.Text != "select one..")
            {
                openconnection();
                List<string> list = new List<string>();
                string asd = "select * from Batch where BatchName = '" + Batch.Text + "'";
                using (SqlCommand cmd = new SqlCommand(asd, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string av;
                        for (int i = 1; reader[i].ToString() != ""; i++)
                        {
                            av = reader[i].ToString();
                            list.Add(av);
                        }
                    }
                }
                Subject.Items.Clear();
                foreach (string ab in list)
                    Subject.Items.Add(ab);
                con.Close();
            }
            else
                Subject.Items.Clear();
        }
    }
}