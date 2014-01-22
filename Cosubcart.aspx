<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Cosubcart.aspx.cs" Inherits="Cosubcart" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label runat="server" ID="LblCategoryId" Text=""></asp:Label>
<asp:Label runat="server" ID="LblSubcategoryId" Text=""></asp:Label>
 <%--<table cellpadding="10">
 
    <tr>
    <asp:Literal ID="ltImages" runat="server"></asp:Literal>
       <td> <asp:ImageButton runat="server" ID="Image1"  Height="200" Width="180" /></td>
       <td><asp:ImageButton  runat="server" ID="Image2" Height="200" Width="180"/></td> 
       <td> <asp:ImageButton runat="server" ID="Image3" Height="200" Width="180"/></td>
       <td> <asp:ImageButton runat="server" ID="Image4" Height="200" Width="180" /></td>
    </tr>
</table>--%>




<asp:DataList ID="DataCosubategoryList" runat="server" 
                RepeatColumns="4"
              RepeatDirection="Horizontal">
    <ItemTemplate>
    <asp:ImageButton ID="ImageButton2" runat="server"  Width="200px" Height="500px" 
            
            ImageUrl='<%# "~/Image/"+ Eval("Image")%>'
            PostBackUrl='<%# Eval("CosubcategoryId", 
            "~/Cart.aspx?Cosct={0}") %>'
             CommandName="Image"/>    
    </ItemTemplate>
</asp:DataList>





</asp:Content>

