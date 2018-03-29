using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_siparis : System.Web.UI.Page
{
    veritabani system = new veritabani();
    string id = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] == null)
        {
            Response.Redirect("login.aspx");
        }
        id = Request.QueryString["Id"];
        islem = Request.QueryString["islem"];

        if (islem == "Sil")
        {
            system.cmd("Delete from siparis Where id=" + id);
            Response.Redirect("siparis.aspx");
        }


        Label lblBaslik = (Label)Master.FindControl("lblSayfaBaslik");
        lblBaslik.Text = "SİPARİŞLER";
        SiparisCek();
    }
    void SiparisCek()
    {
        DataTable dt = system.getdatatable("Select * from Siparis");
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }
}