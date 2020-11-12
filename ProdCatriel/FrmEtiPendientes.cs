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

namespace TRAZAAR
{
    public partial class FrmEtiPendientes : Form
    {
        public FrmEtiPendientes()
        {
            InitializeComponent();
        }

        public int NROOT{ get; set; }
        public string LOTE { get; set; }
        public string CATEGORIA { get; set; }
        string impresora;

        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            LblTitulo.Text = "Piezas Pendientes";
            Dgprincipal.Rows.Clear();
            CargarGrid();
            GetimpresoraEti();
        }

        private void GetimpresoraEti()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"SELECT VALORTEXTO FROM PARAMETROSPRODUCCION " +
            "WHERE PARAMETRO_CLAVE = 'IMPRESORA_ETI_JAMON' ";

            dt = M.lisquery(ssql);
            if (dt.Rows.Count > 0)
            {
                impresora = dt.Rows[0][0].ToString();
            }
        }



        private void CargarGrid()
        {
            Dgprincipal.Rows.Clear();
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@TIPO",1));
                lst.Add(new ClsParametros("@NROOT",NROOT));
                lst.Add(new ClsParametros("@LOTE",LOTE));
                lst.Add(new ClsParametros("@CATEGORIA", CATEGORIA));
                dt = M.Listado("SP_GetPiezasPendientes", lst);
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

            foreach (DataGridViewRow r in Dgprincipal.SelectedRows)
            {
                string inputFilePath = Application.StartupPath + @"\Reportes\Jamon.E05";
                TextWriter tsw = new StreamWriter(inputFilePath);
                tsw.WriteLine("^XA^CFD");
                tsw.WriteLine("^POI");
                tsw.WriteLine("^MMT");
                tsw.WriteLine("^PW799");
                tsw.WriteLine("^LL1598");
                tsw.WriteLine("^LS0");
                tsw.WriteLine("^FO480,225^GB275,0,4^FS");
                tsw.WriteLine("^BY2,2,150^FT530,385^BEN,,Y,N");
                tsw.WriteLine("^FD" + r.Cells[4].Value.ToString() + "^FS");
                tsw.WriteLine(@"^FT550,80^A0N,36,33^FH\^FD" + r.Cells[1].Value.ToString() + "^FS");
                tsw.WriteLine(@"^FT500,120^A0N,33,33^FH\^FDLote:^FS");
                tsw.WriteLine(@"^FT500,165^A0N,28,28^FH\^FDPieza:^FS");
                tsw.WriteLine(@"^FT500,210^A0N,28,28^FH\^FDPeso:^FS");
                tsw.WriteLine(@"^FT610,210^A0N,51,50^FH\^FD" + r.Cells[6].Value.ToString() + "^FS");
                tsw.WriteLine(@"^FT700,155^A0N,28,28^FH\^FD" + r.Cells[3].Value.ToString() + "^FS");
                tsw.WriteLine(@"^FT650,120^A0N,34,33^FH\^FD" + r.Cells[2].Value.ToString() + "^FS");
                tsw.WriteLine("^PQ1,0,1,Y^XZ");

                //tsw.WriteLine("^XA");
                //tsw.WriteLine("^XFE:1.ZPL");
                //tsw.WriteLine("^FN999^FD" + r.Cells[4].Value.ToString() + "^FS");
                //tsw.WriteLine("^FN998^FD" + r.Cells[2].Value.ToString() + "^FS");
                //tsw.WriteLine("^FN997^FD" + r.Cells[6].Value.ToString() + "^FS");
                //tsw.WriteLine("^FN996^FD" + r.Cells[3].Value.ToString() + "^FS");
                //tsw.WriteLine("^XZ");
                //tsw.WriteLine("^FX");

                tsw.Close();
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = "ZebraZM4";
                PageSettings pa = new PageSettings();
                pa.Margins = new Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 350, 190);
                pd.DefaultPageSettings.PaperSize = ps;
                string printerPath = impresora;
                System.IO.File.Copy(inputFilePath, printerPath, true);
            }  
        }
    }
}

    
 

