<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="ExpenseMaster.aspx.cs" Inherits="ExpenseMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="ExpenseId" Text="Expense Id" Font-Bold="True" 
                    Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtExpenseId" Text="" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <span>Voucher No</span></td>
            <td>
                <asp:TextBox runat="server" ID="TxtVno" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblVDate" Text="VoucherDate" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtVDate" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblAccountname" Text="Account Name" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropExpensecategoryList" AutoPostBack="true">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblDescription" Text="Description" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtDescription" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblAmount" Text="Amount" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtAmount" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblType" Text="Type" Font-Bold="true"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropType" OnSelectedIndexChanged="DropType_SelectedIndexChanged">
                    <asp:ListItem>Trading A/c</asp:ListItem>
                    <asp:ListItem>P&L A/C</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButInsert" Text="Insert" OnClick="ButInsert_Click" />
                <asp:Button runat="server" ID="Update" Text="Update" OnClick="Update_Click" 
                    Visible="False" />
                <asp:Button runat="server" ID="Cancle" Text="Cancle" OnClick="Cancle_Click" />
            </td>
        </tr>
    </table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" />
    <asp:GridView runat="server" ID="GVExpenseMasterList" AutoGenerateColumns="false"
        DataKeyNames="ExpenseId" OnSelectedIndexChanged="GVExpenseMasterList_SelectedIndexChanged"
        OnRowDeleting="GVExpenseMasterList_RowDeleting" OnRowEditing="GVExpenseMasterList_RowEditing">
        <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:BoundField HeaderText="ExpenseId" DataField="ExpenseId" />
            <asp:BoundField HeaderText="VNo" DataField="VNo" />
            <asp:BoundField HeaderText="VDate" DataField="VDate" />
            <asp:BoundField HeaderText="Accouct name" DataField="Expensecategoryname" />
            <asp:BoundField HeaderText="ExpenseDesc" DataField="ExpenseDesc" />
            <asp:BoundField HeaderText="Amount" DataField="Amount" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="ButEdit" Text="Edit" CommandName="Edit" />
                    <asp:Button runat="server" ID="ButDelete" Text="Delete" CommandName="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
