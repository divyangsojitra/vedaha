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
/// Summary description for CPurchseMaster
/// </summary>
public class CPurchseMaster
{
	public CPurchseMaster(int PurchseId)
	{
        m_PurchseId = PurchseId;
        SqlConnection ObjConnection =new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "PurchseMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@PurchseId", PurchseId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet ds = new DataSet();

        ObjDataAdapter.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            DataRow dr = ds.Tables[0].Rows[0];
            m_PurchseId = Convert.ToInt32(dr["PurchseId"]);
            m_ProductId = Convert.ToInt32(dr["ProductId"]);
            m_SizeId = Convert.ToInt32(dr["SizeId"]);
            m_PQty = Convert.ToInt32(dr["PQty"]);
            m_PRate = Convert.ToDouble(dr["PRate"]);
            m_Amount = Convert.ToDecimal(dr["Amount"]);
            m_Total = Convert.ToDecimal(dr["Total"]);
            m_Addless = Convert.ToDecimal(dr["Addless"]);
            m_Netamount = Convert.ToDecimal(dr["Netamount"]);
            m_PurchaseBillno = Convert.ToInt32(dr["PurchaseBillno"]);
            m_PurchaseBillDate = Convert.ToDateTime(dr["PurchaseBillDate"]);
            m_ReturnStatus = Convert.ToInt32(dr["ReturnStatus"]);
            
            //m_SQty = Convert.ToInt32(dr["SQty"]);
            //m_SRate = Convert.ToDouble(dr["SRate"]);
            
            
        }
	}
    private int m_PurchseId = 0;
    public int PurchseId
    {
        get
        {
            return m_PurchseId;
        }
        set
        {
            m_PurchseId=value;
        }
    }
    private int m_ProductId = 0;
    public int ProductId
    {
        get
        {
            return m_ProductId;
        }
        set
        {
            m_ProductId = value;
        }
    }
    private int m_SizeId = 0;
    public int SizeId
    {
        get
        {
            return m_SizeId;
        }
        set
        {
            m_SizeId = value;
        }
    }
    private int m_PQty = 0;
    public int PQty
    {
        get
        {
            return m_PQty;
        }
        set
        {
            m_PQty = value;
        }

    }
    private double m_PRate = 0;
    public double PRate
    {
        get
        {
            return m_PRate;
        }
        set
        {
            m_PRate = value;
        }
    }
    private int m_SQty = 0;
    public int SQty
    {
        get
        {
            return m_SQty;
        }
        set
        {
            m_SQty = value;
        }
    }
    private double m_SRate = 0;
    public double SRate
    {
        get
        {
            return m_SRate;
        }
        set
        {
            m_SRate = value;
        }
    }
    private int m_PurchaseBillno = 0;
    public int PurchaseBillno
    {
        get
        {
            return m_PurchaseBillno;
        }
        set
        {
            m_PurchaseBillno = value;
        }
    }
    private DateTime m_PurchaseBillDate = DateTime.MinValue;
    public DateTime PurchaseBillDate
    {
        get
        {
            return m_PurchaseBillDate;
        }
        set
        {
            m_PurchaseBillDate = value;
        }
    }
    private int m_ReturnStatus =0;
    public int ReturnStatus
    {
        get
        {
            return m_ReturnStatus;
        }
        set
        {
            m_ReturnStatus = value;
        }
    }
    private decimal m_Amount = 0;
    public decimal Amount
    {
        get
        {
            return m_Amount;
        }
        set
        {
            m_Amount = value;
        }
    }

    private decimal m_Total = 0;
    public decimal Total
    {
        get
        {
            return m_Total;
        }
        set
        {
            m_Total = value;
        }
    }
    private decimal m_Addless=0;
    public decimal Addless
    {
        get
        {
            return m_Addless;

        }
        set
        {
            m_Addless = value;
        }
        
    }
    private decimal m_Netamount = 0;
    public decimal Netamount
    {
        get
        {
            return m_Netamount;
        }
        set
        {
            m_Netamount = value;
        }
    }

}
