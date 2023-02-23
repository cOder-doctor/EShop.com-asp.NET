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
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["search"] != null)
            {
                Label2.Text = " দুঃখিত আপনার প্রোডাক্টটি আমাদের কাছে নেই ";
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

        protected void Button7_Click(object sender, EventArgs e)
        {
            string iid;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            String chkpas = "select Id from [table] where pro_name = '" + TextBox1.Text + "'";
            SqlCommand com2 = new SqlCommand(chkpas, conn);
            System.Diagnostics.Debug.WriteLine(com2.ExecuteScalar());
            System.Diagnostics.Debug.WriteLine(com2.ExecuteScalar());
            if(com2.ExecuteScalar() == null)
            {
                Session["search"] = TextBox1.Text;
                Response.Redirect("search.aspx");

            }
            else
            {
                iid = com2.ExecuteScalar().ToString();
                Response.Redirect("SaveRating.aspx?one=" + iid);
                Session["search"] = null;
            }
            //System.Diagnostics.Debug.WriteLine(e.CommandArgument.ToString());
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}