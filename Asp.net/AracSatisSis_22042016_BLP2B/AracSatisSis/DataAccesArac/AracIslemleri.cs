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
    
    public class AracIslemleri
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);

        public SqlDataReader AracTurListele()
        {
            SqlCommand cmd = new SqlCommand("sp_AracTurListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader AracMarkaListele(int aracTurId)
        {
            SqlCommand cmd = new SqlCommand("sp_AracMarkaListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Parameters.AddWithValue("@aracTurId", aracTurId);

            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader AracModelListele(int aracMarkaId)
        {
            SqlCommand cmd = new SqlCommand("sp_AracModelListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Parameters.AddWithValue("@aracMarkaId", aracMarkaId);

            SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public SqlDataReader YakitTuruListele()
        {
            conn.Close();
            SqlCommand cmd = new SqlCommand("sp_YakitTuruListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader VitesTuruListele()
        {
            conn.Close();
            SqlCommand cmd = new SqlCommand("sp_VitesTuruListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader KasaTipiListele()
        {
            conn.Close();
            SqlCommand cmd = new SqlCommand("sp_KasaTipiListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }
    }
}
