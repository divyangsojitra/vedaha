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
/// Summary description for CExpenseMaster
/// </summary>
public class CExpenseMaster
{
	public CExpenseMaster(int ExpenseId)
	{
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ExpenseId", ExpenseId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsExpenseMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsExpenseMasterDetails);

        if (dsExpenseMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsExpenseMasterDetails.Tables[0].Rows[0];
            m_ExpenseId = Convert.ToInt32(dr["ExpenseId"]);
            m_VNo = Convert.ToInt32(dr["VNo"]);
            m_VDate = Convert.ToDateTime(dr["VDate"]);
            m_ExpensecategoryId = Convert.ToInt32(dr["ExpensecategoryId"]);
            m_Amount = Convert.ToDouble(dr["Amount"]);
            m_ExpenseDesc = dr["ExpenseDesc"].ToString();
            m_Type = dr["Type"].ToString();
        }

       
	}
    private int m_ExpenseId =0;
    public int ExpenseId
    {
        get
        {
            return m_ExpenseId;
        }
        set
        {
            m_ExpenseId=value;
        }
    }
    private int m_VNo = 0;
    public int VNo
    {
        get
        {
            return m_VNo;
        }
        set
        {
            m_VNo=value;
        }

    }
    private DateTime m_VDate = DateTime.MinValue;
    public DateTime VDate
    {
        get
        {
            return m_VDate;
        }
        set
        {
            m_VDate=value;
        }
    }
    private int m_ExpensecategoryId =0;
    public int ExpensecategoryId
    {
        get
        {
            return m_ExpensecategoryId;
        }
        set
        {
            m_ExpensecategoryId=value;
        }
    }
    private double m_Amount = 0;
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
    private string m_ExpenseDesc = "";
    public string ExpenseDesc
    {
        get
        {
            return m_ExpenseDesc;
        }
        set
        {
            m_ExpenseDesc=value;
        }
    }
    private string m_Type = "";
    public string Type
    {
        get
        {
            return m_Type;
        }
        set
        {
            m_Type = value;
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
