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
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    String checkuser = "select count(*) from [Table2] where Username = '" + TextBox6.Text + "'";
                    SqlCommand com = new SqlCommand(checkuser, conn);
                    int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                    if (temp == 1)
                    {
                        Response.Write("User already Exists");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error:" + ex.ToString());
                }

            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                Guid newGuid = Guid.NewGuid();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                Session["Name"] = TextBox2.Text;
                Session["Name1"] = TextBox3.Text;
                if ((string)Session["Name"] == (string)Session["Name1"] && (string)Session["Name"] != "")
                {
                    if ((string)TextBox6.Text != "")
                    {
                        String insertquery = "insert into [Table2] (Id,Username,Password,Firstname,Surname,email,Contact_no,Address) values (@Id ,@uname ,@pass ,@first ,@sur, @email,@con,@add)";
                        SqlCommand com = new SqlCommand(insertquery, conn);
                        com.Parameters.AddWithValue("@Id", newGuid.ToString());
                        com.Parameters.AddWithValue("@uname", TextBox6.Text);
                        com.Parameters.AddWithValue("@pass", TextBox2.Text);
                        com.Parameters.AddWithValue("@first", TextBox1.Text);
                        com.Parameters.AddWithValue("@sur", TextBox4.Text);
                        com.Parameters.AddWithValue("@email", TextBox5.Text);
                        com.Parameters.AddWithValue("@con", TextBox7.Text);
                        com.Parameters.AddWithValue("@add", TextBox8.Text);
                        com.ExecuteNonQuery();

                        Button1.Visible = false;
                        password.Visible = false;
                        password1.Visible = false;
                        password0.Visible = false;
                        TextBox1.Visible = false;
                        TextBox2.Visible = false;
                        TextBox3.Visible = false;
                        TextBox4.Visible = false;
                        TextBox5.Visible = false;
                        TextBox6.Visible = false;
                        username.Visible = false;
                        username3.Visible = false;
                        username4.Visible = false;
                        Response.Redirect("Login.aspx");
                        Response.Write("Registration is successful");
                        conn.Close();
                    }
                    else
                    {
                        Response.Write("</br>" + "Please Enter The Username" + "</br>");

                        Button1.Visible = false;
                        password.Visible = false;
                        password1.Visible = false;
                        password0.Visible = false;
                        TextBox1.Visible = false;
                        TextBox2.Visible = false;
                        TextBox3.Visible = false;
                        TextBox4.Visible = false;
                        TextBox5.Visible = false;
                        TextBox6.Visible = false;
                        username.Visible = false;

                        username3.Visible = false;
                        username4.Visible = false;
                    }

                }
                else
                {
                    Response.Write("</br>" + "Please Enter The same Password" + "</br>");

                    Button1.Visible = false;

                    password.Visible = false;
                    password1.Visible = false;
                    password0.Visible = false;
                    TextBox1.Visible = false;
                    TextBox2.Visible = false;
                    TextBox3.Visible = false;
                    TextBox4.Visible = false;
                    TextBox5.Visible = false;
                    TextBox6.Visible = false;
                    username.Visible = false;

                    username3.Visible = false;
                    username4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}