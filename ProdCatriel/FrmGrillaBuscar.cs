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
    public partial class FrmGrillaBuscar : Form
    {
        public string combo;
        public FrmGrillaBuscar()
        {
            InitializeComponent();
        }
        public string Codigo { get; set; }
        public string nombre { get; set; }
        public double Costo{ get; set; }

        public string Unimed { get; set; }
        public string version { get; set; }
        public int id { get; set; }
        public int minutos { get; set; }

        public string tipo_F { get; set; }

        private void FrmGrillaBuscar_Load(object sender, EventArgs e)
        {
            LlenarGrid(combo,txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Cursor.Current = Cursors.Default;
            txtBuscar.Focus();
        }

        private void LlenarGrid(string _combo, string filtro)
        {

            Dgprincipal.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", _combo));
                lst.Add(new ClsParametros("@filtro",filtro));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_CargaCombos", lst);
                Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);

            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            LlenarGrid(combo,txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid(combo,txtBuscar.Text);
            Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            if(combo== "COMPONENTEBUSCAR") 
            { 
                id =Convert.ToInt32( Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                Codigo = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                nombre = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                Unimed = Dgprincipal.CurrentRow.Cells[3].Value.ToString();
                Costo = Convert.ToDouble(Dgprincipal.CurrentRow.Cells[4].Value.ToString());     
                tipo_F= Dgprincipal.CurrentRow.Cells[5].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (combo == "PTERMINADOS")
            {
                Codigo = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                nombre = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (combo == "COMPONENTE_CARNICO_BUSCAR")
            {
                Codigo = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                nombre = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                Unimed = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (combo == "BUSCAR_FORMULAS")
            {
                id= Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                Codigo = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                nombre = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                version = Dgprincipal.CurrentRow.Cells[3].Value.ToString();
                minutos= Convert.ToInt32(Dgprincipal.CurrentRow.Cells[4].Value.ToString());
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Codigo = Dgprincipal.CurrentRow.Cells[0].Value.ToString();
                nombre = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[2].Value.ToString());
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void Dgprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = ((DataGridView)sender).CurrentRow;
                string valorPrimerCelda = Convert.ToString(row.Cells[0].Value);
                e.Handled = true;
            }
        }
        private void Dgprincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)'\r')
            {
                Dgprincipal_DoubleClick(Dgprincipal, e);
                return;   
            }
            if (e.KeyChar == 27)
            {
                this.Close();
                return;
            }
            if (e.KeyChar != 8)
            {
                txtBuscar.Text = txtBuscar.Text + e.KeyChar.ToString();
            }
            else
            {
                if (txtBuscar.Text.Count() > 0)
                {
                    txtBuscar.Text = txtBuscar.Text.Substring(0, txtBuscar.Text.Count() - 1);
                }  
            }
        }
    }
}
