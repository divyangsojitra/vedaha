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
/// Summary description for CProductMasterServices
/// </summary>
public class CProductMasterServices
{
	public CProductMasterServices()
	{
		
	}
    public static DataSet BindCategoryNameList()
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="CategoryMasterList";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdatpter=new SqlDataAdapter(ObjCommand);
        DataSet dsCategoryMasterList = new DataSet();
        
        ObjDataAdatpter.Fill(dsCategoryMasterList);
        return (dsCategoryMasterList);
    }
    public static DataSet BindSubCategoryNameList()
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SubCategoryMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSubCategoryMasterList = new DataSet();

        ObjDataAdapter.Fill(dsSubCategoryMasterList);
        return (dsSubCategoryMasterList); 
    }
    public  DataSet ProductMasterList()
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ProductMasterMasterListGV";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsProductMasterMasterListGV = new DataSet();

        ObjDataAdapter.Fill(dsProductMasterMasterListGV);
        return (dsProductMasterMasterListGV);
    }

    public static DataSet ProductMasterListwithcosubcategory(int CosubcategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ProductIdwithCategoryList";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CosubcategoryId", CosubcategoryId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsProductIdwithCategoryList = new DataSet();

        ObjDataAdapter.Fill(dsProductIdwithCategoryList);
        return (dsProductIdwithCategoryList);
    }
    public static DataSet ProductMasteCartList(int CategoryId,int SubCategoryId,int CosubcategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ProductMasterCartList";
        ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
        ObjCommand.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
        ObjCommand.Parameters.AddWithValue("@CosubcategoryId", CosubcategoryId);
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsProductMasterCartList = new DataSet();

        ObjDataAdapter.Fill(dsProductMasterCartList);
        return (dsProductMasterCartList);

    }
    
    public static DataSet ProductsubcategorycartList(int sid)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SubCategoryImage";
        ObjCommand.Parameters.AddWithValue("@CategoryId",sid);
        ObjCommand.CommandType = CommandType.StoredProcedure;
        

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSubCategoryImage = new DataSet();

        ObjDataAdapter.Fill(dsSubCategoryImage);
        return (dsSubCategoryImage);

    }
    public static int ProductMasterInsert(int SupplierId,int CategoryId, int SubCategoryId, int CosubcategoryId, string ProductName,int FabricId, string Colour, int Qty, string ProductDesc, string Image, bool Status)
    {
       SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
       ObjConnection.Open();
        
       SqlCommand ObjCommand = new SqlCommand();
       ObjCommand.Connection = ObjConnection;
       ObjCommand.CommandText = "ProductMasterInsert";
       ObjCommand.CommandType = CommandType.StoredProcedure;

       ObjCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
       ObjCommand.Parameters.AddWithValue("@CategoryId", CategoryId);
       ObjCommand.Parameters.AddWithValue("@SubCategoryId", SubCategoryId);
       ObjCommand.Parameters.AddWithValue("@CosubcategoryId", CosubcategoryId);
       ObjCommand.Parameters.AddWithValue("@ProductName", ProductName);
       ObjCommand.Parameters.AddWithValue("FabricId", FabricId);
       ObjCommand.Parameters.AddWithValue("@Colour", Colour);
       ObjCommand.Parameters.AddWithValue("@Qty", Qty);
       ObjCommand.Parameters.AddWithValue("@ProductDesc", ProductDesc);
       //ObjCommand.Parameters.AddWithValue("@Price", Price);
       ObjCommand.Parameters.AddWithValue("@Image",Image);
        ObjCommand.Parameters.AddWithValue("@Status",  Status);
       
       int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
       return intReturnValue;
       //int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
       //return intReturnValue;   
    }
    public static int ProductMasterUpdate(int ProductId,int SupplierId,
        int CategoryId, 
        int SubCategoryId,
        int CosubcategoryId,
        int FabricId,
          string Colour, 
        string Productname,
      
        
        string ProductDesc, 
       
        int Qty,
        string Image,
        bool Status )
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="ProductMasterUpDate";
        ObjCommand.CommandType=CommandType.StoredProcedure;
        ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
        ObjCommand.Parameters.AddWithValue("@SupplierId", SupplierId);
        ObjCommand.Parameters.AddWithValue("@CategoryId",CategoryId);
        ObjCommand.Parameters.AddWithValue("@SubCategoryId",SubCategoryId);
        ObjCommand.Parameters.AddWithValue("@CosubcategoryId", CosubcategoryId);
        ObjCommand.Parameters.AddWithValue("@FabricId", FabricId);
        ObjCommand.Parameters.AddWithValue("@Colour", Colour);
        ObjCommand.Parameters.AddWithValue("@ProductName",Productname);
        ObjCommand.Parameters.AddWithValue("@ProductDesc",ProductDesc);
        //ObjCommand.Parameters.AddWithValue("@Price",Price);
        ObjCommand.Parameters.AddWithValue("@Qty", Qty);
         ObjCommand.Parameters.AddWithValue("@Image",Image);
        ObjCommand.Parameters.AddWithValue("@Status", Status);

        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    
    }
    public static int ProductMasterDelete(int ProductId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="ProductMasterDelete";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId",ProductId);
        int intReturnValue=Convert.ToInt32(ObjCommand.ExecuteScalar());
        return intReturnValue;
    }
    public static DataSet DisplayData(int ProductId)
    {
        SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "ProductMasterDetailswithStock";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId",ProductId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);

        DataSet ds=new DataSet();

        ObjDataAdapter.Fill(ds);
        return ds;
    }

    public static DataSet DisplayProductMasterColuman()

    {
        SqlConnection objConnection = new SqlConnection(Common.C_ConnectionString);
        objConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = objConnection;
        ObjCommand.CommandText = "ProductMastercolumandisplay";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsProductMastercolumandisplay = new DataSet();

        ObjDataAdapter.Fill(dsProductMastercolumandisplay);
        return dsProductMastercolumandisplay;
    }
    public static DataSet BindReport(string str1,string str2,string str3,string str4)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "PROC_ProductMasterList";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        ObjCommand.Parameters.AddWithValue("@P_IN_CATEGORY_lIST", str1);
        ObjCommand.Parameters.AddWithValue("@P_IN_SUBCATEGORY_LIST",str2);
        ObjCommand.Parameters.AddWithValue("@P_IN_COSUBCATEGORY_LIST",str3);
        ObjCommand.Parameters.AddWithValue("@P_IN_PRODUCTNAME",str4);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsPROC_ProductMasterList = new DataSet();

        ObjDataAdapter.Fill(dsPROC_ProductMasterList);
        return dsPROC_ProductMasterList;
    }
    public static DataSet BindProductsearchPrice(string SizeId, string Colourname, string StartSRate, string EndSRate,string CategoryId,
                                                 string SubcategoryId,string CosubcategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ProductsearchPrice";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsProductsearchPrice = new DataSet();

        ObjDataAdapter.Fill(dsProductsearchPrice);
        return dsProductsearchPrice;
    }
}
