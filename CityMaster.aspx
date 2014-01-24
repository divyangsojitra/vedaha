<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CityMaster.aspx.cs"  MasterPageFile="~/AdminMaster.master"   Inherits="CityMaster" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1"><div>
    <asp:Label runat="server" ID="Lblmsg"></asp:Label>
     <table runat="server" id="TblAddEdit" visible="false">
        <tr>
            <td><asp:Label runat="server" ID="LblCityId" Text="City Id" Font-Bold="True"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="TxtCityId" Text="" 
                    ontextchanged="TxtCityId_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblCityname" Text="City Name" Font-Bold="True"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="TxtCityname" Text=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblState" Text="State" Font-Bold="True"></asp:Label></td>
            <td>
                <asp:DropDownList runat="server" ID="DropSate">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButInsert" CommandName="ButInsert" Text="Insert" 
                    onclick="ButInsert_Click" Font-Bold="True" />
                <asp:Button runat="server" ID="ButUpdate" CommandName="ButUpdate" Text="Update" 
                    onclick="ButUpdate_Click" Font-Bold="True" />
                <asp:Button runat="server" ID="ButCancle" CommandName="ButCancle" Text="Cancle" 
                    onclick="ButCancle_Click" Font-Bold="True" />
            </td>
        </tr>
     </table>
    <asp:Button runat="server" ID="ButAdd" CommandName="ButAdd" CssClass="add" Text="Add" 
            onclick="ButAdd_Click" Font-Bold="True" Font-Italic="False" />
        <asp:GridView runat="server" ID="gvcity" CssClass="width" DataKeyNames="CityId" AutoGenerateColumns="false" 
                AllowPaging="true" AllowSorting="true" 
            onrowediting="gvcity_RowEditing" onrowdeleting="gvcity_RowDeleting" >
            <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
            <Columns>
            
                <asp:BoundField DataField="CityId" HeaderText="City Id" />
                <asp:BoundField DataField="Cityname" HeaderText="City Name" />
                <asp:BoundField DataField="StateId" HeaderText="State" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button runat="server" ID="ButEdit" CssClass="butedit" CommandName="Edit" Text="Edit" />
                        <asp:Button runat="server" ID="ButDelete" CommandName="Delete" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
           
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>






