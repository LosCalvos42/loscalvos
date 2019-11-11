using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace logica
{
    public class ClsSJamones
    {
        ClsManejador M = new ClsManejador();
        //atributos(campos de la tapla)
        public int Hid { get; set; }
        public String Hfecha { get; set; }
        public int Hnroproc { get; set; }
        public int Htipo { get; set; }
        public String Hestado { get; set; }
        public String Hdebaja { get; set; }

        public int Iid { get; set; }
        public int IHid { get; set; }
        public String Ilote { get; set; }
        public String Inropieza { get; set; }
        public decimal  Ipeso { get; set; }
        public String Icodbar { get; set; }
        public String Itextura { get; set; }
        public int Inroitem { get; set; }
        public int Inrobate { get; set; }
        public String TEXT { get; set; }

        public String RegistrarSeleccion()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            String Mensaje = "";
            try
            {

                lst.Add(new ClsParametros("@SJMH_ID ", Hid));
                lst.Add(new ClsParametros("@SJMH_FECHA ", Hfecha));
                lst.Add(new ClsParametros("@SJMH_NROPROC", Hnroproc));
                lst.Add(new ClsParametros("@SJMH_TIPOJ", Htipo));
                lst.Add(new ClsParametros("@SJMH_ESTADO", Hestado));
                lst.Add(new ClsParametros("@SJMH_DEBAJA", Hdebaja));

                lst.Add(new ClsParametros("@SJMBH_ESTADO", "A"));
                lst.Add(new ClsParametros("@SJMBH_NROBATE", 0));
                lst.Add(new ClsParametros("@SJMBH_TEXTURA", Itextura));
                lst.Add(new ClsParametros("@SJMBH_BLOTE", "lote"));

                //lst.Add(new ClsParametros("@SJMBI_ID ", Hid));
                //lst.Add(new ClsParametros("@SJMH_ID ", IHid));
                lst.Add(new ClsParametros("@SJMBI_LOTE ", Ilote));
                lst.Add(new ClsParametros("@SJMBI_NROPIEZA ", Inropieza));
                lst.Add(new ClsParametros("@SJMBI_PESO", Ipeso));
                lst.Add(new ClsParametros("@SJMBI_CODBAR", Icodbar));
                //lst.Add(new ClsParametros("@SJMI_TEXTURA", Itextura));
                //lst.Add(new ClsParametros("@SJMI_NROITEM", Inroitem));
                //lst.Add(new ClsParametros("@SJMI_NROBATE", Inrobate));
                lst.Add(new ClsParametros("@Mensaje", "", System.Data.SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("SP_RegistrarSeleccion", ref lst);
                return Mensaje = lst[14].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
