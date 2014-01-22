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
/// Summary description for CSateMasterServices
/// </summary>
public class CStateMasterServices
{
	public CStateMasterServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public  static DataSet BindgvStateList()
    {
        SqlConnection Objconnection = new SqlConnection(Common.C_ConnectionString);
        Objconnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = Objconnection;
        ObjCommand.CommandText = "StateMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsStateMasterList=new DataSet();

        ObjDataAdapter.Fill(dsStateMasterList);
        return (dsStateMasterList);
    }
    public static int StateInsert(int StateId, string Statename)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StateMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StateId",StateId);
        ObjCommand.Parameters.AddWithValue("@Statename", Statename);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
    public static int StateDelete(int StateId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StateMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StateId",StateId);
        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int StateUpdate(int StateId,string Statename)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "StateMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StateId", StateId);
        ObjCommand.Parameters.AddWithValue("@Statename",Statename );

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
}
