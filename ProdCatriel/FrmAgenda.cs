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
using System.Windows.Forms.DataVisualization.Charting;

namespace TRAZAAR
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
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
            Cargarcombo("ARTICULOAGENDA", CmbProducto,"");
            //Cargarcombo("PROCESO", CmbProceso);
            //Cargarcombo("ESTADOS", CmbEstado);
            Cargarcombo("CATEGORIAS", CmbCategoria, CmbProducto.SelectedValue.ToString());

            //id = Convert.ToInt32(this.Text.Split()[2]);
            Inicio();

        }
        private void limpiarObjetos() {
            
            //TxtCodigo.Text = "";
            //TxtDescripcion.Text = "";
            //TxtObs.Text = "";
        }

        private void CargaraGrilla()
        {
            string CATEG = "";
            CATEG = CmbCategoria.SelectedValue.ToString();
            Dgprincipal.DataSource = null;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@codprod", CmbProducto.SelectedValue));
                lst.Add(new ClsParametros("@categoria", CATEG));
                dt = M.Listado("SP_GetAgenda", lst);
                if (dt.Rows.Count > 0)
                {
                    Dgprincipal.DataSource = dt;
                    Dgprincipal.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(142, 68, 173);
                    Dgprincipal.Columns[0].DefaultCellStyle.ForeColor = Color.White;
                    Dgprincipal.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 188);
                    Dgprincipal.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(178, 235, 242);
                    Dgprincipal.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(197, 202, 233);
                    Dgprincipal.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                    Dgprincipal.Columns[5].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                    Dgprincipal.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 128);
                    Dgprincipal.CellBorderStyle = DataGridViewCellBorderStyle.None;
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

                if(combo== "ARTICULOAGENDA")
                {
                    topItem[2] = "-Select-";
                }
                else
                {
                    topItem[2] = "TODAS";
                }
                


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
        }
        

        private bool valido()
        {

            //if (TxtCodigo.Text == "")
            //{
            //    MessageBox.Show("El Campo Nombre NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    TxtCodigo.Focus();
            //    return false;
            //}

            //if (TxtDescripcion.Text == "")
            //{
            //    MessageBox.Show("El Campo Apellido NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    TxtDescripcion.Focus();
            //    return false;
            //}

            return true;
        }
        private String[] AbmUser(string tipo)
        {

            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                
                //lst.Add(new ClsParametros("@Tipo", Tipo));
                //lst.Add(new ClsParametros("@ID", id));
                //lst.Add(new ClsParametros("@CODIGO", TxtCodigo.Text));
                //lst.Add(new ClsParametros("@DESCRIPCION", TxtDescripcion.Text));
                //lst.Add(new ClsParametros("@OBS", TxtObs.Text));
                //lst.Add(new ClsParametros("@USR_ID ", Program.IDUSER));
                
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("sp_AddFamilia", ref lst);
                msj = new string[2];
                msj[0] = lst[7].Valor.ToString();
                msj[1] = lst[8].Valor.ToString();
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
            Cargarcombo("CATEGORIAS", CmbCategoria, CmbProducto.SelectedValue.ToString());
        }
    }
}

    
 

