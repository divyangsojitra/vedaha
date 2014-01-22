<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Userhomepage.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="Userhomepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
        <asp:Label runat="server" ID="Lblmgs" Text=""></asp:Label>
        <asp:Label runat="server" ID="Lblcustid" Text=""></asp:Label>
        <asp:LinkButton runat="server" ID="ButLogout" Text="Logout"></asp:LinkButton>
    
    <table>
        <tr>
            <td>
               <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Add  to Cart</asp:LinkButton> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LbEditProfile" runat="server" onclick="LbEditProfile_Click">Edit Profile</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
               <asp:LinkButton ID="linkSignOut" runat="server" onclick="LinkButton1_Click">Sign Out</asp:LinkButton>  
            </td>
        </tr>
    </table>
    </div>
</asp:Content>




