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
/// Summary description for CExpensecategoryMasterServices
/// </summary>
public class CExpensecategoryMasterServices
{
	public CExpensecategoryMasterServices()
	{
		
	}
    public static DataSet ExpenseCategoryMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseCategoryMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsExpenseCategoryMasterList = new DataSet();

        ObjDataAdapter.Fill(dsExpenseCategoryMasterList);
        return dsExpenseCategoryMasterList;
    }
    public static int ExpenseCategoryMasterInsert(string Expensecategoryname)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseCategoryMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@ExpensecategoryId", ExpensecategoryId);
        ObjCommand.Parameters.AddWithValue("@Expensecategoryname",Expensecategoryname);
        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static int ExpenseCategoryMasterUpDate(int ExpensecategoryId, string Expensecategoryname)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseCategoryMasterUpDate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ExpensecategoryId", ExpensecategoryId);
        ObjCommand.Parameters.AddWithValue("@Expensecategoryname", Expensecategoryname);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static int ExpenseCategoryMasterDelete(int ExpensecategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseCategoryMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ExpensecategoryId",ExpensecategoryId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
}
