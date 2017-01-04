using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AppPemilu.KoneksiDB
{
    class Koneksi
    {
        private static SqlConnection koneksi;
        public Koneksi(string connectionString)
        {
            koneksi = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (koneksi.State == System.Data.ConnectionState.Closed)
                    koneksi.Open();
                return true;
            }
        }
        public static SqlConnection getKoneksi()
        {
            koneksi = new SqlConnection();
            koneksi.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["db_pemilu"].ConnectionString;
            return koneksi;
        }
    }
}
