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
/// Summary description for CFeedbackMaster
/// </summary>
public class CFeedbackMaster
{
	public CFeedbackMaster(int FeedbackId)
	{
        m_FeedbackId = FeedbackId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "FeedBackMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@Feedbackd",FeedbackId);
        
        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsFeedbackDetail=new DataSet();

        ObjDataAdapter.Fill(dsFeedbackDetail);

        if(dsFeedbackDetail.Tables[0].Rows.Count>0)
        {
            DataRow dr=dsFeedbackDetail.Tables[0].Rows[0];
            m_FeedbackId=Convert.ToInt32(dr["FeedbackId"]);
            //m_Date=Convert.ToDateTime(dr["Date"]);
           // m_ProductId=Convert.ToInt32(dr["ProductId"]);
           
           // m_Username=dr["Username"].ToString();
            m_EmailId=dr["EmailId"].ToString();
            m_FeedbackDesc = dr["Feedbackdesc"].ToString();
            m_Status = Convert.ToBoolean(dr["Status"]);
            m_IsExit = true;

            

        }
		
	}
    private int m_FeedbackId = 0;
    public int FeedbackId
    {
        get
        {
            return m_FeedbackId;
        }
        set
        {
            m_FeedbackId = value;
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
   
    private string m_FeedbackDesc = "";
    public string FeedbackDesc
    {
        get
        {
            return m_FeedbackDesc;
        }
        set
        {
            m_FeedbackDesc = value;
        }
    }
    private bool m_Status = false;
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
 