using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Giris : System.Web.UI.Page
{   veritabani system=new veritabani();
        string Id = "";
    string islem = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] == null)
        {
            Response.Redirect("login.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Anasayfa Yazıları";

        AdiSoyadiCek();

        Id = Request.QueryString["Id"];
        islem = Request.QueryString["islem"];

        if (islem == "Sil")
        {
            system.cmd("Delete from Yazilar where Id =" + Id);
            Response.Redirect("Giris.aspx");
        }

     }
    protected void  btnEkle_Click(object sender, EventArgs e)
{
        OleDbConnection baglan = system.baglan();
            OleDbCommand cmd = new OleDbCommand("Insert into Yazilar (Baslik,Detay) values (@Baslik,@Detay)", baglan);

            cmd.Parameters.Add("Baslik",txtAdiSoyadi.Text);
            cmd.Parameters.Add("Detay", Detay.Content);
                   cmd.ExecuteNonQuery();
            Response.Redirect("Giris.aspx");
}
    void AdiSoyadiCek()
    {
        DataTable dtOzgecmis = system.getdatatable("Select * from Yazilar");
        DataList1.DataSource = dtOzgecmis;
        DataList1.DataBind();

    }
}
