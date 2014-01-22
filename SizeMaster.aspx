<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="SizeMaster.aspx.cs" Inherits="SizeMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
<div>
    <asp:Label runat="server" ID="lblmsg" Text=""></asp:Label>
    <asp:Label runat="server" ID="Lblcat" Text="SizeMaster" Font-Bold="True" 
            Font-Names="Arial Black"></asp:Label><br />
    <table>
        <tr>
            <td><asp:Label runat="server" ID="LblSizeId" Text="SizeId" Font-Bold="True" 
                    Visible="False"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="TxtSizeId" Text="" Visible="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblSizeType" Text="Type" Font-Bold="True"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="TxtType" Text=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="ButInsert" Text="Insert" 
                    onclick="ButInsert_Click" Font-Bold="True" />
                <asp:Button runat="server" ID="ButUpDate" Text="Update" 
                    onclick="ButUpDate_Click" Font-Bold="True" Visible="False" />
                <asp:Button runat="server" ID="ButCancle" Text="Cancle" 
                    onclick="ButCancle_Click" Font-Bold="True" />
            </td>
        </tr>
    </table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" onclick="ButAdd_Click" />
    <asp:GridView runat="server" ID="GvSizeMasterList" AutoGenerateColumns="false" 
        DataKeyNames="SizeId" 
        onselectedindexchanged="GvSizeMasterList_SelectedIndexChanged" 
        onrowdeleting="GvSizeMasterList_RowDeleting" 
        onrowediting="GvSizeMasterList_RowEditing">
        <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="SizeId" HeaderText="SizeId" />
            <asp:BoundField DataField="Desc" HeaderText="Description" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="ButEdit" Text="Edit" CommandName="Edit" />
                    <asp:Button runat="server" ID="Delete" Text="Delete" CommandName="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
</asp:Content>

