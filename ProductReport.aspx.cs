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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Web;
using System.Collections.Generic;
//namespace CrystalReport1
  
   

public partial class Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void BindgvProductlist()
    {
        DataSet dsProductMasterList = CProductMasterServices.ProductMasterList();
       // ListBox1.AppendDataBoundItems = true;

        ListBox1.DataSource = dsProductMasterList;
        //GvReport.DataSource = dsProductMasterList;
        //GvReport.DataBind();
        // this.ListBox1.DataValueField
       
       // ListBox1.DataTextField =dsProductMasterList.ToString();
        //ListBox1.Items.Add(new ListItem( dsProductMasterList));


        ListBox1.DataTextField = "Productname";
        ListBox1.DataValueField = "ProductId";
        ListBox1.DataBind();
        
    }
    private void BindCategory()
    {
        DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        ListBox1.DataSource = dsCategoryMasterList;
        ListBox1.DataTextField = "CategoryName";
        ListBox1.DataValueField = "CategoryId";
        ListBox1.DataBind();
    }
    private void BindSubCategory()
    {
        DataSet dsSubCategoryMasterList = CSubCategoryMasterServices.SubCategoryMasterList();
        ListBox1.DataSource = dsSubCategoryMasterList;
        ListBox1.DataTextField = "SubCategoryName";
        ListBox1.DataValueField="SubCategoryId";
        ListBox1.DataBind();
    }
    private void BindCosubcategory()
    {
        DataSet dsCosubcategoryMasterList = CCoSubCategoryMasterServices.CosubcategoryList();
        ListBox1.DataSource = dsCosubcategoryMasterList;
        ListBox1.DataTextField = "Cosubcategorydesc";
        ListBox1.DataValueField = "CosubcategoryId";
        ListBox1.DataBind();
    }
    private void BindGvReport()
    {
        DataSet dsPROC_ProductMasterList = CProductMasterServices.BindReport(Lblmsg.Text, Lblsub.Text, Lblcosub.Text, Lblpro.Text);
        GvReport.DataSource = dsPROC_ProductMasterList;
        GvReport.DataBind();
    }
    protected void ButSearch_Click(object sender, EventArgs e)
    {
        int listcount = 0;
        string str = string.Empty;
        Lblmsg.Text = "";
        Lblsub.Text = "";
        Lblcosub.Text = "";
        Lblpro.Text = "";
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected == true)
            {
                listcount = listcount + 1;
                if (Dropparameter.Text.ToUpper() == "CATEGORY")
                    Lblmsg.Text = Lblmsg.Text + ListBox1.Items[i].Text + "','";
                else if (Dropparameter.Text == "SUBCATEGORY")
                    Lblsub.Text = Lblsub.Text + ListBox1.Items[i].Text + "','";
                else if (Dropparameter.Text == "COSUBCATEGORY")
                    Lblcosub.Text = Lblcosub.Text + ListBox1.Items[i].Text + "','";
                else if (Dropparameter.Text == "PRODUCTNAME")
                    Lblpro.Text = Lblpro.Text + ListBox1.Items[i].Text + "','";


            }
        }
        //str+=i.ToString();
        //Lbltext.Text = i.ToString();


        if (Lblmsg.Text.Length > 0)
        {
            Lblmsg.Text = Lblmsg.Text.Substring(0, (Lblmsg.Text.Length - 3));
            Lblmsg.Text = Lblmsg.Text.ToUpper();
        }
        if (Lblsub.Text.Length > 0)
        {
            Lblsub.Text = Lblsub.Text.Substring(0, (Lblsub.Text.Length - 3));
            Lblsub.Text = Lblsub.Text.ToUpper();
        }

        if (Lblcosub.Text.Length > 0)
        {
            Lblcosub.Text = Lblcosub.Text.Substring(0, (Lblcosub.Text.Length - 3));
            Lblcosub.Text = Lblcosub.Text.ToUpper();
        }

        if (Lblpro.Text.Length > 0)
        {
            Lblpro.Text = Lblpro.Text.Substring(0, (Lblpro.Text.Length - 3));
            Lblpro.Text = Lblpro.Text.ToUpper();
        }



        BindGvReport();
       
    }
    protected void Dropparameter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Dropparameter.SelectedIndex == 1)
        {

            BindgvProductlist();
        }
        else if (Dropparameter.SelectedIndex == 2)
        {

            BindCategory();
        }
        else if (Dropparameter.SelectedIndex == 3)
        {
            BindSubCategory();
        }
        else if (Dropparameter.SelectedIndex == 4)
        {
            BindCosubcategory();
        }


        //switch (Dropparameter.SelectedIndex)
        //{
        //    case (Dropparameter.SelectedIndex == 1):
        //        BindgvProductlist();
        //        break;
        //    case (Dropparameter.SelectedIndex == 2):
        //        BindCategory();
        //        break;
        //}
    }
    protected void ButPrint_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ProductRep.aspx");
        //ProductReport rep = new ProductReport();
        
        //DataSet dsPROC_ProductMasterList = CProductMasterServices.BindReport(Lblmsg.Text, Lblsub.Text, Lblcosub.Text, Lblpro.Text);
       
        //GvReport.DataSource = dsPROC_ProductMasterList;
        //GvReport.DataBind();
        
       
        //CrystalReport1 Rep = new CrystalReport1();
        //CrystalReports rep=new CrystalReports();
       //ReportDocument crystalReport = new ReportDocument();
        //////SqlConnection ObjConnection = new SqlConnection(Common.C_ConnectionString);
        //////ObjConnection.Open();
        
        //////SqlCommand ObjCommand = new SqlCommand();
        //////ObjCommand.Connection = ObjConnection;
        //////ObjCommand.CommandText = "PROC_ProductMasterList";
        //////ObjCommand.CommandType = CommandType.StoredProcedure;
        //////ObjCommand.Parameters.AddWithValue("@P_IN_CATEGORY_lIST", Lblmsg.Text);
        //////ObjCommand.Parameters.AddWithValue("@P_IN_SUBCATEGORY_LIST", Lblsub.Text);
        //////ObjCommand.Parameters.AddWithValue("@P_IN_COSUBCATEGORY_LIST", Lblcosub.Text);
        //////ObjCommand.Parameters.AddWithValue("@P_IN_PRODUCTNAME", Lblpro.Text);

        //////SqlDataAdapter ObjDataAdapter = new SqlDataAdapter(ObjCommand);
        //////DataSet dsPROC_ProductMasterList = new DataSet();

        //////ObjDataAdapter.Fill(dsPROC_ProductMasterList);
        ////////Rep.SetDataSource(dsPROC_ProductMasterList);
        ////////CrystalReportViewer1.ReportSource =Rep;
        //Response.Redirect("ProductRep.aspx");
        ReportDocument Rep = new ReportDocument();
        Rep.Load(Server.MapPath("CrystalReport1.rpt"));
       // Rep.SetDataSource(dsPROC_ProductMasterList);
        string s=@"ABC\SQLEXPRESS";
        Rep.SetDatabaseLogon("sa", "123456",s,"shopping");
        Rep.SetParameterValue("@P_IN_CATEGORY_lIST", Lblmsg.Text);
        Rep.SetParameterValue("@P_IN_SUBCATEGORY_LIST", Lblsub.Text);
        Rep.SetParameterValue("@P_IN_COSUBCATEGORY_LIST", Lblcosub.Text);
        Rep.SetParameterValue("@P_IN_PRODUCTNAME", Lblpro.Text);
       // Response.Redirect("ProductRep.aspx");
        CrystalReportViewer1.ReportSource = Rep;


        //ReportDocument reportdocument = new ReportDocument();
        //reportdocument.Load(Server.MapPath("CrystalReport.rpt"));
        //reportdocument.SetDatabaseLogon("", "", "SureshDasari", "MySampleDB");
        //reportdocument.SetParameterValue("Username", txtUserName.Text);
        //CrystalReportViewer1.ReportSource = reportdocument;


    }
    protected void AddMore_Click(object sender, EventArgs e)
    {
        int rowCount = 0;
        rowCount = Convert.ToInt32(Session["clicks"]);

        rowCount++;
        Session["clicks"] = rowCount;

        for (int i = 0; i < rowCount; i++)
        {
            DropDownList Dropparameter = new DropDownList();
            DropDownList DropCondition = new DropDownList();
            ListBox ListBox1 = new ListBox();

            Dropparameter.ID = "Dropparameter" + i.ToString();
            DropCondition.ID = "DropCondition" + i.ToString();
            ListBox1.ID = "ListBox1" + i.ToString();

            //dropDownList.Items.Add(new ListItem("Item1"));
            Dropparameter.Items.Add(new ListItem("--Select--"));
            Dropparameter.Items.Add(new ListItem("PRODUCTNAME"));

            Dropparameter.Items.Add(new ListItem("CATEGORY"));
            Dropparameter.Items.Add(new ListItem("SUBCATEGORY"));
            Dropparameter.Items.Add(new ListItem("COSUBCATEGORY"));
           // Dropparameter_SelectedIndexChanged(object sender, EventArgs e);
            

            DropCondition.Items.Add(new ListItem("And"));
            DropCondition.Items.Add(new ListItem("OR"));

            Panel1.Controls.Add(Dropparameter);
            Panel1.Controls.Add(DropCondition);
            Panel1.Controls.Add(ListBox1);
        }
    }
    protected void ButCount_Click(object sender, EventArgs e)
    {
        //int totalitem = ListBox1.Items.Count;
        //Lblmsg.Text = "Listbox total Item:" + totalitem.ToString();

        int listcount = 0;
        string str = string.Empty;
        Lblmsg.Text ="";
        Lblsub.Text ="";
        Lblcosub.Text="";
        Lblpro.Text ="";
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected == true)
            {
                listcount = listcount + 1;
                if (Dropparameter.Text.ToUpper() == "Category")
                    Lblmsg.Text = Lblmsg.Text + ListBox1.Items[i].Text + "','";
                else if (Dropparameter.Text == "SubCategory")
                    Lblsub.Text = Lblsub.Text + ListBox1.Items[i].Text + "','";
                else if (Dropparameter.Text == "Cosubcategory")
                    Lblcosub.Text = Lblcosub.Text + ListBox1.Items[i].Text + "','";
                else if (Dropparameter.Text == "ProductName")
                    Lblpro.Text = Lblpro.Text + ListBox1.Items[i].Text + "','";


            }
        }
            //str+=i.ToString();
            //Lbltext.Text = i.ToString();
        
        
        if( Lblmsg.Text.Length > 0 )
        {
                Lblmsg.Text = Lblmsg.Text.Substring(0,(Lblmsg.Text.Length - 3));
                Lblmsg.Text = Lblmsg.Text.ToUpper();
        }
        if (Lblsub.Text.Length > 0)
        {
            Lblsub.Text = Lblsub.Text.Substring(0, (Lblsub.Text.Length - 3));
            Lblsub.Text = Lblsub.Text.ToUpper();
        }

        if (Lblcosub.Text.Length > 0)
        {
            Lblcosub.Text = Lblcosub.Text.Substring(0, (Lblcosub.Text.Length - 3));
            Lblcosub.Text = Lblcosub.Text.ToUpper();
        }

        if (Lblpro.Text.Length > 0)
        {
            Lblpro.Text = Lblpro.Text.Substring(0, (Lblpro.Text.Length - 3));
            Lblpro.Text = Lblpro.Text.ToUpper();
        }

    }
    protected void CrystalReportViewer1_Init(object sender, EventArgs e)
    {

    }
}

