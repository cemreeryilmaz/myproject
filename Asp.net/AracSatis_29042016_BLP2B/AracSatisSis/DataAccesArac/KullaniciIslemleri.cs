using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessArac;

namespace DataAccesArac
{
    public class KullaniciIslemleri
    {
        static string connStr = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);

        public string KullaniciEkle(Kullanici kullanici)
        {
            SqlCommand cmd = new SqlCommand("sp_KullaniciEkle", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ad", kullanici.Ad);
            cmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
            cmd.Parameters.AddWithValue("@eposta", kullanici.Eposta);
            cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);
            cmd.Parameters.AddWithValue("@cepTelefonu", kullanici.CepTelefonu);
            cmd.Parameters.AddWithValue("@ilceId", kullanici.IlceId);
            cmd.Parameters.AddWithValue("@kayitTarihi", kullanici.KayitTarihi);
            cmd.Parameters.AddWithValue("@kullaniciOnayDurumu", kullanici.KullaniciOnayDurumu);

            cmd.Parameters.Add("@durum", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            int sonuc = cmd.ExecuteNonQuery();
            int durum = Convert.ToInt32( cmd.Parameters["@durum"].Value);

            if (sonuc > 0)
                return "Kaydınız Gerçekleştirildi...";
            else if (durum == -1)
                return "Girdiğiniz eposta adresi zaten kayıtlı!";
            else if (durum == -2)
                return "Girdiğiniz cep telefonu zaten kayıtlı!";
            else
                return "Kayıt sırasında HATA!";


        }

        public SqlDataReader KullaniciGiris(Kullanici kullanici)
        {
            SqlCommand cmd = new SqlCommand("sp_KullaniciGiris", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@eposta", kullanici.Eposta);
            cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        }
    }
}
