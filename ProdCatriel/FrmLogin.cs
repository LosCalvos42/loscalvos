using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using logica;
using Datos;
using System.IO;
using System.Xml;
using System.Reflection;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

using System.Data.SqlClient;

namespace LOSCALVOS
{
    public partial class FrmLogin : Form
    {

        //Computer mycomputer = new Computer();
        public static string verlocal;
        public static string user;
        public static string DB;
        public static string rutaini = Application.StartupPath + @"\" + Application.ProductName + ".ini";
        string pass;
        Splash _Splash = new Splash();
        //string Sproduccion, Sdesarrollo, recordar_pass;
        public static String Login_Servidor = leerini(), Sproduccion, Sdesarrollo,  Sbase, SContra  , Actualiza, INIUSER, TIPOENTRADA, RACTUALIZACION, EMPRESA;
        //ClsLogin USL = new ClsLogin();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Login_Servidor = comboBox1.Text;
            lblServer.Text = Login_Servidor;
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



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "config@")
            {
                try
                {
                    FrmEntrada _FrmEntrada = new FrmEntrada
                    {
                        Rutaini = rutaini,
                        Servidor = Login_Servidor,
                        RutaActualizacion = RACTUALIZACION,
                        Actualiza = Actualiza,
                        Database=Sbase,
                        Contra=SContra
                    };
                    _FrmEntrada.ShowDialog();
                    //string archivo = rutaini;
                    //Util.WritePrivateProfileString("Datos", "USER", txtUsuario.Text, archivo);

                    return;
                }
                catch
                {
                    MessageBox.Show("La Carpeta contenedora NO tiene los suficientes permisos para esta Acción." + Environment.NewLine + "Consulte Con el Administrador del Sistema.", "Error al escribir .INI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }

            try
            {
                ClsManejador.ip = Login_Servidor;
                ClsManejador.database = Sbase;
                ClsManejador.contra = SContra;
                ClsManejador2.ip = Login_Servidor;
                ClsLogin USL = new ClsLogin();

                string MSJ = "";
                if (txtUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
                {
                    MessageBox.Show("El Usuario o la Contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string passE = Encriptar(txtContraseña.Text);



                    USL.m_USER = txtUsuario.Text;
                    USL.m_PASS = passE;
                    //MSJ = USL.BuscarUser() ;
                    DataTable DT = USL.BuscarUser();
                    Program.IDUSER= Convert.ToInt32(DT.Rows[0][0].ToString());
                    Program.perfil = Convert.ToInt32(DT.Rows[0][1].ToString());
                    user = DT.Rows[0][2].ToString();
                    pass = DT.Rows[0][3].ToString();
                    MSJ = DT.Rows[0][4].ToString();

                    if (MSJ == "INACTIVO")
                    {
                        MessageBox.Show("El Usuario se encuentra Inactivo o no Existe." + Environment.NewLine + "Consulte Con el Administrador del Sistema.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

                    if (user == txtUsuario.Text.ToUpper() & pass == passE)
                    {

                        if (INIUSER != txtUsuario.Text)
                        {
                            try
                            {
                                string archivo = rutaini;
                                Util.WritePrivateProfileString("Datos", "USER", txtUsuario.Text, archivo);
                            }
                            catch
                            {
                                MessageBox.Show("La Carpeta contenedora NO tiene los suficientes permisos para esta Acción." + Environment.NewLine + "Consulte Con el Administrador del Sistema.", "Error al escribir .INI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        //USR.Show();
                        Program.SERVIDORPRODUCCION = Login_Servidor;
                        _Splash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al Ingresar las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string leerini()
        {
            //ClsLogin USL = new ClsLogin();
            StringBuilder SERVIDOR_P = new StringBuilder();
            StringBuilder SERVIDOR_D = new StringBuilder();
            StringBuilder DATABASE = new StringBuilder();
            StringBuilder CONTRA = new StringBuilder();
            StringBuilder SOURCE = new StringBuilder();
            StringBuilder R_ENTRADA = new StringBuilder();
            StringBuilder R_USER = new StringBuilder();
            StringBuilder R_ACTUALIZA = new StringBuilder();
            StringBuilder R_EMP = new StringBuilder();

            //string valor = "";
            string archivo = rutaini;

            if (File.Exists(archivo))
            {
                Util.GetPrivateProfileString("Datos", "SERVIDOR_P", "", SERVIDOR_P, SERVIDOR_P.MaxCapacity, archivo);
                Login_Servidor = SERVIDOR_P.ToString();
                Sproduccion = SERVIDOR_P.ToString();

                Util.GetPrivateProfileString("Datos", "SERVIDOR_D", "", SERVIDOR_D, SERVIDOR_D.MaxCapacity, archivo);
                Sdesarrollo = SERVIDOR_D.ToString();

                Util.GetPrivateProfileString("Datos", "DATABASE", "", DATABASE, DATABASE.MaxCapacity, archivo);
                Sbase = DATABASE.ToString();
                //Program.DATABASE = Sbase;
                Util.GetPrivateProfileString("Datos", "CONTRA", "", CONTRA, DATABASE.MaxCapacity, archivo);
                SContra = CONTRA.ToString();
                //Program.CONTRA = SContra;

                Util.GetPrivateProfileString("Datos", "SOURCE", "", SOURCE, SOURCE.MaxCapacity, archivo);
                RACTUALIZACION = SOURCE.ToString();

                Util.GetPrivateProfileString("Datos", "ACTUALIZA", "", R_ACTUALIZA, R_ACTUALIZA.MaxCapacity, archivo);
                Actualiza = R_ACTUALIZA.ToString();

                Util.GetPrivateProfileString("Datos", "EMP", "", R_EMP, R_EMP.MaxCapacity, archivo);
                EMPRESA = R_EMP.ToString();

                Util.GetPrivateProfileString("Datos", "USER", "", R_USER, R_USER.MaxCapacity, archivo);
                INIUSER = R_USER.ToString();

                Util.GetPrivateProfileString("Datos", "ENTRADA", "", R_ENTRADA, R_ENTRADA.MaxCapacity, archivo);
                TIPOENTRADA = R_ENTRADA.ToString();
            }
            else
            {
                MessageBox.Show("No se puede encontrar archivo " + archivo);
                System.Environment.Exit(0);
            }
            //Program.Servidor = valor;
            ClsManejador.ip = Login_Servidor;
            ClsManejador.admin = Sbase;
            ClsManejador.contra = SContra;


            return Login_Servidor;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            lblErrorUser.Visible = false;
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null, e);
            }
        }



        private void btnverPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnverPass_MouseUp(object sender, MouseEventArgs e)
        {

            if (txtContraseña.Text != "Contraseña")
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void LblBy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.janckosoft.com");
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        public static Version GetPublishedVersion()
        {
            XmlDocument xmlDoc = new XmlDocument();
            Assembly asmCurrent = System.Reflection.Assembly.GetExecutingAssembly();
            string executePath = new Uri(asmCurrent.GetName().CodeBase).LocalPath;

            xmlDoc.Load(executePath + ".manifest");
            string verlocal = string.Empty;
            if (xmlDoc.HasChildNodes)
            {
                verlocal = xmlDoc.ChildNodes[1].ChildNodes[0].Attributes.GetNamedItem("version").Value.ToString();
            }
            return new Version(verlocal);

        }


        public static Version GetServerVersion()
        {

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                Assembly asmCurrent = System.Reflection.Assembly.GetExecutingAssembly();
                string executePath = new Uri(asmCurrent.GetName().CodeBase).LocalPath;

                xmlDoc.Load(@"\\" +RACTUALIZACION  + @"\"+Application.ProductName+".exe.manifest");
                string verlocal = string.Empty;
                if (xmlDoc.HasChildNodes)
                {
                    verlocal = xmlDoc.ChildNodes[1].ChildNodes[0].Attributes.GetNamedItem("version").Value.ToString();
                }
                return new Version(verlocal);
            }


            catch
            {
                MessageBox.Show("La Ruta de Actualización no es correcta o NO tiene permisos suficientes." + Environment.NewLine + "Consulte con el Administrador del Sistema.", "Error Update ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Version(verlocal);
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                verlocal = "" + GetPublishedVersion();
                lblversion.Text = "Compilación: " + verlocal;
                lblEmpresa.Text = EMPRESA;
                lblServer.Text = Login_Servidor;
                comboBox1.Items.Add(Sproduccion);
                comboBox1.Items.Add(Sdesarrollo);
                if (TIPOENTRADA == "ADMIN")
                {
                    this.Height = 332;
                    //this.Height = 284;
                }
                else
                {
                    this.Height = 284;
                }

                if (INIUSER != "")
                {
                    txtUsuario.Text = INIUSER;
                    txtUsuario.TabStop = false;
                    txtContraseña.Focus();
                }
                else
                {
                    txtUsuario.Focus();
                }

                // Copiamos la carpeta.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            actualiza();

        }
        private void actualiza()
        {

            if (Actualiza == "SI")
            {
                string verserver = "" + GetServerVersion();
                if (Convert.ToDouble(verlocal) < Convert.ToDouble(verserver))
                {
                    Computer mycomputer = new Computer();
                    MessageBox.Show("Existe una Versión Más reciente en linea" + Environment.NewLine + "Se procedera con La Actualización", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        using (FileStream fs = File.Create(Path.Combine(Application.StartupPath, "AccessTemp.txt"), 1, FileOptions.DeleteOnClose))
                        {
                            fs.Close();
                        }
                        Application.Exit();
                        this.Close();
                        Process.Start(Application.StartupPath + @"\Actualiza.exe");
                    }
                    catch
                    {
                        MessageBox.Show("La Carpeta contenedora NO tiene los suficientes permisos para esta Acción." + Environment.NewLine + "Consulte Con el Administrador del Sistema.", "Error Update ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
        }

        public class Util
        {

            [DllImport("kernel32")]
            public static extern int GetPrivateProfileString(string section,
                     string key, string def, StringBuilder retVal,
                int size, string filePath);

            [DllImport("kernel32")]
            public static extern long WritePrivateProfileString(string section,
                string key, string val, string filePath);

        }
    }
}
