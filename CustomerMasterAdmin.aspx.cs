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

public partial class CustomerMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindgvCustomerList();
        }
    }
    public void BindgvCustomerList()
    {
        DataSet dsCustomerMasterList = CCustomerMasterServices.CustomerMasterList();
        GvCustomer.DataSource = dsCustomerMasterList;
        GvCustomer.DataBind();

    }
}
