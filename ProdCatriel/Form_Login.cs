using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using CapaLogicaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
   
        public FormLogin()
        {
            InitializeComponent();
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario") {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text==""){
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
           lblErrorUser.Visible = false;
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text==""){
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnlogin_Click(object sender, EventArgs e)
        //{
        //    CNEmpleado ObjEmpleado= new CNEmpleado();
        //    SqlDataReader Loguear;

        //    ObjEmpleado.Usuario = txtuser.Text;
        //    ObjEmpleado.Contraseña = txtpass.Text;

        //    if (ObjEmpleado.Usuario == txtuser.Text)
        //    {
        //        lblErrorUser.Visible = false;
        //        if (ObjEmpleado.Contraseña == txtpass.Text)
        //        {
        //            lblErrorPass.Visible = false;
        //            Loguear = ObjEmpleado.IniciarSesion();

        //            if (Loguear.Read() == true)
        //            {
        //                this.Hide();
        //                FormPrincipal ObjFP = new FormPrincipal();
        //                ObjFP.Show();
        //            }
        //            else
        //            {
        //                lblErrorAcceso.Text = "Usuario o contraseña incorrectas, Vuelva intentarlo";
        //                lblErrorAcceso.Visible = true;
        //                txtpass.Text = "";
        //                txtpass_Leave(null, e);
        //                txtuser.Focus();
        //            }
        //        }
        //        else
        //        {
        //            lblErrorPass.Text = ObjEmpleado.Contraseña;
        //            lblErrorPass.Visible = true;
        //        }
        //    }
        //    else
        //    {
        //        lblErrorUser.Text = ObjEmpleado.Usuario;
        //        lblErrorUser.Visible = true;
        //    }
        //}

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // btnlogin_Click(null, e);
            }
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FormRecuperarContraseña form = new FormRecuperarContraseña();
            //form.ShowDialog();
        }
    }
}
