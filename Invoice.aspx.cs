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

public partial class Invoice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Request.QueryString["Oid"] == null || Request.QueryString["Oid"] = "")
        //{
        //    Response.Redirect("OrderMaster.aspx");
        //    return;
        //}
        
        TxtInvoiceDate.Text = System.DateTime.Now.ToString();
        TxtFinaldeliveryDate.Text = System.DateTime.Now.AddDays(7).ToString();
        //int intTrId= Convert.ToInt32(Request.QueryString["Tid"]);
       LblOrderId.Text = (Request.QueryString["Oid"]).ToString();
        //LblTransactionId.Text = intTrId.ToString();

        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    DataRow dr = ds.Tables[0].Rows[0];
        //    m_InvoiceId = Convert.ToInt32(dr["InvoiceId"]);



       DataSet ds = CInvoiceServices.InvoiceData(Convert.ToInt32(LblOrderId.Text));
      if(ds.Tables[0].Rows.Count>0);
            {
                    //DataRow dr = dsInvoiceMasterDataDispaly.Tables[0].Rows[0];
              // LblOrderId.Text = (dr["OrderId"]).ToString();
               //LblOrderId.Text = dsInvoiceMasterDataDispaly.Tables[0].Rows[0]["OrderId"].ToString();
                LblOrderId.Text = ds.Tables[0].Rows[0]["OrderId"].ToString();
                LblOrderDate.Text =ds.Tables[0].Rows[0]["OrderDate"].ToString();

                LblCustomerAccountNo.Text =ds.Tables[0].Rows[0]["CustomerId"].ToString();
                LblEmailId.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();
                LblFirstname.Text = ds.Tables[0].Rows[0]["Firstname"].ToString();
                LblAddress.Text = ds.Tables[0].Rows[0]["Shp_Address"].ToString();
                LblCity.Text = ds.Tables[0].Rows[0]["Shp_City"].ToString();
                LblPincode.Text =ds.Tables[0].Rows[0]["shp_pincode"].ToString();
                LblState.Text = ds.Tables[0].Rows[0]["Shp_State"].ToString();
                LblPhone.Text = ds.Tables[0].Rows[0]["shp_phoneno"].ToString();
                LblTransactionId.Text = ds.Tables[0].Rows[0]["TransactionId"].ToString();
                LblPaymentDate.Text = ds.Tables[0].Rows[0]["PaymentDate"].ToString();
                LblCardHolderName.Text = ds.Tables[0].Rows[0]["CardHolderName"].ToString();
                LblCard.Text = ds.Tables[0].Rows[0]["Card"].ToString();

                LblTotalAmt.Text =ds.Tables[0].Rows[0]["Expr1"].ToString();
                LblPaymentType.Text = ds.Tables[0].Rows[0]["PaymentOption"].ToString();
            }

       ////// COrderMaster ObjOrderId = new COrderMaster(intOrderId);
       ////// if (ObjOrderId.IsExit == true)
       ////// {
       

       ////// }
            DataSet dsOrderDetailbyOrderId = COrderMasterDetailServices.OrderMasterDetailListbyOrderId_Pro(Convert.ToInt32(LblOrderId.Text));
            GvShopingList.DataSource = dsOrderDetailbyOrderId;
            GvShopingList.DataBind();
       ////// LblOrderId.Text = intOrderId.ToString();

       ////// DataSet dsCreditcardMasterDetailsbyOrderId = CCreditcardServices.CreditcardMasterDetailsbyOrderId(Convert.ToInt32(LblOrderId.Text));
            
       ////////// DataSet dsCreditcardMasterDetailsbyOrderId = CCreditcardServices.CreditcardMasterDetailsbyOrderId(Convert.ToInt32(LblOrderId.Text));




        //CCreditcardServices ObjOderId1 = new CCreditcardMaster(Convert.ToInt32(LblOrderId.Text));
        //if (ObjOrderId.IsExit == true)
        //{
        //    LblTransactionId.Text = ObjOrderId1.TransactionId.ToString();
        //    LblCardHolderName.Text = ObjOrderId1.Cardholdarname;
        //LblCard.Text = ObjOrderId;
        //LblPaymentType.Text = ObjTransactionId.expirydate;
        //LblPaymentDate.Text=Obj
        //}
    }
    public static string getTime()
    {
        return DateTime.Now.ToString("hh:mm:ss tt");
    }
    public static string getTime_DELIVERYdt()
    {
        return DateTime.Now.AddDays(7).ToString("hh:mm:ss tt");
        
    }
    protected void ButSubmit_Click(object sender, EventArgs e)
    {
        int intReturnValue = CInvoiceServices.InvoiceInsert(Convert.ToDateTime(TxtInvoiceDate.Text),Convert.ToInt32(LblOrderId.Text), Convert.ToDateTime(TxtFinaldeliveryDate.Text),Convert.ToBoolean(checkDelivaryStatus.Checked));
        if (intReturnValue > 0)
        {
            TxtInvoiceDate.Text = "";
            TxtFinaldeliveryDate.Text = "";
            LblOrderId.Text = "";
            LblPaymentDate.Text = "";
            LblTransactionId.Text = "";
            LblCustomerAccountNo.Text = "";
            LblFirstname.Text = "";
            LblCity.Text = "";
            LblAddress.Text = "";
            LblState.Text = "";
            LblPincode.Text = "";
            LblPhone.Text = "";
            LblEmailId.Text = "";
            LblPaymentType.Text = "";

        }
    }
    

    protected void ButPrint_Click(object sender, EventArgs e)
    {
        Response.Redirect("InvoicePrint.aspx"); 
    }
}
