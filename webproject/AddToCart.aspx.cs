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
    public partial class AddToCart : System.Web.UI.Page
    {
        static int sum = 0;
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
                Button6.Text = Session["New"].ToString();
            }
                if (!IsPostBack)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("sno");
                    dt.Columns.Add("Id");
                    dt.Columns.Add("pro_name");
                    dt.Columns.Add("pro_size");
                    dt.Columns.Add("pro_price");
                    dt.Columns.Add("pro_image");
                    //dt.Columns.Add("cost");
                    //dt.Columns.Add("totalcost");
                    if (Request.QueryString["id"] != null)
                    {
                        if (Session["buyitems"] == null)
                        {
                            DataRow dr = dt.NewRow();
                            SqlConnection scon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                            scon.Open();
                            String myquery = "select * from [Table] where Id = '" +Request.QueryString["id"]+"'";
                            SqlCommand cmd = new SqlCommand(myquery, scon);
                            System.Diagnostics.Debug.WriteLine(myquery);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dr["sno"] = 1;
                            dr["Id"] = ds.Tables[0].Rows[0]["Id"].ToString();
                            dr["pro_name"] = ds.Tables[0].Rows[0]["pro_name"].ToString();
                            dr["pro_size"] = ds.Tables[0].Rows[0]["pro_size"].ToString();
                            dr["pro_price"] = ds.Tables[0].Rows[0]["pro_price"].ToString();
                            dr["pro_image"] = ds.Tables[0].Rows[0]["pro_image"].ToString();
                            sum += Int32.Parse(ds.Tables[0].Rows[0]["pro_price"].ToString()); 
                            dt.Rows.Add(dr);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            Session["buyitems"] = dt;
                        }
                        else
                        {
                            dt = (DataTable)Session["buyitems"];
                            int sr;
                            sr = dt.Rows.Count;
                            DataRow dr = dt.NewRow();
                            SqlConnection scon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                            scon.Open();
                            String myquery = "select * from [Table] where Id = '" + Request.QueryString["id"] + "'";
                            SqlCommand cmd = new SqlCommand(myquery, scon);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dr["sno"] = sr + 1;
                            dr["Id"] = ds.Tables[0].Rows[0]["Id"].ToString();
                            dr["pro_name"] = ds.Tables[0].Rows[0]["pro_name"].ToString();
                            System.Diagnostics.Debug.WriteLine(ds.Tables[0].Rows[0]["pro_name"].ToString());
                            dr["pro_size"] = ds.Tables[0].Rows[0]["pro_size"].ToString();
                            dr["pro_price"] = ds.Tables[0].Rows[0]["pro_price"].ToString();
                            dr["pro_image"] = ds.Tables[0].Rows[0]["pro_image"].ToString();
                            sum += Int32.Parse(ds.Tables[0].Rows[0]["pro_price"].ToString());
                            System.Diagnostics.Debug.WriteLine(sum);
                            dt.Rows.Add(dr);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            Session["buyitems"] = dt;
                        }
                    }
                    else
                    {
                        dt = (DataTable)Session["buyitems"];
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
                Label2.Text = sum.ToString();
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

        protected void ImageButton4_Click(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void ImageButton4_Command(object sender, CommandEventArgs e)
        {

            System.Diagnostics.Debug.WriteLine(e.CommandArgument.ToString());
            if (e.CommandName == "buynow")
            {
                Session["product_id"] = e.CommandArgument.ToString();

                Response.Redirect("buynow.aspx?id=" + e.CommandArgument.ToString());
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    