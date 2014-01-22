﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="ButAddmore" Text="Add" 
            onclick="ButAddmore_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Srno">
                <ItemTemplate>
                   <asp:TextBox runat="server" ID="TxtSrno" Text=""></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Size">
                <ItemTemplate>
                   <asp:DropDownList runat="server" ID="Dropsize"></asp:DropDownList> 
                </ItemTemplate>  
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Qty">
                <ItemTemplate>
                   <asp:TextBox runat="server" ID="TxtQty" Text=""></asp:TextBox> 
                </ItemTemplate>   
            </asp:TemplateField>
        </Columns>
        </asp:GridView> 
    </div>
    </form>
</body>
</html>
