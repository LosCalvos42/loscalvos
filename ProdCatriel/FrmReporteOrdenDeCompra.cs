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

namespace Alberdi
{
    public partial class FrmReporteOrdenDeCompra : Form
    {
        public FrmReporteOrdenDeCompra()
        {
            InitializeComponent();
        }
        public Int64 Nroingreso; 
       

        private void DetalleCaja_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "";
            lblProveedor.Text = "";
            txtdetalle.Text = "";
            lbltipo.Text = "";
            LblNumeroOc.Text = "";
            LlenarGrid(Nroingreso);
            //Dgprincipal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Dgprincipal.ClearSelection();
            Cursor.Current = Cursors.Default;
            Dgprincipal.ClearSelection();

            Salir.Focus();

        }

        private void LlenarGrid(Int64 nroIng)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                
                lst.Add(new ClsParametros("@NroIng",nroIng));
                lst.Add(new ClsParametros("@Tipo", 1));
                lst.Add(new ClsParametros("@NroRemito",""));
                dt = M.Listado("SP_Catriel_IngresoComprobantes", lst);

                if (dt.Rows.Count > 0)
                {
                    lblFecha.Text = dt.Rows[0][0].ToString();
                    lblProveedor.Text = dt.Rows[0][1].ToString();
                    txtdetalle.Text = dt.Rows[0][2].ToString();
                    lbltipo.Text = dt.Rows[0][3].ToString();
                    LblNumeroOc.Text= dt.Rows[0][4].ToString();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Dgprincipal.Rows.Add(dt.Rows[i][0]);
                        //Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                        Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][5].ToString();
                        Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][6].ToString();
                        Dgprincipal.Rows[i].Cells[2].Value = Convert.ToInt32(dt.Rows[i][7].ToString());
                        //Dgprincipal.Rows[i].Cells[6].Value = Convert.ToDecimal(dt.Rows[i][6].ToString());
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
