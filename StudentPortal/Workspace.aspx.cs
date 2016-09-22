using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentPortal
{
    public partial class Workspace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextArea1.Visible = false;
            Button2.Visible = false;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = true;
            TextArea1.Visible = true;
            Button2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}