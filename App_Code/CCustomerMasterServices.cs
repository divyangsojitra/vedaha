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
/// Summary description for CCustomerMasterServices
/// </summary>
public class CCustomerMasterServices
{
	public CCustomerMasterServices()
	{
		
	}
    public static DataSet CustomerMasterList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCustomerMasterList = new DataSet();

        ObjDataAdapter.Fill(dsCustomerMasterList);
        return (dsCustomerMasterList);
    }
    public static DataSet BindCityList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CityMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@StateId", StateId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCityMasterList = new DataSet();

        ObjDataAdapter.Fill(dsCityMasterList);
        return dsCityMasterList;
    }
    //public static string BindState(int StateId, string Statename, string cityname)
    //{
    //    SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
    //    ObjConnection.Open();

    //    SqlCommand ObjCommand = new SqlCommand();
    //    ObjCommand.Connection = ObjConnection;
    //    ObjCommand.CommandText = "CustomerMastercityList";
    //    ObjCommand.CommandType = CommandType.StoredProcedure;

    //    SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
    //    DataSet dsCustomerMastercityList = new DataSet();

    //    ObjDataAdapter.Fill(dsCustomerMastercityList);
    //    return dsCustomerMastercityList;
    //}
    public static int CustomerMasterInsert( 
        string Firstname, 
        string Lastname, 
        string Address,
        int CityId,
        int StateId, 
        int Pincode, 
        string Phoneno,
        DateTime Birthdate,
        string EmailId, 
        string Password, 
        bool Status,string Type)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);
        ObjCommand.Parameters.AddWithValue("@Firstname", Firstname);
        ObjCommand.Parameters.AddWithValue("@Lastname", Lastname);
        ObjCommand.Parameters.AddWithValue("@Address", Address);
        ObjCommand.Parameters.AddWithValue("@CityId", CityId);
        ObjCommand.Parameters.AddWithValue("@PinCode", Pincode);
        ObjCommand.Parameters.AddWithValue("@StateId", StateId);
        ObjCommand.Parameters.AddWithValue("@Phoneno", Phoneno);
        ObjCommand.Parameters.AddWithValue("@Birthdate", Birthdate);
        ObjCommand.Parameters.AddWithValue("@EmailId", EmailId);
        ObjCommand.Parameters.AddWithValue("@Password", Password);
        ObjCommand.Parameters.AddWithValue("@Status", Status);
        ObjCommand.Parameters.AddWithValue("@Type", Type);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;


    }

    public static int CustomerMasterUpdate(int CustomerId,string Firstname, string Lastename, string Address, string City, int Pincode, string State,string Phoneno, DateTime Birthdate)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        ObjCommand.Parameters.AddWithValue("@CustomerId",CustomerId);

        ObjCommand.Parameters.AddWithValue("@Firstname", Firstname);
        ObjCommand.Parameters.AddWithValue("@Lastname", Lastename);
        ObjCommand.Parameters.AddWithValue("@Address", Address);
        ObjCommand.Parameters.AddWithValue("@City", City);
        ObjCommand.Parameters.AddWithValue("@PinCode", Pincode);
        ObjCommand.Parameters.AddWithValue("@State", State);
        ObjCommand.Parameters.AddWithValue("@Phoneno", Phoneno);
        ObjCommand.Parameters.AddWithValue("@Birthdate", Birthdate);
        //ObjCommand.Parameters.AddWithValue("@Password", Password);
        //ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;


    }
    public static int CustomerMasterDelete(int CustomerId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CustomerId",CustomerId);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
}
