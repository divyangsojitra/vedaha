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
/// Summary description for CPurchseMasterServices
/// </summary>
/// 
public class CPurchseMasterServices
{
	public CPurchseMasterServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int PurchseEnteryInsert(int ProductId,int PurchaseBillno, DateTime PurchaseBillDate, 
        int SizeId, int PQty, double PRate,decimal Amount,decimal Total,decimal Addless,decimal Netamount)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "PurchseMasterInset";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@PurchaseBillno", PurchaseBillno);
        ObjCommand.Parameters.AddWithValue("@PurchaseBillDate", PurchaseBillDate);
        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@PQty", PQty);
        ObjCommand.Parameters.AddWithValue("@PRate", PRate);
        ObjCommand.Parameters.AddWithValue("@Amount", Amount);
        ObjCommand.Parameters.AddWithValue("@Total",Total);
        ObjCommand.Parameters.AddWithValue("@Addless", Addless);
        ObjCommand.Parameters.AddWithValue("@Netamount", Netamount);


        int intReturnValue1 = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue1; 

             
    }

    public int PurchseUpdate
        (int PurchseId, int PurchaseBillno, DateTime PurchaseBillDate, int SizeId, int PQty, double PRate, double SRate,
        decimal Amount,decimal Total,decimal Addless,decimal Netamount)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        //ObjCommand.CommandText = "StockQtyReturnList";
        ObjCommand.CommandText = "PurchseMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@PurchseId", PurchseId);
        ObjCommand.Parameters.AddWithValue("@PurchaseBillno",PurchaseBillno);
        ObjCommand.Parameters.AddWithValue("@PurchaseBillDate",PurchaseBillDate);
        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@PRate", PRate);
        ObjCommand.Parameters.AddWithValue("@PQty",PQty);
        ObjCommand.Parameters.AddWithValue("@SRate", SRate);
        //ObjCommand.Parameters.AddWithValue("@SQty",SQty);
        
        ObjCommand.Parameters.AddWithValue("@Amount",Amount);
        ObjCommand.Parameters.AddWithValue("@Addless",Addless);
        ObjCommand.Parameters.AddWithValue("@Total",Total);
        ObjCommand.Parameters.AddWithValue("@Netamount",Netamount);

        int intReturnvalue2 = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnvalue2;


    }
    public static int PurchaseDelete(int PurchseId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "PurchseMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@PurchseId", PurchseId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }

    public static int SellEnteryInsert(int ProductId, int SQty, double SRate)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SellEnteryInset";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@SQty", SQty);
        ObjCommand.Parameters.AddWithValue("@SRate", SRate);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;

    }

    public static int StockQtyList(int ProductId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockQtyList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
       
        SqlParameter retValParam = new SqlParameter("@Availableqty", SqlDbType.Int);
        retValParam.Direction = ParameterDirection.ReturnValue;
        ObjCommand.Parameters.Add(retValParam);

        ObjCommand.ExecuteNonQuery();

        int intReturnValues=0;
        if(retValParam != null)
        {
            intReturnValues = Convert.ToInt32(retValParam.Value);
        }
        
        return intReturnValues;
    }

    public int CustomerReturnQty(string PurchseId, int SQty, double SRate, int ReturnStatus)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockQtyReturnList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@PurchseId", PurchseId);
        ObjCommand.Parameters.AddWithValue("@SQty", SQty);
        ObjCommand.Parameters.AddWithValue("@SRate", SRate);
        ObjCommand.Parameters.AddWithValue("@ReturnStatus", ReturnStatus);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;

    }
    
}
