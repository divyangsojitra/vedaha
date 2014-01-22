using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Userhomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null || Session["CustomerId"] == "")
        {
            Response.Redirect("LoginMaster.aspx");
        }
        
        if (this.IsPostBack == false)
        {
            Lblmgs.Text = " hi," + Session["Firstname"].ToString();
            Lblcustid.Text = "CustomerId" + Session["CustomerId"].ToString();
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingbag.aspx");
        

    }
    protected void LbEditProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditUserProfile.aspx");
    }
}
