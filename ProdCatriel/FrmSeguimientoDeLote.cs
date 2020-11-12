using Datos;
using System;
using System.Collections;
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
    public partial class FrmSeguimientoDeLote : Form
    {
        public FrmSeguimientoDeLote()
        {
            InitializeComponent();
        }

        decimal MERMA = 0;

        private void CargarDatosOrigen()
        {
            try
            {
                DgOrigen.DataSource = null;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@Lote", CmbLote.SelectedValue));
                lst.Add(new ClsParametros("@tipo", 1));

                dt = M.Listado("SP_GetSeguimientoDeLote", lst);
                if (dt.Rows.Count > 0)
                {
                    DgOrigen.DataSource = dt;
                }

                //DgOrigen.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                //DgOrigen.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                //DgOrigen.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                //DgOrigen.Rows[1].DefaultCellStyle.ForeColor = Color.White;
                
                //DataGridViewCellStyle styEstilo;
                //styEstilo = new DataGridViewCellStyle();
                //styEstilo.BackColor = Color.FromArgb(92, 107, 192);
                //styEstilo.ForeColor = Color.White;
                //styEstilo.Font = new Font("Bradley Hand ITC", 9, FontStyle.Bold);
                //styEstilo.Alignment = DataGridViewContentAlignment.BottomRight;
                // asignar estilo a las cabeceras del control
                //this.dgvGrid.ColumnHeadersDefaultCellStyle = styEstilo;..
                //DgOrigen.Rows[0].DefaultCellStyle= styEstilo;
                //DgOrigen.Rows[1].DefaultCellStyle = styEstilo;
                //using (Font font = new Font(
                //   DgOrigen.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                //{
                //    DgOrigen.Rows[0].DefaultCellStyle.Font = font;
                //    DgOrigen.Rows[1].DefaultCellStyle.Font = font;
                //}

                DgOrigen.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosMov()
        {
            try
            {
                DgMovimientos.DataSource = null;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@Lote", CmbLote.SelectedValue));
                lst.Add(new ClsParametros("@tipo", 2));

                dt = M.Listado("SP_GetSeguimientoDeLote", lst);
                if (dt.Rows.Count > 0)
                {
                    DgMovimientos.DataSource = dt;
                    DgMovimientos.Columns[3].DefaultCellStyle.Format = "N0";
                    DgMovimientos.Columns[4].DefaultCellStyle.Format = "N2";
                   
                }

             
                DgMovimientos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EstadosGrilla()
        {
            if(DgActual.Rows.Count<1)
            {
                return;
            }

            using (Font font = new Font(
                    DgActual.DefaultCellStyle.Font.FontFamily, 7, FontStyle.Underline))
            {

                DgActual.Columns[6].DefaultCellStyle.Font = font;
                DgActual.Columns[6].DefaultCellStyle.ForeColor = Color.FromArgb(118, 215, 196);
                DgMovimientos.Columns[7].DefaultCellStyle.Font = font;
                DgMovimientos.Columns[7].DefaultCellStyle.ForeColor = Color.FromArgb(118, 215, 196);
            }

            using (Font font = new Font(
                    DgActual.DefaultCellStyle.Font.FontFamily, 7, FontStyle.Regular))
            {
                DgActual.Rows[DgActual.RowCount - 1].Cells[0].Value = "";
                DgActual.Rows[DgActual.Rows.Count - 1].DefaultCellStyle.Font = Font;
                DgActual.Rows[DgActual.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.FromArgb(241, 196, 15);
            }
            DgActual.Columns[0].Visible = false;
            DgActual.Columns[1].Visible = false;
            DgMovimientos.Columns[0].Visible = false;
            DgMovimientos.Columns[1].Visible = false;


        }
        private void CargarDatosActual()
        {
            try
            {
                DgActual.DataSource = null; ;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@lote", CmbLote.SelectedValue));
                lst.Add(new ClsParametros("@tipo", 3));

                dt = M.Listado("SP_GetSeguimientoDeLote", lst);
                if (dt.Rows.Count > 1)
                {

                    MERMA = 0;
                    DgActual.DataSource = dt;
                    DgActual.Columns[4].DefaultCellStyle.Format = "N0";
                    DgActual.Columns[5].DefaultCellStyle.Format = "N2";
                    
                }
                DgActual.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosGlobal()
        {
            try
            {
                DgGlobal.DataSource = null; ;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@lote", CmbLote.SelectedValue));
                lst.Add(new ClsParametros("@tipo", 5));

                dt = M.Listado("SP_GetSeguimientoDeLote", lst);
                if (dt.Rows.Count > 1)
                {
                   DgGlobal.DataSource = dt;
                   DgGlobal.Columns[1].DefaultCellStyle.Format = "N0";
                   DgGlobal.Columns[2].DefaultCellStyle.Format = "N2";
                }
                DgGlobal.ClearSelection();

                DgGlobal.Columns[1].DefaultCellStyle.Format = "N0";
                DgGlobal.Columns[2].DefaultCellStyle.Format = "N2";
                DgGlobal.Rows[DgGlobal.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.FromArgb(241, 196, 15);

                chart1.Series[0].Points.Clear();


                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

                decimal merma = (Convert.ToDecimal(dt.Rows[2][2]) - Convert.ToDecimal(dt.Rows[3][2]));

                decimal mermaP = 0;
                decimal rendimiento = 0;

                mermaP = merma * 100 / Convert.ToDecimal(dt.Rows[2][2]);
                rendimiento = 100 - mermaP;

                //txtDiferencia.Text = Convert.ToString(Math.Round(merma, 2));



                chart1.Series[0].Points.AddXY("Rendimiento", Math.Round(rendimiento, 2));
                chart1.Series[0].Points.AddXY("Merma", Math.Round(mermaP, 2));



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Graficar()
        {
            ArrayList Proceso = new ArrayList();
            ArrayList Merma = new ArrayList();
            
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@lote", CmbLote.SelectedValue));
            lst.Add(new ClsParametros("@tipo",4));

            dt = M.Listado("SP_GetSeguimientoDeLote", lst);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Proceso.Add(dt.Rows[i][0]);
                    Merma.Add(dt.Rows[i][3]);
                }
            }

            chart2.Series[0].Points.DataBindXY(Proceso, Merma);
        }

        private void Cargarcombo(string combo, ComboBox _combo,string Filtro)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", Filtro));
                dt = M.Listado("sp_CargaCombos", lst);
                _combo.DataSource = dt;
                _combo.DisplayMember = "NOMBRE";
                _combo.ValueMember = "CODIGO";
                DataRow topItem = dt.NewRow();
                topItem[1] = 1;
                topItem[2] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmSeguimientoDeLote_Load(object sender, EventArgs e)
        {
            Cargarcombo("ARTISALAZON",CmbProducto,"");
        }

        private void CmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cargarcombo("LOTE", CmbLote, CmbProducto.SelectedValue.ToString());
        }

        private void CmbLote_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDatosActual();
            CargarDatosOrigen();
            CargarDatosMov();
            EstadosGrilla();
            CargarDatosGlobal();
            Graficar();
        }

        private void DgActual_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgActual.CurrentRow.Cells[6].Value.ToString() != "" && DgActual.CurrentCell.ColumnIndex == 6)
            {
                try
                {
                    FrmLoteItems _FrmLoteItems = new FrmLoteItems();
                    _FrmLoteItems.StartPosition = FormStartPosition.CenterScreen;
                    _FrmLoteItems.Titulo = "Detalle de Piezas estado actual";
                    _FrmLoteItems.Tipo = 1;
                    _FrmLoteItems.Lote = CmbLote.Text;
                    _FrmLoteItems.NroOt = Convert.ToInt32(DgActual.CurrentRow.Cells[0].Value);
                    _FrmLoteItems.CodProc = DgActual.CurrentRow.Cells[1].Value.ToString();
                    _FrmLoteItems.CatPeso = DgActual.CurrentRow.Cells[3].Value.ToString();
                    _FrmLoteItems.CatMerma= DgActual.CurrentRow.Cells[4].Value.ToString();
                    _FrmLoteItems.ShowDialog();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void DgMovimientos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgMovimientos.CurrentRow.Cells[7].Value.ToString() != "" && DgMovimientos.CurrentCell.ColumnIndex == 7)
            {
                try
                {
                    FrmLoteItems _FrmLoteItems = new FrmLoteItems();
                    _FrmLoteItems.StartPosition = FormStartPosition.CenterScreen;
                    _FrmLoteItems.Titulo = "Detalle de Piezas por Movimiento";
                    _FrmLoteItems.Tipo = 2;
                    _FrmLoteItems.Lote = CmbLote.Text;
                    _FrmLoteItems.NroOt = Convert.ToInt32(DgMovimientos.CurrentRow.Cells[0].Value);
                    _FrmLoteItems.CodProc = DgMovimientos.CurrentRow.Cells[1].Value.ToString();
                    _FrmLoteItems.CatPeso = DgMovimientos.CurrentRow.Cells[5].Value.ToString();
                    _FrmLoteItems.CatMerma = DgMovimientos.CurrentRow.Cells[6].Value.ToString();
                    _FrmLoteItems.ShowDialog();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
