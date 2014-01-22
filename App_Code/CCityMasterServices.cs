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
/// Summary description for CCityMasterServices
/// </summary>
public class CCityMasterServices
{
	public CCityMasterServices()
	{
        
	
	}
    public static DataSet CityMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CityMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter objDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCityMasterList = new DataSet();

        objDataAdapter.Fill(dsCityMasterList);
        return dsCityMasterList;
    }
    public static DataSet BindStateMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StateMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsStateMasterList = new DataSet();

        ObjDataAdapter.Fill(dsStateMasterList);
        return dsStateMasterList;


    }
    public static int CityMasterInsert(int CityId, string Cityname, int StateId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="CityMasterInsert";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CityId",CityId);
        ObjCommand.Parameters.AddWithValue("@Cityname",Cityname);
        ObjCommand.Parameters.AddWithValue("@StateId",StateId);

        int intReturnValues=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;

    }
    public static int CityMasterUpdate(int CityId, string Cityname, int StateId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CityMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CityId", CityId);
        ObjCommand.Parameters.AddWithValue("@Cityname", Cityname);
        ObjCommand.Parameters.AddWithValue("@StateId", StateId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static int CityMasterDelete(int CityId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CityMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CityId", CityId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
}
