<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="FabircMaster.aspx.cs" Inherits="FabircMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="con1" Runat="Server">
<asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblFabircId" Text="Fabirc"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtFabicId" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblFabricname" Text="Fabricname"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtFabricname" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblStatus" Text="Status"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropStatus" >
                <asp:ListItem Text="Active"></asp:ListItem>
                <asp:ListItem Text="Inactive"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Id="ButInsert" Text="Insert" CommandName="Insert" 
                    onclick="ButInsert_Click" />
                <asp:Button runat="server" ID="ButUpdate" Text="Update" CommandName="Update" 
                    onclick="ButUpdate_Click" />
                <asp:Button runat="server" ID="ButCancle" Text="Cancle" CommandName="Cancle" 
                    onclick="ButCancle_Click" />
            </td>
        </tr>
    </table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" CommandName="Add" />
    <asp:GridView runat="server" ID="GvFabricList" AutoGenerateColumns="false" DataKeyNames="FabricId" 
        onrowediting="GvFabricList_RowEditing" 
        onrowdeleting="GvFabricList_RowDeleting">
    <Columns>
        <asp:BoundField DataField="FabricId" HeaderText="FabricId" />
        <asp:BoundField DataField="Fabricname" HeaderText="Fabricname" />
        <asp:BoundField  DataField="Status" HeaderText="Status" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button runat="server" ID="ButEdit" Text="Edit" CommandName="Edit" />
            
            <asp:Button runat="server" ID="ButDelete" Text="Delete" CommandName="Delete" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Content>

