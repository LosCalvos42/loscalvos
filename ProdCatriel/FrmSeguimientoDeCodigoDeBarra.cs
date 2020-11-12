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

namespace TRAZAAR
{
    public partial class FrmSeguimientoDeCodigoDeBarra : Form
    {
        public FrmSeguimientoDeCodigoDeBarra()
        {
            InitializeComponent();
        }

        decimal MERMA = 0;

        private void CargarDatosOrigen()
        {
            try
            {
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@CodBar", TxtCodBar.Text));
                lst.Add(new ClsParametros("@tipo", 1));

                dt = M.Listado("SP_GetSeguimientoCodbar", lst);
                if (dt.Rows.Count > 0)
                {
                    DgOrigen.DataSource = dt;
                }

                DgOrigen.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                DgOrigen.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                DgOrigen.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                DgOrigen.Rows[1].DefaultCellStyle.ForeColor = Color.White;

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
                using (Font font = new Font(
                   DgOrigen.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                {
                    DgOrigen.Rows[0].DefaultCellStyle.Font = font;
                    DgOrigen.Rows[1].DefaultCellStyle.Font = font;
                }
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
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@CodBar", TxtCodBar.Text));
                lst.Add(new ClsParametros("@tipo", 2));

                dt = M.Listado("SP_GetSeguimientoCodbar", lst);
                if (dt.Rows.Count > 0)
                {
                    DgMovimientos.DataSource = dt;
                }

                DgMovimientos.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                DgMovimientos.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                DgMovimientos.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                DgMovimientos.Rows[1].DefaultCellStyle.ForeColor = Color.White;


                using (Font font = new Font(
                   DgMovimientos.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                {
                    DgMovimientos.Rows[0].DefaultCellStyle.Font = font;
                    DgMovimientos.Rows[1].DefaultCellStyle.Font = font;
                }
                DgMovimientos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosActual()
        {
            try
            {
                DgActual.Rows.Clear();
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@CodBar", TxtCodBar.Text));
                lst.Add(new ClsParametros("@tipo", 3));

                dt = M.Listado("SP_GetSeguimientoCodbar", lst);
                if (dt.Rows.Count > 0)
                {
                    
                    MERMA = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DgActual.Rows.Add(dt.Rows[i][0]);
                        DgActual.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        DgActual.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        DgActual.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        DgActual.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

                        if (i == 8 && dt.Rows[i][3].ToString()!="")
                        {
                            MERMA= Convert.ToDecimal(dt.Rows[i][3].ToString().Replace(".",","));
                        }

                    }
                    DgActual.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                    DgActual.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                    DgActual.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                    DgActual.Rows[1].DefaultCellStyle.ForeColor = Color.White;
                    using (Font font = new Font(
                    DgActual.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                    {
                        DgActual.Rows[0].DefaultCellStyle.Font = font;
                        DgActual.Rows[1].DefaultCellStyle.Font = font;
                    }
                    DgActual.ClearSelection();
                    if (dt.Rows[0][2].ToString() == "")
                    {
                        MessageBox.Show("No se encontraron Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Graficar()
        {
            chart1.Series[0].Points.Clear();
            decimal resto = 100;
            //diferencia = 0;

            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            resto = resto - Math.Round(Math.Abs(MERMA), 2);
            chart1.Series[0].Points.AddXY(" ", resto);
            chart1.Series[0].Points.AddXY("MERMA", Math.Round(Math.Abs(MERMA), 2));
        }


        private void TxtCodBar_KeyPress(object sender, KeyPressEventArgs e)
       {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CargarDatosActual();
                CargarDatosOrigen();
                CargarDatosMov();
                Graficar();
            }
        }

    }
}
