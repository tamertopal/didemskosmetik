using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;


public partial class Admin_UrunGuncelle : System.Web.UI.Page
{
    veritabani system = new veritabani();
    string Id = "";
    DataRow drhaber;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] == null)
        {
            Response.Redirect("login.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfabaslik");
        lbl1.Text = "Ürün Güncelleme Sayfası";

        Id = Request.QueryString["Id"];
        drhaber = system.getdatarow("Select * from Urunler where Id=" + Id);
        KategoriCek();


        if (drhaber != null)
        {
            if (Page.IsPostBack == false)
            {
                DropKategori.SelectedValue = drhaber["KategoriId"].ToString();
                txtBaslik.Text = drhaber["Baslik"].ToString();
               detay.Content = drhaber["Yazi"].ToString();

                if (drhaber["Resim"].ToString() != "")
                {
                    imgResim.ImageUrl = "../UrunResmi/150/" + drhaber["Resim"].ToString();
                }
                else
                {
                    imgResim.Visible = false;
                }
              if (drhaber["Vitrin"].ToString() == "1")
                    chkVitrin.Checked = true;
            }


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


    protected void btnEkle_Click(object sender, EventArgs e)
    {
        int Vitrin = 0;


        if (chkVitrin.Checked == true)
            Vitrin = 1;

        string uzanti = "";
        string resimadi = "";

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
                FileInfo fisahte = new FileInfo(Server.MapPath("../UrunResmi/sahte" + uzanti));
                fisahte.Delete();


            } 

           

          

        }  else 
            {
                resimadi=system.getdatacell("Select Resim from Urunler Where Id="+Id);

            }
             OleDbConnection baglan= system.baglan();
            OleDbCommand cmd= new OleDbCommand("Update From Urunler Set KategoriId=@KategoriId Baslik=@baslik,Yazi=@detay, Resim=@resmi, Vitrin=@vitrin Where id="+Id,baglan);
            cmd.Parameters.Add("KategoriId", DropKategori.SelectedValue);
            cmd.Parameters.Add("baslik", txtBaslik.Text);
            cmd.Parameters.Add("detay", detay.Content);
            cmd.Parameters.Add("resmi", resimadi);
            cmd.Parameters.Add("vitrin", Vitrin);
            cmd.ExecuteNonQuery();
            Response.Redirect("Urunler.aspx");

    }

}