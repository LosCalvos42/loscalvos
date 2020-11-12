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
    public partial class FrmEtiqGancheras : Form
    {
        public FrmEtiqGancheras()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }

        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            Cargarcombo("PRODUCTOSCLASIFICADOS", CmbProdProc);
            DataGridViewCheckBoxColumn SEL = new DataGridViewCheckBoxColumn();
            SEL.HeaderText = "SEL";
            Dgprincipal.Columns.Add(SEL);
            Dgprincipal.Columns[8].Width = 50;


        }
        private void LlenarGrid()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@tipo",2));
                lst.Add(new ClsParametros("@fecha ", Convert.ToInt32(DtDeste.Value.ToString("yyyyMMdd"))));
                lst.Add(new ClsParametros("@lote", CmbLote.SelectedValue));
                lst.Add(new ClsParametros("@NRO_PROC", CmbProdProc.SelectedValue));
                lst.Add(new ClsParametros("@ARTI", CmbProdProc.SelectedValue));
                dt = M.Listado("SP_OrigenClasificacionImpGancheras", lst);
                Dgprincipal.Rows.Clear();

                if (dt.Rows.Count > 0)
                { 

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Dgprincipal.Rows.Add(dt.Rows[i][0]);
                        Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        Dgprincipal.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        Dgprincipal.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                        Dgprincipal.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                        Dgprincipal.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                        Dgprincipal.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                        Dgprincipal.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                        Dgprincipal.Rows[i].Cells[8].Value = true;
                    }
                    GrupoCate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("NO existen datos para la fecha seleccionada. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                PaperSize ps = new PaperSize("Custom", 350, 190);
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
                using (Font Titulos = new Font("Arial", 22, FontStyle.Regular))//Formato
                using (Font TLote = new Font("Arial Black", 20, FontStyle.Bold))//Formato
                using (Font TCate = new Font("Arial Black", 40, FontStyle.Bold))//Formato
                using (Font TSani = new Font("Arial", 17, FontStyle.Bold))//Formato
                using (Font Fecha = new Font("Arial", 10, FontStyle.Regular))//Formato
                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();

                    /*Feha De Clasificado*/ string caption = "Clasif."+ DtDeste.Value.ToString("dd/MM/yyyy");
                    g.DrawString(caption, Fecha, System.Drawing.Brushes.Black, 110, 178);//posicion del texto
                                                                                          
                   /*lote*/   caption = "Lote:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 105, 15);//posicion del texto
                    caption = string.Format("{0}", LblLote.Text);
                    g.DrawString(caption, TLote, System.Drawing.Brushes.Black, 180, 15);

                  /*Categoria*/   caption = string.Format("{0}", "Categoria:" );
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 31, 55);
                    caption = string.Format("{0}", LblCat.Text);
                    g.DrawString(caption, TCate, System.Drawing.Brushes.Black, 180, 35);

                  /*Sanitario*/ caption = string.Format("{0}", "Sanitario/s:");
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 20, 95);
                    caption = string.Format("{0}", TxtSanitario1.Text);
                    g.DrawString(caption, TSani, System.Drawing.Brushes.Black, 5, 127);
                    caption = string.Format("{0}", TxtSanitario2.Text);
                    g.DrawString(caption, TSani, System.Drawing.Brushes.Black, 5, 155);
                }
            }
        }

        private bool valido()
        {
            if (CmbProdProc.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (Producto)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbProdProc.Focus();
                return false;
            }
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
        private void CargarcomboLote(string combo, ComboBox _combo)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@tipo", 1));
                lst.Add(new ClsParametros("@fecha ", Convert.ToInt32(DtDeste.Value.ToString("yyyyMMdd"))));
                lst.Add(new ClsParametros("@lote", ""));
                lst.Add(new ClsParametros("@NRO_PROC", CmbProdProc.SelectedValue));
                lst.Add(new ClsParametros("@arti", CmbProdProc.SelectedValue));
                dt = M.Listado("SP_OrigenClasificacionImpGancheras", lst);
                CmbLote.DataSource = null;

                if (dt.Rows.Count > 0)
                { 
                    _combo.DataSource = dt;
                    _combo.DisplayMember = "Lote";
                    _combo.ValueMember = "Lote";
                    DataRow topItem = dt.NewRow();
                    topItem[0] = "-Select-";
                    dt.Rows.InsertAt(topItem, 0);
                    _combo.SelectedValue = "-Select-";
                }
                else
                {
                    MessageBox.Show("NO existen datos para la fecha seleccionada. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            GrupoCate.Enabled = false;
            Dgprincipal.Rows.Clear();
            if (valido())
            {
                CheFalse();
                CargarcomboLote("PRODUCTOSCLASIFICADOS", CmbLote);
                //LlenarGrid();
            }
        }

        private void CmbLote_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Dgprincipal.Rows.Clear();
            Dgprincipal.Refresh();
            GrupoCate.Enabled =false;
            if (CmbLote.SelectedIndex != 0)
            { 
                LlenarGrid();
                LblLote.Text = CmbLote.SelectedValue.ToString();
                
            }
            this.Cursor = Cursors.Default;
            Dgprincipal.SelectAll();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CheFalse()
        {
            RC1.Checked = false;
            RC2.Checked = false;
            RC3.Checked = false;
            RC4.Checked = false;
            RC5.Checked = false;
            RC6.Checked = false;
            RC7.Checked = false;
            RC8.Checked = false;
            RC9.Checked = false;
            RC10.Checked = false;
            RC12.Checked = false;
            RC12.Checked = false;
            TxtSanitario1.Text = "";
            TxtSanitario2.Text = "";
        }
       

        private void Dgprincipal_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            CheFalse();
        }
        private void Sanitarios()
        {
            try
            {
                TxtSanitario1.Text = "";
                TxtSanitario2.Text = "";
                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {
                    bool isCellChecked = (bool)Dgprincipal.Rows[i].Cells[8].Value;
                    if (isCellChecked == true)
                    {
                        if (i == 0)
                        {
                            TxtSanitario1.Text = TxtSanitario1.Text + Dgprincipal.Rows[i].Cells[7].Value.ToString();

                        }
                        if (i == 1)
                        {

                            TxtSanitario1.Text = TxtSanitario1.Text+ " / "+ Dgprincipal.Rows[i].Cells[7].Value.ToString();

                        }
                        if (i == 2)
                        {

                            TxtSanitario2.Text = TxtSanitario2.Text + Dgprincipal.Rows[i].Cells[7].Value.ToString();

                        }
                        if (i == 3)
                        {

                            TxtSanitario2.Text = TxtSanitario2.Text + " / " + Dgprincipal.Rows[i].Cells[7].Value.ToString();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RC1_CheckedChanged(object sender, EventArgs e)
        {
            
            Sanitarios();
            if (RC1.Checked)
            {
                LblCat.Text = "1";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC2_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC2.Checked)
            {
                LblCat.Text = "2";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC3_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC3.Checked)
            {
                LblCat.Text = "3";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC4_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC4.Checked)
            {
                LblCat.Text = "4";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC5_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC5.Checked)
            {
                LblCat.Text = "5";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC6_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC6.Checked)
            {
                LblCat.Text = "6";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC9_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC9.Checked)
            {
                LblCat.Text = "9";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC7_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC7.Checked)
            {
                LblCat.Text = "7";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC8_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC8.Checked)
            {
                LblCat.Text = "8";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void CmbLote_MouseClick(object sender, MouseEventArgs e)
        {
            CheFalse();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Dgprincipal.Rows.Clear();
            Dgprincipal.Refresh();
            GrupoCate.Enabled = false;
            if (CmbLote.SelectedIndex != 0)
            {
                LlenarGrid();
                LblLote.Text = CmbLote.SelectedValue.ToString();

            }
            this.Cursor = Cursors.Default;
            Dgprincipal.SelectAll();
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

        private void RC10_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC10.Checked)
            {
                LblCat.Text = "10";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC11_CheckedChanged(object sender, EventArgs e)
        {
            Sanitarios();
            if (RC11.Checked)
            {
                LblCat.Text = "11";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }

        private void RC12_CheckedChanged(object sender, EventArgs e)
        {
            if (RC12.Checked)
            {
                LblCat.Text = "12";
                BtnImprimir.Enabled = true;
            }
            else
            {
                LblCat.Text = "";
                BtnImprimir.Enabled = false;
            }
        }
    }
}

    
 

