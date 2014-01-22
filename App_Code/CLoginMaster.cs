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
/// Summary description for Login
/// </summary>
public class Login
{
	public Login(int LoinId)
	{
        m_LoginId = LoginId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="LoginDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("LoginId",m_LoginId);

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsLoginDetails=new DataSet();
        
        ObjDataAdapter.Fill( dsLoginDetails);

        if(dsLoginDetails.Tables[0].Rows.Count>0)
        {
            DataRow dr=dsLoginDetails.Tables[0].Rows[0];
            m_LoginId=Convert.ToInt32(dr["LoginId"]);
            m_EmailId=dr["EmailId"].ToString();
            m_Password=dr["Password"].ToString();
            m_IsExit=true;
        }
		
	}
    

    private int m_LoginId = 0;
    public int LoginId
    {
        get
        {
            return m_LoginId;
        }
        set
        {
            m_LoginId=value;
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
    private string m_Password = "";
    public string Password
    {
        get
        {
            return m_Password;
        }
        set
        {
            m_Password = value;
        }
    }
    private bool m_IsExit=false;
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
