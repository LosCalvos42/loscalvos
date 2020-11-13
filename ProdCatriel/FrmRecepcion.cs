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

namespace LOSCALVOS
{
    public partial class FrmRecepcion : Form
    {
        private bool InvokeRequinetworking=false;

        public FrmRecepcion()
        {
            InitializeComponent();

            //nnn();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarGrid()
        {
            
            DgIngreso.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@desde", dtDesde.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("SP_ListadoRecepcion", lst);
                DgIngreso.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void nnn()
        {
            btnBuscar.Enabled = false;
            progressBar1.Value=0;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Style = ProgressBarStyle.Marquee;
            System.Threading.Thread _thread = new System.Threading.Thread(new System.Threading.ThreadStart(loadTable));

            _thread.Start(); System.Threading.Thread.Sleep(600);

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtDesde.Value > dtHasta.Value)
            {
                MessageBox.Show("Rango de Fecha Incorrecta.", "Buscar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtDesde.Focus();
                return;    
                
            }
            nnn();
        }   
        private void loadTable()
        {
            DgIngreso.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@desde", dtDesde.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("SP_ListadoRecepcion", lst);
                DgIngreso.DataSource = dt;
               

            }
            catch (Exception)
            {
                return;
            }
            setDataSource(dt);
        }
        internal delegate void SetDataSourceDelegate(DataTable dt);
        private void setDataSource(DataTable dt)
        { // Invoke method if requinetworking: 
            if (this.InvokeRequinetworking)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), dt);
            }
            else
            {
                DgIngreso.DataSource = dt;
                progressBar1.Visible = false;
                btnBuscar.Enabled = true;
            }
        }

        private void FrmRecepcion_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            Cursor.Current = Cursors.Default;
        }
    }
}
