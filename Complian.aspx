<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Complian.aspx.cs" Inherits="Complian" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
    <tr>
        <td>
            <asp:Label runat="server" ID="Lblname" Text="Name" Font-Bold="True" 
                Font-Size="Small" ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="Txtname" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblEmailId" Text="Email Address" Font-Bold="True" 
                ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtEmailId" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblSubject" Text="Subject" Font-Bold="True" 
                ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="Txtsubject" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblComplianType" Text="Complian Type" 
                Font-Bold="True" ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:DropDownList runat="server" ID="DropComplianType">
            <asp:ListItem Text="Customer Service"></asp:ListItem>
            <asp:ListItem Text="Shipping Service"></asp:ListItem>
            <asp:ListItem Text="Other Complian"></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="Lblcomment" Text="Comment" Font-Bold="True" 
                ForeColor="Black"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtComment" Text="" Height="84px" Width="170px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button runat="server" ID="ButSubmit" CssClass="submit" Text="Submit" Font-Bold="True" />
        </td>
    </tr>
</table>
</asp:Content>

