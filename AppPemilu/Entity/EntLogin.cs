using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPemilu.Entity
{
    class EntLogin
    {
        private string kode;
        private string password;

        public static string user;
        public static string ID;
        public void setKode(string kode)
        {
            this.kode = kode;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setUser(string u)
        {
            user = u;
        }
        public void setID(string id)
        {
            ID = id;
        }
        public string getKode()
        {
            return kode;
        }
        public string getPassword()
        {
            return password;
        }
        public string getUser()
        {
            return user;
        }
        public string getID()
        {
            return ID;
        }

    }
}
