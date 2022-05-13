using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmDetalleDeExpedicion : Form
    {
        public FrmDetalleDeExpedicion()
        {
            InitializeComponent();
        }

        public string Camara { get; set; }
        public string Producto { get; set; }
        public DateTime Fecha { get; set; }

        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            LblTitulo.Text = "Detalle";
            Dgprincipal.Rows.Clear();
            CargarGrid();
        }

        private void CargarGrid()
        {
            Dgprincipal.Rows.Clear();
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo", "DETALLE"));
                lst.Add(new ClsParametros("@FechaDesde", Fecha.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@FechaHasta", Fecha.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@ARTICODIGO", Producto));
                dt = M.Listado("SP_ConsultaExpedicion", lst);    //SP del reporte
                Dgprincipal.DataSource = dt;
                Dgprincipal.ClearSelection();

                //if (Dgprincipal.Rows.Count > 0)
                //{ 
                //    Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColorGrid()
        {
            //if (Dgprincipal.Rows.Count > 0)
            //{

            //    for (int i = 0; i < Dgprincipal.Rows.Count; i++)
            //    {
            //        if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "Codigo Repetido")
            //        {
            //            Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
            //        }
            //        if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "Error en campo Peso (KG)")
            //        {
            //            Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //        }
            //        if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "Fuera de Categoria")
            //        {
            //            Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //        }

            //    }
            //    Dgprincipal.ReadOnly = true;
            //    Dgprincipal.ClearSelection();
            //}
        }
        

        private bool valido()
        {
            return true;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.RowCount > 0)
            {
                DataGridViewSelectedRowCollection Seleccionados = Dgprincipal.SelectedRows;

                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();

                foreach (DataGridViewRow item in Seleccionados)
                {
                    dt.Clear();
                    lst.Clear();
                    string id = item.Cells[3].Value.ToString();

                    lst.Add(new ClsParametros("@codbar", id));
                    dt = M.Listado("SP_GetInfoCodbar", lst);
                    if (dt.Rows.Count > 0)
                    {
                        Imprimir(dt);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void Imprimir(DataTable dt)
        {
            string impresora = @"\\localhost\" + Program.IMPRESORAETIQUETA;
            if (impresora != null)
            {
                string inputFilePath = Application.StartupPath + @"\Reportes\Produccion.E05";
                TextWriter tsw = new StreamWriter(inputFilePath);
                tsw.WriteLine(@"^XA");
                tsw.WriteLine(@"^MMT");
                tsw.WriteLine(@"^PW812");
                tsw.WriteLine(@"^LL0406");
                tsw.WriteLine(@"^LS0");
                tsw.WriteLine(@"^FT135,70^A0N,62,67^FH\^FDVto.: " + dt.Rows[0][10].ToString() + "^FS");
                tsw.WriteLine(@"^FT35,158^A0N,88,42^FH\^FD" + dt.Rows[0][1].ToString() + "-" + dt.Rows[0][2].ToString() + "^FS");
                tsw.WriteLine(@"^FT115,261^A0N,42,33^FH\^FD" + dt.Rows[0][6].ToString() + "^FS");
                tsw.WriteLine(@"^FT115,211^A0N,46,33^FH\^FD" + dt.Rows[0][5].ToString() + "^FS");
                tsw.WriteLine(@"^FT40,264^A0N,44,28^FH\^FDTara:^FS");
                tsw.WriteLine(@"^FT469,260^A0N,111,64^FH\^FD" + dt.Rows[0][7].ToString() + " kg^FS");
                tsw.WriteLine(@"^FT357,246^A0N,56,45^FH\^FD" + dt.Rows[0][4].ToString() + "^FS");
                tsw.WriteLine(@"^FT40,211^A0N,44,28^FH\^FDBruto:^FS");
                tsw.WriteLine(@"^FT221,245^A0N,56,62^FH\^FDCant:^FS");
                tsw.WriteLine(@"^FT464,350^A0N,28,30^FH\^FDFecha: " + dt.Rows[0][9].ToString() + "^FS");
                tsw.WriteLine(@"^FT524,315^A0N,30,38^FH\^FD" + dt.Rows[0][3].ToString() + "^FS");
                tsw.WriteLine(@"^FT463,315^A0N,23,26^FH\^FDLote:^FS");
                tsw.WriteLine(@"^FT75,392^A0N,36,45^FH\^FD" + dt.Rows[0][8].ToString() + "^FS");
                tsw.WriteLine(@"^BY2,3,86^FT35,360^BCN,,N,N");
                tsw.WriteLine(@"^FD>:" + dt.Rows[0][8].ToString() + "^FS");
                tsw.WriteLine(@"^PQ1,0,1,Y^XZ");

                tsw.Close();
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = "ZebraZM4";
                PageSettings pa = new PageSettings();
                pa.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 1000, 2000);
                pd.DefaultPageSettings.PaperSize = ps;
                string printerPath = impresora;
                System.IO.File.Copy(inputFilePath, printerPath, true);
            }
            else
            {
                if (MessageBox.Show("Impresora NO configurada para este Equipo" + Environment.NewLine + "Desea Ir a Configuracion de Impresora?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    CheckForIllegalCrossThreadCalls = false;
                    FrmImpresoras _FrmImpresoras = new FrmImpresoras();
                    _FrmImpresoras.StartPosition = FormStartPosition.CenterScreen;
                    _FrmImpresoras.ShowDialog();
                }
                else
                {
                    return;
                }
            }
        }
    }
}

    
 

