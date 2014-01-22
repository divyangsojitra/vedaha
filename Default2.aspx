<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel runat="server" ID="Report" Visible="true">
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" ID="FromDate" Text="Date" ></asp:Label>
                    <asp:TextBox runat="server" ID="TxtfromDate" Text=""></asp:TextBox>
                    <asp:Label runat="server" ID="LblTo" Text="To"></asp:Label>
                    <asp:TextBox runat="server" ID="TxtTodate" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="Lblitem" Text="Select" ></asp:Label>
                 </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList runat="server" ID="Dropparameter">
                    <asp:ListItem Text="Product List"></asp:ListItem>
                    <asp:ListItem Text="Supplier List"></asp:ListItem> 
                    <asp:ListItem Text="CategoryList"></asp:ListItem>
                    <asp:ListItem Text="Stock List"></asp:ListItem>
                     </asp:DropDownList>
               </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td>
                    <asp:Button runat="server" ID="ButSearch" Text="Search" 
                        onclick="ButSearch_Click" />
                </td>
            </tr>
        </table>
        <asp:GridView runat="server" ID="GVReport" AutoGenerateColumns="true">
           
        </asp:GridView>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
