<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="ManageDelivery.aspx.cs" Inherits="ManageDelivery" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="con1" Runat="Server">
<asp:GridView runat="server" ID="GvDelivery">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox runat="server" ID="checkDelivaryStatus" Text="checkDelivaryStatus" />
            </ItemTemplate>
            
        </asp:TemplateField>
        
    </Columns>
</asp:GridView>
    
</asp:Content>

