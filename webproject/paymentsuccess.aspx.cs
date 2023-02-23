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
    public partial class paymentsuccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null)
            {
                Response.Redirect("login.aspx");
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection scon2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            scon2.Open();
            String query = "update [admin] set payment = '" + TextBox1.Text + "' where Id= '" + Session["payment_id"].ToString() + "'";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = query;
            cmd2.Connection = scon2;
            cmd2.ExecuteNonQuery();
            scon2.Close();
            Session["tran"] = TextBox1.Text;
            Response.Redirect("RDLC_Report.aspx");
        }
    }
}