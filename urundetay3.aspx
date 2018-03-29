<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="urundetay3.aspx.cs" Inherits="urundetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="icerik">

      			
      			<div id="iceriksolust"></div>
       		<div id="iceriksagust" class="h1">TEK KULLANIMLIK ÜRÜNLER</div>
       		
       		<div id="iceriksol"> 
 		     		<div id="iceriksolust1"></div>         
           		
   					<div id="iceriksolust2" class="p1">
                           <asp:Repeater ID="rpkategoriler" runat="server">
                          <ItemTemplate>
                           <p class="p1">
                               <img src="images/ilanlar.gif" />&nbsp&nbsp&nbsp <a href="urundetay3.aspx?id=<%#Eval("Id") %>"><%#Eval("Baslik").ToString().ToUpper()%></a></p>
                          </ItemTemplate>
                           </asp:Repeater>
                     
   					
   					</div>
    				
	  		  <div id="iceriksolust3"></div>
    			 
    		</div>
       		<div id="iceriksag">
       		  <div id="iceriksagust2"></div>         
           		
   					<div id="iceriksagorta" class="p1">
    				
                         <a href="siparis.aspx" class="p1"> <img src="images/unbennant.jpg"  align="right"/></a>
                         <br />
                        <br />
                       
                        <asp:Repeater ID="rptHakkimizda" runat="server">
                       <ItemTemplate>
                       <div id="hakkimizda">
                            <div id="hakkimizdabaslik">
                               <center> <%#Eval("Baslik") %><br />
                                    </center>
                            </div><br />
                         
                            <div id="hakkimizdayazi"><img src="UrunResmi/150/<%#Eval("Resim") %>" align="right" vspace="15" hspace="10"/><p> <%#Eval("Yazi") %></p> 
                       </div>
                       <br />
                     
                           
    				       </div>
                          
                        
              <p class="ortabaslik"></p>
                       
                       </ItemTemplate>
                       </asp:Repeater><br />
                        
                     
            </div>
            	<div id="iceriksagalt"></div>
         
			    </div>
</asp:Content>

