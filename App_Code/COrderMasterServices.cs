using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for COrderMasterServices
/// </summary>
public class COrderMasterServices
{
	public COrderMasterServices()
	{
		
	}
    public static DataSet TanstionOrderDetails()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "TanstionOrderDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
        SqlDataAdapter ObjdataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsTanstionOrderDetails = new DataSet();

        ObjdataAdapter.Fill(dsTanstionOrderDetails);

        return (dsTanstionOrderDetails);

    }
    public static DataSet OrderMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="OrderMasterList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsOrderMasterList=new DataSet();
 
        ObjDataAdapter.Fill(dsOrderMasterList);
        return (dsOrderMasterList);
        
    }
    public static int OrderMasterInsert( int CustomerId, string Firstname, string Address, string State, string City, int Pincode, string Phoneno, double TotalAmt, string PaymentOption, string PaymentStatus)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "OrderMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
       //ObjCommand.Parameters.AddWithValue("@OrderDate", OrderDate); 
        ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);
        ObjCommand.Parameters.AddWithValue("@Firstname", Firstname);
        ObjCommand.Parameters.AddWithValue("@Address", Address);
        ObjCommand.Parameters.AddWithValue("@State", State);
        ObjCommand.Parameters.AddWithValue("@City", City);
        ObjCommand.Parameters.AddWithValue("@Pincode", Pincode);
        ObjCommand.Parameters.AddWithValue("@Phoneno", Phoneno);
        ObjCommand.Parameters.AddWithValue("@TotalAmt", TotalAmt);
        ObjCommand.Parameters.AddWithValue("@PaymentOption", PaymentOption);
        ObjCommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int OrderMasterUpdate(int OrderId, DateTime OrderDate, int CustomerId, string DeliveryAddress, float TotalAmt, string PaymentOption, string PaymentStatus)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "OrderMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
        ObjCommand.Parameters.AddWithValue("@OrderDate", OrderDate);
        ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

        ObjCommand.Parameters.AddWithValue("@DeliveryAddress", DeliveryAddress);
        ObjCommand.Parameters.AddWithValue("@TotalAmt", TotalAmt);
        ObjCommand.Parameters.AddWithValue("@PaymentOption", PaymentOption);
        ObjCommand.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int OrderMasterDelete(int OrderId)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        
        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }

    public static DataSet CustomerpurchseDetail(int CustomerId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerpurchseDetail";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet DsCustomerpurchseDetail = new DataSet();

        ObjDataAdapter.Fill(DsCustomerpurchseDetail);
        return DsCustomerpurchseDetail;

    }

    
}
