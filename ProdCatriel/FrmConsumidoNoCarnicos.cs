using Datos;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alberdi
{
    public partial class FrmConsumidoNoCarnicos : Form
    {
        public FrmConsumidoNoCarnicos()
        {
            InitializeComponent();
        }
        
        public DateTime Periodo { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Periodo1 { get; set; }
        public string Vienede { get; set; }



        private void DetalleCaja_Load(object sender, EventArgs e)
        {


            int var_mesActual = Periodo.Month; // obtengo el mes actual
            int var_mesanterior = Periodo.Month - 1;
            int var_anio = Periodo.Year; // obtengo el año actual
            int var_mesSiguiente = DateTime.Now.Month + 1; // obtengo el mes siguiente
            dtRDesde.Value = Convert.ToDateTime("01/" + var_mesActual + "/" + var_anio);// pongo el 1 porque siempre es el primer día obvio
            

            dtRHasta.Value = DateTime.Now.AddDays(-0);
            if (DateTime.Now.Day == 1)
            {
                dtRDesde.Value = Convert.ToDateTime("01/" + var_mesanterior + "/" + var_anio);
            }

            
            if (Vienede != "CONSULTA")
            {
                LlenarGrid(CodigoProducto);
            }
            
            //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;

        }

        private void LlenarGrid(string oc)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Fecha_Desde", Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"))));
                lst.Add(new ClsParametros("@Fecha_Hasta", Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"))));
                dt = M.Listado("SP_CatrielConsumidoxPeriodoNoCarnicos", lst);

                DgCC.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    DgCC.DataSource = dt; 
                }
                EstadoGrilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private Cursor curAnterior = null;

        
  

        private void BtnBuscarF_Click(object sender, EventArgs e)
        {
            if (dtRHasta.Value < dtRDesde.Value)
            {
                MessageBox.Show("Fecha Desde No Debe ser Mayor que Fecha Hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtRHasta.Focus();
                return;

            }

            LlenarGrid(CodigoProducto);
        }

        private void PBuscar_Click(object sender, EventArgs e)
        {

            DgCC.DataSource = null;
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar
            {
                StartPosition = FormStartPosition.CenterScreen,
                combo = "PRODUCTOMPC"
            };
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {
                int IdProd;
                CodigoProducto = _FrmGrillaBuscar.Codigo;
                NombreProducto= _FrmGrillaBuscar.nombre;
               
                IdProd = _FrmGrillaBuscar.id;

            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mimprimir_Click(object sender, EventArgs e)
        {
            if (DgCC.RowCount <1)
            {
                MessageBox.Show("No Hay Datos Para Exportar o Imprimir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;

            }

            Cursor.Current = Cursors.WaitCursor;
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcelCC(DgCC,CodigoProducto,NombreProducto, Convert.ToString(dtRDesde.Value.ToString("dd/MM/yyyy")), Convert.ToString(dtRHasta.Value.ToString("dd/MM/yyyy")));
            this.Refresh();
            System.Threading.Thread.Sleep(100);
        }


        private void EstadoGrilla()
        {
            DgCC.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgCC.Columns[2].DefaultCellStyle.Format = "N0";
            DgCC.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
        }
    }
}

