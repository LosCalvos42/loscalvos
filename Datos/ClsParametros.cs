using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Datos
{
    public class ClsParametros
    {
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public int Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }

        public ClsParametros(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }
        public ClsParametros(String objNombre, Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)
        {
            Nombre = objNombre;
            Valor = objValor;
            TipoDato = objTipoDato;
            Direccion = objDireccion;
            Tamaño = objTamaño;
        }

    }
}
