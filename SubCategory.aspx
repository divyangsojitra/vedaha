<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubCategory.aspx.cs" MasterPageFile="~/AdminMaster.master" Inherits="SubCategory" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">

<div>
        <asp:Label runat="server" ID="lblmsgbox" Text=""></asp:Label>   
        <asp:Label runat="server" ID="Lblcat" Text="SubcategoryMaster" Font-Bold="True" 
            Font-Names="Arial Black"></asp:Label><br />
<table runat="server" id="TblAddEdit" visible="true">
    <tr>
        <td>
            <asp:Label runat="server" ID="lblSubcategoryid" Text="SubCategoryID" 
                Font-Bold="True" Visible="False"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="Txtsubcategoryid" Text="" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="lblCategoryname" Text="CategoryName" 
                Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:DropDownList runat="server" ID="Dropcategoryname"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="lblSubcategoryname" Text="SubCategory Name" 
                Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="Txtsubcategoryname" Text=""></asp:TextBox>
            
        </td>
    </tr>
    
    <tr>
        <td>
            <asp:Label runat="server" ID="LblStatus" Text="Status" Font-Bold="True"></asp:Label>
        </td>
        <td>
            <asp:DropDownList runat="server" ID="DropStatus">
            <asp:ListItem>Active</asp:ListItem>
            <asp:ListItem>Inactive</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="ButInsert" runat="server" Text="Insert" 
        onclick="ButInsert_Click" Font-Bold="True"/>
            <asp:Button ID="ButUpdate" runat="server" Text="Update" Visible="false"
                onclick="ButUpdate_Click" Font-Bold="True" />
            <asp:Button ID="ButCancle" runat="server" Text="Cancle" 
                onclick="ButCancle_Click" Font-Bold="True"/>
        </td>
    </tr> 
    <tr>
        <td>
        &nbsp;</td>
    </tr>  
</table>
    <asp:Button runat="server" ID ="ButAdd" Text="Add" onclick="ButAdd_Click"/>
</div>
    <asp:GridView ID="GvSubCategoryList" runat="server" AutoGenerateColumns="false" 
            DataKeyNames="SubCategoryId"
            onrowediting="GvSubCategoryList_RowEditing" 
            onrowdeleting="GvSubCategoryList_RowDeleting">
            <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
     <Columns>
        <asp:BoundField DataField="SubCategoryId" HeaderText="SubCategoryId" />
        <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" />
        <asp:BoundField DataField="SubCategoryName" HeaderText="SubCategoryName" />
        <asp:BoundField DataField ="Status" HeaderText="Status" />
        <asp:TemplateField> 
                   
        <ItemTemplate>
                <asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit" CausesValidation="false" />
                <asp:Button ID="Button2" runat="server" Text="Delete" CommandName="Delete" CausesValidation="false" />
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>
     </asp:GridView>
</asp:Content>




