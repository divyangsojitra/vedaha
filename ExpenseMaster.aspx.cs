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

public partial class ExpenseMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindExpensecategoryname();
            BindGVExpenseMasterList();
        }
    }
    public void BindExpensecategoryname()
    {
        DataSet dsExpenseCategoryMasterList = CExpensecategoryMasterServices.ExpenseCategoryMasterList();
        DropExpensecategoryList.DataSource = dsExpenseCategoryMasterList;
        DropExpensecategoryList.Items.Clear();
        DropExpensecategoryList.DataTextField = "Expensecategoryname";
        DropExpensecategoryList.DataValueField = "ExpensecategoryId";
        DropExpensecategoryList.DataBind();
    }
    public void BindGVExpenseMasterList()
    {
        DataSet dsExpenseMasterList = CExpenseMasterServices.ExpenseMasterList();
        GVExpenseMasterList.DataSource = dsExpenseMasterList;
        GVExpenseMasterList.DataBind();
    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValue = CExpenseMasterServices.ExpenseMasterInsert(Convert.ToInt32(TxtVno.Text),Convert.ToDateTime(TxtVDate.Text),
           Convert.ToInt32(DropExpensecategoryList.SelectedValue),TxtDescription.Text,Convert.ToDouble(TxtAmount.Text),DropType.SelectedValue);
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "Insert Expense";
            BindGVExpenseMasterList();
            TxtExpenseId.Text = "";
            TxtVno.Text = "";
            TxtVDate.Text = "";
            TxtDescription.Text = "";
            TxtAmount.Text = "";
        }
        else
        {
            Lblmsg.Text="Error Occur while Inserting Expense Entery...";
        }
    }
    protected void GVExpenseMasterList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Cancle_Click(object sender, EventArgs e)
    {
        Lblmsg.Text = "";
        TxtExpenseId.Text = "";
        TxtVno.Text = "";
        TxtVDate.Text = "";
        TxtDescription.Text = "";
        TxtAmount.Text = "";

    }
    protected void GVExpenseMasterList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int intExpenseId = Convert.ToInt32(GVExpenseMasterList.DataKeys[e.NewEditIndex].Value);
        
        CExpenseMaster ObjExpenseId = new CExpenseMaster(intExpenseId);
        if(ObjExpenseId.IsExit==false)
        {
            TxtExpenseId.Text = ObjExpenseId.ExpenseId.ToString();
            TxtVno.Text = ObjExpenseId.VNo.ToString();
            TxtVDate.Text = ObjExpenseId.VDate.ToString();
            DropExpensecategoryList.SelectedValue= ObjExpenseId.ExpensecategoryId.ToString();
            TxtDescription.Text = ObjExpenseId.ExpenseDesc.ToString();
            TxtAmount.Text = ObjExpenseId.Amount.ToString();
            DropType.SelectedValue = ObjExpenseId.Type.ToString();

        }
    }
    protected void GVExpenseMasterList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int intExpenseId = Convert.ToInt32(GVExpenseMasterList.DataKeys[e.RowIndex].Value);

        CExpenseMaster ObjExpenseId = new CExpenseMaster(intExpenseId);
        if (ObjExpenseId.IsExit == false)
        {
            TxtExpenseId.Text = ObjExpenseId.ExpenseId.ToString();
            TxtVno.Text = ObjExpenseId.VNo.ToString();
            TxtVDate.Text = ObjExpenseId.VDate.ToString();
            DropExpensecategoryList.SelectedValue = ObjExpenseId.ExpensecategoryId.ToString();
            TxtDescription.Text = ObjExpenseId.ExpenseDesc.ToString();
            TxtAmount.Text = ObjExpenseId.Amount.ToString();
            DropType.SelectedValue = ObjExpenseId.Type.ToString();
        }
        int intReturnValue = CExpenseMasterServices.ExpenseMasterDelete(Convert.ToInt32(TxtExpenseId.Text));

        if (intReturnValue > 0)
        {
            Lblmsg.Text = "Delete Expense Entery..";
            BindGVExpenseMasterList();
            TxtExpenseId.Text = "";
            TxtVno.Text = "";
            TxtVDate.Text = "";
            TxtDescription.Text = "";
            TxtAmount.Text = "";
        }
        else
        {
            Lblmsg.Text = "Error Occur while Delete the Expense Entery...";
        }
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        int intReturnValue = CExpenseMasterServices.ExpenseMasterUpdate(Convert.ToInt32(TxtExpenseId.Text), Convert.ToInt32(TxtVno.Text), Convert.ToDateTime(TxtVDate.Text), Convert.ToInt32(DropExpensecategoryList.SelectedValue), TxtDescription.Text, Convert.ToDouble(TxtAmount.Text),DropType.SelectedValue);
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "Expense UpDate...";
            BindGVExpenseMasterList();
            TxtExpenseId.Text = "";
            TxtVno.Text = "";
            TxtVDate.Text = "";
            TxtDescription.Text = "";
            TxtAmount.Text = "";

        }
    }
    protected void DropType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
