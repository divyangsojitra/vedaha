<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerMasterAdmin.aspx.cs" Inherits="CustomerMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView runat="server" ID="GvCustomer" AutoGenerateColumns="false" DataKeyNames="CustomerId">
        <Columns>
            <asp:BoundField HeaderText="CustomerId" DataField="CustomerId" />
            <asp:BoundField HeaderText="Firstname" DataField="Firstname" />
            <asp:BoundField HeaderText="Lastname" DataField="Lastname" />
            <asp:BoundField HeaderText="Address" DataField="Address" />
            <asp:BoundField HeaderText="City" DataField="City" />
            <asp:BoundField HeaderText="Pincode" DataField="Pincode" />
            <asp:BoundField HeaderText="State" DataField="State" />
            <asp:BoundField HeaderText="Phoneno" DataField="Phoneno" />
            <asp:BoundField HeaderText="Date" DataField="Date" />
            <asp:BoundField HeaderText="EmailId" DataField="EmailId" />
            <asp:BoundField HeaderText="Password" DataField="Password" />
            <asp:BoundField HeaderText="Status" DataField="Status" />
            <asp:BoundField HeaderText="Birthdate" DataField="Birthdate" />
            <asp:BoundField HeaderText="Type" DataField="Type" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="ButActive" CommandName="Active" Text="Active" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>     
    </asp:GridView>
</asp:Content>

