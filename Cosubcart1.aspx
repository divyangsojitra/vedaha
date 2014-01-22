<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Cosubcart1.aspx.cs" Inherits="Cosubcart1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Label runat="server" ID="LblCategoryId" Text=""></asp:Label>
<asp:Label runat="server" ID="LblSubcategoryId" Text=""></asp:Label>

<asp:DataList ID="DataCosubategoryList" runat="server" 
                RepeatColumns="4"
              RepeatDirection="Horizontal">
    <ItemTemplate>
   
         <asp:ImageButton ID="ImageButton2" runat="server"  Width="200px" Height="300px"
            ImageUrl='<%# "~/Image/"+ Eval("Image")%>'
            PostBackUrl='<%# Eval("CosubcategoryId","~/Cart.aspx?Sid={0}") %>'  
            
             CommandName="Image"/>   
            
            
    </ItemTemplate>
</asp:DataList>
</asp:Content>

