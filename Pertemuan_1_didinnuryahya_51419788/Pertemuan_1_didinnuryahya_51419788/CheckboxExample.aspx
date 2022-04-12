<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckboxExample.aspx.cs" Inherits="Pertemuan_1_didinnuryahya_51419788.CheckboxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>VB</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
        </asp:CheckBoxList>
    
    </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
