using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Cursor = System.Windows.Forms.Cursor;
using System.Drawing.Printing;

namespace LOSCALVOS
{
    public partial class FrmAgendaDeTrabajo : Form
    {
        public FrmAgendaDeTrabajo()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }
        public string Fdesde { get; set; }
        public string Fhasta { get; set; }


        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            Cargarcombo("ARTICULOAGENDA", CmbProducto,"");
            Cargarcombo("LOTE", CmbLote, CmbProducto.SelectedValue.ToString());
            Inicio();
        }
        private void limpiarObjetos()
        {
            
        }

        private void CargaraGrilla()
        {

            string Lote = "";
            Lote= CmbLote.SelectedValue.ToString();
            Dgprincipal.DataSource = null;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Codprod", CmbProducto.SelectedValue));
                lst.Add(new ClsParametros("@lote", Lote));
                lst.Add(new ClsParametros("@desde", Fdesde));
                lst.Add(new ClsParametros("@hasta", Fhasta));
                setDataSource(dt = M.Listado("SP_GetAgendaDeTrabajo", lst));
                if (dt.Rows.Count > 0)
                {
                    Dgprincipal.DataSource = dt;
                    Dgprincipal.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(142, 68, 173);
                    Dgprincipal.Columns[0].DefaultCellStyle.ForeColor = Color.White;
                    Dgprincipal.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 188);
                    Dgprincipal.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(178, 235, 242);
                    Dgprincipal.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(197, 202, 233);
                    Dgprincipal.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                    Dgprincipal.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                    Dgprincipal.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 128);
                    Dgprincipal.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(179, 229, 252);
                    Dgprincipal.Columns[8].Visible = false;
                    Dgprincipal.Columns[9].Visible = false;
                    Dgprincipal.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    Dgprincipal.ClearSelection();
                }

                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {
                    if (Dgprincipal.Rows[i].Cells[2].Value.ToString() == "PRIMERA SAL")
                    {
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(142, 68, 173);
                        Dgprincipal.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLENAR()
        {
            Dgprincipal.DataSource = null;
            progressBar.Visible = true;
            pictureBox1.Visible = true;
            LblPorcentaje.Visible = true;
            System.Threading.Thread thread =
            new System.Threading.Thread(new System.Threading.ThreadStart(CargaraGrilla));
            thread.Start();
            progressBar.Style = ProgressBarStyle.Marquee;
            //LblPorcentaje.Text = string.Format("Porcentaje...{0}%", progressBar.Value);
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
            }
        }

        private void Cargarcombo(string combo, ComboBox _combo,string filtro)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                _combo.DataSource = null;
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", filtro));
                dt = M.Listado("sp_CargaCombos", lst);
                if (dt.Rows.Count > 0) { 
                    _combo.DataSource = dt;
                    _combo.DisplayMember = "NOMBRE";
                    _combo.ValueMember = "CODIGO";
                    DataRow topItem = dt.NewRow();
                    topItem[1] = 1;

                    if(combo== "ARTICULOAGENDA")
                    {
                        topItem[2] = "-Select-";
                    }
                    else
                    {
                        topItem[2] = "TODAS";
                    }
                    dt.Rows.InsertAt(topItem, 0);
                    _combo.SelectedValue = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Inicio()
        {
           limpiarObjetos();
        }
        

        private bool valido()
        {

            if (CmbProducto.Text == "-Select-")
            {
                MessageBox.Show("Debe seleccionar un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbProducto.Focus();
                return false;
            }
            if (CmbLote.Text =="")
            {
                MessageBox.Show("No Existen lotes para el producto seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbProducto.Focus();
                return false;
            }
            return true;
        }
        
        private void Dgprincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgprincipal.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dgprincipal.DataSource = null;
            Fdesde = (DtDeste.Value).ToString("yyyyMMdd");
            Fhasta = (DtHasta.Value).ToString("yyyyMMdd");

            if (valido())
            {
                LLENAR();
            }
        }

        private void CmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cargarcombo("LOTE", CmbLote, CmbProducto.SelectedValue.ToString());
        }
        private Cursor curAnterior = null;
        private void mimprimir_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count < 1)
            {
                MessageBox.Show("NO hay datos para imprimir", "Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                imprimir();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string getImpresoraPorDefecto()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
        private void imprimir()
        {
            string Lote = "";
            Lote = CmbLote.SelectedValue.ToString();
            ReportDocument reporte = new ReportDocument();
            
            reporte.Load(Application.StartupPath + @"\Reportes\AgendaPorPeriodo.rpt");
            

            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
           
            lst.Add(new ClsParametros("@Codprod", CmbProducto.SelectedValue));
            lst.Add(new ClsParametros("@lote", Lote));
            lst.Add(new ClsParametros("@desde", Fdesde));
            lst.Add(new ClsParametros("@hasta", Fhasta));
            dt = M.Listado("SP_GetAgendaDeTrabajo", lst);
            reporte.SetDataSource(dt);
            //reporte.PrintOptions.PrinterName = getImpresoraPorDefecto();
            //reporte.PrintToPrinter(1, false, 0, 0);

            PrintDialog dialog1 = new PrintDialog();
            if (dialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int copies = dialog1.PrinterSettings.Copies;
                int fromPage = dialog1.PrinterSettings.FromPage;
                int toPage = dialog1.PrinterSettings.ToPage;
                bool collate = dialog1.PrinterSettings.Collate;

                reporte.PrintOptions.PrinterName = dialog1.PrinterSettings.PrinterName;
                reporte.PrintToPrinter(copies, collate, fromPage, toPage);
            }
            //FrmReporte _FrmReporte = new FrmReporte();
            //_FrmReporte.StartPosition = FormStartPosition.CenterScreen;
            //_FrmReporte.PrepararReporte(reporte);
            //_FrmReporte.ShowDialog();
        }
    }
}

    
 

