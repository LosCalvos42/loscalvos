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
    public partial class FrmLoteItems : Form
    {
        public FrmLoteItems()
        {
            InitializeComponent();
        }

        public int Tipo { get; set; }
        public int NroOt { get; set; }
        public string Lote { get; set; }
        public string CodProc { get; set; }
        public string CatPeso { get; set; }
        public string CatMerma { get; set; }
        public string Titulo { get; set; }
        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            Dgprincipal.Rows.Clear();
            CargarGrilla();

            LblTitulo.Text = Titulo;

        }

        private void CargarGrilla()
        {
            try
            {
               Dgprincipal.DataSource = null; ;
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@Tipo", Tipo));
                lst.Add(new ClsParametros("@Lote", Lote));
                lst.Add(new ClsParametros("@NroOt", NroOt));
                lst.Add(new ClsParametros("@codProc", CodProc));
                lst.Add(new ClsParametros("@CatePeso", CatPeso));
                lst.Add(new ClsParametros("@CateMerma",CatMerma));
                dt = M.Listado("SP_GetSeguimientoDeLoteDetalle", lst);
                if (dt.Rows.Count > 0)
                {

                    Dgprincipal.DataSource = dt;
                   // DgActual.Columns[4].DefaultCellStyle.Format = "N0";
                   // DgActual.Columns[5].DefaultCellStyle.Format = "N2";

                }
                Dgprincipal.ClearSelection();
                if (Dgprincipal.Rows.Count > 0)
                {
                    Dgprincipal.FirstDisplayedScrollingRowIndex = Dgprincipal.RowCount - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }
    }
}

    
 

