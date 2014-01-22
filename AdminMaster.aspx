<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminMaster.aspx.cs" Inherits="AdminMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblAdministratorId" Text="AdministratorId" Font-Bold="true"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtAdminnistratorId" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblPassword" Text="Password" Font-Bold="true"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtPassword" Text=""></asp:TextBox>
        </td>     
    </tr>
   <tr>
        <td>
            <asp:Label runat="server" ID="LblConfirmPasswor" Text="Confirm Password" Font-Bold="true"></asp:Label>
        </td>
        <td>
              <asp:TextBox runat="server" ID="TxtConfirmPassword" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
           <td> 
                <asp:Label runat="server" ID="LblCreateAccount" Text="Create Account" Font-Bold="true"></asp:Label>           
           </td>
           <td>
                <asp:Label runat="server" ID="LblCancle" Text="Cancle" Font-Bold="true"></asp:Label>
            </td>
    </tr>
</table>
</asp:Content>

