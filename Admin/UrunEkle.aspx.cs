using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

public partial class Admin_UrunEkle : System.Web.UI.Page
{
    veritabani system = new veritabani();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] == null)
        {
            Response.Redirect("login.aspx");
        }
        if (Page.IsPostBack == false)
        {
            KategoriCek();
        }

        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Ürün Ekle";

        //resim işlemleri

        string resimadi = "";
        string uzanti = "";

        if (fuResim.HasFile)
        {
            uzanti = Path.GetExtension(fuResim.PostedFile.FileName);
            resimadi = ayarlar.UrlSeo(txtBaslik.Text) + "_haberresim_" + uzanti;

            fuResim.SaveAs(Server.MapPath("../UrunResmi/sahte" + uzanti));


            int donusturme = 800;
            Bitmap bmp = new Bitmap(Server.MapPath("../UrunResmi/sahte" + uzanti));
            using (Bitmap OrjinalResim = bmp)
            {
                double ResYukseklik = OrjinalResim.Height;
                double ResGenislik = OrjinalResim.Width;
                double oran = 0;

                if (ResGenislik >= donusturme)
                {
                    oran = ResGenislik / ResYukseklik;
                    ResGenislik = donusturme;
                    ResYukseklik = donusturme / oran;

                    Size yenidegerler = new Size(Convert.ToInt32(ResGenislik), Convert.ToInt32(ResYukseklik));
                    Bitmap yeniresim = new Bitmap(OrjinalResim, yenidegerler);
                    yeniresim.Save(Server.MapPath("../UrunResmi/800/" + resimadi));

                    yeniresim.Dispose();
                    OrjinalResim.Dispose();
                    bmp.Dispose();


                }
                else
                {
                    fuResim.SaveAs(Server.MapPath("../UrunResmi/800/" + resimadi));

                }


            }

            donusturme = 150;
            bmp = new Bitmap(Server.MapPath("../UrunResmi/sahte" + uzanti));
            using (Bitmap OrjinalResim = bmp)
            {
                double ResYukseklik = OrjinalResim.Height;
                double ResGenislik = OrjinalResim.Width;
                double oran = 0;

                if (ResGenislik >= donusturme)
                {
                    oran = ResGenislik / ResYukseklik;
                    ResGenislik = donusturme;
                    ResYukseklik = donusturme / oran;

                    Size yenidegerler = new Size(Convert.ToInt32(ResGenislik), Convert.ToInt32(ResYukseklik));
                    Bitmap yeniresim = new Bitmap(OrjinalResim, yenidegerler);
                    yeniresim.Save(Server.MapPath("../UrunResmi/150/" + resimadi));

                    yeniresim.Dispose();
                    OrjinalResim.Dispose();
                    bmp.Dispose();

                    //FileInfo fisahte=new FileInfo(Server.MapPath("../HaberResmi/sahte"+uzanti));
                    //fisahte.Delete();    
                }
                else
                {
                    fuResim.SaveAs(Server.MapPath("../UrunResmi/150/" + resimadi));

                }
                FileInfo fisahte = new FileInfo(Server.MapPath("../UrunResmi/sahte" + uzanti));
                fisahte.Delete();


            }
            int vitrin;
            vitrin = 0;
            if (chkVitrin.Checked == true)
                vitrin = 1;

            OleDbConnection baglan = system.baglan();
            OleDbCommand cmd = new OleDbCommand("Insert into Urunler (KategoriId,Baslik,Yazi,Resim,Vitrin) values (@KategoriId,@Baslik,@Yazi,@Resim,@vitrin)",baglan);
            cmd.Parameters.Add("KategoriID", DropKategori.SelectedValue);
            cmd.Parameters.Add("Baslik", txtBaslik.Text);
            cmd.Parameters.Add("Yazi",detay.Content);
            cmd.Parameters.Add("Resim", resimadi);
            cmd.Parameters.Add("Vitrin", vitrin);
            cmd.ExecuteNonQuery();
            Response.Redirect("UrunEkle.aspx");

           
        }

    }
    void KategoriCek()
    {
        DataTable dtKategoriler = system.getdatatable("Select * from Kategoriler Order by Sira");

        DropKategori.Items.Add("Seçiniz");
        DropKategori.Items[0].Value = "0";
        int sira = 1;

        for (int i = 0; i < dtKategoriler.Rows.Count; i++)
        {
            DataRow drKategori = dtKategoriler.Rows[i];
            DropKategori.Items.Add(drKategori["KategoriAdi"].ToString());
            DropKategori.Items[sira].Value = drKategori["Id"].ToString();
            sira++;
        }
    }
}