using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmEntrada : Form
    {
        public FrmEntrada()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string Servidor { get; set; }
        public string Database { get; set; }
        public string Contra { get; set; }
        public string RutaActualizacion { get; set; }
        public string Rutaini { get; set; }
        public string Actualiza { get; set; }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            txtserver.Text = Servidor;
            txtactualizacion.Text = RutaActualizacion;
            TxtBase.Text = Database;
            Txtcontraseña.Text = Contra;


            if (Actualiza == "SI")
            {
                chActualiza.Checked = true;
            }
            else
            {
                chActualiza.Checked = false;
            }

        }
        private void Inicio()
        {
            

        }
        

        private bool Valido()
        {

            if (txtserver.Text == "")
            {
                MessageBox.Show("El Campo Nombre NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtserver.Focus();
                return false;
            }

            if (txtactualizacion.Text == "")
            {
                MessageBox.Show("El Campo Apellido NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtactualizacion.Focus();
                return false;
            }
         
            return true;

        }
        
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public class Util
        {

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
            [DllImport("kernel32")]
            public static extern int GetPrivateProfileString(string section,
                     string key, string def, StringBuilder retVal,
                int size, string filePath);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
            [DllImport("kernel32")]
            public static extern long WritePrivateProfileString(string section,
                string key, string val, string filePath);

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Valido() == true)
                {
                    string act;
                    string archivo = Rutaini;
                    Util.WritePrivateProfileString("Datos", "SERVIDOR_P",txtserver.Text, archivo);
                    Util.WritePrivateProfileString("Datos", "DATABASE", TxtBase.Text, archivo);
                    Util.WritePrivateProfileString("Datos", "CONTRA", Txtcontraseña.Text, archivo);
                    Util.WritePrivateProfileString("Datos", "RUTAA", txtactualizacion.Text, archivo);
                    if (chActualiza.Checked)
                    {
                         act = "SI";
                    }
                    else
                    {
                         act = "NO";
                    }
                    Util.WritePrivateProfileString("Datos", "ACTUALIZA", act, archivo);
                    MessageBox.Show("Los Datos se guardaron correctamente....", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(Application.StartupPath + @"\"+Application.ProductName+".exe");
                    System.Environment.Exit(0);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

    
 

