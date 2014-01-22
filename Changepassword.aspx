<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Changepassword.aspx.cs" Inherits="Changepassword" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">

<table>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblCurrentPassword" Text="Current Password" Font-Bold="true"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="Txtcurrentpassword" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblnewPassword" Text="New Password" Font-Bold="true"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="Txtnewpassword" Text=""></asp:TextBox>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="Lblconfirmnewpassword" Text="Confirm new Password" Font-Bold="true" ></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtConfirmpassword" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button runat="server" ID="ButChange" CommandName="Change" Text="Change" Font-Bold="true" />
        </td>
        <td>
            <asp:Button runat="server" ID="ButCancle" CommandName="Cancle" Text="Cancle" Font-Bold="true" />
        </td>
    </tr>
</table>
</asp:Content>

