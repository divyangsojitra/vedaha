using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class EditUserProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
           
            
                LblcustomerId.Text = Session["CustomerId"].ToString();

            
            //LblcustomerId.Text = "1";
            SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
            ObjConnection.Open();

            SqlCommand ObjCommand = new SqlCommand();
            ObjCommand.Connection = ObjConnection;
            ObjCommand.CommandText = "CustomerMasterDetails";
            ObjCommand.CommandType = CommandType.StoredProcedure;

            ObjCommand.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(LblcustomerId.Text));

            SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);

            DataSet dsCustomerMasterDetails = new DataSet();

            ObjDataAdapter.Fill(dsCustomerMasterDetails);
            if (dsCustomerMasterDetails.Tables[0].Rows.Count > 0)
            {
                DataRow dr = dsCustomerMasterDetails.Tables[0].Rows[0];
                Txtfirstname.Text = dr["Firstname"].ToString();
                TxtLastName.Text = dr["Lastname"].ToString();
                TxtAddress.Text = dr["Address"].ToString();
                TxtCity.Text = dr["city"].ToString();
                TxtPincode.Text = dr["Pincode"].ToString();
                TxtState.Text = dr["State"].ToString();
                TxtPhoneno.Text = dr["Phoneno"].ToString();
                TxtBirthDate.Text = (dr["Birthdate"].ToString());


            }


        }
    }
    protected void ButEdit_Click(object sender, EventArgs e)
    {
    }
    protected void ButEdit_Click1(object sender, EventArgs e)
    {

        int intReturnValue = CCustomerMasterServices.CustomerMasterUpdate(Convert.ToInt32(LblcustomerId.Text),
            Txtfirstname.Text,
           TxtLastName.Text,
            TxtAddress.Text,
            TxtCity.Text,
            Convert.ToInt32(TxtPincode.Text),
             TxtState.Text,
           TxtPhoneno.Text,
            Convert.ToDateTime(TxtBirthDate.Text));
      //  int intReturnValue = CCustomerMasterServices.CustomerMasterUpdate(1, "ami", "patel", "surat", "tina", 122, "surat",199,Convert.ToDateTime(TxtBirthDate.Text));
       
        if (intReturnValue > 0)
        {
            Txtfirstname.Text = "";
            TxtLastName.Text = "";
            TxtAddress.Text = "";
            TxtCity.Text = "";
            TxtState.Text = "";
            TxtPhoneno.Text = "";
            TxtPincode.Text = "";

        }
    }
    protected void ButEdit_Command(object sender, CommandEventArgs e)
    {

    }
}
