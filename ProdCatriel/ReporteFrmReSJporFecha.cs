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
    public partial class ReporteFrmReSJporFecha : Form
    {


        public List<ClsDatosReporteBatea> datosR = new List<ClsDatosReporteBatea>();
        public DataTable dtr = new DataTable();
        public DataTable dtr1 = new DataTable();
        public ReporteFrmReSJporFecha()
        {
            InitializeComponent();
        }

        private void ReporteFrmReSJporFecha_Load(object sender, EventArgs e)
        {

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", datosR));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtr));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet11", dtr1));


            this.reportViewer2.RefreshReport();
            reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer2.ZoomMode = ZoomMode.Percent;
            reportViewer2.ZoomPercent = 100;
        }
    }
}
