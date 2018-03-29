<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="siparis.aspx.cs" Inherits="siparis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 608px;
        }
        .style2
        {
            width: 213px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="icerik">
   			<div id="iceriksolustilet"></div>
       		<div id="iceriksagust" class="h1">SİPARİS FORMU</div>
       		<br />
       		<div id="iceriksol"> 
 		     <div id="iceriksolust1"></div>         
           		
   					<div id="iceriksolust2" class="p1">
   					 
                           <asp:Repeater ID="rpkategoriler3" runat="server">
                          <ItemTemplate>
                            <p><img src="Admin/Images/adres.jpg" /><br /><%#Eval("Adres")%></p>
                              <p><img src="Admin/Images/mail.jpg" /><br /><%#Eval("Email")%></p>
                                <p><img src="Admin/Images/tel.jpg" /><br /><%#Eval("Telefon")%></p>
                                  <p><img src="Admin/Images/gsm.jpg" /><br /><%#Eval("GSM")%></p>
                           
                              
                          </ItemTemplate>
                           </asp:Repeater>   
</div>
    				
	  		  <div id="iceriksolust3"></div>
    			 
    			 
    		</div>
       		<div id="iceriksag">
       		  <div id="iceriksagust2"></div>         
           		<div id="iceriksagorta" class="p1">
    				 
                        
                    <table class="style1">
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:Label ID="lblBilgi" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Adınız</td>
                            <td>
                                <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="txtAdi" ErrorMessage="Boş bırakılamaz!"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                E-Posta Adresiniz</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtEmail" ErrorMessage="Yanlış Email Adresi" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                    Visible="False"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Telefon</td>
                            <td>
                                <asp:TextBox ID="txtKonu" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Adresiniz</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Sipariş Açıklamanız</td>
                            <td>
                                <asp:TextBox ID="txtAciklama" runat="server" Height="68px" TextMode="MultiLine" 
                                    Width="378px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnGonder" runat="server" onclick="btnGonder_Click" 
                                    Text="Gönder" />
                            </td>
                            
                        </tr>
                        
                        </table>
    				 
                        
              </div>
            	<div id="iceriksagalt">
                    
                </div>
         
			</div>
</asp:Content>

