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
    public partial class FrmImpresionPallet : Form
    {
        public FrmImpresionPallet()
        {
            InitializeComponent();
        }

        public int Tipo { get; set; }
        public int NROOT { get; set; }
        public string Lote{ get; set; }
        public string Categoria{ get; set; }
        public string RackCodbar { get; set; }
        DataTable dt = new DataTable();

        private void FrmImpresionRack_Load(object sender, EventArgs e)
        {
            //Tipo = this.Text;
            //id = Convert.ToInt32(this.Text.Split()[2]);
            Inicio();
        }
        private void limpiarObjetos() {
            
            
        }
        private void Inicio()
        {
            GargarGrid();
            Dgprincipal.ClearSelection();
            Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[0].Selected=true;
            Dgprincipal.Refresh();


            //CargarEtiqueta(1);
            if (Tipo == 1)
            {
                CargarEtiqueta(1);
                Dgprincipal.Refresh();
                 BtnPrint1.PerformClick();
                this.Close();
                Tipo = 0;
            }else
            {
                CargarEtiqueta(1);
            }

        }
        private bool valido()
        {
            
            return true;
        }
        private void GargarGrid()
        {
            try
            {
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@tipo", "C"));
                lst.Add(new ClsParametros("@CATEGORIA", Categoria));
                lst.Add(new ClsParametros("@NROOT", NROOT));
                lst.Add(new ClsParametros("@RACK_CODBAR",RackCodbar));
                dt = M.Listado("SP_GetPallet", lst);
                if (dt.Rows.Count > 0)
                {
                    Dgprincipal.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }
        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }
        private void CargarEtiqueta(int vienede)
        {
            try
            {
                LimpiaEtiqueta();
                ClsManejador M = new ClsManejador();
                //DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@tipo", "D"));
                lst.Add(new ClsParametros("@CATEGORIA", Categoria));
                //lst.Add(new ClsParametros("@LOTE", Lote));
                lst.Add(new ClsParametros("@NROOT", NROOT));

                if (vienede == 0)
                {
                    lst.Add(new ClsParametros("@RACK_CODBAR", Dgprincipal.CurrentRow.Cells[0].Value.ToString()));
                }
                else
                {
                    lst.Add(new ClsParametros("@RACK_CODBAR", Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[0].Value.ToString()));

                }
               
                dt = M.Listado("SP_GetPallet", lst);
                if (dt.Rows.Count > 0)
                {


                    LblNroRack.Text = dt.Rows[0][0].ToString();
                    LblCateg.Text = dt.Rows[0][2].ToString();
                    LblCantidad.Text = dt.Rows[0][3].ToString();
                    LblKinicio.Text= dt.Rows[0][4].ToString();
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    //Codigo.IncludeLabel = true;
                    //Codigo.LabelFont = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                    int minWidth = Math.Max(350, Codigo.EncodedValue.Length);
                    //return barcode.Encode(barcode.EncodedType, code, minWidth, 35);
                    lblCodigo.Text = dt.Rows[0][1].ToString();
                    panelCodbar.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, dt.Rows[0][1].ToString(), Color.Black, Color.White, minWidth, 50);
                    //Codigo.IncludeLabel = true;
                    panelCodbar.BackgroundImageLayout = ImageLayout.None;
                    //panelCodbar.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                LblProceso1.Text = dt.Rows[i][5].ToString();
                                LblKg1.Text = dt.Rows[i][6].ToString();
                                LblMerma1.Text = dt.Rows[i][7].ToString();
                                LblFecha1.Text = Convert.ToDateTime(dt.Rows[i][8]).ToString("dd/MM/yyyy");
                                break;
                            case 1:
                                LblProceso2.Text = dt.Rows[i][5].ToString();
                                LblKg2.Text = dt.Rows[i][6].ToString();
                                LblMerma2.Text = dt.Rows[i][7].ToString();
                                LblFecha2.Text = Convert.ToDateTime(dt.Rows[i][8]).ToString("dd/MM/yyyy");
                                break;
                            case 2:
                                LblProceso3.Text = dt.Rows[i][5].ToString();
                                LblKg3.Text = dt.Rows[i][6].ToString();
                                LblMerma3.Text = dt.Rows[i][7].ToString();
                                LblFecha3.Text = Convert.ToDateTime(dt.Rows[i][8]).ToString("dd/MM/yyyy");
                                break;
                            case 3:
                                LblProceso4.Text = dt.Rows[i][5].ToString();
                                LblKg4.Text = dt.Rows[i][6].ToString();
                                LblMerma4.Text = dt.Rows[i][7].ToString();
                                LblFecha4.Text = Convert.ToDateTime(dt.Rows[i][8]).ToString("dd/MM/yyyy");
                                break;
                            case 4:
                                LblProceso5.Text = dt.Rows[i][5].ToString();
                                LblKg5.Text = dt.Rows[i][6].ToString();
                                LblMerma5.Text = dt.Rows[i][7].ToString();
                                LblFecha5.Text = Convert.ToDateTime(dt.Rows[i][8]).ToString("dd/MM/yyyy");
                                break;
                            case 5:
                                LblProceso6.Text = dt.Rows[i][5].ToString();
                                LblKg6.Text = dt.Rows[i][6].ToString();
                                LblMerma6.Text = dt.Rows[i][7].ToString();
                                LblFecha6.Text = Convert.ToDateTime(dt.Rows[i][8]).ToString("dd/MM/yyyy");
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
            //LblLote.Text = "";
            LblCateg.Text = "";
            //LblProbeedor.Text = "";
            LblCantidad.Text = "";
            LblNroRack.Text = "";
            //LblControl.Text = "";
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
            string impresora = @"\\localhost\" + Program.IMPRESORAETIQUETA;
            if (impresora != null)
            {
                foreach (DataGridViewRow r in Dgprincipal.SelectedRows)
                {
                    
                    string inputFilePath = Application.StartupPath + @"\Reportes\RackEstucado.E05";
                    TextWriter tsw = new StreamWriter(inputFilePath);
                    tsw.WriteLine(@"^XA");
                    tsw.WriteLine(@"^XA");
                    tsw.WriteLine(@"^PW831");
                    tsw.WriteLine(@"^FO413,707^GB0,143,1^FS");
                    tsw.WriteLine(@"^FT18,55^A0N,34,33^FH\^FDRack:^FS");
                    tsw.WriteLine(@"^FT671,914^A0N,39,38^FH\^FDFecha:^FS");

                    tsw.WriteLine(@"^FT610,971^A0N,39,38^FH\^FD"+ Convert.ToDateTime(dt.Rows[0][8]).ToString("dd/MM/yyyy")+"^FS");
                    tsw.WriteLine(@"^FT585,1267^A0N,39,38^FH\^FD" + Convert.ToDateTime(dt.Rows[2][8]).ToString("dd/MM/yyyy") + "^FS");
                    tsw.WriteLine(@"^FT359,1265^A0N,28,9^FH\^FD--------------------^FS");
                    tsw.WriteLine(@"^FT584,1185^A0N,39,38^FH\^FD" + Convert.ToDateTime(dt.Rows[1][8]).ToString("dd/MM/yyyy") + "^FS");
                    tsw.WriteLine(@"^FT360,1183^A0N,28,9^FH\^FD--------------------^FS");
                    tsw.WriteLine(@"^FT476,973^A0N,39,38^FH\^FD"+dt.Rows[0][7].ToString()+"^FS");
                    tsw.WriteLine(@"^FT226,1119^A0N,45,45^FH\^FDTrabajos Pendientes:^FS");
                    tsw.WriteLine(@"^FT45,1270^A0N,39,38^FH\^FD"+dt.Rows[2][5].ToString()+ "^FS");
                    tsw.WriteLine(@"^FT45,1185^A0N,39,38^FH\^FD" + dt.Rows[1][5].ToString() + "^FS");
                    tsw.WriteLine(@"^FT267,970^A0N,36,36^FH\^FD" + dt.Rows[0][6].ToString() + "^FS");
                    tsw.WriteLine(@"^FT16,967^A0N,34,40^FH\^FD" + dt.Rows[0][5].ToString() + "^FS");
                    tsw.WriteLine(@"^FT475,914^A0N,39,38^FH\^FDMerma:^FS");
                    tsw.WriteLine(@"^FT329,911^A0N,39,38^FH\^FDKg:^FS");
                    tsw.WriteLine(@"^FT22,913^A0N,39,38^FH\^FDProceso:^FS");
                    tsw.WriteLine(@"^FT88,755^A0N,46,76^FH\^FDCantidad:^FS");
                    tsw.WriteLine(@"^FT456,752^A0N,44,60^FH\^FDKg Iniciales:^FS");
                    tsw.WriteLine(@"^FT506,831^A0N,62,60^FH\^FD" + dt.Rows[0][4].ToString() + "^FS");
                    tsw.WriteLine(@"^FT187,838^A0N,73,81^FH\^FD" + dt.Rows[0][3].ToString() + "^FS");
                    tsw.WriteLine(@"^FT103,54^A0N,34,45^FH\^FD" + dt.Rows[0][0].ToString() + "^FS");
                    tsw.WriteLine(@" ^BY3,5,150^FT130,1560^BCN,,Y,N");
                    tsw.WriteLine(@"^FD>:" + dt.Rows[0][1].ToString() + "^FS");
                    tsw.WriteLine(@"^FT176,622^A0N,603,748^FH\^FDA^FS");
                    tsw.WriteLine(@"^FO21,1127^GB783,166,5^FS");
                    tsw.WriteLine(@"^FO25,854^GB802,0,1^FS");
                    tsw.WriteLine(@"^FO9,692^GB802,0,2^FS");
                    tsw.WriteLine(@"^PQ1,0,1,Y^XZ");

                    tsw.Close();
                    PrintDocument pd = new PrintDocument();
                    pd.PrinterSettings.PrinterName = "ZebraZM4";
                    PageSettings pa = new PageSettings();
                    pa.Margins = new Margins(0, 0, 0, 0);
                    pd.DefaultPageSettings.Margins = pa.Margins;
                    PaperSize ps = new PaperSize("Custom", 1000, 2000);
                    pd.DefaultPageSettings.PaperSize = ps;
                    string printerPath = impresora;
                    System.IO.File.Copy(inputFilePath, printerPath, true);

                }

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
                   // LblControl.Text = dt.Rows[0][11].ToString();
                    //LblLote.Text = dt.Rows[0][1].ToString();
                    LblCateg.Text = dt.Rows[0][2].ToString();
                    //LblProbeedor.Text = dt.Rows[0][5].ToString();

                    LblCantidad.Text = dt.Rows[0][6].ToString();

                    /*Rack*/
                    caption = "Rack:";
                    g.DrawString(caption, Titulos, System.Drawing.Brushes.Black, 5, 10);//posicion del texto
                    caption = string.Format("{0}", dt.Rows[0][10].ToString());
                    g.DrawString(caption, TDatos, System.Drawing.Brushes.Black, 130, 10);

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

        private void Dgprincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarEtiqueta(Tipo);
        }
    }
}

    
 

