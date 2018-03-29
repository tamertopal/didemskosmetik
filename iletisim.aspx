<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="icerik">
   			<div id="iceriksolustilet"></div>
       		<div id="iceriksagust" class="h1">İLETİŞİM FORMU</div>
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
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                E-mail</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Konu</td>
                            <td>
                                <asp:TextBox ID="txtKonu" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                Mesaj</td>
                            <td>
                                <asp:TextBox ID="txtMesaj" runat="server" Height="142px" TextMode="MultiLine" 
                                    Width="496px"></asp:TextBox>
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
                        
                        <tr>
                            <td class="h1" colspan="2">
                           <br />
                            <br />
                            Biz Neredeyiz!
                            <br />
                            <br />
                          <br />
                                <div id="harita">
                                
                                <iframe width="425" height="350" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=tr&amp;geocode=&amp;q=didems+kozmetik+36.839893,34.663882&amp;aq=&amp;sll=36.83402,34.66341&amp;sspn=0.019544,0.0421&amp;vpsrc=6&amp;g=36.839893,34.663882&amp;ie=UTF8&amp;t=h&amp;ll=36.83402,34.66341&amp;spn=0.019544,0.0421&amp;output=embed"></iframe><br /><small>Şunu daha büyük bir haritada görüntüle: <a href="http://maps.google.com/maps?f=q&amp;source=embed&amp;hl=tr&amp;geocode=&amp;q=didems+kozmetik+36.839893,34.663882&amp;aq=&amp;sll=36.83402,34.66341&amp;sspn=0.019544,0.0421&amp;vpsrc=6&amp;g=36.839893,34.663882&amp;ie=UTF8&amp;t=h&amp;ll=36.83402,34.66341&amp;spn=0.019544,0.0421" style="color:#0000FF;text-align:left">Kaydedilen Yerler</a></small>
                                
                                </div>
                                </td>
                            
                        </tr>
                        
                    </table>
    				 
                        
              </div>
            	<div id="iceriksagalt">
                    
                </div>
         
			</div>
</asp:Content>

