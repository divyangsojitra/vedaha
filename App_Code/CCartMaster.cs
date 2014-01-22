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
/// Summary description for CCartMaster
/// </summary>
public class CCartMaster
{
    public CCartMaster(int CartId)
	{
        m_CartId = CartId;

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand=new SqlCommand();
        ObjCommand.Connection=ObjConnection;
        ObjCommand.CommandText = "CustomerMasterDetails";
        //ObjCommand.CommandText = "CartMasrterDetailsbyCustomerId1";
        ObjCommand.CommandType=CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CartId",CartId);
        //ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

        SqlDataAdapter ObjDataAdapter=new SqlDataAdapter(ObjCommand);
        DataSet dsCartDetails=new DataSet();

        ObjDataAdapter.Fill(dsCartDetails);
         
        if(dsCartDetails.Tables[0].Rows.Count>0)
        {
            DataRow dr=dsCartDetails.Tables[0].Rows[0];
            m_Date=Convert.ToDateTime(dr["Date"]);
            m_ProductId=Convert.ToInt32(dr["ProductId"]);
            m_price=Convert.ToDouble(dr["Price"]);
            m_Qty=Convert.ToInt32(dr["Qty"]);
            m_Total=Convert.ToDouble(dr["Total"]);
            m_SizeId = Convert.ToInt32(dr["SizeId"]);
            m_Image = dr["Image"].ToString();
           // m_TotalAmt=Convert.ToDouble(dr["TotalAmt"]);
            
        }
		
	}
    //public CCartMaster(int CustomerId)
    //{
    //    m_CustomerId = CustomerId;

    //    SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
    //    ObjConnection.Open();

    //    SqlCommand ObjCommand = new SqlCommand();
    //    ObjCommand.Connection = ObjConnection;
    //    ObjCommand.CommandText = "CartMasrterDetailsbyCustomerId";
    //    ObjCommand.CommandType = CommandType.StoredProcedure;

    //    ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

    //    SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
    //    DataSet dsCartMasrterDetailsbyCustomerId = new DataSet();

    //    ObjDataAdapter.Fill(CartMasrterDetailsbyCustomerId);
    //    if (dsCartMasrterDetailsbyCustomerId.Tables[0].Rows.Count > 0)
    //    {

    //        DataRow dr = dsCartMasrterDetailsbyCustomerId.Tables[0].Rows[0];

    //        m_CartId = Convert.ToInt32(dr["CartId"]);
    //        m_Date = Convert.ToDateTime(dr["Date"]);
    //        m_ProductId = Convert.ToInt32(dr["ProductId"]);
    //        m_price = Convert.ToDouble(dr["Price"]);
    //        m_Qty = Convert.ToInt32(dr["Qty"]);
    //        m_Total = Convert.ToDouble(dr["Total"]);
    //        m_IsExit = true;

    //    }


    //}
    private int m_CartId = 0;
    public int CartId
    {
        get
        {
            return CartId;
        }
        set
        {
            CartId = value;
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
    private double m_price = 0;
    public double price
    {
        get
        {
            return m_price;
        }
        set
        {
            m_price = value;
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
    private DateTime m_Date = DateTime.MinValue;
    public DateTime Date
    {
        get
        {
            return m_Date;
        }
        set
        {
            m_Date=value;
        }
    }
    private double m_Total = 0;
    public double Total
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
    private string m_Image = "";
    public string Image
    {
        get
        {
            return m_Image;
        }
        set
        {
            m_Image = value;
        }

    }
    //private double m_TotalAmt=0;
    //public double TotalAmt
    //{
    //    get
    //    {
    //        return m_TotalAmt;
    //    }
    //    set
    //    {
    //        m_TotalAmt = value;
    //    }

    //}

    private bool m_IsExit =false;
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
