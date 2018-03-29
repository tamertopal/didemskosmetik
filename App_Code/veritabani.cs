using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for veritabani
/// </summary>
public class veritabani : System.Web.UI.Page
{
	public veritabani()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //public string taban;
    public OleDbConnection baglan()
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=" + Server.MapPath("~/App_Data/tabanim.mdb"));
        baglanti.Open();
        return (baglanti);
    }

    public int cmd(string oledbcumle)
    {
        OleDbConnection baglan = this.baglan();
        OleDbCommand sorgu = new OleDbCommand(oledbcumle, baglan);

        int sonuc = 0;

        try
        {
            sonuc = sorgu.ExecuteNonQuery();
        }
        catch (OleDbException ex)
        {
            throw new Exception(ex.Message + "(" + oledbcumle + ")");
        }
        sorgu.Dispose();
        baglan.Close();
        baglan.Dispose();
        return (sonuc);
    }

    public DataTable getdatatable(string oledb)
    {
        OleDbConnection baglan = this.baglan();
        OleDbDataAdapter adapter = new OleDbDataAdapter(oledb, baglan);
        DataTable dt = new DataTable();
        try
        {
            adapter.Fill(dt);
        }
        catch (OleDbException ex)
        {
            throw new Exception(ex.Message + "(" + oledb + ")");
        }
        adapter.Dispose();
        baglan.Close();
        baglan.Dispose();
        return dt;
    }

    public DataRow getdatarow(string oledb)
    {
        DataTable table = getdatatable(oledb);
        if (table.Rows.Count == 0) return null;
        return table.Rows[0];
    }
    public DataColumn getdatacolumn(string oledb)
    {
        DataTable table = getdatatable(oledb);
        return table.Columns[0];
    }

    public string getdatacell(string oledb)
    {
        DataTable table = getdatatable(oledb);
        if (table.Rows.Count == 0) return null;
        return table.Rows[0][0].ToString();
    }
    public DataSet getdataset(string oledb)
    {
        OleDbConnection baglan = this.baglan();
        OleDbDataAdapter adapter = new OleDbDataAdapter(oledb, baglan);
        DataSet ds = new DataSet();
        try
        {
            adapter.Fill(ds);
        }
        catch (OleDbException ex)
        {
            throw new Exception(ex.Message + "(" + oledb + ")");
        }
        adapter.Dispose();
        baglan.Close();
        baglan.Dispose();
        return ds;
    }

    public OleDbCommand cmd(string p, OleDbConnection baglanti)
    {
        throw new NotImplementedException();
    }
}