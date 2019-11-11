using Datos;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteBatea : Form
    {
        public List<ClsDatosReporteBatea> datosR = new List<ClsDatosReporteBatea>();
        public DataTable dtr = new DataTable();


        public ReporteBatea()
        {
            InitializeComponent();
        }

        private void ReporteBatea_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetbatea1", datosR));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtr));
            this.reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            //reportViewer1.
            //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
            reportViewer1.ZoomPercent = 100;
        }

        
    }
}
