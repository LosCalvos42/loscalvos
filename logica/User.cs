using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace logica
{
    public partial class User
    {
        public String m_ACCION { get; set; }
        public int m_ID { get; set; }
        public String m_NOMBRE   {get; set;}
        public String m_APELLIDO {get; set;}
        public String m_USER     {get; set;}
        public String m_PASS     {get; set;}
        public int  m_TIPO       {get; set;}

        ClsManejador M = new ClsManejador();

        public String RegistrarUser()
        {
            String msj = "";
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@ACCION", m_ACCION));
                lst.Add(new ClsParametros("@USR_ID", m_ID));
                lst.Add(new ClsParametros("@USR_NOMBRE", m_NOMBRE));
                lst.Add(new ClsParametros("@USR_APELLIDO", m_APELLIDO));
                lst.Add(new ClsParametros("@USR_USER", m_USER));
                lst.Add(new ClsParametros("@USR_PASS", m_PASS));
                lst.Add(new ClsParametros("@USR_TIPO", m_TIPO));
                lst.Add(new ClsParametros("@Mensaje", "",SqlDbType.VarChar, ParameterDirection.Output,100));
                M.EjecutarSP("SP_RegistrarUSER", ref lst);
                msj = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;
        }
        public DataTable ListadoUser()
        {
            return M.Listado("Sp_ListadoUSER",null);
        }
    }   
}
