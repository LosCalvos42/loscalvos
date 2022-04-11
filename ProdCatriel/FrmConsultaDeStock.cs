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

namespace LOSCALVOS
{
    public partial class FrmConsultaDeStock : Form
    {
        public FrmConsultaDeStock()
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
            this.Text = "SP_ConsultaDeStock";  // nombre del SP
            desde = DateTime.Now;//.AddDays(-1);
            hasta = DateTime.Now;

            Cargarcombo("CAMBIOALMACEN", CmbAlmacen);
            Cargarcombo("Arti", CmbProducto);

            //LLENAR();
            //Dgprincipal.ClearSelection();
            
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
                _combo.ValueMember = "CODIGO";
                DataRow topItem = dt.NewRow();
                //topItem[1] = 1;
                //topItem[2] = "TODOS";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue ="TODOS";
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        

        private void loadTable()
        {
            //Dgprincipal.DataSource = null;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo","RESUMEN"));
                lst.Add(new ClsParametros("@FILTRO", CmbAlmacen.SelectedValue.ToString()));
                lst.Add(new ClsParametros("@ARTICODIGO", CmbProducto.SelectedValue));
                setDataSource(dt = M.Listado("SP_ConsultaDeStock", lst));    //SP del reporte
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
                //EstadoGrilla();
                Dgprincipal.ClearSelection();
            }
        }
        private void EstadoGrilla()
        {
 
            Dgprincipal.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[8].DefaultCellStyle.Format = "N2";
            using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
            {
                Dgprincipal.Columns[6].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[6].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);
            }

            if (CmbProducto.SelectedValue.ToString() != "0")
            {
                int totalU = 0;
                decimal totalK = 0;
                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {

                    totalU = totalU + Convert.ToInt32(Dgprincipal.Rows[i].Cells[7].Value);
                    totalK = totalK + Convert.ToDecimal(Dgprincipal.Rows[i].Cells[8].Value);

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
            Dgprincipal.DataSource = null;
            LLENAR();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgprincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetalleDeStock _FrmDetalleDeStock = new FrmDetalleDeStock();

            _FrmDetalleDeStock.Camara = Dgprincipal.Rows[Dgprincipal.CurrentRow.Index].Cells[4].Value.ToString();
            _FrmDetalleDeStock.Producto = Dgprincipal.Rows[Dgprincipal.CurrentRow.Index].Cells[0].Value.ToString();
            _FrmDetalleDeStock.StartPosition = FormStartPosition.CenterScreen;
            _FrmDetalleDeStock.ShowDialog();
            inicializar();
        }

        private void mimprimir_Click(object sender, EventArgs e)
        {

            this.Dgprincipal.Cursor = Cursors.WaitCursor;
            ClsManejador M = new ClsManejador();
            DataTable dtr = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo", "REPORTE"));
                lst.Add(new ClsParametros("@FILTRO", CmbAlmacen.SelectedValue.ToString()));
                lst.Add(new ClsParametros("@ARTICODIGO", CmbProducto.SelectedValue));
                setDataSource(dtr = M.Listado("SP_ConsultaDeStock", lst));    //SP del reporte

                if (dtr.Rows.Count > 0)
                {
                   
                    ReportDocument reporte = new ReportDocument();
                    reporte.Load(Application.StartupPath + @"\Reportes\Stock.rpt");
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
