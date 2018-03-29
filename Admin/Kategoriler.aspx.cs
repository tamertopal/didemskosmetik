using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Kategoriler : System.Web.UI.Page
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
            system.cmd("Delete from Kategoriler where Id =" + Id);
            Response.Redirect("Kategoriler.aspx");
        }
                

        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Kategori Yönetimi";
        KategoriCek();



    }
    protected void btnEkle_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = system.baglan();
        OleDbCommand cmd = new OleDbCommand("Insert into Kategoriler (KategoriAdi,Sira) Values (@KategoriAdi, @Sira)",baglan);
        cmd.Parameters.Add("KategoriAdi", txtKategoriAdi.Text);
        cmd.Parameters.Add("Sira", Convert.ToInt32(txtSira.Text));
        cmd.ExecuteNonQuery();
        Response.Redirect("Kategoriler.aspx");
    }
    void KategoriCek()
    {
        DataTable dtKategoriler = system.getdatatable("Select * from Kategoriler");
        dlKategoriler.DataSource = dtKategoriler;
        dlKategoriler.DataBind();
    }
}