using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kozmetik : System.Web.UI.Page
{
    veritabani system = new veritabani();

    protected void Page_Load(object sender, EventArgs e)
    {
        UrunCek();
        VitrinCek();
    }
    void UrunCek()
    {
        rpkategoriler3.DataSource = system.getdatatable("Select Baslik,Id From Urunler Where KategoriId=1");
        rpkategoriler3.DataBind();
    }
    void VitrinCek()
    {
        dlvitrin3.DataSource = system.getdatatable("Select Baslik,Resim From Urunler Where KategoriId=1 and Vitrin=1");
        dlvitrin3.DataBind();
    }
}