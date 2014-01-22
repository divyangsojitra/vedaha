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

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindCustomerCityList();

            // BindState();
        }

        //captcha1.Success += new CaptchaEventHandler(captcha1_Success);
        //captcha1.Failure += new CaptchaEventHandler(captcha1_Failure);
    }
    // public void captcha1_Failure()
    //{
    //    Lblmsgbox.Text = "Fail";
    //}
    //public void captcha1_Success()
    //{
    //    Lblmsgbox.Text = "Sucess";
    //}
    public void BindCustomerCityList()
    {
        DataSet dsCityMasterList = CCustomerMasterServices.BindCityList();

        DropCityList.DataSource = dsCityMasterList;
        DropCityList.DataTextField="Cityname";
        DropCityList.DataValueField="CityId";
        DropCityList.DataBind();
    
    }
    //public void BindCustomerState()
    //{
    
    //}
    



    protected void  ButCancel_Click(object sender, EventArgs e)
{
    
        Txtfirstname.Text = "";
        TxtLastName.Text = "";
        TxtAddress.Text = "";
       //TxtCity.Text = "";
        //LblState.Text = "";
        TxtPincode.Text = "";
        TxtPhoneno.Text = "";
        //TxtDate.Text = "";
        TxtEmailId.Text = "";
        TxtPassword.Text = "";
        TxtConfirmPassword.Text = "";
}


    //protected void captacha_Sucess(object sender, EventArgs e)
    //{
       
    //}
    //protected void Captacha_Failure(object sender, EventArgs e)
    //{

    //}
    protected void ButCreatemyaccount_Click(object sender, EventArgs e)
    {

        //if (Session["captcha"] != null && captcha1.txtCaptchaBox.Text.ToLower() == Session["captcha"].ToString())
        {
            Lblmsgbox.Text = "sucess";  
            //on correct code create account
            // ButCreatemyaccount .Visible = true;
            ButCancel.Visible = true;
            //ButUpdate.Visible = false;
            //ButAdd.Visible = true;
            // TblAddEdit.Visible = true;

            int intReturnValue = CCustomerMasterServices.CustomerMasterInsert(
            Txtfirstname.Text,
            TxtLastName.Text,
            TxtAddress.Text,
            Convert.ToInt32(DropCityList.SelectedValue),
           Convert.ToInt32(Dropstate.SelectedValue),
                // LblState.Text,
            Convert.ToInt32(TxtPincode.Text),
            TxtPhoneno.Text,
            Convert.ToDateTime(TxtBirthDate.Text),
            TxtEmailId.Text,
            TxtPassword.Text,
            checkStatus.Checked = true,Lbltype.Text);

            if (intReturnValue > 0)
            {
                Lblmsgbox.Text = " Account is Created";
                // BindCustomerList();
                Txtfirstname.Text = "";
                TxtLastName.Text = "";
                TxtAddress.Text = "";
                //TxtCity.Text = "";
                TxtPincode.Text = "";
                // LblState.Text = "";
                TxtPhoneno.Text = "";
                TxtEmailId.Text = "";
                TxtPassword.Text = "";
                TxtConfirmPassword.Text = "";
                //TxtDate.Text = "";
                checkStatus.Checked = false;

            }
            //else
            {


            }
        }
        //else
        //{
        //    Lblmsgbox.Text = "You have entered incorrect code, Please enter correct one.";
        //    captcha1.txtCaptchaBox.Text = "";
        //    captcha1.SetCaptcha();
        //    //SetCaptcha();           
        //}
        
        
        
        
    
    }

      public void BindState(string stateid)
    {

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand("Select Statename,Stateid from statemaster where stateid="+stateid, ObjConnection);
        
        // ObjCommand.Connection = ObjConnection;
        //ObjCommand.CommandText = "CustomerMastercityList";
        // ObjCommand.CommandType = CommandType.StoredProcedure;

        //ObjCommand.CommandText =;
        SqlDataReader dr = ObjCommand.ExecuteReader();
        Dropstate.DataSource = dr;
        Dropstate.Items.Clear();
        Dropstate.DataTextField = "Statename";
        Dropstate.DataValueField = "StateId";
        Dropstate.DataBind();
        
    }
    protected void DropCityList_SelectedIndexChanged(object sender, EventArgs e)
    
    {
        
        CCityMaster ObjState = new CCityMaster(Convert.ToInt32(DropCityList.SelectedValue));
        BindState(ObjState.StateId.ToString());
        //CStateMaster ObjState = new CStateMaster(Convert.ToInt32(DropCityList.SelectedValue));
      //  Dropstate.SelectedValue = ObjState.StateId.ToString();
       // Lblstate.Text = ObjState.StateId.ToString();
        
        
        
        

       //SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        //////ObjConnection.Open();

        //////SqlCommand ObjCommand = new SqlCommand();
        //////ObjCommand.Connection = ObjConnection;
        //////ObjCommand.CommandText = "CustomerMastercityList";
        //////ObjCommand.CommandType = CommandType.StoredProcedure;

        ////////ObjCommand.Parameters.AddWithValue("@CityId", DropCityList.SelectedValue);


        //////SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        //////DataSet dsCustomerMastercityList = new DataSet();

        //////ObjDataAdapter.Fill(dsCustomerMastercityList);

        //////Dropstate.DataSource = dsCustomerMastercityList;
        //////Dropstate.DataTextField = "Statename";
        //////Dropstate.DataValueField = "SatateId";
        //////Dropstate.DataBind();






        ////if (dsCustomerMastercityList.Tables[0].Rows.Count > 0)
        ////{
        ////    DataSet dr = dsCustomerMastercityList.Tables[0].Rows[0];

        ////    //DropCityList.SelectedValue = dr["Cityname"].
        ////    Dropstate.SelectedValue = dr["Statename"].ToString();

        ////    //LblState.Text = dr["Statename"].ToString();
        ////}

    }
   

    protected void ButcontinuousShopping_Click(object sender, EventArgs e)
    {
        Response.Redirect("shoppingbag.aspx");
    }

    protected void Dropstate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

}
