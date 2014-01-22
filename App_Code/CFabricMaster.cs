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
/// Summary description for CFabricMaster
/// </summary>
public class CFabricMaster
{
	public CFabricMaster(int FabricId)
	{
		//
		// TODO: Add constructor logic here
		//
        m_FabricId=FabricId;
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "FabricMasterDetails";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@FabricId",FabricId);
       // ObjCommand.Parameters.AddWithValue("@Fabricname",Fabricname);

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet DsFabricDetails =new DataSet();

        ObjDataAdapter.Fill(DsFabricDetails);
        if(DsFabricDetails.Tables[0].Rows.Count>0)
        {
            DataRow dr=DsFabricDetails.Tables[0].Rows[0];
            m_FabricId=Convert.ToInt32(dr["FabricId"]);
            m_Fabricname=dr["Fabricname"].ToString();
            m_Status = dr["Status"].ToString();
            m_IsExit = true;
        }

        

        
	}
    private int m_FabricId = 0;
    public int FabricId
    {
        get
        {
           return m_FabricId;
        }
        set
        {
            value=m_FabricId;
        }
    }
    private string m_Fabricname = "";
    public string Fabricname
    {
        get
        {
            return m_Fabricname;
        }
        set
        {
             m_Fabricname=value ;
        }
    }
    private string m_Status = "";
    public string Status
    {
        get
        {
            return m_Status;
        }
        set
        {
            m_Status = value;
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
 
