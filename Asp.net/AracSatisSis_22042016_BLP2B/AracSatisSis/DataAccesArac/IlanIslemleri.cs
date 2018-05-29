using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessArac;


namespace DataAccesArac
{
    public class IlanIslemleri
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);

        public bool IlanEkle(Ilan ilan)
        {
            SqlCommand cmd = new SqlCommand("sp_IlanEkle", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@kullaniciId", ilan.KullaniciId);
            cmd.Parameters.AddWithValue("@ilanBasligi", ilan.IlanBasligi);
            cmd.Parameters.AddWithValue("@aracTuru", ilan.AracTuru);
            cmd.Parameters.AddWithValue("@aracModelId", ilan.AracModel);
            cmd.Parameters.AddWithValue("@modelYili", ilan.ModelYili);
            cmd.Parameters.AddWithValue("@kilometre", ilan.Kilometre);
            cmd.Parameters.AddWithValue("@vitesTuruId", ilan.VitesTuru);
            cmd.Parameters.AddWithValue("@kasaTipiId", ilan.KasaTipi);
            cmd.Parameters.AddWithValue("@yakitTuruId", ilan.YakitTuru);
            cmd.Parameters.AddWithValue("@fiyat", ilan.Fiyat);
            cmd.Parameters.AddWithValue("@aciklama", ilan.Aciklama);
            cmd.Parameters.AddWithValue("@ilanTarihi", ilan.IlanTarihi);

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            int i= cmd.ExecuteNonQuery();

            return Convert.ToBoolean(i);
        }
    }
}
