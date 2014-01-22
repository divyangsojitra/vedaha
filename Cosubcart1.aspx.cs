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

public partial class Cosubcart1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {

            LblSubcategoryId.Text = Request.QueryString["Cscat"];
            Session["SubCategoryId"] = LblSubcategoryId.Text;
            LblCategoryId.Text = Session["CategoryId"].ToString();
            


        }
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryImage";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        ObjCommand.Parameters.AddWithValue("@CategoryId", Convert.ToInt32(LblCategoryId.Text));
        ObjCommand.Parameters.AddWithValue("@SubCategoryId", Convert.ToInt32(LblSubcategoryId.Text));
        //DataTable dt = new DataTable();

        //ObjCommand.Parameters.AddWithValue("@CategoryId",17);
        //ObjCommand.Parameters.AddWithValue("@SubCategoryId",30);

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCosubcategoryImage = new DataSet();
        ObjDataAdapter.Fill(dsCosubcategoryImage);

        DataCosubategoryList.DataSource = dsCosubcategoryImage;
        DataCosubategoryList.DataBind();

        

    }
}
