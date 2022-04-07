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
    public partial class FrmSeguimientoDeCodigoDeBarra : Form
    {
        public FrmSeguimientoDeCodigoDeBarra()
        {
            InitializeComponent();
        }

        decimal MERMA = 0;

        private void CargarDatosOrigen()
        {
            try
            {
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@CodBar", TxtCodBar.Text));

                dt = M.Listado("SP_SeguimientoGetInfoCodbar", lst);
                if (dt.Rows.Count > 0)
                {
                    DgOrigen.DataSource = dt;
                }

                DgOrigen.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(81, 46, 95);
                DgOrigen.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(81, 46, 95);
                DgOrigen.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                DgOrigen.Rows[1].DefaultCellStyle.ForeColor = Color.White;

                //DataGridViewCellStyle styEstilo;
                //styEstilo = new DataGridViewCellStyle();
                //styEstilo.BackColor = Color.FromArgb(92, 107, 192);
                //styEstilo.ForeColor = Color.White;
                //styEstilo.Font = new Font("Bradley Hand ITC", 9, FontStyle.Bold);
                //styEstilo.Alignment = DataGridViewContentAlignment.BottomRight;
                // asignar estilo a las cabeceras del control
                //this.dgvGrid.ColumnHeadersDefaultCellStyle = styEstilo;..
                //DgOrigen.Rows[0].DefaultCellStyle= styEstilo;
                //DgOrigen.Rows[1].DefaultCellStyle = styEstilo;
                using (Font font = new Font(
                   DgOrigen.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                {
                    DgOrigen.Rows[0].DefaultCellStyle.Font = font;
                    DgOrigen.Rows[1].DefaultCellStyle.Font = font;
                }
                DgOrigen.ClearSelection();
                TxtCodBar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
        
        

        private void TxtCodBar_KeyPress(object sender, KeyPressEventArgs e)
       {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
                CargarDatosOrigen();
                TxtCodBar.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtCodBar.Text = "";
            TxtCodBar.Focus();
        }
    }
}
