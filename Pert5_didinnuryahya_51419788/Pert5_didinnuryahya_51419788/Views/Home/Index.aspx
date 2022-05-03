<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Pert5_didinnuryahya_51419788.Models.Class1>" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat ="server">
    <meta name="viewport" content="width=device-width" />
    <title>View1</title>
</head>
<body>
    <form id="Form1" runat="server" method="post" style="padding-left:100px; padding-top:100px">
    <div>
        <table>
            <tr>
                <td colspan="2">
                    <h1>Login Form</h1>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" Text="Nama" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nm" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" Text="Password:" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox TextMode="Password" ID="Pass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" />
                </td>
                <td><a href="home/Index2">not register yet!</a></td>
            </tr>
        </table>
        
    </div>
        </form>
</body>
</html>
