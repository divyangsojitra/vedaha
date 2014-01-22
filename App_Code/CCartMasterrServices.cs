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
/// Summary description for CCartMasterrServices
/// </summary>
public class CCartMasterrServices
{
	public CCartMasterrServices()
	{
		
	}
    public static DataSet CartList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        //ObjCommand.CommandText="CartMasterList";
        //ObjCommand.CommandText = "CartMasrterDetailsbyCustomerId1";
        ObjCommand.CommandText = "CartMasterList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

       SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
       DataSet DsCartMasterList = new DataSet();

       ObjDataAdapter.Fill(DsCartMasterList);
       return (DsCartMasterList);


    }
    public static DataSet CartMasrterDetailsbyCustomerId(int CustomerId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        
        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CartMasrterDetailsbyCustomerId1";
        ObjCommand.CommandType = CommandType.StoredProcedure;

    

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet DsCartMasrterDetailsbyCustomerId1 = new DataSet();

        ObjDataAdapter.Fill(DsCartMasrterDetailsbyCustomerId1);
        return (DsCartMasrterDetailsbyCustomerId1);


    }

    public static int CartInsert(int ProductId,int SizeId, double Price, int Qty, double Total,string Image)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand ();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "CartMasterInsert";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@CartId", CartId);
        ObjCommand.Parameters.AddWithValue("@ProductId",ProductId);
       ObjCommand.Parameters.AddWithValue("@SizeId",SizeId);
        ObjCommand.Parameters.AddWithValue("@Price",Price);
        ObjCommand.Parameters.AddWithValue("@Qty",Qty);
        ObjCommand.Parameters.AddWithValue("@Total",Total);
     
        //ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);
        ObjCommand.Parameters.AddWithValue("@Image", Image);
        //ObjCommand.Parameters.AddWithValue("@TotalAmt", TotalAmt);

        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;


    }
    public static int CartUpdate(int CartId, int ProductId,int SizeId,double Price, int Qty, double Total, int CustomerId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CartMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CartId", CartId);
        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@Price", Price);
        ObjCommand.Parameters.AddWithValue("@Qty", Qty);
        ObjCommand.Parameters.AddWithValue("@Total", Total);
        //ObjCommand.Parameters.AddWithValue("@CustomerId",CustomerId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
    public static int CartDelete(int CartId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CartMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CartId", CartId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
}
