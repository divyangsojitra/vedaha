using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (this.IsPostBack == false)
        //{
        //    BindCategory();
        //}
        //SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        //ObjConnection.Open();

        //SqlCommand ObjCommand = new SqlCommand();
        //ObjCommand.Connection = ObjConnection;
        //ObjCommand.CommandText = "CategoryImage";
        //ObjCommand.CommandType = CommandType.StoredProcedure;

        //DataTable dt = new DataTable();
        //SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        //ObjDataAdapter.Fill(dt);

        //Image11.ImageUrl = "~/Image/" + dt.Rows[0]["Image"];
        //Image11.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[0]["Image"];
        //Image12.ImageUrl = "~/Image/" + dt.Rows[1]["Image"];
        //Image12.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[1]["Image"];
        //Image13.ImageUrl = "~/Image/" + dt.Rows[2]["Image"];
        //Image13.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[2]["Image"];
        //Image14.ImageUrl = "~/Image/" + dt.Rows[3]["Image"];
        //Image14.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[3]["Image"];
        ////Image15.ImageUrl = "~/Image/" + dt.Rows[4]["Image"];
        ////Image15.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[4]["Image"];
        ////Image16.ImageUrl = "~/Image/" + dt.Rows[5]["Image"];
        ////Image16.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[5]["Image"];
        ////Image17.ImageUrl = "~/Image/" + dt.Rows[6]["Image"];
        ////Image17.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[6]["Image"];
        ////Image18.ImageUrl = "~/Image/" + dt.Rows[7]["Image"];
        ////Image18.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[7]["Image"];
        ////Image19.ImageUrl = "~/Image/" + dt.Rows[8]["Image"];
        ////Image19.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[8]["Image"];
        ////Image20.ImageUrl = "~/Image/" + dt.Rows[9]["Image"];
        ////Image20.PostBackUrl = "~/Cart.aspx?cat=" + dt.Rows[9]["Image"];

    }
    public void BindCategory()
    {
        //DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        //gvCategory.DataSource = dsCategoryMasterList;
        //gvCategory.DataBind();
    }
    protected void gvCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
