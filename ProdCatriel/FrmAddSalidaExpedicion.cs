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
    public partial class FrmAddSalidaExpedicion : Form
    {
        public FrmAddSalidaExpedicion()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
     
        public string Listado { get; set; }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            Tipo = this.Text.Split()[0];
            //id = Convert.ToInt32(this.Text.Split()[2]);
            //Cargarcombo("CAMBIOALMACEN", cmbTipo);
            Inicio();
        }
        private void limpiarObjetos() 
        { 
            TxtCodBar.Text = "";
            //cmbTipo.SelectedValue = 1;  
        }
        private void Inicio()
        {
            if (Tipo == "INGRESO")
            {
                id = 0;
                limpiarObjetos();
                Limpio();
            }
            if (Tipo == "SALIDA")
            {
                id = 0;
                limpiarObjetos();
                Limpio();
            }
            if (Tipo == "MODIFICAR")
            {
                
               

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
        private void Limpio()
        {
            LblCamaraOrigen.Text = "";
            LblVto.Text = "";
            LblProducto.Text = "";
            LblLote.Text = "";
            LblCantidad.Text = "";
            LblBruto.Text = "";
            LblTara.Text = "";
            LblKilos.Text = "";
            LblBarcod.Text = "";
            LblFechaPro.Text = "";
            TxtInfo.Text = "";
            panelCodbar.BackgroundImage = null;
            panelCodbar.BackgroundImageLayout = ImageLayout.Center;
            this.Refresh();
        }
        private bool valido()
        {

            if (TxtCodBar.Text == "")
            {
                MessageBox.Show("El Campo Codigo NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodBar.Focus();
                return false;
            }

            if (TxtCodBar.Text == "")
            {
                MessageBox.Show("El Campo Descripcion NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodBar.Focus();
                return false;
            }
            //if (cmbTipo.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Debe Seleccionar Almacén de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cmbTipo.Focus();
            //    return false;
            //}
            return true;
        }
        private String[] AddCambioAlmacen(string CodBar)
        {

            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //cabecera PROCPRODH Convert.ToInt32(cmbPerfil.SelectedValue)
                lst.Add(new ClsParametros("@CodBar", CodBar));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_AddSalidaExpedicion", ref lst);
                msj = new string[2];
                msj[0] = lst[1].Valor.ToString();
                msj[1] = lst[2].Valor.ToString();
            }

            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = "Error";
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
        

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CargarDatosOrigen();
                TxtCodBar.Text = "";
            }
        }
        private void CargarDatosOrigen()
        {
            Limpio();
            if (valido())
            {
                try
                {
                    ClsManejador M = new ClsManejador();
                    DataTable dt = new DataTable();
                    List<ClsParametros> lst = new List<ClsParametros>();
                    lst.Add(new ClsParametros("@CodBar", TxtCodBar.Text));

                    dt = M.Listado("SP_GetInfoCodbar", lst);
                    if (dt.Rows.Count > 0)
                    {
                        BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                        LblProducto.Text = dt.Rows[0][1].ToString() + "-" + dt.Rows[0][2].ToString();
                        LblLote.Text = "Lote: " + dt.Rows[0][3].ToString();
                        LblCantidad.Text = "Cant: " + dt.Rows[0][4].ToString();
                        LblBruto.Text = "Bruto: " + dt.Rows[0][5].ToString();
                        LblTara.Text = "Tara: " + dt.Rows[0][6].ToString();
                        LblKilos.Text = dt.Rows[0][7].ToString() + " Kg";
                        LblBarcod.Text = dt.Rows[0][8].ToString();
                        LblFechaPro.Text = "F.Prod: " + dt.Rows[0][9].ToString();
                        LblVto.Text = "Vto: " + dt.Rows[0][10].ToString();
                        LblCamaraOrigen.Text = "Camara Origen: " + dt.Rows[0][11].ToString();
                        panelCodbar.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128A, dt.Rows[0][8].ToString(), Color.Black, Color.White, 270, 50);
                        panelCodbar.BackgroundImageLayout = ImageLayout.Center;

                        string[] msg = AddCambioAlmacen(TxtCodBar.Text);

                        if (msg[0] == "ERROR")
                        {
                            TxtInfo.Text = msg[1];
                            TxtInfo.ForeColor = Color.Red;
                            PanelEtiqueta.BackColor = Color.MistyRose;

                        }
                        if(msg[0] == "EXP")
                        {
                            TxtInfo.Text = msg[1];
                            TxtInfo.ForeColor = Color.Red;
                            PanelEtiqueta.BackColor = Color.Salmon;
                        }

                        if (msg[0] == "OK")
                        {
                            TxtInfo.Text = msg[1];
                            TxtInfo.ForeColor = Color.Green;
                            PanelEtiqueta.BackColor = Color.White;

                        }
                    }
                    else
                    {
                        TxtInfo.Text = "Codigo de Barra No Encontrado";
                        TxtInfo.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }
    }
}

