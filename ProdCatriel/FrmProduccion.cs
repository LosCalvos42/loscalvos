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

        private void PSOTrabajo_Click(object sender, EventArgs e)
        {
            
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
            _FrmListados.TituloListado = "Listado de Tipo de Almacenes";
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
            _FrmListados.TituloListado = "Listado de Almacenes";
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
            _FrmListados.TituloListado = "Listado de Grupo de Productos";
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
            FrmAddSectoresProductivos _FrmAddTipoProducto = new FrmAddSectoresProductivos();
            _FrmListados.Tabla = "SECTOR";
            _FrmListados.Listado = "SECTORESPRODUCTIVOS";
            _FrmListados.TituloListado = "Listado de Sectores Productivos";
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
            _FrmListados.TituloListado = "Listado de Familia de Productos";
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
            _FrmListados.TituloListado = "Listado de Grupos de Familia";
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
            _FrmListados.TituloListado = "Listado de Categoria por Peso";
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
            _FrmListados.TituloListado = "Listado de Categoria por Merma";
            _FrmListados.Abm = _FrmAddCategoriaMerma;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddEstados _FrmAddEstados = new FrmAddEstados();
            _FrmListados.Tabla = "ESTADO";
            _FrmListados.Listado = "ESTADOS";
            _FrmListados.TituloListado = "Listado de Estado de Etiqueta";
            _FrmListados.Abm = _FrmAddEstados;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void procesosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddProcesos _FrmAddProcesos = new FrmAddProcesos();
            _FrmListados.Tabla = "PROCESO";
            _FrmListados.Listado = "PROCESOS";
            _FrmListados.TituloListado = "Listado de Procesos Productivos";
            _FrmListados.Abm = _FrmAddProcesos;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }
        private void Permisos()
        {
            mConfiguracion.Enabled = false;
            mReportes.Enabled = false;


            if (Program.perfil == 5)
            {
                
                marchivo.Enabled = false;
                mConfiguracion.Enabled = false;
            }
        }

        private void FrmProduccion_Load(object sender, EventArgs e)
        {
            Permisos();
        }

        private void ImpresíonEtqGancherasMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmEtiqGancheras _FrmEtiqGancheras = new FrmEtiqGancheras();
            _FrmEtiqGancheras.Listado = "PROCESOS";
            _FrmEtiqGancheras.StartPosition = FormStartPosition.CenterScreen;
            _FrmEtiqGancheras.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmEtiqGancheras);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmAddRecepcionDeLotes _FrmAddRecepcionDeLotes = new FrmAddRecepcionDeLotes();
            _FrmAddRecepcionDeLotes.Listado = "PROCESOS";
            _FrmAddRecepcionDeLotes.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddRecepcionDeLotes.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmAddRecepcionDeLotes);//FrmAddRecepcionDeLotes
        }

        private void mReportes_Click(object sender, EventArgs e)
        {
            

            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmOrdenesProduccion _FrmOrdenesProduccion = new FrmOrdenesProduccion();

            _FrmOrdenesProduccion.StartPosition = FormStartPosition.CenterScreen;
            _FrmOrdenesProduccion.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmOrdenesProduccion);//FrmAddRecepcionDeLotes

        }

        private void MenuItemPSal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmPendientesDeIngSal _FrmPendientesDeIngSal = new FrmPendientesDeIngSal();
            _FrmPendientesDeIngSal.StartPosition = FormStartPosition.CenterScreen;
            _FrmPendientesDeIngSal.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmPendientesDeIngSal);//FrmAddRecepcionDeLotes
        }

        private void MenuItemSSal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmPendientesDeIng2Sal _FrmPendientesDeIng2Sal = new FrmPendientesDeIng2Sal();
            _FrmPendientesDeIng2Sal.StartPosition = FormStartPosition.CenterScreen;
            _FrmPendientesDeIng2Sal.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmPendientesDeIng2Sal);//FrmAddRecepcionDeLotes
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmEtiqSal _FrmEtiqSal = new FrmEtiqSal();
            _FrmEtiqSal.Listado = "PROCESOS";
            _FrmEtiqSal.StartPosition = FormStartPosition.CenterScreen;
            _FrmEtiqSal.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmEtiqSal);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmAgendaDeTrabajo _FrmAgendaDeTrabajo = new FrmAgendaDeTrabajo();
            _FrmAgendaDeTrabajo.StartPosition = FormStartPosition.CenterScreen;
            _FrmAgendaDeTrabajo.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmAgendaDeTrabajo);//FrmAddRecepcionDeLotes
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListadosProduccion _FrmListadosProduccion = new FrmListadosProduccion();
            FrmAddOrdenDeTrabajo _FrmAddOrdenDeTrabajo = new FrmAddOrdenDeTrabajo();
            _FrmListadosProduccion.Tabla = "OTRESUMEN";
            _FrmListadosProduccion.Listado = "OTRABAJO";
            _FrmListadosProduccion.TituloListado = "Listado de Ordenes De Trabajo";
            _FrmListadosProduccion.Fdesde = (DateTime.Now).ToString("yyyyMMdd");
            _FrmListadosProduccion.Fhasta = (DateTime.Now).ToString("yyyyMMdd");
            _FrmListadosProduccion.Abm = _FrmAddOrdenDeTrabajo;
            _FrmListadosProduccion.StartPosition = FormStartPosition.CenterScreen;
            _FrmListadosProduccion.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListadosProduccion);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListadosProduccion _FrmListadosProduccion = new FrmListadosProduccion();
            FrmAddOrdenDeTrabajoEstucado _FrmAddOrdenDeTrabajoEstucado = new FrmAddOrdenDeTrabajoEstucado();
            _FrmListadosProduccion.Tabla = "OTRESUMEN";
            _FrmListadosProduccion.Listado = "OTRABAJO";
            _FrmListadosProduccion.TituloListado = "Listado de Ordenes De Trabajo";
            _FrmListadosProduccion.Fdesde = (DateTime.Now.AddDays(-1)).ToString("yyyyMMdd");
            _FrmListadosProduccion.Fhasta = (DateTime.Now.AddDays(1)).ToString("yyyyMMdd");
            _FrmListadosProduccion.Abm = _FrmAddOrdenDeTrabajoEstucado;
            _FrmListadosProduccion.StartPosition = FormStartPosition.CenterScreen;
            _FrmListadosProduccion.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListadosProduccion);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmBajasDeProduccion _FrmBajasDeProduccion = new FrmBajasDeProduccion();
            _FrmBajasDeProduccion.StartPosition = FormStartPosition.CenterScreen;
            //_FrmBajasDeProduccion.WindowState = FormWindowState.Maximized;

            _FrmBajasDeProduccion.ShowDialog();
            //AbrirFormEnPanel(_FrmBajasDeProduccion);//FrmAddRecepcionDeLotes
        }

        private void PProductos_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmListados _FrmListados = new FrmListados();
            FrmAddArticulos _FrmAddArticulos = new FrmAddArticulos();
            _FrmListados.Tabla = "ARTI";
            _FrmListados.Listado = "ARTI";
            _FrmListados.TituloListado = "Listado de Productos";
            _FrmListados.Abm = _FrmAddArticulos;
            _FrmListados.StartPosition = FormStartPosition.CenterScreen;
            _FrmListados.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmListados);
        }

        private void BarraPesaje_Click(object sender, EventArgs e)
        {
             Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmControlDeProduccion _FrmControlDeProduccion = new FrmControlDeProduccion();
            _FrmControlDeProduccion.StartPosition = FormStartPosition.CenterScreen;
            _FrmControlDeProduccion.WindowState = FormWindowState.Maximized;
            _FrmControlDeProduccion.ShowDialog();
        }
    }
}

