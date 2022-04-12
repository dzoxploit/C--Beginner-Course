<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextboxExample.aspx.cs" Inherits="Pertemuan_1_didinnuryahya_51419788.TextboxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Nama<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Label ID="Label_Hasil" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
