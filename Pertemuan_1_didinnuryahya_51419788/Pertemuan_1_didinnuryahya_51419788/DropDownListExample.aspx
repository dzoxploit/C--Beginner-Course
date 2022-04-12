<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownListExample.aspx.cs" Inherits="Pertemuan_1_didinnuryahya_51419788.DropDownListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="0">komputer</asp:ListItem>
            <asp:ListItem Value="1">Sepeda</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
