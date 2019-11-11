using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class ClsListarParametros
    {
        public String m_parametro{ get; set; }
        public String m_valor { get; set; }
        ClsManejador M = new ClsManejador();
        public DataTable BuscarParametro()
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Parametro", m_parametro));
                lst.Add(new ClsParametros("@valor", m_valor));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                msj = lst[2].Valor.ToString();
                return M.Listado("SP_Parametros", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
