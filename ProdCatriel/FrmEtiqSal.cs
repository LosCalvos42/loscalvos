using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TRAZAAR
{
    public partial class FrmEtiqSal : Form
    {
        public FrmEtiqSal()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }


        string ImpLote = "";
        string ImpCategoria = "";
        int ImpCantidad = 0;
        int CantidadParametro;
        string OBSERVACION1;
        string OBSERVACION2;
        string IMPRIME_OBS;



        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            GetCantidadParametro();
            GetObservacion();
        }
        private void GetCantidadParametro()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"select VALORINT from PARAMETROSPRODUCCION where PARAMETRO_CLAVE ='CANTIDAD_BIN_SALAR'";

            dt = M.lisquery(ssql);
            if (dt.Rows.Count > 0)
            {
                CantidadParametro = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }

        private void GetObservacion()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"select VALORTEXTO from PARAMETROSPRODUCCION where PARAMETRO_CLAVE IN ('OBS_BIN_SALAR1','OBS_BIN_SALAR2') ORDER BY PARAMETRO_CLAVE";

            dt = M.lisquery(ssql);
            if (dt.Rows.Count > 0)
            {
                OBSERVACION1 = dt.Rows[0][0].ToString();
                OBSERVACION2 = dt.Rows[1][0].ToString();
            }
        }

        private void LlenarGrid()
        {
            Dgprincipal.DataSource = null;
            BtnImprimir.Enabled = false;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@lote", TxtLote.Text));
                dt = M.Listado("SP_GetImpresionBins", lst);
                

                if (dt.Rows.Count > 0)
                {

                    Dgprincipal.DataSource = dt;
                    Dgprincipal.Columns[5].Visible = false;
                    Dgprincipal.Columns[6].Visible = false;
                    BtnImprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("NO existen datos para el Lote Ingresado. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Imprimir()
        {
            string NombreImpresora =Program.IMPRESORAETIQUETA;
            if ( NombreImpresora != null)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(Pr_PrintPage);
                // Especifica que impresora se utilizara!!
                pd.PrinterSettings.PrinterName = NombreImpresora;
                PageSettings pa = new PageSettings();
                pa.Margins = new Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 380, 800);
                pd.DefaultPageSettings.PaperSize = ps;
                pd.Print();
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

        //funcion que se encarga de imprimir
        private void Pr_PrintPage(Object sender, PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font Titulos = new Font("Arial", 50, FontStyle.Regular))//Formato
                using (Font TLote = new Font("Arial Black", 60, FontStyle.Bold))//Formato
                using (Font TCate = new Font("Arial Black", 60, FontStyle.Bold))//Formato
                using (Font TCanti = new Font("Arial Black", 60, FontStyle.Bold))//Formato
                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    /*lote*/
                    string caption = "Lote:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 20, 15);//posicion del texto
                    caption = string.Format("{0}", Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                    g.DrawString(caption, TLote, System.Drawing.Brushes.Black, 5, 90);

                    /*Categoria*/
                    caption = string.Format("{0}", "Categoria:");
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 20, 210);
                     caption = string.Format("{0}", Dgprincipal.CurrentRow.Cells[2].Value.ToString());
                    g.DrawString(caption, TCate, System.Drawing.Brushes.Black, 20, 280);

                    /*Sanitario*/
                    caption = string.Format("{0}", "Cantidad:");
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 20, 400);
                     caption = string.Format("{0}", ImpCantidad);
                    g.DrawString(caption, TCanti, System.Drawing.Brushes.Black, 20, 460);
                    //  caption = string.Format("{0}", TxtSanitario2.Text);
                    if (IMPRIME_OBS == "SI")
                    { 
                        caption = string.Format("{0}", OBSERVACION1);
                        g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 15, 560);

                        caption = string.Format("{0}", OBSERVACION2);
                        g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 15, 640);


                    }



                }
            }
        }

        private bool valido()
        {
            //if (CmbProdProc.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Hay Datos Sin completar (Producto)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    CmbProdProc.Focus();
            //    return false;
            //}
            return true;
        }
        private void Cargarcombo(string combo, ComboBox _combo)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", ""));
                dt = M.Listado("sp_CargaCombos", lst);
                _combo.DataSource = dt;
                _combo.DisplayMember = "NOMBRE";
                _combo.ValueMember = "ID";
                DataRow topItem = dt.NewRow();
                topItem[0] = 1;
                topItem[1] = 1;
                topItem[2] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //;
            if (valido())
            {
                LlenarGrid();
            }
        }

        

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count > 0)
            { 
                try
                {
                    IMPRIME_OBS = "NO";
                    int canti30=Convert.ToInt32(Dgprincipal.CurrentRow.Cells[5].Value.ToString());
                    int cantimenor= Convert.ToInt32(Dgprincipal.CurrentRow.Cells[6].Value.ToString());

                    if (canti30 == 0 && cantimenor >1)
                    {
                        IMPRIME_OBS = "SI";
                    } else
                    {
                        IMPRIME_OBS = "NO";
                    }
                    for (int i = 0; i < canti30; i++)
                    {
                        if (i == 0)
                        {
                            IMPRIME_OBS = "SI";
                        }
                        else
                        {
                            IMPRIME_OBS = "NO";
                        }
                        ImpCantidad = CantidadParametro;
                        Imprimir();
                        IMPRIME_OBS = "NO";
                    }
                    ImpCantidad = cantimenor;
                    Imprimir();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmImpresoras _FrmImpresoras = new FrmImpresoras();
            _FrmImpresoras.StartPosition = FormStartPosition.CenterScreen;
            _FrmImpresoras.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmImpresoras _FrmImpresoras = new FrmImpresoras();
            _FrmImpresoras.StartPosition = FormStartPosition.CenterScreen;
            _FrmImpresoras.ShowDialog();
        }
    }
}

    
 

