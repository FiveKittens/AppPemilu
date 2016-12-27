using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppPemilu.Implement
{
    class ImpLogin : Interface.IntLogin
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;

        public ImpLogin()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean Login(Entity.EntLogin e)
        {

            query = "SELECT id_staff, password, nama_staff FROM tb_admin " +
                    "WHERE id_staff = '" + e.getKode() + "' AND password = '" + e.getPassword() + "'";

            koneksi.Open();

            SqlCommand command = koneksi.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

           
            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == e.getKode())
                    && (reader.GetString(1).ToString() == e.getPassword()))
                {
                    e.setID(reader.GetString(0).ToString());
                    e.setUser(reader.GetString(2).ToString());
                    status = true;
                }
                else
                {
                    status = false;
                }
            }

            koneksi.Close();

            return status;
        }
    }
}
