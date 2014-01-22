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
/// Summary description for CSubCategoryMaster
/// </summary>
public class CSubCategoryMaster
{
    public CSubCategoryMaster(int SubCategoryId)
    {
        m_SubCategoryId=SubCategoryId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="SubCategoryMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SubCategoryId",m_SubCategoryId); 

        SqlDataAdapter ObjDataAdapter=new  SqlDataAdapter(ObjCommand);
        DataSet  dsSubCategoryMasterDetails=new DataSet();

        ObjDataAdapter.Fill(dsSubCategoryMasterDetails);

        if (dsSubCategoryMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsSubCategoryMasterDetails.Tables[0].Rows[0];
            m_SubCategoryId = Convert.ToInt32(dr["SubCategoryId"]);
            m_CategoryId=Convert.ToInt32(dr["CategoryId"]);
            m_SubCategoryName =dr["SubCategoryName"].ToString();
            
            m_Status =dr["Status"].ToString();
            m_IsExit = true;
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
            m_SubCategoryId=value;
        }
    }
    private string m_SubCategoryName = "";
    public string SubCategoryName
    {
        get
        {
            return m_SubCategoryName;
        }
        set
        {
            m_SubCategoryName = value;
        }
    }
    private int  m_CategoryId =0;
    public int  CategoryId
    {
        get
        {
            return m_CategoryId;
        }
        set
        {
            m_CategoryId = value;
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
