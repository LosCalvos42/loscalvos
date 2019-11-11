using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace logica
{
    public class ClsTipo
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

            return M.Listado("SP_listarTipoUsuario", lst);
        }


    }
}
