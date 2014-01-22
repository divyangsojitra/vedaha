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
/// Summary description for CBillMaster
/// </summary>
public class CBillMaster
{
	public CBillMaster()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int m_BillId = 0;
    public int BillId
    {
        get
        {
            return m_BillId;
        }
        set
        {
            m_BillId = value;
        }
    }
    private DateTime m_BillDate = DateTime.MinValue;
    public DateTime BillDate
    {
        get
        {
            return m_BillDate;
        }
        set
        {
            m_BillDate = value;
        }
    }
    private int m_OderId = 0;
    public int OderId
    {
        get
        {
            return m_OderId;
        }
        set
        {
            m_OderId = value;
        }
    }
    private string m_Paymenttype = "";
    public string Paymenttype
    {
        get
        {
            return m_Paymenttype; 
        }
        set
        {
            m_Paymenttype = value;
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
