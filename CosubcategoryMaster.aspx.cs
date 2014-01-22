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

public partial class CosubcategoryMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
           
            BindCategoryname();
            BindGv();
        }
      
      // BindSubcategoryname(CategoryId);
      //  BindSubcategoryname(Convert.ToInt32(DropCategoryname.SelectedValue));
        
    }
    public void BindGv()
    {
        DataSet dsCosubcategoryMasterList = CCoSubCategoryMasterServices.CosubcategoryList();
        gvCosubcategoryList.DataSource = dsCosubcategoryMasterList;
        gvCosubcategoryList.DataBind();

    }
    public void BindCategoryname()
    {
        DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        DropCategoryname.DataSource = dsCategoryMasterList;
        DropCategoryname.Items.Clear();
        DropCategoryname.DataTextField = "Categoryname";
        DropCategoryname.DataValueField = "CategoryId";
        DropCategoryname.DataBind();

        CSubCategoryMaster ObjsubCategory = new CSubCategoryMaster((Convert.ToInt32(DropCategoryname.SelectedValue)));
        BindSubcategoryname(Convert.ToInt32(ObjsubCategory.CategoryId));

    }
    public void BindSubcategoryname(int CategoryId)
        {
            DataSet dsSubcategoryMasterListbyCategoryId = CSubCategoryMasterServices.SubCategoryMasterListbyCategoryId(Convert.ToInt32(DropCategoryname.SelectedValue));
            DropSubCategory.DataSource = dsSubcategoryMasterListbyCategoryId;
            DropSubCategory.Items.Clear();
            DropSubCategory.DataTextField = "SubCategoryName";
            DropSubCategory.DataValueField = "SubCategoryId";
            DropSubCategory.DataBind();
        }

   

   
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValues = CCoSubCategoryMasterServices.CosubcategoryInsert(
            Convert.ToInt32(DropCategoryname.SelectedValue),
            Convert.ToInt32(DropSubCategory.SelectedValue),TxtDescription.Text,DropStatus.SelectedValue);
        if (intReturnValues > 0)
        {
            Lblmsg.Text = "CosubcategoryInsert";
            BindGv();
            TxtDescription.Text = "";
        }
        else
        {
            Lblmsg.Text ="Error occured while insering CosubCategory.";
        }
    }

    protected void ButCancle_Click(object sender, EventArgs e)
    {
        Lblmsg.Text = "";
        TxtDescription.Text = "";
    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        int intReturnValues = CCoSubCategoryMasterServices.CosubcategoryUpdate(Convert.ToInt32(TxtCosubcategory.Text),
            Convert.ToInt32(DropCategoryname.SelectedValue), Convert.ToInt32(DropSubCategory.SelectedValue), TxtDescription.Text,DropStatus.SelectedValue);
        if (intReturnValues > 0)
        {
            Lblmsg.Text = "Cosubcategory Update";
            TxtDescription.Text = "";
            BindGv();
        }
        else
        {
            Lblmsg.Text = "Error occured while Updateing CosubCategory.";
        }
    }
    protected void gvCosubcategoryList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        ButCancle.Visible = true;
        ButInsert.Visible = false;
        ButUpdate.Visible = true;
       DropSubCategory.Items.Clear();
        DropCategoryname.ClearSelection();

        int intCosubcategoryId=Convert.ToInt32(gvCosubcategoryList.DataKeys[e.NewEditIndex].Value);
        
        CCoSubCategoryMaster ObjCosubcategory = new CCoSubCategoryMaster(intCosubcategoryId);
        
        //CSubCategoryMaster ObjsubCategory = new CSubCategoryMaster((Convert.ToInt32(DropCategoryname.SelectedValue)));
        DropCategoryname.SelectedValue = ObjCosubcategory.CategoryId.ToString();
        BindSubcategoryname((Convert.ToInt32(DropCategoryname.SelectedValue)));

        if (ObjCosubcategory.IsExit == true)
        {
            TxtCosubcategory.Text = ObjCosubcategory.CosubcategoryId.ToString();
            DropCategoryname.SelectedValue = ObjCosubcategory.CategoryId.ToString();
            DropSubCategory.SelectedValue = ObjCosubcategory.SubcategoryId.ToString();
            TxtDescription.Text = ObjCosubcategory.Cosubcategorydesc.ToString();
            DropStatus.SelectedValue = ObjCosubcategory.Status.ToString();
        }
    }
    protected void gvCosubcategoryList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DropCategoryname.ClearSelection();
        DropSubCategory.ClearSelection();
        int intCosubcategoryId = Convert.ToInt32(gvCosubcategoryList.DataKeys[e.RowIndex].Value);

        CCoSubCategoryMaster ObjCosubcategory = new CCoSubCategoryMaster(intCosubcategoryId);
       
        DropCategoryname.SelectedValue = ObjCosubcategory.CategoryId.ToString();
       
        if (ObjCosubcategory.IsExit == true)
        {
            TxtCosubcategory.Text=ObjCosubcategory.CosubcategoryId.ToString();
            DropCategoryname.SelectedValue = ObjCosubcategory.CategoryId.ToString();
            DropSubCategory.SelectedValue = ObjCosubcategory.SubcategoryId.ToString();
            TxtDescription.Text = ObjCosubcategory.Cosubcategorydesc.ToString();
            DropStatus.SelectedValue = ObjCosubcategory.Status.ToString();
        }
        int intReturnValue = CCoSubCategoryMasterServices.CosubcategoryDelete(Convert.ToInt32(TxtCosubcategory.Text));
        if (intReturnValue > 0)
        {
            Lblmsg.Text="Cosubcategory Delete";
            BindGv();
            TxtCosubcategory.Text="";
            TxtDescription.Text="";
        }
    }
    protected void DropCategoryname_SelectedIndexChanged(object sender, EventArgs e)
    {
        CSubCategoryMaster ObjsubCategory = new CSubCategoryMaster((Convert.ToInt32(DropCategoryname.SelectedValue)));
       BindSubcategoryname(Convert.ToInt32(ObjsubCategory.CategoryId));

        //BindSubcategoryname(ObjsubCategory.CategoryId.ToString());
       // DropSubCategory.SelectedValue = "SubCategoryId";
        
        // BindSubcategoryname(Convert.ToInt32(CategoryId));
    }
}
