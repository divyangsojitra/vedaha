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
/// Summary description for CProductMaster
/// </summary>
public class CProductMaster
{
    public CProductMaster(int ProductId)
    {
        m_ProductId = ProductId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand ();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ProductMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ProductId", m_ProductId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet  dsProductMasterDetails=new DataSet();

       ObjDataAdapter.Fill(dsProductMasterDetails);
        if(dsProductMasterDetails.Tables[0].Rows.Count >0)
        {
            DataRow dr=dsProductMasterDetails.Tables[0].Rows[0];
            m_ProductId=Convert.ToInt32(dr["ProductId"]);
            m_SupplierId = Convert.ToInt32(dr["SupplierId"]);
            m_CategoryId=Convert.ToInt32(dr["CategoryId"]);
            m_SubCategoryId=Convert.ToInt32(dr["SubCategoryId"]);
            m_CosubcategoryId = Convert.ToInt32(dr["CosubcategoryId"]);
            m_ProductName=dr["ProductName"].ToString();
            m_Colour=dr["Colour"].ToString();
            m_ProductDesc = dr["ProductDesc"].ToString();
            m_FabricId =Convert.ToInt32(dr["FabricId"]);
            //m_Price=Convert.ToDouble(dr["Price"]);
            m_Qty=Convert.ToInt32(dr["Qty"]);
            m_Status=Convert.ToBoolean(dr["Status"]);
            m_Image = dr["Image"].ToString();
            m_IsExit=true;
         }
        

    }
    private int m_SupplierId = 0;
    public int SupplierId
    {
        get
        {
            return m_SupplierId;
        }
        set
        {
            m_SupplierId = value;
        }

    }
    private int m_ProductId = 0;
    public int ProductId 
    {
        get
        {
            return m_ProductId;
        }
        set
        {
            m_ProductId = value; 
        }

   }
    private int m_CategoryId = 0;
    public int CategoryId
    {
        get
        {
            return m_CategoryId; 
        }
        set
        {
            m_CategoryId=value;
        }

    }
    private int m_SubCategoryId = 0;
    public int SubCategoryId
    {
        get
        {
            return m_SubCategoryId;  
        }
        set
        {
            m_SubCategoryId = value;
        }
    }
    private int m_CosubcategoryId = 0;
    public int CosubcategoryId
    {
        get
        {
            return m_CosubcategoryId;
        }
        set
        {
            m_CosubcategoryId = value;
        }

    }
    private string m_Colour = "";
    public string Colour
    {
        get
        {
            return m_Colour;
        }
        set
        {
            m_Colour = value;
        }
    }
    private int m_Qty = 0;
    public int Qty
    {
        get
        {
            return m_Qty;
        }
        set
        {
            m_Qty = value;
        }
    }
    private string m_ProductName = "";
    public string ProductName
    {
        get
        {
            return m_ProductName;
        }
        set
        {
            m_ProductName = value;
        }
    }
    private string m_ProductDesc = "";
    public string ProductDesc
    {
        get
        {
            return m_ProductDesc;
        }
        set
        {
            m_ProductDesc = value;
        }
    }
    private double m_Price = 0;
    public double  Price
    {
        get
        {
            return m_Price;
        }
        set
        {
            m_Price = value;
        }
    }
    private bool m_Status=false;
    public bool Status
    {
        get
        {
            return m_Status;
        }
        set
        {
            m_Status = value;
        }
    }
    private string m_Image = "";
    public string Image
    {
        get
        {
            return m_Image;
        }
        set
        {
            m_Image = value;
        }
    }
    private int m_FabricId = 0;
    public int FabricId
    {
        get
        {
            return m_FabricId;
        }
        set
        {
            m_FabricId = value;
        }
    }
    
    private bool m_IsExit = false;
    public bool IsExit
    {
        get
        {
            return m_IsExit;
        }
        set
        {
            m_IsExit = value;
        }
    }
}
