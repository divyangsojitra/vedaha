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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            SetInitialRow();

        }

    }
    private void SetInitialRow()
    {

        DataTable dt = new DataTable();

        DataRow dr = null;

        dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));

        dt.Columns.Add(new DataColumn("Column1", typeof(string)));

        dt.Columns.Add(new DataColumn("Column2", typeof(string)));

        dt.Columns.Add(new DataColumn("Column3", typeof(string)));

        dr = dt.NewRow();

        dr["RowNumber"] = 1;

        dr["Column1"] = string.Empty;

        dr["Column2"] = string.Empty;

        dr["Column3"] = string.Empty;

        dt.Rows.Add(dr);

        //dr = dt.NewRow();



        //Store the DataTable in ViewState

        ViewState["CurrentTable"] = dt;



        Gridview1.DataSource = dt;

        Gridview1.DataBind();

    }
    private void AddNewRowToGrid()
    {

        int rowIndex = 0;



        if (ViewState["CurrentTable"] != null)
        {

            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];

            DataRow drCurrentRow = null;

            if (dtCurrentTable.Rows.Count > 0)
            {

                for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {

                    //extract the TextBox values

                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("TextBox1");

                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("TextBox2");

                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("TextBox3");



                    drCurrentRow = dtCurrentTable.NewRow();

                    drCurrentRow["RowNumber"] = i + 1;



                    dtCurrentTable.Rows[i - 1]["Column1"] = box1.Text;

                    dtCurrentTable.Rows[i - 1]["Column2"] = box2.Text;

                    dtCurrentTable.Rows[i - 1]["Column3"] = box3.Text;



                    rowIndex++;

                }

                dtCurrentTable.Rows.Add(drCurrentRow);

                ViewState["CurrentTable"] = dtCurrentTable;



                Gridview1.DataSource = dtCurrentTable;

                Gridview1.DataBind();

            }

        }

        else
        {

            Response.Write("ViewState is null");

        }



        //Set Previous Data on Postbacks
        //SetPreviousData(CurrentTable);
        SetPreviousData();

    }
    private void SetPreviousData()
    {

        int rowIndex = 0;

        if (ViewState["CurrentTable"] != null)
        {

            DataTable dt = (DataTable)ViewState["CurrentTable"];

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("TextBox1");

                    TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("TextBox2");

                    TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("TextBox3");



                    box1.Text = dt.Rows[i]["Column1"].ToString();

                    box2.Text = dt.Rows[i]["Column2"].ToString();

                    box3.Text = dt.Rows[i]["Column3"].ToString();



                    rowIndex++;

                }

            }

        }

    }
    
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid();
    }
    protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable CurrentTable = new DataTable();
        int RowIndex = e.RowIndex;
        CurrentTable = (DataTable)ViewState["CurrentTable"];
        CurrentTable.Rows.RemoveAt(e.RowIndex);
        SetPreviousData();
    }
    protected void Gridview1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DeleteRowHandler(object sender,CommandEventArgs e)
    {
        GridViewRow row=((GridViewRow)((LinkButton)sender).Parent.Parent);
        //DataTable dt = new DataTable();
        DataTable dt = (DataTable)ViewState["CurrentTable"];
        dt.Rows.RemoveAt(row);
        ViewState["CurrentTable"] = dt;
        Gridview1.DataSource = dt;
        Gridview1.DataBind();
        
       
        //DataRow dr=null;
        //dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));

        //dt.Columns.Add(new DataColumn("Column1", typeof(string)));

        //dt.Columns.Add(new DataColumn("Column2", typeof(string)));

        //dt.Columns.Add(new DataColumn("Column3", typeof(string)));
        //for (int i = 1; i <Gridview1.Rows.Count; i++)
        //{
        //    dr=dt.NewRow();
        //            dr[1] = ((TextBox)Gridview1.Rows[i].Cells[1].FindControl("TextBox1")).Text;

        //            dr[2] = ((TextBox)Gridview1.Rows[i].Cells[2].FindControl("TextBox2")).Text;

        //            dr[3] = ((TextBox)Gridview1.Rows[i].Cells[3].FindControl("TextBox3")).Text;
        //            dt.Rows.Add(dr);
        //}
        //dt.Rows.RemoveAt(row.RowIndex);
        //ViewState["CurrentTable"]=dt;
        //Gridview1.DataSource=dt;
        //Gridview1.DataBind();
    }
}
