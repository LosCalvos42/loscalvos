using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;
using Datos;
using System.Text.RegularExpressions;

namespace Alberdi
{
    public partial class FrmSelecJamon : Form
    {
        
        public static int nropro;
        public static int idtipo;
        public static int flag;
        public static string estado_proc;
        public int ulnumerolote;
        //string es_nuevo; 
        Clsproceso P = new Clsproceso();
        ClsProcesoBatea b = new ClsProcesoBatea();
        ClsTipoJamon C = new ClsTipoJamon();
        ClsSJamones S = new ClsSJamones();
        public FrmSelecJamon()
        {
            InitializeComponent();
        }

        private void FrmSelecJamon_Load(object sender, EventArgs e)
        {
            //if (ClsManejador.ip == "DESARROLLO")
            //{
            //    this.BackColor = Color.Gainsboro;
            //}
            //else
            //{
            //    this.BackColor = Color.GhostWhite;
            //}
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            puertosDisponibles();
            Control.CheckForIllegalCrossThreadCalls = false;
            inicontroles();

        }
        private void inicontroles()
        {
            CargarComboBox();
        }
        private void CargarComboBox()
        {
            //cmbtipojamon.DataSource = C.Listar();
            //cmbtipojamon.DisplayMember = "TIPOJAMON_DESC";
            //cmbtipojamon.ValueMember = "TIPOJAMON_ID";
            //cmbtipojamon.SelectedValue = -1;
        }

        private void puertosDisponibles()
        {
            foreach (string puertoDis in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(puertoDis);
                
            }
        }
        private void cmbPuertos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPuertos.Text;
            cmbPuertos.Enabled = false;
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                }
                serialPort1.Open();

                cmbtipojamon.Focus();
                gh.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciones otro puerto", "Puerto no disponible");
  //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPuertos.Enabled = true;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (lblespe.Visible == true)
            {
                //System.Threading.Thread.Sleep(2000);
                string datorx = "";
                datorx = serialPort1.ReadLine();

                datorx=RemoveSpecialCharacters(datorx);
                serialPort1.DiscardInBuffer();
                string[] words = datorx.Split('k');
                decimal peso = 0;
                peso= Convert.ToDecimal(words[0].ToString().Replace(".", ","));
                lblKg.Text = Convert.ToString(peso.ToString().Replace(",", "."));
                lblespe.Visible = false;
                groupBox1.Enabled = true;
                groupBox1.BackColor = Color.Beige;
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
            }
        }
        private void FrmSelecJamon_Resize(object sender, EventArgs e)
        {

        }
        private string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, @"[^0-9A-Za-z.]", "", RegexOptions.None);
        }
        private void FrmSelecJamon_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        public  void guardar(String textura)
        {
                try
                {
                    S.Hid = 0;
                    S.Hfecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd").Replace("/", ""));
                    S.Hnroproc = Convert.ToInt32(lblnp.Text);
                    S.Htipo = Convert.ToInt32(cmbtipojamon.SelectedValue);
                    S.Hestado = "A";
                    S.Hdebaja = "N";

                    S.Iid = 0;
                    S.IHid = 0;
                    S.Ilote = "H";
                    S.Inropieza = "H";
                    S.Ipeso = Convert.ToDecimal(lblKg.Text.ToString().Replace(".", ","));
                    S.Icodbar = txtetiqueta.Text;
                    S.Itextura = textura;
                    S.Inroitem = 0;
                    S.Inrobate = 0;

                    S.RegistrarSeleccion();
                    if (chSineti.Checked == true)
                    { 
                        ClsManejador M = new ClsManejador();
                        M.Ejecutarquery(@"update parametros set valor= '"+Convert.ToString(ulnumerolote)+ "' where parametro_id=6");
                    }
                    refrescargrilla();
                    txtetiqueta.Text = "";
                    lblKg.Text = "";
                    lblespe.Visible = false;
                    groupBox1.Enabled = false;
                    groupBox1.BackColor = Color.GhostWhite;
                    textura = "";
                    txtetiqueta.Focus();
                    serialPort1.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void txtetiqueta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chSineti.Checked==true)
                {
                    if (txtetiqueta.Text != "" & txtetiqueta.Text.Length == 4)
                    {
                        string ssql;
                        lblLotechek.Text = txtetiqueta.Text;
                        DataTable RS = new DataTable();
                        ClsManejador M = new ClsManejador();
                        ssql = @"select valor from parametros where parametro_id = 6";
                        RS = M.lisquery(ssql);
                        
                        //string ulsinlote = RS.Rows[0][0].ToString();
                        ulnumerolote = Convert.ToInt32(RS.Rows[0][0].ToString()) +1;
                        string ss = txtetiqueta.Text.Substring(0, 1);
                        
                        if (ss=="5")
                        {
                            MessageBox.Show("SIN ETIQUETA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            button2.PerformClick();
                            return;
                        }

                        txtetiqueta.Text = DateTime.Today.ToString("yyyy")+lblLotechek.Text+ulnumerolote;
                        
                    }
                }

                if (txtetiqueta.Text != "" & txtetiqueta.Text.Length == 13)
                {
                    txtetiqueta.Enabled = false;
                    string ssql;
                    DataTable RS = new DataTable();
                    ClsManejador M = new ClsManejador();
                    ssql = @"select isnull(max(sjmbi_codbar),0)from sjmbi where sjmbi_codbar='" + txtetiqueta.Text + "'";
                    RS = M.lisquery(ssql);
                    String a = RS.Rows[0][0].ToString();
                    if (a != "0")
                    {

                        //ssql = RS.Rows[0][0].ToString();
                        MessageBox.Show("El codigo de Barras YA FUE LEIDOooo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //ssql = RS.Rows[0][0].ToString();
                        txtetiqueta.Text = "";
                        MessageBox.Show("El codigo de Barras YA FUE LEIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtetiqueta.Enabled = true;
                        txtetiqueta.Focus();
                        return;
                    }
                    try
                    {
                        if (serialPort1.IsOpen == true)
                        {
                            serialPort1.Close();
                        }
                        serialPort1.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lblespe.Visible = true;
                }
                else
                {
                    lblespe.Visible = false;
                    txtetiqueta.Enabled = true;
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
                nropro = Convert.ToInt32(lblnp.Text);
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
                        lblf1.Text= DT.Rows[i][6].ToString();
                        
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

        private void totales(ref DataGridView GRILLA,string NOMG)
        {
            if (GRILLA.RowCount > 0)
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
                //for (int i = 0; i < dgF.Rows.Count; i++)
                //{
                //    uniF = uniF + Convert.ToInt32(dgF.Rows[i].Cells[1].Value.ToString());
                //}
                //dgF.Rows.Add(1);
                //dgF.Rows[dgF.RowCount - 1].Cells[0].Value = "Total:";
                //dgF.Rows[dgF.RowCount - 1].Cells[1].Value = uniF;
                //dgF.FirstDisplayedScrollingRowIndex = dgF.RowCount - 1;

                //for (int i = 0; i < dgI.Rows.Count; i++)
                //{
                //    uniI = uniI + Convert.ToInt32(dgI.Rows[i].Cells[1].Value.ToString());
                //}
                //dgI.Rows.Add(1);
                //dgI.Rows[dgI.RowCount - 1].Cells[0].Value = "Total:";
                //dgI.Rows[dgI.RowCount - 1].Cells[1].Value = uniI;
                //dgI.FirstDisplayedScrollingRowIndex = dgI.RowCount - 1;

                //for (int i = 0; i < dgB.Rows.Count; i++)
                //{
                //    uniB = uniB + Convert.ToInt32(dgB.Rows[i].Cells[1].Value.ToString());
                //}
                //dgB.Rows.Add(1);
                //dgB.Rows[dgB.RowCount - 1].Cells[0].Value = "Total:";
                //dgB.Rows[dgB.RowCount - 1].Cells[1].Value = uniB;
                //dgB.FirstDisplayedScrollingRowIndex = dgB.RowCount - 1;
            }
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
                inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA = 'F'AND SJMH_NROPROC =" + Convert.ToInt32(lblnp.Text) +
                " AND SJMH_FECHA = '" + Convert.ToString(dt1.Value.ToString("yyyy/MM/dd")).Replace("/", "")+"'";
                RS = M.lisquery(ssql);
                if (RS.Rows.Count>0)
                { 
                    if (dgF.Rows.Count > 0)
                    {
                        int a = Convert.ToInt32(RS.Rows[RS.Rows.Count - 1][0].ToString());
                        if (Convert.ToInt32(RS.Rows[RS.Rows.Count-1 ][0].ToString())> Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value))
                        {                                                                                                     //2 POR QUE EL -1 ES EL TOTAL                  
                            btndelantef.Enabled = true;
                        }
                        else
                        {
                            btndelantef.Enabled = false;
                        }

                        if (Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value)==1)
                        {                                            //2 POR QUE EL -1 ES EL TOTAL
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
                inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA = 'I'AND SJMH_NROPROC =" + Convert.ToInt32(lblnp.Text) +
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
                inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA = 'B'AND SJMH_NROPROC =" + Convert.ToInt32(lblnp.Text) +
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgF.Rows.Clear();
            dgI.Rows.Clear();
            dgB.Rows.Clear();
            string ssql;
            string fecha;
            fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            fecha = fecha.Replace("/", "");
            cmbtipojamon.SelectedValue = -1;
            //es_nuevo = "S";
            DataTable dt = new DataTable();
            ClsManejador M = new ClsManejador();
            ssql = @"select isNull(max(sjmh_nroproc),0)+1 as nro from sjmh where sjmh_fecha='" + fecha + "'";

            dt = M.lisquery(ssql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                lblnp.Text = dt.Rows[i][0].ToString();
                ghi.Enabled = true;
                gh.Enabled = false;
                cmbtipojamon.Focus();
            }
            lblf1.Text = ".....";
            lblf2.Text = ".....";
            lblf3.Text = ".....";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtipojamon.SelectedValue = -1;
            cmbtipojamon.SelectedValue = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 0;
            //es_nuevo = "N";
            frmSelecHJamon _frmSelecHJamon = new frmSelecHJamon();
            _frmSelecHJamon.StartPosition = FormStartPosition.CenterScreen;
            
            _frmSelecHJamon.lblfecha.Text = dt1.Text;
            _frmSelecHJamon.ShowDialog();

            if (flag == 0)
            {
                return;
            }
            P.nombre = nropro;
            P.fech= Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            DataTable DT = P.BuscarProceso(P.nombre,P.fech);

            lblnp.Text = Convert.ToString(nropro);
            cmbtipojamon.SelectedValue = idtipo;
            ghi.Enabled = true;
            dgF.Rows.Clear();
            dgI.Rows.Clear();
            dgB.Rows.Clear();

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
                    //totales(ref dgB, dgB.Name);
                }
            }
            totales(ref dgF, dgF.Name);
            totales(ref dgI, dgI.Name);
            totales(ref dgB, dgB.Name);
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (cmbtipojamon.SelectedIndex >= 0)
            {
                gh.Enabled = false;
                ghi.Enabled = false;
                gi.Enabled = true;
                txtetiqueta.Focus();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Tipo de Jamón", "Seleccionar", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                cmbtipojamon.Focus();
            }
            btnFatras.Enabled = false;
            btndelantef.Enabled = false;

            navegacionF();
            navegacionI();
            navegacionB();
        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            lblnp.Text = "";
            gh.Enabled = true;
            ghi.Enabled = false;
            gi.Enabled = false;
            dgF.Rows.Clear();
            dgI.Rows.Clear();
            dgB.Rows.Clear();
            cmbtipojamon.SelectedIndex = -1;
            nropro = 0;
            idtipo = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblespe.Visible = false; 
            txtetiqueta.Text = "";
            txtetiqueta.Focus();
            lblKg.Text = "";
            groupBox1.Enabled = false;
            
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            dgF.Rows.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Program._FrmSelecJamon = false;
        }

        private void PF_Click(object sender, EventArgs e)
        {
            guardar("F");
        }

        private void PI_Click(object sender, EventArgs e)
        {
            guardar("I");
        }

        private void PB_Click(object sender, EventArgs e)
        {
            guardar("B");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta a punto de Cerrar todas las bateas y Cerrar el Proceso.\nDesea Continuar? ", "Seleccion de Jamón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    string ssql;
                    string fecha;
                    
                    fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                    fecha = fecha.Replace("/", "");

                    
                    ClsManejador M = new ClsManejador();
                    
                    ssql = @"update SJMH set SJMH_ESTADO='C' where sjmh_fecha='" + fecha + "' and SJMH_NROPROC="+Convert.ToInt32(lblnp.Text) ;
                    M.lisquery(ssql);
                    ssql = @" UPDATE t1
                    SET t1.SJMBH_ESTADO = 'C'
                    FROM SJMBH t1
                    INNER JOIN SJMH t2
                    ON t1.SJMBH_SJMH_ID = t2.SJMH_ID
                    where t2.SJMH_FECHA = '" + fecha + "'and t2.SJMH_NROPROC = " + Convert.ToInt32(lblnp.Text);
                    M.lisquery(ssql);
                    estado_proc = "C";
                    lblPT.Visible = true;
                    txtetiqueta.Enabled = false;
                    refrescargrilla();
                    lblf1.Text = ".....";
                    lblf2.Text = ".....";
                    lblf3.Text = ".....";
                    print.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                return;
            }
        }



        private void print_Click(object sender, EventArgs e)
        {
            //F
            nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"));
            b.textura = "F";
            //b.nrobatea = 0;
            int numeromaxBatea;
            string ssql;
            DataTable RSimp = new DataTable();
            ClsManejador M = new ClsManejador();
            ssql = @"select robatea = isnull(max(SJMBH_NRO),0) from SJMBH
            inner join SJMH on SJMH_ID = SJMBH_SJMH_ID where SJMBH_TEXTURA =" + "'F'" + "AND SJMH_NROPROC = " + nropro + " AND SJMH_FECHA ='" + Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"))+"'";
            RSimp = M.lisquery(ssql);
            numeromaxBatea = Convert.ToInt32(RSimp.Rows[0][0].ToString());
            if (numeromaxBatea > 0) { 
                for (int J=0; J < numeromaxBatea;J++)
                {
                    b.nrobatea = J+1;
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

                    printF.PerformClick();
                }
            }
            //IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
            nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"));
            b.textura = "I";
            numeromaxBatea=0;
            
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

                    printI.PerformClick();
                }
            }
            //BBBBBBBBBBBBBBBBBBBBBBBB

            nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy /MM/dd"));
            b.textura = "B";
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

                    printB.PerformClick();
                }
            }
        }
        private void btnCF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Cerrar la Batea?", "Seleccion de Jamón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    string ssql;
                    string fecha;
                    fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                    fecha = fecha.Replace("/", "");


                    ClsManejador M = new ClsManejador();
                    ssql = @" UPDATE t1
                    SET t1.SJMBH_ESTADO = 'C'
                    FROM SJMBH t1
                    INNER JOIN SJMH t2
                    ON t1.SJMBH_SJMH_ID = t2.SJMH_ID
                    where t2.SJMH_FECHA = '" + fecha + "'and t2.SJMH_NROPROC = " + Convert.ToInt32(lblnp.Text) + "and t1.SJMBH_TEXTURA = 'F'";
                    M.lisquery(ssql);
                    refrescargrilla();
                    lblf1.Text = ".....";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Cerrar la Batea?", "Seleccion de Jamón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string ssql;
                    string fecha;
                    fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                    fecha = fecha.Replace("/", "");


                    ClsManejador M = new ClsManejador(); 
                    ssql = @" UPDATE t1
                    SET t1.SJMBH_ESTADO = 'C'
                    FROM SJMBH t1
                    INNER JOIN SJMH t2
                    ON t1.SJMBH_SJMH_ID = t2.SJMH_ID
                    where t2.SJMH_FECHA = '" + fecha + "'and t2.SJMH_NROPROC = " + Convert.ToInt32(lblnp.Text) + "and t1.SJMBH_TEXTURA = 'I'";
                    M.lisquery(ssql);
                    refrescargrilla();
                    lblf2.Text = ".....";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Cerrar la Batea?", "Seleccion de Jamón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string ssql;
                    string fecha;
                    fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
                    fecha = fecha.Replace("/", "");
                    ClsManejador M = new ClsManejador();
                    ssql = @" UPDATE t1
                    SET t1.SJMBH_ESTADO = 'C'
                    FROM SJMBH t1
                    INNER JOIN SJMH t2
                    ON t1.SJMBH_SJMH_ID = t2.SJMH_ID
                    where t2.SJMH_FECHA = '" + fecha + "'and t2.SJMH_NROPROC = " + Convert.ToInt32(lblnp.Text) + "and t1.SJMBH_TEXTURA = 'B'";
                    M.lisquery(ssql);
                    refrescargrilla();
                    lblf3.Text = ".....";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
        private void btnFatras_Click(object sender, EventArgs e)
        { 
            nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "F";
            if (dgF.Rows.Count<1)
            {
                b.nrobatea = 0;
            }
            else
            {
                b.nrobatea = Convert.ToInt32(dgF.Rows[dgF.RowCount - 2].Cells[4].Value);
            }
            b.mostrar = "PREVIUS";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID,b.fecha,b.textura,b.nrobatea,b.mostrar);
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
            totales(ref dgF, dgF.Name);
            navegacionF();
        }

        private void btndelantef_Click(object sender, EventArgs e)
        {

            nropro = Convert.ToInt32(lblnp.Text);
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

        private void btndelanteI_Click(object sender, EventArgs e)
        {
            nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "I";
            b.nrobatea = Convert.ToInt32(dgI.Rows[dgI.RowCount - 2].Cells[4].Value);
            b.mostrar = "NEXT";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgI.Rows.Clear();
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

        private void btnatrasI_Click(object sender, EventArgs e)
        {

            nropro = Convert.ToInt32(lblnp.Text);
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
            b.mostrar = "PREVIUS";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
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
            totales(ref dgI, dgI.Name);
            navegacionI();
        }

        private void btnatrasB_Click(object sender, EventArgs e)
        {
            nropro = Convert.ToInt32(lblnp.Text);
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
            b.mostrar = "PREVIUS";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
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

            totales(ref dgB, dgB.Name); ;
            navegacionB(); 
        }

        private void btndelanteB_Click(object sender, EventArgs e)
        {
            nropro = Convert.ToInt32(lblnp.Text);
            b.PRO_ID = nropro;
            b.fecha = Convert.ToString(dt1.Value.ToString("yyyy/MM/dd"));
            b.textura = "B";
            b.nrobatea = Convert.ToInt32(dgB.Rows[dgB.RowCount - 2].Cells[4].Value);
            b.mostrar = "NEXT";
            DataTable DT = b.BuscarProcesoBatea(b.PRO_ID, b.fecha, b.textura, b.nrobatea, b.mostrar);
            dgB.Rows.Clear();

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
            totales(ref dgB, dgB.Name); ;
            navegacionB();
        }

        private void printF_Click(object sender, EventArgs e)
        {
            if (dgF.RowCount < 1)
            {
                MessageBox.Show("NO Existen Datos Para Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GFIRME.BackColor == Color.GhostWhite)
            {
                MessageBox.Show("Debe Cerrar la Batea Para Poder Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         


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
            ///////////////
            ReporteBatea _ReporteBatea = new ReporteBatea();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            datos.Btipo = cmbtipojamon.Text;
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
            if (GINTER.BackColor == Color.GhostWhite)
            {
                MessageBox.Show("Debe Cerrar la Batea Para Poder Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
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
            ReporteBatea _ReporteBatea = new ReporteBatea();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            datos.Btipo = cmbtipojamon.Text;
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
            if (GBLANDO.BackColor == Color.GhostWhite)
            {
                MessageBox.Show("Debe Cerrar la Batea Para Poder Imprimir", "IMPRIMIR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtB = new DataTable();
            dtB.Columns.Add("lote", typeof(System.String));
            dtB.Columns.Add("uni", typeof(System.Int32));
            dtB.Columns.Add("peso", typeof(System.Double));

            foreach (DataGridViewRow rowGrid in dgB.Rows)
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
            ReporteBatea _ReporteBatea = new ReporteBatea();
            ClsDatosReporteBatea datos = new ClsDatosReporteBatea();
            datos.Btipo = cmbtipojamon.Text;
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

        private void txtetiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)46) && (e.KeyChar != (char)13))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void chSineti_CheckedChanged(object sender, EventArgs e)
        {
            if (chSineti.Checked == true)
            {
                lblLotechek.Visible = true;
                txtetiqueta.Focus();

            }
            else
            {
                lblLotechek.Visible = false;
                lblLotechek.Text = "";
                button2.PerformClick();
                txtetiqueta.Focus();
            }
        }

        private void lblLotechek_DoubleClick(object sender, EventArgs e)
        {
            if (lblLotechek.Text != "")
            {
                txtetiqueta.Text = lblLotechek.Text;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos _FrmUser = new FrmProductos();
            _FrmUser.Parent = this.MdiParent;
            _FrmUser.Dock = DockStyle.Fill;
            
            _FrmUser.Show();
        }
    }
}
