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
/// Summary description for CSupplierMasterServices
/// </summary>
public class CSupplierMasterServices
{
	public CSupplierMasterServices()
	{
		
	}
    public static DataSet SupplierMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SupplierMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSupplierMasterList = new DataSet();

        ObjDataAdapter.Fill(dsSupplierMasterList);
        return (dsSupplierMasterList);
    }
    public static int SupplierInsert(string Suppliername,string Address,string Area,string City,int Pincode,string Contactno,string EmailId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SupplierMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@Suppliername", Suppliername);
        ObjCommand.Parameters.AddWithValue("@Address", Address);
        ObjCommand.Parameters.AddWithValue("@Area", Area);
        ObjCommand.Parameters.AddWithValue("@City", City);
        ObjCommand.Parameters.AddWithValue("@Pincode", Pincode);
        ObjCommand.Parameters.AddWithValue("@Contactno", Contactno);
        ObjCommand.Parameters.AddWithValue("@EmailId", EmailId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int SupplierUpdate(int SupplierId, 
                                    string Suppliername, 
                                    string Address, 
                                    string Area, 
                                    string City, 
                                    int Pincode, 
                                    string Contactno, 
                                    string EmailId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SupplierMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SupplierId",SupplierId);
        ObjCommand.Parameters.AddWithValue("@Suppliername", Suppliername);
        ObjCommand.Parameters.AddWithValue("@Address", Address);
        ObjCommand.Parameters.AddWithValue("@Area", Area);
        ObjCommand.Parameters.AddWithValue("@City", City);
        ObjCommand.Parameters.AddWithValue("@Pincode", Pincode);
        ObjCommand.Parameters.AddWithValue("@Contactno", Contactno);
        ObjCommand.Parameters.AddWithValue("@EmailId", EmailId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
    public static int SupplierDelete(int SupplierId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SupplierMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SupplierId", SupplierId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;

    }
}
