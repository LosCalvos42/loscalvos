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
    public partial class FrmUtilidades : Form
    {
        public FrmUtilidades()
        {
            InitializeComponent();

        }

        private void PRecepcion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmRecepcion _FrmRecepcion = new FrmRecepcion();
            _FrmRecepcion.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmRecepcion.ShowDialog();
        }

        private void PStock_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmStock _FrmStock = new FrmStock();
            _FrmStock.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmStock.ShowDialog();
        }

        private void PProductos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmProductos _FrmProductos = new FrmProductos();
            _FrmProductos.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmProductos.ShowDialog();
            
        }

        private void PTRecurso_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmTipoRecurso _FrmTipoRecurso = new FrmTipoRecurso();
            _FrmTipoRecurso.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmTipoRecurso.ShowDialog();
        }

        private void PAlmacenes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmListados _FrmAlmacenes = new FrmListados();
            _FrmAlmacenes.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmAlmacenes.ShowDialog();
        }

        private void PFamilias_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmFamilias _FrmFamilias = new FrmFamilias();
            _FrmFamilias.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmFamilias.ShowDialog();
        }

        private void PMarcas_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmMarcas _FrmMarcas = new FrmMarcas();
            _FrmMarcas.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmMarcas.ShowDialog();
        }

        private void Precursos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmRecursoProduccion _FrmRecursoProduccion = new FrmRecursoProduccion();
            _FrmRecursoProduccion.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmRecursoProduccion.ShowDialog();
        }

        private void PDProcesos_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //FrmDefinicionProcesos _FrmDefinicionProcesos = new FrmDefinicionProcesos();
            //_FrmDefinicionProcesos.StartPosition = FormStartPosition.CenterScreen;
            ////_FrmInformeDespostada.ParentForm;
            //_FrmDefinicionProcesos.ShowDialog();
        }

        private void POdTrabajo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmOrdenesProduccion _FrmOrdenesProduccion = new FrmOrdenesProduccion();
            _FrmOrdenesProduccion.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmOrdenesProduccion.ShowDialog();
        }

        private void PSOTrabajo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmSeguimientoOrdenesProduccion _FrmSeguimientoOrdenesProduccion = new FrmSeguimientoOrdenesProduccion();
            _FrmSeguimientoOrdenesProduccion.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmSeguimientoOrdenesProduccion.ShowDialog();
        }

        private void PUMedida_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmUnidadMedida _FrmUnidadMedida = new FrmUnidadMedida();
            _FrmUnidadMedida.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmUnidadMedida.ShowDialog();
        }

        private void Psalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._FrmUtilidades = false;
            
        }
        private void AbrirFormEnPanel(object formHijo)
        {
            //if (this.panel1.Controls.Count > 0)
            //    this.panel1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            //fh.FormBorderStyle = FormBorderStyle.None;
            //fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            fh.Parent.Controls.SetChildIndex(fh, 0);

            this.panel1.Tag = fh;
            //fh.MdiParent=this;
            fh.Show();
        }
        

        private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmImpresoras _FrmImpresoras = new FrmImpresoras();
            _FrmImpresoras.StartPosition = FormStartPosition.CenterScreen;
            AbrirFormEnPanel(_FrmImpresoras);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmBalanzas _FrmBalanzas = new FrmBalanzas();
            _FrmBalanzas.StartPosition = FormStartPosition.CenterScreen;
            AbrirFormEnPanel(_FrmBalanzas);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmAddDispositivo _FrmAddDispositivo = new FrmAddDispositivo();
            _FrmAddDispositivo.StartPosition = FormStartPosition.CenterScreen;
            AbrirFormEnPanel(_FrmAddDispositivo);
        }
    }
}

