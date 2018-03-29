using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urundetay : System.Web.UI.Page
{
    veritabani system = new veritabani();
    public string id = "";
    public string KategoriId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.QueryString["Id"];
        UrunCek();
        KategoriCek();
    }
    void UrunCek()
    {
        
        DataTable dt = system.getdatatable("Select * from Urunler Where Id="+Convert.ToInt32(id));
        rptHakkimizda.DataSource = dt;
        rptHakkimizda.DataBind();
    }
    void KategoriCek()
    {
        rpkategoriler.DataSource = system.getdatatable("Select Baslik,Id From Urunler Where KategoriId=2");
        rpkategoriler.DataBind();
    }

   
    
        
   
}