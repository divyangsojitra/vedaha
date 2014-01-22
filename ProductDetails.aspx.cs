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

public partial class ProductDetails : System.Web.UI.Page
{
   // string strfilename;
   // string strConnectionString = @"Data Source=LENOVO\SQL2005;Initial Catalog=shopping;Persist Security Info=True;User ID=sa;Password=123456";
    protected void Page_Load(object sender, EventArgs e)
                
    {
        //if (Session["CustomerId"] != "")
        ////////Random _rd=new Random();
        ////////if (Session["CustomerId"] == null || Session["CustomerId"] == "")
        ////////{
        ////////    Session["CustomerId"] = _rd.Next();
        ////////}
        ////////if (Session["CustomerId"] == null)
        ////////{
            
        ////////    Response.Redirect("LoginMaster.aspx");
        ////////}
        ////////if (Session["CustomerId"]== "")
        ////////{
            
        ////////    Response.Redirect("LoginMaster.aspx");
        ////////}
       
        //////if(this.IsPostBack == false)
        //////{
        //////    ////LblCustomerId.Text = Session["CustomerId"].ToString();

        //////}
        
            // BindDatalist();
        
        if (this.IsPostBack == false)
        {
            if (Request.QueryString["pid"] == null || Request.QueryString["pid"] == "")
            {
                Response.Redirect("Cart.aspx");
                return;
            }
            int intProductId = Convert.ToInt32(Request.QueryString["pid"]);


            CProductMaster objProduct = new CProductMaster(intProductId);
            
            if (objProduct.IsExit == true)
            {
                LblProductname.Text = objProduct.ProductName;
                LblProductDesc.Text = objProduct.ProductDesc;
               ///string strFileName = DateTime.Now.Ticks.ToString() + "_" + Image2;
                ////////string strFilePath = Server.MapPath("~/Image/" + strFileName);
                //FileUpload1.SaveAs(strFilePath);

                //Image1.ImageUrl = "~/Images/" + strFileName;
                LblProductId.Text = objProduct.ProductId.ToString();
               Image2.ImageUrl = "~/Image/" + (objProduct.Image.ToString());
               //Image2.ImageUrl = strFilePath;
            //string  strfilename = objProduct.Image.ToString();
               // Image2.ImageUrl = objProduct.Image.ToString();
               //ViewState["Imagename"] = objProduct.Image.ToString();
                LblPrice.Text = objProduct.Price.ToString();
                //lblStudentName.Text = objStudent.StudentName;
                //lblStudentAddress.Text = objStudent.StudentAddrelss;
                //Image2.ImageUrl = objProduct.Image.ToString();
                
                

            }

            BindProductSize(Convert.ToInt32(LblProductId.Text));
            //LblPrice.Text = (CStockMasterServices.SRatetbySize(Convert.ToInt32(LblProductId.Text), Convert.ToInt32(DropdownSize.SelectedValue))).ToString();
        }

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    
    {
        CPurchseMasterServices ObjCPurchseMasterServices = new CPurchseMasterServices();
        int intReturnValues=CPurchseMasterServices.StockQtyList(Convert.ToInt32(LblProductId.Text));
        LblStockQty.Text=intReturnValues.ToString();
        if (LblStockQty.Text == "0")
        {
            Lblmsg.Text = "No Stock";
        }
        else
        {
           double tot;
           LblQty.Text="1";
           tot = Convert.ToDouble(LblPrice.Text);  Convert.ToDouble(LblQty.Text);
           LblTotal.Text = Convert.ToString(tot);

           int intReturnValue = CCartMasterrServices.CartInsert(Convert.ToInt32(LblProductId.Text), Convert.ToInt32(DropdownSize.SelectedValue), Convert.ToDouble(LblPrice.Text), Convert.ToInt32(LblQty.Text), Convert.ToDouble(LblTotal.Text),Image2.ImageUrl);
            
            if (intReturnValue > 0)
           {
               Lblmsg.Text = "Item Add to Cart";

           }  
        }
        
    }
    private void BindProductSize(int ProductId)
    {
        DataSet dsStockMasterListbyProductId = CStockMasterServices.StockMasterListbyProductId(Convert.ToInt32(LblProductId.Text));
        DropdownSize.DataSource = dsStockMasterListbyProductId;
        DropdownSize.Items.Clear();
        DropdownSize.DataValueField = "SizeId";
        DropdownSize.DataTextField = "Desc";
        
        DropdownSize.DataBind();
        if (DropdownSize.Items.Count > 0)
        {
            LblPrice.Text = (CStockMasterServices.SRatetbySize(Convert.ToInt32(LblProductId.Text), Convert.ToInt32(DropdownSize.SelectedValue))).ToString();

        }

    }
    protected void DropdownSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}
