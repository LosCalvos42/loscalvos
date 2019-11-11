using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alberdi
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
        public static bool FMantCliente = false;
        public static bool FABMCliente = false;
        public static bool _FrmMenuProduccion = false;
        public static bool _FrmProductos = false;
        public static bool _FrmUser = false;
        public static bool _FrmProduccion=false;
        public static bool _FrmConsultas = false;
        public static int perfil;

        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }

    }
}
