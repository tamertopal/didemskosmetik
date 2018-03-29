<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div id="hizmetler"></div>
        	<div id="icerik">
      			
      			<div id="iceriksolustilet"></div>
       		<div id="iceriksagust" class="h1">VİZYONUMUZ</div>
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
                           <asp:Repeater ID="rpYazilar" runat="server">
                           <ItemTemplate>
                           	  <p> <strong><center>
    				    <%#Eval("Baslik") %>
    				  </center></strong> </p>
    				  <p> <%#Eval("Detay") %></p>
                           
                           </ItemTemplate>
                           </asp:Repeater>
                        
              <p class="ortabaslik">&nbsp;</p></div>
            	<div id="iceriksagalt"></div>
         
			</div>
</asp:Content>

