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
        YaziCek();
        UrunCek();
    }
    void YaziCek()
    {
        DataTable dt = system.getdatatable("Select * from Yazilar");
        rpYazilar.DataSource = dt;
        rpYazilar.DataBind();
    }
    void UrunCek()
    {
        rpkategoriler3.DataSource = system.getdatatable("Select * From iletisim");
        rpkategoriler3.DataBind();
    }
}