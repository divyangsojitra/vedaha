<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Home.aspx.cs" Inherits="Home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="50" 
        
        <%--style="border-style: --%> inherit; border-color: #C0C0C0; width: 529px; height: 432px;" 
        align="center">
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <%--<asp:Label runat="server" ID="Lblbuttonwoman" Text="WOMEN" Font-Bold="True" 
                    BackColor="#CCCCCC" Height=50px Font-Size="Medium" Width="173px"  />--%>
                <asp:LinkButton runat="server" ID="Linkwomen" Text="WOMEN" Font-Bold="True" 
                    BackColor="ControlLightLight" Font-Size="Medium" ForeColor="Black" 
                    Font-Names="Arial Black"></asp:LinkButton>
                   
            </td>
            <td >&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton runat="server" ID="LinkMen" Text="MEN" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="Medium" ForeColor="Black"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton runat="server" ID="Image1" Height="200" Width="160px"  />
            </td>
            <td>
                <asp:ImageButton runat="server" ID="Image2" Height="200" Width="160px"/>
            </td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:LinkButton runat="server" ID="Linkgirl" Text="GIRLS" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="Medium" ForeColor="Black"></asp:LinkButton>
            </td>
            <td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton runat="server" ID="LinkBoy" Text="BOYS" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="Medium" ForeColor="Black"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton runat="server" ID="Image3" Height="200" Width="160px" />
            </td>
            <td>
                <asp:ImageButton runat="server" ID="Image4" Height="200" Width="160px" />
            </td>
        </tr>
    </table>
</asp:Content>
