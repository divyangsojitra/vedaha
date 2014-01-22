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
/// Summary description for CSizeMaster
/// </summary>
public class CSizeMaster
{
	public CSizeMaster(int SizeId)
	{
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SizeMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSizeMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsSizeMasterDetails);

        if (dsSizeMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsSizeMasterDetails.Tables[0].Rows[0];
            m_SizeId = Convert.ToInt32(dr["SizeId"]);
            m_Desc = dr["Desc"].ToString();
            m_IsExit = true;
        }
		
	}
    private int m_SizeId = 0;
    public int SizeId
    {
        get
        {
            return m_SizeId;
        }
        set
        {
            m_SizeId = value;
        }

    }
    private string m_Desc = "";
    public string Desc
    {
        get
        {
            return m_Desc;
        }
        set
        {
            m_Desc = value;
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
