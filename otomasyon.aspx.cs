using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class otomasyon : System.Web.UI.Page
{
    veritabani system = new veritabani();
    string Baslik;

    protected void Page_Load(object sender, EventArgs e)
    {
        UrunCek();
        VitrinCek();
        if (rpkategoriler5 == null)
        Baslik="Henüz bu alana veri girilmedi";
           
       
    }
    void UrunCek()
    {
        rpkategoriler5.DataSource = system.getdatatable("Select Baslik,Id From Urunler Where KategoriId=5");
        rpkategoriler5.DataBind();
    }
    void VitrinCek()
    {
        dlvitrin5.DataSource = system.getdatatable("Select Baslik,Resim From Urunler Where KategoriId=5 and Vitrin=1");
        dlvitrin5.DataBind();
    }
}