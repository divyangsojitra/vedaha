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
/// Summary description for CSupplierMaster
/// </summary>
public class CSupplierMaster
{
	public CSupplierMaster(int SupplierId)
	{
        m_SupplierId = SupplierId;
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "SupplierMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("SupplierId",m_SupplierId);
        
        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsSupplierMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsSupplierMasterDetails);
        if (dsSupplierMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsSupplierMasterDetails.Tables[0].Rows[0];
            m_SupplierId = Convert.ToInt32(dr["SupplierId"]);
            m_Suppliername = dr["Suppliername"].ToString();
            m_Address = dr["Address"].ToString();
            m_Area = dr["Area"].ToString();
            m_City = dr["City"].ToString();
            m_Pincode =Convert.ToInt32(dr["Pincode"]);
            m_Contactno = dr["Contactno"].ToString();
            m_EmailId = dr["EmailId"].ToString();
            m_IsExit = true;
        }

	}
    private int m_SupplierId=0;
    public int  SupplierId
    {
        get
        {
            return m_SupplierId;
        }
        set
        {
            m_SupplierId = value;
        }
        
    }
    private string m_Suppliername = "";
    public string Suppliername
    {
        get
        {
            return m_Suppliername;
        }
        set
        {
            m_Suppliername = value;
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
    private string m_Area = "";
    public string Area
    {
        get
        {
            return m_Area;
        }
        set
        {
            m_Area = value;
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
    private int m_Pincode = 0;
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
    private string m_Contactno = "";
    public string Contactno
    {
        get
        {
            return m_Contactno;
        }
        set
        {
            m_Contactno = value;
        }
    }
    private string m_EmailId = "";
    public string EmailId
    {
        get
        {
            return m_EmailId;
        }
        set
        {
            m_EmailId = value;
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

        
