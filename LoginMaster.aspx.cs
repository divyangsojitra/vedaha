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

public partial class LoginMaster : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void ButSingin_Click(object sender, EventArgs e)
    {
        //string strConnectionString = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=shopping;Persist Security Info=True;User ID=sa;Password=123456";
        CCustomerMaster ObjCustomer = new CCustomerMaster(TxtEmailId.Text);
        //CCustomerMaster ObjCustomer = new CCustomerMaster(.Text);
        if (ObjCustomer.IsExit == true)
        {
            if (TxtPassword.Text == ObjCustomer.Password)
            {
                Session["CustomerId"] = ObjCustomer.CustomerId;
                Session["EmailId"]=ObjCustomer.EmailId;
                Session["Firstname"] = ObjCustomer.Firstname;
                Session["Type"] = ObjCustomer.Type;
                try
                {
                    if (Session["OrderId"].ToString() == "imfromshp")
                    {
                        Response.Redirect("shoppingbag.aspx");
                    }
                }
                catch (Exception ex) { }
                if (Session["Type"].ToString() == "Admin")
                {
                    Response.Redirect("ProductMaster.aspx");
                }
                Response.Redirect("Userhomepage.aspx");
                Response.Redirect("Cart.aspx");
            }
           
       }
        else
        {
            lblmsg.Text = "Invalid  or password";
        }
       

    }
    protected void ButCreateAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerReg.aspx");

    }
    //protected void ButSignout_Click(object sender, EventArgs e)
    //{
        

    //}
}
