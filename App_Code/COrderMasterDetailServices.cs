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
/// Summary description for COrderMasterDetailServices
/// </summary>
public class COrderMasterDetailServices
{
	public COrderMasterDetailServices()
	{
		
	}
    public static DataSet OrderMasterDetailList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="OrderDetailList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsOrderDetailList=new DataSet();

        ObjDataAdapter.Fill(dsOrderDetailList);
        return(dsOrderDetailList);

    }
    public static DataSet OrderMasterDetailListbyOrderId(int OrderId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "OrderDetailbyOrderId";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsOrderDetailbyOrderId = new DataSet();

        ObjDataAdapter.Fill(dsOrderDetailbyOrderId);
        return (dsOrderDetailbyOrderId);

    }
    public static DataSet OrderMasterDetailListbyOrderId_Pro(int OrderId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "UsercopyProductList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsUsercopyProductList = new DataSet();

        ObjDataAdapter.Fill(dsUsercopyProductList);
        return (dsUsercopyProductList);

    }
    public static int OrderMasterDetailInsert( int OrderId, int ProductId,int SizeId, int Qty, double Price, double LineTotalAmt ,double TotalAmt)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="OrderDetailInsert";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@OrderDetailId",OrderDetailId);
        ObjCommand.Parameters.AddWithValue("@OrderId",OrderId);
        ObjCommand.Parameters.AddWithValue("@ProductId",ProductId);
        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@Qty",Qty);
        ObjCommand.Parameters.AddWithValue("@Price", Price);
        ObjCommand.Parameters.AddWithValue("@LineTotalAmt",LineTotalAmt);
        ObjCommand.Parameters.AddWithValue("@TotalAmt",TotalAmt);

        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int OrderMasterDeteilUpdate(int OrderId, int ProductId,int SizeId, int Qty, double Price,double LineTotalAmt, double TotalAmt)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "OrderDetailUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@OrderDetailId", OrderDetailId);
        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@SizeId",SizeId);
        ObjCommand.Parameters.AddWithValue("@Qty", Qty);
        ObjCommand.Parameters.AddWithValue("@Price", Price);
        ObjCommand.Parameters.AddWithValue("@LineTotalAmt", LineTotalAmt);
        ObjCommand.Parameters.AddWithValue("@TotalAmt", TotalAmt);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
    public static int StockQtyReturnListOrderDetail(int OrderId, int Qty, double Price, double LineTotalAmt)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockQtyReturnListOrderDetail";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
        ObjCommand.Parameters.AddWithValue("@Qty", Qty);
        ObjCommand.Parameters.AddWithValue("@Price", Price);
        ObjCommand.Parameters.AddWithValue("@LineTotalAmt", LineTotalAmt);

        int intReturnValue1 = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue1;
    
    }


}
