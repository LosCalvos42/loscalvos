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
    public partial class FrmAgregarItem : Form
    {
        public FrmAgregarItem()
        {
            InitializeComponent();
        }
        public string Codigo { get; set; }
        public string Descrip { get; set; }
        public double Cantidad { get; set; }
        public double Costo{ get; set; }
        public int id { get; set; }
        public string Grilla { get; set; }

        private void txtCantiDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == (char)Keys.Enter)
           {
                try
                {
                    if (txtCantidad.Text != "")
                    {

                        double n = Convert.ToDouble(txtCantidad.Text.Replace(".", ","));
                        txtCantidad.Text = string.Format("{0:n}", n);
                    }
                    //sivalido = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;
                btnMasMP.PerformClick();
           }

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
                if (txtCantidad.Text != "")
                {

                double n = Convert.ToDouble(txtCantidad.Text.Replace(".", ","));
                txtCantidad.Text = string.Format("{0:n}", n);
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
            if (valido() == true) {
                Codigo = txtCodigo.Text;
                Descrip = txtDescrip.Text;
                Cantidad = Convert.ToDouble(txtCantidad.Text);
                id = id;
            DialogResult = DialogResult.OK;
            this.Close();
            }
        }


        private bool valido()
        {
            
            if (txtDescrip.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un Código", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("El Campo Cantidad NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private void pBuscar2_Click(object sender, EventArgs e)
        {
            FrmGrillaBuscar _FrmGrillaBuscar = new FrmGrillaBuscar();
            _FrmGrillaBuscar.StartPosition = FormStartPosition.CenterScreen;
            _FrmGrillaBuscar.combo = Grilla;
            if (_FrmGrillaBuscar.ShowDialog() == DialogResult.OK)
            {
                txtCodigo.Text = _FrmGrillaBuscar.Codigo;
                txtDescrip.Text = _FrmGrillaBuscar.nombre;
                id = Convert.ToInt32(_FrmGrillaBuscar.id);
                Costo= Convert.ToDouble(_FrmGrillaBuscar.Costo);
            }
        }

        private void pBuscar2_MouseDown(object sender, MouseEventArgs e)
        {
            pBuscar2.BackColor = Color.DarkGray;
        }

        private void pBuscar2_MouseHover(object sender, EventArgs e)
        {
            pBuscar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pBuscar2_MouseLeave(object sender, EventArgs e)
        {
            pBuscar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pBuscar2_MouseUp(object sender, MouseEventArgs e)
        {
            pBuscar2.BackColor = Color.Transparent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
 
}
