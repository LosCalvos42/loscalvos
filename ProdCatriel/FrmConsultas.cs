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

        private void MenuIngSal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmReporteDeProduccion _FrmReporteDeProduccion = new FrmReporteDeProduccion();
            _FrmReporteDeProduccion.Tabla = "PRODUCCION";
            _FrmReporteDeProduccion.Listado = "PRODUCCION";
            _FrmReporteDeProduccion.TituloListado = "Listado de Ordenes De Trabajo";
            _FrmReporteDeProduccion.Fdesde = (DateTime.Now).ToString("yyyyMMdd");
            _FrmReporteDeProduccion.Fhasta = (DateTime.Now).ToString("yyyyMMdd");
            _FrmReporteDeProduccion.StartPosition = FormStartPosition.CenterScreen;
            _FrmReporteDeProduccion.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmReporteDeProduccion);
        }

        private void MENUSeguimiento_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmSeguimientoDeCodigoDeBarra _FrmReporteDeProduccion = new FrmSeguimientoDeCodigoDeBarra();

    
            _FrmReporteDeProduccion.StartPosition = FormStartPosition.CenterScreen;
            _FrmReporteDeProduccion.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmReporteDeProduccion);
            
        }
    }
}

