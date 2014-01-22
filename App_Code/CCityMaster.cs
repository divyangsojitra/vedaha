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
/// Summary description for CCityMaster
/// </summary>
public class CCityMaster
{
	public CCityMaster(int CityId)
	{
        m_CityId = CityId;
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CityMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CityId", m_CityId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCityMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsCityMasterDetails);
        if (dsCityMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsCityMasterDetails.Tables[0].Rows[0];
            m_CityId = Convert.ToInt32(dr["CityId"]);
            m_Cityname = dr["Cityname"].ToString();
            m_StateId = Convert.ToInt32(dr["StateId"]);
            m_IsExit = true;
        }
	}
    private int m_CityId = 0;
    public int CityId
    {
        get
        {
            return m_CityId;
        }
        set
        {
             m_CityId=value;
        }
    }
    private string m_Cityname = "";
    public string Cityname
    {
        get
        {
            return m_Cityname;
        }
        set
        {
            m_Cityname = value;
        }
       
    }
    private int m_StateId = 0;
    public int StateId
    {
        get
        {
            return m_StateId;
        }
        set
        {
            m_StateId = value;
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
