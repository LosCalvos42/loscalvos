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
    public partial class FrmReporteBalanceMateriaPrimaStock : Form
    {
        public FrmReporteBalanceMateriaPrimaStock()
        {
            InitializeComponent();

        }
        
        public int Fdesde { get; set; }
        public int Fhasta { get; set; }
        public int Tipo { get; set; }
        public string Grupo { get; set; }
        public string Codigo { get; set; }

        public string Descripcion { get; set; }
        public string TituloCC { get; set; }

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
                lst.Add(new ClsParametros("@filtro", "")); //no se usa 
                dt = M.Listado("balanceGeneralMPC_DetalleProducto", lst);

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

        private void LlenarGridCC(string filtro)
        {
            //LblTitulo.Text = Titulo;
            DgCC.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Fecha_Desde", Fdesde));
                lst.Add(new ClsParametros("@Fecha_Hasta", Fhasta));
                lst.Add(new ClsParametros("@codigo", filtro));
                dt = M.Listado("balanceGeneralMPC_CuentaCorriente", lst);

                if (dt.Rows.Count > 0)
                {
                    //LblProcesando.Visible = false;
                    DgCC.DataSource = dt;
                    //DgIngreso.AutoResizeColumns(Fill);
                    CalcularSaldo();
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    //LblProcesando.Visible = true;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularSaldo()
        {
            for (int i = 0; i <= DgCC.Rows.Count - 1; i++)
            {

                if (DgCC.Rows[i].Cells[2].Value.ToString() == "00 STOCK INICIAL DEL PERIODO")
                {
                    //DgCC.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(130, 224, 170);

                }
                else
                {
                    DgCC.Rows[i].Cells[5].Value = Convert.ToInt32(DgCC.Rows[i - 1].Cells[5].Value.ToString()) + Convert.ToInt32(DgCC.Rows[i].Cells[3].Value.ToString()) - Convert.ToInt32(DgCC.Rows[i].Cells[4].Value.ToString());
                }


            }

            DgCC.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgCC.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgCC.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgCC.Columns[3].DefaultCellStyle.Format = "N0";
            DgCC.Columns[4].DefaultCellStyle.Format = "N0";
            DgCC.Columns[5].DefaultCellStyle.Format = "N0";
            DgCC.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(208, 253, 235);
            DgCC.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
            DgCC.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            LlenarGrid("");
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Dgprincipal.ClearSelection();
            Cursor.Current = Cursors.Default;
            Dgprincipal.ClearSelection();


        }

        private void EstadosGrilla()
        {

            Dgprincipal.Columns[0].Visible = false;
            //Dgprincipal.Columns[5].Visible = false;
            //Dgprincipal.Columns[6].Visible = false;
            SumaTotal = 0;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format = "N0";
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);

            for (int i = 0; i <= Dgprincipal.Rows.Count - 1; i++)
            {

                SumaTotal = SumaTotal + Convert.ToDecimal(Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count - 1].Value);
                if (Dgprincipal.Rows[i].Cells[0].Value.ToString() == "ENPROCESO")
                {
                    Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(213, 245, 227);
                    //Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count - 1].Value = "";
                }
                    
                    //Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count - 1].Value= Convert.ToString(Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count - 1].ToString()).ToString("N0");
                //Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //SumaTotal = SumaTotal+ Convert.ToDecimal(Dgprincipal.Rows[i].Cells[Dgprincipal.Columns.Count-1].Value);
                //Convert.ToString(ingresoEgreso.ToString("N0"))
            }
            LblTotalKG.Text = "Total KG:   " + Convert.ToString(SumaTotal.ToString("N0"));
            Dgprincipal.ClearSelection();
        }

        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            //LlenarGridCC(Dgprincipal.CurrentRow.Cells[1].Value.ToString());
        }

        private void Dgprincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Tipo==1 || Tipo == 4)
            {
                LblCC.Text = TituloCC;
                lblProducto.Text=Dgprincipal.CurrentRow.Cells[1].Value.ToString()+" "+ Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                LlenarGridCC(Dgprincipal.CurrentRow.Cells[1].Value.ToString());
                DgCC.ClearSelection();
                foreach (DataGridViewColumn Col in DgCC.Columns)
                {
                    Col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }
    }
}
