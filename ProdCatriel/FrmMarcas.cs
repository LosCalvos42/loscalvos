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
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;
        }
        private void LlenarGrid()
        {

            Dgprincipal.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //lst.Add(new ClsParametros("@desde", dtDesde.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.lisquery("sp_ListadoMarcas");
                Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
