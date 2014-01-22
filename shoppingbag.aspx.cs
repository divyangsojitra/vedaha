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

public partial class shopping_bag : System.Web.UI.Page
{
    double gnd_Total = 0;
    int i=1;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Page.IsPostBack)
        {
            BindsoppingBagData();
        }
        try
        {
            if (Session["OrderId"].ToString() == "imfromshp")
            {
                filldetails();
            }
        }
        catch (Exception ex) { }
        if (!Page.IsPostBack)
        {
            //Response.Redirect("LoginMaster.aspx");
            //BindsoppingBagData();
        }
        //CCartMaster Objcart = new CCartMaster(intcartId);
        //if (Objcart.IsExit == true)
        //{


        //    Image1.ImageUrl = "~/Image/" + (Objcart.Image.ToString());
        //}
    }
    protected void BindsoppingBagData()

    {
        
        DataSet DsCartMasterList = CCartMasterrServices.CartList();
        GvshoppingList.DataSource = DsCartMasterList;
        GvshoppingList.DataBind();
       
        

    }



    
    protected void GvshoppingList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GvshoppingList_RowEditing(object sender, GridViewEditEventArgs e)    
    {
        
        GvshoppingList.EditIndex=e.NewEditIndex;
        BindsoppingBagData();
        

    }
    protected void GvshoppingList_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

           int key = Convert.ToInt32(GvshoppingList.DataKeys[e.RowIndex].Value);

           HiddenField hidcartId = (HiddenField)(GvshoppingList.Rows[e.RowIndex].Cells[0].FindControl("hidcartId"));
           HiddenField hidProductId = (HiddenField)(GvshoppingList.Rows[e.RowIndex].Cells[0].FindControl("hidProductId"));
           HiddenField hidSizeId = (HiddenField)(GvshoppingList.Rows[e.RowIndex].Cells[0].FindControl("hidSizeId"));
       
          //// Label LblCartId = (Label)(GvshoppingList.Rows[e.RowIndex].Cells[1].FindControl("LblcartId"));
          // Label LblProductId = (Label)GvshoppingList.Rows[e.RowIndex].Cells[2].FindControl("LblProductId");
          // //TextBox TxtQty = new TextBox();
          // Label LblSize = (Label)GvshoppingList.Rows[e.RowIndex].Cells[3].FindControl("LblSize");
            TextBox TxtQty = (TextBox)GvshoppingList.Rows[e.RowIndex].Cells[4].FindControl("TxtQty");
           // TextBox TxtPrice = new TextBox();
            Label LblPrice = (Label)GvshoppingList.Rows[e.RowIndex].Cells[5].FindControl("LblPrice");
            Label Lbltotal = (Label)GvshoppingList.Rows[e.RowIndex].Cells[6].FindControl("Lbltotal");
            //Label LblTotalAmt = (Label)GvshoppingList.Rows[e.RowIndex].Cells[6].FindControl("LblTotalAmt");

            //TxtPrice.Text = TxtPrice.Text;
        
        //double LineTotamt;
        //LineTotamt = Convert.ToDouble(TxtPrice.Text); Convert.ToInt32(TxtQty.Text);
          //LineTotamt =conv(TxtQty.Text)(TxtPrice.Text));
            
           int CartId = Convert.ToInt32(hidcartId.Value);
           int ProductId = Convert.ToInt32(hidProductId.Value);
           int SizeId = Convert.ToInt32(hidSizeId.Value);
            int Qty = Convert.ToInt32(TxtQty.Text);
            double Price = Convert.ToDouble(LblPrice.Text);
            //double Total = Convert.ToDouble(Lbltotal.Text);
            //int CustomerId;
            //if (LblCustomerId.Text != "")
            //{
            //    CustomerId = Convert.ToInt32(LblCustomerId.Text);
            //}
            double LineTotamt;

            LineTotamt = Price*Qty;
            //LineTotamt = Convert.ToDouble(TxtPrice.Text); Convert.ToInt32(TxtQty.Text);

            
           
            Lbltotal.Text = Convert.ToString(LineTotamt);
            double Total = Convert.ToDouble(Lbltotal.Text);
            
            
            SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
            ObjConnection.Open();

            SqlCommand ObjCommand = new SqlCommand();
            ObjCommand.Connection = ObjConnection;
            ObjCommand.CommandText = "CartMasterUpdate";
            ObjCommand.CommandType = CommandType.StoredProcedure;

            ObjCommand.Parameters.AddWithValue("@CartId", CartId);
            ObjCommand.Parameters.AddWithValue("@ProductId", ProductId);
            ObjCommand.Parameters.AddWithValue("@SizeId", SizeId);
            ObjCommand.Parameters.AddWithValue("@Price", Price);
            ObjCommand.Parameters.AddWithValue("@Qty", Qty);
            ObjCommand.Parameters.AddWithValue("@Total", Total);
            //ObjCommand.Parameters.AddWithValue("@CustomerId", CustomerId);

            int intReturnValue = Convert.ToInt32(ObjCommand.ExecuteScalar());
            if (intReturnValue > 0)
            {
               
                GvshoppingList.EditIndex = -1;
                 BindsoppingBagData();
            }

            
    }
    protected void GvshoppingList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GvshoppingList.Rows[e.RowIndex];

       // Label LblCartId = (Label)(GvshoppingList.Rows[e.RowIndex].Cells[1].FindControl("LblcartId"));
        HiddenField hidcartId = (HiddenField)(GvshoppingList.Rows[e.RowIndex].Cells[1].FindControl("hidcartId"));
        int CartId = Convert.ToInt32(hidcartId.Value);
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();
        SqlCommand ObjCommand=new SqlCommand("Delete from CartMaster where CartId=@CartId",ObjConnection);

        ObjCommand.Parameters.AddWithValue("@CartId",CartId);

        ObjCommand.ExecuteNonQuery();
        ObjConnection.Close();
        
        //string cartId = GvshoppingList.DataKeys[e.RowIndex].Value.ToString();
        //string Query = "Delete CartMaster where  CartMaster.cartId= " + cartId;
        BindsoppingBagData();
        //BindGridData();
    }
    protected void GvshoppingList_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GvshoppingList.EditIndex = -1;
        BindsoppingBagData();
    }
    protected void GvshoppingList_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    public void TxtQty_TextChanged(object sender, EventArgs e)
    {
        //GridViewRow grd = GvshoppingList.SelectedRow;
        //GridViewRow row = (GridViewRow)grd.NamingContainer;
        ////GridViewRow row = GvshoppingList.SelectedRow;

        //if (row != null)
        //{
        //    int index = row.RowIndex; //gets the row index selected
        //    Response.Write(index);
        //}
    }
    protected void GvshoppingList_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
    }
    protected void GvshoppingList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            
            Label lblSrno = (Label)e.Row.FindControl("LblSrno");
            lblSrno.Text = i.ToString();
            i++;
        }
        
        if (e.Row.RowType == DataControlRowType.DataRow)
        { 
            double _Price = 0;
            int _Qty = 0;
            double Tot = 0;
            
            

            _Price = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "Price"));
            _Qty = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Qty"));
            Tot = _Price*_Qty;

            Tot = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "Total"));
            
            //GridViewRow row = (GridViewRow)GvshoppingList.Rows[e.RowIndex];
            //GridViewRow row = (GridViewRow)GvshoppingList.Rows[e.RowIndex];
            //Label Lbltotal = (Label)GvshoppingList.Rows[e.RowIndex].Cells[5].FindControl("Lbltotal");
            Label Lbltotal = (Label)e.Row.Cells[5].FindControl("Lbltotal");

            Lbltotal.Text = Tot.ToString();

            //ViewState["Tot"] = Convert.ToDouble(ViewState["_Tot"]+Lbltotal.Text);

           double  RowTotal = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "Total"));
            gnd_Total = gnd_Total + RowTotal;
           

        }
        
        if (e.Row.RowType==DataControlRowType.Footer)
        {
            

            Label LblTotalAmt = (Label)e.Row.FindControl("LblTotalAmt");
            LblTotalAmt.Text = gnd_Total.ToString();
        }
        
    }
    protected void ButOder_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["Type"].ToString() == "User")
            {
                filldetails();
            }
            else
            {
                Session["OrderId"] = "imfromshp";
                Response.Redirect("LoginMaster.aspx");
            }
        }
        catch (Exception ex)
        {
            Session["OrderId"] = "imfromshp";
            Response.Redirect("LoginMaster.aspx");
        }
    }

    private void filldetails()
    {
        TblOderinformation.Visible = true;
        LblCustomerId.Text = Session["CustomerId"].ToString();

        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CustomerData";
        ObjCommand.CommandType = CommandType.StoredProcedure;

        ObjCommand.Parameters.AddWithValue("@CustomerId",int.Parse(Session["CustomerId"].ToString()));

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);

        DataSet dsCustomerMasterDetails = new DataSet();

        ObjDataAdapter.Fill(dsCustomerMasterDetails);

        if (dsCustomerMasterDetails.Tables[0].Rows.Count > 0)
        {
            DataRow dr = dsCustomerMasterDetails.Tables[0].Rows[0];

            Txtfirstname.Text = dr["Firstname"].ToString();
            TxtLastName.Text = dr["Lastname"].ToString();
            TxtAddress.Text = dr["Address"].ToString();
            TxtState.Text = dr["Statename"].ToString();
            TxtCity.Text = dr["Cityname"].ToString();
            TxtPincode.Text = dr["Pincode"].ToString();
            TxtPhoneno.Text = dr["Phoneno"].ToString();
          // LblCustomerId.Text = dr["CustomerId"].ToString();
        }
        Label TotalAmt = (Label)GvshoppingList.FooterRow.FindControl("LblTotalAmt");
        // double data5 = Convert.ToDouble(TotalAmt.Text);
        LblTotal.Text = (TotalAmt.Text);
    }
    protected void ButOderDetail_Click(object sender, EventArgs e)
    {
        
        foreach(GridViewRow gvRow in GvshoppingList.Rows)
        {
            //Label CartId = (Label)gvRow.FindControl("LblCartId");
            HiddenField CartId = (HiddenField)gvRow.FindControl("hidcartId");
            int Cart1 = Convert.ToInt32(CartId.Value);

            HiddenField ProductId1 = (HiddenField)gvRow.FindControl("hidProductId");
            int ProductId = Convert.ToInt32(ProductId1.Value);

            HiddenField SizeId1 = (HiddenField)gvRow.FindControl("hidSizeId");
            int SizeId = Convert.ToInt32(SizeId1.Value);

            //Label Productname = (Label)gvRow.FindControl("LblProductId");
            //string data1 = (Productname.Text).ToString();
            //Label SizeDec = (Label)gvRow.FindControl("LblSize");

            //string data6 =(SizeDec.Text).ToString();
            Label  Qty = (Label)gvRow.FindControl("LblQty");
           int data2 =Convert.ToInt32(Qty.Text);
            Label Price = (Label)gvRow.FindControl("LblPrice");
            double data3 = Convert.ToDouble(Price.Text);
            Label LineTotalAmt = (Label)gvRow.FindControl("LblTotal");
            double data4 = Convert.ToDouble(LineTotalAmt.Text);
            Label TotalAmt = (Label)GvshoppingList.FooterRow.FindControl("LblTotalAmt");
            double data5 = Convert.ToDouble(TotalAmt.Text);
            int d1=Convert.ToInt32(LblOrderId.Text);

            int intReturnValue = COrderMasterDetailServices.OrderMasterDetailInsert
                (Convert.ToInt32(d1),
                Convert.ToInt32(ProductId),
                Convert.ToInt32(SizeId),
                Convert.ToInt32(data2),
                Convert.ToDouble(data3),
                Convert.ToDouble(data4),
                Convert.ToDouble(data5));
            int intReturnValues = CPurchseMasterServices.SellEnteryInsert(Convert.ToInt32(ProductId), Convert.ToInt32(data2), Convert.ToDouble(data3));
            int intReturnValuescart = CCartMasterrServices.CartDelete(Convert.ToInt32(Cart1));
            ButOder.Visible = false;
        }
        Response.Redirect("CreditcardMaster.aspx");
    }

    protected void ButPay_Click(object sender, EventArgs e)
    {
        ButOder.Visible = false;
        //int Oderid;
        //LblOderId.Text = intReturnValue.ToString()

        //int intReturnValue= Convert.ToInt32(LblOderId.Text);
        int intReturnValue = COrderMasterServices.OrderMasterInsert(
            Convert.ToInt32(LblCustomerId.Text),
                     Txtfirstname.Text, TxtAddress.Text, TxtCity.Text, TxtState.Text,
                    Convert.ToInt32(TxtPincode.Text), TxtPhoneno.Text,Convert.ToDouble(LblTotal.Text), OpPaymentoption.SelectedValue, "done");
        //intReturnValue = Convert.ToInt32(LblOderId.Text);
        LblOrderId.Text = intReturnValue.ToString();
        if (intReturnValue > 0)
        {
            Txtfirstname.Text = "";
            TxtAddress.Text = "";
            TxtLastName.Text = "";
            TxtCity.Text = "";
            TxtPincode.Text = "";
            TxtPhoneno.Text = "";
            TxtState.Text = "";
            LblTotal.Text = "";

        }
        COrderMaster ObjOder = new COrderMaster(Convert.ToInt32(LblOrderId.Text));
       if(ObjOder.IsExit==true)
       {
           Session["OrderId"]=ObjOder.OrderId;
       }
       TblOderinformation.Visible = false;
       ButOderDetail.Visible = true;
        
    }
    
}
