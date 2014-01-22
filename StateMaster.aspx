<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StateMaster.aspx.cs"  MasterPageFile="~/AdminMaster.master" Inherits="StateMaster" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
<div>
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <table runat="server" id="TblAddEdit" visible="false">
    <tr>
        <td><asp:Label runat="server" ID="LblStateId" Text="StateId" Font-Bold="True"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="TxtStateId" Text=""></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label runat="server" ID="LblStatename" Text="State Name" Font-Bold="True"></asp:Label></td>
        <td><asp:TextBox runat="server" ID="TxtStatename" Text=""></asp:TextBox></td>
    </tr>
    <tr>
       <td>
            <asp:Button  runat="server" ID="ButInsert" CommandName="ButInsert" 
                Text="Insert" onclick="ButInsert_Click" Font-Bold="True" />
            <asp:Button runat="server" ID="ButUpdate" CommandName="ButUpdate" Text="Update" 
                onclick="ButUpdate_Click" Font-Bold="True" /> 
            <asp:Button runat="server" Id="ButCancle" CommandName="ButCancle" Text="Cancle" 
                onclick="ButCancle_Click" Font-Bold="True" />
        </td>
    </tr>
    </table>
        <asp:Button runat="server" ID="ButAdd" CommandName="ButAdd" Text="Add" Font-Bold="True"
            onclick="ButAdd_Click" />
      <asp:GridView runat="server" ID="gvstateList" DataKeyNames="StateId" AutoGenerateColumns="false" 
        AllowPaging="true" AllowSorting="true" onrowediting="gvstateList_RowEditing" 
            onrowdeleting="gvstateList_RowDeleting">
            <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="StateId" HeaderText="StateId" />
            <asp:BoundField DataField="Statename" HeaderText="State Name" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" ID="ButEdit" CommandName="Edit" Text="Edit" Font-Bold="True" />
                    <asp:Button runat="server" ID="ButDelete" CommandName="Delete" Text="Delete" Font-Bold="True" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
     </asp:GridView>
    </div>
</asp:Content>

