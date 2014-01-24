<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerFeedbackList.aspx.cs" Inherits="CustomerFeedbackList" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView runat="server" ID="gvFeedback" DataKeyNames="FeedbackId" AutoGenerateColumns="false" Width="100%">
 <Columns>
    <asp:BoundField HeaderText="CustomerFeedBack" DataField="FeedbackDesc" ItemStyle-CssClass="good" HeaderStyle-CssClass="feedback" />
 </Columns>
    
</asp:GridView>
</asp:Content>

