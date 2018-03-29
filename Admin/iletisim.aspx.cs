using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_iletisim : System.Web.UI.Page
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
            system.cmd("Delete from iletisim where Id =" + Id);
            Response.Redirect("iletisim.aspx");
        }
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "İletişim Bilgisi";
        AdminCek();
    }
    protected void btnEkle_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = system.baglan();
        OleDbCommand cmd = new OleDbCommand("Insert into iletisim (Adres, Email, Telefon, GSM) values (@Adres,@Email,@Telefon,@GSM)", baglan);
        cmd.Parameters.Add("Adres", txtAdres.Text);
        cmd.Parameters.Add("Email", txtMail.Text);
        cmd.Parameters.Add("Telefon", txtTel.Text);
        cmd.Parameters.Add("GSM", txtGsm.Text);
        cmd.ExecuteNonQuery();
        Response.Redirect("iletisim.aspx");
    }
    void AdminCek()
    {

        DataTable dtadminler = system.getdatatable("Select * from iletisim");
        dlAdminler.DataSource = dtadminler;
        dlAdminler.DataBind();

    }

}