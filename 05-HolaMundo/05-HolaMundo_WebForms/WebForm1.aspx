<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_05_HolaMundo_WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px;">
            <asp:Label runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox runat="server" ID="inputName"></asp:TextBox>
            
            <asp:Label runat="server" id="lblError" style="color:red;"></asp:Label>
        </div>
        
        <asp:Button runat="server" Text="Saluda" style="margin-left:10px; padding:5px; font-weight:bold;" OnClick="onBtnSaludoClick"></asp:Button>

        <div style="padding: 20px; border:solid 2px black; margin:1em; text-align:center; height:20px;">
            <asp:Label runat="server" id="lblSaludo"></asp:Label>
        </div>
    </form>
</body>
</html>
