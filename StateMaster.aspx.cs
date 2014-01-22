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

public partial class StateMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(this.IsPostBack==false) 
        {
            BindStateList();
        }

    }
    public void BindStateList()
    {
        DataSet dsStateMasterList = CStateMasterServices.BindgvStateList();
        gvstateList.DataSource = dsStateMasterList;
        gvstateList.DataBind();
    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TxtStateId.Text = "";
        TxtStatename.Text = "";
    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        int intReturnValue=CStateMasterServices.StateInsert(Convert.ToInt32(TxtStateId.Text),TxtStatename.Text);
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "State Insert";
            BindStateList();
            TxtStateId.Text = "";
            TxtStatename.Text = "";
        }

    }
    protected void gvstateList_RowEditing(object sender, GridViewEditEventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = false;
        ButUpdate.Visible = true;
        ButCancle.Visible = true;

        int intStateId = Convert.ToInt32(gvstateList.DataKeys[e.NewEditIndex].Value);
        CStateMaster ObjState =new CStateMaster(intStateId);

        if(ObjState.IdExit==true)
        {
          TxtStateId.Text=ObjState.StateId.ToString();
          TxtStatename.Text=ObjState.Statename.ToString();
        }

    }
    protected void gvstateList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int intStateId = Convert.ToInt32(gvstateList.DataKeys[e.RowIndex].Value);
        CStateMaster ObjState = new CStateMaster(intStateId);

        if (ObjState.IdExit == true)
        {
            TxtStateId.Text = ObjState.StateId.ToString();
            TxtStatename.Text = ObjState.Statename.ToString();
        }

        int intReturnValue = CStateMasterServices.StateDelete(Convert.ToInt32(TxtStateId.Text));
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "State Delete";
            BindStateList();
            TxtStateId.Text = "";
            TxtStatename.Text = "";
        }


    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        ButInsert.Visible = false;
        ButCancle.Visible = true;
        TblAddEdit.Visible = false;
        
        
        int intReturnValue = CStateMasterServices.StateUpdate(Convert.ToInt32(TxtStateId.Text), TxtStatename.Text);
        if (intReturnValue > 0)
        {
            Lblmsg.Text = "State Update";
                BindStateList();
            TxtStateId.Text="";
            TxtStatename.Text="";
        }
    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButUpdate.Visible = false;
        ButCancle.Visible = true;
        ButInsert.Visible = true;
    }
}
