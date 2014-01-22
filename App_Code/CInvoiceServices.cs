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
/// Summary description for CInvoiceServices
/// </summary>
public class CInvoiceServices
{
	public CInvoiceServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static int InvoiceInsert(DateTime InvoiceDate, int OrderId, DateTime FinaldeliveryDate,bool DeliveryStatus)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "InvioceInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
        ObjCommand.Parameters.AddWithValue("@FinaldeliveryDate", FinaldeliveryDate);
        ObjCommand.Parameters.AddWithValue("@DeliveryStatus", DeliveryStatus);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static DataSet InvoiceData(int OrderId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "InvoiceMasterDataDispaly";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);
        //int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);

        DataSet ds=new DataSet();

        ObjDataAdapter.Fill(ds);
        return ds;
    }
    public static DataSet invoice_done_delivey_pending()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "invoice_done_delivey_pending";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet Dsinvoice_done_delivey_pending=new DataSet();

        ObjDataAdapter.Fill(Dsinvoice_done_delivey_pending);
        return Dsinvoice_done_delivey_pending;
    }
    public static DataSet invoice_done_an_delivery_done()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "invoice_done_an_delivery_done";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet Dsinvoice_done_an_delivery_done = new DataSet();

        ObjDataAdapter.Fill(Dsinvoice_done_an_delivery_done);
        return Dsinvoice_done_an_delivery_done;
    }
    public static DataSet PendingInvoice()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "PendingInvoice";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet DsPendingInvoice = new DataSet();

        ObjDataAdapter.Fill(DsPendingInvoice);
        return DsPendingInvoice;
    }
    public static DataSet invoice_summary()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "invoice_summary";

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet DsInvoice_summary = new DataSet();

        ObjDataAdapter.Fill(DsInvoice_summary);
        return DsInvoice_summary;
    }
}
