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

namespace TRAZAAR
{
    public partial class FrmIngresoCarnicosTrazabilidad : Form
    {
        public FrmIngresoCarnicosTrazabilidad()
        {
            InitializeComponent();
        }
        public int Nroingreso { get; set; }
        public string CodigoM { get; set; }
        public int Nc_mercaderia { get; set; }
        public string Proveedor { get; set; }
        public string Producto { get; set; }
        public string Remito { get; set; }
        public string Kg { get; set; }
        public string VIENEDE { get; set; }
        public string LOTE { get; set; }
        public int FechaD { get; set; }
        public int fechaH { get; set; }
        private void DetalleCaja_Load(object sender, EventArgs e)
        {

            if (VIENEDE == "PROCESO")
            {
                label3.Text = "";
                label4.Text = "Lote:";
                lblproducto.Text = CodigoM + " - " + Producto;
                lblProveedor.Text = Proveedor;
                LblNumeroRemito.Text = LOTE;
                lblkg.Text = Kg + " Kg.";
                LlenarGrid(Nroingreso, Nc_mercaderia);
                //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                Dgprincipal.ClearSelection();
                Cursor.Current = Cursors.Default;
                Dgprincipal.ClearSelection();
            }
            else 
            if (VIENEDE == "DESPOSTADA")
            {
                label3.Text = "";
                label4.Text = "Lote:";
                lblproducto.Text = CodigoM + " - " + Producto;
                lblProveedor.Text = Proveedor;
                LblNumeroRemito.Text = LOTE;
                lblkg.Text = Kg + " Kg.";
                LlenarGridDespostada(FechaD,fechaH, CodigoM);
                //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                Dgprincipal.ClearSelection();
                Cursor.Current = Cursors.Default;
                Dgprincipal.ClearSelection();
            }

            else
            {
                lblproducto.Text = CodigoM + " - " + Producto;
                lblProveedor.Text = Proveedor;
                LblNumeroRemito.Text = Remito;
                lblkg.Text = Kg + " Kg.";
                LlenarGrid(Nroingreso, Nc_mercaderia);
                //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                Dgprincipal.ClearSelection();
                Cursor.Current = Cursors.Default;
                Dgprincipal.ClearSelection();
            }
            
        }

        private void LlenarGrid(int NROINGRESO, int CODIGOP)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                decimal Disponible = 0;

                if (VIENEDE == "PROCESO")
                {
                   
                    lst.Add(new ClsParametros("@NcProceso", Nc_mercaderia));
                    lst.Add(new ClsParametros("@NcOt", NROINGRESO));
                    lst.Add(new ClsParametros("@Mcodigo", CodigoM));
                    dt = M.Listado("SP_Catriel_ProcesosCarnicosTrazabilidad", lst);

                }
                else
                {
                    
                    lst.Add(new ClsParametros("@NroIngreso", NROINGRESO));
                    lst.Add(new ClsParametros("@codigo", CODIGOP));
                    dt = M.Listado("SP_Catriel_IngresoCarnicosTrazabilidad", lst);
                }
               

                if (dt.Rows.Count > 0)
                {
                    decimal total = 0;
                   
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        Dgprincipal.Rows.Add(dt.Rows[i][0]);
                        Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        Dgprincipal.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        Dgprincipal.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        Dgprincipal.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        Dgprincipal.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        Dgprincipal.Rows[i].Cells[6].Value = Convert.ToDecimal(dt.Rows[i][6].ToString());
                        total = total + Convert.ToDecimal(dt.Rows[i][6].ToString());
                        if (Dgprincipal.Rows[i].Cells[3].Value.ToString() == "DISPONIBLE")
                        {
                            Disponible = Convert.ToDecimal(dt.Rows[i][6].ToString());
                        }

                    }
                    Dgprincipal.Rows.Add(1);
                    Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[0].Value = "";
                    Dgprincipal.Rows[Dgprincipal.Rows.Count-1].Cells[5].Value = "TOTAL:";
                    Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[6].Value = total;

                    using (Font font = new Font(
                   Dgprincipal.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                    {
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].DefaultCellStyle.Font = font;
                    }

                    if (Dgprincipal.Rows[0].Cells[3].Value.ToString() == "DISPONIBLE") { 
                        Dgprincipal.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                    }   
                using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
                    {

                        Dgprincipal.Columns[5].DefaultCellStyle.Font = font;
                        Dgprincipal.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
                       
                    }
                }
                else
                {
                    
                }

                LblDisponible.Text = Convert.ToString(Disponible.ToString("N0"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarGridDespostada(int Fdesde, int Fhasta,string Codigo)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                decimal Disponible = 0;

                

                    lst.Add(new ClsParametros("@Fecha_Desde", Fdesde));
                    lst.Add(new ClsParametros("@Fecha_Hasta", Fhasta));
                    lst.Add(new ClsParametros("@CODIGO", Codigo));
                    lst.Add(new ClsParametros("@TIPO", Nroingreso));
                dt = M.Listado("SP_Catriel_ProcesosCarnicosTrazabilidadDespostada", lst);


                if (dt.Rows.Count > 0)
                {
                    decimal total = 0;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        Dgprincipal.Rows.Add(dt.Rows[i][0]);
                        Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        Dgprincipal.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        Dgprincipal.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        Dgprincipal.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        Dgprincipal.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        Dgprincipal.Rows[i].Cells[6].Value = Convert.ToDecimal(dt.Rows[i][6].ToString());
                        total = total + Convert.ToDecimal(dt.Rows[i][6].ToString());
                        if (Dgprincipal.Rows[i].Cells[3].Value.ToString() == "DISPONIBLE")
                        {
                            Disponible = Convert.ToDecimal(dt.Rows[i][6].ToString());
                        }

                    }
                    Dgprincipal.Rows.Add(dt.Rows);
                    Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[0].Value = "";
                    Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[5].Value = "TOTAL:";
                    Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[6].Value = total;

                    using (Font font = new Font(
                   Dgprincipal.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                    {
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].DefaultCellStyle.Font = font;
                    }

                    if (Dgprincipal.Rows[0].Cells[3].Value.ToString() == "DISPONIBLE")
                    {
                        Dgprincipal.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(247, 220, 111);
                    }
                    using (Font font = new Font(
                        Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
                    {

                        Dgprincipal.Columns[5].DefaultCellStyle.Font = font;
                        Dgprincipal.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;

                    }
                }
                else
                {

                }

                LblDisponible.Text = Convert.ToString(Disponible.ToString("N0"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Cursor curAnterior = null;

        private void Dgprincipal_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                if (e.ColumnIndex == Dgprincipal.Columns[5].Index && e.RowIndex!= Dgprincipal.Rows[Dgprincipal.RowCount - 1].Index && Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    this.Dgprincipal.Cursor = Cursors.Hand;
                }
                else
                {
                    this.Dgprincipal.Cursor = curAnterior;
                }
            }
        }

        private void Dgprincipal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime Fecha;
            int NroProceso;
            string NroOt;
            string Lote;
            int TIPOPROCESO = 0;
            if (e.RowIndex == (-1))
            {
                return;
            }


                if (Dgprincipal.CurrentRow.Cells[0].Value.ToString() != "" && Dgprincipal.CurrentCell.ColumnIndex == 5)
                {
                
                NroProceso = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[2].Value.ToString());
                NroOt = Dgprincipal.CurrentRow.Cells[4].Value.ToString();
                Lote = Dgprincipal.CurrentRow.Cells[5].Value.ToString();
                Fecha= Convert.ToDateTime(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    string SQL;
                    SQL= "SELECT ISNULL(PROCESOS_TIPO,'') AS TIPO, TIPOPROCESO_DESC,PROCESOS_DESC "+
                            "FROM [ALBPROD].[dbo].[PROCESOS] " +
                            "INNER JOIN TIPOPROCESO ON TIPOPROCESO_ID = PROCESOS_TIPO "+
                            "WHERE PROCESOS_IDTWINS = "+NroProceso;
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
                            Fecha = Convert.ToDateTime(Dgprincipal.CurrentRow.Cells[0].Value.ToString()),
                            vienede = 1
                        };
                        _FrmReporteDespostada.ShowDialog();

                    }
                    else
                    {
                        if(Dgprincipal.CurrentRow.Cells[1].Value.ToString()=="P")
                        {
                            FrmReporteProcesosDetalle _FrmReporteProcesosDetalle = new FrmReporteProcesosDetalle
                            {
                                StartPosition = FormStartPosition.CenterScreen,
                                NroOT = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[4].Value.ToString()),
                                NroProceso = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[2].Value.ToString()),
                                Fecha = Convert.ToDateTime(Dgprincipal.CurrentRow.Cells[0].Value.ToString()),
                                vienede = 1
                            };
                            _FrmReporteProcesosDetalle.ShowDialog();
                        }

                        if (Dgprincipal.CurrentRow.Cells[1].Value.ToString() == "R")
                        {
                            FrmReporteRemitoSalida _FrmReporteRemitoSalida = new FrmReporteRemitoSalida
                            {
                                StartPosition = FormStartPosition.CenterScreen,
                                NcRemito = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[2].Value.ToString())
                            };

                            _FrmReporteRemitoSalida.ShowDialog();
                        }
                    }
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            } 
        }
    }
}
