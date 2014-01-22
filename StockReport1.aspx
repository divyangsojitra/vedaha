<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="StockReport1.aspx.cs" Inherits="StockReport" Title="Untitled Page" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<form id="form1" runat="server">
    <div>
    <asp:Panel runat="server" id="PanelReport">
    <table>
        <tr>
            <td>
                <asp:Label ID="LblDate" runat="server" Text="Date"></asp:Label>  
                <asp:TextBox ID="TxtfromDate" runat="server" Text=""></asp:TextBox>
                <asp:Label ID="LblTO" runat="server" Text="To"></asp:Label>
                <asp:TextBox ID="TxttoDate" runat="server" Text=""></asp:TextBox>
           </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList r
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Id="ButSearch"  Text="Search" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td>
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                    AutoDataBind="True" Height="1039px" ReportSourceID="CrystalReportSource1" 
                    Width="901px" oninit="CrystalReportViewer1_Init" />
                <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                    <Report FileName="CrystalReport1.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </td></tr>        
    </table>
   </asp:Panel>
     <asp:GridView runat="server" ID="GVStockList" AutoGenerateColumns="true" DataKeyNames="PurchseId">
    </asp:GridView>
    </div>
    </form>


