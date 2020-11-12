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


        private void Psalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._FrmConsultas = false;
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmSeguimientoDeCodigoDeBarra _FrmSeguimientoDeCodigoDeBarra = new FrmSeguimientoDeCodigoDeBarra();
            _FrmSeguimientoDeCodigoDeBarra.StartPosition = FormStartPosition.CenterScreen;
            _FrmSeguimientoDeCodigoDeBarra.ShowDialog();
        }

        private void MenuIngSal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmReporteSalazon _FrmReporteSalazon = new FrmReporteSalazon();
            _FrmReporteSalazon.Tabla = "OTRESUMEN";
            _FrmReporteSalazon.Listado = "OTRABAJO";
            _FrmReporteSalazon.TituloListado = "Listado de Ordenes De Trabajo";
            _FrmReporteSalazon.Fdesde = (DateTime.Now).ToString("yyyyMMdd");
            _FrmReporteSalazon.Fhasta = (DateTime.Now).ToString("yyyyMMdd");
            _FrmReporteSalazon.StartPosition = FormStartPosition.CenterScreen;
            _FrmReporteSalazon.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmReporteSalazon);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmSeguimientoDeLote _FrmSeguimientoDeLote = new FrmSeguimientoDeLote();
            _FrmSeguimientoDeLote.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmSeguimientoDeLote);
        }
    }
}

