<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Kalibim.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="Admin_iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 144px;
        }
        .style3
        {
            width: 144px;
            height: 26px;
        }
        .style4
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                Adres Bilgisi</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                E-Mail</td>
            <td>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Telefon</td>
            <td>
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                GSM</td>
            <td class="style4">
                <asp:TextBox ID="txtGsm" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnEkle" runat="server" onclick="btnEkle_Click" Text="Ekle" />
            </td>
        </tr>
    </table>
    <asp:DataList ID="dlAdminler" runat="server">
    <ItemTemplate>
    <table class="Normal" width="100%" >
                                <tr>
                                <td width="50%"><%#Eval("Adres") %></td>
                                <td width="50%" align="right">
                                   <a href="iletisim.aspx?Id=<%#Eval("Id") %>&islem=Sil"> <img border="0" src="Images/stopicon.jpg" /></a>
                                </td>
                            </tr>
    </ItemTemplate>
    </asp:DataList>
</asp:Content>

