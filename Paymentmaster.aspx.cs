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

public partial class Paymentmaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    protected void OpPaymentoption_SelectedIndexChanged(object sender, EventArgs e)
    
    {
        if (OpPaymentoption.SelectedValue == "Creditcard")
        {
            Response.Redirect("CreditcardMaster.aspx");
        }
        else if (OpPaymentoption.SelectedValue == "DebitCard")
        {
            Response.Redirect("DebitCard.aspx");
        }
    }

    protected void OpPaymentoption_TextChanged(object sender, EventArgs e)
    {

    }
}
