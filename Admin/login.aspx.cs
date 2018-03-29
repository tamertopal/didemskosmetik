using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_login : System.Web.UI.Page
{
    veritabani system = new veritabani();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataRow drgiris = system.getdatarow("Select * from Adminler Where KullaniciAdi='" + ayarlar.Temizle(txtAdi.Text) + "' and Sifre='" + ayarlar.Temizle(txtSifre.Text) + "'");
        if (drgiris != null)
        {
            Session["AdiSoyadi"]=drgiris["AdiSoyadi"].ToString();
            Session["Id"] = drgiris["Id"].ToString();
            Response.Redirect("Default.aspx");
        }
        else
        {
            Label1.Text = "Yanlış Kullanıcı Adı veya PArola girdiniz!!!";
        
        }
    }
}