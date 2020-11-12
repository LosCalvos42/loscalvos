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
    public partial class FrmBuscarEnBodega : Form
    {
        public string combo;
        public FrmBuscarEnBodega()
        {
            InitializeComponent();
        }
        public string Lote{ get; set; }
        public string Categoria { get; set; }
        DateTime  Fecha { get; set; }
        

        private void FrmGrillaBuscar_Load(object sender, EventArgs e)
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
                dt = M.Listado("SP_GetPezasEnBodega", lst);
                Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            if (Dgprincipal.Rows.Count > 0)
            {
               Lote= Dgprincipal.CurrentRow.Cells[0].Value.ToString();
               Categoria = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
               Fecha = Convert.ToDateTime(Dgprincipal.CurrentRow.Cells[2].Value);
               DialogResult = DialogResult.OK;
               this.Close();
                
            }
        }

        private void Dgprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = ((DataGridView)sender).CurrentRow;
                string valorPrimerCelda = Convert.ToString(row.Cells[0].Value);
                e.Handled = true;
            }
        }

        private void Dgprincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'\r')
            {
                Dgprincipal_DoubleClick(Dgprincipal, e);
                return;
                
            }
            if (e.KeyChar == 27)
            {

                

                this.Close();
                return;

            }

            if (e.KeyChar != 8)
            {
                
            }
            
            else
            {
                
                
               
            }
        }
    }
}
