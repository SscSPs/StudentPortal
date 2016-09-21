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
    public partial class attandance : System.Web.UI.Page
    {
        static string path;
        static string constring;
        SqlConnection con;
        protected System.Web.UI.WebControls.Panel PnlControl;
        List<string> rollnumbers;
        CheckBox[] chckbx;

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

                rollnumbers = Reader("select Rollno from StudentDetails where Batch='" + Batch.Text + "'");
                chckbx = new CheckBox[rollnumbers.Count];

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
                AddCheckboxes(rollnumbers);
            }
            else
                Subject.Items.Clear();
        }
        
        private void AddCheckboxes(List<string> rolls)
        {
            int i = 0;
            try
            {
                foreach (string rollno in rolls)
                {
                    chckbx[i] = new CheckBox();
                    chckbx[i].ID = rollno;
                    chckbx[i].Text = rollno;
                    Panel1.Controls.Add(chckbx[i]);
                    if ((i+1) % 4 == 0)
                        Panel1.Controls.Add(new LiteralControl("<br />"));
                    else
                        Panel1.Controls.Add(new LiteralControl("&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; "));
                    i++;
                }
            }
            catch { }
        }
        
        public bool IsValidField(SqlConnection objCon, string tableName, string columnName)
        {
            const string query = "SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS"
                                    + " WHERE TABLE_NAME = @TABLENAME AND"
                                    + " COLUMN_NAME = @COLUMNNAME";

            using (var cmd = new SqlCommand(query, objCon))
            {
                cmd.Parameters.Add("@TABLENAME", SqlDbType.NVarChar, 128).Value = tableName;
                cmd.Parameters.Add("@COLUMNNAME", SqlDbType.NVarChar, 128).Value = columnName;
                var objvalid = cmd.ExecuteScalar(); // will return 1 or null
                return objvalid != null;
            }
        }
    }
}