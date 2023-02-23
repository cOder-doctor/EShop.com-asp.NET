using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _web_project
{
    public partial class RDLC_Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] == null)
            {
                Response.Redirect("login.aspx");
            }

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