using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace logica
{
    public class ClsLogin
    {
        public String m_USER { get; set; }
        public String m_PASS { get; set; }
        ClsManejador M = new ClsManejador();
        public DataTable BuscarUser()
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@USR_USER", m_USER));
                lst.Add(new ClsParametros("@USR_PASS", m_PASS));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                msj = lst[2].Valor.ToString();
                return M.Listado("SP_Login", lst);
            }
            catch (Exception ex)
            {
                throw ex;

            } 
        }
    }
}
