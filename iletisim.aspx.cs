using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class iletisim : System.Web.UI.Page
{
    veritabani system = new veritabani();

    protected void Page_Load(object sender, EventArgs e)
    {
        UrunCek();
        
            
    }
    void UrunCek()
    {
        rpkategoriler3.DataSource = system.getdatatable("Select * From iletisim");
        rpkategoriler3.DataBind();
    }
    protected void btnGonder_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = system.baglan();
        OleDbCommand cmd = new OleDbCommand("Insert Into Mesajlar (Adi,Email,Konu,Mesaj) values (@Adi,@Email, @Konu,@Mesaj)",baglan);
        cmd.Parameters.Add("Adi", txtAdi.Text);
        cmd.Parameters.Add("Email", txtEmail.Text);
        cmd.Parameters.Add("Konu", txtKonu.Text);
        cmd.Parameters.Add("Mesaj", txtMesaj.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("iletisim.aspx");
        lblBilgi.Text = "Mesajınız İletildi";
    }
}