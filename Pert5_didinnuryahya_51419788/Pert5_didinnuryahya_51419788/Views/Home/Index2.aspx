<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Pert5_didinnuryahya_51419788.Models.Class2>" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index2</title>
</head>
<body>
    <div>
        <form id="Form1" method="post" runat="server" style="padding-left:100px; padding-top:100px;">
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2">
                        <h1>REGISTER FORM</h1>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server">Username</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="nm" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server">Password</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="Pass" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="Button1" runat="server" Text="Register"></asp:Button>
                    </asp:TableCell>
                    <asp:TableCell>
                        <label><%:Model.status %></label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </form>
    </div>
</body>
</html>

