<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="mail.aspx.cs" Inherits="mail" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="con1" Runat="Server">
    <div>
<table style=" border:1px solid" align="center">
<tr>
    <td colspan="2" align="center">
        <b>Send Mail using asp.net</b>
    </td>
</tr>
<tr>
    <td>
    From:
    </td>
<td>
<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
Subject:
</td>
<td>
<asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
To:
</td>
<td>
<asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td valign="top">
Body:
</td>
<td>
<asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Columns="30" Rows="10" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
</td>
<td>
<asp:Button ID="btnSubmit" Text="Send" runat="server" onclick="btnSubmit_Click" />
</td>
</tr>
</table>
</div>
</asp:Content>

