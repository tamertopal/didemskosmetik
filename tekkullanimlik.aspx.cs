using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    veritabani system = new veritabani();


    protected void Page_Load(object sender, EventArgs e)
    {
        UrunCek();
        VitrinCek();

    }
    void UrunCek()
    {
        rpkategoriler.DataSource = system.getdatatable("Select Baslik,Id From Urunler Where KategoriId=3");
        rpkategoriler.DataBind();
    }
    void VitrinCek()
    {
       dlvitrin.DataSource = system.getdatatable("Select Baslik,Resim From Urunler Where KategoriId=3 and Vitrin=1");
            dlvitrin.DataBind();

    }
}