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
    public partial class FrmAddRecepcionDeLotes : Form
    {
        public FrmAddRecepcionDeLotes()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string TieneCategoria { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }
        public string CtlMerma { get; set; }
        public string EstadoCodbar { get; set; }
        public string lotes { get; set; }

        public int uniExclu = 0;
        public decimal kgExclu = 0;
        int Totalunidades = 0;
        decimal TotalKg = 0;


        DataTable DtCategorias = new DataTable();
        DataTable DtExcluidos = new DataTable();

        private void FrmAddRecepcionDeLotes_Load(object sender, EventArgs e)
        {
            TieneCategoria = "";
            Tipo = this.Text;
            LblTitulo.Text = Listado;
            Tipo = this.Text.Split()[0];
            Inicio();
            btnAceptar.Enabled = false;
        }
        private void Pendientes()
        {
            DgPendientes.Rows.Clear();
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@TIPO", "PROCESO"));
                lst.Add(new ClsParametros("@LOTE", ""));
                lst.Add(new ClsParametros("@ARTI", ""));
                dt = M.Listado("SP_BuscarLoteNuevo", lst);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DgPendientes.Rows.Add(dt.Rows[i][0]);
                    DgPendientes.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    DgPendientes.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    DgPendientes.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    DgPendientes.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    DgPendientes.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    DgPendientes.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    DgPendientes.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    DgPendientes.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                }
                DgPendientes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarObjetos()
        {
            DgOrigen.DataSource=null;
            DgOrigen.Refresh();
            Dgprincipal.Rows.Clear();
            Dgprincipal.Refresh();
            treResumen.Nodes.Clear();
            treResumen.Refresh();
            TxtArchivo.Text = "";
            BtnBuscar.Enabled = false;
            btnAceptar.Enabled = false;
            Totalunidades = 0;
            TotalKg = 0;
        }
        private void LimpiarObjetos2()
        {
            Totalunidades = 0;
            TotalKg = 0;
            Dgprincipal.Rows.Clear();
            Dgprincipal.Refresh();
            treResumen.Nodes.Clear();
            treResumen.Refresh();
            TxtArchivo.Text = "";
            btnAceptar.Enabled = false;
        }

        private void Inicio()
        {
            LimpiarObjetos();
            Pendientes();
            DtExcluidos.Columns.Clear();
            DtExcluidos.Clear();
            DtExcluidos.Columns.Add("LINEA", typeof(int));
            DtExcluidos.Columns.Add("LOTE", typeof(String));
            DtExcluidos.Columns.Add("FECHA", typeof(String));
            DtExcluidos.Columns.Add("HORA", typeof(String));
            DtExcluidos.Columns.Add("COD.BARRA", typeof(String));
            DtExcluidos.Columns.Add("KG", typeof(String));
            DtExcluidos.Columns.Add("MOTIVO", typeof(String));
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

            if (MessageBox.Show("Iniciar Proceso de Generacion de Lote: " + DgPendientes.CurrentRow.Cells[3].Value.ToString(),"insertar Lote", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        private void InsertarLote()
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (valido() == true)
            {
                SendDatos();
            }
            else
            {
                return;
            }
        }
        private void SendDatos()
        {
            FrmAddLote _FrmAddLote = new FrmAddLote();

            // CABECERA
            _FrmAddLote.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddLote.NroSector = DgPendientes.CurrentRow.Cells[0].Value.ToString();
            _FrmAddLote.OT= Convert.ToInt32(DgPendientes.CurrentRow.Cells[1].Value.ToString());
            _FrmAddLote.Fecha = Convert.ToString(Convert.ToDateTime(DgPendientes.CurrentRow.Cells[2].Value.ToString()).ToString("yyyyMMdd"));
            _FrmAddLote.Lote = DgPendientes.CurrentRow.Cells[3].Value.ToString();
            _FrmAddLote.CodProd = DgPendientes.CurrentRow.Cells[4].Value.ToString();
            _FrmAddLote.Unicades = Convert.ToInt32(DgPendientes.CurrentRow.Cells[6].Value.ToString());
            _FrmAddLote.kg = Convert.ToDecimal(DgPendientes.CurrentRow.Cells[7].Value.ToString());
            _FrmAddLote.Titulo = "Recepción De Lote";
            // ITEMS
            var DtItems = new DataTable();
            DtItems =(DataTable)DgOrigen.DataSource;
            _FrmAddLote.DtItems = DtItems;

            // ITEMS
            var DtDetalle = new DataTable();
            DtDetalle.Columns.Add("LOTE", typeof(string));
            DtDetalle.Columns.Add("FECHA", typeof(DateTime));
            DtDetalle.Columns.Add("HORA", typeof(string));
            DtDetalle.Columns.Add("BLANCO", typeof(string));
            DtDetalle.Columns.Add("CODIGOBARRA", typeof(string));
            DtDetalle.Columns.Add("KG", typeof(decimal));
            DtDetalle.Columns.Add("CATEGORIA", typeof(string));

            for (int i = 0; i < Dgprincipal.Rows.Count; i++)
            {
                DtDetalle.Rows.Add(Dgprincipal.Rows[i].Cells[1].Value, 
                                Dgprincipal.Rows[i].Cells[2].Value, 
                                Dgprincipal.Rows[i].Cells[3].Value,
                                Dgprincipal.Rows[i].Cells[4].Value, 
                                Dgprincipal.Rows[i].Cells[5].Value,
                                Dgprincipal.Rows[i].Cells[6].Value,
                                Dgprincipal.Rows[i].Cells[7].Value);

            }
            _FrmAddLote.DtLoteDetalle = DtDetalle;
            if (_FrmAddLote.ShowDialog() == DialogResult.Yes)
            {
                Inicio();
            }
        }

        private void Dgprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Buscarorigen(string lote,string Arti)
        {
            DgOrigen.Rows.Clear();
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@TIPO", "ORIGEN"));
                lst.Add(new ClsParametros("@LOTE", lote));
                lst.Add(new ClsParametros("@ARTI", Arti));
                dt = M.Listado("SP_BuscarLoteNuevo", lst);

                //////for (int i = 0; i < dt.Rows.Count; i++)
                //////{
                //////    DgOrigen.Rows.Add(dt.Rows[i][0]);
                //////    DgOrigen.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                //////    DgOrigen.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                //////    DgOrigen.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                //////    DgOrigen.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                //////    DgOrigen.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                //////    DgOrigen.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                //////    DgOrigen.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                //////    DgOrigen.Rows[i].Cells[7].Value = dt.Rows[i][7].ToString();
                //////}
                ///
                DgOrigen.DataSource = dt;
                DgOrigen.Columns[2].Visible = false;
                DgOrigen.Columns[3].Visible = false;
                DgOrigen.Columns[4].Visible = false;
                //Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Dgprincipal.Columns[Dgprincipal.Columns.Count - 1].DefaultCellStyle.Format = "N0";



                DgOrigen.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgPendientes_Click(object sender, EventArgs e)
        {


            this.Cursor = Cursors.AppStarting;

            LimpiarObjetos();
            Buscarorigen(DgPendientes.CurrentRow.Cells[3].Value.ToString(), DgPendientes.CurrentRow.Cells[4].Value.ToString()); 
            DgOrigen.SelectAll();
            GetCategorias(DgPendientes.CurrentRow.Cells[4].Value.ToString());
            BtnBuscar.Enabled = true;
            
            this.Cursor = Cursors.Default;
        }

        private void GetCategorias( string codigo)
        {
            ClsManejador M = new ClsManejador();
            string ssql = @"select C.CATEGORIAPESO_CODIGO, C.CATEGORIAPESO_MIN,C.CATEGORIAPESO_MAX 
                          from CATEGORIAPESO C 
                          where C.CATEGORIAPESO_DEBAJA='N' AND C.ARTI_CODIGO=" + codigo;
            //"AND I.DISPIMPRESORA_ESTADO = 'ON'";
            DtCategorias = M.lisquery(ssql);
            if (DtCategorias.Rows.Count == 0)
            {
                MessageBox.Show("No existen Categorias para este producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TieneCategoria = "SI";

            }
            else
            {
                DtCategorias.Columns.Add("Cant", typeof(Int32));
                DtCategorias.Columns.Add("KG", typeof(decimal));
                if (DtCategorias.Rows.Count > 0)
                {
                    for (int i = 0; i < DtCategorias.Rows.Count; i++)
                    {
                        
                      DtCategorias.Rows[i][3] =0 ;
                      DtCategorias.Rows[i][4] =0.000;
                        
                    }
                }

            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                LimpiarObjetos2();
                var resultado = AbrirTXT.ShowDialog();
                 if (resultado == DialogResult.OK)
                 {
                    if(DgPendientes.CurrentRow.Cells[3].Value.ToString()+".txt" == AbrirTXT.SafeFileName)
                    {
                        TxtArchivo.Text = AbrirTXT.SafeFileName;
                        LeerArchivo(AbrirTXT.FileName);
                    }
                    else
                    {
                        MessageBox.Show("El Archivo Seleccionado NO Corresponde con el LOTE.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                 }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treresumen()
        {
            Totalunidades = 0;
            TotalKg = 0;
            treResumen.Nodes.Clear();
            treResumen.Nodes.Add("LOTE:" + DgPendientes.CurrentRow.Cells[2].Value.ToString()).ForeColor = Color.Blue;

            TreeNode node;
            ///////////////////////////////////////////////////////////
            
            ////////////////////////////////////////////////////
            node = treResumen.Nodes.Add("CATEGORIAS");
            node.ForeColor = Color.Blue;// Color.FromArgb(205; 97; 85);

            for (int i = 0; i < DtCategorias.Rows.Count; i++)
            {
                node.Nodes.Add(String.Format("{0,-2}", DtCategorias.Rows[i][0].ToString().PadLeft(2, '-')) + String.Format("{0,5}", DtCategorias.Rows[i][3].ToString().PadLeft(10, ' ')) + " Uni" + String.Format("{0,5}", DtCategorias.Rows[i][4].ToString().PadLeft(10, ' ')) + " Kgs.").ForeColor = Color.FromArgb(21, 101, 192);

                Totalunidades = Totalunidades+ Convert.ToInt32(DtCategorias.Rows[i][3]);
                TotalKg = TotalKg + Convert.ToDecimal(DtCategorias.Rows[i][4]);

            }
            node.Expand();
            node = treResumen.Nodes.Add("MATERIA PRIMA");
            //node.ForeColor = Color.FromArgb(40, 53, 147);
            node.BackColor = Color.PaleGreen;
            string codigo = DgPendientes.CurrentRow.Cells[3].Value.ToString();
            string nombre = DgPendientes.CurrentRow.Cells[4].Value.ToString();//DgPendientes.Rows[i].Cells[2].Value.ToString();
            node.Nodes.Add(String.Format("{0,-10}", codigo.PadLeft(1, '-')) + " - " + String.Format("{0,-10}", nombre.PadRight(20, ' ')) + String.Format("{0,5}",Totalunidades.ToString().PadLeft(10, ' ')) + " Uni" + String.Format("{0,20}",TotalKg.ToString().PadLeft(10, ' ')) + " kgs.").BackColor = Color.PaleGreen;
            node.Expand();

            node = treResumen.Nodes.Add("EXCLUIDOS");
            //node.ForeColor = Color.Blue;//Color.FromArgb(40, 53, 147);
            node.BackColor = Color.LightPink;
            //ForeColor = Color.LightPink;
            node.Nodes.Add(String.Format("{0,-2}",uniExclu.ToString().PadLeft(10, ' ')) + " Uni" + String.Format("{0,-2}", kgExclu.ToString().PadLeft(10, ' ')) + " Kgs.").BackColor = Color.LightPink;//Color.FromArgb(39, 55, 70);
            //node.NodeFont.Font.LightPink;
            node.Expand();
        }
        private void LeerArchivo(string Archivo)
        {
            for (int i = 0; i < DtCategorias.Rows.Count; i++)
            {

                DtCategorias.Rows[i][3] = 0;
                DtCategorias.Rows[i][4] = 0.000;
                //DtExcluidos.Clear();

            }
            DtExcluidos.Clear();
            uniExclu =0;
            kgExclu=0;
            Dgprincipal.Rows.Clear();
            
            string[] lines = System.IO.File.ReadAllLines(@""+Archivo);
            //System.Console.WriteLine("Contenido del archivo = ");
            foreach (string line in lines)
            {
                string exclu = "S";
                String str = line;

                char[] spearator = { ';' };

                // using the method 
                String[] strlist = str.Split(spearator);
                //Dgprincipal.Rows.Add(1);
                string repetido = "N";
                if (DtCategorias.Rows.Count > 0)
                {



                    if (Dgprincipal.Rows.Count > 0 && Dgprincipal.Rows.Cast<DataGridViewRow>().Any(x => x.Cells[5].Value.ToString() == strlist[4].ToString()))
                    {

                       // repetido = "S";

                        uniExclu = uniExclu + 1;
                        kgExclu = kgExclu + Convert.ToDecimal(strlist[5].ToString());

                        DtExcluidos.Rows.Add();
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][0] = DtExcluidos.Rows.Count;
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][1] = strlist[0].ToString();
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][2] = strlist[1].ToString();
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][3] = strlist[2].ToString();
                        //DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][4] = strlist[3].ToString();
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][4] = strlist[4].ToString();
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][5] = strlist[5].ToString();
                        DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][6] = "Codigo Repetido";
                    }
                    else
                    {

                        

                        for (int i = 0; i < DtCategorias.Rows.Count; i++)
                        {
                            exclu = "S";

                            if (strlist[5].ToString() == "RROR ")
                            {
                                MessageBox.Show("El Archivo contiene Lineas con ERROR.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }

                            else if (Convert.ToDecimal(strlist[5].ToString()) >= Convert.ToDecimal(DtCategorias.Rows[i][1].ToString()) && Convert.ToDecimal(strlist[5].ToString()) < Convert.ToDecimal(DtCategorias.Rows[i][2].ToString()))
                            {
                                DtCategorias.Rows[i][3] = Convert.ToInt32(DtCategorias.Rows[i][3].ToString()) + 1;
                                int y = Convert.ToInt32(DtCategorias.Rows[i][3]);

                                DtCategorias.Rows[i][4] = Convert.ToDecimal(DtCategorias.Rows[i][4].ToString()) + Convert.ToDecimal(strlist[5].ToString());
                                decimal d = Convert.ToDecimal(DtCategorias.Rows[i][4]);
                                Dgprincipal.Rows.Add(1);
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[0].Value = Dgprincipal.Rows.Count;
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[1].Value = strlist[0].ToString();
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[2].Value = strlist[1].ToString();
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[3].Value = strlist[2].ToString();
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[4].Value = strlist[3].ToString();
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[5].Value = strlist[4].ToString();
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[6].Value = strlist[5].ToString();
                                Dgprincipal.Rows[Dgprincipal.Rows.Count - 1].Cells[7].Value = DtCategorias.Rows[i][0];
                                exclu = "N";
                                break;
                            }
                            
                        }
                        if (exclu == "S")
                        { 
                            uniExclu = uniExclu + 1;


                            if (strlist[5].ToString() != "RROR ")
                            {

                                kgExclu = kgExclu + Convert.ToDecimal(strlist[5].ToString());
                            }

                            DtExcluidos.Rows.Add();
                            DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][0] = DtExcluidos.Rows.Count;
                            DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][1] = strlist[0].ToString();
                            DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][2] = strlist[1].ToString();
                            DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][3] = strlist[2].ToString();
                            //DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][4] = strlist[3].ToString();
                            DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][4] = strlist[4].ToString();
                            DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][5] = strlist[5].ToString();


                            //uniExclu = uniExclu + 1;
                            
                            if (strlist[5].ToString() == "RROR ")
                            {
                               
                                DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][6] = "Error en campo Peso (KG)";
                            }
                            else
                            {
                                kgExclu = kgExclu + Convert.ToDecimal(strlist[5].ToString());
                                DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][6] = "Fuera de Categoria";
                            }
                            
                        }
                    }
                }
                else
                {
                    uniExclu = uniExclu + 1;
                    kgExclu = kgExclu + Convert.ToDecimal(strlist[5].ToString());

                    DtExcluidos.Rows.Add();
                    DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][0] = DtExcluidos.Rows.Count;
                    DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][1] = strlist[0].ToString();
                    DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][2] = strlist[1].ToString();
                    DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][3] = strlist[2].ToString();
                    //DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][4] = strlist[3].ToString();
                    DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][4] = strlist[4].ToString();
                    DtExcluidos.Rows[DtExcluidos.Rows.Count - 1][5] = strlist[5].ToString();
                }     
            }  
         
            treresumen();
            if (DtExcluidos.Rows.Count > 0)
            {
                Btn.Enabled = true;

            }

            if (DtCategorias.Rows.Count > 0)
            {
                btnAceptar.Enabled = true;

            }
            else
            {
                btnAceptar.Enabled = false;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmLoteDetalle _FrmLoteDetalle = new FrmLoteDetalle();
            _FrmLoteDetalle.DtExcluidos = DtExcluidos;
            _FrmLoteDetalle.StartPosition = FormStartPosition.CenterScreen;
            _FrmLoteDetalle.ShowDialog();
        }

        private void DgPendientes_KeyUp(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            DgOrigen.Rows.Clear();
            DgOrigen.Refresh();
            Buscarorigen(DgPendientes.CurrentRow.Cells[2].Value.ToString(), DgPendientes.CurrentRow.Cells[3].Value.ToString());
            this.Cursor = Cursors.Default;
            DgOrigen.SelectAll();
            GetCategorias(DgPendientes.CurrentRow.Cells[3].Value.ToString());
            BtnBuscar.Enabled = true;
        }

        private void DgPendientes_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            DgOrigen.Rows.Clear();
            DgOrigen.Refresh();
            Buscarorigen(DgPendientes.CurrentRow.Cells[2].Value.ToString(), DgPendientes.CurrentRow.Cells[3].Value.ToString());
            this.Cursor = Cursors.Default;
            DgOrigen.SelectAll();
            GetCategorias(DgPendientes.CurrentRow.Cells[3].Value.ToString());
            BtnBuscar.Enabled = true;
        }
    }
}

    
 

