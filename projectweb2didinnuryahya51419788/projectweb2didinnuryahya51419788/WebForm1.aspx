<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="projectweb2didinnuryahya51419788.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Studi Web Form</title>
    <style>
        .style1 {
           width:156px;
        }
        .style2 {
            width:332px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:54%">
            <tr>
                <td class="style1">Nama</td>
                <td class="style2">
                    <asp:TextBox ID="txtnama" runat="server" style="width:230px">
                    </asp:TextBox>
                </td>
            </tr>
              <tr>
                <td class="style1">Alamat</td>
                <td class="style2">
                    <asp:TextBox ID="txtalamat" runat="server" style="width:230px">
                    </asp:TextBox>
                </td>
            </tr>
              <tr>
                <td class="style1">Kota</td>
                <td class="style2">
                    <asp:TextBox ID="txtkota" runat="server" style="width:230px">
                    </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">Provinsi</td>
                <td class="style2">
                    <asp:TextBox ID="txtprovinsi" runat="server" style="width:230px">
                    </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1"></td>
                <td id="displayrow" runat="server" class="style2"></td>
            </tr>
        </table>
    </div>
        <asp:Button ID="Button1" runat="server" style="width:230px" OnClick="Button1_click" Text="OK"/>
    </form>
</body>
</html>
