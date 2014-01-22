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
/// Summary description for CCreditcardServices
/// </summary>
public class CCreditcardServices
{
	public CCreditcardServices()
	{
	    	
	}
    public static DataSet CCreditcardList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "CreditcardMasterList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        SqlDataAdapter ObjdataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsCreditcardMasterList=new DataSet();

       ObjdataAdapter.Fill(dsCreditcardMasterList);

        return(dsCreditcardMasterList ); 

    }

   



    public static int CCreditcardInsert(string CardHolderName,int OrderId,int Creditcardno,string Card,int cvc2no,DateTime expirydate,double Amount)
    {
        SqlConnection ObjConnection=new SqlConnection (Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CreditcardMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CardHolderName", CardHolderName);
        ObjCommand.Parameters.AddWithValue("@OrderId",OrderId);
        ObjCommand.Parameters.AddWithValue("@Creditcardno",Creditcardno);
        ObjCommand.Parameters.AddWithValue("@Card",Card);
        ObjCommand.Parameters.AddWithValue("@expirydate",expirydate);
        ObjCommand.Parameters.AddWithValue("@cvc2no",cvc2no);
        ObjCommand.Parameters.AddWithValue("@Amount", Amount);

        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static DataSet CreditcardMasterDetailsbyOrderId(int OrderId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CreditcardMasterDetailsbyOrderId";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCreditcardMasterDetailsbyOrderId = new DataSet();

        ObjDataAdapter.Fill(dsCreditcardMasterDetailsbyOrderId);

        return (dsCreditcardMasterDetailsbyOrderId);
        //int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
       // return intReturnValue;


        //int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        //return intReturnValue;

    }
    //public static int CCreditcardUpdate(string CardHolderName, int OderId, int Creditcardno, int Card, DateTime expirydate, int cvc2no, double Amount)
    //{
    //    SqlConnection ObConnection = new SqlConnection();
    //    ObConnection.Open();

    //    SqlCommand ObjCommand = new SqlCommand();
    //    ObjCommand.Connection = ObConnection;
    //    ObjCommand.CommandText = "CreditcardMasterUpdate";
    //    ObjCommand.CommandType = CommandType.StoredProcedure;


    //}
}
