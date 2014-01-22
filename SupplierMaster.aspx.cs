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

public partial class SupplierMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindSupplierList();
        }

    }
    public void BindSupplierList()
    {
        DataSet dsSuplierMasterList = CSupplierMasterServices.SupplierMasterList();
        GvSupplierList.DataSource = dsSuplierMasterList;
        GvSupplierList.DataBind();

    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButUpdate.Visible = false;
        ButCancle.Visible = true;
        int intReturnValue = CSupplierMasterServices.SupplierInsert(TxtSuppliername.Text, TxtAddress.Text,
            Txtarea.Text,Txtcity.Text,Convert.ToInt32(TxtPincode.Text),TxtContect.Text, TxtEmailId.Text);
        if (intReturnValue > 0)
        {
            BindSupplierList();
            TxtSuppliername.Text = "";
            TxtAddress.Text = "";
            Txtarea.Text = "";
            Txtcity.Text = "";
            TxtPincode.Text = "";
            TxtContect.Text = "";
            TxtEmailId.Text = "";
            Lblmsg.Text = "Supplier Insert";
        }
        else    
        {
            Lblmsg.Text="Error occured while Insert Supplier.";

        }
        
    }

    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButCancle.Visible = true;
        ButInsert.Visible = false;
        int intReturnValue = CSupplierMasterServices.SupplierUpdate(
            Convert.ToInt32(TxtSupplierId.Text),
            TxtSuppliername.Text, 
            TxtAddress.Text,
            Txtarea.Text,
            Txtcity.Text,
            Convert.ToInt32(TxtPincode.Text), 
            TxtContect.Text, 
            TxtEmailId.Text);
        if (intReturnValue > 0)
        {
            BindSupplierList();
            TxtSuppliername.Text = "";
            TxtAddress.Text = "";
            Txtarea.Text = "";
            Txtcity.Text = "";
            TxtPincode.Text = "";
            TxtContect.Text = "";
            TxtEmailId.Text = "";
            Lblmsg.Text = "Supplier Update";

        }
        else
        {
            Lblmsg.Text = "Error occured while Update Supplier.";

        }

    }
    protected void GvSupplierList_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
       
    }
    protected void GvSupplierList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = false;
        ButUpdate.Visible = true;
        ButCancle.Visible = true;
        int intSupplierId = Convert.ToInt32(GvSupplierList.DataKeys[e.NewEditIndex].Value);
        CSupplierMaster ObjSupplier = new CSupplierMaster(intSupplierId);

        if (ObjSupplier.IsExit == true)
        {
            TxtSupplierId.Text = ObjSupplier.SupplierId.ToString();
            TxtSuppliername.Text = ObjSupplier.Suppliername.ToString();
            TxtAddress.Text = ObjSupplier.Address.ToString();
            Txtarea.Text = ObjSupplier.Area.ToString();
            Txtcity.Text = ObjSupplier.City.ToString();
            TxtPincode.Text = ObjSupplier.Pincode.ToString();
            TxtContect.Text = ObjSupplier.Contactno.ToString();
            TxtEmailId.Text = ObjSupplier.EmailId.ToString();

        }

    }
    

    protected void GvSupplierList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        TblAddEdit.Visible = false;
        ButCancle.Visible = true;
        ButUpdate.Visible = true;
        ButInsert.Visible = false;
        int intSupplierId = Convert.ToInt32(GvSupplierList.DataKeys[e.RowIndex].Value);
        CSupplierMaster  ObjSupplier = new CSupplierMaster(intSupplierId);

        if (ObjSupplier.IsExit == true)
        {
            TxtSupplierId.Text = ObjSupplier.SupplierId.ToString();
            TxtSuppliername.Text = ObjSupplier.Suppliername.ToString();
            TxtAddress.Text = ObjSupplier.Address.ToString();
            Txtarea.Text = ObjSupplier.Area.ToString();
            Txtcity.Text = ObjSupplier.City.ToString();
            TxtContect.Text = ObjSupplier.Contactno.ToString();
            TxtPincode.Text = ObjSupplier.Pincode.ToString();
            TxtEmailId.Text = ObjSupplier.EmailId.ToString();
        }
        int intReturnValue = CSupplierMasterServices.SupplierDelete(Convert.ToInt32(TxtSupplierId.Text));
        if (intReturnValue > 0)
        {
            BindSupplierList();
            TxtSupplierId.Text = "";
            TxtSuppliername.Text = "";
            TxtAddress.Text = "";
            Txtarea.Text = "";
            Txtcity.Text = "";
            TxtContect.Text = "";
            TxtPincode.Text = "";
            TxtEmailId.Text = "";
            Lblmsg.Text = "Supplier Delete.";
        }
        else
        {
            Lblmsg.Text = "Error occured while Delete Supplier.";

        }
    }

    protected void ButEdit_Click(object sender, EventArgs e)
    {
        
        
    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TxtSupplierId.Text = "";
        TxtSuppliername.Text = "";
        TxtAddress.Text = "";
        Txtarea.Text = "";
        Txtcity.Text = "";
        TxtContect.Text = "";
        TxtPincode.Text = "";
        TxtEmailId.Text = "";
        Lblmsg.Text = "";
    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = true;
        ButCancle.Visible = true;
        ButUpdate.Visible = false;
    }
}
