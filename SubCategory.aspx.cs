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

public partial class SubCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindGrid();
            BindCategoryName();
        }

    }
    public void BindGrid()
    {
        DataSet dsSubCategoryMasterList = CSubCategoryMasterServices.SubCategoryMasterList();
        GvSubCategoryList.DataSource = dsSubCategoryMasterList;
        GvSubCategoryList.DataBind();
    }
    public void BindCategoryName()
    {
        DataSet dsCategoryMasterList = CSubCategoryMasterServices.BindCategoryNameList();
        Dropcategoryname.DataSource = dsCategoryMasterList;
        Dropcategoryname.DataTextField="CategoryName";
        Dropcategoryname.DataValueField = "CategoryId";
        Dropcategoryname.DataBind();
        
    }

    protected void ButInsert_Click(object sender, EventArgs e)
    {
        //ButAdd.Visible = true;
        //ButUpdate.Visible =false ;
        //ButCancle.Visible = true;

        int intReturnValue = CSubCategoryMasterServices.SubCategoryInsert(Convert.ToInt32(Dropcategoryname.SelectedValue), Txtsubcategoryname.Text, DropStatus.SelectedValue);
        if (intReturnValue > 0)
        {
            lblmsgbox.Text= "SubCategory Insert";
            BindGrid();
            //Dropcategoryname.SelectedValue="";
            Txtsubcategoryname.Text = "";
           // TxtSubCategoryDescription.Text = "";
            TblAddEdit.Visible = false;

        }
        else
        {
            lblmsgbox.Text="Error occured while insering SubCategory.";

        }
    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        ButInsert.Visible = false;
        ButCancle.Visible = true;
        
        int intReturnValue = CSubCategoryMasterServices.SubCategoryUpDate(Convert.ToInt32(Txtsubcategoryid.Text),
            Convert.ToInt32(Dropcategoryname.SelectedValue), Txtsubcategoryname.Text,
            DropStatus.SelectedValue);
        if (intReturnValue > 0)
        {
            lblmsgbox.Text = "SubCategory UpDate.";
            BindGrid();
            Txtsubcategoryid.Text="";
            Txtsubcategoryname.Text="";
            
            DropStatus.SelectedValue="";
            TblAddEdit.Visible = false;
        }
        else
        {
            lblmsgbox.Text="Error occured while UpDate Category.";

        }
    }
    protected void GvSubCategoryList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        TblAddEdit.Visible = true;
        ButAdd.Visible = true;
        ButUpdate.Visible = true;
        ButCancle.Visible = true;
        ButInsert.Visible = false;

        int intSubCategoryId = Convert.ToInt32(GvSubCategoryList.DataKeys[e.NewEditIndex].Value);

        CSubCategoryMaster ObjSubCategory= new CSubCategoryMaster(intSubCategoryId);

        if(ObjSubCategory.IsExit==true)
        {
           
            Txtsubcategoryid.Text =ObjSubCategory.SubCategoryId.ToString();
            Dropcategoryname.SelectedValue=ObjSubCategory.CategoryId.ToString();
            Txtsubcategoryname.Text=ObjSubCategory.SubCategoryName;
            //TxtSubCategoryDescription.Text=ObjSubCategory.SubcategoryDesc;
           DropStatus.SelectedValue=ObjSubCategory.Status;
        }
    }
    protected void GvSubCategoryList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GvSubCategoryList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //TblAddEdit.Visible = false;
        //ButAdd.Visible = true;
        int intSubCategoryId = Convert.ToInt32(GvSubCategoryList.DataKeys[e.RowIndex].Value);

        CSubCategoryMaster ObjSubCategory = new CSubCategoryMaster(intSubCategoryId);
        if (ObjSubCategory.IsExit == true)
        {
            Txtsubcategoryid.Text = ObjSubCategory.SubCategoryId.ToString();
            Dropcategoryname.SelectedValue = ObjSubCategory.CategoryId.ToString();
            Txtsubcategoryname.Text = ObjSubCategory.SubCategoryName;
          
            DropStatus.SelectedValue = ObjSubCategory.Status;

        }
        int intResultValue = CSubCategoryMasterServices.SubCategoryDelete(intSubCategoryId);

        if (intResultValue > 0)
        {
            BindGrid();
            lblmsgbox.Text = "SubCategory Delete.";
            Txtsubcategoryid.Text = "";
            Txtsubcategoryname.Text = "";
         
            
        }
        else
        {

            lblmsgbox.Text = "Error occured while Deleting Data.";
        }
    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {

        TblAddEdit.Visible = true;
        Txtsubcategoryid.Text = "";
        Txtsubcategoryname.Text = "";
        //TxtSubCategoryDescription.Text  ="";

    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = true;
        ButCancle.Visible = true;
        ButUpdate.Visible = false;
        Txtsubcategoryid.Text = "";
        Txtsubcategoryname.Text = "";
        
    }
    protected void GvSubCategoryList_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GvSubCategoryList_SelectedIndexChanged2(object sender, EventArgs e)
    {

    }
}