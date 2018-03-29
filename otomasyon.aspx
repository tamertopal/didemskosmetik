<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="otomasyon.aspx.cs" Inherits="otomasyon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="icerik">
      			
      			<div id="iceriksolust"></div>
       		<div id="iceriksagust" class="h1">OTOMASYON</div>
       		
       		<div id="iceriksol"> 
 		     		<div id="iceriksolust1"></div>         
           		
   					<div id="iceriksolust2" class="p1">
                           <asp:Repeater ID="rpkategoriler5" runat="server">
                          <ItemTemplate>
                           <p>
                               <img src="images/ilanlar.gif" />&nbsp&nbsp&nbsp <a href="urundetay5.aspx?id=<%#Eval("Id")%>"> <%#Eval("Baslik").ToString().ToUpper()%></a></p>
                          </ItemTemplate>
                           </asp:Repeater>
                     
   					
   					</div>
    				
	  		  <div id="iceriksolust3"></div>
    			 
    		</div>
       		<div id="iceriksag">
       		  <div id="iceriksagust2"></div>         
           		
   					<div id="iceriksagorta" class="p1">
    				
                     <asp:DataList ID="dlvitrin5" runat="server" CellPadding="4" 
                            RepeatColumns="3" Width="600px" ForeColor="#333333">
                         <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                         <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                         <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                     <ItemTemplate>
                     <table width="200" height="200">
                     <tr><td valign="top"> Ürün Adı : <%#Eval("Baslik") %><br /></td></tr>
                     <tr> <td> <img src="UrunResmi/150/<%#Eval("Resim") %>"</td></tr> 
                     </table>
                   
                    </ItemTemplate>
                     
                          <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                     
                          </asp:DataList>
                        
                        
            </div>
            	<div id="iceriksagalt"></div>
         
			    </div>
</asp:Content>

