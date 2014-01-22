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

public partial class ProductMaster : System.Web.UI.Page
{
    //int i = 1;
    DataTable dt = new DataTable();
    //DataRow dr=new DataRow();
    //GridView gvProductlist = new GridView();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Type"].ToString() == "Admin")
            {
                if (this.IsPostBack == false)
                {
                    BindgvProdutlist();
                     /*BindCategoryName();
                     BindFabric();*/
                    //BindSubCategoryName();
                    //BindCosubcategoryName();

                    // DataRow dr = dt.NewRow();

                }
            }
            else
            {
                Response.Redirect("LoginMaster.aspx");

            }
            if (!Page.IsPostBack)
            {
                SetInitialRow();
            }


        }
        catch (Exception ex)
        {
            // Response.Redirect("LoginMaster.aspx");
            if (!Page.IsPostBack)
            {
                BindFabric();
                BindSuppliername();
                BindgvProdutlist();
                BindCategoryName();
                BindSubCategoryName(Convert.ToInt32(droplistcategory.SelectedValue));
                // BindCosubcategoryName(Convert.ToInt32(DropCosubcategoryList.SelectedValue));

            }
            // BindSubCategoryName(CategoryId);
            //BindCosubcategoryName();
            //DataTable dt = new DataTable();

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            GvStockList.DataSource = dt;
            // GvStockList.DataBind();
            BindSizeList();
            if (!Page.IsPostBack)
            {
                SetInitialRow();
            }

        }

    }
    public void BindgvProdutlist()
    {

        CProductMasterServices ObjCProductMasterServices = new CProductMasterServices();

        DataSet dsProductMasterMasterListGV = ObjCProductMasterServices.ProductMasterList();
        gvProductlist.DataSource = dsProductMasterMasterListGV;
        gvProductlist.DataBind();
    }
    public void BindSuppliername()
    {
        DataSet dsSuplierMasterList = CSupplierMasterServices.SupplierMasterList();
        Dropsupplierlist.DataSource = dsSuplierMasterList;
        Dropsupplierlist.DataTextField = "Suppliername";
        Dropsupplierlist.DataValueField = "SupplierId";
        Dropsupplierlist.DataBind();
    }
    public void BindCategoryName()
    {
        DataSet dsCategoryMasterList = CCategorymasterServices.CategorymasterList();
        droplistcategory.DataSource = dsCategoryMasterList;
        droplistcategory.DataTextField = "CategoryName";
        droplistcategory.DataValueField = "CategoryId";
        droplistcategory.DataBind();
    }
    public void BindSubCategoryName(int CategoryId)
    {
        DataSet dsSubcategoryMasterListbyCategoryId = CSubCategoryMasterServices.SubCategoryMasterListbyCategoryId(Convert.ToInt32(droplistcategory.SelectedValue));
        droplistsubcategory.DataSource = dsSubcategoryMasterListbyCategoryId;
        droplistsubcategory.Items.Clear();
        droplistsubcategory.DataTextField = "SubCategoryName";
        droplistsubcategory.DataValueField = "SubCategoryId";
        droplistsubcategory.DataBind();
    }
    public void BindCosubcategoryName(int SubCategoryId)
    {
        DataSet dsCosubcategoryListbySubcategoryId = CCoSubCategoryMasterServices.CosubcategoryListbySubcategoryId(Convert.ToInt32(droplistsubcategory.SelectedValue));
        DropCosubcategoryList.DataSource = dsCosubcategoryListbySubcategoryId;
        DropCosubcategoryList.DataTextField = "Cosubcategorydesc";
        DropCosubcategoryList.DataValueField = "CosubcategoryId";
        DropCosubcategoryList.DataBind();
    }
    public void BindFabric()
    {
        DataSet dsFabricMasterList = CFabricMasterServices.FabricMasterList();
        DropFabric.DataSource = dsFabricMasterList;
        DropFabric.Items.Clear();
        DropFabric.DataTextField = "Fabricname";
        DropFabric.DataValueField = "FabricId";
        DropFabric.DataBind();
    }

    public void BindSizeList()
    {
        // DataSet dsSizeMasterList = CSizeMasterServices.BindSizeMasterList();
        //DropDownList dl = (DropDownList)GvStockList.FindControl("DropSize");
        // dl.DataSource = dsSizeMasterList;
        // dl.DataTextField = "Desc";
        // dl.DataValueField = "SizeId";
        // dl.DataBind();



    }

    protected void gvProductlist_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        TblAddEdit.Visible = false;
        Butinsert.Visible = false;
        ButCancle.Visible = true;
        ButUpdate.Visible = true;
        //int  inReturnValue1=0;  
        //int intReturnValue2=0;

        int intProductId = Convert.ToInt32(gvProductlist.DataKeys[e.RowIndex].Value);
        CProductMaster ObjProduct = new CProductMaster(intProductId);

        if (ObjProduct.IsExit == true)
        {
            lblmsgbox.Text = "";
            TxtproductId.Text = ObjProduct.ProductId.ToString();
            droplistcategory.SelectedValue = ObjProduct.CategoryId.ToString();
            droplistsubcategory.SelectedValue = ObjProduct.SubCategoryId.ToString();

            //DroplistColour.SelectedValue = ObjProduct.Colour;
            TxtProductName.Text = ObjProduct.ProductName;
            Txtproductdescription.Text = ObjProduct.ProductDesc;
            //TxtPrice.Text = ObjProduct.Price.ToString();
            LblTotalQty.Text = ObjProduct.Qty.ToString();
            CheckStatus.Checked = ObjProduct.Status;

        }
        int intReturnValue = CProductMasterServices.ProductMasterDelete(Convert.ToInt32(TxtproductId.Text));

        //int intstockid = Convert.ToInt32(GvStockList.DataKeys[e.RowIndex].Value);
        //CStockMaster Objstockid = new CStockMaster(intstockid);
        //if (Objstockid.IsExit == true)
        //{
           
        //}

        foreach (GridViewRow gvrow in GvStockList.Rows)
        {

            HiddenField StockId1 = (HiddenField)gvrow.FindControl("hidStockId");
            int StockId = Convert.ToInt32(StockId1.Value);

            HiddenField PurchseId1 = (HiddenField)gvrow.FindControl("hidPurchaseId");
            int PurchseId = Convert.ToInt32(PurchseId1.Value);
            int intReturnValues = CStockMasterServices.StockMasterDelete(StockId);
            int inReturnValue1 = CPurchseMasterServices.PurchaseDelete(PurchseId);
        }
        //CPurchseMasterServices ObjCPurchseMasterServices = new CPurchseMasterServices();
        
       


        if (intReturnValue > 0)
        {
            lblmsgbox.Text = "Product Delete";
            BindgvProdutlist();
            TxtproductId.Text = "";
            Txtproductdescription.Text = "";
            TxtProductName.Text = "";
            TxtColor.Text = "";

            //TxtPrice.Text = "";
            LblTotalQty.Text = "";
        }
        else
        {
            lblmsgbox.Text = "Error occured while Deleting Data.";
        }


    }
    protected void gvProductlist_RowEditing(object sender, GridViewEditEventArgs e)
    {
        TblAddEdit.Visible = true;
        ButUpdate.Visible = true;
        ButCancle.Visible = true;
        Butinsert.Visible = false;
        int intProductId = Convert.ToInt32(gvProductlist.DataKeys[e.NewEditIndex].Value);
        //CProductMaster ObjProduct = new CProductMaster(intProductId);

        //if (ObjProduct.IsExit == true)
        //{
        //    TxtproductId.Text = ObjProduct.ProductId.ToString();
        //    droplistcategory.SelectedValue = ObjProduct.CategoryId.ToString();
        //    droplistsubcategory.SelectedValue = ObjProduct.SubCategoryId.ToString();
        //    //DroplistColour.SelectedValue = ObjProduct.Colour;
        //    TxtProductName.Text = ObjProduct.ProductName;
        //    TxtPrice.Text = ObjProduct.Price.ToString();
        //    Txtproductdescription.Text = ObjProduct.ProductDesc;
        //    LblTotalQty.Text = ObjProduct.Qty.ToString();
        //    //FileUpload1.FileName = ObjProduct.Image.ToString();
        //    CheckStatus.Checked = ObjProduct.Status;
        //}

        DataSet ds = CProductMasterServices.DisplayData(intProductId);
        {
            //TxtproductId.Text = intProductId.ToString();
            TxtproductId.Text = ds.Tables[0].Rows[0]["ProductId"].ToString();
            TxtProductName.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
            Txtproductdescription.Text = ds.Tables[0].Rows[0]["ProductDesc"].ToString();

            droplistcategory.SelectedValue = ds.Tables[0].Rows[0]["CategoryId"].ToString();

            CSubCategoryMaster ObjsubCategory = new CSubCategoryMaster(Convert.ToInt32(droplistcategory.SelectedValue));
            BindSubCategoryName(Convert.ToInt32(ObjsubCategory.CategoryId));

            
            //droplistsubcategory.SelectedValue = ds.Tables[0].Rows[0]["SubCategoryId"].ToString();

            droplistsubcategory.ClearSelection();
            droplistsubcategory.Items.FindByValue(ds.Tables[0].Rows[0]["SubCategoryId"].ToString()).Selected = true;

            CCoSubCategoryMaster ObjCosubCategory = new CCoSubCategoryMaster(Convert.ToInt32(droplistsubcategory.SelectedValue));
            BindCosubcategoryName(Convert.ToInt32(ObjCosubCategory.SubcategoryId));
            DropCosubcategoryList.ClearSelection();
            // DropCosubcategoryList.SelectedValue = ds.Tables[0].Rows[0]["CosubcategoryId"].ToString();
            DropCosubcategoryList.SelectedValue = ds.Tables[0].Rows[0]["CosubcategoryId"].ToString();
           // DropCosubcategoryList.SelectedValue = ds.Tables[0].Rows[0]["CosubcategoryId"].ToString();
            
            TxtColor.Text = ds.Tables[0].Rows[0]["Colour"].ToString();
            LblTotalQty.Text = ds.Tables[0].Rows[0]["Qty"].ToString();
            //TxtPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
            CheckStatus.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["Status"].ToString());
           // LblTotalAmount.Text = ds.Tables[2].Rows[0]["Total"].ToString();

            //Image1.ImageUrl = "~/Image/" + dt.Rows[0]["Image"];
            Image1.ImageUrl = "~/Image/" + ds.Tables[0].Rows[0]["Image"].ToString();
            string ImageFile = ds.Tables[0].Rows[0]["Image"].ToString();
            ViewState["Imagename"] = ImageFile;
            TxtAddLess.Text = ds.Tables[2].Rows[0]["Addless"].ToString();
            LblNetAmount.Text = ds.Tables[2].Rows[0]["Netamount"].ToString();



            //SetInitialRow();
            for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
            {
                if (i <= 0)
                    AddNewRowToGrid();
                DropDownList Size1 = (DropDownList)GvStockList.Rows[i].FindControl("DropSize");
                Size1.SelectedValue = ds.Tables[2].Rows[i]["SizeId"].ToString();

                TextBox qty = (TextBox)GvStockList.Rows[i].FindControl("TxtQty");
                qty.Text = ds.Tables[2].Rows[i]["PQty"].ToString();

                TextBox PRate = (TextBox)GvStockList.Rows[i].FindControl("TxtPRate");
                PRate.Text = ds.Tables[2].Rows[i]["PRate"].ToString();


                Label Amount = (Label )GvStockList.Rows[i].FindControl("LblAmount");
                Amount.Text = ds.Tables[2].Rows[i]["Amount"].ToString();

                HiddenField StockId = (HiddenField)GvStockList.Rows[i].FindControl("hidStockId");
                StockId.Value = ds.Tables[1].Rows[i]["StockId"].ToString();
                //StockId.Value = ds.Table[1].Rows[i]["StockId"].Tostring();
                HiddenField PurchaseId = (HiddenField)GvStockList.Rows[i].FindControl("hidPurchaseId");
                PurchaseId.Value = ds.Tables[2].Rows[i]["PurchseId"].ToString();
                
                
                string temp_ProductID = ds.Tables[2].Rows[i]["ProductId"].ToString();
                string temp_SizeID = ds.Tables[2].Rows[i]["SizeID"].ToString();

                DataRow[] mfetchrow;
                mfetchrow = ds.Tables[1].Select("ProductId=" + temp_ProductID + " AND SizeID=" + temp_SizeID);

                TextBox SRate = (TextBox)GvStockList.Rows[i].FindControl("TxtSRate");
                //SRate.Text = ds.Tables[1].Rows[i]["SRate"].ToString();
                if (mfetchrow.Length > 0)
                {
                    SRate.Text = mfetchrow[0]["SRate"].ToString();
                }
                //DataTable dt1=new DataTable();
                //dr = dt.NewRow();
                //            dr[1] = ((TextBox)Gridview1.Rows[i].Cells[1].FindControl("TextBox1")).Text;

                //           dr[2] = ((TextBox)Gridview1.Rows[i].Cells[2].FindControl("TextBox2")).Text;

                //           dr[3] = ((TextBox)Gridview1.Rows[i].Cells[3].FindControl("TextBox3")).Text;
                //           dt.Rows.Add(dr);
                //           dt.Rows.Add(dr);
                //           ViewState["Stock"] = dt;
                //           GvStockList.DataSource = dt;

                //           GvStockList.DataBind();

            }

            LblTotalAmount.Text = ds.Tables[2].Rows[0]["Total"].ToString();
            TxtPurchaseBillno.Text = ds.Tables[2].Rows[0]["PurchaseBillno"].ToString();
            TxtPurchaseBillDate.Text = Convert.ToDateTime(ds.Tables[2].Rows[0]["PurchaseBillDate"]).ToString();
        }
    }

    protected void Butinsert_Click(object sender, EventArgs e)
    {
        {
            TblAddEdit.Visible = true;
            ButUpdate.Visible = false;
            ButCancle.Visible = true;


            //    }
            //}
         
            int intReturnValue = CProductMasterServices.ProductMasterInsert(
               Convert.ToInt32(Dropsupplierlist.SelectedValue),
                Convert.ToInt32(droplistcategory.SelectedValue),
                Convert.ToInt32(droplistsubcategory.SelectedValue),
                Convert.ToInt32(DropCosubcategoryList.SelectedValue),
                TxtProductName.Text, Convert.ToInt32(DropFabric.SelectedValue),
                TxtColor.Text,
                //DroplistColour.SelectedValue,
                Convert.ToInt32(LblTotalQty.Text),
                Txtproductdescription.Text,
                //Convert.ToDouble(TxtPrice.Text),
                //strFileName,
                 ViewState["Imagename"].ToString(),
                CheckStatus.Checked);
            LblProductno.Text = intReturnValue.ToString();

            int intReturnValue1=0;
            foreach (GridViewRow gvrow in GvStockList.Rows)
            {
                DropDownList Size1 = (DropDownList)gvrow.FindControl("DropSize");
                int Size = Convert.ToInt32(Size1.Text);
                TextBox Qty1 = (TextBox)gvrow.FindControl("TxtQty");
                int Qty = Convert.ToInt32(Qty1.Text);
                TextBox PRate1 = (TextBox)gvrow.FindControl("TxtPRate");
                double PRate = Convert.ToDouble(PRate1.Text);
                TextBox SRate1 = (TextBox)gvrow.FindControl("TxtSRate");
                double SRate = Convert.ToDouble(SRate1.Text);
                Label Amount1 = (Label)gvrow.FindControl("LblAmount");
                decimal Amount = Convert.ToInt32(Amount1.Text);
                //TextBox PurchaseBillDate1 = (TextBox)gvrow.FindControl("TxtPBillDate");
                //DateTime PurchaseBillDate = Convert.ToDateTime(PurchaseBillDate1.Text);
                //TextBox ReturnStatus1 = (TextBox)gvrow.FindControl("TxtReturnStatus");
                //string purchaseId = GvStockList.DataKeys[gvrow.RowIndex][0].ToString();

                //int ReturnStatus = 0;
                //if (ReturnStatus1.Text != "")
                //{
                //    ReturnStatus = Convert.ToInt32(ReturnStatus1.Text);
                //}


                CPurchseMasterServices objCPurchseMasterServices = new CPurchseMasterServices();
                intReturnValue1 = objCPurchseMasterServices.PurchseEnteryInsert(Convert.ToInt32(LblProductno.Text), Convert.ToInt32(TxtPurchaseBillno.Text),
                    Convert.ToDateTime(TxtPurchaseBillDate.Text),
                    Size, Qty, PRate, Amount, Convert.ToDecimal(LblTotalAmount.Text), Convert.ToDecimal(TxtAddLess.Text), Convert.ToDecimal(LblNetAmount.Text));
                int intReturnValues = CStockMasterServices.StockMasterInsert(Convert.ToInt32(LblProductno.Text), Size, Qty, PRate, SRate);

            }

            if (intReturnValue > 0)
            {

                lblmsgbox.Text = "Insert Data";

                BindgvProdutlist();
                BindCategoryName();
                //BindgvProductlist();
                TxtproductId.Text = "";
                TxtProductName.Text = "";
                Txtproductdescription.Text = "";
                TxtColor.Text = "";
                TxtPurchaseBillno.Text = "";
                // TxtPrice.Text = "";
                LblTotalQty.Text = "";
                LblNetAmount.Text = "";
                LblTotalAmount.Text = "";
                TxtAddLess.Text = "";



            }

            else
            {
                lblmsgbox.Text = "Error occured while insering Product";
            }

            if (intReturnValue1 > 0)
            {
                SetInitialRow();
            }
            else
            {
                lblmsgbox.Text = "Error occured while insering Purchse";
            }

        }
    }
    protected void droplistcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        CSubCategoryMaster ObjsubCategory = new CSubCategoryMaster(Convert.ToInt32(droplistcategory.SelectedValue));
        BindSubCategoryName(Convert.ToInt32(ObjsubCategory.CategoryId));

        //CCoSubCategoryMaster ObjCosubCategory = new CCoSubCategoryMaster(Convert.ToInt32(droplistsubcategory.SelectedValue));
        // BindCosubcategoryName(Convert.ToInt32(ObjCosubCategory.SubcategoryId));
    }
    protected void droplistsubcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        CCoSubCategoryMaster ObjCosubCategory = new CCoSubCategoryMaster(Convert.ToInt32(droplistsubcategory.SelectedValue));
        BindCosubcategoryName(Convert.ToInt32(ObjCosubCategory.SubcategoryId));
    }
    protected void butAdd_Click(object sender, EventArgs e)
    {

    }
    protected void ButUpdate_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        ButUpdate.Visible = true;
        Butinsert.Visible = false;
        ButCancle.Visible = true;
        int intReturnvalue2 = 0;
        int intReturnValues3 = 0;
       
        int intReturnValue = CProductMasterServices.ProductMasterUpdate(
            Convert.ToInt32(TxtproductId.Text),
            Convert.ToInt32(Dropsupplierlist.SelectedValue),
            Convert.ToInt32(droplistcategory.SelectedValue),
            Convert.ToInt32(droplistsubcategory.SelectedValue),
            Convert.ToInt32(DropCosubcategoryList.SelectedValue),
            Convert.ToInt32(DropFabric.SelectedValue),
            TxtColor.Text,
            // DroplistColour.SelectedValue, 
            TxtProductName.Text,
            Txtproductdescription.Text,
            Convert.ToInt32(LblTotalQty.Text),
            //FileUpload1.FileName,
            ViewState["Imagename"].ToString(),
            CheckStatus.Checked);

        foreach (GridViewRow gvrow in GvStockList.Rows)
        {
            DropDownList Size1 = (DropDownList)gvrow.FindControl("DropSize");
            int Size = Convert.ToInt32(Size1.SelectedValue);
            TextBox Qty1 = (TextBox)gvrow.FindControl("TxtQty");
            int Qty = Convert.ToInt32(Qty1.Text);
            TextBox PRate1 = (TextBox)gvrow.FindControl("TxtPRate");
            double PRate = Convert.ToDouble(PRate1.Text);
            TextBox SRate1 = (TextBox)gvrow.FindControl("TxtSRate");
            double SRate = Convert.ToDouble(SRate1.Text);
            Label Amount1 = (Label)gvrow.FindControl("LblAmount");
            decimal Amount = Convert.ToDecimal(Amount1.Text);
            HiddenField StockId1 = (HiddenField)gvrow.FindControl("hidStockId");
            int StockId = Convert.ToInt32(StockId1.Value);
            HiddenField PurchseId1 = (HiddenField)gvrow.FindControl("hidPurchaseId");
            int PurchseId = Convert.ToInt32(PurchseId1.Value);
            //int PurchaseBillno = Convert.ToInt32(PurchaseBillno1.Text);
            //TextBox PurchaseBillDate1 = (TextBox)gvrow.FindControl("TxtPBillDate");
            //DateTime PurchaseBillDate=Convert.ToDateTime(PurchaseBillDate1.Text);
            //TextBox ReturnStatus1 = (TextBox)gvrow.FindControl("TxtReturnStatus");
            //string purchaseId = GvStockList.DataKeys[gvrow.RowIndex][0].ToString();
            
            CPurchseMasterServices objCPurchseMasterServices = new CPurchseMasterServices();

             intReturnvalue2 = objCPurchseMasterServices.PurchseUpdate
              (PurchseId,Convert.ToInt32(TxtPurchaseBillno.Text),Convert.ToDateTime(TxtPurchaseBillDate.Text), 
              Size, Qty, PRate,SRate,Amount,Convert.ToDecimal(LblTotalQty.Text),Convert.ToDecimal(TxtAddLess.Text),Convert.ToDecimal(LblTotalAmount.Text));

             CStockMasterServices ObjCStockMasterServices = new CStockMasterServices();
            
             intReturnValues3 = ObjCStockMasterServices.StockMasterUpdate(StockId,Convert.ToInt32(TxtproductId.Text), Size, Qty, PRate, SRate);

        }




        if (intReturnValue > 0)
        {
            lblmsgbox.Text = "Product Update";
            BindgvProdutlist();
            TxtproductId.Text = "";
            TxtProductName.Text = "";
            TxtColor.Text = "";
            LblTotalQty.Text = "";
            LblTotalQty.Text = "";
            LblNetAmount.Text = "";
            LblTotalAmount.Text = "";
            TxtAddLess.Text = "";

            CheckStatus.Checked = false;
        }

        else
        {
            lblmsgbox.Text = "Error occured while Updateing Product";
        }
        if (intReturnvalue2 > 0)
        {
            SetInitialRow();
            lblmsgbox.Text = "Update Purchse";
        }
        else
        {
            lblmsgbox.Text = "Error occured while Updateing Purchse";
        }
    }
    protected void CheckStatus_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void ButAdd_Click(object sender, EventArgs e)
    {
        TblAddEdit.Visible = true;
        Butinsert.Visible = true;
        ButCancle.Visible = true;
        ButUpdate.Visible = false;


    }
    protected void ButCancle_Click(object sender, EventArgs e)
    {
        TxtproductId.Text = "";
        Txtproductdescription.Text = "";
        //TxtPrice.Text = "";
        LblTotalQty.Text = "";
        Txtproductdescription.Text = "";
        TxtColor.Text = "";

    }
    protected void gvProductlist_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProductlist.PageIndex = e.NewPageIndex;
       BindgvProdutlist();

    }
    protected void TxtQty_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DroplistColour_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (DroplistColour.SelectedIndex == 1)
        //{
        // Color1.BackColor = System.Drawing.Color.FromName(DroplistColour.SelectedValue);
        //}
        //DroplistColour.SelectedValue.ToString();
    }
    protected void DroplistColour_TextChanged(object sender, EventArgs e)
    {

    }
    protected void SelectSize_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Addmore_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid();
    }
    private void SetInitialRow()
    {
        DataTable dt = new DataTable();

        DataRow dr = null;

        dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
        dt.Columns.Add(new DataColumn("Size", typeof(string)));
        dt.Columns.Add(new DataColumn("Qty", typeof(string)));
        dt.Columns.Add(new DataColumn("PRate", typeof(string)));
        dt.Columns.Add(new DataColumn("SRate", typeof(string)));
        dt.Columns.Add(new DataColumn("Amount", typeof(decimal)));
        dt.Columns.Add(new DataColumn("StockId", typeof(int)));
        dt.Columns.Add(new DataColumn("PurchseId", typeof(int)));
        
       
        //dt.Columns.Add(new DataColumn("PurchaseBillDate",typeof(DateTime)));
        //dt.Columns.Add(new DataColumn("ReturnStatus",typeof(string)));
        //dt.Columns.Add(new DataColumn("PurchseId", typeof(int)));
        dr = dt.NewRow();

        dr["RowNumber"] = 1;
        dr["Size"] = string.Empty;
        dr["Qty"] = string.Empty;
        dr["PRate"] = string.Empty;
        dr["SRate"] = string.Empty;
       dr["Amount"] =decimal.MinValue;
        dr["StockId"] = int.MinValue;
        dr["PurchseId"] = int.MinValue;

        // dr["PurchaseBillDate"] = DBNull.Value;
        //dr["ReturnStatus"] =string.Empty;
        // dr["PurchseId"] = 0;

        //DataRow dr= dt.NewRow();

        //dt.Rows.Add(totalsRow);
        dt.Rows.Add(dr);
        ViewState["StockDetail"] = dt;
        GvStockList.DataSource = dt;

        GvStockList.DataBind();

    }
    private void AddNewRowToGrid()
    {
        int RowIndex = 0;

        if (ViewState["StockDetail"] != null)
        {
            //DataSet ds = new DataSet();
            DataTable dt = (DataTable)ViewState["StockDetail"];
            DataRow dr = null;
            if (dt.Rows.Count > 0)
            {
                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    DropDownList Data1 = (DropDownList)GvStockList.Rows[RowIndex].Cells[1].FindControl("DropSize");

                    TextBox Data2 = (TextBox)GvStockList.Rows[RowIndex].Cells[2].FindControl("TxtQty");
                    //int p1 = Convert.ToInt32(TxtQty.Text);
                    TextBox Data3 = (TextBox)GvStockList.Rows[RowIndex].Cells[3].FindControl("TxtPRate");
                    //double p2 = Convert.ToDouble(TxtPRate.Text);
                    TextBox Data4 = (TextBox)GvStockList.Rows[RowIndex].Cells[4].FindControl("TxtSRate");
                    
                    Label Data5 = (Label)GvStockList.Rows[RowIndex].Cells[5].FindControl("LblAmount");
                    HiddenField Data6 = (HiddenField)GvStockList.Rows[RowIndex].Cells[6].FindControl("hidStockId");
                    HiddenField Data7 = (HiddenField)GvStockList.Rows[RowIndex].Cells[6].FindControl("hidPurchaseId");


                    //double Amount = (Data2.Text)(Data3.Text);

                    //TextBox Data6 = (TextBox)GvStockList.Rows[RowIndex].Cells[6].FindControl("TxtPBillDate");
                    //TextBox Data7 = (TextBox)GvStockList.Rows[RowIndex].Cells[7].FindControl("TxtReturnStatus");
                    dr = dt.NewRow();
                    dr["RowNumber"] = i + 1;



                    dt.Rows[i - 1]["Size"] = Data1.SelectedItem.Text;
                    dt.Rows[i - 1]["Qty"] = Data2.Text;
                    dt.Rows[i - 1]["PRate"] = Data3.Text;
                    dt.Rows[i - 1]["SRate"] = Data4.Text;
                    //dt.Rows[i - 1]["Amount"] =Data5.Text;
                    dt.Rows[i - 1]["Amount"] = DBNull.Value;
                    dt.Rows[i - 1]["StockId"] = DBNull.Value;
                    dt.Rows[i - 1]["PurchseId"] = DBNull.Value;

                    RowIndex++;
                    //if (Data6.Text != "")
                    //{
                    //    dt.Rows[i - 1]["PurchaseBillDate"] = Convert.ToDateTime(Data6.Text);
                    //}
                    //else if (Data6.Text == "")
                    //{
                    //    dt.Rows[i - 1]["PurchaseBillDate"] = DBNull.Value;
                    //}
                    //dt.Rows[i - 1]["ReturnStatus"] = Data7.Text;


                }
                dt.Rows.Add(dr);
                ViewState["StockDetail"] = dt;
                GvStockList.DataSource = dt;

                GvStockList.DataBind();


            }


            //GvStockList.Rows[RowIndex].Cells[5].FindControl("LblAmount");
            // GvStockList.FooterRow.Cells[1].Text = dt.Compute("sum(" + dt.Columns[3].ColumnName + ")", null).ToString();

        }
        else
        {
            Response.Write("ViewState is Null");
        }
        SetPriviousData();
    }
    private void SetPriviousData()
    {
        int RowIndex = 0;
        if (ViewState["StockDetail"] != null)
        {
            DataTable dt = (DataTable)ViewState["StockDetail"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DropDownList Data1 = (DropDownList)GvStockList.Rows[RowIndex].Cells[1].FindControl("DropSize");

                    TextBox Data2 = (TextBox)GvStockList.Rows[RowIndex].Cells[2].FindControl("TxtQty");
                    //int Qty = Convert.ToInt32(TxtQty.Text);
                    TextBox Data3 = (TextBox)GvStockList.Rows[RowIndex].Cells[3].FindControl("TxtPRate");
                    //int PRate = Convert.ToInt32(TxtPRate.Text);
                    TextBox Data4 = (TextBox)GvStockList.Rows[RowIndex].Cells[4].FindControl("TxtSRate");
                    Label Data5 = (Label)GvStockList.Rows[RowIndex].Cells[5].FindControl("LblAmount");
                    HiddenField Data6 = (HiddenField)GvStockList.Rows[RowIndex].Cells[6].FindControl("hidStockId");
                    //TextBox Data7 = (TextBox)GvStockList.Rows[RowIndex].Cells[7].FindControl("TxtReturnStatus");
                    HiddenField Data7 = (HiddenField)GvStockList.Rows[RowIndex].Cells[6].FindControl("hidPurchaseId");

                    Data1.Text = dt.Rows[i]["Size"].ToString();
                    Data2.Text = dt.Rows[i]["Qty"].ToString();
                    Data3.Text = dt.Rows[i]["PRate"].ToString();
                    Data4.Text = dt.Rows[i]["SRate"].ToString();
                    //
                    Data5.Text = dt.Rows[i]["Amount"].ToString();
                    Data6.Value = dt.Rows[i]["StockId"].ToString();
                    Data7.Value = dt.Rows[i]["PurchseId"].ToString();
                    LblTotalAmount.Text = (Data5.Text);

                    //if (dt.Rows[i]["PurchaseBillDate"] != null )
                    //{
                    //    if (dt.Rows[i]["PurchaseBillDate"].ToString() != "")
                    //    {
                    //        Data6.Text = dt.Rows[i]["PurchaseBillDate"].ToString();
                    //    }
                    //}
                    //Data7.Text = dt.Rows[i]["ReturnStatus"].ToString();
                    //if (dt.Rows[i]["ReturnStatus"] != null)
                    //{
                    //    if (dt.Rows[i]["ReturnStatus"].ToString() != "")
                    //    {
                    //        Data7.Checked = Convert.ToBoolean(dt.Rows[i]["ReturnStatus"]);
                    //    }
                    //}
                    

                    RowIndex++;
                    

                }
            }

        }

    }
    protected void DropCosubcategoryList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GvStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ButDelete_Click(object sender, EventArgs e)
    {
        //int RowIndex = 0;
        //GvStockList.Rows[RowIndex]
        // int abc= GvStockList.SelectedIndex;

        //int abc=  ((System.Web.UI.WebControls.GridViewRow)(((System.Web.UI.Control)(sender))._parent._parent))._rowIndex;

       // int abc = ((System.Web.UI.WebControls.GridViewRow)(((System.Web.UI.Control)(sender)).Parent.Parent)).RowIndex;
        //DataTable dt = (DataTable)ViewState["StockDetail"];
        //dt.Rows.RemoveAt(abc);
        //ViewState["StockDetail"] = dt;
        //GvStockList.DataSource = dt;
        //GvStockList.DataBind();
        if (GvStockList.Rows.Count > 1)
        {
            if (ViewState["StockDetail"] != null)
            {
                dt = (DataTable)ViewState["StockDetail"];
                int abc = ((System.Web.UI.WebControls.GridViewRow)(((System.Web.UI.Control)(sender)).Parent.Parent)).RowIndex;
                //int rowIndex=Convert.ToInt32(e.
                // dt.Rows[e.Ro].Delete();

            }
            dt.AcceptChanges();
            GvStockList.DataSource = dt;
            GvStockList.DataBind();
            ViewState["StockDetail"] = dt;
        }
    }

    protected void TxtColour_TextChanged(object sender, EventArgs e)
    {

    }
    protected void PreColor_TextChanged(object sender, EventArgs e)
    {

    }
    protected void butupload_Click(object sender, EventArgs e)
    {
        string strFileName = DateTime.Now.Ticks.ToString() + "_" + FileUpload1.FileName;
        string strFilePath = Server.MapPath("~/Image/" + strFileName);
        ViewState["Imagename"] = strFileName;
        FileUpload1.SaveAs(strFilePath);

        Image1.ImageUrl = "~/Image/" + strFileName;

    }
    protected void GvStockList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int i = 0;
        double PRate = 0;
        double SRate = 0;
        int Qty = 0;
        decimal Amount0;
        string Size;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //TextBox Data5 = (TextBox)GvStockList.Rows[i].Cells[5].FindControl("LblAmount");
            //LblTotalAmount.Text = Data5.ToString();
            //double gnd_Total = LblTotalAmount.Text;
            //gnd_Total = gnd_Total + RowTotal;

            string SizeId = e.Row.Cells[1].Text;
            string Prate = e.Row.Cells[2].Text;
            //DropDownList Data1 = (DropDownList)GvStockList.Rows[i].Cells[1].FindControl("DropSize");

            //TextBox Data2 = (TextBox)GvStockList.Rows[i].Cells[2].FindControl("TxtQty");
            ////int Qty = Convert.ToInt32(TxtQty.Text);
            //TextBox Data3 = (TextBox)GvStockList.Rows[i].Cells[3].FindControl("TxtPRate");
            ////int PRate = Convert.ToInt32(TxtPRate.Text);
            //TextBox Data4 = (TextBox)GvStockList.Rows[i].Cells[4].FindControl("TxtSRate");
            //Label Data5 = (Label)GvStockList.Rows[i].Cells[5].FindControl("LblAmount");
            //HiddenField Data6 = (HiddenField)GvStockList.Rows[i].Cells[6].FindControl("hidStockId");
            ////TextBox Data7 = (TextBox)GvStockList.Rows[RowIndex].Cells[7].FindControl("TxtReturnStatus");
            //HiddenField Data7 = (HiddenField)GvStockList.Rows[i].Cells[6].FindControl("hidPurchaseId");

        }


    }

    protected void TxtPRate_TextChanged(object sender, EventArgs e)
    {
        decimal Sum = 0;
        int _Qty = 0;
        DataTable dt = (DataTable)ViewState["StockDetail"];
        ViewState["StockDetail"] = dt;
       
        //(Data5.Text) = (Convert.ToDouble(Data2.Text) * Convert.ToDouble(Data3.Text)).ToString();

        foreach (GridViewRow gvrow in GvStockList.Rows)
        {
            TextBox Data2 = (TextBox)gvrow.FindControl("TxtQty");
            //int Qty = Convert.ToInt32(TxtQty.Text);
            TextBox Data3 = (TextBox)gvrow.FindControl("TxtPRate");
            //int PRate = Convert.ToInt32(TxtPRate.Text);
            Label Data5 = (Label)gvrow.FindControl("LblAmount");

            (Data5.Text) = (Convert.ToDouble(Data2.Text) * Convert.ToDouble(Data3.Text)).ToString();

            //LblTotalAmount.Text = Data5.Text;
            // Sum = LblTotalAmount.Text;
            _Qty=_Qty+Convert.ToInt32(Data2.Text);
            Sum = Sum + Convert.ToDecimal(Data5.Text);
            


        }
        LblTotalQty.Text=_Qty.ToString();
        LblTotalAmount.Text = Sum.ToString();
        //foreach (GridViewRow gvrow in GvStockList.Rows)
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    //TextBox Data5 = (TextBox)gvrow.FindControl("LblAmount");

            //    //(Data5.Text) = (Convert.ToDouble(Data2.Text) * Convert.ToDouble(Data3.Text)).ToString();
            //    TextBox Data5 = (TextBox)GvStockList.Rows[i].Cells[5].FindControl("LblAmount");

            //   Sum = Sum + Convert.ToDouble(Data5.Text);
            //   //double Sum = Data5.Text;

            //    i++;
            //    //LblTotalAmount.Text = Sum + LblTotalAmount.Text;
                
            //   // LblTotalAmount.Text = (LblTotalAmount.Text);
            //    // Sum = LblTotalAmount.Text;
            //}
            //LblTotalAmount.Text = Sum.ToString();
    }


    protected void TxttotalAmt_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TxtAddLess_TextChanged(object sender, EventArgs e)
    {
     (LblNetAmount.Text) = (Convert.ToDecimal(LblTotalAmount.Text) + Convert.ToDecimal(TxtAddLess.Text)).ToString();
    }
    protected void GvStockList_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}