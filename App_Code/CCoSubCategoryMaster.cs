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
/// Summary description for CCoSubCategoryMaster
/// </summary>
public class CCoSubCategoryMaster
{
	public CCoSubCategoryMaster(int CosubcategoryId)
	{
        m_CosubcategoryId = CosubcategoryId;
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CosubcategoryId",m_CosubcategoryId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCosubcategoryMasterDetails=new DataSet();

        ObjDataAdapter.Fill(dsCosubcategoryMasterDetails);

        if(dsCosubcategoryMasterDetails.Tables[0].Rows.Count>0)
        {
            DataRow dr=dsCosubcategoryMasterDetails.Tables[0].Rows[0];
            m_CosubcategoryId = Convert.ToInt32(dr["CosubcategoryId"]);
            m_CategoryId =Convert.ToInt32( dr["CategoryId"]);
            m_SubcategoryId =Convert.ToInt32(dr["SubcategoryId"]);
           // m_Cosubategoryname = dr["Cosubcategoryname"].ToString();
            m_Cosubcategorydesc = dr["Cosubcategorydesc"].ToString();
            m_Status = dr["Status"].ToString();
            m_IsExit = true;
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
    private int m_SubcategoryId = 0;
    public int SubcategoryId
    {
        get
        {
            return m_SubcategoryId;
        }
        set
        {
            m_SubcategoryId = value;
        }
    }
    private string m_Cosubcategorydesc="";
    public string Cosubcategorydesc
    {
        get
        {
            return m_Cosubcategorydesc;
        }
        set
        {
            m_Cosubcategorydesc = value;
        }
    }
    private string m_Status = "";
    public string Status
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
