<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductMaster.aspx.cs" MasterPageFile="~/AdminMaster.master"
    Title="Untitl" Inherits="ProductMaster" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<%--<head id="Head1" runat="server">
    <asp:Content ID="Content2" runat="server" ContentPlaceHolderID="con1">
    </asp:Content>

</head>--%>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblmsgbox" Text=""></asp:Label>
                    <asp:Label runat="server" ID="LblProductno" Text=""></asp:Label>
                    <table runat="server" id="TblAddEdit" visible="false" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblproductcode" Text="ProductId" Visible="False"></asp:Label>
                            </td>
                            <td  >
                                <asp:TextBox runat="server" ID="TxtproductId" Text="" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="PurchaseBillno" Text="PurchaseBillno"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="TxtPurchaseBillno" Text=""></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="LblPurchaseBillDate" Text="PurchaseBillDate"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="TxtPurchaseBillDate" Text=""></asp:TextBox>
                                <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="TxtPurchaseBillDate">
                                                        </asp:CalendarExtender>
                            </td>
                        </tr>
                        <tr>
                            <td  >
                                <asp:Label runat="server" ID="LblSuppliername" Text="Suppliername"></asp:Label>
                            </td>
                            <td  >
                                <asp:DropDownList runat="server" ID="Dropsupplierlist">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td    >
                                <asp:Label runat="server" ID="lblCategory" Text="Category"></asp:Label>
                            </td>
                            <td   >
                                <asp:DropDownList ID="droplistcategory" runat="server" OnSelectedIndexChanged="droplistcategory_SelectedIndexChanged"
                                    AutoPostBack="true" Height="16px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td   >
                                <asp:Label runat="server" ID="lblSubcategory" Text="SubCategory Name"></asp:Label>
                            </td>
                            <td  >
                                <asp:DropDownList ID="droplistsubcategory" runat="server" OnSelectedIndexChanged="droplistsubcategory_SelectedIndexChanged"
                                    AutoPostBack="true">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td   >
                                <asp:Label runat="server" ID="LblCosubcategory" Text="Cosubcategory Name"></asp:Label>
                            </td>
                            <td  >
                                <asp:DropDownList ID="DropCosubcategoryList" runat="server" OnSelectedIndexChanged="DropCosubcategoryList_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td   >
                                <asp:Label runat="server" ID="lblColour" Text="Colours"></asp:Label>
                            </td>
                            <td  >
                                <%--<asp:ColorPickerExtender ID="ColorPickerExtender1" runat="server" TargetControlID="TxtColour">
                                </asp:ColorPickerExtender>--%>
                                <asp:TextBox ID="TxtColor" runat="server" Text=""></asp:TextBox>
                                <asp:TextBox ID="PreColor" runat="server" Text="" OnTextChanged="PreColor_TextChanged"
                                    Width="31px"></asp:TextBox>
                                <asp:PopupControlExtender ID="PopupControlExtender1" runat="server" TargetControlID="TxtColor"
                                    PopupControlID="popupPanel" Position="Bottom">
                                </asp:PopupControlExtender>
                                <%--<asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
--%>

                                <script type="text/javascript">
    function setColor(source) {
    debugger;
        document.getElementById('<%= PreColor.ClientID %>').style.backgroundColor = source.style.backgroundColor;
        document.getElementById('<%= TxtColor.ClientID %>').innerText = source.colorCode; 
        //alert( source.colorCode);
        var colorname = source.style.backgroundColor;
        if(colorname == "#000000")
        {
        document.getElementById('<%= TxtColor.ClientID %>').innerText="Black";
        }
        //alert(source.colorCode);
    }
                                </script>

                                <asp:Panel ID="popupPanel" runat="server" Height="208px" >
                                    <table>
                                        <tr>
                                            <td style="background-color: #000000; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#000000">
                                            </td>
                                            <%--<td style="background-color: #FF0000; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#FF0000">
                                            </td>
                                            <td style="background-color: #00FF00; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#00FF00">
                                            </td>
                                            <td style="background-color: #0000FF; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#0000FF">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="background-color: #FFFF00; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#FFFF00">
                                            </td>
                                            <td style="background-color: #00FFFF; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#00FFFF">
                                            </td>
                                            <td style="background-color: #FF00FF; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#FF00FF">
                                            </td>
                                            <td style="background-color: #C0C0C0; width: 10px; height: 10px;" onclick="setColor(this);"
                                                colorcode="#C0C0C0">
                                            </td>--%>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td  >
                                <asp:Label runat="server" ID="Label1" Text="Product Name"></asp:Label>
                            </td>
                            <td  >
                                <asp:TextBox ID="TxtProductName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td   >
                                <asp:Label runat="server" ID="LblProductId11" Text="Fabric"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropFabric" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td  >
                                <asp:Label runat="server" ID="lblproductDescription" Text="Product Description"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="Txtproductdescription" Text=""></asp:TextBox>
                            </td>
                        </tr>
                       
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="lblimage" Text="Image"></asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Image runat="server" ID="Image1" Width="100" Height="100" />
                            </td>
                            <td>
                                <asp:Button runat="server" ID="butupload" Text="UpLoad" CommandName="Upload" 
                                    onclick="butupload_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CheckStatus" runat="server" OnCheckedChanged="CheckStatus_CheckedChanged"
                                    Text="Is Status Active?" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="10">
                            <table width="100%">
                            <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Button runat="server" ID="Addmore" Text="Add New Row" OnClick="Addmore_Click" />
                                        <asp:GridView runat="server" ID="GvStockList" AutoGenerateColumns="False" OnSelectedIndexChanged="GvStockList_SelectedIndexChanged"
                                            Style="margin-right: 0px" onrowdatabound="GvStockList_RowDataBound" 
                                            onrowdeleting="GvStockList_RowDeleting" >
                                            <Columns>
                                                <asp:TemplateField HeaderText="Row Number">
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("RowNumber") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("RowNumber") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Size">
                                                    <ItemTemplate>
                                                        <asp:DropDownList runat="server" ID="DropSize" DataSourceID="SqlDataSource1" DataTextField="Desc"
                                                            DataValueField="SizeId">
                                                        </asp:DropDownList>
                                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:shoppingConnectionString %>"
                                                            SelectCommand="SELECT * FROM [SizeMaster]"></asp:SqlDataSource>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Qty" >
                                                    <ItemTemplate>
                                                        <asp:TextBox runat="server" ID="TxtQty" Text="" Width="50"></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="PRate">
                                                    <ItemTemplate>
                                                        <asp:TextBox runat="server" ID="TxtPRate" Text="" 
                                                            ontextchanged="TxtPRate_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Sell Rate">
                                                    <ItemTemplate>
                                                        <asp:TextBox runat="server" ID="TxtSRate" Text="" Width="70"></asp:TextBox>
                                                        
                                                        <%--<asp:HiddenField ID="hidPurchaseId"  runat="server"/>--%>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                
                                                <asp:TemplateField HeaderText="Amount">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" ID="LblAmount" Text="" Width="70"></asp:Label>
                                                        <asp:HiddenField ID="hidStockId"  runat="server"/>
                                                        <asp:HiddenField ID="hidPurchaseId"  runat="server"/>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <%--<asp:TemplateField>
                                                    <ItemTemplate>
                                                    
                                                    </ItemTemplate>
                                                </asp:TemplateField>--%>
                                                <asp:TemplateField HeaderText="Delete">
                                                    <ItemTemplate>
                                                        <asp:Button runat="server" ID="ButDelete" Text="Delete" CommandName="Delete" OnClick="ButDelete_Click" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                
                                            </Columns>
                                        </asp:GridView>
                                        <table>
                                             <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="lblTotalQty1" Text="Qty"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="LblTotalQty" Text=""></asp:Label>
                                                    <%--<asp:TextBox ID="TxtQty" runat="server" OnTextChanged="TxtQty_TextChanged"></asp:TextBox>--%>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="LbltotalAmount1" Text="TotalAmount"></asp:Label>
                                                </td>
                                                <td>
                                                    <%--<asp:TextBox runat="server" ID="TxttotalAmt" Text=""  
                                                        ontextchanged="TxttotalAmt_TextChanged"></asp:TextBox>--%>
                                                        <asp:Label runat="server" ID="LblTotalAmount" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label runat="server" ID="LbladdLess" Text="Add/Less"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox runat="server" ID="TxtAddLess" Text="" AutoPostBack="true"
                                                        ontextchanged="TxtAddLess_TextChanged"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                               <td>
                                                    <asp:Label runat="server" ID="LblNetAmt1" Text="NetAmount"></asp:Label>
                                               </td>
                                               <td>
                                                    <%--<asp:TextBox runat="server" ID="TxtNetAmt" Text=""></asp:TextBox>--%>
                                                    <asp:Label runat="server" ID="LblNetAmount" Text="NetAmount"></asp:Label>
                                               </td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                </td>
                            </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td  >
                                <asp:Button ID="Butinsert" runat="server" Text="Insert" OnClick="Butinsert_Click"
                                    Style="height: 26px" />
                                <asp:Button ID="ButUpdate" runat="server" Text="Update" OnClick="ButUpdate_Click"
                                    Visible="False" />
                                <asp:Button ID="ButCancle" runat="server" Text="Cancle" OnClick="ButCancle_Click" />
                            </td>
                        </tr>
                    </table>
                    <asp:Button runat="server" ID="ButAdd" Text="Add" OnClick="ButAdd_Click" />
                    <asp:GridView ID="gvProductlist" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductId"
                        OnRowEditing="gvProductlist_RowEditing" OnRowDeleting="gvProductlist_RowDeleting"
                        AllowPaging="true" AllowSorting="true" PageSize="3" OnPageIndexChanging="gvProductlist_PageIndexChanging"
                        Height="251px">
                        <RowStyle BackColor="LightCyan" Font-Bold="true" ForeColor="Black" />
                        <AlternatingRowStyle BackColor="LightBlue" />
                        <HeaderStyle BackColor="MidnightBlue" Font-Bold="true" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ProductId" HeaderText="ProductId" />
                            <%--<asp:BoundField DataField="CategoryName" HeaderText="CategoryName" />
                            <asp:BoundField DataField="SubCategoryName" HeaderText="SubCategoryName" />
                            <asp:BoundField DataField="Cosubcategorydesc" HeaderText="CosubcategoryName" />--%>
                            <asp:BoundField DataField="ProductName" HeaderText="ProductName" />
                            <asp:BoundField DataField="ProductDesc" HeaderText="ProductDesc" />
                            <asp:BoundField DataField="Qty" HeaderText="Qty" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Image runat="server" ID="Image5" ImageUrl='<%# "~/Image/" + Eval("Image") %>'
                                         Height="200px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" CommandName="Edit" Text="Edit" />
                                    <asp:Button ID="Button2" runat="server" CommandName="Delete" Text="Delete" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
