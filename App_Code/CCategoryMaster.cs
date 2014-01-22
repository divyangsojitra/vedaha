using System;
using System.Data;
using System.Collections;
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
/// Summary description for CCategoryMaster
/// </summary>
/// 

public class CCategoryMaster
{
    public CCategoryMaster(int CategoryId)
	{
        m_CategoryId= CategoryId;

      SqlConnection ObjConnection=new SqlConnection(Common.C_ConnectionString);
      ObjConnection.Open();

       SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="CategoryMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;
        
        ObjCommand.Parameters.AddWithValue("@CategoryId",m_CategoryId);

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsCategoryMasterDetails=new DataSet();

        ObjDataAdapter.Fill(dsCategoryMasterDetails);

        if(dsCategoryMasterDetails.Tables[0].Rows.Count>0)
        {
            DataRow  dr=dsCategoryMasterDetails.Tables[0].Rows[0];
            m_CategoryId=Convert.ToInt32(dr["CategoryId"]);
            m_CategoryCode=Convert.ToInt32(dr["CategoryCode"]);
            m_CategoryName=dr["CategoryName"].ToString();
            m_Status=dr["Status"].ToString();
            m_IsExit = true;
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
            m_CategoryId = value;
        }
    }
   private int m_CategoryCode = 0;
    public int CategoryCode
    {
        get
        {
            return m_CategoryCode; 
        }
        set
        {
            m_CategoryCode=value;
        }
    }
    private string m_CategoryName="";
    public string CategoryName
    {
        get
        {
            return m_CategoryName ; 
        }
        set
        {
            m_CategoryName = value;
        }
    }
    private string  m_Status="";
    public string Status
        {
            get
            {
                return m_Status;
            }
            set 
            {
                m_Status=value;
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
            m_IsExit =value;
        }
    }
    
        
}
