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

namespace TRAZAAR
{
    public partial class FrmReporteBalanceMateriaPrima : Form
    {
        int diferencia;
        int diferencia2;
        int ingresoEgreso;
        int StckF;
        public FrmReporteBalanceMateriaPrima()
        {
            InitializeComponent();
        }

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

            int var_mesActual = DateTime.Now.Month; // obtengo el mes actual
            int var_mesanterior = DateTime.Now.Month - 1;
            int var_anio = DateTime.Now.Year; // obtengo el año actual
            int var_mesSiguiente = DateTime.Now.Month + 1; // obtengo el mes siguiente
            dtRDesde.Value = Convert.ToDateTime("01/" + var_mesActual + "/" + var_anio);// pongo el 1 porque siempre es el primer día obvio


            dtRHasta.Value = DateTime.Now.AddDays(-1);
            if (DateTime.Now.Day == 1)
            {
                dtRDesde.Value = Convert.ToDateTime("01/" + var_mesanterior + "/" + var_anio);
            }
            permisos();
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
            Cursor.Current = Cursors.WaitCursor;
            int fed;
            int feh;
            int tipo = 0;
            string Titulo = "";
            string Titulo2 = "";
            fed = Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"));
            feh = Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"));

            if (Dgprincipal.CurrentCell.Value.ToString() == "0")
            {
                //GridView1.Rows[index].Cells[index].Text;
                //Dgprincipal.CurrentCell.ToString();
                return;
            }
            string grupo;
            string tgrupo;
            if (Dgprincipal.CurrentRow.Cells[0].Value.ToString() == "---------TOLAL:")
            {
                grupo = "";
                tgrupo = "TODOS";
            }
            else
            {
                grupo = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                tgrupo = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
            }

            
            switch (Dgprincipal.CurrentCell.ColumnIndex)
            {
                case 1:
                    tipo = 1;
                    Titulo = "Stock al " + dtRDesde.Value.ToString("dd/MM/yyyy") + " Grupo: " + tgrupo;
                    Titulo2 = "Cuenta Corriente Periodo " + dtRDesde.Value.ToString("dd/MM/yyyy")+"/"+ dtRHasta.Value.ToString("dd/MM/yyyy");
                    break;
                case 2:
                    tipo = 2;
                    Titulo = "Ingresos " + dtRDesde.Value.ToString("dd/MM/yyyy") + " al " + dtRHasta.Value.ToString("dd/MM/yyyy") + " Grupo: " + tgrupo;
                    break;
                case 3:
                    tipo = 3;
                    Titulo = "Egresos " + dtRDesde.Value.ToString("dd/MM/yyyy") + " al " + dtRHasta.Value.ToString("dd/MM/yyyy") + " Grupo: " + tgrupo;
                    break;
                case 4:
                    tipo = 4;
                    Titulo = "Stock al " + dtRHasta.Value.ToString("dd/MM/yyyy") + " Grupo: " + grupo;
                    Titulo2 = "Cuenta Corriente Periodo " + dtRDesde.Value.ToString("dd/MM/yyyy") + "-" + dtRHasta.Value.ToString("dd/MM/yyyy");
                    break;
            }

            if (tipo == 2 || tipo == 3)
            {
                if (RMovimiento.Checked == true)
                {
                    FrmReporteBalanceMateriaPrimaDetalle _FrmReporteBalanceMateriaPrimaDetalle1 = new FrmReporteBalanceMateriaPrimaDetalle();
                    _FrmReporteBalanceMateriaPrimaDetalle1.StartPosition = FormStartPosition.CenterScreen;
                    _FrmReporteBalanceMateriaPrimaDetalle1.Titulo = Titulo;
                    _FrmReporteBalanceMateriaPrimaDetalle1.Fdesde = fed;
                    _FrmReporteBalanceMateriaPrimaDetalle1.Fhasta = feh;
                    _FrmReporteBalanceMateriaPrimaDetalle1.Tipo = tipo;
                    _FrmReporteBalanceMateriaPrimaDetalle1.Grupo = grupo;
                    _FrmReporteBalanceMateriaPrimaDetalle1.Codigo = "";
                    _FrmReporteBalanceMateriaPrimaDetalle1.ShowDialog();
                }
                if(RProducto.Checked==true)
                {
                    FrmReporteBalanceMateriaPrimaStock _FrmReporteBalanceMateriaPrimaStock = new FrmReporteBalanceMateriaPrimaStock();
                    _FrmReporteBalanceMateriaPrimaStock.StartPosition = FormStartPosition.CenterScreen;
                    _FrmReporteBalanceMateriaPrimaStock.Titulo = Titulo;
                    _FrmReporteBalanceMateriaPrimaStock.Fdesde = fed;
                    _FrmReporteBalanceMateriaPrimaStock.Fhasta = feh;
                    _FrmReporteBalanceMateriaPrimaStock.Tipo = tipo;
                    _FrmReporteBalanceMateriaPrimaStock.Grupo = grupo;
                    _FrmReporteBalanceMateriaPrimaStock.Codigo = "";
                    _FrmReporteBalanceMateriaPrimaStock.ShowDialog();
                }
            }
            if (tipo == 1 || tipo == 4)
            {
                FrmReporteBalanceMateriaPrimaStock _FrmReporteBalanceMateriaPrimaStock = new FrmReporteBalanceMateriaPrimaStock();
                _FrmReporteBalanceMateriaPrimaStock.StartPosition = FormStartPosition.CenterScreen;

                _FrmReporteBalanceMateriaPrimaStock.Titulo = Titulo;
                _FrmReporteBalanceMateriaPrimaStock.Fdesde = fed;
                _FrmReporteBalanceMateriaPrimaStock.Fhasta = feh;
                _FrmReporteBalanceMateriaPrimaStock.Tipo = tipo;
                _FrmReporteBalanceMateriaPrimaStock.Grupo = grupo;
                _FrmReporteBalanceMateriaPrimaStock.Codigo = "";
                _FrmReporteBalanceMateriaPrimaStock.TituloCC = Titulo2;
                _FrmReporteBalanceMateriaPrimaStock.ShowDialog();
            }

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
                diferencia = 0;
                ingresoEgreso = 0;
                StckF = 0;
                if (dtRHasta.Value >= DateTime.Today)
                {
                    MessageBox.Show("Fecha Hasta, No debe ser la Fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;

                }
                if (dtRHasta.Value < dtRDesde.Value)
                {
                    MessageBox.Show("Fecha Desde No Debe ser Mayor que Fecha Hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;

                }

                Cursor.Current = Cursors.WaitCursor;
                txtIngresosEgresos.Text = "";
                txtStockF.Text = "";
                txtDiferencia.Text = "";
                txtDife.Text = "";
                int fed;
                int feh;
                fed = Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"));
                feh = Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"));
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                dt = M.lisquery("balanceGeneralMPC " + fed + "," + feh);

                //Dgprincipal.DataSource = dt;
                //EstadosGrilla();
                Dgprincipal.ClearSelection();

                Dgprincipal.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Dgprincipal.Rows.Add(dt.Rows[i][0]);
                    //Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][1].ToString();
                    Dgprincipal.Rows[i].Cells[1].Value = Convert.ToDecimal(dt.Rows[i][2].ToString());
                    Dgprincipal.Rows[i].Cells[2].Value = Convert.ToDecimal(dt.Rows[i][3].ToString());
                    Dgprincipal.Rows[i].Cells[3].Value = Convert.ToDecimal(dt.Rows[i][4].ToString());
                    Dgprincipal.Rows[i].Cells[4].Value = Convert.ToDecimal(dt.Rows[i][5].ToString());
                    //Dgprincipal.Rows[i].Cells[6].Value = Convert.ToDecimal(dt.Rows[i][6].ToString());
                }
                using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                {
                    Dgprincipal.Rows[Dgprincipal.RowCount - 1].DefaultCellStyle.Font = font;
                }
                
                //id = Convert.ToInt32(dt.Rows[0][0].ToString());

                ingresoEgreso = Convert.ToInt32(Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[1].Value) + Convert.ToInt32(Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[2].Value) - Convert.ToInt32(Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[3].Value);
                txtIngresosEgresos.Text = Convert.ToString(ingresoEgreso.ToString("N0"));
                //Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[6].Value = totaldeb;
                StckF = Convert.ToInt32(Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[4].Value);
                txtStockF.Text = Convert.ToString(StckF.ToString("N0"));

                diferencia = StckF - ingresoEgreso;
                decimal porcentaje = ((diferencia * 100) / Convert.ToDecimal(StckF));

                txtDife.Text = Convert.ToString(diferencia.ToString("N0"));
                txtDiferencia.Text = Convert.ToString(porcentaje.ToString("N1")) + "%";
                Graficar();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void mimprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción No esta Disponible.", "TRAZAAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void print_Click(object sender, EventArgs e)
        {
            //if (Dgprincipal.Rows.Count < 2)
            //{
            //    return;
            //}

            //Cursor.Current = Cursors.WaitCursor;
            //Exportar exp = new Exportar();
            //exp.ExportarDataGridViewExcel(Dgprincipal, Convert.ToString(dtRDesde.Value.ToString("dd/MM/yyyy")), Convert.ToString(dtRHasta.Value.ToString("dd/MM/yyyy")), Convert.ToString(ingresoEgreso.ToString("N2")), Convert.ToString(StckF.ToString("N2")), Convert.ToString(diferencia.ToString("N2")), txtDiferencia.Text,txtKgDeshuese.Text, Convert.ToString(diferencia2.ToString("N2")), txtDiferencia2.Text);
            //this.Refresh();
            //System.Threading.Thread.Sleep(100);


        }

        private void txtKgDeshuese_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sivalido = 0;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)46) && (e.KeyChar != (char)13))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Graficar()
        {
            chart1.Series[0].Points.Clear();
            decimal resto = 100;
            //diferencia = 0;

            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
           
                    //diferencia = diferencia+ Math.Round(, 2);
                    //resto = resto - diferencia;
            Dgprincipal.Rows[3].DefaultCellStyle.BackColor = Color.FromArgb(165, 214, 167);
            decimal porcentaje = ((diferencia * 100) / Convert.ToDecimal(StckF));
            resto = resto - Math.Round(Math.Abs(porcentaje), 1);
            chart1.Series[0].Points.AddXY("% Stock Final", resto);
            chart1.Series[0].Points.AddXY("% Diferencia", Math.Round(Math.Abs(porcentaje), 1));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count < 2)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcel(Dgprincipal, Convert.ToString(dtRDesde.Value.ToString("dd/MM/yyyy")), Convert.ToString(dtRHasta.Value.ToString("dd/MM/yyyy")), Convert.ToString(ingresoEgreso.ToString("N2")), Convert.ToString(StckF.ToString("N2")), Convert.ToString(diferencia.ToString("N2")), txtDiferencia.Text,"25", Convert.ToString(diferencia2.ToString("N2")), "23");
           // ExportarDataGridViewExcel(DataGridView dgView, string Fechad, string Fechah, string IngEgr, string Stf, string dif, string porcent, string desh, string dif2, string porcent2)

            this.Refresh();
            System.Threading.Thread.Sleep(100);
        }
    }
}
