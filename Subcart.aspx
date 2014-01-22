<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPage2.master" CodeFile="~/Subcart.aspx.cs" CodeBehind="~/Subcart.aspx.cs" Inherits="Subcart" %>
<%--<%@ Register Src="~/MasterPage2.master" TagPrefix="uc" TagName="RadioPrice" %>--%>
<%@ MasterType VirtualPath="~/MasterPage2.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
--%>    <div>

    
    <%--<uc:RadioList runat="server" ID="CPriceRadio"/>--%>
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <asp:Label runat="server" ID="LblCategoryId" Visible="False"></asp:Label>
        &nbsp;&nbsp; 
    <asp:Label runat="server" ID="Label1" Text="Dress" Font-Bold="True" 
            Font-Names="Arial Black" ForeColor="#990000"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label runat="server" ID="Label2" Text="Women Sarees" Font-Names="Arial Black" 
            ForeColor="#990000"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label runat="server" ID="Label3" Text="Wedding Sarees" Font-Bold="True" 
            Font-Names="Arial Black" ForeColor="#990000"></asp:Label>
    <asp:DataList ID="DataSubCategoryList" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
    <ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server"  Width="200px" Height="300px"
            ImageUrl='<%# "~/Image/"+ Eval("Image")%>'  
            PostBackUrl='<%# Eval("SubCategoryId","~/Cosubcart1.aspx?Cscat={0}") %>' CommandName="Image"/>
    </ItemTemplate>
    </asp:DataList>
    
    
        
        
        
    <%--<table cellpadding="10">
    <tr>
       <td> <asp:ImageButton runat="server" ID="Image1"  Height="200" Width="180" /></td>
       <td><asp:ImageButton  runat="server" ID="Image2" Height="200" Width="180"/></td> 
       <td> <asp:ImageButton runat="server" ID="Image3" Height="200" Width="180"/></td>
       <td> <asp:ImageButton runat="server" ID="Image4" Height="200" Width="180" /></td>
    </tr>
</table>--%>
    </div>
    </asp:Content>
  
