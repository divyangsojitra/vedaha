<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="Gridview1" runat="server" ShowFooter="true" AutoGenerateColumns="false"
            OnSelectedIndexChanged="Gridview1_SelectedIndexChanged" 
            onrowdeleting="Gridview1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="RowNumber" HeaderText="Row Number" />
                <asp:TemplateField HeaderText="Header 1">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Header 2">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Header 3">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </ItemTemplate>
                    <FooterStyle HorizontalAlign="Right" />
                    <FooterTemplate>
                    </FooterTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="D1">
                    <ItemTemplate>
                    <asp:LinkButton runat="server" ID="lnkDel"  OnCommand="DeleteRowHandler"   Text="delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="ButtonAdd" runat="server" Text="Add New Row" CommandName="ButtonAdd"
            OnClick="ButtonAdd_Click" />
    </div>
    </form>
</body>
</html>
