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
/// Summary description for COrderMaster
/// </summary>
public class COrderMaster
{
	public COrderMaster(int OrderId)
	{
        m_OrderId = OrderId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "OrderMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@OrderId", OrderId);

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter (ObjCommand);
        DataSet dsOrderMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsOrderMasterDetails);
        if (dsOrderMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsOrderMasterDetails.Tables[0].Rows[0];
            m_OrderId=Convert.ToInt32(dr["OrderId"]);
            m_CustomerId=Convert.ToInt32(dr["CustomerId"]);
            m_Firstname = dr["Firstname"].ToString();
            m_Address = dr["Address"].ToString();
            m_City = dr["City"].ToString();
            m_Pincode = Convert.ToInt32(dr["Pincode"]);
            m_Phoneno = dr["Phoneno"].ToString();
            m_State = dr["State"].ToString();
            m_TotalAmt = Convert.ToDouble(dr["TotalAmt"]);
            
            m_PaymentOption=dr["PaymentOption"].ToString();
            m_PaymentStatus=dr["PaymentStatus"].ToString();
            m_IsExit = true;

            
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
    private DateTime m_OrderDate = DateTime.MinValue;
    public DateTime OrderDate
    {
        get
        {
            return m_OrderDate;
        }
        set
        {
            m_OrderDate = value;
        }

    }
    private int m_CustomerId = 0;
    public int CustomerId
    {
        get
        {
            return m_CustomerId; 
        }
        set
        {
            m_CustomerId=value;
           
        }
    }
    private string m_Firstname = "";
    public string Firstname
    {
        get
        {
            return m_Firstname;
        }
        set
        {
            m_Firstname = value;
        }
    }
    private string m_State = "";
    public string State
    {
        get
        {
            return m_State;
        }
        set
        {
            m_State = value;
        }
    }
    private string m_City = "";
    public string City
    {
        get
        {
            return m_City;
        }
        set
        {
            m_City = value;
        }
    }
    private int m_Pincode=0;
    public int Pincode
    {
        get
        {
            return m_Pincode;
        }
        set
        {
            m_Pincode = value;
        }
    }
    private string m_Phoneno = "";
    public string Phoneno
    {
        get
        {
            return m_Phoneno;
        }
        set
        {
            m_Phoneno = value;
        }
    }
    private string m_Address = "";
    public string Address
    {
        get
        {
            return m_Address;
        }
        set
        {
            m_Address = value;
        }
    }
    private double m_TotalAmt=0;
    public double TotalAmt
    {
        get
        {
            return m_TotalAmt;
        }
        set
        {
            m_TotalAmt=value;
        }
    }
    private string m_PaymentOption = "";
    public string PaymentOption
    {
        get
        {
            return m_PaymentOption;
        }
        set
        {
            m_PaymentOption = value;
        }
    
    }
    private string m_PaymentStatus = "";
    public string PaymentStatus
    {
        get
        {
            return m_PaymentStatus;
        }
        set
        {
            m_PaymentStatus = value;
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