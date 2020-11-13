using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos;

namespace LOSCALVOS
{
    public partial class frmSelecHJamon : Form
    {
        String fecha;
        String ssql;
        public frmSelecHJamon()
        {
            InitializeComponent();
        }

        private void frmSelecHJamon_Load(object sender, EventArgs e)
        {

            cargargrilla();
        }
        
        public void cargargrilla()
        {
            DataTable dt = new DataTable();
            
            ClsManejador M = new ClsManejador();
            //fecha = DateTime.Now.ToString("yyyy/MM/dd");
            fecha = Convert.ToString(Convert.ToDateTime(lblfecha.Text).ToString("yyyy/MM/dd"));
            fecha=fecha.Replace("/", "");
            //ssql = "select *from sjmh where Sjmh_fecha='"+fecha+"'";

            ssql= @"select h.sjmh_id,h.sjmh_fecha,h.sjmh_nroproc,t.TIPOJAMON_ID,t.TIPOJAMON_DESC, h.sjmh_estado
            from sjmh h
            inner join TIPOJAMON t on TIPOJAMON_ID = sjmh_tipoj
            where h.sjmh_fecha = '" + fecha + "'";

            dt =M.lisquery(ssql);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtgpro.Rows.Add(dt.Rows[i][0]);
                dtgpro.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                dtgpro.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                dtgpro.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                dtgpro.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                dtgpro.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                dtgpro.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                
            }
        }

        private void dtgpro_DoubleClick(object sender, EventArgs e)
        {

            if (dtgpro.RowCount > 0)
            {
                if (dtgpro.CurrentRow.Cells[5].Value.ToString()=="C")
                {
                    MessageBox.Show("Proceso esta cerrado, No se pude continuar", "Proceso Cerrdo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FrmPesada.nropro = Convert.ToInt32(dtgpro.CurrentRow.Cells[2].Value.ToString());
                FrmPesada.idtipo = Convert.ToInt32(dtgpro.CurrentRow.Cells[3].Value.ToString());
                //FrmSelecJamon.tipojid = Convert.ToInt32(dtgpro.CurrentRow.Cells[3].Value.ToString());
                FrmPesada.flag = 1;
                this.Close();
            }
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            FrmPesada.flag = 0;
            this.Close();
        }

        private void frmSelecHJamon_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FrmSelecJamon.flag = 0;
        }
    }
  
}
