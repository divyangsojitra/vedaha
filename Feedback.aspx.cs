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

public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            //BindProductName();
        }
    }

    protected void ButSubmit_Click(object sender, EventArgs e)
    {
        int intReturnValue = CFeedbackMasterrServices.FeedBackInsert(TxtEmailId.Text, Txtfeedbackmsg.Text,CheckStatus.Checked=false);
        {
            if (intReturnValue > 0)
            {

                TxtEmailId.Text = "";

                Txtfeedbackmsg.Text = "";
            }
        }
    }
}
