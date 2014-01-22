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
/// Summary description for CFabricMasterServices
/// </summary>
public class CFabricMasterServices
{
	public CFabricMasterServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DataSet FabricMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FabricMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@FabricId", "FabricId");

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsFabricMasterList = new DataSet();

        ObjDataAdapter.Fill(dsFabricMasterList);
        //ObjDataAdapter.Fill(dsFabricMasterList);

        return dsFabricMasterList;
    }
    public static int FabricMasterInsert(string Fabricname, string Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FabricMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@FabricId", FabricId);
        ObjCommand.Parameters.AddWithValue("@Fabricname", Fabricname);
        ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnvalue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnvalue;

    }
    public static int FabricMasterUpdate(int FabricId, string Fabricname, string Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FabricMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@FabricId", FabricId); 
        ObjCommand.Parameters.AddWithValue("@Fabricname",Fabricname);
        ObjCommand.Parameters.AddWithValue("@Status",Status);

        int intReturnvalue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnvalue;
    }
    public static int FabricMasterDelete(int FabricId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FabricMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@FabricId", FabricId);

        int intReturnvalue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnvalue;
    }
}
