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
    public partial class FrmBajasDeProduccion : Form
    {
        public FrmBajasDeProduccion()
        {
            InitializeComponent();
        }

        decimal MERMA = 0;

        private void CargarDatosActual()
        {
            try
            {
                DgActual.Rows.Clear();
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                List<ClsParametros> lst = new List<ClsParametros>();
                lst.Add(new ClsParametros("@CodBar", TxtCodBar.Text));
                lst.Add(new ClsParametros("@tipo", 3));

                dt = M.Listado("SP_GetSeguimientoCodbar", lst);
                if (dt.Rows.Count > 0)
                {
                    
                    MERMA = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DgActual.Rows.Add(dt.Rows[i][0]);
                        DgActual.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        DgActual.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                        DgActual.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                        DgActual.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();

                        if (i == 8 && dt.Rows[i][3].ToString()!="")
                        {
                            MERMA= Convert.ToDecimal(dt.Rows[i][3].ToString().Replace(".",","));
                        }

                    }
                    DgActual.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                    DgActual.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(92, 107, 192);
                    DgActual.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                    DgActual.Rows[1].DefaultCellStyle.ForeColor = Color.White;
                    using (Font font = new Font(
                    DgActual.DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold))
                    {
                        DgActual.Rows[0].DefaultCellStyle.Font = font;
                        DgActual.Rows[1].DefaultCellStyle.Font = font;
                    }
                    DgActual.ClearSelection();
                    if (dt.Rows[0][2].ToString() == "")
                    {
                        MessageBox.Show("No se encontraron Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DgActual.Rows.Clear();
                        return;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargarcombo(string combo, ComboBox _combo)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", ""));
                dt = M.Listado("sp_CargaCombos", lst);
                _combo.DataSource = dt;
                _combo.DisplayMember = "NOMBRE";
                _combo.ValueMember = "CODIGO";
                DataRow topItem = dt.NewRow();
                topItem[1] = 1;
                topItem[2] = "-Select-";
                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void TxtCodBar_KeyPress(object sender, KeyPressEventArgs e)
       {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CargarDatosActual();
            }
        }

        private void FrmBajasDeProduccion_Load(object sender, EventArgs e)
        {
            Cargarcombo("MOTIVOEXCLUCION", CmbMotivo);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DgActual.Rows.Count == 0)
            {
                MessageBox.Show("No Hay Ningún Registro Para Excluir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodBar.Focus();
            }


            if (CmbMotivo.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar Motivo de Exclución", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbMotivo.Focus();
                return;
            }

            if (MessageBox.Show("Esta seguro que desea EXCLUIR esta pieza?", "Terminar OT.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                ClsManejador M = new ClsManejador();
                List<ClsParametros> lst = new List<ClsParametros>();
                DataTable dt = new DataTable();
                string[] msj;
                lst.Clear();
                lst.Add(new ClsParametros("@CODBAR", TxtCodBar.Text));
                lst.Add(new ClsParametros("@ESTADOCODBAR", CmbMotivo.SelectedValue));
                lst.Add(new ClsParametros("@FECHAPROD", DateTime.Now.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@USR_ID", Program.IDUSER));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.EjecutarSP("SP_ExcluirCodbar", ref lst);
                msj = new string[2];
                msj[0] = lst[4].Valor.ToString();
                msj[1] = lst[5].Valor.ToString();

                if (msj[0] == "0" || msj[0] == "")
                {
                    MessageBox.Show(msj[1], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente" + System.Environment.NewLine + msj[1], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
 
}
