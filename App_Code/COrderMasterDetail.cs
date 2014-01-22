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
/// Summary description for COrderMasterDetail
/// </summary>
public class COrderMasterDetail
{
    public COrderMasterDetail(int OrderDetailId)
	{
        m_OrderDetailId = OrderDetailId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "OrderDetailDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderDetailId", m_OrderDetailId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsOrderDetailDetails = new DataSet();

        ObjDataAdapter.Fill(dsOrderDetailDetails);
        if (dsOrderDetailDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsOrderDetailDetails.Tables[0].Rows[0];
            m_OrderDetailId = Convert.ToInt32(dr["OrderDetailId"]);
            m_ProductId = Convert.ToInt32(dr["ProductId"]);
            
            m_Price = Convert.ToDouble(dr["Price"]);
            m_Qty = Convert.ToInt32(dr["Qty"]);
            m_LineTotalAmt = Convert.ToDouble(dr["LineTotalAmt"]);
            m_TotalAmt = Convert.ToDouble(dr["TotalAmt"]);
            m_IsExit = true;
        }
		
	}
    private int m_OrderDetailId = 0;
    public int OrderDetailId
    {
        get
        {
            return m_OrderDetailId;
        }
        set
        {
            m_OrderDetailId =value;
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
            m_OrderId =value;
        }
    }
    private int m_ProductId=0;
    public int ProductId
    {
        get
        {
            return m_ProductId;
        }
        set
        {
            m_ProductId =value;
        }
    }
    private int m_Qty = 0;
    public int Qty
    {
        get
        {
            return m_Qty;
        }
        set
        {
            m_Qty = value;
        }
    }
    private double m_Price=0;
    public double Price
    {
        get
        {
            return m_Price;
        }
        set
        {
            m_Price=value;
        }
    }
    private double m_LineTotalAmt=0;
    public double LineTotalAmt
    {
        get
        {
            return m_LineTotalAmt;
        }
        set
        {
            m_LineTotalAmt=value;
        }
    }
    private double m_TotalAmt=0;
    public double TotalAmt
    {
        get
        {
           return  m_TotalAmt;
        }
        set
        {
            m_TotalAmt=value;
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

