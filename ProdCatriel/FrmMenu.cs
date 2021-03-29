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
using logica;
using System.Runtime.InteropServices;

namespace LOSCALVOS
{
    public partial class FrmMenu : Form
    {

        public string nombreparametroServer;
        public FrmMenu()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin _FrmLogin = new FrmLogin();
            _FrmLogin.Show();
            this.Hide();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        private void selecciónJamonXTexturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesada _FrmSelecJamon = new FrmPesada();
            _FrmSelecJamon.StartPosition = FormStartPosition.CenterScreen;
            _FrmSelecJamon.MdiParent = this;
            _FrmSelecJamon.Show();
        }
        
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser _FrmUser = new FrmUser();
            _FrmUser.MdiParent = this;
            _FrmUser.Show();
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.BarraTitulo.Region = region;
            this.Invalidate();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            if (ClsManejador.ip == "DESARROLLO")
            {

                nombreparametroServer = "SERVIDOR_D";
                try { 
                    Bitmap bmp = new Bitmap(Application.StartupPath + @"\Imagenes\DESARROLLO.jpg");
                    panel1.BackgroundImage = bmp;
                    panel1.BackgroundImageLayout = ImageLayout.Zoom;
                }
                catch
                {
                    MessageBox.Show("No se encuentra la carpeta Multimedia" + Environment.NewLine + "Consulte Con el Administrador del Sistema.", "Error al intentar Abrir Multimedia ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                nombreparametroServer = "SERVIDOR_P";
            }

            //this .BackColor= Color.FromArgb(64, 69, 76);
            ClsListarParametros LP = new ClsListarParametros();
            LP.m_parametro = "EMPRESA";
            LP.m_valor = "";
            DataTable DT = LP.BuscarParametro();
            pnlempresa.Text = DT.Rows[0][0].ToString();
            pnlempresa.AutoSize = StatusBarPanelAutoSize.Contents;

            LP.m_parametro = nombreparametroServer; //NOMBRE DE PARAMETRO DE SERVIDOR A BUSCAR
            DT = LP.BuscarParametro();
            pnlserver.Text = DT.Rows[0][0].ToString();
            pnlserver.AutoSize = StatusBarPanelAutoSize.Contents;
            
            LP.m_parametro = "NOMBRESOFT";
            DT = LP.BuscarParametro();
            pnlsistema.Text ="Sistema: "+ DT.Rows[0][0].ToString() + "       Version: " + FrmLogin.verlocal;
            pnlsistema.AutoSize = StatusBarPanelAutoSize.Contents;
            pnluser.Text = "Usuario: " +FrmLogin.user;
            pnluser.AutoSize = StatusBarPanelAutoSize.Contents;
            permisos();

            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql  = @"select TOP(1) isnull(DISPIMPRESORA_NOMBRE, '') as IMPRESORA, isnull(DISPBALANZAS_NOMBRE, '') AS BALANZA " +
            ",isnull(DISPBALANZAS_PUERTO, '') AS PUERTO " +
            "FROM [DISPOSITIVOS] D " +
            "INNER JOIN [DISPIMPRESORAS] I ON D.DISPOSITIVO_ID = I.DISPOSITIVO_ID AND I.DISPIMPRESORA_ESTADO = 'ON' " +
            "left join [DISPBALANZAS] B on B.DISPOSITIVO_ID = D.DISPOSITIVO_ID AND B.DISPBALANZAS_ESTADO = 'ON' " +
            "WHERE D.DISPOSITIVO_NROSERIE = '" + Program.SerialPC + "' " +
            "AND D.DISPOSITIVO_NOMBRE = '" + Program.HostName + "' ";



            dt = M.lisquery(ssql);

            if (dt.Rows.Count == 1)
            {
                Program.IMPRESORAETIQUETA = dt.Rows[0][0].ToString();
                Program.BALANZA = dt.Rows[0][1].ToString();
                Program.BALANZAPUERTO= dt.Rows[0][2].ToString();
                PPrint.Text = Program.IMPRESORAETIQUETA;
                PPrint.AutoSize = StatusBarPanelAutoSize.Contents;

                PBalanza.Text = Program.BALANZA;
                PBalanza.AutoSize = StatusBarPanelAutoSize.Contents;

            }

        }

        private void permisos()
        {
            //BtnConsultas.Enabled = false;

            if (Program.perfil != 1)//administrador
            {
                Btnproduccion.Enabled = true;
                BtnConfiguracion.Enabled = false;
            }

            


        }



        private void ingresoXProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTwinsIngresoXproveedor _FrmTwinsIngresoXproveedor = new FrmTwinsIngresoXproveedor();
            _FrmTwinsIngresoXproveedor.StartPosition = FormStartPosition.CenterScreen;
            _FrmTwinsIngresoXproveedor.MdiParent = this;
            _FrmTwinsIngresoXproveedor.Show();
        }

        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 69, 76);
            PPrint.Text = Program.IMPRESORAETIQUETA;
            PBalanza.Text = Program.BALANZA;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDE
            if (panelMenu.Width == 160)
            {
                this.tmOcultarMenu.Enabled = true;
                PTrazar.Visible = false;
            }
            else if (panelMenu.Width == 52) { 
                this.tmMostrarMenu.Enabled = true;
            PTrazar.Visible = true;}
            //-------SIN EFECTO SLIDE
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Program._FrmSelecJamon == false)
            //{
            //    HabilitarBotones(button1);
            //    FrmSelecJamon fm = new FrmSelecJamon();
            //    fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //    AbrirFormEnPanel(fm);
            //    Program._FrmSelecJamon = true;
            //}

            if (Program._FrmProduccion == false)
            {
                HabilitarBotones(Btnproduccion);
                FrmProduccion fm = new FrmProduccion();

                fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                AbrirFormEnPanel(fm);
                botones (Program._FrmProduccion);
                Program._FrmProduccion = true;
            }

        }
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            //MostrarFormLogo();

            Btnproduccion.BackColor = Color.FromArgb(88, 19, 76);
            BtnConfiguracion.BackColor = Color.FromArgb(88, 19, 76);
            BtnConsultas.BackColor = Color.FromArgb(88, 19, 76);
            BtnUtilidades.BackColor = Color.FromArgb(88, 19, 76);

            //btnListaClientes.BackColor = Color.FromArgb(29, 34, 39);

        }

        


        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            //fh.MdiParent=this;
            fh.Show();
        }
        private void HabilitarBotones(Button b)
        {
            Btnproduccion.BackColor = Color.FromArgb(88, 19, 76);
            BtnConfiguracion.BackColor = Color.FromArgb(88, 19, 76);
            BtnConsultas.BackColor = Color.FromArgb(88, 19, 76);
            BtnUtilidades.BackColor = Color.FromArgb(88, 19, 76);
            b.BackColor = Color.FromArgb(211, 84, 0);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Confirma Que Desea Salir de la Aplicacion?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program._FrmConfiguracion == false)
            {
                HabilitarBotones(BtnConfiguracion);
                FrmConfiguracion fm2 = new FrmConfiguracion();
                fm2.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                AbrirFormEnPanel(fm2);
                botones(Program._FrmConfiguracion);
                Program._FrmConfiguracion = true;
            }
        }

        //private void btnMaximizar_Click(object sender, EventArgs e)
        //{
        //    lx = this.Location.X;
        //    ly = this.Location.Y;
        //    sw = this.Size.Width;
        //    sh = this.Size.Height;
        //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        //    btnMaximizar.Visible = false;
        //    btnNormal.Visible = true;
        //}

        //private void btnNormal_Click(object sender, EventArgs e)
        //{
        //    this.Size = new Size(sw, sh);
        //    this.Location = new Point(lx, ly);
        //    btnNormal.Visible = false;
        //    btnMaximizar.Visible = true;
        //}

        //private void btnMinimizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 160)
                this.tmMostrarMenu.Enabled = false;
            else
                panelMenu.Width = panelMenu.Width + 36;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar la Aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                //System.Environment.Exit(0);
            }
            else
            { 
                e.Cancel = true;
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if (Program._FrmConsultas == false)
            {
                HabilitarBotones(BtnConsultas);
                FrmConsultas fm2 = new FrmConsultas();

                fm2.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                AbrirFormEnPanel(fm2);
                botones(Program._FrmConsultas);
                Program._FrmConsultas = true;
            }
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 52)
                this.tmOcultarMenu.Enabled = false;
            else
                panelMenu.Width = panelMenu.Width - 36;
        }

        private void botones(object formHijo)
        {
            Program._FrmSelecJamon = false;
            Program._FrmTipoRecurso = false;
            Program._FrmMenuProduccion = false;
            Program._FrmProductos = false;
            Program._FrmUser = false;
            Program._FrmProduccion = false;
            Program._FrmConsultas = false;
            Program._FrmConfiguracion = false;
            Program._FrmUtilidades = false;
            formHijo = true;
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            if (Program._FrmUtilidades == false)
            {
                HabilitarBotones(BtnUtilidades);
                FrmUtilidades fm2 = new FrmUtilidades();
                fm2.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
                AbrirFormEnPanel(fm2);
                botones(Program._FrmUtilidades);
                Program._FrmUtilidades = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
