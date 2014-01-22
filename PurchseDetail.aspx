<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="PurchseDetail.aspx.cs" Inherits="PurchseDetail" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <div>
        <asp:Label runat="server" ID="LblcustomerId" Text=""></asp:Label>
        <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
        <asp:GridView runat="server" ID="GVPurchseDetail" AutoGenerateColumns="false" DataKeyNames="OrderId,PurchseId"
            ShowFooter="true" OnRowEditing="GVPurchseDetail_RowEditing" OnRowUpdating="GVPurchseDetail_RowUpdating"
            OnRowDataBound="GVPurchseDetail_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Sr no">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblSrno"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PurchseId">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblPurchseId" Text='<%#Eval("PurchseId")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="OrderId">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblOrderId" Text='<%#Eval("OrderId") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label runat="server" ID="LblOrderId" Text='<%#Eval("OrderId") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="ProductId">
               </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <asp:Image runat="server" ID="Image1" ImageUrl='<%# "~/Image/" + Eval("Image")%>'
                            Width="75px" Height="150px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ProductName">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblProductname" Text='<%#Eval("ProductName")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label runat="server" ID="LblProductname" Text='<%#Eval("ProductName")%>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Size">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblSize" Text='<%#Eval("Desc")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label runat="server" ID="LblSize" Text='<%#Eval("Desc")%>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Qty">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblQty" Text='<%#Eval("Qty")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label runat="server" ID="LblQty" Text='<%#Bind("Qty")%>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Return Qty">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblReturnQty" Text='<%#Eval("ReturnStatus")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox runat="server" ID="TxtReturnQty" Text='<%#Bind("ReturnStatus")%>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Price">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblPrice" Text='<%#Eval("Price") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label runat="server" ID="LblPrice" Text='<%#Bind("Price") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="LblLineTotalAmt" Text='<%#Eval("LineTotalAmt") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:Label runat="server" ID="LblTotalAmt"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="Edit-Update" ShowEditButton="true" ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
