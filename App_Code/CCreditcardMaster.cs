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
/// Summary description for CCreditcardMaster
/// </summary>
public class CCreditcardMaster
{
    public CCreditcardMaster(int TransactionId)
	{
        m_TransactionId = TransactionId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CreditcardMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@TransactionId", TransactionId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCreditcardMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsCreditcardMasterDetails);
        if (dsCreditcardMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsCreditcardMasterDetails.Tables[0].Rows[0];
            
            m_TransactionId = Convert.ToInt32(dr["TransactionId"]);
           // m_TransactionId = "24";//dr["TransactionId");
            m_CardholderName = dr["CardHolderName"].ToString();
            m_OrderId=Convert.ToInt32(dr["OrderId"]);
            m_Creditcardno=Convert.ToInt32(dr["Creditcardno"]);
            m_Card = dr["Card"].ToString();
            m_expirydate=Convert.ToDateTime(dr["expirydate"]);
            m_cvc2no=Convert.ToInt32(dr["cvc2no"]);
            m_Amount=Convert.ToDouble(dr["Amount"]);
            m_IsExit = true;
            

		}
	}
    private int m_TransactionId = 0;
    public int TransactionId
    {
        get
        {
            return m_TransactionId;
        }
        set
        {
            m_TransactionId = value;
        }
    }
   
    private string m_CardholderName = "";
    public string Cardholdarname
    {
        get
        {
            return m_CardholderName;
            
        }
        set
        {
            m_CardholderName=value;
        }

    }
    private int m_OrderId=0;
    public int OrderId
    {
        get
        {
            return m_OrderId;
        }
        set
        {
            m_OrderId=value;
        }
    }
   private int m_Creditcardno=0;     
   public int Creditcardno
   {
       get
       {
           return m_Creditcardno;
       }
       set
       {
           m_Creditcardno=value;
       }
   }
   private string m_Card= "";
   public string Card
     {
         get
         {
             return m_Card;
         }
         set
         {
             m_Card=value;
         }
     }
    private DateTime m_expirydate=DateTime.MinValue;
    public DateTime expirydate
    {
        get
        {
            return m_expirydate;
        }
        set
        {
            m_expirydate=value;
        }
    }
    private  int m_cvc2no=0;
    public int cvc2no
    {
        get
        {
            return m_cvc2no;
        }
        set
        {
            m_cvc2no=value;
        }

    }
   private double m_Amount=0;
    public double Amount
    {
        get
        {
            return m_Amount;
        }
        set
        {
            m_Amount=value;
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
            m_IsExit=value;
        }

    }
}

