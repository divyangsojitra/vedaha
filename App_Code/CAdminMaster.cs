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

/// <summary>
/// Summary description for CAdminMaster
/// </summary>
public class CAdminMaster
{
	public CAdminMaster()
	{
		
	}
    private int m_AdminId = 0;
    public int AdminId
    {
        get
        {
            return m_AdminId;
        }
        set
        {
            m_AdminId = value;
        }
    }
    private string m_Adminname = "";
    public string Adminname
    {
        get
        {
            return m_Adminname;
        }
        set
        {
            m_Adminname = value;
        }
    }
    private string m_Username = "";
    public string Username
    {
        get
        {
            return m_Username;
        }
        set
        {
            m_Username = value;
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
