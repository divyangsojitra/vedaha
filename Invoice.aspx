<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Invoice.aspx.cs" MasterPageFile="~/AdminMaster.master" Inherits="Invoice" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="con1">
   <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
    <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    <table runat="server" id="Tbluse">
    <tr>
        <td>
            <asp:Panel runat="server" ID="userOrderinformation">
    <table style="width: 556px">
    <tr>
        <td>
            <asp:Label runat="server" ID="LblInvoice" Text="InvoiceDate"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtInvoiceDate" Text=""></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label runat="server" ID="LblFinalDeliveryDate" Text="FinalDeliveryDate"></asp:Label>
        </td>
        <td>
            <asp:TextBox runat="server" ID="TxtFinaldeliveryDate" Text=""></asp:TextBox>
        </td>
    </tr>
    
    
    
    
        <tr>
            <td class="style6">
                <asp:Label runat="server" ID="LblOrderId1" Text="OrderId:"></asp:Label>
            </td>
            <td >
                <asp:Label runat="server" ID="LblOrderId" Text=""></asp:Label>
            </td>
       </tr> 
        <tr>
            <td class="style6" >
                <asp:Label runat="server" ID="LblOrderDate1" Text="Order Date:"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="LblOrderDate" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="CustomerAccountNo" Text="CustomerAccountNo"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="LblCustomerAccountNo" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="EmailId" Text="EmailId"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="LblEmailId" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Mob" Text="Phoneno"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LblPhone" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        </table>
    </asp:Panel>
    
        </td>
    </tr>
    
  
    
    <tr>
    <td class="style9">
    <asp:Panel runat="server" ID="UserAddress" Width="557px">
    <table>
        <tr>
            <td class="style7">
                <asp:Label runat="server" ID="LblFirstname1" Text="Name:"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="LblFirstname" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:Label runat="server" ID="LblAddress1" Text="Address:"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="LblAddress" Text=""></asp:Label>
            </td>
         <tr>
             <td class="style7">
                <asp:Label runat="server" ID="LblCity1" Text="City:"></asp:Label>
             </td>
             <td>
                <asp:Label runat="server" ID="LblCity" Text=""></asp:Label> 
             </td>
         </tr>
         <tr>
               <td class="style7">
                  <asp:Label runat="server" ID="LblPincode1" Text="PinCode:"></asp:Label>
               </td>
               <td>
                   <asp:Label runat="server" ID="LblPincode" Text=""></asp:Label>
               </td>
         </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="LblState1" runat="server" Text="State:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LblState" runat="server" Text=""></asp:Label>
                    
                </td>
            </tr>
    </table>
    </asp:Panel>
    <td>
    </td>
    </td>
    </tr>
    <tr>
    <td class="style9">
        <asp:Panel runat="server" Id="shopingList" Width="547px" >
                <asp:GridView ID="GvShopingList" runat="server" AutoGenerateColumns="false" 
                    DataKeyNames="OrderId" Width="541px">
                    <Columns>
                        <asp:BoundField HeaderText="ProductId" DataField="ProductId" />
                        <asp:BoundField HeaderText="Product Name" DataField="ProductName" />
                        <asp:ButtonField HeaderText="Size" DataTextField="Desc" />
                        <asp:BoundField HeaderText="Qty" DataField="Qty" />
                        <asp:BoundField HeaderText="Price" DataField="Price" />
                        <asp:BoundField HeaderText="Total" DataField="LineTotalAmt" />
                        
                        <asp:TemplateField>
                        <FooterTemplate>
                            <asp:Label runat="server" ID="LblTotal" Text=""></asp:Label>
                            
                        </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor ="#336699" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
            <HeaderStyle BackColor="#336699" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                </asp:GridView>
                <asp:Label runat="server" ID="Label1" Text="Total"  Width="450" BackColor="#336699" Font-Bold ="true" ForeColor="White" ></asp:Label> 
                <asp:Label runat="server" ID="LblTotalAmt" Text="" BackColor="#336699" Font-Bold ="true" ForeColor="White"></asp:Label>
    </asp:Panel>
    </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:Panel runat="server" ID="PaymentDetails">
            <table>
                <tr>
                    <td class="style8">
                        <asp:Label runat="server" ID="LblTransactionId1" Text="TransactionId:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LblTransactionId" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <asp:Label runat="server" ID="LblPaymentDate1" Text="PaymentDate:"></asp:Label>
                    </td> 
                    <td>
                        <asp:Label runat="server" ID="LblPaymentDate" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <asp:Label runat="server" ID="LblPaymentType1" Text="PaymentType:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LblPaymentType" Text=""></asp:Label>
                    </td>
               </tr>
               <tr>
                    <td>
                        <asp:Label runat="server" ID="LblCardHolderName1" Text="CardHolderName"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LblCardHolderName" Text=""></asp:Label>
                    </td>
               </tr>
               <tr>
                    <td class="style8">
                        <asp:Label runat="server" ID="Card" Text="Card:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="LblCard" Text=""></asp:Label>
                    </td>
               </tr>
               <tr>
                    <td>
                        <asp:Label runat="server" ID="Label2" Text="Act_Delievery_date"></asp:Label>
                        
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBox1" Text="" Width="118px"></asp:TextBox>
                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" >
                        </asp:CalendarExtender>
                    </td>
                </tr>
               <tr>
                    <td>
                        <asp:CheckBox runat="server" ID="checkDelivaryStatus" Text="checkDelivaryStatus" Visible="false" />
                    </td>
               </tr>
               
            </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
    <td>
     <asp:Panel runat="server" Id="Button">
        <table>
           <tr>
             <td>
                <asp:Button runat="server" ID="ButSubmit" CommandName="Submit" Text="Submit" 
                     onclick="ButSubmit_Click" />
              </td>
           <td>
                <asp:Button runat="server" ID="ButPrint" CommandArgument="Print" Text="Print" Visible="false"
                    onclick="ButPrint_Click" />
           </td>
           </tr> 
         </table>
      </asp:Panel>
    </td>
    </tr>
    </table>
    
   
     </asp:Content>
   
