using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using Datos;
using Excel = Microsoft.Office.Interop.Excel;
namespace LOSCALVOS
{
    public partial class FrmTwinsIngresoXproveedor : Form
    {


        ClsTWingresos P = new ClsTWingresos();
        public FrmTwinsIngresoXproveedor()
        {
            InitializeComponent();
        }

        private void FrmTwinsIngresoXproveedor_Resize(object sender, EventArgs e)
        {
            Salir.Top = this.Height - 80;
            Salir.Left = this.Width - 100;
            dgDatos.Width = Width - 650;
            dgDatos.Height = Height - 160;
            print.Top = this.Height - 140;
            print.Left = this.Width - 80;

            progressBar1.Top = this.Height - 60;
            progressBar1.Width = Width - 650;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Cargargrilla()
        {
            progressBar1.Value -=1 ;
            try
            {
                this.Refresh();
                dgDatos.Rows.Clear();
                
                string fechD = Convert.ToString(DTD.Value.ToString("yyyy/MM/dd")).Replace("/","");
                string fechH = Convert.ToString(DTH.Value.ToString("yyyy/MM/dd")).Replace("/", "");
                P.fechD = Convert.ToInt32(fechD);
                P.fechH = Convert.ToInt32(fechH);
                progressBar1.Value += ((50 * progressBar1.Maximum) / 100);
                DataTable DT = P.BuscarIngresos(P.fechD, P.fechH);
                if (DT.Rows.Count > 0)
                {
                    progressBar1.Maximum = DT.Rows.Count+progressBar1.Value;
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                       dgDatos.Rows.Add(1);
                       if (dgDatos.Rows.Count>1 && Convert.ToString(dgDatos.Rows[dgDatos.RowCount - 2].Cells[0].Value) != DT.Rows[i][0].ToString())
                        {
                            using (Font font = new Font(
                            dgDatos.DefaultCellStyle.Font.FontFamily, 11, FontStyle.Bold))
                            {
                                dgDatos.Rows[dgDatos.RowCount - 1].DefaultCellStyle.Font = font;
                            }
                            dgDatos.Rows[dgDatos.RowCount - 1].Cells[0].Style.BackColor = Color.LightSkyBlue;
                            dgDatos.Rows[dgDatos.RowCount - 1].Cells[0].Value = "Proveedor";
                            dgDatos.Rows[dgDatos.RowCount - 1].Cells[1].Style.BackColor = Color.LightSkyBlue;
                            dgDatos.Rows[dgDatos.RowCount - 1].Cells[1].Value = "MateriaPrima";
                            dgDatos.Rows[dgDatos.RowCount - 1].Cells[2].Style.BackColor = Color.LightSkyBlue;
                            dgDatos.Rows[dgDatos.RowCount - 1].Cells[2].Value = "Kg";
                            dgDatos.Rows.Add(1);
                            progressBar1.Maximum += 1;
                            System.Threading.Thread.Sleep(20);
                            this.Refresh();
                            //progressBar1.Value += 1;
                        }
                       dgDatos.Rows[dgDatos.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                       dgDatos.Rows[dgDatos.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                       dgDatos.Rows[dgDatos.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                       progressBar1.Value += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar1.Value = 0;
        }


            private void releaseObject(object obj)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
                catch (Exception ex)
                {
                    obj = null;
                    MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
                }
                finally
                {
                    GC.Collect();
                }
            }
      


        private void print_Click(object sender, EventArgs e)
        {
            ////////Cursor.Current = Cursors.WaitCursor;
            ////////Exportar exp = new Exportar();
            ////////exp.ExportarDataGridViewExcel(dgDatos, progressBar1, Convert.ToString(DTD.Value.ToString("dd/MM/yyyy")), Convert.ToString(DTH.Value.ToString("dd/MM/yyyy")));
            ////////this.Refresh();
            ////////System.Threading.Thread.Sleep(100);
            ////////progressBar1.Value = 0;
            ////////progressBar1.Maximum = 100;
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //int i = 0;
            //int j = 0;
            //xlWorkSheet.Rows.Cells.Font.Size = 11;
            //xlWorkSheet.Rows.Cells.Font.Name = "Verdana";

            //int iFil = 0, iCol = 0;
            //foreach (DataGridViewColumn column in dgDatos.Columns)
            //    if (column.Visible)
            //        xlWorkSheet.Cells[1, ++iCol] = column.HeaderText;
            ////MARCAMOS LAS CELDAS DEL ENCABEZADO EN NEGRITA Y EN COLOR DE RELLENO GRIS
            //xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, dgDatos.ColumnCount]].Font.Bold = true;
            //xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, dgDatos.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);

            //for (  i = 0; i <= dgDatos.RowCount - 1; i++)
            //{
            //    for (j = 0; j <= dgDatos.ColumnCount - 1; j++)
            //    {
            //        DataGridViewCell cell = dgDatos[j, i];
            //        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
            //    }
            //}

            //xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            cmdBuscar.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            this.Refresh();
            progressBar1.Value = 50;
            //progressBar1.Value -=20;
            dgDatos.Rows.Clear();
            progressBar1.Value = 50;
            progressBar1.Visible = true;
            progressBar1.Refresh();
            this.Refresh();
            Cargargrilla();
            progressBar1.Value = 0;
            cmdBuscar.Enabled = true;
        }
    }
}

