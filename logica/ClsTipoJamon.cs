using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class ClsTipoJamon
    {
        private ClsManejador M = new ClsManejador();
        Int32 m_Idtipo;
        String m_Descripcion;
        public object accion;
        public Int32 IdCargo
        {
            get { return m_Idtipo; }
            set { m_Idtipo = value; }
        }
        public String Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }

        public DataTable Listar()
        {
            List<ClsParametros> lst = new List<ClsParametros>();

            return M.Listado("SP_listarTipojamon", lst);
        }


    }
}
