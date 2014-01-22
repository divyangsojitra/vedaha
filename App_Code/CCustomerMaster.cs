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
/// Summary description for CCustomerMaster
/// </summary>
public class CCustomerMaster
{
	public CCustomerMaster(int CustomerId)
	{
        m_CustomerId = CustomerId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerMasterDetails";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCustomerMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsCustomerMasterDetails);
        if (dsCustomerMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsCustomerMasterDetails.Tables[0].Rows[0];
            m_CustomerId = Convert.ToInt32(dr["CustomerId"]);
            m_Firstname = dr["Firstname"].ToString();
            m_Lastname = dr["Lastname"].ToString();
            m_Address = dr["Address"].ToString();
            m_Pincode = Convert.ToInt32(dr["Pincode"]);
            m_Phoneno = dr["Phoneno"].ToString();
            m_CityId = Convert.ToInt32(dr["CityId"]);
            m_StateId =Convert.ToInt32(dr["State"]);
           
            m_EmailId = dr["EmailId"].ToString();
            m_Password = dr["password"].ToString();
            m_Status = Convert.ToBoolean(dr["Status"]);
            m_Birthdate = Convert.ToDateTime(dr["Birthdate"]);
            m_Type = dr["Type"].ToString();
            m_IsExit = true;
        }
        else
        {
            m_IsExit = false;
        }
        
		
	}
    public CCustomerMaster(string EmailId)
    {
        m_EmailId = EmailId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerMasterDetailsbyEmailId";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@EmailId", m_EmailId);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCustomerMasterDetailsbyEmailId = new DataSet();

        ObjDataAdapter.Fill(dsCustomerMasterDetailsbyEmailId);
        if (dsCustomerMasterDetailsbyEmailId.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsCustomerMasterDetailsbyEmailId.Tables[0].Rows[0];
            m_CustomerId = Convert.ToInt32(dr["CustomerId"]);
            m_Firstname = dr["Firstname"].ToString();
            m_Lastname = dr["Lastname"].ToString();
            m_Address = dr["Address"].ToString();
            m_Pincode = Convert.ToInt32(dr["Pincode"]);
            m_Phoneno = dr["Phoneno"].ToString();
            m_CityId = Convert.ToInt32(dr["CityId"]);
            m_StateId =Convert.ToInt32( dr["StateId"]);

            //m_EmailId = dr["EmailId"].ToString();
            m_Password = dr["password"].ToString();
            m_Status = Convert.ToBoolean(dr["Status"]);
            m_Type = dr["Type"].ToString();
            m_IsExit = true;
        }
        else
        {
            m_IsExit = false;
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
            m_CustomerId = value;
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
    private string m_Lastname = "";
    public string Lastname
    {
        get
        {
            return m_Lastname;
        }
        set
        {
            m_Lastname=value;
        }
    }
    private string m_Address="";
    public string Address
    {
        get
        {
            return m_Address;
        }
        set
        {
            m_Address=value;
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
            m_Pincode=value;
        }
    }
    private int m_CityId=0;
    public int CityId
    {
        get
        {
            return m_CityId;
        }
        set
        {
            m_CityId=value;
        }
    }
    private int m_StateId=0;
    public int StateId
    {
        get
        {
            return m_StateId;
        }
        set
        {
            m_StateId=value;
        }
    }
    private string m_Phoneno="";
    public string Phoneno
    {
        get
        {
            return m_Phoneno;
        }
        set
        {
            m_Phoneno=value;
        }
    }
    private string m_EmailId="";
    public string EmailId
    {
        get
        {
            return m_EmailId;
        }
        set
        {
            m_EmailId=value;
        }
    }
    private string m_Password="";
    public string Password
    {
        get
        {
            return m_Password;
        }
        set
        {
            m_Password=value;
        }
    }
    private bool m_Status=false;
    public bool Status
    {
        get
        {
            return m_Status;
        }
        set
        {
            m_Status=value;
        }
    }
    private DateTime m_Date = DateTime.MinValue;
    public DateTime Date
    {
        get
        {
            return m_Date;
        }
        set
        {
            m_Date = value;
        }
    }
    private DateTime m_Birthdate = DateTime.MinValue;
    public DateTime Birthdate
    {
        get
        {
            return m_Birthdate;
        }
        set
        {
            m_Birthdate = value;
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

}
