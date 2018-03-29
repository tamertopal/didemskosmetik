<%@ Page Title="" Language="C#" MasterPageFile="Kalibim.master" AutoEventWireup="true" CodeFile="Adminler.aspx.cs" Inherits="Admin_Adminler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            width: 146px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="Normal" width="100%">
        <tr>
            <td class="style3">
                Adı Soyadı:</td>
            <td>
                <asp:TextBox ID="txtAdiSoyadi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Kullanıcı Adı:</td>
            <td>
                <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Şifre:</td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                ŞifreTekrar:</td>
            <td>
                <asp:TextBox ID="txtSifre2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="validSifre" runat="server" 
                    ControlToCompare="txtSifre" ControlToValidate="txtSifre2" 
                    ErrorMessage="Şifreler Eşleşmiyor!"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" onclick="btnEkle_Click" />
                <br />
                <br />
            </td>
        </tr>
        </table>
    <asp:DataList ID="dlAdminler" runat="server" CellPadding="4" Width="70%" 
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        GridLines="Both">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <ItemStyle BackColor="White" ForeColor="#003399" />
                    <ItemTemplate>
                        <table class="Normal" width="100%" >
                                <tr>
                                <td width="25%"><%#Eval("AdiSoyadi") %></td>
                                <td width="25%"><%#Eval("KullaniciAdi") %></td>
                                <td width="25%"><%#Eval("Sifre") %></td>
                                <td width="25%" align="right">
                                   <a href="Adminler.aspx?Id=<%#Eval("Id") %>&islem=Sil"> <img border="0" src="Images/stopicon.jpg" /></a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                </asp:DataList>
</asp:Content>

