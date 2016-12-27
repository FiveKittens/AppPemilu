using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppPemilu.Interface
{
    interface IntCalon
    {
        Boolean submitCalon(Entity.EntCalon e);
        Boolean updateCalon(Entity.EntCalon e);
        Boolean deleteCalon(Entity.EntCalon e);
        DataSet SelectCalon();
        
        String nomorBaru();
    }
}
