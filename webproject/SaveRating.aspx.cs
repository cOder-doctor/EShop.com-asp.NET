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
    public partial class SaveRating : System.Web.UI.Page
    {
        static String proid;
        static int totalrating;
        static int totalrows;
        static float overallrating;
        static String rating;
        string idd;
        string pname;
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label2.Text = Request.QueryString["id"].ToString();
           // Label3.Text = Request.QueryString["product_name"].ToString();
           // Label4.Text = Request.QueryString["Rating"].ToString() + " out of 5";
            if (!Page.IsPostBack)
            {
                proid = Request.QueryString["one"].ToString();
                SqlConnection mycon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                mycon.Open();
                String myquery = "Select sum(rating) from [Table3] where Id= '" + proid + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;
                cmd.Connection = mycon;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0] is DBNull)
                    {
                        ds.Tables[0].Rows[0][0] = "0";
                        totalrating = 0;
                    }
                    else
                        totalrating = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
                }
                mycon.Close();
                countrows();
                overallrating = (totalrating / (float)totalrows);
                //Label4.Text = string.Format("{0:f1}", overallrating) +"      out of 5 ";
                SqlConnection scon2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                scon2.Open();
                String query = "update [Table] set pro_rating = '" + overallrating + "' where id= '" + proid + "'";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = query;
                cmd2.Connection = scon2;
                cmd2.ExecuteNonQuery();
                scon2.Close();
                if (Request.QueryString["one"] != null)
                {
                    DataList1.DataSourceID = null;
                    DataList1.DataSource = SqlDataSource1;
                    DataList1.DataBind();
                }
            }
            if (Session["New"] != null)
            {
                Label1.Text = Session["New"].ToString();
                Button6.Text = Session["New"].ToString();
            }
           
        }
        private void countrows()
        {
            SqlConnection mycon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            mycon.Open();
            String myquery = "Select * from [Table3] where Id= '"+proid+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = mycon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            totalrows = ds.Tables[0].Rows.Count;
            mycon.Close();
            System.Diagnostics.Debug.WriteLine(totalrating);
            System.Diagnostics.Debug.WriteLine(totalrows);
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
            String query = "insert into [Table3](Id,Product_name,Rating) values('" + idd + "','" + pname + "'," + Convert.ToInt16(rating.ToString()) + ")";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = scon;
            cmd.ExecuteNonQuery();
            System.Diagnostics.Debug.WriteLine(pname);
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.CommandArgument.ToString());
            if (e.CommandName == "addtocart")
            {
                Response.Redirect("AddtoCart.aspx?id=" + e.CommandArgument.ToString());
            }
            if (e.CommandName == "buynow")
            {
                Session["product_id"] = e.CommandArgument.ToString();

                Response.Redirect("buynow.aspx?id=" + e.CommandArgument.ToString());

            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton4_Command(object sender, CommandEventArgs e)
        {

        }

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {

        }



    }
}