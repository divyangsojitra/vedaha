<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ColourMaster.aspx.cs" Inherits="ColourMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
<table>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblColourId" Text="ColourId" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtColour" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" Id="LblColourName" Text="ColorName" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtColourName" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button runat="server" ID="ButInsert" Text="Insert"  />
            <asp:Button runat="server" ID="ButUpdate" Text="Update" />
            <asp:Button runat="server" ID="ButCancle" Text="Cancle" />
        </td>
    </tr>
</table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" />
    <asp:GridView runat="server" ID="GvColourList" AutoGenerateColumns="true">
    </asp:GridView>

</asp:Content>

