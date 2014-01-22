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

public partial class SizeMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            Bindgv(); 
        }
       
    }
    protected void Bindgv()
    {
        DataSet dsSizeMasterList = CSizeMasterServices.BindSizeMasterList();
        GvSizeMasterList.DataSource = dsSizeMasterList;
        GvSizeMasterList.DataBind();
    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValue = CSizeMasterServices.SizeMasterInsert( (TxtType.Text).ToString());
        if (intReturnValue > 0)
        {
            lblmsg.Text = "Size Insert";
            Bindgv();
            TxtSizeId.Text = "";
            TxtType.Text= "";
        }
        else
        {
            lblmsg.Text = "Error occured while inserting Size.";
        }
    }
    protected void ButUpDate_Click(object sender, EventArgs e)
    {
        ButInsert.Visible = false;
        ButUpDate.Visible = true;
        int intReturnValue = CSizeMasterServices.SizeMasterUpdate(Convert.ToInt32(TxtSizeId.Text), (TxtType.Text).ToString());
       if (intReturnValue >0)
        
            {
                lblmsg.Text="Size UpDate";
                TxtSizeId.Text="";
                TxtType.Text="";
                Bindgv();
            }
            else
           {
                lblmsg.Text="Error occured while Updateing Size";
           }
        
    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        TxtSizeId.Text = "";
        TxtType.Text = "";
    }
    protected void GvSizeMasterList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GvSizeMasterList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        ButInsert.Visible = false;
        ButUpDate.Visible = true;
        ButCancle.Visible = true;
        int intSizeId = Convert.ToInt32(GvSizeMasterList.DataKeys[e.NewEditIndex].Value);
        
        CSizeMaster ObjSize=new CSizeMaster(intSizeId);
        if (ObjSize.IsExit == true)
        {
            TxtSizeId.Text = ObjSize.SizeId.ToString();
            TxtType.Text = ObjSize.Desc.ToString();
        }
    }
    protected void GvSizeMasterList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int intSizeId = Convert.ToInt32(GvSizeMasterList.DataKeys[e.RowIndex].Value);
        CSizeMaster ObjSize = new CSizeMaster(intSizeId);

        if(ObjSize.IsExit==true)
        {
            TxtSizeId.Text=ObjSize.SizeId.ToString();
            TxtType.Text=ObjSize.Desc.ToString();
        }
        int intReturnValue = CSizeMasterServices.SizeMasterDelete(Convert.ToInt32(TxtSizeId.Text));
        if (intReturnValue > 0)
        {
            
            lblmsg.Text = "Delete Data";
            Bindgv();
            TxtSizeId.Text = "";
            TxtType.Text = "";
        }
        else
        {
            lblmsg.Text = "Error occured while Deleting Data.";
        }
    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {
        
    }
}
