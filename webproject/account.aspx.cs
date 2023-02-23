using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _web_project
{
    public partial class account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null)
            {
                Session["login"] = "something";
                Response.Redirect("login.aspx");
            }
       
            {
                Session["login"] = null;
                Button6.Text = Session["New"].ToString();

            }
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            String chkpas = "select Firstname from [Table2] where Username = '"+Session["New"].ToString()+"'";
            SqlCommand com2 = new SqlCommand(chkpas, conn);
            Label2.Text=com2.ExecuteScalar().ToString();
            chkpas = "select Surname from [Table2] where Username = '" + Session["New"].ToString() + "'";
            com2 = new SqlCommand(chkpas, conn);
            Label3.Text = com2.ExecuteScalar().ToString();
            chkpas = "select Email from [Table2] where Username = '" + Session["New"].ToString() + "'";
            com2 = new SqlCommand(chkpas, conn);
            Label4.Text = com2.ExecuteScalar().ToString();
            chkpas = "select Contact_no from [Table2] where Username = '" + Session["New"].ToString() + "'";
            com2 = new SqlCommand(chkpas, conn);
            Label5.Text = com2.ExecuteScalar().ToString();
            chkpas = "select Address from [Table2] where Username = '" + Session["New"].ToString() + "'";
            com2 = new SqlCommand(chkpas, conn);
            Label6.Text = com2.ExecuteScalar().ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("pro_insert.aspx");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("account.aspx");
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != null)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                String query = "update [Table2] set Address = '" + TextBox1.Text + "' where Username = '" + Session["New"].ToString() + "'";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = query;
                cmd2.Connection =conn;
                cmd2.ExecuteNonQuery();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            String chkpas = "select Password from [Table2] where Username = '" + Session["New"].ToString() + "'";
            SqlCommand com2 = new SqlCommand(chkpas, conn);
            string pass = com2.ExecuteScalar().ToString().Replace(" ", "");
            System.Diagnostics.Debug.WriteLine(pass);
            System.Diagnostics.Debug.WriteLine(TextBox2.Text);
            if(pass == TextBox2.Text.ToString())
            {
                if (TextBox3.Text == TextBox4.Text)
                {
                    String query = "update [Table2] set Password = '" + TextBox3.Text + "' where Username = '" + Session["New"].ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = query;
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery();
                    Label7.Text = "ধন্যবাদ আপনার তথ্যটি সঠিকভাবে পরিবর্তিত হয়েছে ";
                }
                else
                {
                    Label7.Text = "নতুন ও কনফার্ম পাসওয়ার্ড সঠিকভাবে দিন";
                }
          
            }
            else
            {
                Label7.Text = "আপনার বর্তমান পাসওয়ার্ড সঠিকভাবে দিন";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Redirect("home.aspx");
        }
    }
}