<%@ Page Language="C#" AutoEventWireup="true" CodeFile="shoppingbag.aspx.cs" MasterPageFile="~/MasterPage.master" Inherits="shopping_bag" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
   
    <asp:Panel runat="server" ID="IdInformation">
        <asp:Label runat="server" ID="LblCustomerId" Text=""></asp:Label>
        <asp:Label runat="server" ID="LblOrderId" Text=""></asp:Label>
        <asp:Label runat="server" ID="Lblmsg" Text=""></asp:Label>
    </asp:Panel>
    
    <table runat="server" id="Informaton"> 
   <tr>
    <td>
    <asp:Panel runat="server" ID="Shoppingbag">
    
        <asp:GridView ID="GvshoppingList" runat="server" 
        AutoGenerateColumns="False" DataKeyNames="CartId"
            onrowediting="GvshoppingList_RowEditing" 
            onrowcancelingedit="GvshoppingList_RowCancelingEdit" 
            onrowdeleting="GvshoppingList_RowDeleting" 
            onrowupdating="GvshoppingList_RowUpdating" 
        onselectedindexchanged="GvshoppingList_SelectedIndexChanged1" 
        onrowcommand="GvshoppingList_RowCommand" 
        onrowdatabound="GvshoppingList_RowDataBound" ShowFooter="true">
            <Columns>
            <asp:TemplateField HeaderText="Sr no">
                <ItemTemplate>
                    <asp:Label  runat="server" Id="LblSrno"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="cartId" >
                <ItemTemplate>
                    <asp:Label runat="server" ID="LblCartId" Text='<%#Eval("cartId")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label runat="server" ID="LblCartId" Text='<%#Eval("cartId")%>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                <asp:HiddenField runat="server" ID="hidcartId" Value='<%#Eval("cartId")%>' /> 
                <asp:HiddenField runat="server" ID="hidProductId" Value='<%#Eval("ProductId")%>' /> 
                 <asp:HiddenField runat="server" ID="hidSizeId" Value='<%#Eval("SizeId")%>'/> 
                 <asp:Image runat="server" Id="Image1" ImageUrl='<%#Eval("Image")%>' Width="75px" Height="150px" /> 
                
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Size">
                <ItemTemplate>
                    <asp:Label runat="server" ID="LblSize" Text='<%#Eval("Desc")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label runat="server" ID="LblSize" Text='<%#Eval("Desc")%>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Qty">
                <ItemTemplate>
                    <asp:Label   runat="server" ID="LblQty" Text='<%#Eval("Qty")%>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
               <asp:TextBox runat="server" ID="TxtQty" Text='<%#Bind("Qty")%>'></asp:TextBox> 
                </EditItemTemplate>
                 <ControlStyle Width="60px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <asp:Label runat="server" ID="LblPrice" Text='<%#Eval("Price") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:Label runat="server" ID="LblPrice" Text='<%#Bind("Price")%>'></asp:Label> 
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total">
            <ItemTemplate>
                 <asp:Label runat="server" ID="LblTotal" Text='<%#Bind("Total") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Label runat="server" ID="LblTotalAmt"/>
                </FooterTemplate>
            </asp:TemplateField> 
                   <asp:CommandField HeaderText="Edit-Update" ShowEditButton="true" ShowDeleteButton="true"/>   
            </Columns>
            <FooterStyle BackColor ="#336699" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
            <HeaderStyle BackColor="#336699" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
        </asp:GridView>
        </asp:Panel>
        
        
        <asp:Panel runat="server" id="ButtonInformation" Height="47px">
        <table>
            <tr>
            <td>
             <asp:Button runat="server" ID="ButOder" Text="Order Now" onclick="ButOder_Click"  />
            <asp:Button runat="server" ID="ButOderDetail" Text="Save Item" onclick="ButOderDetail_Click"  Visible="true"/>
            </td>
            </tr>
        </table>
        </asp:Panel>
        </td>
        <td>
        <asp:Panel runat="server" id="Oderinformation">
         <table runat="server" id="TblOderinformation" visible="false">
           <tr>
             <td>
                <asp:Label runat="server" ID="FirstName" Text="First Name"></asp:Label>
             </td>
            <td>
                <asp:TextBox runat="server" ID="Txtfirstname" Text=""></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LastName1" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtLastName" Text=""></asp:TextBox>
             </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Address1" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtAddress" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="Pincode1" Text="Pincode"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPincode" Text=""></asp:TextBox>
            </td>
        </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="City1" Text="City"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtCity" Text=""></asp:TextBox>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="State" Text="State"></asp:Label>
           </td>
            <td>
                <asp:TextBox runat="server" ID="TxtState" Text=""></asp:TextBox>
            </td>
       </tr>
       <tr>
            <td>
                <asp:Label runat="server" ID="Phoneno" Text="Phoneno"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPhoneno" Text=""></asp:TextBox>
            </td>
       </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="TotalAmt" Text="TotalAmt"></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" ID="LblTotal" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblPaymentOption" Text="PaymentOption"></asp:Label>
            </td>
        </tr>
        <tr>
             <td>
                <asp:RadioButtonList ID="OpPaymentoption" runat="server">
                    <asp:ListItem>Debit Card</asp:ListItem>
                    <asp:ListItem>Credit Card</asp:ListItem>
                </asp:RadioButtonList>
            </td>
       </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="ButPay" Text="Pay Now" onclick="ButPay_Click"/>
            </td>
        </tr>
    </table>
    </asp:Panel>
   </td>
</tr>
</table>
    </div>
</asp:Content>




