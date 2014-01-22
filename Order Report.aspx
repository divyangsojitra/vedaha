<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order Report.aspx.cs" Inherits="Order_Report" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Report</title>
    <style>
table{ 
table-layout:fixed; 
border-collapse:collapse; 
font-size:12px; 
padding:0px; 
margin:0px; 
} 
table tr{ 
border-bottom: 0px solid #cccccc; 
margin-bottom:0px; 
} 
table tr.header{ 
height:29px; 
background-image: none; 
} 
table th{ 
text-align:left; 
font-size:12px; 
font-weight:bold; 
text-indent:10px; 
padding:0px; 
margin:0px; 
background-image:url('table_middle_wh.png'); 
background-repeat:repeat-x; 
border-right:0px solid #cccccc; 
} 
table th.first{ 
background-image:url('tab_corner_left_long_wh.png'); 
background-position:0% 0%; 
background-repeat:no-repeat; 
} 
table th.last{ 
background-image:url('tab_corner_right_long_wh.png'); 
background-position:right top; 
background-repeat:no-repeat; 
border-right:0px none #000; 
} 
table td{ 
background-color:#ffffff; 
text-indent:0px; 
padding:2px 10px 10px 10px; 
border-bottom:0px solid #cccccc; 
vertical-align:top; 
border-left:0px solid #cccccc; 
} 
div.for_table{ 
background-image:url('border_right_wh.png'); 
background-position:right top; 
background-repeat:repeat-y; 
margin:0px 0px 0px 40px; 
padding:0px 0px 0px 0px; 
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
    <table cellpadding="0" cellspacing="0" width="100%">
    <tr>
    <td width=100% style="background-image:url(images/menu_bg.jpg)" colspan="4">
        <asp:Label runat="server" ID="LblOrderReport" Text="Order Report" Font-Bold="True"
            Font-Size="X-Large" ForeColor="Black"></asp:Label>
            </td>
            </tr>
            </table>
        <asp:Panel runat="server" ID="Panel1">
            <table cellpadding="0" cellspacing="0" >
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LblDate" Text="Date"></asp:Label>
                        </td>
                        <td>
                        <asp:TextBox runat="server" ID="Txtfromdate" Text=""></asp:TextBox>
                        </td>
                        <td>
                        <asp:Label runat="server" ID="Lblto" Text="To"></asp:Label>
                        </td>
                        <td>
                        <asp:TextBox runat="server" ID="Txttodate" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LblOrderstatus" Text="Order Status"></asp:Label>
                        </td>
                        <td>
                        <asp:DropDownList runat="server"  Width="150px"   ID="DropOrderstatus" AutoPostBack="true" OnSelectedIndexChanged="DropOrderstatus_SelectedIndexChanged">
                            <asp:ListItem Text="--Select--"></asp:ListItem>
                            <asp:ListItem Text="Pending for Invoice"></asp:ListItem>
                            <asp:ListItem Text="Invoice Done but delivery Pending"></asp:ListItem>
                            <asp:ListItem Text="Invoice And Delivery Done"></asp:ListItem>
                            <asp:ListItem Text="Invoice summary"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LblCity" Text="City" ></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="DropCity" Style="margin-left: 0px" width="150px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <table>
        <tr>
        <td align=center> 
        <asp:Button runat="server" ID="ButSearch" Text="Search" BackColor=LightSlateGray BorderWidth="1" ForeColor="White" Font-Bold="true" OnClick="ButSearch_Click" />
        <asp:Button runat="server" ID="ButPrint" Text="Print" backcolor=LightSlateGray ForeColor="White" Font-Bold="true"/>
        </td>
        </tr>
        </table>
        <asp:GridView runat="server" ID="GvOrderReport" AutoGenerateColumns="true">
            <RowStyle BackColor="LightCyan" Font-Bold="true" ForeColor="Black" />
            <AlternatingRowStyle BackColor="LightBlue" />
            <HeaderStyle BackColor="MidnightBlue" Font-Bold="true" ForeColor="White" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
