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

public partial class PurchseDetail : System.Web.UI.Page
{
    double gnd_Total = 0;
    int i = 1;
    int intReturnValues = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LblcustomerId.Text = "7";
            BindgvPurchseDetail(Convert.ToInt32(LblcustomerId.Text));
        }
    }

    public void BindgvPurchseDetail(int CustomerId)
    {
        DataSet DsCustomerpurchseDetail = COrderMasterServices.CustomerpurchseDetail(Convert.ToInt32(LblcustomerId.Text));
        GVPurchseDetail.DataSource = DsCustomerpurchseDetail;
        GVPurchseDetail.DataBind();
    }

    protected void GVPurchseDetail_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GVPurchseDetail.EditIndex = e.NewEditIndex;
        BindgvPurchseDetail(Convert.ToInt32(LblcustomerId.Text));
    }

    protected void GVPurchseDetail_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string  OrderID = GVPurchseDetail.DataKeys[e.RowIndex].Values[0].ToString();
        string  PurchaseID = GVPurchseDetail.DataKeys[e.RowIndex].Values[1].ToString();
        //Label LblPurchseId=(Label)(GVPurchseDetail.Rows[e.RowIndex].Cells[1].FindControl("LblPurchseId"));
        //Label LblOrderId = (Label)(GVPurchseDetail.Rows[e.RowIndex].Cells[2].FindControl("LblOrderId"));

        //int OrderID = 0;
        //int PurchaseID = 0;
        //if (LblOrderId != null)
        //{
        //    if (LblOrderId.Text != "")
        //    {
        //        OrderID = Convert.ToInt32(LblOrderId.Text);
        //    }
        //}
        //if (LblPurchseId != null)
        //{
        //    if (LblPurchseId.Text != "")
        //    {
        //        PurchaseID = Convert.ToInt32(LblPurchseId.Text);
        //    }
        //}

        Label LblQty = (Label)(GVPurchseDetail.Rows[e.RowIndex].Cells[6].FindControl("LblQty"));
        TextBox TxtReturnQty = (TextBox)(GVPurchseDetail.Rows[e.RowIndex].Cells[7].FindControl("TxtReturnQty"));
        int ReturnQty = Convert.ToInt32(TxtReturnQty.Text);
        if (Convert.ToInt32(LblQty.Text) >= Convert.ToInt32(TxtReturnQty.Text))
        {



            //int Key = Convert.ToInt32(GVPurchseDetail.DataKeys[e.RowIndex].Value);

            //Label LblQty = (Label)(GVPurchseDetail.Rows[e.RowIndex].Cells[5].FindControl("LblQty"));
            //TextBox TxtReturnStatus = (TextBox)(GVPurchseDetail.Rows[e.RowIndex].Cells[6].FindControl("TxtReturnStatus"));
            Label LblPrice = (Label)(GVPurchseDetail.Rows[e.RowIndex].Cells[8].FindControl("LblPrice"));
            Label LblLineTotalAmt = (Label)(GVPurchseDetail.Rows[e.RowIndex].Cells[9].FindControl("LblLineTotalAmt"));

            //int Qty;
            //int ReturnStatus;
            //int Qty = Convert.ToInt32(LblQty);
            //int ReturnStatus = Convert.ToInt32(TxtReturnStatus);
           // int ReturnQty = Convert.ToInt32(TxtReturnQty);
            int Qty = Convert.ToInt32(LblQty.Text);
            double Price = Convert.ToDouble(LblPrice.Text);


            // double Price;
            double LineTotamt;
            Qty = (Qty - ReturnQty);
            LblQty.Text = Convert.ToString(Qty);
            LineTotamt = Price * Qty;
            LblPrice.Text = Convert.ToString(Price);
            //LblLineTotalAmt = Convert.ToString(LblLineTotamt);
            //double TotalAmt = Convert.ToDouble(LblTotalAmt);

            //Qty = Convert.ToInt32(LblQty);
            //ReturnStatus = Convert.ToInt32(TxtReturnStatus);
            //Price = Convert.ToDouble(LblPrice);
            
            LblLineTotalAmt.Text = Convert.ToString(LineTotamt);


            CPurchseMasterServices ObjCPurchseMasterServices=new CPurchseMasterServices;

       = CPurchseMasterServices.CustomerReturnQty(PurchaseID, Qty, LineTotamt, ReturnQty);
            //int intReturnValues1 = COrderMasterDetailServices.StockQtyReturnListOrderDetail(Convert.ToUInt32(OrderID),Qty,Price,LineTotamt);  
            
            

                GVPurchseDetail.EditIndex = -1;
                BindgvPurchseDetail(Convert.ToInt32(LblcustomerId.Text));
                
            
            

            //int intReturnValues=COrderMasterDetailServices
        }
        else
        {
            Lblmsg.Text = "Enter the Proper ReturnQty";
        }

        
    }

    protected void GVPurchseDetail_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            Label LblSrno = (Label)e.Row.FindControl("LblSrno");
            LblSrno.Text = i.ToString();
            i++;
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            double _Price = 0;
            int _Qty = 0;
            double _Tot = 0;

            _Price=Convert.ToDouble(DataBinder.Eval(e.Row.DataItem,"Price"));
            _Qty=Convert.ToInt32(DataBinder.Eval(e.Row.DataItem,"Qty"));
            _Tot=_Price*_Qty;
            _Tot = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "LineTotalAmt"));

            Label LblLineTotalAmt = (Label)(e.Row.Cells[9].FindControl("LblLineTotalAmt"));
            LblLineTotalAmt.Text = _Tot.ToString();

            double RowTotal = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "LineTotalAmt"));
             gnd_Total = gnd_Total + RowTotal;

        }
        if (e.Row.RowType==DataControlRowType.Footer)
        {
            

            Label LblTotalAmt = (Label)e.Row.FindControl("LblTotalAmt");
            LblTotalAmt.Text = gnd_Total.ToString();
        }
    }

}
