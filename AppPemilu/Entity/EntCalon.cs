using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPemilu.Entity
{
    class EntCalon
    {
        private string nomor;
        private string nama;
        private string partai;
        private static byte[] image;

        public void SetNomor(string nomor)
        {
            this.nomor = nomor;
        }
        public void SetNama(string nama)
        {
            this.nama = nama;
        }
        public void SetPartai(string partai)
        {
            this.partai = partai;
        }
        public void SetImage(byte[] img)
        {
            image = img;
        }
        public string getNomor()
        {
            return nomor;
        }
        public string getNama()
        {
            return nama;
        }
        public string getPartai()
        {
            return partai;
        }
        public byte[] getImage()
        {
            return image;
        }
    }
}
