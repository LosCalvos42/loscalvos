using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace logica
{
    class Clslistarprocesosxfecha
    {
        ClsManejador M = new ClsManejador();
        public DataTable Listado()
        {
            return M.Listado("select * from sjmh ", null);
        }

    }
}
