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
    public partial class FrmAddArticulos : Form
    {
        public FrmAddArticulos()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            //Tipo = this.Text;
            Tipo = this.Text.Split()[0];
            id = Convert.ToInt32(this.Text.Split()[2]);
            Cargarcombo("FAMILIA", cmbFamilia);
            Cargarcombo("TIPOPRODUCTO", cmbTipoproducto);
            Inicio();
        }
        private void limpiarObjetos() {
            id = 0;
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            cmbFamilia.SelectedValue = 1;
            cmbTipoproducto.SelectedValue = 1;
            TxtSanitario.Text = "";
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
                    lst.Add(new ClsParametros("@listado", "PRODUCTOS"));
                    lst.Add(new ClsParametros("@Filtro", ""));
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@DeBaja", ""));
                    //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                    //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                    dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                    if (dt.Rows.Count > 0)
                    {
                       TxtCodigo.Text = dt.Rows[0][1].ToString();
                       TxtDescripcion.Text = dt.Rows[0][2].ToString();
                       cmbFamilia.SelectedValue = dt.Rows[0][3].ToString();
                       cmbTipoproducto.SelectedValue = dt.Rows[0][4].ToString();
                       TxtSanitario.Text = dt.Rows[0][5].ToString();
                        if (dt.Rows[0][6].ToString() == "N")
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
                    lst.Add(new ClsParametros("@listado", "PRODUCTOS"));
                    lst.Add(new ClsParametros("@Filtro", ""));
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@DeBaja", ""));
                    dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                    if (dt.Rows.Count > 0)
                    {

                        TxtCodigo.Text = dt.Rows[0][1].ToString();
                        TxtDescripcion.Text = dt.Rows[0][2].ToString();
                        cmbFamilia.SelectedValue= dt.Rows[0][3].ToString();
                        cmbTipoproducto.SelectedValue = dt.Rows[0][4].ToString();
                        TxtSanitario.Text = dt.Rows[0][5].ToString();

                        if (dt.Rows[0][6].ToString() == "N")
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

            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("El Campo Nombre NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
                return false;
            }

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("El Campo Apellido NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
                return false;
            }
            if (cmbFamilia.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (Perfil)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbFamilia.Focus();
                return false;
            }
            if (TxtSanitario.Text == "")
            {
                MessageBox.Show("El Campo Nombre de Usuario NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                lst.Add(new ClsParametros("@FAMILIA", cmbFamilia.SelectedValue));
                lst.Add(new ClsParametros("@TIPOPRODUCTO", cmbTipoproducto.SelectedValue));
                lst.Add(new ClsParametros("@SANITARIO", TxtSanitario.Text));
                lst.Add(new ClsParametros("@USR_ID ", Program.IDUSER));
                if (chekActivo.Checked == true)
                { 
                    lst.Add(new ClsParametros("@DEBAJA", "N"));
                }
                else
                {
                    lst.Add(new ClsParametros("DEBAJA", "S"));
                }
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("sp_AddArti", ref lst);
                msj = new string[2];
                msj[0] = lst[9].Valor.ToString();
                msj[1] = lst[10].Valor.ToString();
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

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    
 

