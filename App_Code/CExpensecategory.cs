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
/// Summary description for CExpensecategory
/// </summary>
public class CExpensecategory
{
   public CExpensecategory(int ExpensecategoryId)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "ExpenseCategoryMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@ExpensecategoryId", ExpensecategoryId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsExpenseCategoryMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsExpenseCategoryMasterDetails);

        if (dsExpenseCategoryMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsExpenseCategoryMasterDetails.Tables[0].Rows[0];
            m_ExpensecategoryId = Convert.ToInt32(dr["ExpensecategoryId"]);
            m_Expensecategoryname = dr["Expensecategoryname"].ToString();
            m_IsExit = true;
        }

        
		
	}

    private int m_ExpensecategoryId = 0;
    public int ExpensecategoryId
    {
        get
        {
           return m_ExpensecategoryId;
        }
        set
        {
            m_ExpensecategoryId = value;
        }
    }
    private string m_Expensecategoryname = "";
    public string Expensecategoryname
    {
        get
        {
            return m_Expensecategoryname;
        }
        set
        {
            m_Expensecategoryname = value;
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
