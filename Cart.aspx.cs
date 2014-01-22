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

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        { //LblCustomerId.Text = "LblCustomerId" + Session["CustomerId"].ToString();
            //LblCosubcategoryId.Text = Request.QueryString["Coscat"];
            //LblCategoryId.Text = Session["CategoryId"].ToString();
            //LblSubCategoryId.Text = Session["SubCategoryId"].ToString();
            //if (Master.FindControl("h2NarrowChoice") != null)
            //    Master.FindControl("h2NarrowChoice").Visible = false;
            //if (Master.FindControl("Image1") != null)
            //    Master.FindControl("Image1").Visible = false;
            //if (Master.FindConstrol("h2AllVariety") != null)
            //    Master.FindControl("h2AllVariety").Visible = fals
            LblCosubcategoryId.Text = Request.QueryString["Sid"];
            //LblCosubcategoryId.Text = "1";
            //LblCategoryId.Text = "2";
            LblCategoryId.Text = Session["CategoryId"].ToString();
            //LblSubCategoryId.Text = "9";
            LblSubCategoryId.Text = Session["SubCategoryId"].ToString();
            BindDatalist();
            //      LblcatId.Text = Request.QueryString["cat"];
        }
    }
    public void BindDatalist()
    {
        //DataSet dsProductMasterCartList = CProductMasterServices.ProductMasteCartList(Convert.ToInt32(LblCategoryId.Text),Convert.ToInt32(LblSubCategoryId.Text),int.Parse(Request.QueryString["Coscat"].ToString()));
        DataSet dsProductMasterCartList = CProductMasterServices.ProductMasteCartList(Convert.ToInt32(LblCategoryId.Text),Convert.ToInt32(LblSubCategoryId.Text),Convert.ToInt32(LblCosubcategoryId.Text));
        // DataSet dsProductMasterCartList = CCartMasterrServices.CartList(17, 30, 11);
        ImageDataList.DataSource = dsProductMasterCartList;
        ImageDataList.DataBind();
    }
    protected void DataList1_ItemCommand1(object source, DataListCommandEventArgs e)
    {
        {
            int intProductId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ProductDetails.aspx?pid=" + intProductId.ToString());
        }

    }

    protected void ImageDataList_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Response.Redirect("ProductDetails.aspx");
    }
    protected void LnkbutBhoppingbag_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingbag.aspx");
    }
    protected void ImageDataList_ItemCreated(object sender, DataListItemEventArgs e)
    {

    }
    protected void ImageDataList_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void ImageDataList_SelectedIndexChanged2(object sender, EventArgs e)
    {

    }
    protected void ButAddtoCart_Click(object sender, EventArgs e)
    {

    }
}
