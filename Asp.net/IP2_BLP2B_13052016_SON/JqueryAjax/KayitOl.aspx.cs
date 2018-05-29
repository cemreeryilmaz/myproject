using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Services;

public partial class KayitOl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static string KullaniciEkle(string ad, string soyad,string eposta, string sifre, char cinsiyet, string sehir)
    {
        string connStr = WebConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("sp_KullaniciEkle", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@Ad", ad);
        cmd.Parameters.AddWithValue("@Soyad", soyad);
        cmd.Parameters.AddWithValue("@Eposta", eposta);
        cmd.Parameters.AddWithValue("@Sifre", sifre);
        cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
        cmd.Parameters.AddWithValue("@Sehir", sehir);

        if (conn.State == ConnectionState.Closed)
            conn.Open();
        int i = cmd.ExecuteNonQuery();
        
        conn.Close();
        if (i > 0)
            return "KAYIT BAŞARILI!";
        else
            return "KAYIT SIRASINDA HATA OLUŞTU!";
        
    }
}