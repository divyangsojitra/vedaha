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
/// Summary description for CInvoice
/// </summary>
public class CInvoice
{
    public CInvoice(int InvoiceId)
	{
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "InvoiceMasterDetalis";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@InvoiceId", InvoiceId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet ds = new DataSet();

        ObjDataAdapter.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            m_InvoiceId = Convert.ToInt32(dr["InvoiceId"]);
            m_InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
            m_OrderId = Convert.ToInt32(dr["OrderId"]);
            m_FinaldeliveryDate = Convert.ToDateTime(dr["FinaldeliveryDate"]);
            m_DeliveryStatus = Convert.ToBoolean(dr["DeliveryStatus"]);
            m_IsExit = true;
        }
	}
    private int m_InvoiceId = 0;
    public int InvoiceId
    {
        get
        {
            return m_InvoiceId;
        }
        set
        {
            m_InvoiceId = value;
        }
    }
    private DateTime m_InvoiceDate = DateTime.MinValue;
    public DateTime InvoiceDate
    {
        get
        {
            return m_InvoiceDate; 
        }
        set
        {
            m_InvoiceDate = value;
        }
    }
    private int m_OrderId = 0;
    public int OrderId
    {
        get
        {
            return m_OrderId;
        }
        set
        {
            m_OrderId = value;
        }
    }
    private DateTime m_FinaldeliveryDate = DateTime.MinValue;
    public DateTime FinaldeliveryDate
    {
        get
        {
            return m_FinaldeliveryDate;
        }
        set
        {
            m_FinaldeliveryDate = value;
        }
    }
    private bool m_DeliveryStatus = false;
    public bool DeliveryStatus
    {
        get
        {
            return m_DeliveryStatus;
        }
        set
        {
            m_DeliveryStatus = value;
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
