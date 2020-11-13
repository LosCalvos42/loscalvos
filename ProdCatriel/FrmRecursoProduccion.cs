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
    public partial class FrmRecursoProduccion : Form
    {
        public FrmRecursoProduccion()
        {
            InitializeComponent();
        }

        private void menuForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }
    }
}
