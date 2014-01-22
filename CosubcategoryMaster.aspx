<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="CosubcategoryMaster.aspx.cs" Inherits="CosubcategoryMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <div>
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <asp:Label runat="server" ID="Lblcat" Text="CosubcategoryMaster" Font-Bold="True" 
            Font-Names="Arial Black"></asp:Label><br />
<table>
    <tr>
        <td><asp:Label runat="server" ID="LblCosubcategory" Text="CoSubCategoryId" 
                Visible="False"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="TxtCosubcategory" Text="" Visible="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="LblCategoryname" Text="Category name"></asp:Label></td>
        <td><asp:DropDownList runat="server" ID="DropCategoryname" 
                onselectedindexchanged="DropCategoryname_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="LblSubCategoryname" Text="SubCategory name"></asp:Label></td>
        <td><asp:DropDownList runat="server" ID="DropSubCategory" ></asp:DropDownList></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="LblDesc" Text="Description"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="TxtDescription" Text=""></asp:TextBox></td>
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
           <asp:Button runat="server" ID="ButInsert" Text="Insert" 
                onclick="ButInsert_Click" />
        
            <asp:Button ID="ButUpdate" runat="server" Text="Update" onclick="ButUpdate_Click" Visible="false" 
                />
            <asp:Button runat="server"  ID="ButCancle" Text="Cancle" 
                onclick="ButCancle_Click" />
          </td>    
    </tr>
</table>
<%--<asp:Button runat="server" ID="ButAdd" Text="Add" />--%>
<asp:GridView runat="server" ID="gvCosubcategoryList" AutoGenerateColumns="false" 
            DataKeyNames="CosubcategoryId" 
            onrowdeleting="gvCosubcategoryList_RowDeleting" 
            onrowediting="gvCosubcategoryList_RowEditing">
            <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
    <Columns>
        <asp:BoundField DataField="CosubcategoryId" HeaderText="CosubcategoryId" />
        <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" />
        <asp:BoundField DataField="SubCategoryName" HeaderText="SubCategoryName" />
        <asp:BoundField DataField="Cosubcategorydesc" HeaderText="Cosubcategoryname" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button runat="server" ID="ButEdit" CommandName="Edit" Text="Edit" />
                <asp:Button runat="server" ID="ButDelete" CommandName="Delete" Text="Delete" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    

</asp:GridView>
</div>
</asp:Content>

