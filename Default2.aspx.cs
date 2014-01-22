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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindgvProductlist();
    }
    public void BindgvProductlist()
    {
        DataSet dsProductMasterList = CProductMasterServices.ProductMasterList();
        GVReport.DataSource = dsProductMasterList;
        GVReport.DataBind();
    }
    private void BindCategory()
    {
        DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        GVReport.DataSource = dsCategoryMasterList;
        GVReport.DataBind();
    }
    
    protected void ButSearch_Click(object sender, EventArgs e)
    {
        if (Dropparameter.SelectedIndex == 1)
        {
            BindgvProductlist();
        }
        else
        {
            BindCategory();

        }

    }
}
