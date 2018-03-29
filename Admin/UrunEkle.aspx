<%@ Page Title="" Language="C#" MasterPageFile="Kalibim.master" AutoEventWireup="true" CodeFile="UrunEkle.aspx.cs" Inherits="Admin_UrunEkle" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            width: 104px;
        }
        .style4
        {
            height: 23px;
            width: 104px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style4">
                Kategori Adı</td>
            <td class="style2">
                <asp:DropDownList ID="DropKategori" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Başlık</td>
            <td>
                <asp:TextBox ID="txtBaslik" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Detay</td>
            <td>
                <cc1:Editor ID="detay" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                Resim</td>
            <td>
                <asp:FileUpload ID="fuResim" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                Vitrin</td>
            <td>
                <asp:CheckBox ID="chkVitrin" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style2">
                <asp:Button ID="btnEkle" runat="server" Text="Ürün Ekle" />
            </td>
        </tr>
    </table>
</asp:Content>

