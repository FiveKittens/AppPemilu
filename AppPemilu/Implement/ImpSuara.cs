using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AppPemilu.Implement
{
    class ImpSuara : Interface.IntSuara
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;
        private SqlCommand command;

        public ImpSuara()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean tambahSuara(Entity.EntSuara e)
        {
            status = false;
            try
            {
                query = "IF NOT EXISTS(SELECT 1 FROM tb_suara WHERE nomor_calon=" + e.GetNomor() + ")\r\n" +
                        "INSERT INTO tb_suara VALUES ('" + e.GetNomor() + "', 1, GETDATE())"
                        + "\r\nELSE\r\n" +
                        "UPDATE tb_suara SET suara_masuk=suara_masuk+1, waktu_suara = GETDATE() WHERE nomor_calon=" + e.GetNomor();

                koneksi.Open();

                command = new SqlCommand(query, koneksi);
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException ex)
            {
                koneksi.Close();
                Console.WriteLine("ERROR" + ex.Message);
            }
            return status;
        }

        public Boolean updateSuara(Entity.EntSuara e)
        {
            status = false;
            try
            {
                query = "UPDATE tb_suara SET suara_masuk = suara_masuk-1, waktu_suara = GETDATE() WHERE nomor_calon =" + e.GetNomor() + "\r\n" +
                        "IF EXISTS(SELECT 1 FROM tb_suara WHERE nomor_calon=" + e.GetNomor() + " AND suara_masuk < 1)\r\n" +
                        "DELETE from tb_suara WHERE nomor_calon =" + e.GetNomor();
                koneksi.Open();

                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException ex)
            {
                koneksi.Close();
                Console.WriteLine("ERROR" + ex.Message);
            }
            return status;
        }
        public DataSet SelectDetilCalon()
        {
            DataSet dt = new DataSet();
            try
            {
                query = "SELECT tb_calon.gambar_calon  as Pic, tb_suara.suara_masuk as Suara\r\n" +
                        "FROM tb_calon INNER JOIN tb_suara \r\n" +
                        "ON tb_calon.nomor_calon = tb_suara.nomor_calon";

                koneksi.Open();

                command = new SqlCommand(query, koneksi);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "tb_vertical");
                koneksi.Close();
            }
            catch (SqlException se)
            {
                koneksi.Close();
                Console.WriteLine("ERROR" + se);
            }
            return dt;
        }

        public DataSet RekapSuara()
        {
            DataSet dt = new DataSet();
            try
            {
                query = "SELECT tb_calon.nama_calon, tb_suara.*" +
                        "FROM tb_calon INNER JOIN tb_suara " +
                        "ON tb_calon.nomor_calon = tb_suara.nomor_calon" ;

                koneksi.Open();

                command = new SqlCommand(query, koneksi);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt, "tb_rekap");
                koneksi.Close();
            }
            catch (SqlException se)
            {
                koneksi.Close();
                Console.WriteLine("ERROR" + se);
            }
            return dt;
        }

        public DataSet SelectSuara()
        {
            DataSet ds = new DataSet();
            try
            {
                {
                    koneksi.Open();

                    query = "SELECT * from tb_suara ";
                    command = new SqlCommand(query, koneksi);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "tb_suara");

                    koneksi.Close();
                }
            }
            catch (SqlException se)
            {
                koneksi.Close();
                Console.WriteLine("ERROR" + se);
            }

            return ds;
        }
    }
}
