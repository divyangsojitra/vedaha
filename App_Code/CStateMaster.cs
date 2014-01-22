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
/// Summary description for CSateMaster
/// </summary>
public class CStateMaster
{
	public CStateMaster(int StateId)
	{
        m_StateId = StateId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="StateMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StateId", StateId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsStateMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsStateMasterDetails);
        if (dsStateMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsStateMasterDetails.Tables[0].Rows[0];
            m_StateId =Convert.ToInt32(dr["StateId"]);
            m_Statename = dr["Statename"].ToString();
            m_IsExit = true;


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
    private string m_Statename = "";
    public string Statename
    {
        get
        {
            return m_Statename;
        }
        set
        {
            m_Statename = value;
        }
    }
    private bool m_IsExit = false;
    public bool IdExit
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
