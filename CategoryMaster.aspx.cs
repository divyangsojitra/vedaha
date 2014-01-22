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

public partial class CategoryMaster : System.Web.UI.Page
{
   // string strConnectionString = @"Data Source=LENOVO\SQL2005;Initial Catalog=shopping;Persist Security Info=True;User ID=sa;Password=123456";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            BindGrid();
        }
        
    }
    private void BindGrid()
    {
        DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        gvCategorylist.DataSource = dsCategoryMasterList;
        gvCategorylist.DataBind();
    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValue = CCategorymasterServices.CategoryInsert(Convert.ToInt32(TxtCategorycode.Text), TxtCategoryName.Text, Dropstatus.SelectedValue);
        if(intReturnValue >0)
        {
            lblmsgbox.Text  = "Category Insert";
            BindGrid();
            TxtCategorycode.Text = "";
            TxtCategoryName.Text = "";
            Dropstatus.SelectedValue = "";

            TblAddEdit.Visible = false;
        }
        else
        {
            lblmsgbox.Text="Error occured while insering Category.";
        }

    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = false;
        TxtCategorycode.Text = "";
        TxtCategoryName.Text = "";
        Dropstatus.SelectedValue = "";
        lblmsgbox.Text = "";

    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        int intReturnValue = CCategorymasterServices.CategoryUpdate(Convert.ToInt32(TxtCategoryId.Text),Convert.ToInt32(TxtCategorycode.Text), TxtCategoryName.Text, Dropstatus.SelectedValue);
        if (intReturnValue > 0)
        {
            lblmsgbox.Text = "Category Update";
            BindGrid();
            TxtCategoryId.Text = "";
            TxtCategorycode.Text = "";
            TxtCategoryName.Text = "";
            Dropstatus.SelectedValue = "";
            lblmsgbox.Text = "";
        }
        else
        {
            lblmsgbox.Text = "Error occured while UpDate Category.";
        }
    }
    protected void gvCategorylist_RowEditing(object sender, GridViewEditEventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = false;
        ButCancle.Visible = true;
        ButUpdate.Visible = true;

        int intCategoryId = Convert.ToInt32(gvCategorylist.DataKeys[e.NewEditIndex].Value);

        CCategoryMaster ObjCategory = new CCategoryMaster(intCategoryId);

        if (ObjCategory.IsExit ==true)
        {
            //global::System.Windows.Forms.MessageBox.Show("hiiii");
            lblmsgbox.Text = "";
            TxtCategoryId.Text = ObjCategory.CategoryId.ToString();
            TxtCategorycode.Text = ObjCategory.CategoryCode.ToString();
            TxtCategoryName.Text = ObjCategory.CategoryName;
            Dropstatus.SelectedValue = ObjCategory.Status;
        }
 
    }
    protected void gvCategorylist_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        TblAddEdit.Visible = false;
        ButInsert.Visible = false;
        ButCancle.Visible = true;
        ButUpdate.Visible = true;
        int intCategoryId = Convert.ToInt32(gvCategorylist.DataKeys[e.RowIndex].Value);
        CCategoryMaster ObjCategory = new CCategoryMaster(intCategoryId);

        if (ObjCategory.IsExit == true)
        {
            //global::System.Windows.Forms.MessageBox.Show("hiiii");
            lblmsgbox.Text = "Category Delete";
            TxtCategoryId.Text = ObjCategory.CategoryId.ToString();
            TxtCategorycode.Text = ObjCategory.CategoryCode.ToString();
            TxtCategoryName.Text = ObjCategory.CategoryName;
            Dropstatus.SelectedValue = ObjCategory.Status;
        }
 

       // int intCategoryId = Convert.ToInt32(gvCategorylist.DataKeys[e.RowIndex].Value);
        //CCategorymasterServices  ObjCategory = new CCategoryMaster(intCategoryId);
        int intReturnValue = CCategorymasterServices.CategoryDelete(Convert.ToInt32(TxtCategoryId.Text));
        if (intReturnValue > 0)
        {
            BindGrid();
            TxtCategoryId.Text  = "";
            TxtCategorycode.Text = "";
            TxtCategoryName.Text = "";
        }
        else
        {
            lblmsgbox.Text = "Error occured while Deleting Data.";  
        }
            
    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {

        //((LinkButton)GridView1.Rows[e.Row.RowIndex].Cells[1].Controls[0]).Enabled = false;
       // ((Button)gvCategorylist.Rows[e.Equals.RowIndex].Cells[1].Controls[0]).Enabled=false;
        TblAddEdit.Visible = true;
        ButInsert.Visible = true;
        ButCancle.Visible = true;
        ButUpdate.Visible = false;
        TxtCategoryId.Text = "";
        TxtCategorycode.Text = "";
        TxtCategoryName.Text = "";
       


    }
    protected void gvCategorylist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
protected void  gvCategorylist_SelectedIndexChanged1(object sender, EventArgs e)
{

}
protected void gvCategorylist_SelectedIndexChanged2(object sender, EventArgs e)
{

}
protected void gvCategorylist_SelectedIndexChanged3(object sender, EventArgs e)
{

}
}
