using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPemilu.Entity
{
    class EntSuara
    {
        private string nomor;
        private string waktu;
        
        public void SetNomor(string nomor)
        {
            this.nomor = nomor;
        }
        public string GetNomor()
        {
            return nomor;
        }
        public void SetWaktu(string waktu)
        {
            this.waktu = waktu;
        }
        public string GetWaktu()
        {
            return waktu;
        }
    }
}
