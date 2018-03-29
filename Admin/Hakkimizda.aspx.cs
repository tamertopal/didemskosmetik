using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

public partial class Admin_Hakkimizda : System.Web.UI.Page
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
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Hakkımızda Sayfası";

        AdiSoyadiCek();

        Id = Request.QueryString["Id"];
        islem = Request.QueryString["islem"];

        if (islem == "Sil")
        {
            system.cmd("Delete from BizKimiz where Id =" + Id);
            Response.Redirect("Hakkimizda.aspx");
        }

     }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        string resimadi = "";
        string uzanti = "";
        int donusturme;

        if (fuResim.HasFile)
        {
            uzanti = Path.GetExtension(fuResim.PostedFile.FileName);
            resimadi = ayarlar.UrlSeo(txtAdiSoyadi.Text) + "_haberresim_" + uzanti;

            fuResim.SaveAs(Server.MapPath("../UrunResmi/sahte" + uzanti));

            Bitmap bmp = new Bitmap(Server.MapPath("../UrunResmi/sahte" + uzanti));
            using (Bitmap OrjinalResim = bmp)



                donusturme = 230;

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

            OleDbConnection baglan = system.baglan();
            OleDbCommand cmd = new OleDbCommand("Insert into BizKimiz (AdiSoyadi,Ozgecmis,Resim) values (@AdiSoyadi,@Ozgecmis,@Resim)", baglan);

            cmd.Parameters.Add("AdiSoyadi", txtAdiSoyadi.Text);
            cmd.Parameters.Add("Ozgecmis", Detay.Content);
            cmd.Parameters.Add("Resim", resimadi);
            cmd.ExecuteNonQuery();
            Response.Redirect("Hakkimizda.aspx");

        }
    }
    void AdiSoyadiCek()
    {
        DataTable dtOzgecmis = system.getdatatable("Select * from BizKimiz");
        DataList1.DataSource = dtOzgecmis;
        DataList1.DataBind();

    }
}