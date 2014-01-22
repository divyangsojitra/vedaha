

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CategoryMaster.aspx.cs"  MasterPageFile="~/AdminMaster.master" Inherits="CategoryMaster" %>



<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">

    <asp:Panel ID="Panel1" runat="server">  
 
 <div> 
 
        <asp:Label runat="server" ID="lblmsgbox"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label runat="server" ID="Lblcat" Text="CategoryMaster" Font-Bold="True" 
            Font-Names="Arial Black"></asp:Label><br />
<table runat="server" id="TblAddEdit" visible="false">
<tr>
    <td>
        <asp:Label runat="server" ID="LblCategoryid" Text="CategoryId" Font-Bold="True" 
            Visible="False"></asp:Label>
    </td>
    <td class="style1">
        <asp:TextBox runat="server" ID="TxtCategoryId" Text="" Visible="False"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <asp:Label runat="server" ID="lblcategorycode" Text="Category Code" Font-Bold="true"></asp:Label>
    </td>
    <td class="style1">
        <asp:TextBox runat="server" ID="TxtCategorycode" Text="" MaxLength="10"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TxtCategorycode" ErrorMessage="Enter the only number" 
            ValidationExpression="\d*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TxtCategorycode" 
            ErrorMessage="Enter the Proper Category Code"></asp:RequiredFieldValidator>
     </td>
</tr>
<tr>
    <td>
        <asp:Label runat="server" ID="lblCategoryname" Text="Category Name"></asp:Label>
    </td>
    <td class="style1">
        <asp:TextBox runat="server" ID="TxtCategoryName" Text="" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TxtCategoryName" 
            ErrorMessage="Enter the ProperCategory Name"></asp:RequiredFieldValidator>
    </td>
</tr> 
<tr>
    <td>
        <asp:Label runat="server" ID="lblStatus" Text="Status"></asp:Label>
    </td>
    <td class="style1">
        <asp:DropDownList runat="server" ID ="Dropstatus">
        <asp:ListItem>Active</asp:ListItem>
        <asp:ListItem>Inactive</asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>
<tr>
    <td>
        <asp:Button runat="server" ID="ButInsert" Text="Insert" 
            onclick="ButInsert_Click" />
        <asp:Button runat="server" ID="ButUpdate" Text="Update" 
            onclick="ButUpdate_Click" />
        <asp:Button runat="server" ID="ButCancle" Text="Cancel" onclick="ButCancle_Click" 
            CausesValidation="False" />
    </td>
 </tr>
<tr>
    <td>
        &nbsp;</td>
 </tr>
</table> 
    <asp:Button runat="server" ID="ButAdd" Text="Add" onclick="ButAdd_Click" 
            CausesValidation="false"/>
    </div> 
    <asp:GridView ID="gvCategorylist" runat="server" AutoGenerateColumns="false" DataKeyNames="CategoryId" 
        onrowediting="gvCategorylist_RowEditing" 
        onrowdeleting="gvCategorylist_RowDeleting" 
            onselectedindexchanged="gvCategorylist_SelectedIndexChanged3">
            <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:BoundField  DataField="Categoryid" HeaderText="Category Id" />
            <asp:BoundField DataField ="Categoryname" HeaderText="Category Name" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton runat="server" ID="ButEdit" ImageUrl="~/images/user_edit.png" CommandName="Edit"  CausesValidation="false" />                
                <asp:ImageButton runat="server" ID="ButDelete" ImageUrl="~/images/user_logout.png" CommandName="Delete" CausesValidation="false"/>
            </ItemTemplate>
        </asp:TemplateField>
        
       </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource> 
  
</asp:Panel> 
</asp:Content>     







