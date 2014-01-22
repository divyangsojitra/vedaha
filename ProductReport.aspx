<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductReport.aspx.cs" Inherits="Report" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Report</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel runat="server" ID="Panel2" Width="358px" Height="70px">
        <p style="margin-left: 120px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" 
                Text="ProductReport"></asp:Label>
            <br />
        </p>
    <table>
       <tr>
         <td>
            <asp:Label runat="server" ID="FromDate" Text="Date" ></asp:Label>
            </td>
            <td>
            <asp:TextBox runat="server" ID="TxtfromDate" Text=""></asp:TextBox>
            </td>
            <td>
            <asp:Label runat="server" ID="LblTo" Text="To"></asp:Label> </td>
             <td><asp:TextBox runat="server" ID="TxtTodate" Text=""></asp:TextBox>
             
          </td>
          <td><asp:Button runat="server" ID="AddMore" Text="AddMore" 
                        onclick="AddMore_Click"  /></td>
       </tr>
       </table>
       </asp:Panel>
       
       <asp:Panel runat="server" ID="Panel1" Width="273px">
       
       <table>
        <tr>             
                
                <td valign=top>
                    <asp:DropDownList runat="server" ID="Dropparameter" 
                        onselectedindexchanged="Dropparameter_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Text="--Select--"></asp:ListItem>
                    <asp:ListItem Text="PRODUCTNAME"></asp:ListItem>
                    <asp:ListItem Text="CATEGORY"></asp:ListItem> 
                    <asp:ListItem Text="SUBCATEGORY"></asp:ListItem>
                    <asp:ListItem Text="COSUBCATEGORY"></asp:ListItem>
                     </asp:DropDownList>
               </td>
               
                <td valign=top>
                    <asp:ListBox runat="server" ID="ListBox1" SelectionMode="Multiple" Width="200px"></asp:ListBox>
                </td>
                 <td valign=top>
                    <asp:DropDownList runat="server" ID="DropCondition">
                    <asp:ListItem Text="AND"></asp:ListItem>
                    <asp:ListItem Text="OR"></asp:ListItem>
                    </asp:DropDownList>
                    
                </td>
                
       </tr>
       <tr>
            <td>
                <asp:Button runat="server" ID="ButCount" Text="Count" 
                    onclick="ButCount_Click" />
                <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
                <asp:Label runat="server" ID="Lblcat" Text=""></asp:Label>
                <asp:Label runat="server" ID="Lblsub" Text=""></asp:Label>
                <asp:Label runat="server" ID="Lblcosub" Text=""></asp:Label>
                <asp:Label runat="server" ID="Lblpro" Text=""></asp:Label>
                <asp:Label runat="server" ID="Lbltext" Text=""></asp:Label>
            </td>
       </tr>
       </table>
       
       </asp:Panel>
       <asp:Button runat="server" ID="ButSearch" Text="Search" 
                    onclick="ButSearch_Click" />
                <asp:Button runat="server" ID="ButPrint" Text="Print" 
                    onclick="ButPrint_Click" />
       <asp:GridView runat="server" ID="GvReport" AutoGenerateColumns="true">
    <RowStyle BackColor="LightCyan"  Font-Bold="true" ForeColor="Black"   />
        <AlternatingRowStyle BackColor="LightBlue"  />
        <HeaderStyle BackColor ="MidnightBlue" Font-Bold="true" ForeColor="White" />
    </asp:GridView>
    <asp:Panel runat="server" ID="Report1" >
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="True" Height="1039px" ReportSourceID="CrystalReportSource1" 
            Width="901px" oninit="CrystalReportViewer1_Init" 
            EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
           <Report FileName="CrystalReport1.rpt">
            </Report>
        </CR:CrystalReportSource>
        </asp:Panel>
        <%--<rsweb:ReportViewer ID="ReportViewer1" runat="server">
        </rsweb:ReportViewer>--%>
   
    </div>
    </form>
</body>
</html>
