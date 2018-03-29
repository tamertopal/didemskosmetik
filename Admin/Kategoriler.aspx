<%@ Page Title="" Language="C#" MasterPageFile="Kalibim.master" AutoEventWireup="true" CodeFile="Kategoriler.aspx.cs" Inherits="Admin_Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 115px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                Kategori Adı:</td>
            <td>
                <asp:TextBox ID="txtKategoriAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sırası:</td>
            <td>
                <asp:TextBox ID="txtSira" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" onclick="btnEkle_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:DataList ID="dlKategoriler" runat="server" CellPadding="4" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
        GridLines="Both" Width="507px">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <ItemStyle BackColor="White" ForeColor="#330099" />
        <ItemTemplate>
            <table class="Normal" width="100%">
                <tr>
                    <td width="35%"><%#Eval("KategoriAdi") %></td>
                    <td width="35%" align="right"><%#Eval("Sira") %></td>
                    <td width="30%" align="right"> <a href="Kategoriler.aspx?Id=<%#Eval("Id") %>&islem=Sil"> <img border="0" src="Images/stopicon.jpg" /></a></td>
                   
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    </asp:DataList>
</asp:Content>

