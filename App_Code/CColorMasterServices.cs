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
/// Summary description for CColorMasterServices
/// </summary>
public class CColorMasterServices
{
	public CColorMasterServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //public static int ColorMasterInsert()
    //{
    //}

    public static DataSet DisplayColorval(string val)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "Displaycolorname";
        ObjCommand.CommandType = CommandType.StoredProcedure;



        ObjCommand.Parameters.AddWithValue("@Val", val);
    
        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsDisplaycolorname = new DataSet();

        ObjDataAdapter.Fill(dsDisplaycolorname);

        return dsDisplaycolorname;
    }
}
