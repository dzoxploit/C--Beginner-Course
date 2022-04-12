<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListboxExample.aspx.cs" Inherits="Pertemuan_1_didinnuryahya_51419788.ListboxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="0">C#</asp:ListItem>
            <asp:ListItem Value="1">VB</asp:ListItem>
            <asp:ListItem Value="2">Java</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
