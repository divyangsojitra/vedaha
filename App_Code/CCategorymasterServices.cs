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
/// Summary description for CCategorymasterServices
/// </summary>
public class CCategorymasterServices
{
	public CCategorymasterServices()
	{
	}
    public static DataSet CategorymasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CategoryMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCategoryMasterList = new DataSet();

        ObjDataAdapter.Fill(dsCategoryMasterList);

        return dsCategoryMasterList;
    }
    public static DataSet CategorymasterList(int ProductId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CategoryMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCategoryMasterList = new DataSet();

        ObjDataAdapter.Fill(dsCategoryMasterList);

        return dsCategoryMasterList;
    }
    public static int CategoryInsert(int CategoryCode,string CategoryName,string Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
       ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "CategoryMasterInsert";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CategoryCode",CategoryCode);
        ObjCommand.Parameters.AddWithValue("@CategoryName",CategoryName);
        ObjCommand.Parameters.AddWithValue("@Status",Status);
        
        int intReturnValue =Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int CategoryUpdate(int CategoryId,int CategoryCode,string CategoryName,string Status)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="CategoryMasterUpdate";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        ObjCommand.Parameters.AddWithValue ("@CategoryCode",CategoryCode);
        ObjCommand.Parameters.AddWithValue("@CategoryName",CategoryName);
        ObjCommand.Parameters.AddWithValue("@Status",Status);

        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int CategoryDelete(int CategoryId)
    {  
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        
        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CategoryMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CategoryId",CategoryId);


        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
}
  