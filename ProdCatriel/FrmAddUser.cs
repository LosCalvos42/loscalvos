﻿using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LOSCALVOS
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Perfil { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            Cargarcombo("Perfil", cmbPerfil);
            Inicio();
        }
        private void Inicio()
        {
            if (Tipo == "CAMBIOPASS")
            {

                LlenarGrid("CAMBIOPASS",Convert.ToString(id));

            }


            if (Tipo == "NUEVO")
            {
                id = 0;

            }
            if (Tipo == "MODIFICAR")
            {
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtpass.Text = DesEncriptar(Pass);
                txtUser.Text = User;
                txtRpass.Text = txtpass.Text;
                cmbPerfil.SelectedValue = Perfil;
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
                txtApellido.Text = Apellido; txtApellido.ReadOnly = true;
                txtpass.Text = DesEncriptar(Pass); txtpass.ReadOnly = true;
                txtUser.Text = User; txtUser.ReadOnly = true;
                txtRpass.Text = txtpass.Text; txtRpass.ReadOnly = true;
                cmbPerfil.SelectedValue = Perfil; cmbPerfil.Enabled = false;
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

        private void LlenarGrid(string Combo, string Filtro)
        {


            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", Combo));
                lst.Add(new ClsParametros("@filtro", id));
                dt = M.Listado("sp_CargaCombos", lst);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtNombre.Text = dt.Rows[i][1].ToString(); txtNombre.ReadOnly = true;
                    txtApellido.Text = dt.Rows[i][2].ToString(); txtApellido.ReadOnly = true;
                    txtpass.Text = DesEncriptar(dt.Rows[i][6].ToString());
                    txtUser.Text = dt.Rows[i][5].ToString(); txtUser.ReadOnly = true;
                    txtRpass.Text = DesEncriptar(dt.Rows[i][6].ToString());
                    cmbPerfil.SelectedValue = dt.Rows[i][3].ToString(); cmbPerfil.Enabled = false;
                    chekActivo.Enabled = false;
                    if (dt.Rows[i][7].ToString() == "N")
                    {
                        chekActivo.Checked = true;
                    }

                    else
                    {
                        chekActivo.Checked = false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Cargarcombo(string combo, ComboBox _combo)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", ""));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_CargaCombos", lst);
                _combo.DataSource = dt;
                _combo.DisplayMember = "NOMBRE";
                _combo.ValueMember = "ID";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[2] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue =0;
            }
            catch (Exception ex)
            {
                throw ex;
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

            if (txtApellido.Text == "")
            {
                MessageBox.Show("El Campo Apellido NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return false;
            }
            if (cmbPerfil.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (Perfil)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPerfil.Focus();
                return false;
            }
            if (txtUser.Text == "")
            {
                MessageBox.Show("El Campo Nombre de Usuario NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return false;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("El Campo Contraseña NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return false;
            }


            if (txtpass.Text != txtRpass.Text)
            {
                lblErrorPass.Visible = true;
                txtRpass.Focus();
                return false;
            }
            else
            {
                lblErrorPass.Visible = false;
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
                lst.Add(new ClsParametros("@UserID", id));
                lst.Add(new ClsParametros("@Nombre", txtNombre.Text));
                lst.Add(new ClsParametros("@Apellido", txtApellido.Text));
                lst.Add(new ClsParametros("@Perfil", Convert.ToInt32(cmbPerfil.SelectedValue)));
                lst.Add(new ClsParametros("@User", txtUser.Text));
                lst.Add(new ClsParametros("@Pass", Encriptar(txtpass.Text)));
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
                M.EjecutarSP("sp_AbmUsuarios", ref lst);
                msj = new string[2];
                msj[0] = lst[8].Valor.ToString();
                msj[1] = lst[9].Valor.ToString();
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
            if (Tipo == "CAMBIOPASS")
            {
                if (MessageBox.Show("¿Confirma que desea Modificar La Contraseña?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

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
                    Apellido = txtApellido.Text;
                    User = txtUser.Text.ToUpper();
                    Pass = Encriptar(txtpass.Text);
                    Perfil = Convert.ToInt32(cmbPerfil.SelectedValue);
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

                        if (Tipo == "CAMBIOPASS")
                        {
                            //foreach (Process proceso in Process.GetProcesses())
                            //{
                            //    if (proceso.ProcessName == "LOSCALVOS")
                            //    {
                            //        proceso.Kill();
                            //        Process.Start(Application.StartupPath + @"\LOSCALVOS.exe");
                            //    }
                            //}
                            Program.ForzarCierre = "SI";
                            Application.Exit();
                            this.Close();
                            Process.Start(Application.StartupPath + @"\LOSCALVOS.exe");
                        }
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

    
 

