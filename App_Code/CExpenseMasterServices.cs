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
/// Summary description for CExpenseMasterServices
/// </summary>
public class CExpenseMasterServices
{
	public CExpenseMasterServices()
	{
		
	}

    public static DataSet ExpenseMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsExpenseMasterList = new DataSet();

        ObjDataAdapter.Fill(dsExpenseMasterList);
        return dsExpenseMasterList;

    }
    public static DataSet ExpenseMasterTaccountList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseMasterAccount";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsExpenseMasterAccount = new DataSet();

        ObjDataAdapter.Fill(dsExpenseMasterAccount);
        return dsExpenseMasterAccount;

    }
   public static int ExpenseMasterInsert(int VNo,DateTime VDate,int ExpensecategoryId,string ExpenseDesc,double Amount,string Type)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@VNo",VNo);
        ObjCommand.Parameters.AddWithValue("@VDate", VDate);
        ObjCommand.Parameters.AddWithValue("@ExpensecategoryId", ExpensecategoryId);
        ObjCommand.Parameters.AddWithValue("@ExpenseDesc", ExpenseDesc);
        ObjCommand.Parameters.AddWithValue("@Amount", Amount);
        ObjCommand.Parameters.AddWithValue("@Type", Type);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
   public static int ExpenseMasterUpdate(int ExpenseId,int VNo,DateTime VDate,int ExpensecategoryId,string ExpenseDesc,double Amount,string Type)
   {
       SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
       ObjConnection.Open();

       SqlCommand ObjCommand = new SqlCommand();
       ObjCommand.Connection = ObjConnection;
       ObjCommand.CommandText = "ExpenseMasterUpdate";
       ObjCommand.CommandType = CommandType.StoredProcedure;

       ObjCommand.Parameters.AddWithValue("@ExpenseId", ExpenseId);
       ObjCommand.Parameters.AddWithValue("@VNo", VNo);
       ObjCommand.Parameters.AddWithValue("@VDate", VDate);
       ObjCommand.Parameters.AddWithValue("@ExpensecategoryId", ExpensecategoryId);
       ObjCommand.Parameters.AddWithValue("@ExpenseDesc", ExpenseDesc);
       ObjCommand.Parameters.AddWithValue("@Amount", Amount);
       ObjCommand.Parameters.AddWithValue("@Type", Type);

       int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
       return intReturnValue;
   }
    public static int ExpenseMasterDelete(int ExpenseId)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "ExpenseMasterDelete";
        ObjCommand.CommandType=CommandType.StoredProcedure;
        
        ObjCommand.Parameters.AddWithValue("@ExpenseId",ExpenseId);

        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static DataSet ExpenseRep()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseRep";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet DsExpenseRep = new DataSet();

        ObjDataAdapter.Fill(DsExpenseRep);
        return DsExpenseRep;

    }
}
