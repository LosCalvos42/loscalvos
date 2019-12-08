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
    public partial class FrmProduccion : Form
    {
        public FrmProduccion()
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
            //Cursor.Current = Cursors.WaitCursor;
            //FormsegundoPlano _FormsegundoPlano = new FormsegundoPlano();
            //_FormsegundoPlano.StartPosition = FormStartPosition.CenterScreen;
            ////_FrmInformeDespostada.ParentForm;
            //_FormsegundoPlano.ShowDialog();

            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FormsegundoPlano _FormsegundoPlano = new FormsegundoPlano();

            _FormsegundoPlano.StartPosition = FormStartPosition.CenterScreen;
            _FormsegundoPlano.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FormsegundoPlano);




        }

       

        private void PTRecurso_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmTipoRecurso _FrmTipoRecurso = new FrmTipoRecurso();
            _FrmTipoRecurso.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmTipoRecurso.ShowDialog();
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

        private void PFamilias_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddAlmacen _FrmAddAlmacen = new FrmAddAlmacen();
            _FrmListados.Tabla = "ALMACENTIPO";
            _FrmListados.Listado = "ALMACENTIPO";
            _FrmListados.Abm = _FrmAddAlmacen;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
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
            Cursor.Current = Cursors.WaitCursor;
            FrmDefinicionProcesos _FrmDefinicionProcesos = new FrmDefinicionProcesos();
            _FrmDefinicionProcesos.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            _FrmDefinicionProcesos.ShowDialog();
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
            Program._FrmProduccion = false;
            
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddArticulos _FrmAddArticulos = new FrmAddArticulos();
            _FrmListados.Tabla = "ARTI";
            _FrmListados.Listado = "PRODUCTOS";
            _FrmListados.TituloListado = "Listado de Productos";
            _FrmListados.Abm = _FrmAddArticulos;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void TipoDeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddAlmacenTipo _FrmAddAlmacenTipo = new FrmAddAlmacenTipo();
            _FrmListados.Tabla = "ALMACENTIPO";
            _FrmListados.Listado = "ALMACENTIPO";
            _FrmListados.Abm = _FrmAddAlmacenTipo;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddAlmacen _FrmAddAlmacen = new FrmAddAlmacen();
            _FrmListados.Tabla = "ALMACEN";
            _FrmListados.Listado = "ALMACENES";
            _FrmListados.Abm = _FrmAddAlmacen;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void GrupoItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddGrupoPruducto _FrmAddGrupoPruducto = new FrmAddGrupoPruducto();
            _FrmListados.Tabla = "GRUPOPRODUCTO";
            _FrmListados.Listado = "GRUPOPRODUCTO";
            _FrmListados.Abm = _FrmAddGrupoPruducto;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void TipoProductoItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddTipoProducto _FrmAddTipoProducto = new FrmAddTipoProducto();
            _FrmListados.Tabla = "TIPOPRODUCTO";
            _FrmListados.Listado = "TIPOPRODUCTO";
            _FrmListados.Abm = _FrmAddTipoProducto;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void FamiliaItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddFamilia _FrmAddFamilia = new FrmAddFamilia();
            _FrmListados.Tabla = "ARTIFAMILIA";
            _FrmListados.Listado = "FAMILIA";
            _FrmListados.Abm = _FrmAddFamilia;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void GrupoFamiliaItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddGrupoFamilia _FrmAddGrupoFamilia = new FrmAddGrupoFamilia();
            _FrmListados.Tabla = "GRPFAMILIA";
            _FrmListados.Listado = "GRUPOFAMILIA";
            _FrmListados.Abm = _FrmAddGrupoFamilia;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
            
        }

        private void CategoriaPorPesomenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddCategoriaPeso _FrmAddCategoriaPeso = new FrmAddCategoriaPeso();
            _FrmListados.Tabla = "CATEGORIAPESO";
            _FrmListados.Listado = "CATEGORIAPESO";
            _FrmListados.Abm = _FrmAddCategoriaPeso;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void CategoriaPorMermaMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddCategoriaMerma _FrmAddCategoriaMerma = new FrmAddCategoriaMerma();
            _FrmListados.Tabla = "CATEGORIAPMERMA";
            _FrmListados.Listado = "CATEGORIAMERMA";
            _FrmListados.Abm = _FrmAddCategoriaMerma;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }
    }
}

