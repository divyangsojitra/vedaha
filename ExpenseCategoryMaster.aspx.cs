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

public partial class ExpenseCategoryMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindExpenseCategoryList();
        }

    }
    public void BindExpenseCategoryList()
    {
        DataSet dsExpenseCategoryMasterList = CExpensecategoryMasterServices.ExpenseCategoryMasterList();
        GvExpenseList.DataSource = dsExpenseCategoryMasterList;
        GvExpenseList.DataBind();

    }

    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValues = CExpensecategoryMasterServices.ExpenseCategoryMasterInsert(TxtExpensecategoryname.Text);
        if (intReturnValues > 0)
        {
            Lblmsg.Text = "Expense Category Insert";
            BindExpenseCategoryList();
            TxtExpenseCategoryId.Text = "";
            TxtExpensecategoryname.Text = "";
        }
        else
        {
            Lblmsg.Text = "Error occured while insering Expense Category.";
        }
    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TxtExpenseCategoryId.Text = "";
        TxtExpensecategoryname.Text = "";

    }
    protected void Update_Click(object sender, EventArgs e)
    {
        int intReturnValues = CExpensecategoryMasterServices.ExpenseCategoryMasterUpDate(Convert.ToInt32(TxtExpenseCategoryId.Text), TxtExpensecategoryname.Text);
        if (intReturnValues > 0)
        {
            Lblmsg.Text = "Expense Category UpDate";
            BindExpenseCategoryList();
            TxtExpenseCategoryId.Text = "";
            TxtExpensecategoryname.Text = "";
        }
        else
        {
            Lblmsg.Text = "Error occured while Update Expense Category.";
        }
    }
    protected void GvExpenseList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int intExpensecategoryId = Convert.ToInt32(GvExpenseList.DataKeys[e.NewEditIndex].Value);
        //int intCosubcategoryId = Convert.ToInt32(gvCosubcategoryList.DataKeys[e.NewEditIndex].Value);

        CExpensecategory ObjExpensecategoryId = new CExpensecategory(intExpensecategoryId);
        if (ObjExpensecategoryId.IsExit == true)
        {
            TxtExpenseCategoryId.Text = ObjExpensecategoryId.ExpensecategoryId.ToString();
            TxtExpensecategoryname.Text = ObjExpensecategoryId.Expensecategoryname.ToString();
        }
        
    }
    protected void GvExpenseList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int intExpensecategory = Convert.ToInt32(GvExpenseList.DataKeys[e.RowIndex].Value);

        CExpensecategory ObjExpensecategoryId = new CExpensecategory(intExpensecategory);
        if(ObjExpensecategoryId.IsExit==true)
        {
            TxtExpenseCategoryId.Text=ObjExpensecategoryId.ExpensecategoryId.ToString();
            TxtExpensecategoryname.Text=ObjExpensecategoryId.Expensecategoryname.ToString();
        }

        int intReturnValue = CExpensecategoryMasterServices.ExpenseCategoryMasterDelete(Convert.ToInt32(TxtExpenseCategoryId.Text));
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "Expense Category Delete...";
            BindExpenseCategoryList();
            TxtExpenseCategoryId.Text = "";
            TxtExpensecategoryname.Text = "";
        }
        else
        {
            Lblmsg.Text = "Error occured while Delete Expense Category...";

        }
    }
}
