<%@ Page Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="Color.aspx.cs" Inherits="Color" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="con1" Runat="Server">
<%--<asp:ScriptMan=ager ID="ScriptManager1" runat="server">
</asp:ScriptManager>--%>


    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    
   
<asp:textbox id="TextBox1" runat="server"  Width = "150px" />
<br />
<div id="preview" style="width:70px;height:70px;border:1px solid #000;margin:8px 3px;float:left">
</div>
<asp:Button ID="Button1" CssClass="choose_color" runat="server" Text="Choose Color" 
        onclick="Button1_Click" />

    <asp:ColorPickerExtender ID="ColorPickerExtender1" runat="server" targetcontrolid="TextBox1"
     samplecontrolid="preview" 
     popupbuttonid="Button1" 
     PopupPosition ="Right" OnClientColorSelectionChanged = "Color_Changed">
    </asp:ColorPickerExtender>

 <script type  "text/javascript">
    function Color_Changed(sender)
    {
        sender.get_element().value = "#" + sender.get_selectedColor();
        
    }
</script>

    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />

</asp:Content>

