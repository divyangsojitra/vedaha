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
/// Summary description for CStockMaster
/// </summary>
public class CStockMaster
{
	public CStockMaster(int StoctId)
	{

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText="StockMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@StockId",StoctId);

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsStockMasterDetails  =new DataSet();

        if (dsStockMasterDetails.Tables[0].Rows.Count>0)
        {
            DataRow dr=dsStockMasterDetails.Tables[0].Rows[0];
            m_StockId = Convert.ToInt32(dr["StockId"]);
            m_ProductId=Convert.ToInt32(dr["ProductId"]);
            m_SizeId=Convert.ToInt32(dr["SizeId"]);
            m_PRate = Convert.ToDouble(dr["PRate"]);
            m_SRate = Convert.ToDouble(dr["SRate"]);
        }

        
 
	}
    private int m_StockId = 0;
    public int StockId
    {
        get
        {
            return m_StockId;
        }
        set
        {
            m_StockId = value;
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
            m_ProductId=value;
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
