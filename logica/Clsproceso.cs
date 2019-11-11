using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace logica
{
    public class Clsproceso
    {
        public int nombre { get; set; }
        public String fech { get; set; }
        ClsManejador M = new ClsManejador();
        public DataTable BuscarProceso(int objDatos,string fecha)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@PRO_ID", objDatos));
            lst.Add(new ClsParametros("@fecha", fecha));
            return dt = M.Listado("SP_BuscarProceso", lst);
        }
    }
}
