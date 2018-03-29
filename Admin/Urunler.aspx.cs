using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Urunler : System.Web.UI.Page
{
    veritabani system = new veritabani();

    string Id = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] == null)
        {
            Response.Redirect("login.aspx");
        }
        Id = Request.QueryString["Id"];
        islem = Request.QueryString["islem"];

        if (islem == "Sil")
        {
            system.cmd("Delete from Urunler Where Id=" + Id);
            Response.Redirect("Urunler.aspx");
        }

        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Ürün Yönetimi";
        UrunCek();

        
    }
    void UrunCek()
    {
        DataTable dtUrunler = system.getdatatable("Select * from Urunler");
        rpUrunler.DataSource = dtUrunler;
        rpUrunler.DataBind();

    }
}