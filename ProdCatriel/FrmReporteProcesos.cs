using Datos;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Alberdi
{
    public partial class FrmReporteProcesos : Form
    {
        int Kentrada;
        int Ksalida;
        double magro = 0;

        public FrmReporteProcesos()
        {
            InitializeComponent();
        }
        public int vienede { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public string CodigoM { get; set; }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuevo_Click(object sender, EventArgs e)
        {
            //FrmAddMuestra _FrmAddMuestra = new FrmAddMuestra();

            //_FrmAddMuestra.StartPosition = FormStartPosition.CenterScreen;
            //_FrmAddMuestra.Tipo = "NUEVO";
            //_FrmAddMuestra.id = 0;
            //_FrmAddMuestra.ShowDialog();
            //inicializar();
        }

        private void FrmCargaDeMuestras_Load(object sender, EventArgs e)
        {
            //LlenarGrid("MUESTRAS", "");
            //Dgprincipal.ClearSelection();

            if (vienede == 0)
            {
                permisos();
            }
            else
            {
                permisos();

                dtRDesde.Value = Fecha;
                dtRHasta.Value = Fecha;
                btnBuscarF.PerformClick();

            }
                
            
        }
        private void EstadosGrilla()
        {
            progressBar1.Maximum = progressBar1.Value+DgResumen.Rows.Count + 48;

            DgResumen.Columns[0].Visible = false;
            DgResumen.Columns[3].Visible = false;
            progressBar1.Value += 4;
            DgResumen.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgResumen.Columns[6].DefaultCellStyle.Format = "N0";
            progressBar1.Value += 4;
            DgResumen.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgResumen.Columns[7].DefaultCellStyle.Format = "N0";
            progressBar1.Value += 4;
            lblcalculando.Visible = true;
            this.Refresh();
            DgResumen.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgResumen.Columns[8].DefaultCellStyle.Format = "N0";
            progressBar1.Value += 4;
            DgResumen.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgResumen.Columns[9].DefaultCellStyle.Format = "N1";
            DgResumen.Columns[10].DefaultCellStyle.Format = "N1";
            DgResumen.Columns[11].DefaultCellStyle.Format = "N1";
            progressBar1.Value += 4;
            DgResumen.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgResumen.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            
            DgResumen.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
            DgResumen.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(208, 253, 235);

            DgResumen.Columns[8].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
            DgResumen.Columns[9].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
            //DgResumen.Columns[10].DefaultCellStyle.BackColor = Color.FromArgb(214, 234, 248);
            //DgResumen.Columns[11].DefaultCellStyle.BackColor = Color.FromArgb(214, 234, 248);

            progressBar1.Value += 4;
            using (Font font = new Font(DgResumen.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
            {
                DgResumen.Columns[5].DefaultCellStyle.Font = font;
                DgResumen.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
            }

            for (int i = 0; i < DgResumen.Rows.Count; i++)
            {
                progressBar1.Value += 1;
                if (DgResumen.Rows[i].Cells[10].Value.ToString() != "")
                {
                    decimal valor = Convert.ToDecimal(DgResumen.Rows[i].Cells[9].Value);
                    decimal min=Convert.ToDecimal(DgResumen.Rows[i].Cells[10].Value.ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                    decimal max = Convert.ToDecimal(DgResumen.Rows[i].Cells[11].Value.ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                    if ((valor< (min))||(valor>(max)))
                    {
                        DgResumen.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(245, 183, 177);
                    }
                }
                lblcalculando.Visible = false;
            }
        }






        private void mmodificar_Click(object sender, EventArgs e)
        {

          
        }
        private void permisos()
        {
            if (Program.perfil != 2)//administrador
            {
                mmodificar.Enabled = false;
                meliminar.Enabled = false;

            }
        }
        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {

           
        }

        private void Dgprincipal_Sorted(object sender, EventArgs e)
        {
            EstadosGrilla();
        }

        private void FrmCargaDeMuestras_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarF_Click(object sender, EventArgs e)
        {
           
            try
            {
                //DgResumen.Visible = false;
                this.Cursor = Cursors.WaitCursor;
                DgResumen.DataSource = null;
                lblProducto.Text= "";
                Kentrada = 0;
                Ksalida=0;
               
                if (dtRHasta.Value.Date > DateTime.Today.Date)
                {
                    MessageBox.Show("Fecha Hasta, No debe ser Mayor Fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    this.Cursor = Cursors.Default;
                    return;

                }
                if (dtRHasta.Value.Date < dtRDesde.Value.Date)
                {
                    MessageBox.Show("Fecha Desde No Debe ser Mayor que Fecha Hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    this.Cursor = Cursors.Default;
                    return;

                }
                progressBar1.Value = 20;
                progressBar1.Visible = true;
                progressBar1.Refresh();
                this.Refresh();

                DgResumen.DataSource = null;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>
                {

                    //int fed;
                    //int feh;
                    //string filtro="";
                    new ClsParametros("@Fecha_Desde", Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"))),
                    new ClsParametros("@Fecha_Hasta", Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"))),
                    new ClsParametros("@Tipo", 1),
                    new ClsParametros("@NroOt", 0)
                };
                dt = M.Listado("SP_Catriel_ProcesosResumen", lst);

                if (dt.Rows.Count > 0)
                {
                    DgResumen.DataSource = dt;
                    EstadosGrilla();
                    DgResumen.Visible = true;
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("La Consulta No Devolvio Ningun Registro.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    this.Cursor = Cursors.Default;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        private void Graficar()
        {
            //chart1.Series[0].Points.Clear();
            //double resto=100;
            //magro = 0;
            //if (Rpaleta.Checked) { 
            //    chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            //    for (int i = 0; i < Dgprincipal.Rows.Count - 1; i++)
            //    {
            //        if (Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001023" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001006")
            //        { 
            //            magro=magro + Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
            //            resto = resto - Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
            //            Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(93, 173, 226);
            //        }

            //    }
            //    chart1.Series[0].Points.AddXY("MAGRO", magro);
            //    chart1.Series[0].Points.AddXY(" ", resto);
            //}

            //if (Rjamon.Checked)
            //{
            //    chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            //    for (int i = 0; i < Dgprincipal.Rows.Count - 1; i++)
            //    {
            //        if (Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001022" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001033" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1004024" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001007")
            //        {
            //            magro=magro + Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
            //            resto = resto - Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
            //            Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(93, 173, 226);
            //        }

            //    }
            //    chart1.Series[0].Points.AddXY("MAGRO", magro);
            //    chart1.Series[0].Points.AddXY(" ", resto);
            //}

            //double merma = (Kentrada- Ksalida);
            //merma = merma / Ksalida*100;
            //txtDiferencia.Text = merma.ToString("N2");
        }
        private void mimprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción No esta Disponible.", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void print_Click(object sender, EventArgs e)
        {
            //if (Dgprincipal.Rows.Count < 2)
            //{
            //    return;
            //}

           
            //ExportarDesp exp = new ExportarDesp();
            //exp.ExportarDataGridViewExcel(DgResumen,Dgprincipal, Convert.ToString(dtRDesde.Value.ToString("dd/MM/yyyy")), Convert.ToString(dtRHasta.Value.ToString("dd/MM/yyyy")), Convert.ToString(Kentrada.ToString("N2")), Convert.ToString(magro.ToString("N2")), lblProducto.Text, txtDiferencia.Text);
            //this.Refresh();
            //System.Threading.Thread.Sleep(100);
         
            
        }
        private System.Windows.Forms.Cursor curAnterior = null;

        private void DgResumen_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DgResumen.Columns[5].Index)
                {
                    this.DgResumen.Cursor = Cursors.Hand;
                }
                else
                {
                    this.DgResumen.Cursor = curAnterior;
                }
            }
        }

       

        private void DgResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int NroProceso;
            string NroOt;
            string Lote;
            int TIPOPROCESO = 0;
            
            if (DgResumen.CurrentRow.Cells[5].Value.ToString() != "" && DgResumen.CurrentCell.ColumnIndex==5)
            {

                NroProceso = Convert.ToInt32(DgResumen.CurrentRow.Cells[3].Value.ToString());
                NroOt = DgResumen.CurrentRow.Cells[0].Value.ToString();
                Lote = DgResumen.CurrentRow.Cells[5].Value.ToString();

                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    string SQL;
                    SQL = "SELECT ISNULL(PROCESOS_TIPO,'') AS TIPO, TIPOPROCESO_DESC,PROCESOS_DESC " +
                            "FROM[ALBPROD].[dbo].[PROCESOS] " +
                            "INNER JOIN TIPOPROCESO ON TIPOPROCESO_ID = PROCESOS_TIPO " +
                            "WHERE PROCESOS_IDTWINS = " + NroProceso;
                    dt = M.lisquery(SQL);

                    if (dt.Rows.Count > 0)
                    {
                        TIPOPROCESO = Convert.ToInt32(dt.Rows[0][0].ToString());

                    }
                    if (TIPOPROCESO == 1)
                    {
                        FrmReporteDespostada _FrmReporteDespostada = new FrmReporteDespostada
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            Codigo = CodigoM,
                            Fecha = Convert.ToDateTime(DgResumen.CurrentRow.Cells[0].Value.ToString()),
                            vienede = 1
                        };
                        _FrmReporteDespostada.ShowDialog();


                    }
                    else
                    {
                        FrmReporteProcesosDetalle _FrmReporteProcesosDetalle = new FrmReporteProcesosDetalle
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            NroOT = Convert.ToInt32(DgResumen.CurrentRow.Cells[0].Value.ToString()),
                            NroProceso = Convert.ToInt32(DgResumen.CurrentRow.Cells[3].Value.ToString()),
                            vienede = 1
                        };
                        _FrmReporteProcesosDetalle.ShowDialog();


                    }


                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void DgResumen_Sorted(object sender, EventArgs e)
        {
            EstadosGrilla();
        }
    }
}
