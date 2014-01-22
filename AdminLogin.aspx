<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" MasterPageFile="~/AdminMaster.master" Inherits="AdminLogin" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register TagName="Captcha" TagPrefix="Controls" Src="~/Control/Captcha.ascx" %>



<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        
        
    <div>
  <asp:Label runat="server" id="Lblmsgbox" Font-Bold=true ForeColor=Red Text=""></asp:Label>
  <asp:Label runat="server" ID="Lbltype" Text="Admin" Visible="false"></asp:Label>
   <table runat="server" id="TblAddEdit" visible="true">
    
        <tr>
            <td>
                <asp:Label runat="server" ID="FirstName" Text="First Name" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
             </td>
            <td>
                <asp:TextBox runat="server" ID="Txtfirstname" Text=""></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LastName1" Text="Last Name" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtLastName" Text=""></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Address1" Text="Address" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtAddress" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Pincode1" Text="Pincode" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPincode" Text=""></asp:TextBox>
            </td>
        </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="City1" Text="City" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DropCityList" AutoPostBack="true"
                    onselectedindexchanged="DropCityList_SelectedIndexChanged"></asp:DropDownList>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="State" Text="State" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
           </td>
            <td>
                <asp:DropDownList runat="server" ID="Dropstate"  AutoPostBack="true"
                    onselectedindexchanged="Dropstate_SelectedIndexChanged"></asp:DropDownList>
                <asp:Label ID="Lblstate" runat="server" Text=" "></asp:Label>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="Phoneno" Text="Phoneno" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPhoneno" Text=""></asp:TextBox>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="BirthDate1" Text="Birth Date" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
               
                <asp:TextBox runat="server" ID="TxtBirthDate" Text="" ></asp:TextBox> 
                 <asp:CalendarExtender runat="server"  ID="CalendarExtender1" TargetControlID="TxtBirthDate">
                </asp:CalendarExtender>
             </td>          
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="EmailId1" Text="EmailId" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtEmailId" Text=""></asp:TextBox>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="Password" Text="Password" Font-Bold="True" 
                    ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPassword" Text=""></asp:TextBox>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="LblConfirmPassword" Text="Confirm Password" 
                    Font-Bold="True" ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtConfirmPassword" Text=""></asp:TextBox> 
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="TxtConfirmPassword" 
                    ErrorMessage="Password no mach plz Enter  retype password" 
                    ControlToCompare="TxtPassword"></asp:CompareValidator>
            </td>
       </tr>
       <tr>
            <td>
                <asp:CheckBox runat="server" ID="checkStatus" Text="" Visible="False" />
                
    
            </td>
       </tr>
       <tr>
            <td><asp:Button runat="server" ID="ButCreatemyaccount"         
                    Text="Create my account" CommandName="ButCreatemyaccount"
                    onclick="ButCreatemyaccount_Click" Font-Bold="True"  />
            <asp:Button runat="server" ID="ButCancel" Text="Cancel" onclick="ButCancel_Click" 
                    CommandName="ButCancel" Font-Bold="True" /></td>
       </tr>  
        
   </table>
        
    </div>
</asp:Content>
