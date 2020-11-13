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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();

        }



        private void LlenarGrid(string filtro)
        {

            Dgprincipal.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@filtro",filtro));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_ListadoArti",lst);
                Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            LlenarGrid("");
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;
        }

        private void pBuscar_MouseDown(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor = Color.DarkGray;
        }

        private void pBuscar_MouseHover(object sender, EventArgs e)
        {
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void pBuscar_MouseLeave(object sender, EventArgs e)
        {
            pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void pBuscar_MouseUp(object sender, MouseEventArgs e)
        {
            pBuscar.BackColor = Color.Transparent;
        }

        private void pBuscar_Click(object sender, EventArgs e)
        {
            LlenarGrid(txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            LlenarGrid(txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Buscar()
        {
            foreach (DataGridViewRow Row in Dgprincipal.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells[0].Value);

                if (Valor ==this.txtBuscar.Text)
                {
                    //Dgprincipal.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Green;
                    //Dgprincipal.Rows[Convert.ToInt32(strFila)].Selected=true;
                    Dgprincipal.CurrentCell = Dgprincipal.Rows[Convert.ToInt32(strFila)].Cells[0];
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LlenarGrid(txtBuscar.Text);
                Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid(txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
