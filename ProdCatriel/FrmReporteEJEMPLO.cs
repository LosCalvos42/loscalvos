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
    public partial class FrmReporteEJEMPLO : Form
    {
        public FrmReporteEJEMPLO()
        {
            InitializeComponent();
        }
        public string Listado { get; set; }
        public string Filtro { get; set; }
        public string Fdesde { get; set; }
        public string Fhasta { get; set; }
        public string Tabla { get; set; }
        public Form Abm { get; set; }
        public Form AbmE { get; set; }
        public string accion = "";
        public string TituloListado { get; set; }

        private void FrmListados_Load(object sender, EventArgs e)
        {
            Filtro = "";
            this.Text = "SP_NNNNNNNNN";  // nombre del SP
            DtDeste.Value = DateTime.Now;//.AddDays(-1);
            DtHasta.Value = DateTime.Now;
            LLENAR();
            Dgprincipal.ClearSelection();
            Permisos();
        }
        private void Permisos()
        {
            if (Program.perfil == 5)
            {
                //mnuevo.Enabled = false;
                //mmodificar.Enabled = false;
                //meliminar.Enabled = false;
            }
        }
        
        private void LLENAR()
        {
            Dgprincipal.DataSource = null;
            progressBar.Visible = true;
            pictureBox1.Visible = true;
            LblPorcentaje.Visible = true;
            System.Threading.Thread thread =
            new System.Threading.Thread(new System.Threading.ThreadStart(loadTable));
            thread.Start();
            progressBar.Style = ProgressBarStyle.Marquee;
            //LblPorcentaje.Text = string.Format("Porcentaje...{0}%", progressBar.Value);
        }

        private void loadTable()
        {
            //Dgprincipal.DataSource = null;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@listado",Listado));
                lst.Add(new ClsParametros("@Filtro",Filtro));
                lst.Add(new ClsParametros("@id", 0));
                lst.Add(new ClsParametros("@Fdesde", Fdesde));
                lst.Add(new ClsParametros("@Fhasta", Fhasta));
                setDataSource(dt = M.Listado("SP_rrrrrrr", lst));    //SP del reporte
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        internal delegate void SetDataSourceDelegate(DataTable table);
        private void setDataSource(DataTable table)
        {
            //Invoke method if required:
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), table);
            }
            else
            {
                progressBar.Visible = false;
                pictureBox1.Visible = false;
                LblPorcentaje.Visible = false;
                Dgprincipal.DataSource = table;
                EstadoGrilla();
                Dgprincipal.ClearSelection();
            }
        }
        private void EstadoGrilla()
        {
           


            for (int i = 0; i <= Dgprincipal.Rows.Count - 1; i++)
            {
                switch (Dgprincipal.Rows[i].Cells[2].Value.ToString())
                {
                    case "DISPONIBLE":
                        //Dgprincipal.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231);
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231);
                        if (Convert.ToDateTime(Dgprincipal.Rows[i].Cells[7].Value.ToString()) < DateTime.Now.Date)
                        {
                            Dgprincipal.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(245, 183, 177);
                        }

                        break;
                    case "PROCESANDO":
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                        if (Convert.ToDateTime(Dgprincipal.Rows[i].Cells[7].Value.ToString()) < DateTime.Now.Date)
                        {
                            Dgprincipal.Rows[i].Cells[7].Style.BackColor = Color.FromArgb(245, 183, 177);
                        }
                        break;
                    case "REALIZADO":
                        Dgprincipal.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(171, 235, 198);
                        break;
                    case "TERMINADO":
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(169, 223, 191);
                        break;

                }
                //Dgprincipal.Refresh();
                //Application.DoEvents();
            }
           
        } 



        private void inicializar()
        {
            Dgprincipal.DataSource = null;
            LLENAR();
        }

        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtro = "";
            Dgprincipal.DataSource = null;
            LLENAR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtro = "";
            Fdesde = (DtDeste.Value).ToString("yyyyMMdd");
            Fhasta = (DtHasta.Value).ToString("yyyyMMdd");
            Dgprincipal.DataSource = null;
            LLENAR();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgprincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgprincipal.CurrentRow.Cells[11].Value.ToString() == "ELABM")
            {
                FrmAddOrdenDeTrabajoEstucado _FrmAddOrdenDeTrabajoEstucado = new FrmAddOrdenDeTrabajoEstucado();
                AbmE = _FrmAddOrdenDeTrabajoEstucado;

                Form _Formulario = AbmE as Form;
                _Formulario.StartPosition = FormStartPosition.CenterScreen;
                _Formulario.Text = "CONSULTAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                _Formulario.ShowDialog();
                inicializar();
            }
            else
            {
                Form _Formulario = Abm as Form;
                _Formulario.StartPosition = FormStartPosition.CenterScreen;
                _Formulario.Text = "CONSULTAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                _Formulario.ShowDialog();
                inicializar();

            }
        }

        private void Ractivos_CheckedChanged(object sender, EventArgs e)
        {
            LLENAR();
        }

        private void Reliminados_CheckedChanged(object sender, EventArgs e)
        {
            LLENAR();
        }
    }
}
