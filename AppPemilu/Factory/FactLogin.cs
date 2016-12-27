using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPemilu.Factory
{
    class FactLogin
    {
        private static Interface.IntLogin Login;
        private static Interface.IntCalon Calon;
        private static Interface.IntSuara Suara;

        public static Interface.IntLogin GetInterfaceLogin()
        {
            Login = new Implement.ImpLogin();
            return Login;
        }

        public static Interface.IntCalon GetInterfaceCalon()
        {
            Calon = new Implement.ImpCalon();
            return Calon;
        }

        public static Interface.IntSuara GetInterfaceSuara()
        {
            Suara = new Implement.ImpSuara();
            return Suara;
        }
        
    }
}
