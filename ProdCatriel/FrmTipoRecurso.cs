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
    public partial class FrmTipoRecurso : Form
    {
        public FrmTipoRecurso()
        {
            InitializeComponent();
            //menuForm.Renderer = new MyRenderer();
        }

        private void mnuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                this.Close();
        }

        private void mmodificar_Click(object sender, EventArgs e)
        {

        }

        private void FrmTipoRecurso_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            DgArt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;
        }
        private void LlenarGrid()
        {

            DgArt.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                //lst.Add(new ClsParametros("@desde", dtDesde.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.lisquery("sp_ListadotipoRecurso");
                DgArt.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //private class MyRenderer : ToolStripProfessionalRenderer
        //{
        //    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        //    {
        //        if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
        //        else
        //        {
        //            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
        //            e.Graphics.FillRectangle(Brushes.Beige, rc);
        //            e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
        //        }
        //    }
        //}
    }
    }
