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
/// Summary description for CSubCategoryMasterServices
/// </summary>
public class CSubCategoryMasterServices
{
	public CSubCategoryMasterServices()
	{
		
	}
    public static DataSet SubCategoryMasterList()
    {
      SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
      ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="SubCategoryMasterList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsSubCategoryMasterList=new DataSet();

        ObjDataAdapter.Fill(dsSubCategoryMasterList);
        return(dsSubCategoryMasterList);
    }
    public static DataSet SubCategoryMasterListbyCategoryId(int CategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SubcategoryMasterListbyCategoryId";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSubcategoryMasterListbyCategoryId = new DataSet();

        ObjDataAdapter.Fill(dsSubcategoryMasterListbyCategoryId);

        return (dsSubcategoryMasterListbyCategoryId);
    }
    public static DataSet BindCategoryNameList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CategoryMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;


        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCategoryMasterList=new DataSet();
        
        ObjDataAdapter.Fill(dsCategoryMasterList);
        return(dsCategoryMasterList);


    }
    public static int SubCategoryInsert(int CategoryId, string SubCategoryName, string Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        
        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SubCategoryMasterInsert";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        ObjCommand.Parameters.AddWithValue("@SubCategoryName", SubCategoryName);
        
        ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int SubCategoryUpDate(int SubCategoryId,int CategoryId,string SubCategoryName,string Status)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SubCategoryMasterUpDate";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        
        ObjCommand.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        ObjCommand.Parameters.AddWithValue("@SubCategoryName", SubCategoryName);
        
        ObjCommand.Parameters.AddWithValue("@Status", Status);
        
        
        int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static int SubCategoryDelete(int SubCategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        
        SqlCommand ObjCommnand=new SqlCommand();
        ObjCommnand.Connection = ObjConnection;
        ObjCommnand.CommandText = "SubCategoryMasterDelete";
        ObjCommnand.CommandType = CommandType.StoredProcedure;

        ObjCommnand.Parameters.AddWithValue("@SubCategoryId",SubCategoryId);

        int intReturnValue = Convert.ToInt32(ObjCommnand.ExecuteScalar());
        return intReturnValue;

    }


}
