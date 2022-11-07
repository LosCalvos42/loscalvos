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
    public partial class FrmForAddComponentes : Form
    {
        public FrmForAddComponentes()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }

        public string PrecioAnterior { get; set; }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            //Tipo = this.Text;
            Tipo = this.Text.Split()[0];
            id = Convert.ToInt32(this.Text.Split()[2]);
            Cargarcombo("FOR_CLASIFICACION", CmbClasificacion);
            Cargarcombo("UNIMED", CmbUnimed);
            Inicio();
        }
        private void limpiarObjetos() {
            
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
        }
        private void Inicio()
        {
            if (Tipo == "NUEVO")
            {
                id = 0;
                limpiarObjetos();
                chekActivo.Checked = true;
                groupBox1.Enabled = true;
            }
            if (Tipo == "MODIFICAR")
            {
                groupBox1.Enabled = true;
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
                        CmbClasificacion.SelectedValue=dt.Rows[0][3].ToString();
                        CmbUnimed.SelectedValue = dt.Rows[0][5].ToString();
                        TxtPrecio.Text= dt.Rows[0][6].ToString();
                        PrecioAnterior = TxtPrecio.Text;
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
                        CmbUnimed.SelectedValue = dt.Rows[0][4].ToString();
                        TxtPrecio.Text = dt.Rows[0][6].ToString();
                        PrecioAnterior = TxtPrecio.Text;
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
                lst.Add(new ClsParametros("@Clasificacion", CmbClasificacion.SelectedValue));
                if (TxtPrecio.Text != PrecioAnterior) 
                {
                    lst.Add(new ClsParametros("@ModPrecio","SI" ));
                }
                else
                {
                    lst.Add(new ClsParametros("@ModPrecio", "NO"));
                }
                lst.Add(new ClsParametros("@Unimed", CmbUnimed.SelectedValue));
                lst.Add(new ClsParametros("@PRECIO", Convert.ToDecimal(TxtPrecio.Text)));
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
                M.EjecutarSP("SP_For_AddComponentes", ref lst);
                msj = new string[2];
                msj[0] = lst[10].Valor.ToString();
                msj[1] = lst[11].Valor.ToString();
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
            try
            {
                if (TxtPrecio.Text != "")
                {

                    double n = Convert.ToDouble(TxtPrecio.Text.Replace(".", ","));
                    TxtPrecio.Text = string.Format("{0:n}", n);
                    //TxtDescuento.Text= TxtDescuento.Text.Replace(",", ".");

                }
                //sivalido = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            TxtPrecio.Text = TxtPrecio.Text.Replace(".", "");
            TxtPrecio.Focus();
            TxtPrecio.Select(TxtPrecio.Text.Length, 0);
        }
    }
}

    
 

