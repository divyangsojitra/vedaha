<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true"
    CodeFile="SupplierMaster.aspx.cs" Inherits="SupplierMaster" Title="Untitled Page" %>



<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <asp:Label runat="server" ID="Lblcat" Text="SupplierMaster" Font-Bold="True" 
            Font-Names="Arial Black"></asp:Label><br />
    <table runat="server" id="TblAddEdit" visible="false">
        <tr>
            <td>
                <asp:Label runat="server" ID="LblSupplierId" Text="SupplierId" Font-Bold="True" Visible="false"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtSupplierId" Text="" Visible="false"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblSuppliername" Text="Supplier Name" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtSuppliername" Text=""></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TxtSuppliername" ErrorMessage="Enter the Supplier Name" 
                    ValidationGroup="abc"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblAddress" Text="Address" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtAddress" Text=""></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TxtAddress" ErrorMessage="Enter the Supplier Address" 
                    ValidationGroup="abc"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Lblarea" Text="Area" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="Txtarea" Text=""></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="Txtarea" ErrorMessage="Enter Supplier Area" 
                    ValidationGroup="abc"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblCity" Text="City" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="Txtcity" Text=""></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="Txtcity" ErrorMessage="Enter Supplier City" 
                    ValidationGroup="abc"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
                <asp:Label runat="server" ID="LblPincode" Text="Pincode" Font-Bold="True"></asp:Label>
            </td>
            <td style="height: 26px">
                <asp:TextBox runat="server" ID="TxtPincode" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblContact" Text="Contact No" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtContect" Text="" MaxLength="10"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="TxtContect" ErrorMessage="Enter the only numerical value" 
                    ValidationExpression="\d*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="TxtContect" ErrorMessage="Enter Contact no" 
                    ValidationGroup="abc"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="EmailId" Text="Email Address" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtEmailId" Text=""></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="TxtEmailId" ErrorMessage="Enter the Email Address" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="Insert"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="TxtEmailId" ErrorMessage="Enter the Email Address" 
                    ValidationGroup="abc"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButInsert" Text="Insert" CommandName="Insert" 
                    onclick="ButInsert_Click" ValidationGroup="abc" />
                <asp:Button runat="server" ID="ButUpdate" Text="Update" CommandName="Update" onclick="ButUpdate_Click" />
                <asp:Button runat="server" ID="ButCancle" Text="Cancle" CommandName="Cancle" 
                    onclick="ButCancle_Click"  />
            </td>
        </tr>
    </table>
    <asp:Button runat="server" ID="ButAdd" Text="Add" CommandName="Add" 
        onclick="ButAdd_Click"/>
    <asp:GridView runat="server" ID="GvSupplierList" DataKeyNames="SupplierId" 
        AutoGenerateColumns="false" onrowediting="GvSupplierList_RowEditing" 
        onrowupdating="GvSupplierList_RowUpdating" 
        onrowdeleting="GvSupplierList_RowDeleting">
        <RowStyle BackColor="LightCyan" Font-Bold="true" ForeColor="Black" />
        <AlternatingRowStyle BackColor="LightBlue" />
        <HeaderStyle BackColor="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:BoundField HeaderText="SupplierId" DataField="SupplierId" />
            <asp:BoundField HeaderText="Suppliername" DataField="Suppliername" />
            <asp:BoundField HeaderText="Address" DataField="Address" />
            <asp:BoundField HeaderText="Area" DataField="Area" />
            <asp:BoundField HeaderText="City" DataField="City" />
            <asp:BoundField HeaderText="Pincode" DataField="Pincode" />
            <asp:BoundField HeaderText="Contactno" DataField="Contactno" />
            <asp:BoundField HeaderText="EmailId" DataField="EmailId" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton runat="server" ID="ButEdit" ImageUrl="~/images/user_edit.png" Text="Edit" CommandName="Edit" CausesValidation="false" />
                    
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
            <ItemTemplate>
                <asp:Button runat="server" ID="ButDelete" Text="Delete" CommandName="Delete" />
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
