using Datos;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alberdi
{
    public partial class FrmReSjamon : Form
    {

        String fecha;
        String ssql;
        int idtipo, nropro;
        Clsproceso P = new Clsproceso();
        ClsProcesoBatea b = new ClsProcesoBatea();
        public FrmReSjamon()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargargrilla();
        }

        public void cargargrilla()
        {
            dtgpro.Rows.Clear();
            DataTable dt = new DataTable();
            ClsManejador M = new ClsManejador();
            //fecha = DateTime.Now.ToString("yyyy/MM/dd");
            fecha = Convert.ToString(Convert.ToDateTime(dt1.Text).ToString("yyyy/MM/dd"));
            fecha = fecha.Replace("/", "");
            //ssql = "select *from sjmh where Sjmh_fecha='"+fecha+"'";

            ssql = @"SELECT * FROM [TwinsDb].[dbo].[IngresoSemanalLC]";

            dt = M.lisquery(ssql);

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
    
        private void btnFatras_Click(object sender, EventArgs e)
        {
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "F";
            if (dgF.Rows.Count < 1)
            {
                b.nrobatea = 0;
            }
            else
            {
                b.nrobatea = Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value);
            }
            //b.nrobatea=Convert.ToInt32(dgF.Rows[dgF.RowCount-1].Cells[4].Value);
            b.mostrar = "PREVIUS";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgF.Rows.Clear();
            lblf1.Text = ".....";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                //if(DT.Rows[i][4].ToString() == "1")
                //{
                //    btnFatras.Enabled = false;
                //    btndelantef.Enabled = true;
                //}
                if (DT.Rows[i][3].ToString() == "F")
                {
                    dgF.Rows.Add(1);
                    dgF.Rows[dgF.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();

                    lblf1.Text = DT.Rows[i][6].ToString();
                    if (DT.Rows[i][7].ToString() == "C")
                    {
                        GFIRME.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        GFIRME.BackColor = Color.GhostWhite;
                    }

                }
            }
            totales(ref dgF, dgF.Name);
            //totales(ref dgI, dgI.Name);
            //totales(ref dgB, dgB.Name);
            navegacionF();
        }
        private void navegacionF()
        {
            ///FFFFFFFFFFF
            try
            {
                string ssql;
                DataTable RS = new DataTable();
                ClsManejador M = new ClsManejador();
                ssql = @"select isnull(SJMBH_NRO,0)from SJMBH 
                inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA = 'F'AND SJMH_NROPROC =" + nropro +
                " AND SJMH_FECHA = '" + Convert.ToString(dt1.Value.ToString("yyyy/MM/dd")).Replace("/", "") + "'";
                RS = M.lisquery(ssql);
                if (RS.Rows.Count > 0)
                {
                    if (dgF.Rows.Count > 0)
                    {
                        int a = Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString());
                        if (Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString()) > Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value))
                        {
                            btndelantef.Enabled = true;
                        }
                        else
                        {
                            btndelantef.Enabled = false;
                        }

                        if (Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value) == 1)
                        {
                            btnFatras.Enabled = false;
                        }
                        else
                        {
                            btnFatras.Enabled = true;
                        }

                    }
                    else
                    {
                        btnFatras.Enabled = true;
                        btndelantef.Enabled = false;
                    }

                }
                else
                {
                    btndelantef.Enabled = false;
                    btnFatras.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void navegacionI()
        {
            try
            {
                string ssql;
                DataTable RS = new DataTable();
                ClsManejador M = new ClsManejador();
                ssql = @"select isnull(SJMBH_NRO,0)from SJMBH 
                inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA = 'I'AND SJMH_NROPROC =" + nropro +
                " AND SJMH_FECHA = '" + Convert.ToString(dt1.Value.ToString("yyyy/MM/dd")).Replace("/", "") + "'";
                RS = M.lisquery(ssql);
                if (RS.Rows.Count > 0)
                {
                    if (dgI.Rows.Count > 0)
                    {
                        int a = Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString());
                        if (Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString()) > Convert.ToInt32(dgI.Rows[dgI.RowCount - 2].Cells[4].Value))
                        {
                            btndelanteI.Enabled = true;
                        }
                        else
                        {
                            btndelanteI.Enabled = false;
                        }

                        if (Convert.ToInt32(dgI.Rows[dgI.RowCount - 2].Cells[4].Value) == 1)
                        {
                            btnatrasI.Enabled = false;
                        }
                        else
                        {
                            btnatrasI.Enabled = true;
                        }

                    }
                    else
                    {
                        btnatrasI.Enabled = true;
                        btndelanteI.Enabled = false;
                    }

                }
                else
                {
                    btndelanteI.Enabled = false;
                    btnatrasI.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void navegacionB()
        {
            try
            {
                string ssql;
                DataTable RS = new DataTable();
                ClsManejador M = new ClsManejador();
                ssql = @"select isnull(SJMBH_NRO,0)from SJMBH 
                inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA = 'B'AND SJMH_NROPROC =" + nropro +
                " AND SJMH_FECHA = '" + Convert.ToString(dt1.Value.ToString("yyyy/MM/dd")).Replace("/", "") + "'";
                RS = M.lisquery(ssql);
                if (RS.Rows.Count > 0)
                {
                    if (dgB.Rows.Count > 0)
                    {
                        int a = Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString());
                        if (Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString()) > Convert.ToInt32(dgB.Rows[dgB.RowCount - 2].Cells[4].Value))
                        {
                            btndelanteB.Enabled = true;
                        }
                        else
                        {
                            btndelanteB.Enabled = false;
                        }

                        if (Convert.ToInt32(dgB.Rows[dgB.RowCount - 2].Cells[4].Value) == 1)
                        {
                            btnatrasB.Enabled = false;
                        }
                        else
                        {
                            btnatrasB.Enabled = true;
                        }

                    }
                    else
                    {
                        btnatrasB.Enabled = true;
                        btndelanteB.Enabled = false;
                    }

                }
                else
                {
                    btndelanteB.Enabled = false;
                    btnatrasB.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refrescargrilla()
        {
            try
            {


                GFIRME.BackColor = Color.GhostWhite;
                GINTER.BackColor = Color.GhostWhite;
                GBLANDO.BackColor = Color.GhostWhite;
                dgF.Rows.Clear();
                dgI.Rows.Clear();
                dgB.Rows.Clear();
                //nropro = Convert.ToInt32(lblnp.Text);
                P.nombre = nropro;
                P.fech = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                DataTable DT = P.BuscarProceso(P.nombre, P.fech);

                for (int i = 0; i < DT.Rows.Count; i++)
                {

                    if (DT.Rows[i][3].ToString() == "F")
                    {
                        dgF.Rows.Add(1);
                        dgF.Rows[dgF.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                        dgF.Rows[dgF.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                        dgF.Rows[dgF.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                        dgF.Rows[dgF.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                        dgF.Rows[dgF.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();
                        lblf1.Text = DT.Rows[i][6].ToString();
                    }
                    if (DT.Rows[i][3].ToString() == "I")
                    {
                        dgI.Rows.Add(1);
                        dgI.Rows[dgI.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                        dgI.Rows[dgI.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                        dgI.Rows[dgI.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                        dgI.Rows[dgI.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                        dgI.Rows[dgI.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();
                        lblf2.Text = DT.Rows[i][6].ToString();
                    }
                    if (DT.Rows[i][3].ToString() == "B")
                    {
                        dgB.Rows.Add(1);
                        dgB.Rows[dgB.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                        dgB.Rows[dgB.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                        dgB.Rows[dgB.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                        dgB.Rows[dgB.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                        dgB.Rows[dgB.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();
                        lblf3.Text = DT.Rows[i][6].ToString();
                    }
                }
                totales(ref dgF, dgF.Name);
                totales(ref dgI, dgI.Name);
                totales(ref dgB, dgB.Name);
                navegacionF();
                navegacionI();
                navegacionB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void totales(ref DataGridView GRILLA, string NOMG)
        {
            if (GRILLA.RowCount > 0)
            P.nombre = nropro;
            P.fech = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            {
                GRILLA.Rows.Add(1);
                GRILLA.Name = NOMG;
                string ssql;
                DataTable RS = new DataTable();
                ClsManejador M = new ClsManejador();
                ssql = @"select uni=count(SJMBH_TEXTURA),Kilos=sum(SJMBI_PESO) 
                from SJMBI i 
                inner join SJMBH b on B.SJMBH_id=I.SJMBI_SJMBH_ID
                inner join sjmh h on h.sjmh_id=B.SJMBH_SJMH_ID
                where sjmh_fecha='" + P.fech + "' and sjmh_nroproc=" + P.nombre + " AND SJMBH_TEXTURA='" + GRILLA.Rows[GRILLA.RowCount - 2].Cells[3].Value + "' AND SJMBH_NRO=" + Convert.ToInt32(GRILLA.Rows[GRILLA.RowCount - 2].Cells[4].Value) + " group by SJMBH_TEXTURA";
                RS = M.lisquery(ssql);
                //String a = RS.Rows[0][0].ToString();

                GRILLA.Rows[GRILLA.RowCount - 1].Cells[0].Value = "Total:";
                GRILLA.Rows[GRILLA.RowCount - 1].Cells[1].Value = RS.Rows[0][0].ToString();
                GRILLA.Rows[GRILLA.RowCount - 1].Cells[2].Value = RS.Rows[0][1].ToString();
                GRILLA.FirstDisplayedScrollingRowIndex = GRILLA.RowCount - 1;
                using (Font font = new Font(
                    GRILLA.DefaultCellStyle.Font.FontFamily, 11, FontStyle.Bold))
                {
                    GRILLA.Rows[GRILLA.RowCount - 1].DefaultCellStyle.Font = font;
                }
                GRILLA.Rows[GRILLA.RowCount - 1].Cells[0].Style.ForeColor = Color.Teal;
                GRILLA.Rows[GRILLA.RowCount - 1].Cells[1].Style.ForeColor = Color.Teal;
                GRILLA.Rows[GRILLA.RowCount - 1].Cells[2].Style.ForeColor = Color.Teal;
            }
        }

        private void btndelantef_Click(object sender, EventArgs e)
        {
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "F";
            b.nrobatea = Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value);
            b.mostrar = "NEXT";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgF.Rows.Clear();
            lblf1.Text = ".....";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                //if (DT.Rows[i][7].ToString() == "A")
                //{
                //    btndelantef.Enabled = false;
                //    btnFatras.Enabled = true;
                //}
                if (DT.Rows[i][3].ToString() == "F")
                {
                    dgF.Rows.Add(1);
                    dgF.Rows[dgF.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                    dgF.Rows[dgF.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();
                    lblf1.Text = DT.Rows[i][6].ToString();

                }
                if (DT.Rows[i][7].ToString() == "C")
                {
                    GFIRME.BackColor = Color.MistyRose;
                }
                else
                {
                    GFIRME.BackColor = Color.GhostWhite;
                }
            }
            totales(ref dgF, dgF.Name);
            navegacionF();
        }

        private void btnatrasI_Click(object sender, EventArgs e)
        {
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "I";
            if (dgI.Rows.Count < 1)
            {
                b.nrobatea = 0;
            }
            else
            {
                b.nrobatea = Convert.ToInt32(dgI.Rows[dgI.RowCount - 2].Cells[4].Value);
            }
            //b.nrobatea=Convert.ToInt32(dgF.Rows[dgF.RowCount-1].Cells[4].Value);
            b.mostrar = "PREVIUS";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgI.Rows.Clear();
            lblf2.Text = ".....";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                //if(DT.Rows[i][4].ToString() == "1")
                //{
                //    btnFatras.Enabled = false;
                //    btndelantef.Enabled = true;
                //}
                if (DT.Rows[i][3].ToString() == "I")
                {
                    dgI.Rows.Add(1);
                    dgI.Rows[dgI.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();

                    lblf2.Text = DT.Rows[i][6].ToString();
                    if (DT.Rows[i][7].ToString() == "C")
                    {
                        GINTER.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        GINTER.BackColor = Color.GhostWhite;
                    }

                }
            }
            totales(ref dgI, dgI.Name);
            navegacionI();
        }

        private void btnatrasB_Click(object sender, EventArgs e)
        {
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "B";
            if (dgB.Rows.Count < 1)
            {
                b.nrobatea = 0;
            }
            else
            {
                b.nrobatea = Convert.ToInt32(dgB.Rows[dgB.RowCount - 2].Cells[4].Value);
            }
            //b.nrobatea=Convert.ToInt32(dgF.Rows[dgF.RowCount-1].Cells[4].Value);
            b.mostrar = "PREVIUS";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgB.Rows.Clear();
            lblf3.Text = ".....";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                //if(DT.Rows[i][4].ToString() == "1")
                //{
                //    btnFatras.Enabled = false;
                //    btndelantef.Enabled = true;
                //}
                if (DT.Rows[i][3].ToString() == "B")
                {
                    dgB.Rows.Add(1);
                    dgB.Rows[dgB.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();

                    lblf3.Text = DT.Rows[i][6].ToString();
                    if (DT.Rows[i][7].ToString() == "C")
                    {
                        GBLANDO.BackColor = Color.MistyRose;
                    }
                    else
                    {
                        GBLANDO.BackColor = Color.GhostWhite;
                    }
                }
            }
            totales(ref dgB, dgB.Name);
            navegacionB();
        }

        private void btndelanteI_Click(object sender, EventArgs e)
        {
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "I";
            b.nrobatea = Convert.ToInt32(dgI.Rows[dgI.RowCount - 2].Cells[4].Value);
            b.mostrar = "NEXT";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgI.Rows.Clear();
            //lblf1.Text = ".....";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                //if (DT.Rows[i][7].ToString() == "A")
                //{
                //    btndelantef.Enabled = false;
                //    btnFatras.Enabled = true;
                //}
                if (DT.Rows[i][3].ToString() == "I")
                {
                    dgI.Rows.Add(1);
                    dgI.Rows[dgI.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                    dgI.Rows[dgI.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();
                    lblf2.Text = DT.Rows[i][6].ToString();

                }
                if (DT.Rows[i][7].ToString() == "C")
                {
                    GINTER.BackColor = Color.MistyRose;
                }
                else
                {
                    GINTER.BackColor = Color.GhostWhite;
                }
            }
            totales(ref dgI, dgI.Name);
            navegacionI();
        }

        private void btndelanteB_Click(object sender, EventArgs e)
        {
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "B";
            b.nrobatea = Convert.ToInt32(dgB.Rows[dgB.RowCount - 2].Cells[4].Value);
            b.mostrar = "NEXT";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgB.Rows.Clear();
            //lblf1.Text = ".....";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i][3].ToString() == "B")
                {
                    dgB.Rows.Add(1);
                    dgB.Rows[dgB.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                    dgB.Rows[dgB.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();
                    lblf3.Text = DT.Rows[i][6].ToString();

                }
                if (DT.Rows[i][7].ToString() == "C")
                {
                    GBLANDO.BackColor = Color.MistyRose;
                }
                else
                {
                    GBLANDO.BackColor = Color.GhostWhite;
                }
            }
            totales(ref dgB, dgB.Name);
            navegacionB();
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            inicontroles();
            cargargrilla();
        }
        private void inicontroles()
        {
            dgF.Rows.Clear();
            dgI.Rows.Clear();
            dgB.Rows.Clear();
            dtgpro.Rows.Clear();
            GBLANDO.BackColor = Color.GhostWhite;
            GINTER.BackColor = Color.GhostWhite;
            GFIRME.BackColor = Color.GhostWhite;
            lblf1.Text = "......";
            lblf2.Text = "......";
            lblf3.Text = "......";
            lbltipodej.Text = "";
            btndelantef.Enabled = false;
            btnFatras.Enabled = false;
            btndelanteI.Enabled = false;
            btnatrasI.Enabled = false;
            btndelanteB.Enabled = false;
            btnatrasB.Enabled = false;
        }

        private void FrmReSjamon_Load(object sender, EventArgs e)
        {
            inicontroles();
        }

        private void printF_Click(object sender, EventArgs e)
        {
            if (dgF.RowCount < 1)
            {
                MessageBox.Show("NO Existen Datos Para Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgF.Rows.RemoveAt(dgF.RowCount - 1);
            DataTable dtB = new DataTable();
            dtB.Columns.Add("lote", typeof(System.String));
            dtB.Columns.Add("uni", typeof(System.Int32));
            dtB.Columns.Add("peso", typeof(System.Double));

            foreach (DataGridViewRow rowGrid in dgF.Rows)
            {
                DataRow row = dtB.NewRow();

                if (rowGrid.Cells[0].Value != null)
                {
                    row["lote"] = rowGrid.Cells[0].Value;
                }
                row["uni"] = rowGrid.Cells[1].Value;
                row["peso"] = rowGrid.Cells[2].Value;

                dtB.Rows.Add(row);
            }
            totales(ref dgF, dgF.Name);
            ///////////////
            ReporteBatea _ReporteBatea = new ReporteBatea();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            datos.Btipo = dtgpro.CurrentRow.Cells[4].Value.ToString();
            datos.Blote = lblf1.Text;
            datos.Nrotextura = 1;

            _ReporteBatea.datosR.Add(datos);
            _ReporteBatea.dtr.Columns.Add("lote", typeof(System.String));
            _ReporteBatea.dtr.Columns.Add("uni", typeof(System.Int32));
            _ReporteBatea.dtr.Columns.Add("peso", typeof(System.Decimal));
            _ReporteBatea.dtr = dtB;
            _ReporteBatea.StartPosition = FormStartPosition.CenterScreen;
            _ReporteBatea.MdiParent = this.MdiParent;
            _ReporteBatea.Show();
            //////////////
        }

        private void printI_Click(object sender, EventArgs e)
        {
            if (dgI.RowCount < 1)
            {
                MessageBox.Show("NO Existen Datos Para Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgI.Rows.RemoveAt(dgI.RowCount - 1);
            DataTable dtB = new DataTable();
            dtB.Columns.Add("lote", typeof(System.String));
            dtB.Columns.Add("uni", typeof(System.Int32));
            dtB.Columns.Add("peso", typeof(System.Double));

            foreach (DataGridViewRow rowGrid in dgI.Rows)
            {
                DataRow row = dtB.NewRow();

                if (rowGrid.Cells[0].Value != null)
                {
                    row["lote"] = rowGrid.Cells[0].Value;
                }
                row["uni"] = rowGrid.Cells[1].Value;
                row["peso"] = rowGrid.Cells[2].Value;

                dtB.Rows.Add(row);
            }
            ///////////////
            totales(ref dgI, dgI.Name);
            ReporteBatea _ReporteBatea = new ReporteBatea();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            datos.Btipo = dtgpro.CurrentRow.Cells[4].Value.ToString();
            datos.Blote = lblf2.Text;
            datos.Nrotextura = 2;

            _ReporteBatea.datosR.Add(datos);
            _ReporteBatea.dtr.Columns.Add("lote", typeof(System.String));
            _ReporteBatea.dtr.Columns.Add("uni", typeof(System.Int32));
            _ReporteBatea.dtr.Columns.Add("peso", typeof(System.Decimal));
            _ReporteBatea.dtr = dtB;
            _ReporteBatea.StartPosition = FormStartPosition.CenterScreen;
            _ReporteBatea.MdiParent = this.MdiParent;
            _ReporteBatea.Show();
            //////////////
        }

        private void printB_Click(object sender, EventArgs e)
        {
            if (dgB.RowCount < 1)
            {
                MessageBox.Show("NO Existen Datos Para Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           dgB.Rows.RemoveAt(dgB.RowCount - 1);
            DataTable dtB = new DataTable();
            dtB.Columns.Add("lote", typeof(System.String));
            dtB.Columns.Add("uni", typeof(System.Int32));
            dtB.Columns.Add("peso", typeof(System.Double));

            foreach (DataGridViewRow  rowGrid in dgB.Rows)
            {
                DataRow row = dtB.NewRow();

                if (rowGrid.Cells[0].Value != null)
                {
                    row["lote"] = rowGrid.Cells[0].Value;
                }
                row["uni"] = rowGrid.Cells[1].Value;
                row["peso"] = rowGrid.Cells[2].Value;

                dtB.Rows.Add(row);
            }
            ///////////////
            totales(ref dgB, dgB.Name);
            ReporteBatea _ReporteBatea = new ReporteBatea();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            datos.Btipo = dtgpro.CurrentRow.Cells[4].Value.ToString();
            datos.Blote = lblf3.Text;
            datos.Nrotextura = 3;

            _ReporteBatea.datosR.Add(datos);
            _ReporteBatea.dtr.Columns.Add("lote", typeof(System.String));
            _ReporteBatea.dtr.Columns.Add("uni", typeof(System.Int32));
            _ReporteBatea.dtr.Columns.Add("peso", typeof(System.Decimal));
            _ReporteBatea.dtr = dtB;
            _ReporteBatea.StartPosition = FormStartPosition.CenterScreen;
            _ReporteBatea.MdiParent = this.MdiParent;
            _ReporteBatea.Show();
            //////////////
        }

        private void print_Click(object sender, EventArgs e)
        {
            //F
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"));
            b.textura = "F";
            //b.nrobatea = 0;
            int numeromaxBatea;
            string ssql;
            DataTable RSimp = new DataTable();
            ClsManejador M = new ClsManejador();
            ssql = @"select robatea = isnull(max(SJMBH_NRO),0) from SJMBH
            inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA =" + "'F'" + "AND SJMH_NROPROC = " + nropro + " AND SJMH_FECHA ='" + Convert.ToString(dt1.Value.ToString("yyyy /MM/dd")) + "'";
            RSimp = M.lisquery(ssql);
            numeromaxBatea = Convert.ToInt32(RSimp.Rows[0][0].ToString());
            if (numeromaxBatea > 0)
            {
                for (int J = 0; J < numeromaxBatea; J++)
                {
                    b.nrobatea = J + 1;
                    DataTable DT = b.BuscarBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea);
                    dgF.Rows.Clear();
                    lblf1.Text = ".....";
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        if (DT.Rows[i][3].ToString() == "F")
                        {
                            dgF.Rows.Add(1);
                            dgF.Rows[dgF.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                            dgF.Rows[dgF.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                            dgF.Rows[dgF.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                            dgF.Rows[dgF.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                            dgF.Rows[dgF.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();

                            lblf1.Text = DT.Rows[i][6].ToString();
                            if (DT.Rows[i][7].ToString() == "C")
                            {
                                GFIRME.BackColor = Color.MistyRose;
                            }
                            else
                            {
                                GFIRME.BackColor = Color.GhostWhite;
                            }

                        }

                    }
                    dgF.Rows.Add(1);
                    printF.PerformClick();
                }
            }
            //IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"));
            b.textura = "I";
            //b.nrobatea = 0;
            numeromaxBatea = 0;

            DataTable RSimpI = new DataTable();
            ClsManejador MI = new ClsManejador();
            ssql = @"select robatea = isnull(max(SJMBH_NRO),0) from SJMBH
            inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA =" + "'I'" + "AND SJMH_NROPROC = " + nropro + " AND SJMH_FECHA ='" + Convert.ToString(dt1.Value.ToString("yyyy /MM/dd")) + "'";
            RSimpI = MI.lisquery(ssql);
            numeromaxBatea = Convert.ToInt32(RSimpI.Rows[0][0].ToString());
            if (numeromaxBatea > 0)
            {
                for (int J = 0; J < numeromaxBatea; J++)
                {
                    b.nrobatea = J + 1;
                    DataTable DT = b.BuscarBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea);
                    dgI.Rows.Clear();
                    lblf2.Text = ".....";
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        if (DT.Rows[i][3].ToString() == "I")
                        {
                            dgI.Rows.Add(1);
                            dgI.Rows[dgI.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                            dgI.Rows[dgI.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                            dgI.Rows[dgI.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                            dgI.Rows[dgI.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                            dgI.Rows[dgI.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();

                            lblf2.Text = DT.Rows[i][6].ToString();
                            if (DT.Rows[i][7].ToString() == "C")
                            {
                                GINTER.BackColor = Color.MistyRose;
                            }
                            else
                            {
                                GINTER.BackColor = Color.GhostWhite;
                            }

                        }

                    }
                    dgI.Rows.Add(1);
                    printI.PerformClick();
                }
            }
            //BBBBBBBBBBBBBBBBBBBBBBBB

            //nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"));
            b.textura = "B";
            //b.nrobatea = 0;
            numeromaxBatea = 0;

            DataTable RSimpB = new DataTable();
            ClsManejador MB = new ClsManejador();
            ssql = @"select robatea = isnull(max(SJMBH_NRO),0) from SJMBH
            inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA =" + "'B'" + "AND SJMH_NROPROC = " + nropro + " AND SJMH_FECHA ='" + Convert.ToString(dt1.Value.ToString("yyyy /MM/dd")) + "'";
            RSimpB = MB.lisquery(ssql);
            numeromaxBatea = Convert.ToInt32(RSimpB.Rows[0][0].ToString());
            if (numeromaxBatea > 0)
            {
                for (int J = 0; J < numeromaxBatea; J++)
                {
                    b.nrobatea = J + 1;
                    DataTable DT = b.BuscarBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea);
                    dgB.Rows.Clear();
                    lblf3.Text = ".....";
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        if (DT.Rows[i][3].ToString() == "B")
                        {
                            dgB.Rows.Add(1);
                            dgB.Rows[dgB.RowCount - 1].Cells[0].Value = DT.Rows[i][0].ToString();
                            dgB.Rows[dgB.RowCount - 1].Cells[1].Value = DT.Rows[i][1].ToString();
                            dgB.Rows[dgB.RowCount - 1].Cells[2].Value = DT.Rows[i][2].ToString();
                            dgB.Rows[dgB.RowCount - 1].Cells[3].Value = DT.Rows[i][3].ToString();
                            dgB.Rows[dgB.RowCount - 1].Cells[4].Value = DT.Rows[i][4].ToString();

                            lblf3.Text = DT.Rows[i][6].ToString();
                            if (DT.Rows[i][7].ToString() == "C")
                            {
                                GBLANDO.BackColor = Color.MistyRose;
                            }
                            else
                            {
                                GBLANDO.BackColor = Color.GhostWhite;
                            }

                        }

                    }
                    dgB.Rows.Add(1);
                    printB.PerformClick();
                }
            }
        }

        private void dtgpro_DoubleClick(object sender, EventArgs e)
        {
            if (dtgpro.RowCount > 0)
            {
                if (dtgpro.CurrentRow.Cells[5].Value.ToString() == "A")
                {
                    MessageBox.Show("Proceso esta Abierto, No se pude Imprimir", "Proceso Abierto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                nropro = Convert.ToInt32(dtgpro.CurrentRow.Cells[2].Value.ToString());
                idtipo = Convert.ToInt32(dtgpro.CurrentRow.Cells[3].Value.ToString());
                lbltipodej.Text = dtgpro.CurrentRow.Cells[4].Value.ToString();
                //lbltipodej.Text =
                //FrmSelecJamon.tipojid = Convert.ToInt32(dtgpro.CurrentRow.Cells[3].Value.ToString());

                dgF.Rows.Clear();
                dgI.Rows.Clear();
                dgB.Rows.Clear();
                navegacionF();
                navegacionI();
                navegacionB();
                
                btnFatras.PerformClick();
                btnatrasI.PerformClick();
                btnatrasB.PerformClick();
                //totales(ref dgF, dgF.Name);
                //totales(ref dgI, dgI.Name);
                //totales(ref dgB, dgB.Name);

            }
        }
    }
}
