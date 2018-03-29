using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Adminler : System.Web.UI.Page
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
            system.cmd("Delete from Adminler where Id =" + Id);
            Response.Redirect("Adminler.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Admin Yonetimi";
        AdminCek();
    }
    void AdminCek()
    {

        DataTable dtadminler = system.getdatatable("Select * from Adminler");
        dlAdminler.DataSource = dtadminler;
        dlAdminler.DataBind();

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = system.baglan();
        OleDbCommand cmd = new OleDbCommand("Insert into Adminler (AdiSoyadi, KullaniciAdi, Sifre) values (@AdiSoyadi,@KullaniciAdi,@Sifre)", baglan);
        cmd.Parameters.Add("AdiSoyadi", txtAdiSoyadi.Text);
        cmd.Parameters.Add("KullaniciAdi", txtKullaniciAdi.Text);
        cmd.Parameters.Add("Sifre", txtSifre.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("Adminler.aspx");

    }
}