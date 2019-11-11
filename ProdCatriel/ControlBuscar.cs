using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alberdi
{
    public partial class ControlBuscar : UserControl
    {
        public ControlBuscar()
        {
            InitializeComponent();
        }

        private void pBuscar_MouseHover(object sender, EventArgs e)
        {
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pBuscar_MouseLeave(object sender, EventArgs e)
        {
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void pBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor=Color.Yellow;
        }

        private void ControlBuscar_Load(object sender, EventArgs e)
        {

        }

        private void pBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor = Color.Transparent;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {


        }

        private void pBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                e.SuppressKeyPress = true; //esta instrucción hace la magia n_n

            }
        }
    }
}
