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
    public partial class FrmConsultas: Form
    {
        public FrmConsultas()
        {
            InitializeComponent();

        }

        private void PBalanceMP_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmReporteBalanceMateriaPrima _FrmReporteBalanceMateriaPrima = new FrmReporteBalanceMateriaPrima();
            _FrmReporteBalanceMateriaPrima.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
           //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmReporteBalanceMateriaPrima);
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

        private void PStock_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmCarnicosCuentaCorriente _FrmCarnicosCuentaCorriente = new FrmCarnicosCuentaCorriente();
            _FrmCarnicosCuentaCorriente.Vienede = "CONSULTA";
            _FrmCarnicosCuentaCorriente.Periodo = DateTime.Now;
            _FrmCarnicosCuentaCorriente.StartPosition = FormStartPosition.CenterScreen;
            _FrmCarnicosCuentaCorriente.WindowState= FormWindowState.Maximized;
            //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmCarnicosCuentaCorriente);
        }

        

       

        private void Psalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._FrmConsultas = false;
            
        }

        private void despostadaCatrielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmReporteDespostada _FrmReporteDespostada = new FrmReporteDespostada();
            _FrmReporteDespostada.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmReporteDespostada);
        }

        private void ingresoAPlantaMPCárnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmIngresoCarnicos _FrmIngresoCarnicos = new FrmIngresoCarnicos();
            _FrmIngresoCarnicos.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmIngresoCarnicos);
        }

        private void otrosProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmReporteProcesos _FrmReporteProcesos = new FrmReporteProcesos();
            _FrmReporteProcesos.StartPosition = FormStartPosition.CenterScreen;
            //_FrmInformeDespostada.ParentForm;
            //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmReporteProcesos);
        }

        private void consumidoporPeriodoNOCarnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmConsumidoNoCarnicos _FrmConsumidoNoCarnicos = new FrmConsumidoNoCarnicos();
            _FrmConsumidoNoCarnicos.StartPosition = FormStartPosition.CenterScreen;
            _FrmConsumidoNoCarnicos.Periodo = DateTime.Now;
            //_FrmInformeDespostada.ParentForm;
            //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmConsumidoNoCarnicos);
        }

        private void procesosProductivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajusteKgMprimaCárnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmCarnicosDiferencias _FrmCarnicosDiferencias = new FrmCarnicosDiferencias();
            _FrmCarnicosDiferencias.Vienede = "CONSULTA";
            _FrmCarnicosDiferencias.Periodo = DateTime.Now;
            _FrmCarnicosDiferencias.StartPosition = FormStartPosition.CenterScreen;
            _FrmCarnicosDiferencias.WindowState = FormWindowState.Maximized;
            //_FrmReporteBalanceMateriaPrima.ShowDialog();
            AbrirFormEnPanel(_FrmCarnicosDiferencias);
        }
    }
}

