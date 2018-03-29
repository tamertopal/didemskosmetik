<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AdminStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table align="center">
        <tr>
            <td class="h1" colspan="2" align="center">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="h1" colspan="2" align="center">
                YÖNETİM PANELİ GİRİŞ<br />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Kullanıcı Adı</td>
            <td>
                <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Şifre</td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Giriş" onclick="Button1_Click" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
