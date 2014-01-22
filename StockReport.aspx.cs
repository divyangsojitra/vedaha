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

public partial class StockReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // BindgvProductlist();
        if (this.IsPostBack == false)
        {
            BindCategory();
        }
    }

    public void BindCategory()
    {
        DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        DropCategory.DataSource = dsCategoryMasterList;
        DropCategory.DataTextField = "CategoryName";
        DropCategory.DataValueField = "CategoryId";
        DropCategory.DataBind();
    }
    public void BindSubCategoryName(int CategoryId)
    {
        DataSet dsSubcategoryMasterListbyCategoryId = CSubCategoryMasterServices.SubCategoryMasterListbyCategoryId(Convert.ToInt32(DropCategory.SelectedValue));
        DropSubcategory.DataSource = dsSubcategoryMasterListbyCategoryId;
        DropSubcategory.Items.Clear();
        DropSubcategory.DataTextField = "SubCategoryName";
        DropSubcategory.DataValueField = "SubCategoryId";
        DropSubcategory.DataBind();
    }
    public void BindCosubcategoryName(int SubCategoryId)
    {
        DataSet dsCosubcategoryListbySubcategoryId = CCoSubCategoryMasterServices.CosubcategoryListbySubcategoryId(Convert.ToInt32(DropSubcategory.SelectedValue));
        DropCosubcategory.DataSource = dsCosubcategoryListbySubcategoryId;
        DropCosubcategory.DataTextField = "Cosubcategorydesc";
        DropCosubcategory.DataValueField = "CosubcategoryId";
        DropCosubcategory.DataBind();
    }

    public void BindgvProductlist(int CosubcategoryId)
    {
        DataSet ProductIdwithCategoryList = CProductMasterServices.ProductMasterList();


        DropProductname.DataSource = ProductIdwithCategoryList;


        DropProductname.DataTextField = "Productname";
        DropProductname.DataValueField = "ProductId";
        DropProductname.DataBind();

    }

    protected void DropCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        CSubCategoryMaster ObjsubCategory = new CSubCategoryMaster(Convert.ToInt32(DropCategory.SelectedValue));
        BindSubCategoryName(Convert.ToInt32(ObjsubCategory.CategoryId));

    }
    protected void DropSubcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        CCoSubCategoryMaster ObjCosubcategory = new CCoSubCategoryMaster(Convert.ToInt32(DropSubcategory.SelectedValue));
        BindCosubcategoryName(Convert.ToInt32(ObjCosubcategory.CosubcategoryId));
    }
    protected void DropCosubcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        CProductMaster ObjProductId = new CProductMaster(Convert.ToInt32(DropCosubcategory.SelectedValue));

        BindgvProductlist(Convert.ToInt32(ObjProductId.ProductId));
    }
    protected void ButSearch_Click(object sender, EventArgs e)
    {
       
        DataSet dsStockRep = CStockMasterServices.DisplayStockRep(Convert.ToInt32(DropProductname.SelectedValue), Convert.ToInt32(DropCategory.SelectedValue),
        Convert.ToInt32(DropSubcategory.SelectedValue), Convert.ToInt32(DropCosubcategory.SelectedValue));
        GVStockList.DataSource = dsStockRep;
        GVStockList.DataBind();
    }
    
    protected void Print_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockRep.aspx");
    }

    protected void DropProductname_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    
}
