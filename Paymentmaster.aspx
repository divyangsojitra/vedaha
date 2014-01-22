<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Paymentmaster.aspx.cs"  MasterPageFile="~/MasterPage.master"   Inherits="Paymentmaster" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <asp:Label runat="server" ID="LblPayment" Text="Payment"></asp:Label>
            <asp:RadioButtonList ID="OpPaymentoption" runat="server"  AutoPostBack="true"
            onselectedindexchanged="OpPaymentoption_SelectedIndexChanged" 
            ontextchanged="OpPaymentoption_TextChanged">
                    <asp:ListItem>Creditcard</asp:ListItem>
                    <asp:ListItem>DebitCard</asp:ListItem>
                    
                </asp:RadioButtonList>
    </div>
</asp:Content>




