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
/// Summary description for CFeedbackMasterrServices
/// </summary>
public class CFeedbackMasterrServices
{
	public CFeedbackMasterrServices()
	{
		
	}
    
    public static DataSet FeebBackList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FeedBackMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

       // ObjCommand.Parameters.AddWithValue("@FeedbackId", FeedbackId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsFeedBackMasterList = new DataSet();

        ObjDataAdapter.Fill(dsFeedBackMasterList);
        return (dsFeedBackMasterList);

    }
    public static DataSet CustomerFeedbackList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerFeedback";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter objDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCustomerFeedback = new DataSet();

        objDataAdapter.Fill(dsCustomerFeedback);
        return (dsCustomerFeedback);
    }
    public static int FeedBackInsert(string EmailId, string FeedbackDesc, bool Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FeedBackMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@FeedbackId", FeedbackId);

        ObjCommand.Parameters.AddWithValue("@EmailId",EmailId);
        ObjCommand.Parameters.AddWithValue("@FeedbackDesc", FeedbackDesc);
        ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;


    }
    public static int FeedBackUpdate(int FeedbackId, bool Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "FeedBackMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@FeedbackId", FeedbackId);
        ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
   
}
