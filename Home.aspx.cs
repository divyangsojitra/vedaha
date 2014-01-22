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

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        ObjConnection.Open();

        SqlCommand ObjCommand = new SqlCommand();
        ObjCommand.Connection = ObjConnection;
        ObjCommand.CommandText = "CategoryImage";
        ObjCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();

        SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        ObjDataAdapter.Fill(dt);

        Image1.ImageUrl = "~/Image/" + dt.Rows[0]["Image"];
        Image1.PostBackUrl = "~/Subcart.aspx?Scat=" + dt.Rows[0]["CategoryId"];
        Image2.ImageUrl = "~/Image/" + dt.Rows[1]["Image"];
        Image2.PostBackUrl = "~/Subcart.aspx?Scat=" + dt.Rows[1]["CategoryId"];
        Image3.ImageUrl = "~/Image/" + dt.Rows[2]["Image"];
        Image3.PostBackUrl = "~/Subcart.aspx?Scat=" + dt.Rows[2]["CategoryId"];
        Image4.ImageUrl = "~/Image/" + dt.Rows[3]["Image"];
        Image4.PostBackUrl = "~/Subcart.aspx?Scat=" + dt.Rows[3]["CategoryId"];


    }
}
