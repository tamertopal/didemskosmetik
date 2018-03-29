using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class temizlik : System.Web.UI.Page
{
    veritabani system = new veritabani();

    protected void Page_Load(object sender, EventArgs e)
    {
        UrunCek();
        VitrinCek();
    }
    void UrunCek()
    {
        rpkategoriler4.DataSource = system.getdatatable("Select Baslik,Id From Urunler Where KategoriId=4");
        rpkategoriler4.DataBind();
    }
    void VitrinCek()
    {
        dlvitrin4.DataSource = system.getdatatable("Select Baslik,Resim From Urunler Where KategoriId=4 and Vitrin=1");
        dlvitrin4.DataBind();
    }
}