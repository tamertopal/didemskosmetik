using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ayarlar
/// </summary>
public class ayarlar
{
	public ayarlar()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string Temizle(string Metin)
    {
        string deger = Metin;
        deger = deger.Replace("'", "");
        deger = deger.Replace("<", "");
        deger = deger.Replace(">", "");
        deger = deger.Replace("&", "");
        deger = deger.Replace("[", "");
        deger = deger.Replace("]", "");

        return deger;
    }
    public static string UrlSeo(string Metin)
    {
        string deger = Metin;
        deger = deger.Replace("'", "");
        deger = deger.Replace("<", "");
        deger = deger.Replace(">", "");
        deger = deger.Replace("&", "");
        deger = deger.Replace("[", "");
        deger = deger.Replace("]", "");
        deger = deger.Replace("ğ", "g");
        deger = deger.Replace("ç", "c");
        deger = deger.Replace("ş", "s");
        deger = deger.Replace("ü", "u");
        deger = deger.Replace("ö", "o");
        deger = deger.Replace("ı", "i");
        deger = deger.Replace("Ğ", "g");
        deger = deger.Replace("Ç", "c");
        deger = deger.Replace("Ş", "s");
        deger = deger.Replace("Ü", "u");
        deger = deger.Replace("Ö", "o");
        deger = deger.Replace("İ", "i");

        return deger;
    }
}