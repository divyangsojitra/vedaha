<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="ExpenseCategoryMaster.aspx.cs" Inherits="ExpenseCategoryMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblExpenseCategoryId" Text="ExpenseCategoryId" 
                    Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtExpenseCategoryId" Text="" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblExpensecategoryname" Text="Expensecategory name"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtExpensecategoryname" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButInsert" Text="Insert" OnClick="ButInsert_Click" />
                <asp:Button runat="server" ID="Update" Text="UpDate" OnClick="Update_Click" Visible="false"/>
                <asp:Button runat="server" ID="ButCancle" Text="Cancle" OnClick="ButCancle_Click" />
            </td>
        </tr>
    </table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" />
    <asp:GridView runat="server" ID="GvExpenseList" AutoGenerateColumns="false" DataKeyNames="ExpensecategoryId"
        OnRowEditing="GvExpenseList_RowEditing" 
        onrowdeleting="GvExpenseList_RowDeleting">
        <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:BoundField HeaderText="ExpenseCategoryId" DataField="ExpensecategoryId" />
            <asp:BoundField HeaderText="Expensecategoryname" DataField="Expensecategoryname" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="ButEdit" CommandName="Edit" Text="Edit" />
                    <asp:Button runat="server" ID="ButDelete" CommandName="Delete" Text="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
