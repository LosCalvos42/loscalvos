using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        //parametros para abrir los frm
        public static string SERVIDORPRODUCCION;
        public static bool _FrmSelecJamon = false;
        public static bool _FrmTipoRecurso = false;
        //public static bool FMantCliente = false;
        //public static bool FABMCliente = false;
        public static bool _FrmConfiguracion = false;
        public static bool _FrmMenuProduccion = false;
        public static bool _FrmProductos = false;
        public static bool _FrmUser = false;
        public static bool _FrmProduccion=false;
        public static bool _FrmConsultas = false;
        public static bool _FrmUtilidades = false; 


        public static int perfil;
        public static int IDUSER;

        public static string ForzarCierre;

        public static string SerialPC { get; set; }
        public static string HostName { get; set; }
        public static string IMPRESORAETIQUETA { get; set; }
        public static string BALANZA { get; set; }
        public static string BALANZAPUERTO { get; set; }

        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }

    }
}
