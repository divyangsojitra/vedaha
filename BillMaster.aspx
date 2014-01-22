<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BillMaster.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="BillMaster" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblBillBillDate" Text="BillBillDate"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtBillDate" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblOderId" Text="OderId"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropOderId"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblPaymenttype" Text="Paymenttype"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPaymenttype" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButInsert"  Text="Insert" />
                <asp:Button runat="server" Id="ButUpdate" Text="Update" />
                <asp:Button runat="server" ID="ButCancel" Text="Cancel" />
            </td>
        </tr>
    </table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" />
    </div>
</asp:Content>



