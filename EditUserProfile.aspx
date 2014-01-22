<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditUserProfile.aspx.cs"
    MasterPageFile="~/MasterPage.master" Inherits="EditUserProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <asp:Label runat="server" ID="Lblmsgbox" Text=""></asp:Label>
        <asp:Label runat="server" ID="LblcustomerId" Text=""></asp:Label>
        <table runat="server" id="TblAddEdit" visible="true">
            <tr>
                <td>
                    <asp:Label runat="server" ID="FirstName" Text="First Name" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="Txtfirstname" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="LastName1" Text="Last Name" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtLastName" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="Address1" Text="Address" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtAddress" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="City1" Text="City" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtCity" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="Pincode1" Text="Pincode" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtPincode" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="State" Text="State" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtState" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="Phoneno" Text="Phone no" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtPhoneno" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="BirthDate1" Text="Birth Date" Font-Bold="true"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="TxtBirthDate" Text=""></asp:TextBox>
                    <asp:CalendarExtender runat="server" ID="CalendarExtender1" TargetControlID="TxtBirthDate">
                    </asp:CalendarExtender>
                </td>
            </tr>
        </table>
        <asp:Button runat="server" ID="ButEdit" Text="Edit Profile" CommandName="ButEdit"
            OnClick="ButEdit_Click1" OnCommand="ButEdit_Command" Font-Bold="True" />
    </div>
</asp:Content>
