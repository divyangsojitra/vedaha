<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="QuantityMaster.aspx.cs" Inherits="QuantityMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
      <table>
        <tr>
            <td><asp:Label runat="server" ID="LblDate" Text="Quantity Id"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="TxtqtyId" Text=""></asp:TextBox></td>
        </tr>
        <tr>
           <td><asp:Label runat="server" ID="LblProductname" Text="Product name"></asp:Label></td>
           <td><asp:DropDownList runat="server" ID="DropProductList"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblSizeType" Text="SizeType" ></asp:Label></td>
            <td><asp:DropDownList runat="server" ID="DropSizeList"></asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblQty" Text=""></asp:Label></td>
            <td><asp:TextBox runat="server" ID="Txtqty" Text=""></asp:TextBox></td>
        </tr>
        </table>
</div>
</asp:Content>

