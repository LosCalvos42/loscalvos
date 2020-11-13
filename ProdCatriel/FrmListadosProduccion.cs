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
    public partial class FrmListadosProduccion : Form
    {
        public FrmListadosProduccion()
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
            this.Text = "SP_LISTADOS_PRODUCCION: " + Listado;
            LblTituloListado.Text = TituloListado;
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
                mnuevo.Enabled = false;
                mmodificar.Enabled = false;
                meliminar.Enabled = false;
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
                if (Reliminados.Checked)
                {
                    lst.Add(new ClsParametros("@debaja",'S'));
                }
                else
                {
                    lst.Add(new ClsParametros("@debaja", 'N'));
                }
                lst.Add(new ClsParametros("@Fdesde", Fdesde));
                lst.Add(new ClsParametros("@Fhasta", Fhasta));
                setDataSource(dt = M.Listado("SP_LISTADOS_PRODUCCION", lst));
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

        private void mnuevo_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Trabajo de Elaboracion Por Mermas?", "Nuevo Trabajo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmAddOrdenDeTrabajoEstucado _FrmAddOrdenDeTrabajoEstucado = new FrmAddOrdenDeTrabajoEstucado();
                AbmE = _FrmAddOrdenDeTrabajoEstucado;

                Form _Formulario = AbmE as Form;
                _Formulario.StartPosition = FormStartPosition.CenterScreen;
                _Formulario.Text = "NUEVO"; //+ " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                _Formulario.ShowDialog();
                inicializar();
            }
            else
            {
                Form _Formulario = Abm as Form;
                _Formulario.StartPosition = FormStartPosition.CenterScreen;
                _Formulario.Text = "NUEVO";// + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                _Formulario.ShowDialog();
                inicializar();

            }
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

        private void mmodificar_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count > 0) { 

                if (Dgprincipal.CurrentRow.Cells[2].Value.ToString() == "TERMINADO" || Dgprincipal.CurrentRow.Cells[2].Value.ToString() == "ENPROCESO")
                {
                    MessageBox.Show("El Trabajo está Terminado O en Proceso, NO puede continuar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Dgprincipal.SelectedRows.Count > 0)
                {
                    if (Dgprincipal.CurrentRow.Cells[11].Value.ToString() == "ELABM")
                    {
                        FrmAddOrdenDeTrabajoEstucado _FrmAddOrdenDeTrabajoEstucado = new FrmAddOrdenDeTrabajoEstucado();
                        AbmE = _FrmAddOrdenDeTrabajoEstucado;

                        Form _Formulario = AbmE as Form;
                        _Formulario.StartPosition = FormStartPosition.CenterScreen;
                        _Formulario.Text = "MODIFICAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                        _Formulario.ShowDialog();
                        inicializar();
                    }
                    else
                    {
                        Form _Formulario = Abm as Form;
                        _Formulario.StartPosition = FormStartPosition.CenterScreen;
                        _Formulario.Text = "MODIFICAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                        _Formulario.ShowDialog();
                        inicializar();

                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                inicializar();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meliminar_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                string Nom = Dgprincipal.CurrentRow.Cells[0].Value.ToString() + " - " + Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Esta por ELIMINAR!!!", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    if (MessageBox.Show("¿Confirma que desea ELIMINAR " + (char)13 + Nom + "? ", "Eliminar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        ClsManejador M = new ClsManejador();
                        M.Ejecutarquery(@"update " + Tabla + " set "+Tabla+"_DEBAJA= 'S' where " + Tabla + "_ID=" + id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LLENAR();
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

        private void mrealizar_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.SelectedRows.Count > 0)
            {
                if (Dgprincipal.CurrentRow.Cells[2].Value.ToString() == "CERRADO")
                {
                    MessageBox.Show("El Trabajo está Terminado, NO puede continuar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Dgprincipal.CurrentRow.Cells[11].Value.ToString() == "ELABM")
                {
                    FrmAddOrdenDeTrabajoEstucado _FrmAddOrdenDeTrabajoEstucado = new FrmAddOrdenDeTrabajoEstucado();
                    AbmE = _FrmAddOrdenDeTrabajoEstucado;

                    Form _Formulario = AbmE as Form;
                    _Formulario.StartPosition = FormStartPosition.CenterScreen;
                    _Formulario.Text = "REALIZAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                    _Formulario.ShowDialog();
                    inicializar();
                }
                else
                {
                    Form _Formulario = Abm as Form;
                    _Formulario.StartPosition = FormStartPosition.CenterScreen;
                    _Formulario.Text = "REALIZAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                    _Formulario.ShowDialog();
                    inicializar();

                }
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
