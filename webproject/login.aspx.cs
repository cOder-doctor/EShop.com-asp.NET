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
    public partial class login : System.Web.UI.Page
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
            if(Session["buyitems"]!=null)
                Session.Remove("buyitems");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            username.Text = username.Text;
            logpass.Text = logpass.Text;
        }
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            String checkuser = "select count(Id) from [Table2] where (Username = '" + username.Text + "' COLLATE SQL_LATIN1_General_CP1_CS_AS)";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = (int)com.ExecuteScalar();
            if (temp == 1)
            {
                String chkpas = "select Password from [Table2] where Username = '" + username.Text + "'";
                SqlCommand com2 = new SqlCommand(chkpas, conn);
                System.Diagnostics.Debug.WriteLine(username.Text);
                string pass = com2.ExecuteScalar().ToString().Replace(" ", "");
                if (pass==logpass.Text)
                {
                    Session["New"] = username.Text;
                    //System.Diagnostics.Debug.WriteLine(Session["New"]);
                    if (CheckBox1.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("userinfo");
                        cookie["username"] = username.Text;
                        cookie["password"] = logpass.Text;
                        cookie.Expires = DateTime.Now.AddDays(60);
                        Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        if ((Request.Cookies["userinfo"] != null))
                        {
                            Response.Cookies["userinfo"].Expires = DateTime.Now.AddDays(-30);
                        }
                    }
                    Response.Redirect("home.aspx");
                }
                else
                {
                    if ((Request.Cookies["userinfo"] != null))
                    {
                        Response.Cookies["userinfo"].Expires = DateTime.Now.AddDays(-30);
                    }
                   // Response.Redirect("login.aspx");
                    Response.Write("Password is not correct");
                }

            }
            else
            {
                if ((Request.Cookies["userinfo"] != null))
                {
                    Response.Cookies["userinfo"].Expires = DateTime.Now.AddDays(-30);
                }
                //Response.Redirect("login.aspx");
                Response.Write("Username is not correct");
            }
            conn.Close();
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("ResetPassword.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}