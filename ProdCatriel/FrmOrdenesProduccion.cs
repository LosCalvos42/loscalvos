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
    public partial class FrmOrdenesProduccion : Form
    {
        public FrmOrdenesProduccion()
        {
            InitializeComponent();
        }

        private void menuForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }
    }
}
