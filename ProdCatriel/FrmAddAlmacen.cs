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
    public partial class FrmAddAlmacen : Form
    {
        public FrmAddAlmacen()
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
            Cargarcombo("TIPOALMACEN", cmbTipo);
            Inicio();

        }
        private void limpiarObjetos() {
            
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtUbicacion.Text = "";
            TxtObs.Text = "";
            TxtKgMax.Text = "";
            cmbTipo.SelectedValue = 1;
            TxtTMin.Text= "";
            TxtTMax.Text= "";
            TxtHMin.Text= "";
            TxtHMax.Text= "";
        }


        private void Inicio()
        {
            if (Tipo == "NUEVO")
            {
                id = 0;
                limpiarObjetos();
                chekActivo.Checked = true;

            }
            if (Tipo == "MODIFICAR")
            {
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    lst.Add(new ClsParametros("@listado", "ALMACENES"));
                    lst.Add(new ClsParametros("@Filtro", ""));
                    lst.Add(new ClsParametros("@id", id));
                    lst.Add(new ClsParametros("@DeBaja",""));
                    //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                    //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                    dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                    if (dt.Rows.Count > 0)
                    {
                       
                       TxtCodigo.Text = dt.Rows[0][1].ToString();//,A.[ALMACEN_CODIGO] CODIGO
                       TxtDescripcion.Text = dt.Rows[0][2].ToString();//,A.[ALMACEN_DESCRIPCION] DESCRIPCION
                       TxtUbicacion.Text = dt.Rows[0][3].ToString(); //,A.[ALMACEN_DOMICILIO] UBICACION
                       TxtObs.Text= dt.Rows[0][4].ToString();//,A.[ALMACEN_OBS] OBS
                       TxtKgMax.Text= dt.Rows[0][5].ToString();//,A.[ALMACEN_CAPACIDADPESO][KG MAX]
                       cmbTipo.SelectedValue= dt.Rows[0][6].ToString();//,TI.ALMACENTIPO_DESCRIPCION TIPO
                       TxtTMin.Text= dt.Rows[0][7].ToString();//, A.[ALMACEN_TEMPMIN] [T° MIN]
                       TxtTMax.Text= dt.Rows[0][8].ToString();//,A.[ALMACEN_TEMPMAX][T° MAX]
                       TxtHMin.Text= dt.Rows[0][9].ToString();//,A.[ALMACEN_HUMEMIN][H MIN]	
                       TxtHMax.Text= dt.Rows[0][10].ToString();//,A.[ALMACEN_HUMEMAX][H MAX]

                        if (dt.Rows[0][10].ToString() == "N")
                        {
                            chekActivo.Checked = false;
                        }
                        else
                        {
                            chekActivo.Checked = true;
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
                    lst.Add(new ClsParametros("@listado", "ALMACENES"));
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
                        TxtUbicacion.Text = dt.Rows[0][3].ToString(); //,A.[ALMACEN_DOMICILIO] UBICACION
                        TxtObs.Text = dt.Rows[0][4].ToString();//,A.[ALMACEN_OBS] OBS
                        TxtKgMax.Text = dt.Rows[0][5].ToString();//,A.[ALMACEN_CAPACIDADPESO][KG MAX]
                        cmbTipo.SelectedValue = dt.Rows[0][6].ToString();//,TI.ALMACENTIPO_DESCRIPCION TIPO
                        TxtTMin.Text = dt.Rows[0][7].ToString();//, A.[ALMACEN_TEMPMIN] [T° MIN]
                        TxtTMax.Text = dt.Rows[0][8].ToString();//,A.[ALMACEN_TEMPMAX][T° MAX]
                        TxtHMin.Text = dt.Rows[0][9].ToString();//,A.[ALMACEN_HUMEMIN][H MIN]	
                        TxtHMax.Text = dt.Rows[0][10].ToString();//,A.[ALMACEN_HUMEMAX][H MAX]

                        if (dt.Rows[0][10].ToString() == "N")
                        {
                            chekActivo.Checked = false;
                        }
                        else
                        {
                            chekActivo.Checked = true;
                        }
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

            if (TxtCodigo.Text == "")
            {
                MessageBox.Show("El Campo Codigo NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
                return false;
            }

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("El Campo Descripcion NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
                return false;
            }
            if (cmbTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (Perfil)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTipo.Focus();
                return false;
            }
            if (TxtUbicacion.Text == "")
            {
                MessageBox.Show("El Campo Nombre de Usuario NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
                return false;
            }
            if (TxtTMin.Text == "")
            {
                MessageBox.Show("El Campo  NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                lst.Add(new ClsParametros("@ALMACEN_ID", id));
                lst.Add(new ClsParametros("@ALMACEN_CODIGO", TxtCodigo.Text));
                lst.Add(new ClsParametros("@ALMACEN_DESCRIPCION", TxtDescripcion.Text));
                lst.Add(new ClsParametros("@ALMACEN_DOMICILIO", TxtUbicacion.Text));
                lst.Add(new ClsParametros("@ALMACEN_OBS", TxtObs.Text));
                lst.Add(new ClsParametros("@ALMACEN_CAPACIDADPESO", Convert.ToDouble(TxtKgMax.Text)));
                lst.Add(new ClsParametros("@ALMACENTIPO_CODIGO", cmbTipo.SelectedValue));
                lst.Add(new ClsParametros("@ALMACEN_TEMPMIN", Convert.ToDouble(TxtTMin.Text.Replace(".", ","))));
                lst.Add(new ClsParametros("@ALMACEN_TEMPMAX", Convert.ToDouble(TxtTMax.Text.Replace(".", ","))));
                lst.Add(new ClsParametros("@ALMACEN_HUMEMIN", Convert.ToDouble(TxtHMin.Text.Replace(".", ","))));
                lst.Add(new ClsParametros("@ALMACEN_HUMEMAX", Convert.ToDouble(TxtHMax.Text.Replace(".", ","))));
                lst.Add(new ClsParametros("@USR_ID ", Program.IDUSER));
                if (chekActivo.Checked == true)
                { 
                    lst.Add(new ClsParametros("@ALMACEN_DEBAJA", "N"));
                }
                else
                {
                    lst.Add(new ClsParametros("@ALMACEN_DEBAJA", "S"));
                }
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("sp_AbmAlmacen", ref lst);
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
                    //id = id;
                    //TxtID.Text = dt.Rows[0][0].ToString(); //A.[ALMACEN_ID] ID
                    //TxtCodigo.Text = dt.Rows[0][1].ToString();//,A.[ALMACEN_CODIGO] CODIGO
                    //TxtDescripcion.Text = dt.Rows[0][2].ToString();//,A.[ALMACEN_DESCRIPCION] DESCRIPCION
                    //TxtUbicacion.Text = dt.Rows[0][3].ToString(); //,A.[ALMACEN_DOMICILIO] UBICACION
                    //TxtObs.Text = dt.Rows[0][4].ToString();//,A.[ALMACEN_OBS] OBS
                    //TxtKgMax.Text = dt.Rows[0][5].ToString();//,A.[ALMACEN_CAPACIDADPESO][KG MAX]
                    //cmbTipo.SelectedItem = dt.Rows[0][6].ToString();//,TI.ALMACENTIPO_DESCRIPCION TIPO
                    //TxtTMin.Text = dt.Rows[0][7].ToString();//, A.[ALMACEN_TEMPMIN] [T° MIN]
                    //TxtTMax.Text = dt.Rows[0][8].ToString();//,A.[ALMACEN_TEMPMAX][T° MAX]
                    //TxtHMin.Text = dt.Rows[0][9].ToString();//,A.[ALMACEN_HUMEMIN][H MIN]	
                    //TxtHMax.Text = dt.Rows[0][10].ToString();//,A.[ALMACEN_HUMEMAX][H MAX]
                    //Perfil = Convert.ToInt32(cmbPerfil.SelectedValue);
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
    }
}

    
 

