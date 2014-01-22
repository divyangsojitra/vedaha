<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreditcardMaster.aspx.cs" MasterPageFile="~/MasterPage.master"   Inherits="CreditcardMaster" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
<asp:Label runat="server" ID="LblCustomerId" Text=""></asp:Label>
    <asp:Label runat="server" ID="LblOrderId" Text=""></asp:Label>
    <asp:Label runat="server" ID="LblTransactionId" Text=""></asp:Label>
    
    <div>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblCardHolderName" Text="CardHolderName" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtCardHolderName" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblCreditcardno" Text="Creditcardno" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtCreditcardno" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Label1" Text="Card Type" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropCard" >
                    <asp:ListItem Text="MASTER"></asp:ListItem>
                    <asp:ListItem Text="VISA"></asp:ListItem>
                </asp:DropDownList>
                <%--<asp:TextBox runat="server" ID="Txtcard" Text=""></asp:TextBox>--%>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label runat="server" ID="Lblexpirydate" Text="Expirydate" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="Txtexpirydate" Text=""></asp:TextBox>
                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="Txtexpirydate" >
                </asp:CalendarExtender>
                
                
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Lblcvc2no" Text="cvc2no" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="Txtcvc2no" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblAmount" Text="Amount" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="TxtAmount" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButInsert" Text="Submit" 
                    onclick="ButInsert_Click" Font-Bold="True" />
                <asp:Button runat="server" ID="ButCancel" Text="Cancel" Font-Bold="True" />
            </td>
        </tr>
    </table>
    </div>
    
</asp:Content>






