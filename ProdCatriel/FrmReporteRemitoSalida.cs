using Datos;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRAZAAR
{
    public partial class FrmReporteRemitoSalida : Form
    {
        public FrmReporteRemitoSalida()
        {
            InitializeComponent();
        }
        public int NcRemito { get; set; }


        private void DetalleCaja_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "";
            lblProveedor.Text = "";
            txtdetalle.Text = "";
            LblNumeroRemito.Text = "";
            LlenarGrid(NcRemito);
            Dgprincipal.ClearSelection();
            Cursor.Current = Cursors.Default;
            Dgprincipal.ClearSelection();
            Salir.Focus();
        }

        private void LlenarGrid(int NcRemito)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                
                lst.Add(new ClsParametros("@NcRemito", NcRemito));
                dt = M.Listado("SP_Catriel_EgresoComprobantes", lst);

                if (dt.Rows.Count > 0)
                {
                    lblFecha.Text = dt.Rows[0][0].ToString();
                    lblProveedor.Text = dt.Rows[0][1].ToString();
                    txtdetalle.Text = dt.Rows[0][4].ToString();
                    LblNumeroRemito.Text= dt.Rows[0][3].ToString();
                    LblTemp.Text = dt.Rows[0][5].ToString(); 


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Dgprincipal.Rows.Add(dt.Rows[i][0]);
                        //Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][6].ToString();
                        Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][7].ToString();
                        Dgprincipal.Rows[i].Cells[2].Value = dt.Rows[i][8].ToString();
                        Dgprincipal.Rows[i].Cells[3].Value = Convert.ToInt32(dt.Rows[i][9].ToString());
                    }
                }
                else
                {
                    
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        private void Salir_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }
    }
}
