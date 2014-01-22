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
using System.Text;

public partial class Cosubcart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //BindDatalist();
       //LblCategoryId.Text = Request.QueryString["Scat"];
       //LblSubcategoryId.Text = "30";

        if (this.IsPostBack == false)
        {

           // LblSubcategoryId.Text = Request.QueryString["Cscat"];
           //Session["SubCategoryId"] = LblSubcategoryId.Text;
           // LblCategoryId.Text = Session["CategoryId"].ToString();
            
        }
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CosubcategoryImage";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        //ObjCommand.Parameters.AddWithValue("@CategoryId", Convert.ToInt32(LblCategoryId.Text));
        //ObjCommand.Parameters.AddWithValue("@SubCategoryId", Convert.ToInt32(LblSubcategoryId.Text));
        //DataTable dt = new DataTable();

        ObjCommand.Parameters.AddWithValue("@CategoryId", 17);
        ObjCommand.Parameters.AddWithValue("@SubCategoryId", 30);
        //ObjCommand.Parameters.AddWithValue("@SubCategoryId", 11);
        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        DataSet dsCosubcategoryImage = new DataSet();
        ObjDataAdapter.Fill(dsCosubcategoryImage);

        DataCosubategoryList.DataSource = dsCosubcategoryImage;
        DataCosubategoryList.DataBind();
       
        //ObjDataAdapter.Fill(dt);

        ////Image1.ImageUrl = "~/Image/" + dt.Rows[0]["Image"];
        ////Image1.PostBackUrl = "~/Cart.aspx?Coscat=" + dt.Rows[0]["CosubcategoryId"];
        ////Image2.ImageUrl = "~/Image/" + dt.Rows[1]["Image"];
        ////Image2.PostBackUrl = "~/Cart.aspx?Coscat=" + dt.Rows[1]["CosubcategoryId"];
        ////Image3.ImageUrl = "~/Image/" + dt.Rows[2]["Image"];
        ////Image3.PostBackUrl = "~/Cart.aspx?Coscat=" + dt.Rows[2]["CosubcategoryId"];
        //Image4.ImageUrl = "~/Image/" + dt.Rows[3]["Image"];
        //Image4.PostBackUrl = "~/Cart.aspx?Coscat=" + dt.Rows[3]["CosubcategoryId"];

        //////System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //////sb.Append("");
        ////////string temp = "";
        //////for (int i =0;i<dt.Rows.Count;i++)
        //////{
        //////    //ImageButton img = new ImageButton();
        //////    ////img.Height = "200";
        //////    ////img.Width = "180";
        //////    //img.ImageUrl = "~/Image/" + dt.Rows[i]["Image"];
        //////    //img.PostBackUrl = "~/Cart.aspx?Cscat=" + dt.Rows[i]["CosubcategoryId"];

        //////    //sb.Append("<td>");
        //////    //sb.Append(img);
        //////    //sb.Append("</td>");

        //////    sb.Append("<td> <asp:ImageButton runat='server' ID='image_");
        //////    sb.Append(i.ToString());
        //////    sb.Append("' Height='200' Width='180' ImageUrl='~/Image/");
        //////    sb.Append(dt.Rows[i]["Image"].ToString());
        //////    sb.Append("' PostBackUrl='~/Cart.aspx?Cscat=");
        //////    sb.Append(dt.Rows[i]["CosubcategoryId"].ToString());
        //////    sb.Append("' /></td>");
        //////}
        
        
        //////ltImages.Text = sb.ToString();
    }
    //public void BindDatalist()
    //{
    //    DataSet dsSubCategoryImage = CProductMasterServices.ProductsubcategorycartList(17);
    //    ImageDataList.DataSource = dsSubCategoryImage;
    //    ImageDataList.DataBind();
    //}
}
