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
    public partial class FrmListados : Form
    {
        public FrmListados()
        {
            InitializeComponent();
        }
        public string Listado { get; set; }
        public string Filtro { get; set; }
        public string Tabla { get; set; }
        public Form Abm { get; set; }
        public string accion = "";
        public string TituloListado { get; set; }

        private void FrmListados_Load(object sender, EventArgs e)
        {

            if (Abm.Name == "FrmAddArticulos")  // Esto es para que no abra el ABM 
            {
                Reliminados.Enabled = false;
                Ractivos.Enabled = false;
            }


            Filtro = "";
            this.Text = "SP_LISTADOS_PRODUCCION: " + Listado;
            LblTituloListado.Text=TituloListado;
            //inicializar();
            //LlenarGrid(Listado, "");
            LLENAR();
            Dgprincipal.ClearSelection();
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
            if (Listado == "OTRABAJOTWINS")
            {
                Dgprincipal.RowsDefaultCellStyle.BackColor = Color.Bisque;
            }

            for (int i = 0; i <= Dgprincipal.Rows.Count - 1; i++)
            {
                switch (Dgprincipal.Rows[i].Cells[2].Value.ToString())
                {

                    case "DISPONIBLE":
                        //Dgprincipal.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231);
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231);
                        if (Convert.ToDateTime(Dgprincipal.Rows[i].Cells[3].Value.ToString()) < DateTime.Now.Date)
                        {
                            Dgprincipal.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(245, 183, 177);
                        }

                        break;
                    case "PROCESANDO":
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                        if (Convert.ToDateTime(Dgprincipal.Rows[i].Cells[3].Value.ToString()) < DateTime.Now.Date)
                        {
                            Dgprincipal.Rows[i].Cells[3].Style.BackColor = Color.FromArgb(245, 183, 177);
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
            if (Abm.Name == "FrmAddArticulos")  // Esto es para que no abra el ABM 
            {
                MessageBox.Show("Los Artículos se modifican solo en el sistema NETPAK.\nConsulte con el Administrador ", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form _Formulario = Abm as Form;
            _Formulario.StartPosition = FormStartPosition.CenterScreen;
            _Formulario.Text = "NUEVO - 0";
            _Formulario.ShowDialog();
            inicializar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtro = txtBuscar.Text;
            Dgprincipal.DataSource = null;
            LLENAR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtro = txtBuscar.Text;
            Dgprincipal.DataSource = null;
            LLENAR();
        }

        private void mmodificar_Click(object sender, EventArgs e)
        {

            if (Dgprincipal.SelectedRows.Count > 0)
            {
                if (Abm.Name == "FrmAddArticulos")  // Esto es para que no abra el ABM 
                {
                    MessageBox.Show("Los Artículos se modifican solo en el sistema NETPAK.\nConsulte con el Administrador ", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 

                if (Abm.Name == "FrmForAddFormulas")
                {
                    FrmForAddFormulas _FrmForAddFormulas = new FrmForAddFormulas();
                    _FrmForAddFormulas.StartPosition = FormStartPosition.CenterScreen;
                    _FrmForAddFormulas.Text = "MODIFICAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString()
                    ;
                    _FrmForAddFormulas.Show();
                    inicializar();
                    return;
                }

                 Form _Formulario = Abm as Form;
                _Formulario.StartPosition = FormStartPosition.CenterScreen;
                _Formulario.Text = "MODIFICAR" +" - "+ Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                _Formulario.ShowDialog();
                inicializar();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            inicializar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meliminar_Click(object sender, EventArgs e)
        {
            if (Abm.Name == "FrmAddArticulos")  // Esto es para que no abra el ABM 
            {
                MessageBox.Show("Los Artículos se modifican solo en el sistema NETPAK.\nConsulte con el Administrador ", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (Dgprincipal.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                string Nom = Dgprincipal.CurrentRow.Cells[1].Value.ToString() + " - " + Dgprincipal.CurrentRow.Cells[2].Value.ToString();
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
            if (Abm.Name == "FrmAddArticulos")  // Esto es para que no abra el ABM 
            {
                MessageBox.Show("Los Artículos se modifican solo en el sistema NETPAK.\nConsulte con el Administrador ", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form _Formulario = Abm as Form;
            _Formulario.StartPosition = FormStartPosition.CenterScreen;
            _Formulario.Text = "CONSULTAR" + " - " + Dgprincipal.CurrentRow.Cells[0].Value.ToString();
            _Formulario.ShowDialog();
            inicializar();
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
