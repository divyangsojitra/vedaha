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
/// Summary description for CComplianMaster
/// </summary>
public class CComplianMaster
{
	public CComplianMaster(int ComplianId)
	{
        m_ComplianId = ComplianId;
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ComplianMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsComplianMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsComplianMasterDetails);
        if (dsComplianMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsComplianMasterDetails.Tables[0].Rows[0];
            m_ComplianId = Convert.ToInt32(dr["ComplianId"]);
            m_Subject = dr["Subject"].ToString();
            m_EmailId = dr["EmailId"].ToString();
            m_Complian_Type = dr["Complian_Type"].ToString();
            m_Comment = dr["Comment"].ToString();
        }

		
	}
    private int m_ComplianId = 0;
    public int ComplianId
    {
        get
        {
            return m_ComplianId;
        }
        set
        {
            m_ComplianId = value;
        }

    }
    private string m_Subject = "";
    public string Subject
    {
        get
        {
            return m_Subject;
        }
        set
        {
            m_Subject = value;
        }
    }
    private string m_EmailId = "";
    public string EmailId
    {
        get
        {
            return m_EmailId;
        }
        set
        {
            m_EmailId = value;
        }
    }
    private string m_Complian_Type = "";
    public string Complian_Type
    {
        get
        {
            return m_Complian_Type;
        }
        set
        {
            m_Complian_Type = value;
        }
    }
    private string m_Comment = "";
    public string Comment
    {
        get
        {
            return m_Comment;
        }
        set
        {
            m_Comment = value;
        }
    }
}
