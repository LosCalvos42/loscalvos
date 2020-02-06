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
        public string lotes { get; set; }

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
            DgDetalle.Rows.Clear();
            Dgprincipal.Rows.Clear();
            ChekCtMerma.Checked=false;
            
        }

        private void SoloLectura()
        {
            TxtNombreOT.ReadOnly = true;
            CmbProceso.Enabled = false;
            CmbAlmacen.Enabled = false;
            TxtObservacion.ReadOnly = true;
            DgDetalle.ReadOnly = true;
            Dgprincipal.ReadOnly = true;
            btnAceptar.Enabled = false;
            btnCancel.Enabled = false;
            groupBox1.Enabled = true;
        }
        private void Inicio()
        {
            limpiarObjetos();
            if (Tipo == "NUEVO")
            {
                LblTitulo.Text = "Orden De Trabajo";
                id = 0;
                limpiarObjetos();
                TxtObservacion.ReadOnly = false;
                groupBox1.Enabled = true;
                btnAceptar.Enabled = true;
                btnCancel.Enabled = true;
                TxtEstadoOT.Text = "DISPONIBLE";
            }
            if (Tipo == "MODIFICAR")
            {
                LblTitulo.Text = "Orden De Trabajo";
                TxtObservacion.ReadOnly = true;
                CmbProceso.Enabled = true;
                CmbAlmacen.Enabled = true;
                btnAceptar.Enabled = true;
                btnCancel.Enabled = true;
                groupBox1.Enabled = true;
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
                        TxtNroOT.Text= dt.Rows[0][0].ToString();
                        CmbProceso.SelectedValue = dt.Rows[0][1].ToString();
                        TxtNombreOT.Text= dt.Rows[0][2].ToString();
                        CmbAlmacen.SelectedValue= dt.Rows[0][3].ToString();
                        Dtfecha.Value= Convert.ToDateTime(dt.Rows[0][4].ToString());
                        CtlMerma= dt.Rows[0][5].ToString();
                        if (CtlMerma=="S")
                        {
                            ChekCtMerma.Checked = true;
                        }
                        else
                        {
                            ChekCtMerma.Checked=false;
                        }

                        TxtEstadoOT.Text= dt.Rows[0][6].ToString();
                        EstadoCodbar= dt.Rows[0][7].ToString();
                        lotes= dt.Rows[0][8].ToString();
                        TxtObservacion.Text= dt.Rows[0][9].ToString();
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
                    TxtNombreOT.ReadOnly = true;
                    //CmbProducto.Enabled = false;
                    CmbAlmacen.Enabled = false;
                    CmbProceso.Enabled = false;

                



                TxtObservacion.ReadOnly = false;
                btnAceptar.Enabled = false;
                btnCancel.Enabled = false;
                groupBox1.Enabled = true;
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
                        TxtEstadoOT.Text = dt.Rows[0][6].ToString();
                        EstadoCodbar = dt.Rows[0][7].ToString();
                        lotes = dt.Rows[0][8].ToString();
                        TxtObservacion.Text = dt.Rows[0][9].ToString();
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
                        TxtEstadoOT.Text = dt.Rows[0][6].ToString();
                        EstadoCodbar = dt.Rows[0][7].ToString();
                        lotes = dt.Rows[0][8].ToString();
                        TxtObservacion.Text = dt.Rows[0][9].ToString();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                lst.Add(new ClsParametros("@LOTES", " "));
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
                    //CmbEstado.SelectedValue = dt.Rows[0][6].ToString();
                    //TxtOsb.Text = dt.Rows[0][7].ToString();
                    //if (dt.Rows[0][8].ToString() == "N")
                    //{
                    //    ChekActivo.Checked = true;
                    //}
                    //else
                    //{
                    //    ChekActivo.Checked = false;
                    //}
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

        private void Btnmas_Click(object sender, EventArgs e)
        {
            Dgprincipal.Rows.Add();
        }

        private void Dgprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        //private void Dgprincipal_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex == 0)
        //    {
        //        e.Value = e.RowIndex + 1;
        //    }
        //}
    }
}

    
 

