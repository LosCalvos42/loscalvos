using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmHistorialDePrecios : Form
    {
        public FrmHistorialDePrecios()
        {
            InitializeComponent();
        }
      
        public string Filtro { get; set; }
       
        public string accion = "";

        public int producto ;



        private void FrmListados_Load(object sender, EventArgs e)
        {
            Filtro = "";
            this.Text = "Historial de Precios";  // nombre del SP
            LLENAR();
        }
       
 
        private void Permisos()
        {
            if (Program.perfil == 5)
            {
                //mnuevo.Enabled = false;
                //mmodificar.Enabled = false;
                //meliminar.Enabled = false;
            }
        }
        
        private void LLENAR()
        {
            Dgprincipal.DataSource = null;
          
          
            System.Threading.Thread thread =
            new System.Threading.Thread(new System.Threading.ThreadStart(loadTable));
            thread.Start();
        
        }


        private void loadTable()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo",3));
                lst.Add(new ClsParametros("@PROD",producto));
                setDataSource(dt = M.Listado("SP_ActualizacionDePrecios", lst));    //SP del reporte
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        internal delegate void SetDataSourceDelegate(DataTable table);
        private void setDataSource(DataTable table)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), table);
            }
            else
            {
                Dgprincipal.DataSource = table;

                EstadoGrilla();
                Dgprincipal.ClearSelection();
            }
        }
        private void EstadoGrilla()
        {

           
            Dgprincipal.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           
            Dgprincipal.Columns[3].DefaultCellStyle.Format = "N2";
           

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
