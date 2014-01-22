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

public partial class FabircMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindGVFabricList();
        }
    }

    protected void BindGVFabricList()
    {
        DataSet dsFabricMasterList = CFabricMasterServices.FabricMasterList();
        GvFabricList.DataSource = dsFabricMasterList;
        GvFabricList.DataBind();
    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnvalue = CFabricMasterServices.FabricMasterInsert((TxtFabricname.Text).ToString(),(DropStatus.SelectedValue).ToString());
        Lblmsg.Text = "Fabric Insert";
        BindGVFabricList();
        TxtFabicId.Text = "";
        TxtFabricname.Text = "";
    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        int intReturnvalue = CFabricMasterServices.FabricMasterUpdate(Convert.ToInt32(TxtFabicId.Text), (TxtFabricname.Text).ToString(),(DropStatus.SelectedValue).ToString());
        if (intReturnvalue > 0)
        {
            Lblmsg.Text = "UPDate Data";
            BindGVFabricList();
            TxtFabicId.Text = "";
            TxtFabricname.Text = "";
        }
        else
        {
            Lblmsg.Text = "Error occured while Update Data";
        }
    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TxtFabicId.Text = "";
        TxtFabricname.Text = "";
        Lblmsg.Text = "";

    }
    protected void GvFabricList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //int intCategoryId = Convert.ToInt32(gvCategorylist.DataKeys[e.NewEditIndex].Value);
        int intFabricId=Convert.ToInt32(GvFabricList.DataKeys[e.NewEditIndex].Value);
        CFabricMaster ObjFabric = new CFabricMaster(intFabricId);
        if(ObjFabric.IsExit==true)
        {
            TxtFabicId.Text=ObjFabric.FabricId.ToString();
            TxtFabricname.Text=ObjFabric.Fabricname.ToString();
            DropStatus.SelectedValue = ObjFabric.Status.ToString();
        }
    }
    protected void GvFabricList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int intFabricId = Convert.ToInt32(GvFabricList.DataKeys[e.RowIndex].Value);
        CFabricMaster ObjFabric = new CFabricMaster(intFabricId);
        if (ObjFabric.IsExit == true)
        {
            TxtFabicId.Text = ObjFabric.FabricId.ToString();
            TxtFabricname.Text = ObjFabric.Fabricname.ToString();
            DropStatus.SelectedValue = ObjFabric.Status.ToString();
        }

        int intReturnValue = CFabricMasterServices.FabricMasterDelete(Convert.ToInt32(TxtFabicId.Text));
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "Delete Fabric";
            BindGVFabricList();
            TxtFabicId.Text = "";
            TxtFabricname.Text = "";
        }
        else
        {
            Lblmsg.Text = "Error occured while Delete Data";
        }
    }
}
