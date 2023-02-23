using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace _web_project
{
    public partial class Default : System.Web.UI.Page
    {
        static String rating;
        string idd;
        string pname;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataList1.DataSourceID = null;
                DataList1.DataSource = SqlDataSource1;
                DataList1.DataBind();
                if (Request.QueryString["cat"] != null)
                {
                    DataList1.DataSourceID = null;
                    DataList1.DataSource = SqlDataSource2;
                    DataList1.DataBind();
                }
                if (Request.QueryString["des"] != null)
                {
                    DataList1.DataSourceID = null;
                    DataList1.DataSource = SqlDataSource3;
                    DataList1.DataBind();
                }
            }
            else
            {

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

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "addtocart")
            {
                Response.Redirect("AddtoCart.aspx?id=" + e.CommandArgument.ToString());
            }
            if (e.CommandName == "buynow")
            {
                Session["product_id"] = e.CommandArgument.ToString();
               
                Response.Redirect("buynow.aspx?id=" + e.CommandArgument.ToString());

            }
            if (e.CommandName == "ratingproduct")
            {
                Label lb = e.Item.FindControl("Label2") as Label;
                Response.Redirect("SaveRating.aspx?one=" + e.CommandArgument.ToString());
                System.Diagnostics.Debug.WriteLine(e.CommandArgument.ToString());
            }
        }

        protected void Rating1_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            rating = e.Value.ToString();
            if (rating == null)
            {
                rating = "1";
            }
            AjaxControlToolkit.Rating _rating = (AjaxControlToolkit.Rating)sender;
            DataListItem item = (DataListItem)_rating.NamingContainer;
            if (item != null)
            {
                idd = (string)DataList1.DataKeys[item.ItemIndex];
            }
            SqlConnection scon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            scon.Open();
            String chkpas = "select pro_name from [Table] where Id = '" + idd + "'";
            SqlCommand com2 = new SqlCommand(chkpas, scon);
            pname = com2.ExecuteScalar().ToString();
            String query = "insert into [Table3](Id,Product_name,Rating) values('"+idd+"','"+pname+"'," + Convert.ToInt16(rating.ToString()) + ")";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = scon;
            cmd.ExecuteNonQuery();
            System.Diagnostics.Debug.WriteLine(idd);
            scon.Close();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
          
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {

        }


    }
}