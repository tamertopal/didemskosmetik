using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tekstil : System.Web.UI.Page
{
    veritabani system = new veritabani();

    protected void Page_Load(object sender, EventArgs e)
    {
        UrunCek();
        VitrinCek();
    }
    void UrunCek()
    {
        rpkategoriler2.DataSource = system.getdatatable("Select Baslik,Id From Urunler Where KategoriId=2");
        rpkategoriler2.DataBind();
    }
    void VitrinCek()
    {
        dlvitrin2.DataSource = system.getdatatable("Select Baslik,Resim From Urunler Where KategoriId=2 and Vitrin=1");
        dlvitrin2.DataBind();
    }
}