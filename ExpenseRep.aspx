<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExpenseRep.aspx.cs" Inherits="ExpenseRep" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
           <td>
            <asp:DropDownList runat="server" ID="DropExpense">
                <asp:ListItem Text="ExpenseRep"></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    </table>
    <asp:GridView runat="server" ID="GvExpense" ></asp:GridView>
    
    </div>
    </form>
</body>
</html>
