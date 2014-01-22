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
/// Summary description for CSizeMasterServices
/// </summary>
public class CSizeMasterServices
{
	public CSizeMasterServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DataSet BindSizeMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SizeMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSizeMasterList = new DataSet();

        ObjDataAdapter.Fill(dsSizeMasterList);
        return dsSizeMasterList;
    }
    public static int SizeMasterInsert(string Desc)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SizeMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

       // ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@Desc",Desc);

        int intReturnValues =Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static int SizeMasterUpdate(int SizeId,string Desc)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText ="SizeMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
        ObjCommand.Parameters.AddWithValue("@Desc",Desc);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;


    }
    public static int SizeMasterDelete(int SizeId)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        
        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="SizeMasterDelete";
        ObjCommand.CommandType=CommandType.StoredProcedure;
        
        ObjCommand.Parameters.AddWithValue("@SizeId",SizeId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }

}
