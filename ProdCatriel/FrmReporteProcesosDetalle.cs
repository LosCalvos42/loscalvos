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
    public partial class FrmReporteProcesosDetalle : Form
    {
        public FrmReporteProcesosDetalle()
        {
            InitializeComponent();
        }
        public Int64 Nroingreso;
        public int vienede { get; set; }
        public int NroOT { get; set; }
        public int NroProceso { get; set; }
        public DateTime Fecha { get; set; }
        private void DetalleCaja_Load(object sender, EventArgs e)
        {
            LblFecha.Text = "";
            lblNroOT.Text = "";
            LblLote.Text = "";
            LblProceso.Text = "";
            LblDescOt.Text = "";
            LlenarGrid(Nroingreso);
            //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DgEntrada.ClearSelection();
            Cursor.Current = Cursors.Default;
            DgEntrada.ClearSelection();

            Salir.Focus();

        }

        private void LlenarGrid(Int64 nroIng)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //SP_Catriel_ProcesosResumen 20190901,20191010,2,1034 
                //@Fecha_Desde int,
                //@Fecha_Hasta int,
                //@Tipo int,
                //@NroOt int
                int FechaProd = Convert.ToInt32(Fecha.ToString("yyyyMMdd"));
                lst.Add(new ClsParametros("@Fecha_Desde", NroProceso));  //No importa que fecha es porque
                lst.Add(new ClsParametros("@Fecha_Hasta", FechaProd));  //el SP en este caso busca por OT
                lst.Add(new ClsParametros("@Tipo", "2"));
                lst.Add(new ClsParametros("@NroOt", NroOT));
                dt = M.Listado("SP_Catriel_ProcesosResumen", lst);

                if (dt.Rows.Count > 0)
                {
                    LblFecha.Text = dt.Rows[0][5].ToString();
                    LblDescOt.Text = dt.Rows[0][2].ToString();
                    LblProceso.Text = dt.Rows[0][3].ToString()+" - "+dt.Rows[0][4].ToString();
                    lblNroOT.Text= dt.Rows[0][1].ToString();
                    LblLote.Text = dt.Rows[0][6].ToString();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int numero = 0;
                        DgEntrada.Rows.Add(1);
                        DgEntrada.Rows[DgEntrada.Rows.Count - 1].Cells[0].Value = dt.Rows[i][7].ToString();
                        DgEntrada.Rows[DgEntrada.Rows.Count - 1].Cells[1].Value = dt.Rows[i][8].ToString();
                        DgEntrada.Rows[DgEntrada.Rows.Count - 1].Cells[2].Value = dt.Rows[i][9].ToString();
                        if (dt.Rows[i][10].ToString() != "")
                        { 
                                 numero = Convert.ToInt32(dt.Rows[i][10].ToString());
                                DgEntrada.Rows[DgEntrada.Rows.Count - 1].Cells[3].Value = numero.ToString("N0");
                        }
                        if (dt.Rows[i][11].ToString() != "")
                        {
                            numero = Convert.ToInt32(dt.Rows[i][11].ToString());
                            DgEntrada.Rows[DgEntrada.Rows.Count - 1].Cells[4].Value = numero.ToString("N0");
                            //Dgprincipal.Rows[i].Cells[6].Value = Convert.ToDecimal(dt.Rows[i][6].ToString());
                        }
                    }
                    EstadoGrilla();
                }
                else
                {
                    
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstadoGrilla()
        {


            using (Font font = new Font(
                    DgEntrada.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
            {

                DgEntrada.Columns[4].DefaultCellStyle.Font = font;
                DgEntrada.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;

                DgEntrada.Columns[0].DefaultCellStyle.Font = font;
                DgEntrada.Columns[0].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);


            } 
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int NC_proceso = 0, Nro_ot = 0;
            string NC_merc ="";
            string lote = "";

            if (DgEntrada.CurrentRow.Cells[0].Value.ToString() != "" && DgEntrada.CurrentCell.ColumnIndex == 4)
            {

                NC_proceso = NroProceso;

                if (NroOT == 0)
                {
                    NroOT = Convert.ToInt32(lblNroOT.Text);
                }
                else { 
                    Nro_ot = NroOT;
                }


                NC_merc = DgEntrada.CurrentRow.Cells[0].Value.ToString();
                lote = DgEntrada.CurrentRow.Cells[2].Value.ToString();
                try
                {
                    FrmIngresoCarnicosTrazabilidad _FrmIngresoCarnicosTrazabilidad1 = new FrmIngresoCarnicosTrazabilidad();
                    _FrmIngresoCarnicosTrazabilidad1.StartPosition = FormStartPosition.CenterScreen;
                    _FrmIngresoCarnicosTrazabilidad1.Nroingreso = NroOT;
                    _FrmIngresoCarnicosTrazabilidad1.Nc_mercaderia = NroProceso;
                    _FrmIngresoCarnicosTrazabilidad1.CodigoM = NC_merc;
                    _FrmIngresoCarnicosTrazabilidad1.VIENEDE="PROCESO";
                    _FrmIngresoCarnicosTrazabilidad1.LOTE = lote;
                    // _FrmIngresoCarnicosTrazabilidad1. = "PROCESO";
                    _FrmIngresoCarnicosTrazabilidad1.Producto= DgEntrada.CurrentRow.Cells[1].Value.ToString();
                    _FrmIngresoCarnicosTrazabilidad1.Kg = Convert.ToString(DgEntrada.CurrentRow.Cells[4].Value.ToString());
                    _FrmIngresoCarnicosTrazabilidad1.ShowDialog();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            if (DgEntrada.CurrentRow.Cells[0].Value.ToString() != "" && DgEntrada.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    FrmCarnicosCuentaCorriente _FrmCarnicosCuentaCorriente = new FrmCarnicosCuentaCorriente();
                    _FrmCarnicosCuentaCorriente.StartPosition = FormStartPosition.CenterScreen;
                    _FrmCarnicosCuentaCorriente.CodigoProducto = DgEntrada.CurrentRow.Cells[0].Value.ToString();
                    _FrmCarnicosCuentaCorriente.NombreProducto= DgEntrada.CurrentRow.Cells[1].Value.ToString();
                    _FrmCarnicosCuentaCorriente.Periodo = Convert.ToDateTime(LblFecha.Text);
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
