<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Kalibim.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Admin_Hakkimizda" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 114px;
        }
        .style3
        {
            height: 23px;
        }
        .style4
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            
            <td class="style2">
                Başlık</td>
            <td>
                <asp:TextBox ID="txtAdiSoyadi" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Yazı</td>
            <td>
                <cc1:Editor ID="Detay" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Resim</td>
            <td>
                <asp:FileUpload ID="fuResim" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                <asp:Button ID="btnEkle" runat="server" onclick="btnEkle_Click" Text="Ekle" />
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="2">
    <asp:DataList ID="DataList1" runat="server" BackColor="White" 
        BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
        GridLines="Both" Width="529px">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <ItemStyle BackColor="White" ForeColor="#330099" />
        <ItemTemplate>
                <table Class="Normal" width="100%">
                    <tr>
                        <td width="60%"><img src="Images/file.gif" /><%#Eval("AdiSoyadi") %> </td>
                        <td width="40%" align="right"> <a href="Hakkimizda.aspx?Id=<%#Eval("Id") %>&islem=Sil"><img src="Images/stopicon.jpg" /></a></td>
                     </tr>
                </table>
       </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" 
            ForeColor="#663399" />
            </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

