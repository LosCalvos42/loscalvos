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
    public partial class FrmDefinicionProcesosDetalle : Form
    {
        public string ID { get; set; }
        public string MODO { get; set; }
        string ARTI { get; set; }
        
        double CostoTotal { get; set; } = 0.00;

        public FrmDefinicionProcesosDetalle()
        {
            InitializeComponent();
        }
        private void FrmDefinicionProcesosDetalle_Load(object sender, EventArgs e)
        {
            Cargarcombo("TPROCESO", cmbTProceso);
            Cargarcombo("ALMA", cmbAlmacen);

            Cargar();
        }

        private void Cargar()
        {
            switch (MODO)
            {
                case "NUEVO":
                    Console.WriteLine("One");
                    break;
                case "MODIFICACION":
                    Console.WriteLine("Two");
                    Console.WriteLine("Two");
                    break;
                case "ELIMINAR":
                    Console.WriteLine("Other");
                    break;
            }
        }


        private void Cargarcombo(string combo,ComboBox _combo)
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
                _combo.ValueMember = "ID";
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pBuscar_Click(object sender, EventArgs e)
        {
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar
            {
                StartPosition = FormStartPosition.CenterScreen,
                combo = "ARTI"
            };
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {
                string codProd = _FrmGrillaBuscar.Codigo; 
                ARTI = _FrmGrillaBuscar.nombre;
                txtBuscar.Text = codProd; 
                //nombreProd = nombreArt;
                txtIDProd.Text = Convert.ToString(_FrmGrillaBuscar.id);
                txtNombreArt.Text = txtNombreTProceso.Text+" de " +ARTI;
                txtProCanti.Focus();
            }
        }

        private void cmbTProceso_Leave(object sender, EventArgs e)
        {
            if (cmbTProceso.Text != "-Select-")
            { 
                string[] datos = cmbTProceso.Text.Split('-');
                txtNombreTProceso.Text = datos[1];
}
            }

        private void chekGenArt_CheckedChanged(object sender, EventArgs e)
        {
            if (chekGenArt.Checked == true)
            {

                pnArti.Visible = true;
                label2.Text = "Código Producto:";
                txtCodProceso.Text = "";
                txtBuscar.Text = "";
                cmbAlmacen.Enabled = true;
                cmbAlmacen.SelectedValue = 0;
            }
            else
            {
                pnArti.Visible = false;
                label2.Text = "Código Proceso:";
                txtCodProceso.Text = "";
                txtBuscar.Text = "";
                cmbAlmacen.Enabled = false;
                cmbAlmacen.SelectedValue = 0;
            }
        }

        private void txtProCanti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)46) && (e.KeyChar != (char)13))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtProCanti_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProCanti.Text != "")
                {

                    double n = Convert.ToDouble(txtProCanti.Text.Replace(".", ","));
                    txtProCanti.Text = string.Format("{0:n}", n);
                }
                treresumen();
                //dg_resultado();
                //sivalido = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor = Color.DarkGray;
        }

        private void pBuscar_MouseHover(object sender, EventArgs e)
        {
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pBuscar_MouseLeave(object sender, EventArgs e)
        {
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor = Color.Transparent;
        }

        //
        
        private void pBuscar2_Click(object sender, EventArgs e)
        {
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar
            {
                StartPosition = FormStartPosition.CenterScreen,
                combo = "ARTI"
            };
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {
                string codProd = _FrmGrillaBuscar.Codigo;
                string nombreArt = _FrmGrillaBuscar.nombre;
                //txtBuscar2.Text = codProd;
                //txtMateriaPrima.Text = nombreArt;
                txtProCanti.Focus();
            }
        }

        private void txtCantiDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)46) && (e.KeyChar != (char)13))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantiDetalle_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProCanti.Text != "")
                {

                    //double n = Convert.ToDouble(txtCantiDetalle.Text.Replace(".", ","));
                    //txtCantiDetalle.Text = string.Format("{0:n}", n);
                }
                //sivalido = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMasMP_Click(object sender, EventArgs e)
        {
            FrmAgregarItem _FrmAgregarItem = new FrmAgregarItem
            {
                StartPosition = FormStartPosition.CenterScreen,
                Grilla = "Arti"
            };
            if (_FrmAgregarItem.ShowDialog() == DialogResult.OK)
            {
                dgMPrima.Rows.Add(1);
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[0].Value = 0;
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[1].Value = _FrmAgregarItem.Codigo;
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[2].Value = _FrmAgregarItem.Descrip;
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[3].Value = _FrmAgregarItem.Cantidad;
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[4].Value = _FrmAgregarItem.Costo;
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[5].Value = Convert.ToDecimal(dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[3].Value.ToString())* Convert.ToDecimal(dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[4].Value.ToString());
                dgMPrima.Rows[dgMPrima.RowCount - 1].Cells[0].Value = _FrmAgregarItem.id;

            }
            treresumen();
        }

        private void treresumen()
        {

            dg_resultado();
            CostoTotal = 0.0;
            treResumen.Nodes.Clear();
            treResumen.Nodes.Add(txtNombreArt.Text).ForeColor=Color.Blue;

            TreeNode node;
///////////////////////////////////////////////////////////
            node = treResumen.Nodes.Add("MATERIA PRIMA");
            node.ForeColor = Color.FromArgb(40, 53, 147);
            for (int i = 0; i < dgMPrima.RowCount; i++)
            {
                string codigo = dgMPrima.Rows[i].Cells[1].Value.ToString();
                string nombre = dgMPrima.Rows[i].Cells[2].Value.ToString();
                double canti = Convert.ToDouble(dgMPrima.Rows[i].Cells[3].Value.ToString());
                node.Nodes.Add(String.Format("{0,-50}",codigo.PadLeft(10, '_')) + " - " + String.Format("{0,-50}",nombre.PadRight(50,'.')) + String.Format("{0,50}",canti.ToString("N2").PadLeft(50,'.'))).ForeColor = Color.FromArgb(39, 55, 70);
                CostoTotal = CostoTotal + Convert.ToDouble(dgMPrima.Rows[i].Cells[5].Value.ToString());


            }

//////////////////////////////////////////////////
            node = treResumen.Nodes.Add("MAQUINARIAS");
            node.ForeColor = Color.FromArgb(40, 53, 147);
            for (int i = 0; i < dgMaquinas.RowCount; i++)
            {
                string codigo = dgMaquinas.Rows[i].Cells[1].Value.ToString();
                string nombre = dgMaquinas.Rows[i].Cells[2].Value.ToString();
                double canti = Convert.ToDouble(dgMaquinas.Rows[i].Cells[3].Value.ToString());
                node.Nodes.Add(String.Format("{0,-50}", codigo.PadLeft(10, '_')) + " - " + String.Format("{0,-50}", nombre.PadRight(50, '.')) + String.Format("{0,50}", canti.ToString("N2").PadLeft(50, '.'))).ForeColor = Color.FromArgb(39, 55, 70);
                CostoTotal = CostoTotal + Convert.ToDouble(dgMaquinas.Rows[i].Cells[5].Value.ToString());

            }
            ////////////////////////////////////////////
            node = treResumen.Nodes.Add("PERSONAL");
            node.ForeColor = Color.FromArgb(40, 53, 147);
            for (int i = 0; i < dgRecursoH.RowCount; i++)
            {
                string codigo = dgRecursoH.Rows[i].Cells[1].Value.ToString();
                string nombre = dgRecursoH.Rows[i].Cells[2].Value.ToString();
                double canti = Convert.ToDouble(dgRecursoH.Rows[i].Cells[3].Value.ToString());
                node.Nodes.Add(String.Format("{0,-50}", codigo.PadLeft(10, '_')) + " - " + String.Format("{0,-50}", nombre.PadRight(50, '.')) + String.Format("{0,50}", canti.ToString("N2").PadLeft(50, '.'))).ForeColor = Color.FromArgb(39, 55, 70);
                CostoTotal = CostoTotal + Convert.ToDouble(dgRecursoH.Rows[i].Cells[5].Value.ToString());

            }
            //dgResultado.Rows.Clear();
            //dgResultado.Rows.Add(1);
            dgResultado.Rows[dgResultado.RowCount - 1].Cells[5].Value = CostoTotal;
            dgResultado.Rows[dgResultado.RowCount - 1].Cells[4].Value = CostoTotal / Convert.ToDouble(txtProCanti.Text);
        }

        private void btnMasMQ_Click(object sender, EventArgs e)
        {
            FrmAgregarItem _FrmAgregarItem = new FrmAgregarItem
            {
                StartPosition = FormStartPosition.CenterScreen,
                Grilla = "MAQUI"
            };
            if (_FrmAgregarItem.ShowDialog() == DialogResult.OK)
            {
                dgMaquinas.Rows.Add(1);
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[0].Value = 0;
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[1].Value = _FrmAgregarItem.Codigo;
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[2].Value = _FrmAgregarItem.Descrip;
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[3].Value = _FrmAgregarItem.Cantidad;
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[4].Value = _FrmAgregarItem.Costo;
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[5].Value = Convert.ToDecimal(dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[3].Value.ToString()) * Convert.ToDecimal(dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[4].Value.ToString());
                dgMaquinas.Rows[dgMaquinas.RowCount - 1].Cells[0].Value = _FrmAgregarItem.id;
            }
            treresumen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMasOP_Click(object sender, EventArgs e)
        {
            FrmAgregarItem _FrmAgregarItem = new FrmAgregarItem
            {
                StartPosition = FormStartPosition.CenterScreen,
                Grilla = "OPE"
            };
            if (_FrmAgregarItem.ShowDialog() == DialogResult.OK)
            {
                dgRecursoH.Rows.Add(1);
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[0].Value = 0;
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[1].Value = _FrmAgregarItem.Codigo;
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[2].Value = _FrmAgregarItem.Descrip;
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[3].Value = _FrmAgregarItem.Cantidad;
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[4].Value = _FrmAgregarItem.Costo;
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[5].Value = Convert.ToDecimal(dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[3].Value.ToString()) * Convert.ToDecimal(dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[4].Value.ToString());
                dgRecursoH.Rows[dgRecursoH.RowCount - 1].Cells[0].Value = _FrmAgregarItem.id;
            }
            treresumen();
        }

        private void pBuscar2_MouseUp(object sender, MouseEventArgs e)
        {
            //pBuscar2.BackColor = Color.Transparent;
        }
        private bool valido()
        {
            if (txtNombreTProceso.Text == "")
            {
                MessageBox.Show("Hay Datos Sin completar (Tipo de Proceso)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTProceso.Focus();
                return false;
            }
            
            if (chekGenArt.Checked == false)
            {
                if (txtCodProceso.Text == "")
                {
                    MessageBox.Show("Hay Datos Sin completar (Codigo de Proceso)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodProceso.Focus();
                    return false;
                }

            }
            else
            {
                if (txtBuscar.Text == "")
                {
                    MessageBox.Show("Hay Datos Sin completar (Codigo de Producto)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBuscar.Focus();
                    return false;
                }

                if (cmbAlmacen.SelectedIndex == 0)
                {
                    MessageBox.Show("Hay Datos Sin completar (Almacen De Resultado)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbAlmacen.Focus();
                    return false;
                }


            }
            if (txtNombreArt.Text == "")
            {
                MessageBox.Show("Hay Datos Sin completar (Nombre Proceso)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreArt.Focus();
                return false;
            }
            if (txtProCanti.Text == "")
            {
                MessageBox.Show("Hay Datos Sin completar (Cantidad)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProCanti.Focus();
                return false;
            }

            if (dgMPrima.RowCount==0 && dgMaquinas.RowCount==0 && dgRecursoH.RowCount == 0)
            {
                //if (MessageBox.Show("¿Confirma Que Desea Grabar el Proceso sin ningún RECURSO?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                //{
                //    return false;
                //}
                MessageBox.Show("No Hay ningún RECURSO ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }


            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (MODO)
            {
                case "NUEVO":
                    
                    if (valido() == true)
                    {
                        string[] msg=alta();

                        if (msg[0]=="0")
                        {

                            MessageBox.Show(msg[1], "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            
                            MessageBox.Show(msg[1], "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                            return;
                        }
                        
                    }
                    else
                    {
                        return;
                    }


                    break;
                case "MODIFICACION":
                    Console.WriteLine("Two");
                    Console.WriteLine("Two");
                    break;
                case "ELIMINAR":
                    Console.WriteLine("Other");
                    break;
            }
        }

        private String[] alta()
        {
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //cabecera PROCPRODH
                if (chekGenArt.Checked == false)
                {
                    lst.Add(new ClsParametros("@CODIGO", txtCodProceso.Text));
                    lst.Add(new ClsParametros("@GENARTICULO", 0));
                    lst.Add(new ClsParametros("@ARTI_ID", 0));
                    lst.Add(new ClsParametros("@RESULTADO_ALMACEN_ID", 0));

                }
                else
                {
                  lst.Add(new ClsParametros("@CODIGO", txtBuscar.Text));
                  lst.Add(new ClsParametros("@GENARTICULO", 1));
                  lst.Add(new ClsParametros("@ARTI_ID", Convert.ToInt32(txtIDProd.Text)));
                  lst.Add(new ClsParametros("@RESULTADO_ALMACEN_ID", Convert.ToInt32(cmbAlmacen.SelectedValue)));
                }
                lst.Add(new ClsParametros("@NOMBRE", txtNombreArt.Text));
                lst.Add(new ClsParametros("@TPROCESO_ID",cmbTProceso.SelectedIndex));
                lst.Add(new ClsParametros("@CANTIDAD", Convert.ToDouble(txtProCanti.Text)));
                lst.Add(new ClsParametros("@COSTO_TOTAL", CostoTotal));
                if (chekGenArt.Checked == false)
                {
                    lst.Add(new ClsParametros("@RESERVASTOCK", 0));
                }
                else
                {
                    lst.Add(new ClsParametros("@RESERVASTOCK", 1));
                }
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("sp_alta_ProcesoH", ref lst);              
                msj = new string[2];
                msj[0] = lst[9].Valor.ToString();
                msj[1] = lst[10].Valor.ToString();

                ///////
                /// Lieneas PROCPRODI
                int idProceso = Convert.ToInt32(msj[0]);
                if (msj[0] != "0") {
                    for (int i = 0; i <= dgMPrima.Rows.Count - 1; i++)
                    {
                        lst.Clear();
                        lst.Add(new ClsParametros("@PROCPRODH_ID", idProceso));
                        lst.Add(new ClsParametros("@PROCRECURSO_ID", "MTPC"));
                        lst.Add(new ClsParametros("@RECURSO_ID", Convert.ToInt32(dgMPrima.Rows[i].Cells[0].Value.ToString())));
                        lst.Add(new ClsParametros("@CANTIDAD", Convert.ToDouble(dgMPrima.Rows[i].Cells[3].Value.ToString())));
                        lst.Add(new ClsParametros("@PRECIO", Convert.ToDouble(dgMPrima.Rows[i].Cells[4].Value.ToString())));
                        lst.Add(new ClsParametros("@IMPORTE", Convert.ToDouble(dgMPrima.Rows[i].Cells[5].Value.ToString())));
                        lst.Add(new ClsParametros("@RESULTADO", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                        lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));//msj = lst[2].Valor.ToString();
                        M.EjecutarSP("sp_alta_ProcesoI", ref lst);
                        //msj = new string[2];
                        msj[0] = lst[6].Valor.ToString();
                        msj[1] = lst[7].Valor.ToString();
                    }

                    for (int i = 0; i <= dgMaquinas.Rows.Count - 1; i++)
                    {
                        lst.Clear();
                        lst.Add(new ClsParametros("@PROCPRODH_ID", idProceso));
                        lst.Add(new ClsParametros("@PROCRECURSO_ID", "MQ"));
                        lst.Add(new ClsParametros("@RECURSO_ID", Convert.ToInt32(dgMaquinas.Rows[i].Cells[0].Value.ToString())));
                        lst.Add(new ClsParametros("@CANTIDAD", Convert.ToDouble(dgMaquinas.Rows[i].Cells[3].Value.ToString())));
                        lst.Add(new ClsParametros("@PRECIO", Convert.ToDouble(dgMaquinas.Rows[i].Cells[4].Value.ToString())));
                        lst.Add(new ClsParametros("@IMPORTE", Convert.ToDouble(dgMaquinas.Rows[i].Cells[5].Value.ToString())));
                        lst.Add(new ClsParametros("@RESULTADO", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                        lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));//msj = lst[2].Valor.ToString();
                        M.EjecutarSP("sp_alta_ProcesoI", ref lst);
                        //msj = new string[2];
                        msj[0] = lst[6].Valor.ToString();
                        msj[1] = lst[7].Valor.ToString();
                    }


                    for (int i = 0; i <= dgRecursoH.Rows.Count - 1; i++)
                    {
                        lst.Clear();
                        lst.Add(new ClsParametros("@PROCPRODH_ID", idProceso));
                        lst.Add(new ClsParametros("@PROCRECURSO_ID", "RH"));
                        lst.Add(new ClsParametros("@RECURSO_ID", Convert.ToInt32(dgRecursoH.Rows[i].Cells[0].Value.ToString())));
                        lst.Add(new ClsParametros("@CANTIDAD", Convert.ToDouble(dgRecursoH.Rows[i].Cells[3].Value.ToString())));
                        lst.Add(new ClsParametros("@PRECIO", Convert.ToDouble(dgRecursoH.Rows[i].Cells[4].Value.ToString())));
                        lst.Add(new ClsParametros("@IMPORTE", Convert.ToDouble(dgRecursoH.Rows[i].Cells[5].Value.ToString())));
                        lst.Add(new ClsParametros("@RESULTADO", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                        lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));//msj = lst[2].Valor.ToString();
                        M.EjecutarSP("sp_alta_ProcesoI", ref lst);
                        //msj = new string[2];
                        msj[0] = lst[6].Valor.ToString();
                        msj[1] = lst[7].Valor.ToString();
                    }
                    /// Resultado
                    lst.Clear();
                    lst.Add(new ClsParametros("@PROCPRODH_ID", idProceso));
                    lst.Add(new ClsParametros("@CODIGO", dgResultado.Rows[0].Cells[1].Value.ToString()));
                    lst.Add(new ClsParametros("@DESCRIPCION", dgResultado.Rows[0].Cells[2].Value.ToString()));
                    lst.Add(new ClsParametros("@CANTIDAD", Convert.ToDouble(dgResultado.Rows[0].Cells[3].Value.ToString())));
                    lst.Add(new ClsParametros("@PRECIO", Convert.ToDouble(dgResultado.Rows[0].Cells[4].Value.ToString())));
                    lst.Add(new ClsParametros("@IMPORTE", Convert.ToDouble(dgResultado.Rows[0].Cells[5].Value.ToString())));
                    lst.Add(new ClsParametros("@RESULTADO", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                    lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                    M.EjecutarSP("sp_alta_ProcesoR", ref lst);
                    msj[0] = lst[6].Valor.ToString();
                    msj[1] = lst[7].Valor.ToString();
                }
            }
            catch (Exception ex)
            {
                msj = new string[2];
                msj[0] = "0";
                msj[1] = ex.Message;

            }
            return msj;
        }

        private void btnMenosMP_Click(object sender, EventArgs e)
        {
            if (dgMPrima.SelectedRows.Count > 0)
            {

                dgMPrima.Rows.RemoveAt(dgMPrima.CurrentRow.Index);
                treresumen();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Item para Eliminar.", "SystemCenter.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_resultado()
        {

            dgResultado.Rows.Clear();
            dgResultado.Rows.Add(1);
            if (chekGenArt.Checked == false)
            {
               dgResultado.Rows[dgResultado.RowCount - 1].Cells[1].Value = txtCodProceso.Text;
            }
            else
            {  
               dgResultado.Rows[dgResultado.RowCount - 1].Cells[1].Value = txtBuscar.Text;
            }

            
            dgResultado.Rows[dgResultado.RowCount - 1].Cells[2].Value =txtNombreArt.Text;
            dgResultado.Rows[dgResultado.RowCount - 1].Cells[3].Value = txtProCanti.Text;

        }

        private void btnMenosMQ_Click(object sender, EventArgs e)
        {
            if (dgMaquinas.SelectedRows.Count > 0)
            {

                dgMaquinas.Rows.RemoveAt(dgMaquinas.CurrentRow.Index);
                treresumen();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Item para Eliminar.", "SystemCenter.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenosOP_Click(object sender, EventArgs e)
        {
            if (dgRecursoH.SelectedRows.Count > 0)
            {

                dgRecursoH.Rows.RemoveAt(dgRecursoH.CurrentRow.Index);
                treresumen();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Item para Eliminar.", "SystemCenter.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
