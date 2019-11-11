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

namespace Alberdi
{
    public partial class FrmReporteBalanceMateriaPrimaDetalle : Form
    {
        public FrmReporteBalanceMateriaPrimaDetalle()
        {
            InitializeComponent();

        }
        
        public int Fdesde { get; set; }
        public int Fhasta { get; set; }
        public int Tipo { get; set; }
        public string Grupo { get; set; }
        public string Codigo { get; set; }


        public string Titulo { get; set; }
        decimal SumaTotal;

        private void LlenarGrid(string filtro)
        {
            LblTitulo.Text = Titulo;
            Dgprincipal.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Fecha_Desde", Fdesde));
                lst.Add(new ClsParametros("@Fecha_Hasta", Fhasta));
                lst.Add(new ClsParametros("@tipo", Tipo));
                lst.Add(new ClsParametros("@grupo", Grupo));
                lst.Add(new ClsParametros("@codigo",Codigo));
                lst.Add(new ClsParametros("@filtro", CmbMov.SelectedItem));
                dt = M.Listado("balanceGeneralMPC_DetalleMovimiento", lst);

                if (dt.Rows.Count>0) {
                    LblProcesando.Visible = false;
                    Dgprincipal.DataSource = dt;
                    //DgIngreso.AutoResizeColumns(Fill);
                    EstadosGrilla();
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    LblProcesando.Visible = true;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            LlenarGrid("");
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;
            
        }

        private void EstadosGrilla()
        {

            Dgprincipal.Columns[2].Visible = false;
            Dgprincipal.Columns[5].Visible = false;
            Dgprincipal.Columns[6].Visible = false;
            SumaTotal = 0;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format = "N0";


            for (int i = 0; i <= Dgprincipal.Rows.Count - 1; i++)
            {
                //Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count - 1].Value= Convert.ToString(Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count - 1].ToString()).ToString("N0");
                //Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                SumaTotal = SumaTotal+ Convert.ToDecimal(Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count-1].Value);
                //Convert.ToString(ingresoEgreso.ToString("N0"))
            }
            LblTotalKG.Text = "Total KG:   " + Convert.ToString(SumaTotal.ToString("N0"));

        }

        private void CmbMov_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            LlenarGrid("");
        }
    }
}
