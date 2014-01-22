<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cart.aspx.cs" MasterPageFile="~/MasterPage2.master"  Inherits="Cart" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         
    <div>
    <asp:Label runat="server" ID="LblCategoryId" Text="1" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="LblSubCategoryId" Text="2" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="LblCosubcategoryId" Text="9" Visible="false"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LnkbutBhoppingbag" runat="server" 
            onclick="LnkbutBhoppingbag_Click">shoppingbag</asp:LinkButton>
   <table>
   <tr>
   <td>
    <asp:DataList ID="ImageDataList" runat="server" RepeatDirection="Horizontal"
                RepeatColumns="4" onitemcommand="DataList1_ItemCommand1" 
        onselectedindexchanged="ImageDataList_SelectedIndexChanged2">
    <ItemTemplate>
    <asp:ImageButton ID="ImageButton1" runat="server"  Width="200px" Height="300px" 
            ImageUrl='<%# "~/Image/"+ Eval("Image")%>' 
            PostBackUrl='<%# Eval("ProductId", 
            "ProductDetails.aspx?pid={0}") %>' CommandName="Image"/>
            
            <br />

            <asp:Label ID="PriceLabel" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Button runat="server" ID="ButAddtowishList" Text="AddToWishlist" CommandName="AddToWishlist" PostBackUrl='<%# Eval("ProductId", 
            "ProductDetails.aspx?pid={0}") %>' CausesValidation="false" Width="80" /><br />
            <asp:Button runat="server" ID="ButAddtoCart" Text="Add To Cart" 
            CommandName="Add To Cart" PostBackUrl='<%# Eval("ProductId", 
            "ProductDetails.aspx?pid={0}") %>' CausesValidation="false" Width="80" 
            onclick="ButAddtoCart_Click"/>
           
             <br />
    </ItemTemplate>
</asp:DataList><br />
</td>
</tr> 
</table>
<%--<asp:HyperLink ID="CartLink" runat="server" 
               >
               View Shopping Cart
</asp:HyperLink><br />
    --%>
    </div>
</asp:Content>






