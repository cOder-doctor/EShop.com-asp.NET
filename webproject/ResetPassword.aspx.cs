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
using System.Net.Mail;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _web_project
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spResetPassword2", con);
                cmd.CommandType = CommandType.StoredProcedure;

               // SqlParameter paramUsername = new SqlParameter("@UserName", txtUserName.Text);

                //cmd.Parameters.Add(paramUsername);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (Convert.ToBoolean(rdr["ReturnCode"]))
                    {
                        //SendPasswordResetEmail(rdr["Email"].ToString(), txtUserName.Text, rdr["UniqueId"].ToString());
                        //lblMessage.Text = "An email with instructions to reset your password is sent to your registered email";
                    }
                    else
                    {
                        //lblMessage.ForeColor = System.Drawing.Color.Red;
                        //lblMessage.Text = "Username not found!";
                    }
                }
            }
        }
        private void SendPasswordResetEmail(string ToEmail, string UserName, string UniqueId)
        {
            // MailMessage class is present is System.Net.Mail namespace
            MailMessage mailMessage = new MailMessage("@stud.kuet.ac.bd", ToEmail);

            // StringBuilder class is present in System.Text namespace
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
            sbEmailBody.Append("Please click on the following link to reset your password");
            sbEmailBody.Append("<br/>"); sbEmailBody.Append("http://localhost:60485/ChangePassword.aspx?uid=" + UniqueId);
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("<b>Pragim Technologies</b>");

            mailMessage.IsBodyHtml = true;

            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Reset Your Password";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
               //
               //
            };

            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

        protected void goto_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }
    }
}