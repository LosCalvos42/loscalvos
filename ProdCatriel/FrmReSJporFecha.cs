using Datos;
using logica;
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
    public partial class FrmReSJporFecha : Form
    {
        Clsproceso P = new Clsproceso();
        ClsProcesoBatea b = new ClsProcesoBatea();
        public FrmReSJporFecha()
        {
            InitializeComponent();
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            cargargrilla();
        }
        public void cargargrilla()
        {
            try
            {
                dgI.Rows.Clear();
                //nropro = Convert.ToInt32(lblnp.Text);
                P.nombre = 1000;
                P.fech = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                DataTable DT = P.BuscarProceso(P.nombre, P.fech);
                if (DT.Rows.Count > 0)
                {
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        dgI.Rows.Add(1);
                        dgI.Rows[dgI.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                        dgI.Rows[dgI.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                        dgI.Rows[dgI.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();

                    }
                    int totaluni = 0;
                    decimal totalpeso = 0;
                    for (int i = 0; i < dgI.RowCount; i++)
                    {
                        totaluni = totaluni + Convert.ToInt32(dgI.Rows[i].Cells[1].Value.ToString());
                        totalpeso = totalpeso + Convert.ToDecimal(dgI.Rows[i].Cells[2].Value.ToString());
                    }
                    dgI.Rows.Add(1);



                    using (Font font = new Font(
                                    dgI.DefaultCellStyle.Font.FontFamily, 11, FontStyle.Bold))
                    {
                        dgI.Rows[dgI.RowCount - 1].DefaultCellStyle.Font = font;
                    }
                    dgI.Rows[dgI.RowCount - 1].Cells[0].Style.ForeColor = Color.Teal;
                    dgI.Rows[dgI.RowCount - 1].Cells[1].Style.ForeColor = Color.Teal;
                    dgI.Rows[dgI.RowCount - 1].Cells[2].Style.ForeColor = Color.Teal;

                    dgI.Rows[dgI.RowCount - 1].Cells[0].Value = "Total";
                    dgI.Rows[dgI.RowCount - 1].Cells[1].Value = totaluni;
                    dgI.Rows[dgI.RowCount - 1].Cells[2].Value = totalpeso;
                    dgI.FirstDisplayedScrollingRowIndex = dgI.RowCount - 1;
                }
                dgNoaptos.Rows.Clear();
                //nropro = Convert.ToInt32(lblnp.Text);
                P.nombre = 1001;
                P.fech = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                DataTable DTS = P.BuscarProceso(P.nombre, P.fech);
                if (DTS.Rows.Count > 0)
                {
                    for (int i = 0; i < DTS.Rows.Count; i++)
                    {
                        dgNoaptos.Rows.Add(1);
                        dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[0].Value = DTS.Rows[i][0].ToString();
                        dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[1].Value = DTS.Rows[i][1].ToString();
                        dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[2].Value = DTS.Rows[i][2].ToString();

                    }
                    int totaluni = 0;
                    decimal totalpeso = 0;
                    for (int i = 0; i < dgNoaptos.RowCount; i++)
                    {
                        totaluni = totaluni + Convert.ToInt32(dgNoaptos.Rows[i].Cells[1].Value.ToString());
                        totalpeso = totalpeso + Convert.ToDecimal(dgNoaptos.Rows[i].Cells[2].Value.ToString());
                    }
                    dgNoaptos.Rows.Add(1);



                    using (Font font = new Font(
                                    dgNoaptos.DefaultCellStyle.Font.FontFamily, 11, FontStyle.Bold))
                    {
                        dgNoaptos.Rows[dgNoaptos.RowCount - 1].DefaultCellStyle.Font = font;
                    }
                    dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[0].Style.ForeColor = Color.Teal;
                    dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[1].Style.ForeColor = Color.Teal;
                    dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[2].Style.ForeColor = Color.Teal;

                    dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[0].Value = "Total";
                    dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[1].Value = totaluni;
                    dgNoaptos.Rows[dgNoaptos.RowCount - 1].Cells[2].Value = totalpeso;
                    dgNoaptos.FirstDisplayedScrollingRowIndex = dgNoaptos.RowCount - 1;



                    //else
                    //{
                    //    MessageBox.Show("NO Existen Datos Para para la Fecha Seleccionada", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (dgI.RowCount < 1 & dgNoaptos.RowCount<1)
            {
                MessageBox.Show("NO Existen Datos Para Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtB = new DataTable();
            dtB.Columns.Add("lote", typeof(System.String));
            dtB.Columns.Add("uni", typeof(System.Int32));
            dtB.Columns.Add("peso", typeof(System.Double));
            DataTable dtB1 = new DataTable();
            dtB1.Columns.Add("lote", typeof(System.String));
            dtB1.Columns.Add("uni", typeof(System.Int32));
            dtB1.Columns.Add("peso", typeof(System.Double));

            foreach (DataGridViewRow rowGrid in dgI.Rows)
            {
                DataRow row = dtB.NewRow();

                row["lote"] = rowGrid.Cells[0].Value;
                row["uni"] = rowGrid.Cells[1].Value;
                row["peso"] = rowGrid.Cells[2].Value;

                dtB.Rows.Add(row);
            }

            foreach (DataGridViewRow rowGrid in dgNoaptos.Rows)
            {
                DataRow row = dtB1.NewRow();

                row["lote"] = rowGrid.Cells[0].Value;
                row["uni"] = rowGrid.Cells[1].Value;
                row["peso"] = rowGrid.Cells[2].Value;

                dtB1.Rows.Add(row);
            }
            ///////////////
            ReporteFrmReSJporFecha _ReporteFrmReSJporFecha = new ReporteFrmReSJporFecha();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            ClsDatosReporteBatea datos1 = new ClsDatosReporteBatea();
            _ReporteFrmReSJporFecha.datosR.Add(datos);
            _ReporteFrmReSJporFecha.dtr.Columns.Add("lote", typeof(System.String));
            _ReporteFrmReSJporFecha.dtr.Columns.Add("uni", typeof(System.Int32));
            _ReporteFrmReSJporFecha.dtr.Columns.Add("peso", typeof(System.Decimal));
            _ReporteFrmReSJporFecha.dtr = dtB;
            _ReporteFrmReSJporFecha.datosR.Add(datos1);
            _ReporteFrmReSJporFecha.dtr1.Columns.Add("lote", typeof(System.String));
            _ReporteFrmReSJporFecha.dtr1.Columns.Add("uni", typeof(System.Int32));
            _ReporteFrmReSJporFecha.dtr1.Columns.Add("peso", typeof(System.Decimal));
            _ReporteFrmReSJporFecha.dtr1 = dtB1;

            datos.Fecha = dt1.Value;
            _ReporteFrmReSJporFecha.StartPosition = FormStartPosition.CenterScreen;
            _ReporteFrmReSJporFecha.MdiParent = this.MdiParent;
            _ReporteFrmReSJporFecha.Show();
            //////////////
        }


    }
}
