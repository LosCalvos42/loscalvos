using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FormsegundoPlano : Form
    {
        public FormsegundoPlano()
        {
            InitializeComponent();
        }
        struct DataParameter
        {
            public int proceso;
            public int Delay;
        }

        private DataParameter _inputparameter;
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progres.Value = e.ProgressPercentage;
            LblPorcentaje.Text = string.Format("Porcentaje...{0}%", e.ProgressPercentage);
            progres.Update();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int proces = ((DataParameter)e.Argument).proceso;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                try
                {
                    lst.Add(new ClsParametros("@listado", "PRODUCTOS"));
                    lst.Add(new ClsParametros("@Filtro", ""));
                    lst.Add(new ClsParametros("@id", 0));
                    //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                    //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                    dt = M.Listado("SP_LISTADOS_PRODUCCION", lst);
                    //Dgprincipal.DataSource = null;
                    //Dgprincipal.DataSource = dt;
                    //Dgprincipal.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                for (int i =0; i < proces; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++*100 / proces, string.Format("Process dato {0}", i));
                        Thread.Sleep(delay);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("el proceso se completo", "mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                _inputparameter.Delay = 10;
                _inputparameter.proceso = 1200;
                backgroundWorker.RunWorkerAsync(_inputparameter);
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }
    }
}
