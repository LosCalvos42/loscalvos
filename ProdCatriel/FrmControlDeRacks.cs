using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmControlDeRacks : Form
    {
        public FrmControlDeRacks()
        {
            InitializeComponent();
        }

        public string Vienede { get; set; }
        public int NROOT { get; set; }
        public string AlmacenControl { get; set; }
        public string Proceso { get; set; }
        public string RackCodbar { get; set; }
        DataTable dt = new DataTable();

        private void FrmImpresionRack_Load(object sender, EventArgs e)
        {
            //Tipo = this.Text;
            //id = Convert.ToInt32(this.Text.Split()[2]);
            Cargarcombo("ALMACEN", CmbAlmacen);
            Inicio();
        }
        private void limpiarObjetos() {
            
            
        }
        private void Inicio()
        {
            if (Vienede == "OT")
            { 
                CmbAlmacen.SelectedValue=AlmacenControl;
                TxtCodBar.Text = RackCodbar;
                CargarEtiqueta();
                //decimal Pesodecimal = 0;

                    //FrmPesada _FrmPesada = new FrmPesada
                    //{
                    //    StartPosition = FormStartPosition.CenterScreen,

                    //};
                    //_FrmPesada.ShowDialog();

                    //Pesodecimal = _FrmPesada.Pesodecimal;

            }
        }
        private bool valido()
        {
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
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_CargaCombos", lst);
                _combo.DataSource = dt;
                _combo.DisplayMember = "NOMBRE";
                _combo.ValueMember = "CODIGO";
                DataRow topItem = dt.NewRow();
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
        
        private void CargarEtiqueta()
        {
            try
            {
                LimpiaEtiqueta();
                ClsManejador M = new ClsManejador();
                //DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@tipo", "D"));
                lst.Add(new ClsParametros("@CATEGORIA", ""));
                lst.Add(new ClsParametros("@LOTE", ""));
                lst.Add(new ClsParametros("@NROOT", 0));
                lst.Add(new ClsParametros("@RACK_CODBAR", TxtCodBar.Text));
                dt = M.Listado("SP_GetRACK", lst);
                if (dt.Rows.Count > 0)
                {
                    LblLote.Text = dt.Rows[0][1].ToString();
                    LblCateg.Text = dt.Rows[0][2].ToString();
                    LblProbeedor.Text = dt.Rows[0][5].ToString();
                    LblCantidad.Text = dt.Rows[0][6].ToString();
                    LblNroRack.Text = dt.Rows[0][10].ToString();
                    LblControl.Text = dt.Rows[0][11].ToString();

                    //LblProceso5.Text = dt.Rows[0][0].ToString();
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    //Codigo.IncludeLabel = true;
                    //Codigo.LabelFont = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                    int minWidth = Math.Max(350, Codigo.EncodedValue.Length);
                    //return barcode.Encode(barcode.EncodedType, code, minWidth, 35);
                    lblCodigo.Text = dt.Rows[0][0].ToString();
                    panelCodbar.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, dt.Rows[0][0].ToString(), Color.Black, Color.White, minWidth, 50);
                    //Codigo.IncludeLabel = true;
                    panelCodbar.BackgroundImageLayout = ImageLayout.None;
                    //panelCodbar.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                LblProceso1.Text = dt.Rows[i][4].ToString();
                                LblKg1.Text = dt.Rows[i][7].ToString();
                                LblMerma1.Text = dt.Rows[i][9].ToString();
                                LblFecha1.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                            case 1:
                                LblProceso2.Text = dt.Rows[i][4].ToString();
                                LblKg2.Text = dt.Rows[i][7].ToString();
                                LblMerma2.Text = dt.Rows[i][9].ToString();
                                LblFecha2.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                            case 2:
                                LblProceso3.Text = dt.Rows[i][4].ToString();
                                LblKg3.Text = dt.Rows[i][7].ToString();
                                LblMerma3.Text = dt.Rows[i][9].ToString();
                                LblFecha3.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                            case 3:
                                LblProceso4.Text = dt.Rows[i][4].ToString();
                                LblKg4.Text = dt.Rows[i][7].ToString();
                                LblMerma4.Text = dt.Rows[i][9].ToString();
                                LblFecha4.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                            case 4:
                                LblProceso5.Text = dt.Rows[i][4].ToString();
                                LblKg5.Text = dt.Rows[i][7].ToString();
                                LblMerma5.Text = dt.Rows[i][9].ToString();
                                LblFecha5.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                            case 5:
                                LblProceso6.Text = dt.Rows[i][4].ToString();
                                LblKg6.Text = dt.Rows[i][7].ToString();
                                LblMerma6.Text = dt.Rows[i][9].ToString();
                                LblFecha6.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                            case 6:
                                LblProceso7.Text = dt.Rows[i][4].ToString();
                                LblKg7.Text = dt.Rows[i][7].ToString();
                                LblMerma7.Text = dt.Rows[i][9].ToString();
                                LblFecha7.Text = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                break;
                        }
                    }
                }
                else
                {
                    LimpiaEtiqueta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiaEtiqueta()
        {
            LblLote.Text = "";
            LblCateg.Text = "";
            LblProbeedor.Text = "";
            LblCantidad.Text = "";
            LblNroRack.Text = "";
            LblControl.Text = "";
            lblCodigo.Text = "";
            panelCodbar.BackgroundImage=null;
            panelCodbar.Refresh();

            LblProceso1.Text = "";
            LblKg1.Text = "";
            LblMerma1.Text = "";
            LblFecha1.Text = "";

            LblProceso2.Text = "";
            LblKg2.Text = "";
            LblMerma2.Text = "";
            LblFecha2.Text = "";

            LblProceso3.Text = "";
            LblKg3.Text = "";
            LblMerma3.Text = "";
            LblFecha3.Text = "";

            LblProceso4.Text = "";
            LblKg4.Text = "";
            LblMerma4.Text = "";
            LblFecha4.Text = "";

            LblProceso5.Text = "";
            LblKg5.Text = "";
            LblMerma5.Text = "";
            LblFecha5.Text = "";

            LblProceso6.Text = "";
            LblKg6.Text = "";
            LblMerma6.Text = "";
            LblFecha6.Text = "";

            LblProceso7.Text = "";
            LblKg7.Text = "";
            LblMerma7.Text = "";
            LblFecha7.Text = "";
        }

        private void BtnPrint1_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelCodbar.BackgroundImage == null)
                {
                    return;
                }
                Imprimir();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Imprimir()
        {
            string NombreImpresora = Program.IMPRESORAETIQUETA;
            if (NombreImpresora != null)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(Pr_PrintPage);
                // Especifica que impresora se utilizara!!
                pd.PrinterSettings.PrinterName = NombreImpresora;
                PageSettings pa = new PageSettings();
                pa.Margins = new Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 400, 900);
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

        private void Pr_PrintPage(Object sender, PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font Titulos = new Font("Arial", 32, FontStyle.Regular))//Formato
                using (Font TDatos = new Font("Arial Black", 28, FontStyle.Bold))//Formato
                using (Font TDatos2 = new Font("Impact", 24, FontStyle.Regular))//Formato
                using (Font Lblcodbar = new Font("Arial", 12, FontStyle.Regular))//Formato
                using (Font headers = new Font("Arial", 14, FontStyle.Underline))//Formato
                using (Font children = new Font("Arial", 12, FontStyle.Regular))//Formato
                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();

                    /*Feha De Clasificado*/
                    string caption = "";
                    LblNroRack.Text = dt.Rows[0][10].ToString();
                    LblControl.Text = dt.Rows[0][11].ToString();
                    LblLote.Text = dt.Rows[0][1].ToString();
                    LblCateg.Text = dt.Rows[0][2].ToString();
                    LblProbeedor.Text = dt.Rows[0][5].ToString();

                    LblCantidad.Text = dt.Rows[0][6].ToString();

                    /*Rack*/
                    caption = "Rack:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 5, 10);//posicion del texto
                    caption = string.Format("{0}", dt.Rows[0][10].ToString());
                    g.DrawString(caption, TDatos, System.Drawing.Brushes.Black, 120, 10);

                    caption = "";
                    g.DrawString(caption, TDatos2, System.Drawing.Brushes.Black, 5, 10);//posicion del texto
                    caption = string.Format("{0}", dt.Rows[0][11].ToString());
                    g.DrawString(caption, TDatos2, System.Drawing.Brushes.Black, 270, 12);




                    /*Lote*/
                    caption = "Lote:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 5, 60);
                    caption = string.Format("{0}", dt.Rows[0][1].ToString());
                    g.DrawString(caption, TDatos, System.Drawing.Brushes.Black, 130, 60);

                    caption = "Categoria:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 5, 110);
                    caption = string.Format("{0}", dt.Rows[0][2].ToString());
                    g.DrawString(caption, TDatos, System.Drawing.Brushes.Black, 230, 110);

                    caption = "proveedor:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 5, 155);
                    caption = string.Format("{0}", dt.Rows[0][5].ToString());
                    g.DrawString(caption, TDatos2, System.Drawing.Brushes.Black, 5, 210);

                    caption = "Cantidad:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 5, 245);
                    caption = string.Format("{0}", dt.Rows[0][6].ToString());
                    g.DrawString(caption, TDatos, System.Drawing.Brushes.Black, 200, 245);

                    caption = "  Proceso             KG        Merma     Fecha   ";
                    g.DrawString(caption, headers, System.Drawing.Brushes.Black, 5, 300);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:

                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 320);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 320);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 320);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 320);
                                break;
                            case 1:
                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 340);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 340);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 340);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 340);
                                break;
                            case 2:
                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 360);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 360);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 360);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 360);
                                break;
                            case 3:
                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 380);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 380);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 380);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 380);
                                break;
                            case 4:
                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 400);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 400);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 400);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 400);
                                break;
                            case 5:
                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 420);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 420);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 420);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 420);
                                break;
                            case 6:
                                caption = dt.Rows[i][4].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 5, 440);

                                caption = dt.Rows[i][7].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 150, 440);


                                caption = dt.Rows[i][9].ToString();
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 230, 440);

                                caption = Convert.ToDateTime(dt.Rows[i][3]).ToString("dd/MM/yyyy");
                                g.DrawString(caption, children, System.Drawing.Brushes.Black, 300, 440);
                                break;
                        }
                    }

                    g.DrawImage(Codigo.Encode(BarcodeLib.TYPE.CODE128, dt.Rows[0][0].ToString(), Color.Black, Color.White, 400, 65), -8, 700);//CODBAR
                    caption = string.Format("{0}", dt.Rows[0][0].ToString());
                    g.DrawString(caption, Lblcodbar, System.Drawing.Brushes.Black, 125, 770);

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmImpresoras _FrmImpresoras = new FrmImpresoras();
            _FrmImpresoras.StartPosition = FormStartPosition.CenterScreen;
            _FrmImpresoras.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelCodbar.BackgroundImage == null)
            {
                return;
            }
            decimal Pesodecimal = 0;
            FrmPesada _FrmPesada = new FrmPesada
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _FrmPesada.ShowDialog();

            Pesodecimal = _FrmPesada.Pesodecimal;
            // INSERT RACKITEMS SELECT @RACK_CODBAR,@FECHAPROD,@PROCESO,@CANTIDAD,@KILOSRACK,@USR_ID,'N'
            ClsManejador ME = new ClsManejador();
            ME.Ejecutarquery("INSERT RACKITEMS values ('"+ RackCodbar +"','" + DateTime.Now.ToString("yyyyMMdd") + "','"+ Proceso +"'," + NROOT + ",'" + Convert.ToString(CmbAlmacen.SelectedValue) + "'," + LblCantidad.Text+", REPLACE('"+Pesodecimal+"', ',', '.')"  +","+Program.IDUSER+",'N')");
            CargarEtiqueta();
            Imprimir();


        }
    }
}

    
 

