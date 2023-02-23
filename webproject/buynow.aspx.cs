using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _web_project
{
    public partial class buynow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                Guid newGuid = Guid.NewGuid();
                string pro_id, pro_uname, buyer_uname, buyer_id, buyer_address, buyer_mob, buyer_email, pro_address, pro_mob, pro_email, pro_price, pro_name, pro_size, pro_image;
                pro_id = Session["product_id"].ToString();
                SqlConnection scon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                scon.Open();
                String chkpas = "select Id from [Table2] where Username = '" + Session["New"].ToString() + "'";
                SqlCommand com2 = new SqlCommand(chkpas, scon);
                buyer_id = com2.ExecuteScalar().ToString();
                buyer_uname = Session["New"].ToString();
                chkpas = "select Address from [Table2] where Username = '" + Session["New"].ToString() + "'";
                com2 = new SqlCommand(chkpas, scon);
                buyer_address = com2.ExecuteScalar().ToString();
                chkpas = "select Contact_no from [Table2] where Username = '" + Session["New"].ToString() + "'";
                com2 = new SqlCommand(chkpas, scon);
                buyer_mob = com2.ExecuteScalar().ToString();
                chkpas = "select Email from [Table2] where Username = '" + Session["New"].ToString() + "'";
                com2 = new SqlCommand(chkpas, scon);
                buyer_email = com2.ExecuteScalar().ToString();
                chkpas = "select pro_address from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_address = com2.ExecuteScalar().ToString();
                chkpas = "select pro_add from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                string pro_add = com2.ExecuteScalar().ToString();
                chkpas = "select pro_mobile from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_mob = com2.ExecuteScalar().ToString();
                chkpas = "select pro_email from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_email = com2.ExecuteScalar().ToString();
                chkpas = "select pro_size from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_size = com2.ExecuteScalar().ToString();
                chkpas = "select pro_price from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_price = com2.ExecuteScalar().ToString();
                chkpas = "select pro_image from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_image = com2.ExecuteScalar().ToString();
                chkpas = "select pro_name from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_name = com2.ExecuteScalar().ToString();
                chkpas = "select pro_username from [Table] where Id = '" + pro_id + "'";
                com2 = new SqlCommand(chkpas, scon);
                pro_uname = com2.ExecuteScalar().ToString();
                string aid = newGuid.ToString();
                String query = "insert into [admin] (Id,buyer_id,pro_id,buyer_username,buyer_address,buyer_contact_no,buyer_email,pro_name,pro_size,pro_price,pro_address,pro_add,pro_contact_no,pro_email,pro_image,pro_username) values('" + aid + "','" + buyer_id + "','" + pro_id + "','" + buyer_uname + "','" + buyer_address + "','" + buyer_mob + "','" + buyer_email + "','" + pro_name + "','" + pro_size + "','" + pro_price + "','" + pro_address + "','" + pro_add + "','" + pro_mob + "','" + pro_email + "','" + pro_image + "','" + pro_uname + "')";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = scon;
                cmd.ExecuteNonQuery();
                query = "insert into [backup] (Id,pro_name,pro_size,pro_price,pro_description,pro_address,pro_image,pro_mobile,pro_rating,pro_email,pro_username) select Id,pro_name,pro_size,pro_price,pro_description,pro_address,pro_image,pro_mobile,pro_rating,pro_email,pro_username from [Table] where Id= '" + pro_id + "'";
                cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = scon;
                cmd.ExecuteNonQuery();
                query = "delete from [Table] where Id = '" + pro_id + "'";
                cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = scon;
                cmd.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine(query);
                Session["payment_id"] = aid;
                scon.Close();
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

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection scon2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            scon2.Open();
            string sss = "cash on delivery";
            String query = "update [admin] set payment = '" + sss + "' where Id= '" + Session["payment_id"].ToString() + "'";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = query;
            cmd2.Connection = scon2;
            cmd2.ExecuteNonQuery();
            scon2.Close();
            Response.Redirect("RDLC_Report.aspx");
        }
    }
}