using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace _web_project
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                Label1.Text = "You have to log in first";
            }

            HttpCookie cookie = Request.Cookies["userinfo"];
            if (cookie != null)
            {
                username.Text = cookie["username"];
                logpass.Text = cookie["password"];
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            String checkuser = "select count(username) from [admindata] where (username = '" + username.Text + "' COLLATE SQL_LATIN1_General_CP1_CS_AS)";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = (int)com.ExecuteScalar();
            if (temp == 1)
            {
                String chkpas = "select password from [admindata] where username = '" + username.Text + "'";
                SqlCommand com2 = new SqlCommand(chkpas, conn);
                System.Diagnostics.Debug.WriteLine(username.Text);
                string pass = com2.ExecuteScalar().ToString().Replace(" ", "");
                if (pass == logpass.Text)
                {
                    Session["New"] = username.Text;
                    System.Diagnostics.Debug.WriteLine(Session["New"]);
                    Response.Redirect("admin.aspx");
                }
            }
        }
    }
}
    
