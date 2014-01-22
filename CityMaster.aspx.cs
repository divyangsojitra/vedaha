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

public partial class CityMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
               BindState();
               BindgvCity();
        }
    }
    public void BindgvCity()
    {
        DataSet dsCityMasterList = CCityMasterServices.CityMasterList();
        gvcity.DataSource = dsCityMasterList;
        gvcity.DataBind();
    }
    public void BindState()
    {
        DataSet dsStateMasterList = CCityMasterServices.BindStateMasterList();
        DropSate.DataSource = dsStateMasterList;
        DropSate.DataTextField = "Statename";
        DropSate.DataValueField = "StateId";
        DropSate.DataBind();

    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TxtCityId.Text = "";
        TxtCityname.Text = "";
        
    }
    protected void TxtCityId_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ButInsert_Click(object sender, EventArgs e)
    {
        ButCancle.Visible = true;
        ButUpdate.Visible = false;
        ButInsert.Visible = true;
        int intReturnValues = CCityMasterServices.CityMasterInsert(Convert.ToInt32(TxtCityId.Text), TxtCityname.Text, Convert.ToInt32(DropSate.SelectedValue));
        if (intReturnValues > 0)
        {
            Lblmsg.Text = "City Insert";
            BindgvCity();
            TxtCityId.Text = "";
            TxtCityname.Text = "";
            TblAddEdit.Visible = false;
        }
    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        int intReturnValues = CCityMasterServices.CityMasterUpdate(Convert.ToInt32(TxtCityId.Text), TxtCityname.Text, Convert.ToInt32(DropSate.SelectedValue));
            if(intReturnValues>0)
            {
                Lblmsg.Text="City UpDate";
                BindgvCity();
                TxtCityId.Text="";
                TxtCityname.Text="";
                TblAddEdit.Visible = false;
            }
    }
    protected void gvcity_RowEditing(object sender, GridViewEditEventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = false;
        ButUpdate.Visible = true;
        ButCancle.Visible = true;
        
        
        int intCityId=Convert.ToInt32(gvcity.DataKeys[e.NewEditIndex].Value);

        CCityMaster ObjCity = new CCityMaster(intCityId);

        if (ObjCity.IsExit==true)
        {
            Lblmsg.Text = "";
            TxtCityId.Text = ObjCity.CityId.ToString();
            TxtCityname.Text = ObjCity.Cityname.ToString();
            DropSate.SelectedValue = ObjCity.StateId.ToString();

        }
    }
    protected void gvcity_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int intCityId = Convert.ToInt32(gvcity.DataKeys[e.RowIndex].Value);

        CCityMaster ObjCity = new CCityMaster(intCityId);
        if (ObjCity.IsExit == true)
        {
            Lblmsg.Text = "";
            TxtCityId.Text = ObjCity.CityId.ToString();
            TxtCityname.Text = ObjCity.Cityname.ToString();
            DropSate.SelectedValue = ObjCity.StateId.ToString();
        }

        int intReturnValues = CCityMasterServices.CityMasterDelete(Convert.ToInt32(TxtCityId.Text));
            if(intReturnValues>0)
            {
                Lblmsg.Text="City Delete";
                BindgvCity();
                TxtCityId.Text="";
                TxtCityname.Text="";

            }

    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButInsert.Visible = true;
        ButUpdate.Visible = false;
        ButCancle.Visible = true;
    }
}
