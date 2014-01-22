<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedback.aspx.cs"  MasterPageFile="~/MasterPage.master" Inherits="Feedback" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <table>
        <tr>
            <td><asp:Label runat="server" ID="LblEmailId" Text="EmailId"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="TxtEmailId" Text=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" ID="LblYourmessage" Text="Your message"></asp:Label></td>
            <td><asp:TextBox runat="server" ID="Txtfeedbackmsg" Text="" Height="87px" 
                    Width="221px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
            <asp:CheckBox runat="server" ID="CheckStatus" Visible="false"/>
            </td>
            <td>
            <asp:Button runat="server" ID="ButSubmit" Text="Submit" 
                    onclick="ButSubmit_Click" /></td>
        </tr>
    </table>
    </div>
</asp:Content>




