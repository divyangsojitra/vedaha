using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MasterPage2 : System.Web.UI.MasterPage
{

   // public event EventHandler PriceSearchSelectIndex;
    //private string m_CategoryId = "";
    public RadioButtonList PriceRadio
    {
        get
        {
            return this.RadioPrice;
        }
        //set
        //{

        //    RadioPrice.SelectedIndex = value;
        //}
        
    }
    public Label Lcount
    {
        get
        {
            return this.Lblcount;
        }
    }
    
    public Panel PanelPrice
    {
        get
        {
            return this.PricePanel;
        }
        
    }
    public  CheckBoxList  ChecksizeList
    {
        get
        {
            return this.CheckListsize;
        }
    }
    public Panel PanelCheck
    {
        get
        {
            return this.Checkpanel;
        }
    }
    public Button but2
    {
        get
        {
            return this.But1;
        }
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
         // BindPrice();
        }
        //SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        //ObjConnection.Open();

        //SqlCommand ObjCommand = new SqlCommand();
        //ObjCommand.Connection = ObjConnection;
        //ObjCommand.CommandText = "CategoryImage";
        //ObjCommand.CommandType = CommandType.StoredProcedure;

        //DataTable dt = new DataTable();
        //SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        //ObjDataAdapter.Fill(dt);

        //Image11.ImageUrl = "~/Image/" + dt.Rows[0]["Image"];
        //Image11.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[0]["Image"];
        //Image12.ImageUrl = "~/Image/" + dt.Rows[1]["Image"];
        //Image12.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[1]["Image"];
        //Image13.ImageUrl = "~/Image/" + dt.Rows[2]["Image"];
        //Image13.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[2]["Image"];
        //Image14.ImageUrl = "~/Image/" + dt.Rows[3]["Image"];
        //Image14.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[3]["Image"];
        //Image15.ImageUrl = "~/Image/" + dt.Rows[4]["Image"];
        //Image15.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[4]["Image"];
        //Image16.ImageUrl = "~/Image/" + dt.Rows[5]["Image"];
        //Image16.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[5]["Image"];
        //Image17.ImageUrl = "~/Image/" + dt.Rows[6]["Image"];
        //Image17.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[6]["Image"];
        //Image18.ImageUrl = "~/Image/" + dt.Rows[7]["Image"];
        //Image18.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[7]["Image"];
        //Image19.ImageUrl = "~/Image/" + dt.Rows[8]["Image"];
        //Image19.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[8]["Image"];
        //Image20.ImageUrl = "~/Image/" + dt.Rows[9]["Image"];
        //Image20.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[9]["Image"];

    }
    //public RadioButtonList RadioPrice
    //protected override void OnInit(EventArgs e)
    //{
    //    RadioPrice.SelectedIndex += RadioPrice_SelectedIndexChanged;
    //    base.OnInit(e);
    //}
    //public event EndEventHandler PriceSearchSelectIndex;
    

    //protected void RadioPrice_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    //if (PriceSearchSelectIndex != null)
    //    //    PriceSearchSelectIndex(this, EventArgs.Empty);
    //    //m_CategoryId = RadioPrice.SelectedValue.ToString();
        
    //}
    //public DataSet BindPrice()
    //{
    //    ImageDataList  dsProductsearchPrice = CProductMasterServices.BindProductsearchPrice();
    //    ImageDataList.DataSource = dsProductsearchPrice;
    //    ImageDataList.DataBind();
    //}

    public void BindCategory()
    {
        //DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        //gvCategory.DataSource = dsCategoryMasterList;
        //gvCategory.DataBind();
    }

    protected void RadioPrice_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (RadioPrice.SelectedIndex == 0)
        {

        }
        else if(RadioPrice.SelectedIndex==1)
        {

        }

    }
    protected void But1_Click(object sender, EventArgs e)
    {

    }
    protected void CheckListsize_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
