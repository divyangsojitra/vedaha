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
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindGvOrderMasterList();
        }
    }
    private void BindGvOrderMasterList()
    {
        DataSet dsCreditcardMasterList = CCreditcardServices.CCreditcardList();
        GvOrderList.DataSource = dsCreditcardMasterList;
        GvOrderList.DataBind();
    }
    //private void BindGvOrderMasterList()
    //{
    //    DataSet dsOrderMasterList = COrderMasterServices.OrderMasterList();
    //    GvOrderList.DataSource = dsOrderMasterList;
    //    GvOrderList.DataBind();
    //}


    protected void GvOrderList_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Billing")
        {
            int intOrderId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("Invoice.aspx?Oid=" + intOrderId.ToString());
        }
    }
}
