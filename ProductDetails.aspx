<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs"  MasterPageFile="~/MasterPage.master" Inherits="ProductDetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<script src="js/jquery.min.js" type="text/javascript"></script>

    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <asp:Label runat="server" ID="LblStockQty" Text=""></asp:Label>
    <asp:Label runat="server" ID="LblCustomerId" Text=""></asp:Label>
    <table>
        <tr>
            <td class="style1" rowspan="5">
    <asp:Image ID="Image2" runat="server" Width="315px" Height="529px" 
                    onclick="Pop(this,30,'');"/>
            </td>
            <tr>
            <td><asp:Label runat="server" ID="LblDetails" Text="Detail:" Font-Bold></asp:Label></td>
        
            <td><asp:Label runat="server" ID="LblProductDesc" Text="" Width="200"></asp:Label></td>
        </tr>
            <td>
                <asp:Label runat="server" ID="LblProductId1" Text="ProductId" Font-Bold></asp:Label>
            </td>
            <td>
                <asp:Label  runat="server" ID="LblProductId" Text=""></asp:Label>    
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="ProductName1" Text="ProductName:" Font-Bold></asp:Label>
                 
            </td>
            <td>
                <asp:Label runat ="server" ID="LblProductname" Width="200" Text=""></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label runat="server" ID="LblSize" Text="Size" Font-Bold></asp:Label>  
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropdownSize" 
                    onselectedindexchanged="DropdownSize_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Label runat="server" ID="price1" Text="price:" Font-Bold></asp:Label>
                
            </td>
            <td> 
                 <asp:Label runat="server" ID="LblPrice" Text=""></asp:Label>
            </td>
        </tr>
        
        <tr>
           <td><asp:Label runat="server" ID="LblQty" Text="" Font-Bold></asp:Label></td> 
           
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblTotal" Text="" Font-Bold></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblTotalamt" Text=""></asp:Label> </td>
        </tr>
        
       
   </table>
 <asp:Label runat="server" ID="LblImage" Text='<%# "~/Image/\\{0}"+Eval("Image")%>' Visible="false" Width="100px" Height="200px"></asp:Label>
    
    
        <br />
<asp:Button ID="btnAdd" runat="server" 
                        Text="Add to Cart" onclick="btnAdd_Click" /><br /><br />
<script src="js/PopBox.js" type="text/javascript"></script>
    </div>

</asp:Content>



