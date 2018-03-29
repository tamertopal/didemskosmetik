using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class siparis : System.Web.UI.Page
{
    veritabani system = new veritabani(); 
   
    protected void Page_Load(object sender, EventArgs e)
    {
          UrunCek();
    }
    protected void btnGonder_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = system.baglan();
        OleDbCommand cmd = new OleDbCommand("Insert Into siparis (Adi, Email, Telefon, Adres, Aciklama) Values (@Adi,@Email,@Telefon,@Adres,@Aciklama)", baglan);
        cmd.Parameters.Add("Adi", txtAdi.Text);
        cmd.Parameters.Add("Email", txtEmail.Text);
        cmd.Parameters.Add("Telefon", txtKonu.Text);
        cmd.Parameters.Add("Adres", TextBox1.Text);
        cmd.Parameters.Add("Aciklama", txtAciklama.Text);

        cmd.ExecuteNonQuery();
        Response.Redirect("siparis.aspx");
        
        
       
    }
    void UrunCek()
    {
        rpkategoriler3.DataSource = system.getdatatable("Select * From iletisim");
        rpkategoriler3.DataBind();
    }
}