using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logica;

namespace logica
{
    public class ClsProcesoBatea
    {
     

       public int @PRO_ID  { get; set; }
       public String @fecha { get; set; }
       public String @textura { get; set; }
       public int  @nrobatea { get; set; }
       public String @mostrar { get; set; }


        ClsManejador M = new ClsManejador();
        public DataTable BuscarProcesoBatea(int PROID, string fecha, String textu,int nrobat, string mostr )
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@PRO_ID", PROID));
            lst.Add(new ClsParametros("@fecha", fecha));
            lst.Add(new ClsParametros("@textura", textu));
            lst.Add(new ClsParametros("@nrobatea ", nrobat));
            lst.Add(new ClsParametros("@mostrar", mostr));
            return dt = M.Listado("SP_BuscarProcesobatea", lst);
        }

        public DataTable BuscarBatea(int PROID, string fecha, String textu, int nrobat)
        {
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@PRO_ID", PROID));
            lst.Add(new ClsParametros("@fecha", fecha));
            lst.Add(new ClsParametros("@textura", textu));
            lst.Add(new ClsParametros("@nrobatea ", nrobat));
            return dt = M.Listado("SP_imprimirBatea", lst);
        }
    }
}
