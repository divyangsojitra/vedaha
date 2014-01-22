<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ComplianMasterAdmin.aspx.cs" Inherits="ComplianMasterAdmin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView runat="server" ID="GvComplianList" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField HeaderText="ComplianId" DataField="ComplianId" />
        <asp:BoundField HeaderText="EmailId" DataField="EmailId" />
        <asp:BoundField HeaderText="Subject" DataField="Subject" />
        <asp:BoundField HeaderText="Complian_Type" DataField="Complian_Type" />
        <asp:BoundField HeaderText="Comment" DataField="Comment" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button runat="server" CommandName="Replay"  ID="Replay" Text="Replay via Email" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>

