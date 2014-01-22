<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerFeedbackList.aspx.cs" Inherits="CustomerFeedbackList" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView runat="server" ID="gvFeedback" DataKeyNames="FeedbackId" AutoGenerateColumns="false">
 <Columns>
    <asp:BoundField HeaderText="CustomerFeedBack" DataField="FeedbackDesc" />
 </Columns>
    
</asp:GridView>
</asp:Content>

