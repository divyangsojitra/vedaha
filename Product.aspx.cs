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

public partial class Product : System.Web.UI.Page
{
    DataTable dt = new DataTable();
   // DataRow dr; //= dt.NewRow();
   
    int i=1;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        

        DataRow dr = dt.NewRow();
        dt.Rows.Add(dr);
       
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void ButAddmore_Click(object sender, EventArgs e)
    {
       
        //{
        //    dt.Rows.Add(new DataRow("newRow"));
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();
        //}

       
        DataRow dr = dt.NewRow();
        dt.Rows.Add(dr);
       // dt = new DataTable();
        //dt.Columns.Add("RowNumber");
       // dr["RowNumber"] = dt.Rows.Count + 1;

        //dt.Rows.Add(dr);
        dt.NewRow();
       
      // DataRow dr1 = dt.NewRow();

        //foreach (DataRow dr in dt.Rows)
       //for(int i=1;i<9;i++)
       // {
       //                 //dr[] =i.ToString();
       //    dt.Rows.Add(dr);
       //   // dt.Rows.Add(dr1);
       //   // dt.Rows.Add(dr1);
       //     dr= dt.NewRow();
            

       //     //dt.Rows.Add();
             
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
             //i++;
        //}

    }
    protected void Add_Click(object sender, EventArgs e)
    {

        //foreach (GridViewRow row in GridView2.Rows)
        //{
        //    var dataRow = dt.NewRow();
        //    for (int i = 0; i < GridView2.Columns.Count; i++)
        //    {
        //        dataRow[i] = row.Cells[i].Text;
        //    }
        //    dt.Rows.Add(dataRow);
        //}
    }
}
