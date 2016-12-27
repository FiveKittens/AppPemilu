using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppPemilu.Interface
{
    interface IntSuara
    {
        Boolean tambahSuara(Entity.EntSuara e);

        Boolean updateSuara(Entity.EntSuara e);
        DataSet RekapSuara();
        DataSet SelectDetilCalon();
        DataSet SelectSuara();
    }
}
