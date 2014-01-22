<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockReport.aspx.cs" Inherits="StockReport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-position: center; background-image: none; background-color: #FFFFFF;">
    <asp:Label runat="server" id="LblStockReport" Text="StockReport" 
            Font-Size="X-Large" ></asp:Label>
    <asp:Panel runat="server" ID="panel1">
    <table>
        
        <tr>
            <td>
                <asp:Label runat="server" ID="LblCategory" Text="Category"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropCategory" 
                    onselectedindexchanged="DropCategory_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="--Select--"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblSubcategory" Text="Subcategory"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropSubcategory" AutoPostBack="true" 
                    onselectedindexchanged="DropSubcategory_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblCosubcategory" Text="Cosubcategory"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropCosubcategory" AutoPostBack="true" OnSelectedIndexChanged="DropCosubcategory_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" id="LblProductname" Text="ProductName"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropProductname" AutoPostBack="true" 
                    onselectedindexchanged="DropProductname_SelectedIndexChanged">
                <asp:ListItem Text="--Select--"></asp:ListItem>
                </asp:DropDownList>
                <%--<asp:TextBox runat="server" ID="TxtProductname" Text=""></asp:TextBox>--%>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblStockqty" Text="Stock Qty"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropStockqty">
                <asp:ListItem Text="Available"></asp:ListItem>
                <asp:ListItem Text="Not Available"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButSearch" Text="Search" 
                    onclick="ButSearch_Click" />
                
            </td>
            <td>
                <asp:Button runat="server" ID="Print" Text="Print" Width="48px" 
                    onclick="Print_Click" />
            </td>
        </tr>
    </table>
    </asp:Panel>
    <asp:GridView runat="server" ID="GVStockList" AutoGenerateColumns="true">
    <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
    </asp:GridView>
    </div>
    </form>
</body>
</html>
