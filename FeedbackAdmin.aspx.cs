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

public partial class FeedbackAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindfeedbackList();
        }
    }
    public void BindfeedbackList()
    {
        DataSet dsFeedBackMasterList = CFeedbackMasterrServices.FeebBackList();
        gvfeedbackList.DataSource = dsFeedBackMasterList;
        gvfeedbackList.DataBind();
        
    }
    protected void gvfeedbackList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        
        
    }
    protected void ButActive_Click(object sender, EventArgs e)
    {
        //int intFeedbackId = Convert.ToInt32(gvfeedbackList.DataKeys[e.NewEditIndex].Value);
       int intReturnValue = CFeedbackMasterrServices.FeedBackUpdate(13, true);
        BindfeedbackList();

    }
}
