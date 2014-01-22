<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginMaster.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="LoginMaster" %>
 
    
 <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div>
 <asp:Label ID="lblmsg" runat="server"></asp:Label>
    <table>
    <tr>
        <td><asp:Label runat="server" ID="LblEmailId" Text="EmailId"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="TxtEmailId" Text="" style="width:100px" ></asp:TextBox></td>
   </tr>
   <tr>
        <td><asp:Label runat="server" ID="LblPassword" Text="Password"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="TxtPassword" Text="" style="width:100px"></asp:TextBox></td>
   </tr>
   
   <tr>
        <td><asp:CheckBox runat="server" ID="checkpassword" Text="Stay signed in" /></td>
  </tr>
  <tr>
        <td><asp:Button runat="server" id="ButSingin" Text="Sign in" 
                onclick="ButSingin_Click" />
                </td>
        <%--<td>
            <asp:Button runat="server" ID="ButSignout" Text="Sign Out" onclick="ButSingin_Click" />
        </td>--%>
  </tr>
   </table>
   <asp:Button runat="server" ID="ButCreateAccount" Text="Create New Account" OnClick="ButCreateAccount_Click"/>
   </div>
</asp:Content>

