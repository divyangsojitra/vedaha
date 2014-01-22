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

public partial class Order_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindCity();


    }
    public void BindCity()
    {
        DataSet dsCityMasterList = CCityMasterServices.CityMasterList();
        DropCity.DataSource = dsCityMasterList;
        DropCity.DataTextField = "Cityname";
        DropCity.DataValueField = "CityId";
        DropCity.DataBind();
    }
    protected void ButSearch_Click(object sender, EventArgs e)
    {
        //int intReturnValue = CInvoiceServices.PendingInvoice();
        //int intReturnValue = CInvoiceServices.invoice_done_an_delivery_done();
        //int intReturnValue = CInvoiceServices.invoice_done_delivey_pending();
    }
    private void Bindgvinvoice_done_delivey_pending()
    {
        DataSet Dsinvoice_done_delivey_pending = CInvoiceServices.invoice_done_delivey_pending();
        GvOrderReport.DataSource = Dsinvoice_done_delivey_pending;
        GvOrderReport.DataBind();
    }
    private void Bindgvinvoice_done_an_delivery_done()
    {
        DataSet Dsinvoice_done_an_delivery_done = CInvoiceServices.invoice_done_an_delivery_done();
        GvOrderReport.DataSource = Dsinvoice_done_an_delivery_done;
        GvOrderReport.DataBind();
    }
    private void BindgvPending()
    {
        DataSet DsPendingInvoice = CInvoiceServices.PendingInvoice();
        GvOrderReport.DataSource = DsPendingInvoice;
        GvOrderReport.DataBind();
    }
    private void BindgvInvoicesummary()
    {
        DataSet DsInvoice_summary = CInvoiceServices.invoice_summary();
       GvOrderReport.DataSource=DsInvoice_summary;
       GvOrderReport.DataBind();
    }

    protected void DropOrderstatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropOrderstatus.SelectedIndex == 1)
        {
            BindgvPending();
        }
        else if(DropOrderstatus.SelectedIndex==2)
        {
            Bindgvinvoice_done_delivey_pending();
        }
        else if (DropOrderstatus.SelectedIndex == 3)
        {
            Bindgvinvoice_done_an_delivery_done();
        }
        else if (DropOrderstatus.SelectedIndex == 4)
        {
            BindgvInvoicesummary();
        }
    }
}
