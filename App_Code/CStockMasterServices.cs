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
/// Summary description for CStockMasterServices
/// </summary>
public class CStockMasterServices
{
	public CStockMasterServices()
	{
		
	}
    public static DataSet StockMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);

        DataSet dsStockMasterList = new DataSet();
        ObjDataAdapter.Fill(dsStockMasterList);

        return dsStockMasterList;

    }
    public static double SRatetbySize(int ProductId,int SizeId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SRatebySize";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);

        double intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;


    }
    public static DataSet StockMasterListbyProductId(int ProductId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockMasterListbyProductId";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);

        DataSet dsStockMasterListbyProductId = new DataSet();
        ObjDataAdapter.Fill(dsStockMasterListbyProductId);

        return dsStockMasterListbyProductId;
    }

    public static int StockMasterInsert(int ProductId,int SizeId, int Qty,double PRate,double SRate)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@Qty", Qty);
        ObjCommand.Parameters.AddWithValue("@PRate", PRate);
        ObjCommand.Parameters.AddWithValue("@SRate", SRate);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;

    }
    public  int StockMasterUpdate(int StockId, int ProductId,int SizeId, int Qty,double PRate,double SRate)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StockId", StockId);
        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@Qty", Qty);
        ObjCommand.Parameters.AddWithValue("@PRate", PRate);
        ObjCommand.Parameters.AddWithValue("@SRate", SRate);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static int StockMasterDelete(int StockId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StockId", StockId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static DataSet DisplayStockRep(int ProductId,int CategoryId, int SubCategoryId,int CosubcategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        
        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StockRep";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@P_in_ProductId",DBNull.Value);
        ObjCommand.Parameters.AddWithValue("@P_in_CategoryId", DBNull.Value);
        ObjCommand.Parameters.AddWithValue("@P_in_SubCategoryId", DBNull.Value);
        ObjCommand.Parameters.AddWithValue("@P_in_CosubcategoryId", DBNull.Value);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsStockRep = new DataSet();
        ObjDataAdapter.Fill(dsStockRep);

        return dsStockRep;
    }
}
