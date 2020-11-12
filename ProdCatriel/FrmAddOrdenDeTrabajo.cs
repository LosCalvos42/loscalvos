using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAZAAR
{
    public partial class FrmAddOrdenDeTrabajo : Form
    {
        public FrmAddOrdenDeTrabajo()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }
        public string CtlMerma { get; set; }
        public string EstadoCodbar { get; set; }
        public string CATEGORIAOT { get; set; }
        public string lotes { get; set; }

        string Codalma;
        decimal mermamin = 0;
        decimal mermamax = 0;
        decimal TotalProd = 0;

        int tipoimp = 0;

        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {

            //Tipo = this.Text;
            LblTitulo.Text = Listado;
            Tipo = this.Text.Split()[0];
            id = Convert.ToInt32(this.Text.Split()[2]);
            //Cargarcombo("ARTICULO", CmbProducto);
            Cargarcombo("ALMACEN", CmbAlmacen);
            Cargarcombo("PROCESO", CmbProceso);
            Inicio();
        }
        private void limpiarObjetos() {

            TxtEstadoOT.Text = "";
            TxtKG.Text = "";
            TxtKRecepcion.Text = "";
            TxtMerma.Text = "";
            TxtMermaMaxima.Text = "";
            TxtMermaMin.Text = "";
            TxtMMaxD.Text = "";
            TxtMminD.Text = "";
            TxtNombreOT.Text = "";
            TxtNroOT.Text = "";
            TxtObservacion.Text = "";
            TxtPesoProceso.Text = "";
            Txtpiezas.Text = "";
            Txtlote.Text = "";
            Txtpieza.Text = "";               
            LblLetra.Text = "";
            DgDetalle.Rows.Clear();
            Dgprincipal.Rows.Clear();
            //Dgprincipal.ReadOnly = true;
            ChekCtMerma.Checked = false;
            mermamin = 0;
            mermamax = 0;
            TotalProd = 0;

        }
        private void SoloLectura()
        {
            TxtNombreOT.ReadOnly = true;
            CmbProceso.Enabled = false;
            //CmbAlmacen.Enabled = false;
            TxtObservacion.ReadOnly = true;
            DgDetalle.ReadOnly = true;
            //Dgprincipal.ReadOnly = true;
            btnAceptar.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = true;
            Dtfecha.Enabled = false;
            BtnBorrar.Enabled = false;
            BtnTerminar.Enabled = false;
        }

        private void Habilito()
        {
            TxtNombreOT.ReadOnly = false;
            CmbProceso.Enabled = true;
            CmbAlmacen.Enabled = true;
            TxtObservacion.ReadOnly = false;
            DgDetalle.ReadOnly = false;
            //Dgprincipal.ReadOnly = true;
            btnAceptar.Enabled = true;
            btnCancel.Enabled = true;
            groupBox1.Enabled = true;
            Dtfecha.Enabled = true;
            BtnBorrar.Enabled = false;
            BtnTerminar.Enabled = true;
        }
        private void Inicio()
        {
            limpiarObjetos();
            if (Tipo == "NUEVO")
            {
                LblTitulo.Text = "Orden De Trabajo";
                id = 0;
                lotes="";
                Dtfecha.Value = DateTime.Now;
                TxtObservacion.ReadOnly = false;
                groupBox1.Enabled = true;
                btnAceptar.Enabled = true;
                btnCancel.Enabled = true;
                TxtEstadoOT.Text = "DISPONIBLE";
                Habilito();
            }
            if (Tipo == "MODIFICAR")
            {
                LblTitulo.Text = "Orden De Trabajo";
                
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@Tipo", "CABECERA"));
                    dt = M.Listado("SP_ListadoOTrabajo", lst);
                    if (dt.Rows.Count > 0)
                    {
                        TxtNroOT.Text = dt.Rows[0][0].ToString();
                        CmbProceso.SelectedValue = dt.Rows[0][1].ToString();
                        TxtNombreOT.Text = dt.Rows[0][2].ToString();
                        CmbAlmacen.SelectedValue = dt.Rows[0][3].ToString();
                        Dtfecha.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                        CtlMerma = dt.Rows[0][5].ToString();
                        if (CtlMerma == "S")
                        {
                            ChekCtMerma.Checked = true;
                        }
                        else
                        {
                            ChekCtMerma.Checked = false;
                        }
                        TxtEstadoOT.Text = dt.Rows[0][6].ToString();
                        EstadoCodbar = dt.Rows[0][7].ToString();
                        lotes = dt.Rows[0][8].ToString();
                        TxtObservacion.Text = dt.Rows[0][9].ToString();
                        TxtMminD.Text = dt.Rows[0][10].ToString();
                        TxtMMaxD.Text = dt.Rows[0][11].ToString();
                        CATEGORIAOT= dt.Rows[0][12].ToString();
                    }
                    lst.Clear();
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@Tipo", "DETALLE"));
                    dt = M.Listado("SP_ListadoOTrabajo", lst);
                    if (dt.Rows.Count > 0)
                    {
                        DgDetalle.Rows.Clear();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DgDetalle.Rows.Add(dt.Rows[i][0]);
                            DgDetalle.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                            DgDetalle.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                            DgDetalle.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                            DgDetalle.Rows[i].Cells[6].Value = dt.Rows[i][3].ToString();
                        }
                        DgDetalle.ClearSelection();
                    }

                    cargarDGPrincipal();

                    if (TxtEstadoOT.Text != "DISPONIBLE")
                    {
                       SoloLectura();
                    }
                    else
                    {
                         Habilito();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (Tipo == "REALIZAR")
            {
                
                LblTitulo.Text = "Realizar Tarea - Orden T. Nro: " + id;
                Dtfecha.Enabled = false;
                SoloLectura();
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@Tipo", "CABECERA"));
                    dt = M.Listado("SP_ListadoOTrabajo", lst);
                    if (dt.Rows.Count > 0)
                    {
                        TxtNroOT.Text = dt.Rows[0][0].ToString();
                        CmbProceso.SelectedValue = dt.Rows[0][1].ToString();
                        TxtNombreOT.Text = dt.Rows[0][2].ToString();
                        CmbAlmacen.SelectedValue = dt.Rows[0][3].ToString();
                        Codalma = Convert.ToString(CmbAlmacen.SelectedValue);
                        Dtfecha.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                        CtlMerma = dt.Rows[0][5].ToString();
                        if (CtlMerma == "S")
                        {
                            ChekCtMerma.Checked = true;
                        }
                        else
                        {
                            ChekCtMerma.Checked = false;
                        }
                        TxtEstadoOT.Text = dt.Rows[0][6].ToString();
                        EstadoCodbar = dt.Rows[0][7].ToString();
                        lotes = dt.Rows[0][8].ToString();
                        TxtObservacion.Text = dt.Rows[0][9].ToString();
                        TxtMminD.Text= dt.Rows[0][10].ToString();
                        TxtMMaxD.Text= dt.Rows[0][11].ToString();
                        CATEGORIAOT = dt.Rows[0][12].ToString();

                    }
                    lst.Clear();
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@Tipo", "DETALLE"));
                    dt = M.Listado("SP_ListadoOTrabajo", lst);
                    if (dt.Rows.Count > 0)
                    {
                        DgDetalle.Rows.Clear();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DgDetalle.Rows.Add(dt.Rows[i][0]);
                            DgDetalle.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                            DgDetalle.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                            DgDetalle.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                            DgDetalle.Rows[i].Cells[6].Value = dt.Rows[i][3].ToString();
                        }
                        DgDetalle.ClearSelection();
                    }
                    cargarDGPrincipal();

                    if (TxtEstadoOT.Text == "TERMINADO")
                    {
                        Dgprincipal.Columns[1].ReadOnly = true;
                        BtnTerminar.Enabled = false;
                        BtnBorrar.Enabled = false;
                    }
                    else
                    {
                        Dgprincipal.Columns[1].ReadOnly = false;
                        Dgprincipal.Refresh();
                        BtnTerminar.Enabled = true;
                        BtnBorrar.Enabled = true;
                    }
                        

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (Tipo == "CONSULTAR")
            {
                SoloLectura();
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@Tipo", "CABECERA"));
                    dt = M.Listado("SP_ListadoOTrabajo", lst);
                    if (dt.Rows.Count > 0)
                    {
                        TxtNroOT.Text = dt.Rows[0][0].ToString();
                        CmbProceso.SelectedValue = dt.Rows[0][1].ToString();
                        TxtNombreOT.Text = dt.Rows[0][2].ToString();
                        CmbAlmacen.SelectedValue = dt.Rows[0][3].ToString();
                        Dtfecha.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                        CtlMerma = dt.Rows[0][5].ToString();
                        if (CtlMerma == "S")
                        {
                            ChekCtMerma.Checked = true;
                        }
                        else
                        {
                            ChekCtMerma.Checked = false;
                        }
                        TxtEstadoOT.Text = dt.Rows[0][6].ToString();
                        EstadoCodbar = dt.Rows[0][7].ToString();
                        lotes = dt.Rows[0][8].ToString();
                        TxtObservacion.Text = dt.Rows[0][9].ToString();
                        TxtMminD.Text = dt.Rows[0][10].ToString();
                        TxtMMaxD.Text = dt.Rows[0][11].ToString();
                        CATEGORIAOT = dt.Rows[0][12].ToString();
                    }
                    lst.Clear();
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@Tipo", "DETALLE"));
                    dt = M.Listado("SP_ListadoOTrabajo", lst);
                    if (dt.Rows.Count > 0)
                    {
                        DgDetalle.Rows.Clear();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DgDetalle.Rows.Add(dt.Rows[i][0]);
                            DgDetalle.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                            DgDetalle.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                            DgDetalle.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                            DgDetalle.Rows[i].Cells[6].Value = dt.Rows[i][3].ToString();
                        }
                        DgDetalle.ClearSelection();
                    }
                    cargarDGPrincipal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cargarDGPrincipal()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@id", id));
                lst.Add(new ClsParametros("@Tipo", "ListadoDetalle"));
                dt = M.Listado("SP_ListadoOTrabajo", lst);
                if (dt.Rows.Count > 0)
                {
                    Dgprincipal.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Dgprincipal.Rows.Add(dt.Rows[i][0]);

                        Dgprincipal.Rows[i].Cells[0].Value = Dgprincipal.RowCount - 1;
                        Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][0].ToString();
                        Dgprincipal.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                        Dgprincipal.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
                        Dgprincipal.Rows[i].Cells[4].Value = dt.Rows[i][3].ToString();
                        Dgprincipal.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                        Dgprincipal.Rows[i].Cells[6].Value = dt.Rows[i][5].ToString();
                        Dgprincipal.Rows[i].Cells[7].Value = dt.Rows[i][6].ToString();

                        if (Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value) < Convert.ToDecimal(TxtMminD.Text) || Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value) > Convert.ToDecimal(TxtMMaxD.Text))
                        {
                            TxtMerma.ForeColor = Color.Red;
                            Dgprincipal.Rows[i].Cells[5].Value = "N";
                            Dgprincipal.Rows[i].Cells[5].Style.BackColor = Color.Red;
                            Dgprincipal.Rows[i].Cells[5].Style.ForeColor = Color.White;

                        }
                        else
                        {
                            TxtMerma.ForeColor = Color.Green;
                            Dgprincipal.Rows[i].Cells[5].Value = "S";
                            Dgprincipal.Rows[i].Cells[5].Style.BackColor = Color.Green;
                            Dgprincipal.Rows[i].Cells[5].Style.ForeColor = Color.White;
                        }

                    }
                    Dgprincipal.ClearSelection();
                    //Dgprincipal.Rows.RemoveAt(Dgprincipal.RowCount - 1);
                    Dgprincipal.Refresh();
                    Calculo_mermasMinMax();
                    Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool valido()
        {
            if (TxtNombreOT.Text == "")
            {
                MessageBox.Show("El Campo NombreOT NO puede estar Vacio!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombreOT.Focus();
                return false;
            }

            if (CmbProceso.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (PROCESO)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbProceso.Focus();
                return false;
            }
            if (CmbAlmacen.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (ALMACEN)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbAlmacen.Focus();
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
                lst.Add(new ClsParametros("@PROCESO", CmbProceso.SelectedValue));
                lst.Add(new ClsParametros("@DESCRIPCION", TxtNombreOT.Text));
                lst.Add(new ClsParametros("@LOTES", lotes));
                lst.Add(new ClsParametros("@FECHAPROCESO", Dtfecha.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@CTRLMERMA", ChekCtMerma.CheckState));
                lst.Add(new ClsParametros("@OBSERVACION", TxtObservacion.Text));
                lst.Add(new ClsParametros("@ESTADOCODBAR", EstadoCodbar));
                lst.Add(new ClsParametros("@ALMACEN", CmbAlmacen.SelectedValue));
                lst.Add(new ClsParametros("@ESTADOOT", TxtEstadoOT.Text));
                lst.Add(new ClsParametros("@USR_ID ", Program.IDUSER));
                lst.Add(new ClsParametros("@DEBAJA", "N"));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("sp_AddOTrabajo", ref lst);
                msj = new string[2];
                msj[0] = lst[13].Valor.ToString();
                msj[1] = lst[14].Valor.ToString();
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
            if (Tipo == "REALIZAR")
            {
                CmbAlmacen.SelectedValue = Codalma;
                btnAceptar.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            { 
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            //this.cl;
        }
        //public static string Encriptar(string _cadenaAencriptar)
        //{
        //    string result = string.Empty;
        //    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
        //    result = Convert.ToBase64String(encryted);
        //    return result;
        //}
        //public static string DesEncriptar(string _cadenaAdesencriptar)
        //{
        //    string result = string.Empty;
        //    byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
        //    //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
        //    result = System.Text.Encoding.Unicode.GetString(decryted);
        //    return result;
        //}
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

                        MessageBox.Show(msg[1], "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        
                        if (Tipo == "REALIZAR")
                        {
                            btnAceptar.Enabled = false;
                        }
                        else
                        {
                            DialogResult = DialogResult.Yes;
                            this.Close();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CmbProceso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DgDetalle.Rows.Clear();
            CmbAlmacen.SelectedIndex = 0;
            ChekCtMerma.Checked = false;
            string IdProceso = CmbProceso.SelectedValue.ToString();

            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@id", 0));
                lst.Add(new ClsParametros("@Codigo", IdProceso));
                lst.Add(new ClsParametros("@tipo", "CABECERA"));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("SP_ListadoProcesos", lst);
                if (dt.Rows.Count > 0)
                {
                    //txtCodProceso.Text = dt.Rows[0][1].ToString();
                    //TxtNombre.Text = dt.Rows[0][2].ToString();
                    //cmbTProceso.SelectedValue = dt.Rows[0][3].ToString();
                    CmbAlmacen.SelectedValue = dt.Rows[0][4].ToString();
                    EstadoCodbar= dt.Rows[0][6].ToString();
                    if (dt.Rows[0][5].ToString() == "S")
                    {
                        ChekCtMerma.Checked = true;
                    }
                    else
                    {
                        ChekCtMerma.Checked = false;
                    }
                }
                lst.Clear();
                lst.Add(new ClsParametros("@id", 0));
                lst.Add(new ClsParametros("@Codigo", IdProceso));
                lst.Add(new ClsParametros("@tipo", "DETALLE"));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("SP_ListadoProcesos", lst);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DgDetalle.Rows.Add(1);
                        DgDetalle.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        DgDetalle.Rows[i].Cells[1].Value = dt.Rows[i][2].ToString();
                        DgDetalle.Rows[i].Cells[2].Value = dt.Rows[i][3].ToString();
                        DgDetalle.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = ((DataGridView)sender).CurrentRow;
                string valorPrimerCelda = Convert.ToString(row.Cells[2].Value);
                MessageBox.Show(valorPrimerCelda, "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Handled = true;
            }
           
        }
        private void Dgprincipal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dgprincipal.BeginEdit(false);
        }

        private void Dgprincipal_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
            dText.KeyUp -= new KeyEventHandler(text_KeyUp);
            dText.KeyUp += new KeyEventHandler(text_KeyUp);
        }

        void text_KeyUp(object sender, KeyEventArgs e)
        {
  
            int rowIndex = ((System.Windows.Forms.DataGridViewTextBoxEditingControl)(sender)).EditingControlRowIndex;

            if (e.KeyCode == Keys.Enter)
            {
                string codbar= Dgprincipal.Rows[rowIndex - 1].Cells[1].Value.ToString();

                if (codbar.Length == 14)
                {
                    RegistrarRack(codbar, rowIndex - 1);
                    Escontrol(codbar);
                }
                else
                { 
                    Registrar(codbar, rowIndex - 1);
                }
            }
        }
        private void RegistrarRack(string codbar, int fila)
        {
            ClsManejador r = new ClsManejador();
            DataTable dtr = new DataTable();
            List<ClsParametros> lstr = new List<ClsParametros>();
            lstr.Add(new ClsParametros("@codbar", codbar));
            lstr.Add(new ClsParametros("@lote", lotes));
            lstr.Add(new ClsParametros("@NroOt", id));
            //lst.Add(new ClsParametros("@CATEGORIA", radioButton1.Checked));
            dtr = r.Listado("SP_GetCodBarrepetidoOT", lstr);

            if (dtr.Rows.Count > 0)
            {
                MessageBox.Show("El Código Ya fue leido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Dgprincipal.Rows.Remove(Dgprincipal.Rows[fila]);
                return;
            }

            DataTable dt = new DataTable();
            ClsManejador M = new ClsManejador();

            string ssql = @" select AA.ESTADO_CODIGO
                        from PRODUCCION p 
                        INNER JOIN AGENDA A ON A.ESTADO_CODIGO=P.ESTADO_CODIGO AND A.CATEGORIAPESO_CODIGO= '" + CATEGORIAOT +
                        "' INNER JOIN AGENDA AA ON AA.AGENDA_ORDEN = A.AGENDA_ORDEN+1 AND AA.CATEGORIAPESO_CODIGO=A.CATEGORIAPESO_CODIGO " +
                        " where RACK_CODBAR ='" + codbar + "' GROUP BY AA.ESTADO_CODIGO";

            dt = M.lisquery(ssql);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() == EstadoCodbar)
                {
                    ssql = @"select p.PRODUCCION_CODBAR
                            from PRODUCCION p
                            INNER JOIN AGENDA A ON A.ESTADO_CODIGO = P.ESTADO_CODIGO AND A.CATEGORIAPESO_CODIGO = '" + CATEGORIAOT +
                            "' where P.RACK_CODBAR ='" + codbar+ "'"; 
                            dt = M.lisquery(ssql);

                    for (int i = 0; i < dt.Rows.Count ; i++)
                    {
                        Registrar(dt.Rows[i][0].ToString() + "0", fila);
                        Dgprincipal.BeginEdit(false);
                        fila = fila + 1;

                        if (i< dt.Rows.Count - 1)
                        { 
                            Dgprincipal.Rows.Add(1);
                        }

                    }
                    Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                    Dgprincipal.Refresh();
                }
                
                else
                {
                    MessageBox.Show("El Código no es válido para esta O. trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Dgprincipal.Rows.Remove(Dgprincipal.Rows[fila]);

                    return;
                }
            }
            else
            {
                MessageBox.Show("El Código no es válido para esta O. trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Dgprincipal.Rows.Remove(Dgprincipal.Rows[fila]);
                return;
            }
        }

        private void Escontrol(string CodRack)
        {
            DataTable dt = new DataTable();
            ClsManejador M = new ClsManejador();

            string ssql = @"select R.RACK_ID,R.RACK_CODBAR,RACK_LOTE,R.RACK_ESCONTROL"+
                            " ,MAX(P.ALMACEN_CODIGO) ALMACEN_CODIGO" +
                            " from RACK R"+
                            " inner join PRODUCCION p on R.RACK_CODBAR= p.RACK_CODBAR" +
                            " where R.RACK_ESCONTROL='S'  AND  R.RACK_CODBAR ='" + CodRack + "' GROUP BY R.RACK_ID,R.RACK_CODBAR,RACK_LOTE,R.RACK_ESCONTROL";

            dt = M.lisquery(ssql);
            if (dt.Rows.Count == 1)
            {
                Cursor.Current = Cursors.WaitCursor;
                CheckForIllegalCrossThreadCalls = false;
                FrmControlDeRacks _FrmControlDeRacks = new FrmControlDeRacks();
                //Vienede
                _FrmControlDeRacks.Vienede = "OT";
                _FrmControlDeRacks.NROOT = Convert.ToInt32(TxtNroOT.Text);
                _FrmControlDeRacks.RackCodbar = CodRack;
                _FrmControlDeRacks.AlmacenControl= Convert.ToString(CmbAlmacen.SelectedValue);
                _FrmControlDeRacks.Proceso = Convert.ToString(CmbProceso.SelectedValue);
                _FrmControlDeRacks.StartPosition = FormStartPosition.CenterScreen;
                _FrmControlDeRacks.ShowDialog();
            }
        }

        private void Registrar(string codbar , int fila)
        {
            ClsManejador r = new ClsManejador();
            DataTable dtr = new DataTable();
            List<ClsParametros> lstr = new List<ClsParametros>();
            lstr.Add(new ClsParametros("@codbar", codbar));
            lstr.Add(new ClsParametros("@lote", lotes));
            lstr.Add(new ClsParametros("@NroOt", id));
            //lst.Add(new ClsParametros("@CATEGORIA", radioButton1.Checked));
            dtr = r.Listado("SP_GetCodBarrepetidoOT", lstr);

            if (dtr.Rows.Count > 0)
            {
                MessageBox.Show("El Código Ya fue leido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Dgprincipal.Rows.Remove(Dgprincipal.Rows[fila]);
                cargarDGPrincipal();
                Dgprincipal.CurrentCell = Dgprincipal.Rows[Dgprincipal.RowCount - 1].Cells[1];
                Dgprincipal.BeginEdit(true);
                return;
            }
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();

            lst.Add(new ClsParametros("@codbar", codbar));
            lst.Add(new ClsParametros("@lote", lotes));
            lst.Add(new ClsParametros("@NroOt", id));
            //lst.Add(new ClsParametros("@CATEGORIA", radioButton1.Checked));
            dt = M.Listado("SP_GetImfoCodBar", lst);
            if (dt.Rows.Count > 0)
            {
                decimal merma = 0;
                decimal Pesodecimal = 0;
                //decimal mermamin = 0;
                //decimal mermamax= 0;
                if (ChekCtMerma.Checked == true) { 
                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                    _FrmPesada.ShowDialog();

                Pesodecimal = _FrmPesada.Pesodecimal;
                }
                else
                {
                    Pesodecimal = Convert.ToDecimal(dt.Rows[0][4].ToString());

                }
                //merma = (Convert.ToDecimal(_FrmPesada.Pesotext) * 100);///Convert.ToDouble(dt.Rows[0][1].ToString())-100);

                //*****************CALCULO DE MERMA**************
                merma = Math.Round(Math.Abs((Convert.ToDecimal(Pesodecimal) * 100) / Convert.ToDecimal(dt.Rows[0][1].ToString()) - 100), 2);
                //*********************************************
                TxtMerma.Text = Convert.ToString(merma);
                Dgprincipal.Rows[fila].Cells[0].Value = Dgprincipal.RowCount - 1;
                Dgprincipal.Rows[fila].Cells[1].Value = dt.Rows[0][0].ToString();
                Dgprincipal.Rows[fila].Cells[2].Value = dt.Rows[0][1].ToString();
                Dgprincipal.Rows[fila].Cells[3].Value = Pesodecimal;
                Dgprincipal.Rows[fila].Cells[4].Value = merma;
                Dgprincipal.Rows[fila].Cells[6].Value = dt.Rows[0][2].ToString();
                Dgprincipal.Rows[fila].Cells[7].Value = dt.Rows[0][3].ToString();
                Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                Dgprincipal.Refresh();
            

                Getinfo(fila);

                TotalProd = Dgprincipal.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal((x).Cells[3].Value));
                TxtPesoProceso.Text = Convert.ToString(TotalProd);

                string[] msg = ABMPROCESO(codbar, lotes, Pesodecimal, Dgprincipal.Rows[fila].Cells[6].Value.ToString(), Dgprincipal.Rows[fila].Cells[6].Value.ToString());

                if (msg[0] == "0")
                {

                    MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("El Código no es válido para esta O. trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cargarDGPrincipal();
                Dgprincipal.CurrentCell = Dgprincipal.Rows[Dgprincipal.RowCount-1].Cells[1];
                Dgprincipal.BeginEdit(true);
            }
            
        }
        private String[] ABMPROCESO(string CODBAR,string LOTE,decimal PESO, string CatPeso,string CatMerma)
        {
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            List<ClsParametros> lst2 = new List<ClsParametros>();
            try
            {
                //cabecera PROCPRODH 
                lst.Add(new ClsParametros("@NROOT", Convert.ToInt32(TxtNroOT.Text)));
                lst.Add(new ClsParametros("@CODBAR", CODBAR));
                lst.Add(new ClsParametros("@LOTE ", LOTE));
                lst.Add(new ClsParametros("@PROCESO", CmbProceso.SelectedValue));
                lst.Add(new ClsParametros("@FECHAPROD", Dtfecha.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@CANTIDAD", 1));
                lst.Add(new ClsParametros("@PESO", PESO));
                lst.Add(new ClsParametros("@CATEGORIAPESO", CatPeso));
                lst.Add(new ClsParametros("@CATEGORIAMERMA ", "SCAT"));
                lst.Add(new ClsParametros("@ALMACEN", CmbAlmacen.SelectedValue));
                lst.Add(new ClsParametros("@ESTADOCODBAR", EstadoCodbar));
                lst.Add(new ClsParametros("@USR_ID", Program.IDUSER));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));

                M.ExecuteSqlTransaction("SP_AddMovimientoCoDBar",  lst);
                msj = new string[2];
                msj[0] =lst[12].Valor.ToString();
                msj[1] = lst[13].Valor.ToString();

                if (lst[12].Valor.ToString() == "IMP")
                {
                    if (MessageBox.Show("¿El Rack es control?", "CONTROL.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ClsManejador ME = new ClsManejador();
                        ME.Ejecutarquery("update RACK set RACK_ESCONTROL='S' where RACK_CODBAR='" + lst[13].Valor.ToString()+"'");
                    }

                    tipoimp = 1;
                    BtnRacks.PerformClick();
                    tipoimp = 0;
                }

            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = lst[12].Valor.ToString();
                msj[1] = lst[13].Valor.ToString();
            }
            return msj;
        }

        private void Calculo_mermasMinMax()
        {
            mermamax = 0;
            mermamin = 500;

            for (int i = 0; i < Dgprincipal.Rows.Count-1; i++)
            {
                if (Dgprincipal.Rows.Cast<DataGridViewRow>().Any(x => Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value.ToString()) < mermamin))
                {
                    mermamin = Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value);
                }
                if (Dgprincipal.Rows.Cast<DataGridViewRow>().Any(x => Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value.ToString()) > mermamax))
                {
                    mermamax = Convert.ToDecimal(Dgprincipal.Rows[i].Cells[4].Value);
                }
            }
            TxtMermaMin.Text = Convert.ToString(mermamin);
            TxtMermaMaxima.Text = Convert.ToString(mermamax);

        }
        private void Getinfo(int fila)
        {
            try
            { 
                Txtpieza.Text = Dgprincipal.Rows[fila].Cells[1].Value.ToString();
                TxtKRecepcion.Text = Dgprincipal.Rows[fila].Cells[2].Value.ToString();
                TxtKG.Text = Dgprincipal.Rows[fila].Cells[3].Value.ToString();
                Txtlote.Text = Dgprincipal.Rows[fila].Cells[7].Value.ToString();



                if (Convert.ToDecimal(Dgprincipal.Rows[fila].Cells[4].Value) < Convert.ToDecimal(TxtMminD.Text) || Convert.ToDecimal(Dgprincipal.Rows[fila].Cells[4].Value) > Convert.ToDecimal(TxtMMaxD.Text))
                {
                    TxtMerma.ForeColor = Color.Red;
                    Dgprincipal.Rows[fila].Cells[5].Value = "N";
                    Dgprincipal.Rows[fila].Cells[5].Style.BackColor = Color.Red;
                    Dgprincipal.Rows[fila].Cells[5].Style.ForeColor = Color.White;
                }
                else
                {
                    TxtMerma.ForeColor = Color.Green;
                    Dgprincipal.Rows[fila].Cells[5].Value = "S";
                    Dgprincipal.Rows[fila].Cells[5].Style.BackColor = Color.Green;
                    Dgprincipal.Rows[fila].Cells[5].Style.ForeColor = Color.White;
                }

                //if (Dgprincipal.Rows.Cast<DataGridViewRow>().Any(x => Convert.ToDecimal(Dgprincipal.Rows[fila].Cells[3].Value.ToString()) < mermamin))
                //{
                //    mermamin = Convert.ToDecimal(Dgprincipal.Rows[fila].Cells[4].Value); 
                //}
                //if (Dgprincipal.Rows.Cast<DataGridViewRow>().Any(x => Convert.ToDecimal(Dgprincipal.Rows[fila].Cells[3].Value.ToString()) > mermamax))
                //{
                //    mermamax = Convert.ToDecimal(Dgprincipal.Rows[fila].Cells[4].Value); 
                //}

                TxtMerma.Text = Dgprincipal.Rows[fila].Cells[4].Value.ToString();
                //TxtMermaMin.Text = Convert.ToString(mermamin);
                //TxtMermaMaxima.Text = Convert.ToString(mermamax);
                Txtpiezas.Text = Convert.ToString(Dgprincipal.Rows.Count - 1);

                switch (Dgprincipal.Rows[fila].Cells[6].Value.ToString())
                {
                    case "CAT1":
                        LblLetra.Text = "1";
                        break;
                    case "CAT2":
                        LblLetra.Text = "2";
                        break;
                    case "CAT3":
                        LblLetra.Text = "3";
                        break;
                    case "CAT4":
                        LblLetra.Text = "4";
                        break;
                    case "CAT5":
                        LblLetra.Text = "5";
                        break;
                }

                Calculo_mermasMinMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
        private void Dgprincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            Getinfo(e.RowIndex);
            
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            
            if (Dgprincipal.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("¿Confirma que desea ELIMINAR esta pieza!!!?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                string[] msg = RemovMovCodBar( Dgprincipal.Rows[Dgprincipal.CurrentRow.Index].Cells[1].Value.ToString(), Dgprincipal.Rows[Dgprincipal.CurrentRow.Index].Cells[7].Value.ToString(),Convert.ToInt32(TxtNroOT.Text));

                if (msg[0] == "0")
                {

                    MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    MessageBox.Show(msg[1], "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Dgprincipal.Rows.RemoveAt(Dgprincipal.CurrentRow.Index);
                    cargarDGPrincipal();
                    return;
                }  
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Item para Eliminar.", "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private String[] RemovMovCodBar(string CODBAR, string LOTE, int NroOt)
        {
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            List<ClsParametros> lst2 = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@CODBAR", CODBAR));
                lst.Add(new ClsParametros("@LOTE ", LOTE));
                lst.Add(new ClsParametros("@NROOT", Convert.ToInt32(TxtNroOT.Text)));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_RemovMovCodBar", ref lst);
                msj = new string[2];
                msj[0] = lst[3].Valor.ToString();
                msj[1] = lst[4].Valor.ToString();
            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[3] = "0";
                msj[4] = ex.Message;
            }
            return msj;
        }

        private void BtnRacks_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count > 1)
            {

                Cursor.Current = Cursors.WaitCursor;
                CheckForIllegalCrossThreadCalls = false;
                FrmImpresionRack _FrmImpresionRack = new FrmImpresionRack();
                _FrmImpresionRack.Categoria = Dgprincipal.Rows[0].Cells[6].Value.ToString();
                _FrmImpresionRack.NROOT = Convert.ToInt32(TxtNroOT.Text);
                _FrmImpresionRack.Tipo = tipoimp;
                _FrmImpresionRack.Lote = lotes;
                _FrmImpresionRack.RackCodbar = "";
                _FrmImpresionRack.StartPosition = FormStartPosition.CenterScreen;
                _FrmImpresionRack.ShowDialog();
                tipoimp = 0;
            }
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            ClsManejador M = new ClsManejador();
            List<ClsParametros> lst = new List<ClsParametros>();
            DataTable dt = new DataTable();
            string[] msj;
            try
            {
                lst.Add(new ClsParametros("@tipo","1"));
                lst.Add(new ClsParametros("@CATEGORIA", CATEGORIAOT));
                lst.Add(new ClsParametros("@LOTE", lotes));
                lst.Add(new ClsParametros("@NROOT", Convert.ToInt32(TxtNroOT.Text)));
                lst.Add(new ClsParametros("@USR_ID", Program.IDUSER));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_TerminarOt",ref lst);

                msj = new string[2];
                msj[0] = lst[5].Valor.ToString();
                msj[1] = lst[6].Valor.ToString();

                if (Convert.ToInt32(lst[5].Valor.ToString()) > 0)
                {
                    if (CmbProceso.SelectedValue == "SSAL")
                    {
                        if (MessageBox.Show("Se encontraron " + lst[5].Valor.ToString() + " Piezas Sin Escanear." + System.Environment.NewLine + System.Environment.NewLine + "¿Desea Continuar?", "Terminar OT.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                        
                    }
                    else
                        MessageBox.Show("Se encontraron " + lst[5].Valor.ToString() + " Piezas Sin Escanear." + System.Environment.NewLine + "NO se puede terminar el trabajo", "Terminar OT.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    return;

                }

                if (MessageBox.Show("Esta seguro que desea TERMINAR la OT NRO: "+TxtNroOT.Text +System.Environment.NewLine + "¿Desea Continuar?", "Terminar OT.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    lst.Clear();
                    lst.Add(new ClsParametros("@tipo", "2"));
                    lst.Add(new ClsParametros("@CATEGORIA", CATEGORIAOT));
                    lst.Add(new ClsParametros("@LOTE", lotes));
                    lst.Add(new ClsParametros("@NROOT", Convert.ToInt32(TxtNroOT.Text)));
                    lst.Add(new ClsParametros("@USR_ID", Program.IDUSER));
                    lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                    lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                    M.EjecutarSP("SP_TerminarOt",ref lst);
                    msj = new string[2];
                    msj[0] = lst[5].Valor.ToString();
                    msj[1] = lst[6].Valor.ToString();

                    if (msj[0] == "0")
                    {
                        MessageBox.Show(msj[1], "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Los Datos se Guardaron Correctamente" + System.Environment.NewLine + msj[1], "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        //this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddlotes_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(CmbProceso.SelectedValue) == "ESTU")
            {
                Cursor.Current = Cursors.WaitCursor;
                CheckForIllegalCrossThreadCalls = false;
                FrmBuscarEnBodega _FrmBuscarEnBodega = new FrmBuscarEnBodega();
                _FrmBuscarEnBodega.StartPosition = FormStartPosition.CenterScreen;
                _FrmBuscarEnBodega.ShowDialog();
                tipoimp = 0;
            }

        }

        private void BtnEtiPendientes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmEtiPendientes _FrmEtiPendientes = new FrmEtiPendientes();
            _FrmEtiPendientes.CATEGORIA = CATEGORIAOT;
            _FrmEtiPendientes.NROOT = Convert.ToInt32(TxtNroOT.Text);
            _FrmEtiPendientes.LOTE = lotes;
            _FrmEtiPendientes.StartPosition = FormStartPosition.CenterScreen;
            _FrmEtiPendientes.ShowDialog();
        }

        private void CmbAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnAceptar.Enabled = true;
        }

        private void CmbAlmacen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
            btnCancel.Enabled = true;
            
        }
    }
}

    
 

