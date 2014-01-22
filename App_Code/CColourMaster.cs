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
/// Summary description for CColourMaster
/// </summary>
public class CColourMaster
{
	public CColourMaster(int Color)
	{
		//
		// TODO: Add constructor logic here
		//
        m_ColorId=ColorId;
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ColorMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ColorId",m_ColorId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsColourMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsColourMasterDetails);


        if (dsColourMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr =dsColourMasterDetails.Tables[0].Rows[0];
            m_ColorId=Convert.ToInt32(dr["Color"]);
            m_Colorname=dr["Colorname"].ToString();
            m_IsExit=true;
            
            
        }
	}
    private int m_ColorId = 0;
    public int ColorId
    {
        get
        {
            return m_ColorId;
        }
        set
        {
            m_ColorId = value;
        }
    }
    private string m_Colorname = "";
    public string Colorname
    {
        get
        {
            return m_Colorname;
        }
        set
        {
            m_Colorname = value;
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
