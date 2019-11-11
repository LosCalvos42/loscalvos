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

namespace Alberdi
{
    public partial class FrmDefinicionProcesos : Form
    {
        public FrmDefinicionProcesos()
        {
            InitializeComponent();
        }

        //private void menuForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    this.Close();
        //}

        private void FrmDefinicionProcesos_Load(object sender, EventArgs e)
        {
            LlenarGrid("");
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;
        }

        private void LlenarGrid(string filtro)
        {

            Dgprincipal.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@filtro", filtro));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_ListadoDefinicionProcesos", lst);
                Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

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
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void pBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor = Color.Transparent;
        }

        private void pBuscar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid(txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            FrmDefinicionProcesosDetalle _FrmDefinicionProcesosDetalle =new FrmDefinicionProcesosDetalle();
            _FrmDefinicionProcesosDetalle.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmDefinicionProcesosDetalle.ID= Dgprincipal.CurrentRow.Cells[7].Value.ToString();
            _FrmDefinicionProcesosDetalle.ShowDialog();
        }

        private void mnuevo_Click(object sender, EventArgs e)
        {
            FrmDefinicionProcesosDetalle _FrmDefinicionProcesosDetalle = new FrmDefinicionProcesosDetalle();

            _FrmDefinicionProcesosDetalle.StartPosition = FormStartPosition.CenterScreen;
            _FrmDefinicionProcesosDetalle.MODO = "NUEVO";
            _FrmDefinicionProcesosDetalle.ShowDialog();
            
        }

        private void Dgprincipal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
