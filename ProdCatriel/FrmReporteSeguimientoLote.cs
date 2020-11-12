using CrystalDecisions.CrystalReports.Engine;
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

namespace TRAZAAR
{
    public partial class FrmReporteSeguimientoLote : Form
    {
        public FrmReporteSeguimientoLote()
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
        public DateTime desde;
        public DateTime hasta;
       
        private void FrmListados_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            pictureBox1.Visible = false;
            LblPorcentaje.Visible = false;

            Filtro = "";
            this.Text = "SP_ConsultaSalazon";  // nombre del SP
            desde = DateTime.Now;//.AddDays(-1);
            hasta = DateTime.Now;
            DtDeste.Value= PrimerDia(desde);
            DtHasta.Value = DtDeste.Value.AddDays(6);
            //CmbProducto.DataSource = null;
            //CargarCombos("PRODUCTO", Convert.ToString(DtDeste.Value.ToString("yyyyMMdd")), Convert.ToString(DtHasta.Value.ToString("yyyyMMdd")));

            LLENAR();
            Dgprincipal.ClearSelection();
            
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
            if(CmbProducto.SelectedValue==null)
            {
                return;
            }
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

        public DateTime PrimerDia(DateTime desde)
        {
            var candidateDate = desde; while (candidateDate.DayOfWeek != DayOfWeek.Monday)
            { candidateDate = candidateDate.AddDays(-1); }
            return candidateDate;
        }

        private void CargarCombos(string Filtro, string fdesde, string fhasta)
        {
            CmbProducto.DataSource = null;
            ClsManejador M = new ClsManejador();
             DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo","COMBO"));
                lst.Add(new ClsParametros("@Fechadesde", fdesde));
                lst.Add(new ClsParametros("@Fechahasta", fhasta));
                lst.Add(new ClsParametros("@FILTRO", ""));
                dt = M.Listado("SP_ConsultaSalazon", lst);

                if (dt.Rows.Count > 1)
                {
                    CmbProducto.DataSource = dt;
                    CmbProducto.DisplayMember = "DESCRIPCION";
                    CmbProducto.ValueMember = "CODIGO";
                }
                


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void loadTable()
        {
            //Dgprincipal.DataSource = null;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {

                lst.Add(new ClsParametros("@Tipo","GRILLA"));
                lst.Add(new ClsParametros("@Fechadesde", DtDeste.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@FechaHASTA", DtHasta.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@FILTRO", CmbProducto.SelectedValue));
                setDataSource(dt = M.Listado("SP_ConsultaSalazon", lst));    //SP del reporte
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
 
            Dgprincipal.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format = "N2";
            using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
            {
                Dgprincipal.Columns[5].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[5].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);
            }
            if (CmbProducto.SelectedValue.ToString() != "0")
            {
                int totalU = 0;
                decimal totalK = 0;
                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {

                    totalU = totalU + Convert.ToInt32(Dgprincipal.Rows[i].Cells[6].Value);
                    totalK = totalK + Convert.ToDecimal(Dgprincipal.Rows[i].Cells[7].Value);

                }
                LblTotal.Text = "TOTAL: " + totalU.ToString("N0")+" Unidades       " + totalK.ToString("N2")+" Kilos";
                LblTotal.Visible = true;
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
            LblTotal.Visible = false;
            Fdesde = (DtDeste.Value).ToString("yyyyMMdd");
            Fhasta = (DtHasta.Value).ToString("yyyyMMdd");
            Dgprincipal.DataSource = null;
            if (DtHasta.Value < DtDeste.Value)
            {
                MessageBox.Show("Fecha Desde No Debe ser Mayor que Fecha Hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DtHasta.Focus();
                return;
            }     
            LLENAR();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgprincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        
        private void Dgprincipal_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgprincipal.Columns[5].Index)
            {
                this.Dgprincipal.Cursor = Cursors.Hand;
            }
            else
            {
                this.Dgprincipal.Cursor = Cursors.Default;
            }
        }

        private void DtHasta_ValueChanged(object sender, EventArgs e)
        { 
            //CmbProducto.DataSource = null;
            CargarCombos("PRODUCTO", Convert.ToString(DtDeste.Value.ToString("yyyyMMdd")), Convert.ToString(DtHasta.Value.ToString("yyyyMMdd")));

        }

        private void DtDeste_ValueChanged(object sender, EventArgs e)
        {
            CargarCombos("PRODUCTO", Convert.ToString(DtDeste.Value.ToString("yyyyMMdd")), Convert.ToString(DtHasta.Value.ToString("yyyyMMdd")));
        }

        private void mimprimir_Click(object sender, EventArgs e)
        {

            this.Dgprincipal.Cursor = Cursors.WaitCursor;
            ClsManejador M = new ClsManejador();
            DataTable dtr = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                this.Dgprincipal.Cursor = Cursors.WaitCursor;
                lst.Add(new ClsParametros("@Tipo", "REPORTE"));
                lst.Add(new ClsParametros("@Fechadesde", DtDeste.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@FechaHASTA", DtHasta.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@FILTRO", CmbProducto.SelectedValue));
                dtr = M.Listado("SP_ConsultaSalazon", lst);//SP del reporte

                if (dtr.Rows.Count > 0)
                {
                   
                    ReportDocument reporte = new ReportDocument();
                    reporte.Load(Application.StartupPath + @"\Reportes\Salazon.rpt");
                    reporte.SetDataSource(dtr);
                    FrmReporte _FrmReporte = new FrmReporte();
                    _FrmReporte.StartPosition = FormStartPosition.CenterScreen;
                    _FrmReporte.PrepararReporte(reporte);
                    ;
                    _FrmReporte.Show();
                    this.Dgprincipal.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                this.Dgprincipal.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
