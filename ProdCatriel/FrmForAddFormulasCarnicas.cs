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

namespace LOSCALVOS
{
    public partial class FrmForAddFormulasCarnicas : Form
    {
        public FrmForAddFormulasCarnicas()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }

        public string PrecioAnterior { get; set; }

        public decimal totalCarnicos = 0; 
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            //Tipo = this.Text;
            Tipo = this.Text.Split()[0];
            id = Convert.ToInt32(this.Text.Split()[2]);
            Cargarcombo("FOR_TIPOFORMULA", CmbClasificacion);
            //Cargarcombo("UNIMED", CmbUnimed);
            Inicio();
        }
        private void limpiarObjetos() {

            TxtProducto.Text = "";
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtKEsperados.Text = "";
            TxtMerma.Text = "";
            TxtMinutos.Text = "";
            TxtObservacion.Text = "";
            TxtPesoTotal.Text = "";
            TxtPeso.Text = "";
            TxtUniEsperadas.Text = "";
            TxtCantidadItems.Text = "";
            Dgprincipal.DataSource = null;
            DgVersiones.DataSource = null;
            Dgprincipal.Rows.Clear();

        }
        private void Inicio()
        {
            if (Tipo == "NUEVO")
            {
                id = 0;
                limpiarObjetos();
                TxtVercion.Text = "1";
                chekActivo.Checked = true;
                RVigSi.Checked= true;
                groupBox1.Enabled = true;
            }
            if (Tipo == "MODIFICAR")
            {
                limpiarObjetos();
                groupBox1.Enabled = true;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    string HayVigente="NO";
                    lst.Add(new ClsParametros("@listado", "FORMULAVERSION"));
                    lst.Add(new ClsParametros("@Filtro", ""));
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@DeBaja", ""));
                    //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                    //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                    dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                    DgVersiones.DataSource= null;
                    if (dt.Rows.Count > 0)
                    {
                        DgVersiones.DataSource = dt;

                        for(int i = 0; i < DgVersiones.Rows.Count; i++)
                        {
                            if (DgVersiones.Rows[i].Cells[5].Value.ToString()=="S")
                            {
                                CargaDeDatos(Convert.ToInt32(DgVersiones.Rows[i].Cells[1].Value.ToString()));

                                DgVersiones.ClearSelection();
                                DgVersiones.Rows[i].Selected = true;
                                HayVigente = "Si";
                                DgVersiones.Refresh();
                                break;
                            }
                        }
                        if (HayVigente != "Si")
                        {
                            CargaDeDatos(Convert.ToInt32(DgVersiones.Rows[DgVersiones.Rows.Count-1].Cells[1].Value.ToString()));
                        }
                        
                        //DgVersiones.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Tipo == "CONSULTAR")
            {
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    lst.Add(new ClsParametros("@listado", "FOR_ARTI"));
                    lst.Add(new ClsParametros("@Filtro", ""));
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@DeBaja", ""));
                    //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                    //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                    dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                    if (dt.Rows.Count > 0)
                    {

                        TxtCodigo.Text = dt.Rows[0][1].ToString();//,A.[ALMACEN_CODIGO] CODIGO
                        TxtDescripcion.Text = dt.Rows[0][2].ToString();//,A.[ALMACEN_DESCRIPCION] DESCRIPCION
                        CmbClasificacion.SelectedValue = dt.Rows[0][3].ToString();
                        //CmbUnimed.SelectedValue = dt.Rows[0][4].ToString();
                        //TxtPrecio.Text = dt.Rows[0][6].ToString();
                        //PrecioAnterior = TxtPrecio.Text;
                        if (dt.Rows[0][7].ToString() == "N")
                        {
                            chekActivo.Checked = true;
                        }
                        else
                        {
                            chekActivo.Checked = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                groupBox1.Enabled = false;
            }
        }

        private void CalculaTotales()
        {
            try
            {
                int CantidadItems = 0;
                decimal peso = 0;
                decimal Merma = 0;
                decimal costototal = 0;

                totalCarnicos = 0;

                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {
                    //if ((Dgprincipal.Rows[i].Cells[8].Value == null))
                    //{
                    //    Dgprincipal.Rows[i].Cells[8].Value = " ";
                    //}
                    CantidadItems = CantidadItems + 1;
                    //if ((Dgprincipal.Rows[i].Cells[8].Value.ToString()) == "+")
                    //{
                    //    peso += Convert.ToDecimal(Dgprincipal.Rows[i].Cells[7].Value.ToString());

                    //    //if (Dgprincipal.Rows[i].Cells[10].Value.ToString() == "1" || Dgprincipal.Rows[i].Cells[10].Value.ToString() == "2")
                    //    //{
                    //    //    totalCarnicos+= Convert.ToDecimal(Dgprincipal.Rows[i].Cells[7].Value.ToString());
                    //    //}
                    //}
                        
                        Dgprincipal.EndEdit();

                    if (Dgprincipal.Rows[i].Cells[1].Value.ToString() == "004686")
                    {
                        Merma += Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value.ToString());
                    }
                    else
                    {
                        peso += Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value.ToString());
                    }
                        
                    
                    //costototal += Convert.ToDecimal(Dgprincipal.Rows[i].Cells[9].Value.ToString());
                    ////TxtCantidadItems.Text = CantidadItems.ToString();

                }
                TxtCantidadItems.Text = Convert.ToString(CantidadItems.ToString("N0"));
                TxtPeso.Text = Convert.ToString(peso.ToString("N2"));
                TxtPesoTotal.Text = Convert.ToString((peso - Merma).ToString("N2"));
                TxtMerma.Text = Convert.ToString(Merma.ToString("N2"));
               // TxtCostoTotal.Text = Convert.ToString(costototal.ToString("N2"));
                //TxtCostoUnitario.Text = Convert.ToString((costototal / Convert.ToDecimal(TxtPesoTotal.Text)).ToString("N2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaDeDatos(int Version)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@listado", "FORMULA_ABM"));
                lst.Add(new ClsParametros("@Filtro", Version));
                lst.Add(new ClsParametros("@id", id));
                lst.Add(new ClsParametros("@DeBaja", ""));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                if (dt.Rows.Count > 0)
                {
                    CmbClasificacion.SelectedValue = dt.Rows[0][0].ToString();
                    DtProduccion.Value= Convert.ToDateTime(dt.Rows[0][1].ToString());
                    if (dt.Rows[0][2].ToString() == "S")
                    {
                        RVigSi.Checked = true;
                        
                    }
                    else
                    {
                        RVigNo.Checked = true;
                    }

                    TxtVercion.Text = dt.Rows[0][3].ToString();
                    if (dt.Rows[0][4].ToString() == "N")
                    {
                        chekActivo.Checked = true;
                    }
                    else
                    {
                        chekActivo.Checked = false;
                    }
                    TxtProducto.Text = dt.Rows[0][5].ToString() + " - " + dt.Rows[0][6].ToString();
                    TxtCodigo.Text = dt.Rows[0][5].ToString();//,A.[ALMACEN_CODIGO] CODIGO
                    TxtDescripcion.Text = dt.Rows[0][6].ToString();//,A.[ALMACEN_DESCRIPCION] DESCRIPCION 
                    TxtObservacion.Text= dt.Rows[0][7].ToString();
                    TxtUniEsperadas.Text = dt.Rows[0][8].ToString();
                    TxtKEsperados.Text = dt.Rows[0][9].ToString();
                    TxtMinutos.Text = dt.Rows[0][14].ToString();
                    Dgprincipal.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Dgprincipal.Rows.Add(1);
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[1].Value = dt.Rows[i][10].ToString();
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[2].Value = dt.Rows[i][11].ToString();
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[3].Value = dt.Rows[i][12].ToString();
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[4].Value = dt.Rows[i][13].ToString();
                        Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[5].Value = dt.Rows[i][14].ToString();
                    }
                    //CalculaTotales();
                    CalculaMerma();
                    CalculaTotales(); 
                    Dgprincipal.ClearSelection();

                    //Dgprincipal.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // este es un mensaje de error pongo este comentario pa
            }
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
                topItem[1] = 0;
                topItem[2] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool valido()
        {
            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("El Campo Nombre NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
                return false;
            }
            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("El Campo Descripcion NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
                return false;
            }
            if (TxtKEsperados.Text=="")
            {
                MessageBox.Show("El Campo Kg esperados NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (TxtUniEsperadas.Text=="")
            {
                MessageBox.Show("El Campo Kg esperados NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (Dgprincipal.RowCount<1)
            {
                MessageBox.Show("Listado de componentes esta Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private String[] AbmUser(string tipo)
        {
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //cabecera PROCPRODH Convert.ToInt32(cmbPerfil.SelectedValue)
                lst.Add(new ClsParametros("@Tipo", Tipo));
                lst.Add(new ClsParametros("@ID", id));
                lst.Add(new ClsParametros("@CODIGO", TxtCodigo.Text));
                lst.Add(new ClsParametros("@DESCRIPCION", TxtDescripcion.Text));
                lst.Add(new ClsParametros("@VERSION", TxtVercion.Text));
                lst.Add(new ClsParametros("@CLASIFICACION", CmbClasificacion.SelectedValue));

                if (RVigSi.Checked)
                {
                    lst.Add(new ClsParametros("@VIGENCIA", "S"));
                }
                else
                {
                    lst.Add(new ClsParametros("@VIGENCIA", "N"));
                }
                lst.Add(new ClsParametros("@UESPERADAS", TxtUniEsperadas.Text.ToString().Replace(",", ".")));
                lst.Add(new ClsParametros("@KESPERADOS", TxtKEsperados.Text.ToString().Replace(",", "."))); 
                lst.Add(new ClsParametros("@MINUTOS", TxtMinutos.Text));
                lst.Add(new ClsParametros("@COMENTARIO", TxtObservacion.Text));
                
                var DtComponentes = new DataTable();
                DtComponentes.Columns.Add("FORMULA_CODIGO", typeof(string));
                DtComponentes.Columns.Add("FORMULA_VERCION", typeof(string));
                DtComponentes.Columns.Add("FORMULA_ARTI_CODIGO", typeof(string));
                DtComponentes.Columns.Add("FORMULA_CANTIDAD", typeof(decimal));
                DtComponentes.Columns.Add("FORMULA_USR", typeof(string));
                DtComponentes.Columns.Add("FORMULA_DEBAJA", typeof(string));

                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {
                    DtComponentes.Rows.Add(TxtCodigo.Text, TxtVercion.Text, Dgprincipal.Rows[i].Cells[1].Value, Dgprincipal.Rows[i].Cells[4].Value.ToString().Replace(".",",") , Program.IDUSER,"N");
                }
                lst.Add(new ClsParametros("@FORMULAI", DtComponentes, SqlDbType.Structured, ParameterDirection.Input));
                lst.Add(new ClsParametros("@USR_ID ", Program.IDUSER));
                if (chekActivo.Checked == true)
                { 
                    lst.Add(new ClsParametros("@DEBAJA", "N"));
                }
                else
                {
                    lst.Add(new ClsParametros("@DEBAJA", "S"));
                }
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_For_AddFormula", ref lst);
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

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_Leave(object sender, EventArgs e)
        {
            ///try
            ///{
            ///    if (TxtPrecio.Text != "")
            ///    {

            ///        double n = Convert.ToDouble(TxtPrecio.Text.Replace(".", ","));
            ///        TxtPrecio.Text = string.Format("{0:n}", n);
            ///        //TxtDescuento.Text= TxtDescuento.Text.Replace(",", ".");

            ///    }
            ///    //sivalido = 1;
            ///}
            ///catch (Exception ex)
            ///{
            ///    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ///}
        }

        private void TxtPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            ///TxtPrecio.Text = TxtPrecio.Text.Replace(".", "");
            ///TxtPrecio.Focus();
            ///TxtPrecio.Select(TxtPrecio.Text.Length, 0);
        }

        private void btnMasMQ_Click(object sender, EventArgs e)
        {
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar
            {
                StartPosition = FormStartPosition.CenterScreen,
                combo = "COMPONENTE_CARNICO_BUSCAR"
            };
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {

                for (int i = 0; i < Dgprincipal.RowCount; i++)
                {
                    if (_FrmGrillaBuscar.Codigo == Dgprincipal.Rows[i].Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Componente ya ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                Dgprincipal.Rows.Add(1);
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[0].Value = Convert.ToInt32(_FrmGrillaBuscar.id);
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[1].Value = _FrmGrillaBuscar.Codigo;
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[2].Value = _FrmGrillaBuscar.nombre;
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[3].Value = _FrmGrillaBuscar.Unimed;
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[4].Value = 0;
                Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[5].Value = _FrmGrillaBuscar.tipo_F;

                Dgprincipal.ClearSelection();

                Dgprincipal.EditMode = DataGridViewEditMode.EditOnEnter;
                Dgprincipal.CurrentCell = Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[4];
                Dgprincipal.CurrentCell.Selected = true;
                Dgprincipal.Focus();
            }
        }


        private void CalculaMerma()
        {
            int CantidadItems = 0;
            decimal peso = 0;
            decimal Merma = 0;
            decimal pesototal = 0;
            decimal costototal = 0;
            decimal costounitario = 0;

            for (int i = 0; i < Dgprincipal.Rows.Count; i++)
            {

                if ((Dgprincipal.Rows[i].Cells[4].Value.ToString()) == "99")
                {
                    Merma += Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value.ToString());
                }
            }
            //for (int i = 0; i < Dgprincipal.Rows.Count; i++)
            //{
            //    if ((Dgprincipal.Rows[i].Cells[8].Value.ToString()) == "-")
            //    {
            //        Dgprincipal.Rows[i].Cells[7].Value = Convert.ToDecimal(Dgprincipal.Rows[i].Cells[5].Value.ToString()) * peso / 100;
            //    }
            //}
        }

        //private void Dgprincipal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{

        //    int rowIndex =e.RowIndex;
        //    if (Dgprincipal.Rows[rowIndex].Cells[4].Value != null)
        //    {
        //        Dgprincipal.Rows[rowIndex].Cells[4].Value = Dgprincipal.Rows[rowIndex].Cells[4].Value.ToString().Replace(".", ",");
        //        //Dgprincipal.CurrentRow.Cells[9].Value = Convert.ToDouble(Dgprincipal.Rows[rowIndex].Cells[3].Value) * Convert.ToDouble(Dgprincipal.Rows[rowIndex].Cells[7].Value);
        //    }


        //    //if (Dgprincipal.Rows[rowIndex].Cells[5].Value != null)
        //    //{
        //    //    Dgprincipal.Rows[rowIndex].Cells[5].Value = Dgprincipal.Rows[rowIndex].Cells[5].Value.ToString().Replace(".", ",");
        //    //}
        //    //Dgprincipal.CurrentRow.Cells[9].Value = Convert.ToDouble(Dgprincipal.Rows[rowIndex].Cells[3].Value) * Convert.ToDouble(Dgprincipal.Rows[rowIndex].Cells[7].Value);

        //    CalculaTotales();
        //    CalculaMerma();
        //    CalculaTotales();
        //}

        //private void Dgprincipal_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    Dgprincipal.CurrentCell = Dgprincipal.Rows[e.RowIndex].Cells[4];
        //    Dgprincipal.BeginEdit(true);
        //}

        private void Dgprincipal_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Validamos si no es una fila nueva
            if (!Dgprincipal.Rows[e.RowIndex].IsNewRow)
            {
                //Sólo controlamos el dato de la columna 0
                //if (e.ColumnIndex == 4 || e.ColumnIndex == 8)
                //{
                //    if (!this.EsMasMenos(e.FormattedValue.ToString()))
                //    {
                //        MessageBox.Show("El dato introducido no es de tipo fecha", "Error de validación",
                //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        Dgprincipal.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo fecha";

                //        //
                //        e.Cancel = true;

                //    }
                //}

                if (e.ColumnIndex == 4)
                {
                    if (!this.EsDecimal(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("El dato introducido no es de tipo fecha", "Error de validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Dgprincipal.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo fechfffffa";
                        e.Cancel = true;

                    }
                    CalculaMerma();
                    CalculaTotales();
                }
            }
            //CalculaTotales();
            // CalculaMerma();
            // CalculaTotales();
        }

        private void Dgprincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (Dgprincipal.CurrentCell.ColumnIndex == 4) //Columnas deseadas
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                }
            }
        }

        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private Boolean EsMasMenos(String Dato)
        {
            try
            {
                if (Dato=="+" || Dato == "-"|| Dato == " " || Dato == "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        } 
        private Boolean EsDecimal(String Dato)
        {
            try
            {
                decimal.Parse(Dato);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgVersiones.ClearSelection();
        }

        private void DgVersiones_DoubleClick(object sender, EventArgs e)
        {
            CargaDeDatos(Convert.ToInt32(DgVersiones.CurrentRow.Cells[0].Value.ToString()));
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Dgprincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (e.KeyChar == (char)13)  // Si es un enter
            {
                SendKeys.Send("{TAB}");
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar
            {
                StartPosition = FormStartPosition.CenterScreen,
                combo = "PTERMINADOS"
            };
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {

                TxtCodigo.Text= _FrmGrillaBuscar.Codigo;
                TxtDescripcion.Text = _FrmGrillaBuscar.nombre;
            }
        }

        private void btnMenosMQ_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.SelectedRows.Count > 0)
            {
                Dgprincipal.Rows.RemoveAt(Dgprincipal.CurrentRow.Index);
                CalculaMerma();
                CalculaTotales();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Item para Eliminar.", "SystemCenter.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

    
 

