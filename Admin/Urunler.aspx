<%@ Page Title="" Language="C#" MasterPageFile="Kalibim.master" AutoEventWireup="true" CodeFile="Urunler.aspx.cs" Inherits="Admin_Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 18px;
        }
        .style2
        {
            width: 20px;
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <img alt="" class="style2" src="Images/ekle.gif" /><asp:HyperLink ID="hprEkle" 
        runat="server" NavigateUrl="UrunEkle.aspx">Ürün Ekle</asp:HyperLink>
    <br />
    <br />
    <asp:Repeater ID="rpUrunler" runat="server">
    <ItemTemplate>
     <table width="100%" cellpadding="1" cellspacing="1" class="normal">
    <tr>
        <td>
            <img src="Images/file.gif" align="absmiddle"/><%#Eval("Baslik") %></td>
             <td align="right">
        <a href="UrunGuncelle.aspx?Id=<%#Eval("Id") %>"><img src="Images/edit.png" /></a>
          <a href="Urunler.aspx?Id=<%#Eval("Id") %>&islem=Sil"><img border="0" src="Images/stopicon.jpg" /></a> 

           
        </td>
    </tr>
    </table>
    </ItemTemplate>
    </asp:Repeater>
</asp:Content>

