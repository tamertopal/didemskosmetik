<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Kalibim.master" AutoEventWireup="true" CodeFile="mesaj.aspx.cs" Inherits="Admin_mesaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" Width="786px" 
        CellPadding="4" ForeColor="#333333">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#E3EAEB" />
    <ItemTemplate>
    <table width="100%">
   <tr>
   <td>
       <img src="Images/edit.png" />Konu: <%#Eval("Konu") %> 
       <a href="mesaj.aspx?id=<%#Eval("id") %>&islem=Sil"> <img src="Images/stopicon.jpg"  align="right"/><hr /></td></a>
   </tr>
     <tr>
   <td>
       <img src="Images/sinavlari.png" />Mesaj:<br /> <%#Eval("Mesaj") %> <hr /></td>
    </tr>
      <tr>
   <td>
       <img src="Images/paylas.gif" />Adı:<%#Eval("Adi") %>&nbsp &nbsp &nbsp &nbsp<img src="Images/mail.jpg" /> Email:<%#Eval("Email") %></td>
     
          

    </tr>
    
    </table>
    </ItemTemplate>
        <SelectedItemStyle BackColor="#C5BBAF" ForeColor="#333333" Font-Bold="True" />
    </asp:DataList>
</asp:Content>

