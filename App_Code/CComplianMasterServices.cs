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
/// Summary description for CComplianMasterServices
/// </summary>
public class CComplianMasterServices
{
	public CComplianMasterServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DataSet BindComplianList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ComplianMasterList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        SqlDataAdapter ObjdataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsComplianMasterList=new DataSet();

        ObjdataAdapter.Fill(dsComplianMasterList);
        return dsComplianMasterList;

        
    }
}
