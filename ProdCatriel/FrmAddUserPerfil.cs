using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmAddUserPerfil : Form
    {
        public FrmAddUserPerfil()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            
            Inicio();
        }
        private void Inicio()
        {
            if (Tipo == "NUEVO")
            {
                id = 0;

            }
            if (Tipo == "MODIFICAR")
            {
                txtNombre.Text = Nombre;
                TxtCodigo.Text = Codigo;
                txtNombre.Text = Nombre; txtNombre.ReadOnly = false;
                TxtCodigo.Text = Codigo; TxtCodigo.ReadOnly = true;
                if (Activo == "N")
                {
                    chekActivo.Checked = true;
                }
                else
                {
                    chekActivo.Checked = false;
                }
            }
            if (Tipo == "CONSULTAR")
            {
                txtNombre.Text = Nombre; txtNombre.ReadOnly = true;
                TxtCodigo.Text = Codigo; TxtCodigo.ReadOnly = true;
                chekActivo.Enabled = false;
                if (Activo == "N")
                {
                    chekActivo.Checked = true;
                }

                else
                {
                    chekActivo.Checked = false;
                }
                
            }

        }
        

        private bool valido()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("El Campo Nombre NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("El Campo Código NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
                return false;
            }
            
            
            return true;

        }
        private String[] AbmUser(string tipo)
        {

            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //cabecera PROCPRODH Convert.ToInt32(cmbPerfil.SelectedValue)
                lst.Add(new ClsParametros("@Tipo", Tipo));
                lst.Add(new ClsParametros("@PerfilId", id));
                lst.Add(new ClsParametros("@Nombre", txtNombre.Text));
                lst.Add(new ClsParametros("@Codigo", TxtCodigo.Text));
                if (chekActivo.Checked == true)
                { 
                    lst.Add(new ClsParametros("@Activo", "N"));
                }
                else
                {
                    lst.Add(new ClsParametros("@Activo", "S"));
                }
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("sp_AbmUsuariosPerfiles", ref lst);
                msj = new string[2];
                msj[0] = lst[5].Valor.ToString();
                msj[1] = lst[6].Valor.ToString();
            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = "0";
                msj[1] = ex.Message;

            }
            return msj;
        }
        private void btnCancel_Click(object sender, EventArgs e)
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Tipo == "MODIFICAR")
            {
                if (MessageBox.Show("¿Confirma que desea Modificar El Registro?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (Tipo == "CONSULTAR")
            {
                DialogResult = DialogResult.No;
                this.Close();
                return;
            }
            try
            {
                if (valido() == true)
                {
                    id = id;
                    Nombre = txtNombre.Text;
                    Codigo = TxtCodigo.Text;
           
                    string[] msg = AbmUser(Tipo);


                    if (msg[0] == "0")
                    {

                        MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {

                        MessageBox.Show(msg[1], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Yes;
                        this.Close();
                        return;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}

    
 

