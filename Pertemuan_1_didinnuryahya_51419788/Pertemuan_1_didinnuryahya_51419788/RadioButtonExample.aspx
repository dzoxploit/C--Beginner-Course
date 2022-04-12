<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonExample.aspx.cs" Inherits="Pertemuan_1_didinnuryahya_51419788.RadioButtonExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="c#">C#</asp:ListItem>
            <asp:ListItem>VB</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
