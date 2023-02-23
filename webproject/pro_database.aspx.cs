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
    public partial class pro_database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;

            DataSet ds;
           
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

           
            con.Open();
            da = new SqlDataAdapter("select * from [Table]", con);

            ds = new DataSet();

            da.Fill(ds);

            //GridView1.DataSource = ds;

            GridView1.DataBind();
            con.Close();
          /*   string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetImageById", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter()
                {
                    ParameterName = "@Id",
                    //Value = Request.QueryString["Id"]
                    Value = Convert.ToInt32(Session["var"].ToString())
                };
                cmd.Parameters.Add(paramId);
                con.Open();
                byte[] bytes = (byte[])cmd.ExecuteScalar();
                if (bytes == null)
                {
                    Response.Redirect("WebForm3.aspx");
                }
                else
                {
                    string strBase64 = Convert.ToBase64String(bytes);
                    Image1.ImageUrl = "data:Image/png;base64," + strBase64;
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                            conn.Open();
                            String insertquery = "insert into [Table] (Image) values (@image)";
                            SqlCommand com = new SqlCommand(insertquery, conn);
                            com.Parameters.AddWithValue("@Id", newGuid.ToString());
                            com.Parameters.AddWithValue("@name", TextBox1.Text);
                            com.Parameters.AddWithValue("@size", TextBox2.Text);
                            com.Parameters.AddWithValue("@price", TextBox3.Text);
                            com.Parameters.AddWithValue("@description", TextBox4.Text);
                            com.Parameters.AddWithValue("@availability", TextBox5.Text);
                            com.ExecuteNonQuery();
                            conn.Close();
                }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("pro_insert.aspx");
        }
    }
}