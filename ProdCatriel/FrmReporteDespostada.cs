using Datos;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.LinkLabel;

namespace TRAZAAR
{
    public partial class FrmReporteDespostada : Form
    {
        int Kentrada;
        int Ksalida;
        double magro = 0;

        public FrmReporteDespostada()
        {
            InitializeComponent();
        }
        public int vienede { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public int NCproceso { get; set; }
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
                if (Codigo == "1001001")
                {
                    NCproceso = 1001001;
                    Rpaleta.Checked = true;
                }
                if (Codigo == "1001002")
                {
                    NCproceso = 1001002;
                    Rjamon.Checked = true;
                }
                btnBuscarF.PerformClick();

            }


        }
        private void LlenarGrid(string Combo, string Filtro)
        {


            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", Combo));
                lst.Add(new ClsParametros("@filtro", Filtro));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_CargaCombos", lst);
                //Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);
                //Dgprincipal.Rows.Clear();
                Dgprincipal.DataSource = dt;
                EstadosGrilla();
                Dgprincipal.ClearSelection();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void EstadosGrilla()
        {
            

                using (Font font = new Font(
                        Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
                {

                    Dgprincipal.Columns[2].DefaultCellStyle.Font = font;
                    Dgprincipal.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                Dgprincipal.Columns[0].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[0].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);
            }


            
        }
        private void inicializar()
        {

            LlenarGrid("MUESTRAS", "");
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
                chart1.Series[0].Points.Clear();
                lblProducto.Text = "";
                Kentrada = 0;
                Ksalida = 0;

                if (dtRHasta.Value.Date > DateTime.Today.Date)
                {
                    MessageBox.Show("Fecha Hasta, No debe ser Mayor Fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;

                }
                if (dtRHasta.Value.Date < dtRDesde.Value.Date)
                {
                    MessageBox.Show("Fecha Desde No Debe ser Mayor que Fecha Hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;

                }


                int fed;
                int feh;
                string filtro = "";
                DgIngreso.DataSource = null;
                Dgprincipal.Rows.Clear();
                if (Rjamon.Checked)
                {
                    NCproceso = 1001002;
                    filtro = "1001002";
                    lblProducto.Text = "Entrada a Despostada...1001002 - JAMÓN C/HUESO";
                }
                if (Rpaleta.Checked)
                {
                    NCproceso = 1001001;
                    filtro = "1001001";
                    lblProducto.Text = "Entrada a Despostada...1001001 - PALETA C/HUESO";
                }
                fed = Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"));
                feh = Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"));
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                dt = M.lisquery("SP_informeDespostadaCatriel " + fed + "," + feh + "," + filtro + ",E");
                if (dt.Rows.Count < 2)
                {
                    MessageBox.Show("No existen Datos Para los Parametros Ingresados .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;
                }

                DgIngreso.DataSource = dt;
                DgIngreso.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                DgIngreso.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                using (Font font = new Font(
                DgIngreso.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Bold))
                {
                    DgIngreso.Rows[DgIngreso.RowCount - 1].DefaultCellStyle.Font = font;
                }
                DgIngreso.ClearSelection();
                DgIngreso.FirstDisplayedScrollingRowIndex = DgIngreso.RowCount - 1;
                dt.Dispose();
                DgIngreso.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                Kentrada = Convert.ToInt32(DgIngreso.Rows[DgIngreso.RowCount - 1].Cells[7].Value.ToString());
                DgIngreso.Columns[5].DefaultCellStyle.Format = "N0";
                DgIngreso.Columns[7].DefaultCellStyle.Format = "N0";

                dt = M.lisquery("SP_informeDespostadaCatriel " + fed + "," + feh + "," + filtro + ",S");

                //Dgprincipal.DataSource = dt;
                EstadosGrilla();
                Dgprincipal.ClearSelection();


                if (dt.Rows.Count < 2)
                {
                    MessageBox.Show("No existen Datos Para los Parametros Ingresados .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Dgprincipal.Rows.Add(dt.Rows[i][0]);
                    Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    Dgprincipal.Rows[i].Cells[2].Value = Convert.ToDecimal(dt.Rows[i][2].ToString());
                    Dgprincipal.Rows[i].Cells[3].Value = Convert.ToDouble(dt.Rows[i][3].ToString());
                    Dgprincipal.Rows[i].Cells[4].Value = Convert.ToDecimal(dt.Rows[i][4].ToString());
                }

                Dgprincipal.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(208, 253, 235);
                Dgprincipal.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(208, 253, 235);
                Dgprincipal.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Bold))
                {
                    Dgprincipal.Rows[Dgprincipal.RowCount - 1].DefaultCellStyle.Font = font;
                }

                int totalk = Convert.ToInt32(Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[2].Value.ToString());
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[3].Value = "";
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[4].Value = "";
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[5].Value = "";
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[6].Value = "";
                for (int i = 0; i < Dgprincipal.Rows.Count - 1; i++)
                {

                    Dgprincipal.Rows[i].Cells[5].Value = Convert.ToDecimal(Convert.ToDecimal(Dgprincipal.Rows[i].Cells[2].Value.ToString()) * 100 / totalk).ToString("N2");
                    if (Convert.ToDecimal(Dgprincipal.Rows[i].Cells[5].Value.ToString()) < Convert.ToDecimal(Dgprincipal.Rows[i].Cells[3].Value.ToString()))
                    {
                        Dgprincipal.Rows[i].Cells[6].Value = "-";
                    }
                    else
                    if (Convert.ToDecimal(Dgprincipal.Rows[i].Cells[5].Value.ToString()) > Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value.ToString()))
                    {
                        Dgprincipal.Rows[i].Cells[6].Value = "+";
                    }

                    else
                    {
                        Dgprincipal.Rows[i].Cells[6].Value = "OK";
                    }
                }
                Ksalida = totalk;
                Dgprincipal.ClearSelection();

                Graficar();


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void Graficar()
        {
            chart1.Series[0].Points.Clear();
            double resto = 100;
            magro = 0;
            if (Rpaleta.Checked)
            {
                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                for (int i = 0; i < Dgprincipal.Rows.Count - 1; i++)
                {
                    if (Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001023" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001006" ||Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001045" )
                    {
                        magro = magro + Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
                        resto = resto - Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(93, 173, 226);
                    }

                }
                chart1.Series[0].Points.AddXY("MAGRO", magro);
                chart1.Series[0].Points.AddXY(" ", resto);
            }

            if (Rjamon.Checked)
            {
                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                for (int i = 0; i < Dgprincipal.Rows.Count - 1; i++)
                {
                    if (Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001022" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001033" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1004024" || Dgprincipal.Rows[i].Cells[0].Value.ToString() == "1001007")
                    {
                        magro = magro + Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
                        resto = resto - Math.Round(Convert.ToDouble(Dgprincipal.Rows[i].Cells[5].Value.ToString()), 2);
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(93, 173, 226);
                    }

                }
                chart1.Series[0].Points.AddXY("MAGRO", magro);
                chart1.Series[0].Points.AddXY(" ", resto);
            }

            double merma = (Kentrada - Ksalida);
            merma = merma / Ksalida * 100;
            txtDiferencia.Text = merma.ToString("N2");
        }

        private void mimprimir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Esta opción No esta Disponible.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void print_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count < 2)
            {
                return;
            }
            Cursor.Current  = Cursors.WaitCursor;
            ExportarDesp exp = new ExportarDesp();
            exp.ExportarDataGridViewExcel(DgIngreso, Dgprincipal, Convert.ToString(dtRDesde.Value.ToString("dd/MM/yyyy")), Convert.ToString(dtRHasta.Value.ToString("dd/MM/yyyy")), Convert.ToString(Kentrada.ToString("N2")), Convert.ToString(magro.ToString("N2")), lblProducto.Text, txtDiferencia.Text);
            this.Refresh();
            System.Threading.Thread.Sleep(100);
        }

        private void Dgprincipal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fecha_Desde= Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd")); ;
            int Fecha_Hasta= Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"));
            string CODIGO = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
            if (Dgprincipal.CurrentRow.Cells[0].Value.ToString() != "" && Dgprincipal.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    FrmIngresoCarnicosTrazabilidad _FrmIngresoCarnicosTrazabilidad1 = new FrmIngresoCarnicosTrazabilidad();
                    _FrmIngresoCarnicosTrazabilidad1.StartPosition = FormStartPosition.CenterScreen;
                    _FrmIngresoCarnicosTrazabilidad1.FechaD = Fecha_Desde;
                    _FrmIngresoCarnicosTrazabilidad1.fechaH = Fecha_Hasta;
                    _FrmIngresoCarnicosTrazabilidad1.CodigoM = CODIGO;
                    _FrmIngresoCarnicosTrazabilidad1.VIENEDE = "DESPOSTADA";
                    //_FrmIngresoCarnicosTrazabilidad1.LOTE = lote;
                    _FrmIngresoCarnicosTrazabilidad1.Nroingreso = NCproceso;
                    _FrmIngresoCarnicosTrazabilidad1.Producto = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                    _FrmIngresoCarnicosTrazabilidad1.Kg = Convert.ToString(Dgprincipal.CurrentRow.Cells[2].Value.ToString());
                    _FrmIngresoCarnicosTrazabilidad1.ShowDialog();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (Dgprincipal.CurrentRow.Cells[0].Value.ToString() != "" && Dgprincipal.CurrentCell.ColumnIndex == 0)
            {

                //NC_proceso = NCproceso;

                //Nro_ot = 0;
                //NC_merc = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                //lote = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                try
                {
                    FrmCarnicosCuentaCorriente _FrmCarnicosCuentaCorriente = new FrmCarnicosCuentaCorriente();
                    _FrmCarnicosCuentaCorriente.StartPosition = FormStartPosition.CenterScreen;
                    _FrmCarnicosCuentaCorriente.CodigoProducto = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                    _FrmCarnicosCuentaCorriente.NombreProducto = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                    _FrmCarnicosCuentaCorriente.Periodo = dtRHasta.Value;
                    _FrmCarnicosCuentaCorriente.ShowDialog();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
