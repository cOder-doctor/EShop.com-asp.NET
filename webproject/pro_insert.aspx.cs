using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;

using System.Data;

using System.Data.SqlClient;

using System.IO;

using System.Configuration;

namespace _web_project
{
    public partial class pro_insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null)
            {
                Session["login"] = "something";
                Response.Redirect("login.aspx");
            }
            else
            {
                Session["login"] = null;
            }
            if (Session["ss"] != null)
            {
                Label3.Text = "Product Insert Successfully";
            }
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            if (dt != null)
            {
                Label1.Text = dt.Rows.Count.ToString();
            }
            else
            {
                Label1.Text = "0";
            }

            if (Session["New"] != null)
            {
                Button6.Text = Session["New"].ToString();
            }
            if (IsPostBack)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    String checkuser = "select count(*) from [Table] where pro_name = '" + TextBox1.Text + "'";
                    SqlCommand com = new SqlCommand(checkuser, conn);
                    int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                    if (temp == 1)
                    {
                        Response.Write("Product already Exists");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("Error:" + ex.ToString());
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                    Session["ss"] = null;
                    string filename2 = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/Image/" + filename2));

                    Guid newGuid = Guid.NewGuid();
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    String insertquery = "insert into [Table] (Id,pro_name,pro_size,pro_price,pro_description,pro_address,pro_add,pro_image,pro_mobile,pro_email,pro_username) values (@Id,@name,@size,@price,@description,@address,@add,@image,@mobile,@email,@uname)";
                    SqlCommand com = new SqlCommand(insertquery, conn);
                    double x = Convert.ToDouble(TextBox3.Text);
                    double ss= (x *.05)+x;
                    com.Parameters.AddWithValue("@Id", newGuid.ToString());
                    com.Parameters.AddWithValue("@name", TextBox1.Text);
                    com.Parameters.AddWithValue("@size", TextBox2.Text);
                    com.Parameters.AddWithValue("@price", string.Format("{0:N2}", Math.Ceiling(ss)));
                    com.Parameters.AddWithValue("@description", DropDownList1.Text);
                    com.Parameters.AddWithValue("@address", DropDownList2.Text);
                    com.Parameters.AddWithValue("@add", TextBox4.Text);
                    com.Parameters.AddWithValue("@image", "Image/" + filename2);
                    com.Parameters.AddWithValue("@mobile", TextBox6.Text);
                    com.Parameters.AddWithValue("@email", TextBox7.Text);
                    com.Parameters.AddWithValue("@uname", Session["New"].ToString());
                    com.ExecuteNonQuery();
                    conn.Close();
                    Session["ss"] = "asdf";
                    Response.Redirect("pro_insert.aspx");
            
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            string JQueryVer = "1.7.1";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
                DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });
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

        protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}