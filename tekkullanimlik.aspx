<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tekkullanimlik.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <br />
        	<div id="icerik">
      			
      			<div id="iceriksolust"></div>
       		<div id="iceriksagust" class="h1">TEK KULLANIMLIK ÜRÜNLER</div>
       		
       		<div id="iceriksol"> 
 		     		<div id="iceriksolust1"></div>         
           		
   					<div id="iceriksolust2" class="p1">
                           <asp:Repeater ID="rpkategoriler" runat="server">
                          <ItemTemplate>
                           <p>
                               <img src="images/ilanlar.gif" />&nbsp&nbsp&nbsp<a href="urundetay3.aspx?id=<%#Eval("Id")%>"> <%#Eval("Baslik").ToString().ToUpper()%></a></p>
                          </ItemTemplate>
                           </asp:Repeater>
                     
   					
   					</div>
    				
	  		  <div id="iceriksolust3"></div>
    			 
    		</div>
       		<div id="iceriksag">
       		  <div id="iceriksagust2"></div>         
           		
   					<div id="iceriksagorta" class="p1">
    				
                     <asp:DataList ID="dlvitrin" runat="server" CellPadding="4" 
                            RepeatColumns="3" Width="600px" ForeColor="#333333">
                         <AlternatingItemStyle BackColor="White" />
                         <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                         <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                         <ItemStyle BackColor="#EFF3FB" />
                     <ItemTemplate>
                     <table width="200" height="200">
                     <tr><td valign="top"> Ürün Adı : <%#Eval("Baslik") %><br /></td></tr>
                     <tr> <td> <img src="UrunResmi/150/<%#Eval("Resim") %>"</td></tr> 
                     </table>
                   
                    </ItemTemplate>
                     
                          <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                     
                          </asp:DataList>
                        
                        
            </div>
            	<div id="iceriksagalt"></div>
         
			    </div>
</asp:Content>

