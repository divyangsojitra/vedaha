<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderMaster.aspx.cs" MasterPageFile="~/AdminMaster.master"
    Inherits="_Default" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <div>
        <asp:GridView ID="GvOrderList" runat="server" AutoGenerateColumns="false" DataKeyNames="TransactionId"
            OnRowCommand="GvOrderList_RowCommand">
            <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
            <Columns>
            
            <asp:BoundField  DataField="TransactionId" HeaderText="TransactionId" />
            <asp:BoundField DataField ="CardHolderName" HeaderText="CardHolderName" />
            <asp:BoundField DataField="OrderId" HeaderText="OrderId" />
            <asp:BoundField  DataField="Creditcardno" HeaderText="Creditcardno" />
            <asp:BoundField DataField ="Card" HeaderText="Card" />
            <asp:BoundField DataField="expirydate" HeaderText="expirydate" />
            <asp:BoundField DataField ="cvc2no" HeaderText="cvc2no" />
            <asp:BoundField DataField="Amount" HeaderText="Amount" />
            <asp:BoundField DataField="PaymentDate" HeaderText="PaymentDate" />
            
                <asp:TemplateField>
                    <ItemTemplate>
                    
                        <asp:Button runat="server" ID="ButBilling" Text="Billing" CommandName="Billing" CommandArgument='<%# Eval("OrderId")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
