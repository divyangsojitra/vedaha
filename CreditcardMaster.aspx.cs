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

public partial class CreditcardMaster : System.Web.UI.Page
{
    double Amt;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (this.IsPostBack == false)
        {
            LblOrderId.Text = Session["OrderId"].ToString();
        }
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="OrderMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;
        ObjCommand.Parameters.AddWithValue("@OrderId",Convert.ToInt32(LblOrderId.Text));

        SqlDataAdapter ObjdataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsOrderMasterDetails=new DataSet();

        ObjdataAdapter.Fill(dsOrderMasterDetails);
        if(dsOrderMasterDetails.Tables[0].Rows.Count>0)
        {
            DataRow dr=dsOrderMasterDetails.Tables[0].Rows[0];
        Amt=Convert.ToDouble(dr["TotalAmt"]);
        }
      TxtAmount.Text = Amt.ToString();

    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValue = CCreditcardServices.CCreditcardInsert(
           TxtCardHolderName.Text,Convert.ToInt32(LblOrderId.Text),
          //Convert.ToInt32 (dropOrderIdList.SelectedValue),
           Convert.ToInt32(TxtCreditcardno.Text),DropCard.SelectedValue,
           Convert.ToInt32(Txtcvc2no.Text),Convert.ToDateTime(Txtexpirydate.Text),Convert.ToDouble(TxtAmount.Text));
        LblTransactionId.Text = intReturnValue.ToString();
        if(intReturnValue>0)
        {
            TxtCardHolderName.Text="";
            TxtCreditcardno.Text="";
            
            Txtcvc2no.Text="";
            Txtexpirydate.Text="";
            TxtAmount.Text = "";

        }
        CCreditcardMaster ObjCard = new CCreditcardMaster(Convert.ToInt32(LblTransactionId.Text));
        if (ObjCard.IsExit == true)
        {
            Session["TransactionId"] = ObjCard.TransactionId;
        }
        Response.Redirect("UsershopingDetailcopy.aspx");
    }
}
