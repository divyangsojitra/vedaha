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
/// Summary description for CCoSubCategoryMasterServices
/// </summary>
public class CCoSubCategoryMasterServices
{
	public CCoSubCategoryMasterServices()
	{
		
	}
    public static DataSet CosubcategoryList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;


        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCosubcategoryMasterList = new DataSet();

        ObjDataAdapter.Fill(dsCosubcategoryMasterList);

        return dsCosubcategoryMasterList;
    }
    public static DataSet CosubcategoryListbySubcategoryId(int SubCategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryMasterListbySubCategoryId";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCosubcategoryMasterListbySubCategoryId = new DataSet();

        ObjDataAdapter.Fill(dsCosubcategoryMasterListbySubCategoryId);

        return dsCosubcategoryMasterListbySubCategoryId;

    }
    public static int CosubcategoryInsert(int CategoryId, int SubcategoryId, string Cosubcategorydesc, string Status)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

       // ObjCommand.Parameters.AddWithValue("@CosubcategoryId", CosubcategoryId);
        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        ObjCommand.Parameters.AddWithValue("@SubcategoryId", SubcategoryId);
        ObjCommand.Parameters.AddWithValue("@Cosubcategorydesc", Cosubcategorydesc);
        ObjCommand.Parameters.AddWithValue("@Status", Status);
        

        int intReturnValues=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;   
    }
    public static int CosubcategoryUpdate(int CosubcategoryId , int CategoryId,int SubcategoryId, string Cosubcategorydesc,string Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryMasterUpdate";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CosubcategoryId", CosubcategoryId);
        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        ObjCommand.Parameters.AddWithValue("@SubcategoryId",SubcategoryId);
        ObjCommand.Parameters.AddWithValue("@Cosubcategorydesc", Cosubcategorydesc);
        ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    public static int CosubcategoryDelete(int CosubcategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryMasterDelete";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CosubcategoryId",CosubcategoryId);

        int intReturnValues = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValues;
    }
    

}
