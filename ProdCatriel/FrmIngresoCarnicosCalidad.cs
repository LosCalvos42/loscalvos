using System;
using Datos;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Alberdi
{
    public partial class FrmIngresoCarnicosCalidad : Form
    {
        public FrmIngresoCarnicosCalidad()
        {
            InitializeComponent();
        }
        
        public int Nroingreso { get; set; }
        public string FECHA { get; set; }
        public string Proveedor { get; set; }
        public string Producto { get; set; }
        public string Oc { get; set; }
        public string Remito { get; set; }
        public string RUTAINFORME { get; set; }

        private void DetalleCaja_Load(object sender, EventArgs e)
        {

            if (Program.perfil!=3)
            {

                BtnAceptar.Visible = false;
                BtnCancelar.Visible = false;
                txtdetalle.ReadOnly = true;
                txtobs.ReadOnly = true;
                Rcumple.Enabled = false;
                Rnocumple.Enabled = false;
                GbInforme.Enabled = false;
                

            }

            RUTAINFORME = "";
            lblOC.Text = Oc;
            LblProducto.Text = Producto;
            LblRemito.Text = Remito;
            lblProveedor.Text = Proveedor;
            LlenarGrid(Oc);
            //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;


        }

        private void LlenarGrid(string oc)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            { 
                lst.Add(new ClsParametros("@OC", oc));
                lst.Add(new ClsParametros("@REMITO", Remito));
                lst.Add(new ClsParametros("@DETALLE", txtdetalle.Text));
                lst.Add(new ClsParametros("@OBSERVACION", txtobs.Text));
                if (Rcumple.Checked) { lst.Add(new ClsParametros("@CUMPLE", "S")); }
                else if (Rnocumple.Checked) { lst.Add(new ClsParametros("@CUMPLE", "N"));}
                else { lst.Add(new ClsParametros("@CUMPLE", "")); }
                lst.Add(new ClsParametros("@TIPO", 1));
                lst.Add(new ClsParametros("@RUTAINFORME", RUTAINFORME));
                lst.Add(new ClsParametros("@NOMBREINFORME", TxtRutainforme.Text));
                lst.Add(new ClsParametros("@ING", Nroingreso));
                dt = M.Listado("SP_CatrielIngresosControlCalidad", lst);

                if (dt.Rows.Count > 0)
                {
                    txtdetalle.Text = dt.Rows[0][2].ToString();
                    txtobs.Text = dt.Rows[0][3].ToString();
                   
                    if (dt.Rows[0][4].ToString()=="S")
                    {
                        Rcumple.Checked = true;
                    }
                    if (dt.Rows[0][4].ToString() == "N")
                    {
                        Rnocumple.Checked = true;
                    }
                    RUTAINFORME= dt.Rows[0][5].ToString();
                    TxtRutainforme.Text= dt.Rows[0][6].ToString();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

            if (Rcumple.Checked)
            {
                this.BackColor = Color.FromArgb(213, 245, 227);
            }
            else
            {
                this.BackColor = Color.FloralWhite;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rnocumple.Checked)
            {
                this.BackColor = Color.FromArgb(250, 219, 216);
            }
            else
            {
                this.BackColor = Color.FloralWhite;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está Seguro que Desea Modificar el Informe?", "SeguimientoTWINS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClsManejador M = new ClsManejador();
                    DataTable dt = new DataTable();
                    List<ClsParametros> lst = new List<ClsParametros>();

                    lst.Add(new ClsParametros("@OC", Oc));
                    lst.Add(new ClsParametros("@REMITO", Remito));
                    lst.Add(new ClsParametros("@DETALLE", txtdetalle.Text));
                    lst.Add(new ClsParametros("@OBSERVACION", txtobs.Text));
                    if (Rcumple.Checked) { lst.Add(new ClsParametros("@CUMPLE", "S")); }
                    else if (Rnocumple.Checked) { lst.Add(new ClsParametros("@CUMPLE", "N")); }
                    else { lst.Add(new ClsParametros("@CUMPLE", "")); }
                    lst.Add(new ClsParametros("@TIPO", 2));
                    lst.Add(new ClsParametros("@RUTAINFORME", RUTAINFORME));
                    lst.Add(new ClsParametros("@NOMBREINFORME", TxtRutainforme.Text));
                    lst.Add(new ClsParametros("@ING", Nroingreso));
                    dt = M.Listado("SP_CatrielIngresosControlCalidad", lst);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                // El siguiente código servirá para que el texto del textbox2 sea igual a la ruta seleccionada + desde el último índice de "\", para copiar el nombre de la carpeta.
                var resultado = Opinforme.ShowDialog();
                    
                    if (resultado == DialogResult.OK)
                    {
                    TxtRutainforme.Text = Opinforme.SafeFileName;//+ Opinforme.FileName;
                        
                        RUTAINFORME = Opinforme.FileName;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor; 
                if (RUTAINFORME == "")
                {
                    MessageBox.Show("¿El Archivo NO esta Disponible", "Ctrl. Calidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Cursor = Cursors.Default;
                    return;
                }
                Process.Start(RUTAINFORME);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

