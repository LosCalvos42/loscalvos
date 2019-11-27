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
using static System.Windows.Forms.LinkLabel;

namespace TRAZAAR
{
    public partial class FrmIngresoCarnicos : Form
    {
     
        public FrmIngresoCarnicos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCargaDeMuestras_Load(object sender, EventArgs e)
        {
            int var_mesActual = DateTime.Now.Month; // obtengo el mes actual
            int var_mesanterior = DateTime.Now.Month-1;
            int var_anio = DateTime.Now.Year; // obtengo el año actual
            int var_mesSiguiente = DateTime.Now.Month + 1; // obtengo el mes siguiente
            dtRDesde.Value = Convert.ToDateTime("01/" + var_mesActual + "/" + var_anio);// pongo el 1 porque siempre es el primer día obvio


            dtRHasta.Value = DateTime.Now.AddDays(-1);
            if (DateTime.Now.Day == 1)
            {
                dtRDesde.Value = Convert.ToDateTime("01/" + var_mesanterior + "/" + var_anio);
            }

           
        }
        private void CargarCombos(string Filtro,string Combo, int idprov )
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Fecha_desde", Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"))));
                lst.Add(new ClsParametros("@Fecha_hasta", Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"))));
                lst.Add(new ClsParametros("@Grupo", Filtro));
                lst.Add(new ClsParametros("@Combo", Combo));
                lst.Add(new ClsParametros("@IDProv", idprov));
                dt = M.Listado("SP_Catriel_IngresoCombos", lst);
                if (Combo == "PROVEEDOR")
                {
                    CmbProveedor.DataSource = dt;
                    CmbProveedor.DisplayMember = "DESCRIPCION";
                    CmbProveedor.ValueMember = "CODIGO";
                    
                }
                else { 
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
        private void EstadosGrilla()
        {
            Dgprincipal.Columns[0].Visible = false;
            Dgprincipal.Columns[7].Visible = false;
            Dgprincipal.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format = "N0";
            //Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format= "LinK";

            using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
            {

                Dgprincipal.Columns[2].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
                Dgprincipal.Columns[3].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
                Dgprincipal.Columns[4].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;
                Dgprincipal.Columns[8].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[8].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);
                Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.ForeColor = Color.Blue;
            }
             if (CmbProducto.SelectedValue.ToString() != "0")
             {
                int total=0;
                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {

                    total =total + Convert.ToInt32(Dgprincipal.Rows[i].Cells[10].Value);
                    
                }
                LblTotal.Text = "TOTAL: " + total.ToString("N0");
                LblTotal.Visible = true;
            }
        }

        private void EstadosGrilla2()
        {
            DGProdOc.Columns[DGProdOc.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DGProdOc.Columns[DGProdOc.Columns.Count - 1].DefaultCellStyle.Format = "N0";
            //Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format= "LinK";
        }

        private void Dgprincipal_Sorted(object sender, EventArgs e)
        {
            EstadosGrilla();
        }

        private void btnBuscarF_Click(object sender, EventArgs e)
        {
            LblTotal.Visible = false;
            try
            {
                Cursor.Current = Cursors.AppStarting;
                Dgprincipal.DataSource = null;
                DGProdOc.DataSource = null;
                Dgprincipal.Rows.Clear();
                Dgprincipal.Refresh();

                
                if (dtRHasta.Value < dtRDesde.Value)
                {
                    MessageBox.Show("Fecha Desde No Debe ser Mayor que Fecha Hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtRHasta.Focus();
                    return;

                }
                if (CmbGrupo.Text=="")
                {
                    MessageBox.Show("Debe Seleccionar GRUPO de Productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CmbGrupo.Focus();
                    return;

                }
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>
                {
                    new ClsParametros("@Fecha_Desde", Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"))),
                    new ClsParametros("@Fecha_Hasta", Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"))),
                    new ClsParametros("@Grupo", CmbGrupo.SelectedItem.ToString()),
                    new ClsParametros("@IDProv", CmbProveedor.SelectedValue),
                    new ClsParametros("@IDprod", CmbProducto.SelectedValue)
                };
                dt = M.Listado("SP_Catriel_IngresosPlanta", lst);

                if (dt.Rows.Count > 0)
                {               
                    Dgprincipal.DataSource = dt;
                    EstadosGrilla();
                    Cursor.Current = Cursors.Default;
                    if (Convert.ToInt32(CmbProducto.SelectedValue) != 0)
                    { 
                        ClsManejador M1 = new ClsManejador();
                        DataTable dt1 = new DataTable();
                        List<ClsParametros> lst1 = new List<ClsParametros>
                        {
                            new ClsParametros("@Fecha_Desde", Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"))),
                            new ClsParametros("@Fecha_Hasta", Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"))),
                            new ClsParametros("@Grupo", CmbGrupo.SelectedItem.ToString()),
                            new ClsParametros("@IDProv", CmbProveedor.SelectedValue),
                            new ClsParametros("@IDprod", CmbProducto.SelectedValue)
                        };
                        dt1 = M1.Listado("SP_Catriel_IngresosPlantaOC", lst1);

                        if (dt1.Rows.Count > 0)
                        {
                            DGProdOc.DataSource = dt1;
                            EstadosGrilla2();
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La Consulta NO Tiene Ningún Registro.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mimprimir_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.RowCount < 1)
            {
                MessageBox.Show("No Hay Datos Para Exportar o Imprimir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            Cursor.Current = Cursors.WaitCursor;
            Exportar exp = new Exportar();
            exp.ExportarDataGridViewExcelIng(Dgprincipal, CmbGrupo.Text, CmbProveedor.Text,CmbProducto.Text, Convert.ToString(dtRDesde.Value.ToString("dd/MM/yyyy")), Convert.ToString(dtRHasta.Value.ToString("dd/MM/yyyy")));
            this.Refresh();
            System.Threading.Thread.Sleep(100);
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
        private void CmbGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            CmbProveedor.DataSource = null;
            CmbProducto.DataSource = null;
            CargarCombos(CmbGrupo.SelectedItem.ToString(),"PROVEEDOR",0);
            CargarCombos(CmbGrupo.SelectedItem.ToString(),"PRODUCTO",Convert.ToInt32(CmbProveedor.SelectedValue.ToString()));
        }


        private void CmbProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCombos(CmbGrupo.SelectedItem.ToString(), "PRODUCTO", Convert.ToInt32(CmbProveedor.SelectedValue.ToString()));
        }

        private void Dgprincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((e.ColumnIndex == Dgprincipal.Columns[2].Index) && e.Value != null)
            {
                DataGridViewCell cell =
                 this.Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (DGProdOc.Rows.Count > 0)
                { 
                    for (int i = 0; i < DGProdOc.Rows.Count; i++)
                    {
                        if (DGProdOc.Rows[i].Cells[0].Value.ToString() == cell.Value.ToString())
                        {
                            int KG = Convert.ToInt32(DGProdOc.Rows[i].Cells[1].Value);
                            cell.ToolTipText = "    TOTAL Ingresado a OC: "+KG.ToString("N0") + Environment.NewLine+ "Click Para ver Orden de Compra";
                           
                        }
                    
                    }
                }
                else
                {
                    cell.ToolTipText = "Click Para ver Orden De Compra";
                }
                //cell.ToolTipText = "Click Para ver Orden de Compra";
            }
            if ((e.ColumnIndex == Dgprincipal.Columns[3].Index) && e.Value != null)
            {
                DataGridViewCell cell =
                 this.Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Click Para Ver Ctrl De Calidad";
            }
            if ((e.ColumnIndex == Dgprincipal.Columns[4].Index) && e.Value != null)
            {
                DataGridViewCell cell =
                 this.Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Click Para ver El Remito";
            }
            if ((e.ColumnIndex == Dgprincipal.Columns[8].Index) && e.Value != null)
            {
                DataGridViewCell cell =
                 this.Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Click Para ver Cta. Corriente";
            }

            if ((e.ColumnIndex == Dgprincipal.Columns[10].Index) && e.Value != null)
            {
                DataGridViewCell cell =
                 this.Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText ="Click Para ver Movimientos";
            }
        }
        private Cursor curAnterior = null;

        private void Dgprincipal_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgprincipal.Columns[2].Index|| e.ColumnIndex == Dgprincipal.Columns[3].Index || e.ColumnIndex == Dgprincipal.Columns[4].Index || e.ColumnIndex == Dgprincipal.Columns[10].Index || e.ColumnIndex == Dgprincipal.Columns[8].Index)
            {
                this.Dgprincipal.Cursor = Cursors.Hand;
            }
            else
            {
                this.Dgprincipal.Cursor = curAnterior;
            }
        }


        private void Dgprincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int fed;
            int feh;
            fed = Convert.ToInt32(dtRDesde.Value.ToString("yyyyMMdd"));
            feh = Convert.ToInt32(dtRHasta.Value.ToString("yyyyMMdd"));

            if (Dgprincipal.CurrentCell.Value.ToString() == "0")
            {
                return;
            }
            switch (Dgprincipal.CurrentCell.ColumnIndex)
            {
                case 2:
                    if (Dgprincipal.CurrentRow.Cells[2].Value.ToString() != " N° 0")
                    {
                        FrmReporteOrdenDeCompra _FrmReporteOrdenDeCompra = new FrmReporteOrdenDeCompra
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            Nroingreso = Convert.ToInt64(Dgprincipal.CurrentRow.Cells[0].Value.ToString())
                        };
                        _FrmReporteOrdenDeCompra.ShowDialog();
                    }
                    break;
                case 3:


                    if (Dgprincipal.CurrentRow.Cells[3].Value.ToString() == "VER")
                    {
                        FrmIngresoCarnicosCalidad _FrmIngresoCarnicosCalidad = new FrmIngresoCarnicosCalidad
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            FECHA = Dgprincipal.CurrentRow.Cells[1].Value.ToString(),
                            Proveedor = Dgprincipal.CurrentRow.Cells[5].Value.ToString(),
                            Remito = Dgprincipal.CurrentRow.Cells[4].Value.ToString(),
                            Nroingreso = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString()),
                            Producto = Dgprincipal.CurrentRow.Cells[8].Value.ToString() + "-" + Dgprincipal.CurrentRow.Cells[9].Value.ToString(),
                            Oc = Dgprincipal.CurrentRow.Cells[2].Value.ToString()
                        };
                        _FrmIngresoCarnicosCalidad.ShowDialog();

                    }
                    else if (Program.perfil == 3)
                    {
                        FrmIngresoCarnicosCalidad _FrmIngresoCarnicosCalidad = new FrmIngresoCarnicosCalidad
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            FECHA = Dgprincipal.CurrentRow.Cells[1].Value.ToString(),
                            Proveedor = Dgprincipal.CurrentRow.Cells[5].Value.ToString(),
                            Remito = Dgprincipal.CurrentRow.Cells[4].Value.ToString(),
                            Nroingreso = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString()),
                            Producto = Dgprincipal.CurrentRow.Cells[8].Value.ToString() + "-" + Dgprincipal.CurrentRow.Cells[9].Value.ToString(),
                            Oc = Dgprincipal.CurrentRow.Cells[2].Value.ToString()
                        };
                        _FrmIngresoCarnicosCalidad.ShowDialog();
                    }

                    break;
                case 4:
                    if (Dgprincipal.CurrentRow.Cells[4].Value.ToString() != "")
                    {
                        FrmReporteRemito _FrmReporteRemito = new FrmReporteRemito
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            NroRemito = (Dgprincipal.CurrentRow.Cells[4].Value.ToString())
                        };
                        _FrmReporteRemito.ShowDialog();
                    }
                    break;
                case 8:
                    if (Dgprincipal.CurrentRow.Cells[8].Value.ToString() != "")
                    {

                        try
                        {
                            FrmCarnicosCuentaCorriente _FrmCarnicosCuentaCorriente = new FrmCarnicosCuentaCorriente
                            {
                                StartPosition = FormStartPosition.CenterScreen,
                                CodigoProducto = Dgprincipal.CurrentRow.Cells[8].Value.ToString(),
                                NombreProducto = Dgprincipal.CurrentRow.Cells[9].Value.ToString(),
                                Periodo = Convert.ToDateTime(Dgprincipal.CurrentRow.Cells[1].Value.ToString())
                            };
                            _FrmCarnicosCuentaCorriente.ShowDialog();

                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    break;
                case 10:
                    if (Dgprincipal.CurrentRow.Cells[10].Value.ToString() != "")
                    {
                        FrmIngresoCarnicosTrazabilidad _FrmIngresoCarnicosTrazabilidad1 = new FrmIngresoCarnicosTrazabilidad
                        {
                            StartPosition = FormStartPosition.CenterScreen,
                            Nroingreso = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString()),
                            Proveedor = Dgprincipal.CurrentRow.Cells[5].Value.ToString(),
                            Remito = Dgprincipal.CurrentRow.Cells[4].Value.ToString(),
                            Producto = Dgprincipal.CurrentRow.Cells[9].Value.ToString(),
                            Nc_mercaderia = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[7].Value.ToString()),
                            CodigoM = Dgprincipal.CurrentRow.Cells[8].Value.ToString(),
                            Kg = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[10].Value.ToString()).ToString("N0")
                        };
                        _FrmIngresoCarnicosTrazabilidad1.ShowDialog();
                    }
                    break;
            }
        }

        private void MenuCopyPaste_Click(object sender, EventArgs e)
        {
            CopyClipboard();
        }
        private void CopyClipboard()
        {
            DataObject d = Dgprincipal.GetClipboardContent();
            Clipboard.SetDataObject(d);
        }

        private void dtRHasta_ValueChanged(object sender, EventArgs e)
        {
            CmbGrupo.SelectedIndex = -1;
            CmbProveedor.DataSource = null;
            CmbProducto.DataSource = null;
        }

        private void dtRDesde_ValueChanged(object sender, EventArgs e)
        {
            CmbGrupo.SelectedIndex = -1;
            CmbProveedor.DataSource = null;
            CmbProducto.DataSource = null;
        }
    }
}
