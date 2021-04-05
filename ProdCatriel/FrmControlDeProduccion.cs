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
//using System.Windows.Forms.DataVisualization.Charting;

namespace LOSCALVOS
{
    public partial class FrmControlDeProduccion : Form
    {
        public FrmControlDeProduccion()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }


        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            //chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Cargarcombo("PRODUCTO", CmbProducto,"");
            Cargarcombo("ALMACEN", CmbAlmacen, ""); 
                    CmbAlmacen.SelectedValue = "CA001"; ///Provisorio
            Cargarcombo("PROCESO", CmdProceso, "");  
                    CmdProceso.SelectedValue = "SALIDA01";///Provisorio
            Cargarcombo("SECTOR", CmdSector, "");   
                    //CmdSector.SelectedValue = "JM001";///Provisorio
            Inicio();

        }
        private void limpiarObjetos() {
            
            //TxtCodigo.Text = "";
            //TxtDescripcion.Text = "";
            //TxtObs.Text = "";
        }

        private void CargaraGrilla()
        {
            //CATEG = CmbCategoria.SelectedValue.ToString();
            Dgprincipal.Rows.Clear();
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Fecha",DtProduccion.Value.ToString("yyyyMMdd")));
                dt = M.Listado("SP_GetProduccion", lst);
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
                        Dgprincipal.Rows[i].Cells[8].Value = dt.Rows[i][8].ToString();
                    }
                    //Dgprincipal.DataSource = dt;
                    //Dgprincipal.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(142, 68, 173);
                    //Dgprincipal.Columns[0].DefaultCellStyle.ForeColor = Color.White;
                    //Dgprincipal.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 188);
                    //Dgprincipal.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(178, 235, 242);
                    //Dgprincipal.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(197, 202, 233);
                    //Dgprincipal.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                    //Dgprincipal.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                    //Dgprincipal.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 128);
                    Dgprincipal.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                    Dgprincipal.ClearSelection();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargarcombo(string combo, ComboBox _combo,string filtro)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", filtro));
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

        private void Inicio()
        {
           limpiarObjetos();
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"SELECT DISPOSITIVO_SECTOR" +
                            " FROM [DISPOSITIVOS] " +
                            " WHERE DISPOSITIVO_NROSERIE = '" + Program.SerialPC + "' " +
                            " AND DISPOSITIVO_NOMBRE= '" + Program.HostName + "'";
            dt = M.lisquery(ssql);

            if (dt.Rows.Count > 0)
            {
                CmdSector.SelectedValue = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("El Sector No esta Configurado.", "Sector", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor;
                CheckForIllegalCrossThreadCalls = false;
                FrmAddDispositivo _FrmAddDispositivo = new FrmAddDispositivo();
                _FrmAddDispositivo.StartPosition = FormStartPosition.CenterScreen;
                
                if (_FrmAddDispositivo.ShowDialog() == DialogResult.OK)
                {
                    Inicio();
                }
            }
        }
        private String[] AbmUser(string tipo)
        {

            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo","NUEVO"));
                lst.Add(new ClsParametros("@FECHAPROD", DtProduccion.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@SECTOR", CmdSector.SelectedValue));
                lst.Add(new ClsParametros("@ALMACEN", CmbAlmacen.SelectedValue));
                lst.Add(new ClsParametros("@PROCESO", CmdProceso.SelectedValue));
                lst.Add(new ClsParametros("@CODPROD", TxtCodProd.Text));
                lst.Add(new ClsParametros("@LOTE", TxtLote.Text));
                lst.Add(new ClsParametros("@CANTIDAD", Convert.ToInt32(TxtCantidad.Text)));
                lst.Add(new ClsParametros("@BRUTO", Convert.ToString(Convert.ToDecimal(TxtKBruto.Text)).Replace(",", ".")));
                lst.Add(new ClsParametros("@TARA", Convert.ToString(Convert.ToDecimal(TxtTara.Text)).Replace(",", ".")));
                lst.Add(new ClsParametros("@NETO", Convert.ToString(Convert.ToDecimal(TxtkNeto.Text)).Replace(",", ".")));
                lst.Add(new ClsParametros("@USR_ID ", Program.IDUSER));
                lst.Add(new ClsParametros("@DEBAJA","N"));
                lst.Add(new ClsParametros("@FECHAVTO", DtVto.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 20));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_AddControlProduccion", ref lst);
                msj = new string[2];
                msj[0] = lst[14].Valor.ToString();
                msj[1] = lst[15].Valor.ToString();
            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = "0";
                msj[1] = ex.Message;

            }
            return msj;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Tipo == "MODIFICAR")
            {
                if (MessageBox.Show("¿Confirma que desea Modificar El Registro?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (Tipo == "CONSULTAR")
            {
                DialogResult = DialogResult.No;
                this.Close();
                return;
            }
            try
            {
                if (valido() == true)
                {
                    string[] msg = AbmUser(Tipo);


                    if (msg[0] == "0")
                    {

                        MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {

                        MessageBox.Show(msg[1], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Yes;
                        this.Close();
                        return;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Dgprincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgprincipal.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargaraGrilla();
        }

        private void CmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // Cargarcombo("CATEGORIAS", CmbCategoria, CmbProducto.SelectedValue.ToString());
        }

        private void BtnBalanzaAceptar_Click(object sender, EventArgs e)
        {
            if (valido() == true)
            {
                string[] msg = AbmUser(Tipo);


                if (msg[0] == "0")
                {

                    MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                   // MessageBox.Show(msg[1]  + msg[0], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    AddFila(msg[0]);
                    if (ChekFprod.Checked==false)
                    {
                        TxtCodProd.Text = "";
                        TxtBuscar.Text = "";
                    }
                    if (ChekFLote.Checked == false)
                    {
                        TxtLote.Text = "";
                    }
                    if (ChekFUni.Checked == false)
                    {
                        TxtCantidad.Text = "0";
                    }
                    if (ChekFTara.Checked == false)
                    {
                        TxtTara.Text = "";
                    }
                    TxtKBruto.Text = "0";
                    int Neto = Convert.ToInt32(TxtKBruto.Text) - Convert.ToInt32(TxtTara.Text);
                    TxtkNeto.Text = Convert.ToString(Neto);

                    return;
                }

            }
        }

        private void AddFila(String Codbar)
        {
            
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@codbar", Codbar));
            //lst.Add(new ClsParametros("@CATEGORIA", radioButton1.Checked));
            dt = M.Listado("SP_GetInfoCodbar", lst);
            if (dt.Rows.Count > 0)
            {
                Dgprincipal.Rows.Add(1);
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[0].Value = dt.Rows[0][0].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[1].Value = dt.Rows[0][1].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[2].Value = dt.Rows[0][2].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[3].Value = dt.Rows[0][3].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[4].Value = dt.Rows[0][4].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[5].Value = dt.Rows[0][5].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[6].Value = dt.Rows[0][6].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[7].Value = dt.Rows[0][7].ToString();
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[8].Value = dt.Rows[0][8].ToString();
                Dgprincipal.ClearSelection();
                Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                Dgprincipal.Refresh();

                Imprimir(dt);
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
                    tsw.WriteLine(@"^FT47,158^A0N,88,50^FH\^FD" + dt.Rows[0][2].ToString() + "^FS");
                    tsw.WriteLine(@"^FT46,71^A0N,62,67^FH\^FDCODIGO:^FS");
                    tsw.WriteLine(@"^FT115,261^A0N,42,33^FH\^FD" + dt.Rows[0][6].ToString() + "^FS");
                    tsw.WriteLine(@"^FT115,211^A0N,46,33^FH\^FD"+ dt.Rows[0][5].ToString() +"^FS");
                    tsw.WriteLine(@"^FT40,264^A0N,44,28^FH\^FDTara:^FS");
                    tsw.WriteLine(@"^FT469,260^A0N,111,64^FH\^FD" + dt.Rows[0][7].ToString() + " kg^FS");
                    tsw.WriteLine(@"^FT357,246^A0N,56,45^FH\^FD" + dt.Rows[0][4].ToString() + "^FS");
                    tsw.WriteLine(@"^FT40,211^A0N,44,28^FH\^FDBruto:^FS");
                    tsw.WriteLine(@"^FT221,245^A0N,56,62^FH\^FDCant:^FS");
                    tsw.WriteLine(@"^FT464,350^A0N,28,30^FH\^FDFecha: " + dt.Rows[0][9].ToString() + "^FS");
                    tsw.WriteLine(@"^FT464,385^A0N,28,30^FH\^FD  Vto.:" + dt.Rows[0][10].ToString() + "^FS");
                    tsw.WriteLine(@"^FT524,315^A0N,30,38^FH\^FD" + dt.Rows[0][3].ToString() + "^FS");
                    tsw.WriteLine(@"^FT463,315^A0N,23,26^FH\^FDLote:^FS");
                    tsw.WriteLine(@"^FT75,392^A0N,36,45^FH\^FD" + dt.Rows[0][8].ToString() + "^FS");
                    tsw.WriteLine(@"^FT284,72^A0N,74,67^FH\^FD"+ dt.Rows[0][1].ToString() + "^FS");
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
        private bool valido()
        {
            if (CmdProceso.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (PROCESO)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmdProceso.Focus();
                return false;
            }
            if (CmdSector.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (Sector)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmdSector.Focus();
                return false;
            }
            if (CmbAlmacen.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (ALMACEN)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbAlmacen.Focus();
                return false;
            }
            if (TxtCodProd.Text == "")
            {
                MessageBox.Show("Hay Datos Sin completar (PRODUCTO)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtBuscar.Focus();
                return false;
            }

            if (TxtLote.Text == "")
            {
                MessageBox.Show("Hay Datos Sin completar (Lote)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtLote.Focus();
                return false;
            }
            if (TxtCantidad.Text == "0")
            {
                MessageBox.Show("Cantidad No puede ser Menor o Igual a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCantidad.Focus();
                return false;
            }
            if (TxtKBruto.Text == "0")
            {
                MessageBox.Show("El Peso No puede ser Menor o Igual a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtKBruto.Focus();
                return false;
            }
            if (TxtkNeto.Text == "0")
            {
                MessageBox.Show("El Peso No puede ser Menor o Igual a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtKBruto.Focus();
                return false;
            }
            return true;
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    try
            //    {
            //        if (TxtCantidad.Text != "")
            //        {
            //            double n = Convert.ToDouble(TxtCantidad.Text.Replace(".", ","));
            //            TxtCantidad.Text = string.Format("{0:n}", n);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    e.Handled = true;
            //}

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13))
            {
                //MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtKBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)  && (e.KeyChar != (char)13))
            {
                //MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void TxtKBruto_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtKBruto.Text == ""|| TxtKBruto.Text == "0,00")
            {
                TxtKBruto.Text = "0";
                
            }

            int Neto = Convert.ToInt32(TxtKBruto.Text) - Convert.ToInt32(TxtTara.Text);
            TxtkNeto.Text = Convert.ToString(Neto);
        }
        private void TxtKBruto_TextChanged(object sender, EventArgs e)
        {
            if (TxtKBruto.Text == "")
            {
                TxtKBruto.Text = "0";
                TxtKBruto.SelectAll();
            }
        }
        private void TxtKBruto_Click(object sender, EventArgs e)
        {
                TxtKBruto.SelectAll();
        }

        private void TxtTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13))
            {
               // MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // e.Handled = true;
                return;
            }
        }

        private void TxtTara_KeyUp(object sender, KeyEventArgs e)
        {
            decimal Neto = Convert.ToDecimal(TxtKBruto.Text) - Convert.ToDecimal(TxtTara.Text);
            TxtkNeto.Text = Convert.ToString(Neto);
        }
        private void TxtTara_TextChanged(object sender, EventArgs e)
        {
            if (TxtTara.Text == "")
            {
                TxtTara.Text = "0";
                TxtTara.SelectAll();
            }
           
        }
        private void TxtTara_Click(object sender, EventArgs e)
        {
            TxtTara.SelectAll();
        }
        private void ChekFTara_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekFTara.Checked == true)
            {
                TxtTara.ReadOnly = true;
            }
            else
            {
                TxtTara.ReadOnly = false;
            }
        }
        private void ChekFUni_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekFUni.Checked == true)
            {
               TxtCantidad.ReadOnly = true;
            }
            else
            {
                TxtCantidad.ReadOnly = false;
            }
        }

        private void meliminar_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("¿Confirma que desea ELIMINAR esta pieza!!!?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                string[] msg = RemovMovCodBar(Dgprincipal.Rows[Dgprincipal.CurrentRow.Index].Cells[8].Value.ToString());

                if (msg[0] == "0")
                {

                    MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    MessageBox.Show(msg[1], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Dgprincipal.Rows.RemoveAt(Dgprincipal.CurrentRow.Index);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Item para Eliminar.", "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private String[] RemovMovCodBar(string CODBAR)
        {
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            List<ClsParametros> lst2 = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@CODBAR", CODBAR));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_RemovMovCodBar", ref lst);
                msj = new string[2];
                msj[0] = lst[1].Valor.ToString();
                msj[1] = lst[2].Valor.ToString();
            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = "0";
                msj[1] = ex.Message;
            }
            return msj;
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar
            {
                StartPosition = FormStartPosition.CenterScreen,
                combo = "PRODUCTOBUSCAR"
            };
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {
                TxtBuscar.Text = _FrmGrillaBuscar.Codigo + " - "+_FrmGrillaBuscar.nombre;
               // txtDescrip.Text = _FrmGrillaBuscar.nombre;
                TxtCodProd.Text = _FrmGrillaBuscar.Codigo;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmImpresoras _FrmImpresoras = new FrmImpresoras();
            _FrmImpresoras.StartPosition = FormStartPosition.CenterScreen;
            _FrmImpresoras.ShowDialog();
        }

        private void mimprimir_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection Seleccionados = Dgprincipal.SelectedRows;

                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();

            foreach (DataGridViewRow item in Seleccionados)
            {
                dt.Clear();
                lst.Clear();
                string id = item.Cells[8].Value.ToString();

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
        private void button2_Click(object sender, EventArgs e)
        {
            
            if( Program.BALANZA.Length>4) { 
            
            FrmPesadaIP _FrmPesada = new FrmPesadaIP
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
                _FrmPesada.ShowDialog();
                TxtKBruto.Text = Convert.ToString(Convert.ToDecimal(Math.Round(_FrmPesada.Pesodecimal)).ToString("N2"));
                decimal Neto = Convert.ToDecimal(TxtKBruto.Text) - Convert.ToDecimal(TxtTara.Text);
                TxtkNeto.Text = Convert.ToString(Neto);
            }
            else
            {
                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.ShowDialog();

                TxtKBruto.Text = Convert.ToString(Convert.ToDecimal(Math.Round(_FrmPesada.Pesodecimal)).ToString("N2"));
                decimal Neto = Convert.ToDecimal(TxtKBruto.Text) - Convert.ToDecimal(TxtTara.Text);
                TxtkNeto.Text = Convert.ToString(Neto);
            }
        }

        private void ChekManual_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekManual.Checked == true)
            {
                TxtKBruto.ReadOnly = false;
            }
            else
            {
                TxtKBruto.ReadOnly = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    
 

