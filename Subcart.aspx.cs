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
using System.Data.SqlClient;

public partial class Subcart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //BindDatalist();
        string StartSRate;
        string EndSRate;
        
        if (this.IsPostBack == false)
        {

            LblCategoryId.Text = Request.QueryString["Scat"];
            Session["CategoryId"] = LblCategoryId.Text;

        }


        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SubCategoryImage";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        ObjCommand.Parameters.AddWithValue("@CategoryId", Convert.ToInt32(LblCategoryId.Text));

        //DataTable dt = new DataTable();

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSubCategoryImage = new DataSet();
        ObjDataAdapter.Fill(dsSubCategoryImage);

       

        DataSubCategoryList.DataSource = dsSubCategoryImage;
        DataSubCategoryList.DataBind();


        ////////Image1.ImageUrl = "~/Image/" + dt.Rows[0]["Image"];
        ////////Image1.PostBackUrl = "~/Cosubcart.aspx?Cscat=" + dt.Rows[0]["SubCategoryId"];
        ////////Image2.ImageUrl = "~/Image/" + dt.Rows[1]["Image"];
        ////////Image2.PostBackUrl = "~/Cosubcart.aspx?Cscat=" + dt.Rows[1]["SubCategoryId"];
        ////////Image3.ImageUrl = "~/Image/" + dt.Rows[2]["Image"];
        ////////Image3.PostBackUrl = "~/Cosubcart.aspx?Cscat=" + dt.Rows[2]["SubCategoryId"];
        ////////Image4.ImageUrl = "~/Image/" + dt.Rows[3]["Image"];
        ////////Image4.PostBackUrl = "~/Cosubcart.aspx?Cscat=" + dt.Rows[3]["SubCategoryId"];

    }
    //public void RadioPrice(string SelectIndex)
    //{
    //}
    
    //public void BindDatalist()
    //{
    //    DataSet dsSubCategoryImage = CProductMasterServices.ProductsubcategorycartList(int.Parse(Request.QueryString["Scat"].ToString()));
    //    ImageDataList.DataSource = dsSubCategoryImage;
    //    ImageDataList.DataBind();
    //}

    protected void Page_Init(object sender, EventArgs e)
    {
       // Master.PriceRadio.SelectedValue += new EventHandler;
        Master.but2.Click += new EventHandler(but2_Click);
        
        Master.PriceRadio.SelectedIndexChanged += new EventHandler(PriceRadio_SelectedIndexChanged1);
        Master.ChecksizeList.SelectedIndexChanged += new EventHandler(CheckListsize_SelectedIndexChanged);
    }

    protected void CheckListsize_SelectedIndexChanged(object sender, EventArgs e)
    {
        //int Count = 0;   
        //bool oneSelected = false;
        //foreach (ListItem item in  Master.ChecksizeList.Items)
        //{
        //    if (item.Selected)
        //    {
        //        oneSelected = true;
        //        if (oneSelected == true)
        //        {
        //            Count = Count + 1;
        //            Master.Lcount.Text = Count.ToString();
        //        }
        //    }
        //}
        Master.Lcount.Text = "";
        for (int i = 0; i < Master.ChecksizeList.Items.Count; i++)
        {
            if (Master.ChecksizeList.Items[i].Selected)
            {
                Master.Lcount.Text += Master.ChecksizeList.Items[i].Text + ',';
            }
        }


    
        
    }
    protected void but2_Click(object sender, EventArgs e)
    {

        Lblmsg.Text = "aaaa";

    }
    protected void PriceRadio_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (Master.PriceRadio.SelectedIndex == 0)
        {
            //BindSerchData();
           string StartSRate = "0";
         string  EndSRate= "900";
            SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
            ObjConnection.Open();

            SqlCommand ObjCommand = new SqlCommand();
            ObjCommand.Connection = ObjConnection;
            ObjCommand.CommandText = "ProductsearchPrice";
            ObjCommand.CommandType = CommandType.StoredProcedure;


           ObjCommand.Parameters.AddWithValue("@cATEGORYID_LIST", Convert.ToInt32(LblCategoryId.Text));
            ObjCommand.Parameters.AddWithValue("@StartSRate", StartSRate.ToString());
            ObjCommand.Parameters.AddWithValue("@EndSRate", EndSRate.ToString());
            
            //DataTable dt = new DataTable();

            SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
            DataSet dsProductsearchPrice = new DataSet();
            ObjDataAdapter.Fill(dsProductsearchPrice);

            DataSubCategoryList.DataSource = dsProductsearchPrice;
            DataSubCategoryList.DataBind();
           
        }
        else if (Master.PriceRadio.SelectedIndex == 1)
        {
            //StartSRate = "0";
            //EndSRate = "1000";
        }
        else if (Master.PriceRadio.SelectedIndex == 2)
        {
            Lblmsg.Text = "ccc";
        }
        

    }
    public void BindSerchData(string SizeId, string Colourname, string StartSRate, string EndSRate, string CategoryId,
                                                 string SubcategoryId, string CosubcategoryId)
    {
        //DataSet dsProductsearchPrice = CProductMasterServices.BindProductsearchPrice
        //    (Master, StartSRate.ToString(), EndSRate.ToString(), Convert.ToInt32(LblCategoryId.Text),);

        //DataSubCategoryList.DataBind();
    }
}
