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
using System.Web.Mail;

public partial class mail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            MailMessage Msg = new MailMessage();
            // Sender e-mail address.
            Msg.From = txtFrom.Text;
            // Recipient e-mail address.
            Msg.To = txtTo.Text;
            Msg.Subject = txtSubject.Text;
            Msg.Body = txtBody.Text;
            // your remote SMTP server IP.
            //SmtpMail.SmtpServer = "10.20.72.1";
            SmtpMail.Send(Msg);
            //Msg = null;
            Page.RegisterStartupScript("UserMsg", "<script>alert('Mail sent thank you...');if(alert){ window.location='SendMail.aspx';}</script>");
        }
        catch (Exception ex)
        {
            Console.WriteLine("{0} Exception caught.", ex);
        }
    }
}
