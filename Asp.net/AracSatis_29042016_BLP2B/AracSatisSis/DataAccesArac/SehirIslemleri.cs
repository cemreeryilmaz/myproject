using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using BusinessArac;

using System.Configuration;

namespace DataAccesArac
{
    public class SehirIslemleri
    {
        static string connStr = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);

        public SqlDataReader IlListele()
        {
            SqlCommand cmd = new SqlCommand("sp_IlListele", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            return dr;
            conn.Close();
        }
        public SqlDataReader IlceListeleByIlId(Il il)
        {
            SqlCommand cmd = new SqlCommand("sp_IlceListeleByIlId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.Parameters.AddWithValue("@sehirId",il.Id);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
            conn.Close();
        }
    }
}
