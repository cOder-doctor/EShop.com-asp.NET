using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace _web_project
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                Button6.Text = Session["New"].ToString();

                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                String un = Session["New"].ToString();
                String checkuser = "select count(username) from [admindata] where (username = 'un' COLLATE SQL_LATIN1_General_CP1_CS_AS)";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = (int)com.ExecuteScalar();
                if (temp == 1)
                {

                    if (Session["confirm"] != null)
                    {
                        Label2.Text = Session["confirm"].ToString() + " product has been confirmed";
                    }
                    if (Session["notconfirm"] != null)
                    {
                        Label2.Text = Session["notconfirm"].ToString() + " product has been reallocated to product table";
                    }
               }
                else
                {
                    Response.Redirect("adminLogin.aspx");
                }


            }*/
            }

            else
            {
                Response.Redirect("adminLogin.aspx");
            }
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

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }



        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

        }
        protected void ImageButton5_Command(object sender, CommandEventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string pro_id = e.CommandArgument.ToString();
            String query = "insert into [Table] (Id,pro_name,pro_size,pro_price,pro_description,pro_address,pro_image,pro_mobile,pro_rating,pro_email,pro_username) select Id,pro_name,pro_size,pro_price,pro_description,pro_address,pro_image,pro_mobile,pro_rating,pro_email,pro_username from [backup] where Id= '" + pro_id + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            query = "delete from [backup] where Id = '" + pro_id + "'";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            query = "delete from [admin] where pro_id = '" + pro_id + "'";
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            Session["confirm"] = null ;
            Session["notconfirm"] = pro_id;
            Response.Redirect("admin.aspx");
        }
        protected void ImageButton4_Command(object sender, CommandEventArgs e)
        {
            String id = e.CommandArgument.ToString();
            String buyname, sellname, buyemail, sellemail, proname, prosize, proprice;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            String chkpas = "select buyer_username from [admin] where Id = '" + id + "'";
            SqlCommand com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            buyname = com2.ExecuteScalar().ToString();
            chkpas = "select pro_username from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            sellname = com2.ExecuteScalar().ToString();
            chkpas = "select pro_id from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            string pro_id = com2.ExecuteScalar().ToString();
            chkpas = "select buyer_email from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            buyemail = com2.ExecuteScalar().ToString();
            chkpas = "select pro_email from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            sellemail = com2.ExecuteScalar().ToString();
            chkpas = "select pro_name from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            proname = com2.ExecuteScalar().ToString();
            chkpas = "select pro_price from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            proprice = com2.ExecuteScalar().ToString();
            chkpas = "select pro_size from [admin] where Id = '" + id + "'";
            com2 = new SqlCommand(chkpas, conn);
            //System.Diagnostics.Debug.WriteLine(username.Text);
            prosize = com2.ExecuteScalar().ToString();
            // StringBuilder class is present in System.Text namespace
            /*MailMessage mailMessage = new MailMessage("hossain1707020@stud.kuet.ac.bd", buyemail);
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("<b>");
            sbEmailBody.Append("       Eshop.com   " + "<br/><br/>");
            sbEmailBody.Append("</b>");
            sbEmailBody.Append("<b>");
            sbEmailBody.Append("Congratulations " + buyname + ",<br/>");
            sbEmailBody.Append("</b>");
            sbEmailBody.Append("You have successfully purchased " + "<br/>");
            sbEmailBody.Append("Product: " + proname + "<br/>");
            sbEmailBody.Append("Quantity: " + prosize + "<br/>");
            sbEmailBody.Append("price: " + proprice + "<br/><br/>");
            //sbEmailBody.Append("<br/>"); sbEmailBody.Append("http://localhost:60485/ChangePassword.aspx?uid=" + UniqueId);
            //sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>Please wait for 1-3 days until we deliver your product</b><br/><br/>");
            sbEmailBody.Append("<b>Thanks for buying product from our website</b>");
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Confirmation message";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                /
                UserName = "tamim@gmail.com",
                Password = "tamim"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);


            mailMessage = new MailMessage("hossain1707020.kuet.ac.bd", sellemail);
            sbEmailBody = new StringBuilder();
            sbEmailBody.Append("<b>");
            sbEmailBody.Append("       Eshop.com   ");
            sbEmailBody.Append("</b>");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>");
            sbEmailBody.Append("Congratulations " + sellname + ",<br/><br/>");
            sbEmailBody.Append("</b>");
            sbEmailBody.Append("Your product has been successfully purchased <br/>");
            sbEmailBody.Append("Product: " + proname + "<br/>");
            sbEmailBody.Append("Quantity: " + prosize + "<br/>");
            sbEmailBody.Append("price: " + proprice + "<br/><br/>");
            //sbEmailBody.Append("<br/>"); sbEmailBody.Append("http://localhost:60485/ChangePassword.aspx?uid=" + UniqueId);
            //sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>Thanks for selling product on our website</b>");
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Confirmation message";
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
               

                UserName = "tamim@gmail.com",
                Password = "tamim"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);*/
            String insertquery = "insert into [adminbackup] (Id,buyer_id,pro_id,buyer_username,buyer_address,buyer_contact_no,buyer_email,pro_name,pro_size,pro_price,pro_address,pro_add,pro_contact_no,pro_email,pro_image,pro_username,payment) select Id,buyer_id,pro_id,buyer_username,buyer_address,buyer_contact_no,buyer_email,pro_name,pro_size,pro_price,pro_address,pro_add,pro_contact_no,pro_email,pro_image,pro_username,payment from [admin] where Id= '" + id + "'";
            SqlCommand com = new SqlCommand(insertquery, conn);
            com.ExecuteNonQuery();
            string query = "delete from [backup] where Id = '" + pro_id + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            String deletequery = "delete from [admin] where Id = '" + id + "'";
            com = new SqlCommand(deletequery, conn);
            com.ExecuteNonQuery();
            conn.Close();
            Session["confirm"] = proname;
            Session["notconfirm"] = null;
            Response.Redirect("admin.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void pro_data_Click(object sender, EventArgs e)
        {
            Response.Redirect("pro_database.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Redirect("home.aspx");
        }
    }
}