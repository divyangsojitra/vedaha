<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FeedbackAdmin.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="FeedbackAdmin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <table>
         <tr>
            <td>
                 <asp:GridView runat="server" ID="gvfeedbackList" AutoGenerateColumns="false" 
                     DataKeyNames="FeedbackId" onrowediting="gvfeedbackList_RowEditing">
                     <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="FeedbackId" HeaderText="FeedbackId" />
                        <asp:BoundField DataField="Date" HeaderText="FeedbackDate" />
                        <asp:BoundField DataField="EmailId" HeaderText="EmailId" />
                        <asp:BoundField DataField="FeedbackDesc" HeaderText="FeedbackDesc" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                            <asp:Button runat="server" ID="ButActive" CommandName="Active" Text="Active" 
                                    onclick="ButActive_Click" />
                            <asp:Button runat="server" ID="ButDisActive" CommandArgument="DisActive" Text="DisActive" /> 
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    
                 </asp:GridView>
             </td>
         </tr>
    </table>
    
    </div>

</asp:Content>


