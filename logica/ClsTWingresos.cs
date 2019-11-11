using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
   public class ClsTWingresos
    {
        
        public int fechD { get; set; }
        public int fechH { get; set; }
        ClsManejador2 M = new ClsManejador2();
        public DataTable BuscarIngresos( int fechaD, int fechaH)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@fechaD", fechaD));
            lst.Add(new ClsParametros("@fechaH", fechaH));
            return dt = M.Listado("SP_BuscarIngresosxfechaAddDespostada", lst);
        }
    }
}
