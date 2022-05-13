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
    public partial class FrmVaciarCamara : Form
    {
        public FrmVaciarCamara()
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
            this.Text = "SP_VaciarCamara";  // nombre del SP
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
                //dt.Rows.InsertAt(topItem, 0);
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
                lst.Add(new ClsParametros("@Tipo","LISTADO"));
                lst.Add(new ClsParametros("@FILTRO", CmbAlmacen.SelectedValue.ToString()));
                lst.Add(new ClsParametros("@ARTICODIGO", CmbProducto.SelectedValue));
                setDataSource(dt = M.Listado("SP_VaciarCamaraListado", lst));    //SP del reporte
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
                dtr = M.Listado("SP_VaciarCamaraListado", lst);    //SP del reporte

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

        private void BtnVaciar_Click(object sender, EventArgs e)
        {

            
            DataGridViewSelectedRowCollection Seleccionados = Dgprincipal.SelectedRows;

            if (Seleccionados.Count < 1)
            {
                MessageBox.Show("Debe Seleccionar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Confirma que desea Cambiar a Camara por Defecto!!!?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            this.Dgprincipal.Cursor = Cursors.WaitCursor;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            foreach (DataGridViewRow item in Seleccionados)
            {
                string[] msg = RemovMovCodBar(item.Cells[3].Value.ToString());

                if (msg[0] == "0")
                {

                    MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

            }
            MessageBox.Show("El Proceso Se Ejecuto Correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBuscar.PerformClick();
            this.Dgprincipal.Cursor = Cursors.Default;
        }

        private String[] RemovMovCodBar(string CODBAR)
        {
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            List<ClsParametros> lst2 = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@CODBAR", CODBAR));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_VaciarCamara", ref lst);
                msj = new string[2];
                msj[0] = lst[1].Valor.ToString();
                msj[1] = lst[2].Valor.ToString();
            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = "0";
                msj[1] = ex.Message;
            }
            return msj;
        }
    }
}
