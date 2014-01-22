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

public partial class UsershopingDetailcopy : System.Web.UI.Page
{
    string Phoneno;
    DateTime Date;
     double Tot;
     int Pincode;
    protected void Page_Load(object sender, EventArgs e)
     {
         if (this.IsPostBack == false)
         {
             LblCustomerAccountNo.Text = Session["CustomerId"].ToString();
             LblOrderId.Text = Session["OrderId"].ToString();
             
             LblEmailId.Text=Session["EmailId"].ToString();
             LblTransactionId.Text = Session["TransactionId"].ToString();
         }
         SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
         ObjConnection.Open();

         SqlCommand ObjCommand = new SqlCommand();
         ObjCommand.Connection = ObjConnection;
         ObjCommand.CommandText = "OrderMasterDetails";
         ObjCommand.CommandType = CommandType.StoredProcedure;

         ObjCommand.Parameters.AddWithValue("@OrderId", Convert.ToInt32(LblOrderId.Text));

         SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
         DataSet dsOrderMasterDetails = new DataSet();

         ObjDataAdapter.Fill(dsOrderMasterDetails);
         if (dsOrderMasterDetails.Tables[0].Rows.Count > 0)
         {
             DataRow dr = dsOrderMasterDetails.Tables[0].Rows[0];
             LblFirstname.Text = dr["Firstname"].ToString();
             LblAddress.Text = dr["Address"].ToString();
             LblCity.Text = dr["City"].ToString();
             LblState.Text = dr["State"].ToString();
             Phoneno = dr["Phoneno"].ToString();
             Date = Convert.ToDateTime(dr["OrderDate"]);
             Lblmob.Text = Phoneno.ToString();
             LblOrderDate.Text = Date.ToString();
             Pincode = Convert.ToInt32(dr["Pincode"]);
             LblPincode.Text = Pincode.ToString();
             LblPaymentType.Text = dr["PaymentOption"].ToString();
             //Label TotalAmt = (Label)GvShopingList.FooterRow.FindControl("LblTotal");
             // double data5 = Convert.ToDouble(TotalAmt.Text);
             Tot = Convert.ToDouble(dr["TotalAmt"]);
             LblTotalAmt.Text = Tot.ToString();
         }

         DataSet dsOrderDetailbyOrderId = COrderMasterDetailServices.OrderMasterDetailListbyOrderId_Pro(Convert.ToInt32(LblOrderId.Text));
         GvShopingList.DataSource = dsOrderDetailbyOrderId;
         GvShopingList.DataBind();
         //Label Total = (Label)GvShopingList.FooterRow.FindControl("LblTotal");
         //LblTotal.Text = (Total.Text);
         //double data5 = Convert.ToDouble(TotalAmt.Text);
         // LblTotal
       
         
            // SqlConnection Connection = new SqlConnection(Common.C_ConnectionString);
             //ObjConnection1.Open();

             SqlCommand ObjCommand1 = new SqlCommand();
             ObjCommand1.Connection = ObjConnection;
             ObjCommand1.CommandText = "CreditcardMasterDetails";
             ObjCommand1.CommandType = CommandType.StoredProcedure;

             ObjCommand1.Parameters.AddWithValue("@TransactionId", Convert.ToInt32(LblTransactionId.Text));

            SqlDataAdapter ObjDataAdapter1 = new SqlDataAdapter(ObjCommand1);
             DataSet dsCreditcardMasterDetails = new DataSet();

             ObjDataAdapter1.Fill(dsCreditcardMasterDetails);

             if (dsCreditcardMasterDetails.Tables[0].Rows.Count > 0)
             {
                 DataRow dr = dsCreditcardMasterDetails.Tables[0].Rows[0];
                 LblCard.Text = dr["Card"].ToString();
                 LblCardHolderName.Text = dr["CardHolderName"].ToString();
                 Date=Convert.ToDateTime(dr["PaymentDate"]);

                LblPaymentDate.Text=Date.ToString();

             }
         

     }
}
