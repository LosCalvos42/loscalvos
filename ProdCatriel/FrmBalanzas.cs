using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LOSCALVOS
{
    public partial class FrmBalanzas : Form
    {
        public FrmBalanzas()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }

        private void FrmBalanzas_Load(object sender, EventArgs e)
        {
            Tipo = this.Text.Split()[0];
            Inicio();
            TxtSerialNumber.Text = Program.SerialPC;
            TxtHostName.Text = Program.HostName;

            puertosDisponibles();
        }
        private void puertosDisponibles()
        {
            foreach (string puertoDis in System.IO.Ports.SerialPort.GetPortNames())
            {
                CmbNombre1.Items.Add(puertoDis);
                CmbNombre2.Items.Add(puertoDis);
                CmbNombre3.Items.Add(puertoDis);
                CmbNombre4.Items.Add(puertoDis);
                CmbNombre5.Items.Add(puertoDis);
                CmbNombre6.Items.Add(puertoDis);
            }
        }

        private void limpiarObjetos()
        {
            TxtSerialNumber.Text = "";
            TxtHostName.Text = "";
        }
        private void Inicio()
        {

            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"select DISPBALANZAS_nro, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO FROM DISPBALANZAS I " +
                                  "INNER JOIN DISPOSITIVOS  D ON D.DISPOSITIVO_ID = I.DISPOSITIVO_ID " +
                                  "WHERE D.DISPOSITIVO_NROSERIE = '" + Program.SerialPC + "' " +
                                  "AND D.DISPOSITIVO_NOMBRE = '" + Program.HostName + "'";
            //"AND I.DISPIMPRESORA_ESTADO = 'ON'";
            dt = M.lisquery(ssql);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 1)
                    {

                        if (dt.Rows[i][2].ToString() == "COM (RS232)")
                        {
                            CmbNombre1.Text = dt.Rows[i][1].ToString();
                            CmbTipo1.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r1.Checked = true;
                            }
                            else
                            {
                                r1.Checked = false;
                            }
                            TxtPuerto1.Text = dt.Rows[i][4].ToString();
                        }
                        else
                        {
                            TxtDesc1.Text = dt.Rows[i][1].ToString();
                            CmbTipo1.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r1.Checked = true;
                            }
                            else
                            {
                                r1.Checked = false;
                            }
                            TxtPuerto1.Text = dt.Rows[i][4].ToString();
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 2)
                    {
                        if (dt.Rows[i][2].ToString() == "COM (RS232)")
                        {
                            CmbNombre2.Text = dt.Rows[i][1].ToString();
                            CmbTipo2.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r2.Checked = true;
                            }
                            else
                            {
                                r2.Checked = false;
                            }
                            TxtPuerto2.Text = dt.Rows[i][4].ToString();
                        }
                        else
                        {
                            TxtDesc2.Text = dt.Rows[i][1].ToString();
                            CmbTipo2.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r2.Checked = true;
                            }
                            else
                            {
                                r2.Checked = false;
                            }
                            TxtPuerto2.Text = dt.Rows[i][4].ToString();
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 3)
                    {
                        if (dt.Rows[i][2].ToString() == "COM (RS232)")
                        {
                            CmbNombre3.Text = dt.Rows[i][1].ToString();
                            CmbTipo3.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r3.Checked = true;
                            }
                            else
                            {
                                r3.Checked = false;
                            }
                            TxtPuerto3.Text = dt.Rows[i][4].ToString();
                        }
                        else
                        {
                            TxtDesc3.Text = dt.Rows[i][1].ToString();
                            CmbTipo3.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r3.Checked = true;
                            }
                            else
                            {
                                r3.Checked = false;
                            }
                            TxtPuerto3.Text = dt.Rows[i][4].ToString();
                        }

                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 4)
                    {
                        if (dt.Rows[i][2].ToString() == "COM (RS232)")
                        {
                            CmbNombre4.Text = dt.Rows[i][1].ToString();
                            CmbTipo4.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r4.Checked = true;
                            }
                            else
                            {
                                r4.Checked = false;
                            }
                            TxtPuerto4.Text = dt.Rows[i][4].ToString();
                        }
                        else
                        {
                            TxtDesc4.Text = dt.Rows[i][1].ToString();
                            CmbTipo4.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r4.Checked = true;
                            }
                            else
                            {
                                r4.Checked = false;
                            }
                            TxtPuerto4.Text = dt.Rows[i][4].ToString();
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 5)
                    {

                        if (dt.Rows[i][2].ToString() == "COM (RS232)")
                        {
                            CmbNombre5.Text = dt.Rows[i][1].ToString();
                            CmbTipo5.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r5.Checked = true;
                            }
                            else
                            {
                                r5.Checked = false;
                            }
                            TxtPuerto5.Text = dt.Rows[i][4].ToString();
                        }
                        else
                        {
                            TxtDesc5.Text = dt.Rows[i][1].ToString();
                            CmbTipo5.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r5.Checked = true;
                            }
                            else
                            {
                                r5.Checked = false;
                            }
                            TxtPuerto5.Text = dt.Rows[i][4].ToString();
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 6)
                    {
                        if (dt.Rows[i][2].ToString() == "COM (RS232)")
                        {
                            CmbNombre6.Text = dt.Rows[i][1].ToString();
                            CmbTipo6.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r6.Checked = true;
                            }
                            else
                            {
                                r6.Checked = false;
                            }
                            TxtPuerto6.Text = dt.Rows[i][4].ToString();
                        }
                        else
                        {
                            TxtDesc6.Text = dt.Rows[i][1].ToString();
                            CmbTipo6.SelectedItem = dt.Rows[i][2].ToString();
                            if (dt.Rows[i][3].ToString() == "ON")
                            {
                                r6.Checked = true;
                            }
                            else
                            {
                                r6.Checked = false;
                            }
                            TxtPuerto6.Text = dt.Rows[i][4].ToString();
                        }
                    }

                }
            }
        }


        //funcion que se encarga de imprimir


        private bool valido()
        {
            if (TxtSerialNumber.Text == "")
            {
                MessageBox.Show("El Campo Nombre NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtSerialNumber.Focus();
                return false;
            }

            if (TxtHostName.Text == "")
            {
                MessageBox.Show("El Campo  NO puede estar Vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtHostName.Focus();
                return false;
            }
            return true;
        }
        private void Abm()
        {
            try
            {
                string Tipodispositivo;

                //if (RPc.Checked)
                //{
                //    Tipodispositivo = "PC";
                //}
                //else
                //{
                //    Tipodispositivo = "PDA";
                //}
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                string ssql = @"SELECT * " +
                                " FROM DISPOSITIVOS " +
                                " WHERE DISPOSITIVO_NROSERIE = '" + TxtSerialNumber.Text + "' " +
                                " AND DISPOSITIVO_NOMBRE= '" + TxtHostName.Text + "'";
                dt = M.lisquery(ssql);

                //if (dt.Rows.Count==0)
                //{
                //    M.Ejecutarquery("INSERT [LOSCALVOSDB].[dbo].[DISPOSITIVOS]  " +
                //    "(DISPOSITIVO_TIPO, DISPOSITIVO_NROSERIE, DISPOSITIVO_NOMBRE,DISPOSITIVO_DEBAJA) " +
                //    "VALUES( '"+Tipodispositivo+"','"+TxtSerialNumber.Text+"','"+TxtHostName.Text+"','N')");
                //}

                ssql = @"SELECT DISPOSITIVO_ID " +
                         "FROM [DISPOSITIVOS] " +
                         "WHERE DISPOSITIVO_NROSERIE ='" + TxtSerialNumber.Text + "' " +
                         "AND DISPOSITIVO_NOMBRE='" + TxtHostName.Text + "'";
                dt = M.lisquery(ssql);

                if (dt.Rows.Count == 1)
                {
                    int DispositivoID = Convert.ToInt32(dt.Rows[0][0].ToString());

                    M.Ejecutarquery("DELETE [DISPBALANZAS]  " +
                    "WHERE DISPOSITIVO_ID= " + DispositivoID);

                    if (CmbTipo1.Text != "")
                    {
                        if (CmbTipo1.Text == "COM (RS232)")
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                            "VALUES( " + DispositivoID + "," + 1 + ",'" + CmbNombre1.Text + "','" + CmbTipo1.Text + "','" + r1.Text + "')");
                        }
                        else
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO) " +
                            "VALUES( " + DispositivoID + "," + 1 + ",'" + TxtDesc1.Text + "','" + CmbTipo1.Text + "','" + r1.Text + "','" + TxtPuerto1.Text + "')");
                        }

                    }
                    if (CmbTipo2.Text != "")
                    {
                        if (CmbTipo2.Text == "COM (RS232)")
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                            "VALUES( " + DispositivoID + "," + 2 + ",'" + CmbNombre2.Text + "','" + CmbTipo2.Text + "','" + r2.Text + "')");
                        }
                        else
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO) " +
                            "VALUES( " + DispositivoID + "," + 2 + ",'" + TxtDesc2.Text + "','" + CmbTipo2.Text + "','" + r2.Text + "','" + TxtPuerto2.Text + "')");
                        }
                    }
                    if (CmbTipo3.Text != "")
                    {
                        if (CmbTipo3.Text == "COM (RS232)")
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                            "VALUES( " + DispositivoID + "," + 3 + ",'" + CmbNombre3.Text + "','" + CmbTipo3.Text + "','" + r3.Text + "')");
                        }
                        else
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO) " +
                            "VALUES( " + DispositivoID + "," + 3 + ",'" + TxtDesc3.Text + "','" + CmbTipo3.Text + "','" + r3.Text + "','" + TxtPuerto3.Text + "')");
                        }
                    }
                    if (CmbTipo4.Text != "")
                    {
                        if (CmbTipo4.Text == "COM (RS232)")
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                            "VALUES( " + DispositivoID + "," + 4 + ",'" + CmbNombre4.Text + "','" + CmbTipo4.Text + "','" + r4.Text + "')");
                        }
                        else
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO) " +
                            "VALUES( " + DispositivoID + "," + 4 + ",'" + TxtDesc4.Text + "','" + CmbTipo4.Text + "','" + r4.Text + "','" + TxtPuerto4.Text + "')");
                        }
                    }
                    if (CmbTipo5.Text != "")
                    {
                        if (CmbTipo5.Text == "COM (RS232)")
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                            "VALUES( " + DispositivoID + "," + 5 + ",'" + CmbNombre5.Text + "','" + CmbTipo5.Text + "','" + r5.Text + "')");
                        }
                        else
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO) " +
                            "VALUES( " + DispositivoID + "," + 5 + ",'" + TxtDesc5.Text + "','" + CmbTipo5.Text + "','" + r5.Text + "','" + TxtPuerto5.Text + "')");
                        }
                    }
                    if (CmbTipo6.Text != "")
                    {
                        if (CmbTipo6.Text == "COM (RS232)")
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                            "VALUES( " + DispositivoID + "," + 6 + ",'" + CmbNombre6.Text + "','" + CmbTipo6.Text + "','" + r6.Text + "')");
                        }
                        else
                        {
                            M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                            "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO,DISPBALANZAS_PUERTO) " +
                            "VALUES( " + DispositivoID + "," + 6 + ",'" + TxtDesc6.Text + "','" + CmbTipo6.Text + "','" + r6.Text + "','" + TxtPuerto6.Text + "')");
                        }
                    }

                    ssql = @"SELECT DISPBALANZAS_NOMBRE,DISPBALANZAS_PUERTO " +
                        "FROM [DISPBALANZAS] " +
                        "WHERE DISPOSITIVO_ID=" + DispositivoID +
                        " AND DISPBALANZAS_ESTADO='ON'";
                    dt = M.lisquery(ssql);

                    if (dt.Rows.Count == 1)
                    {
                        Program.BALANZA = dt.Rows[0][0].ToString();
                        Program.BALANZAPUERTO = dt.Rows[0][1].ToString();
                        MessageBox.Show("Los Datos se Guardaron Correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("NO Hay Balanzas configuradas para este Dispositivo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Error al Intentar Modificar, consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Confirma que desea Modificar El Registro?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                if (valido() == true)
                {
                    Abm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbNombre2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                r1.Text = "ON";
            }
            else
            {
                r1.Text = "OFF";
            }
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {

            if (r2.Checked)
            {
                r2.Text = "ON";
            }
            else
            {
                r2.Text = "OFF";
            }
        }

        private void BtnPrint1_Click(object sender, EventArgs e)
        {

            if (CmbTipo1.Text == "COM (RS232)")
            {


                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Test = "SI",
                    BalTest = CmbNombre1.Text

                };

                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FrmPesadaIP _FrmPesada = new FrmPesadaIP
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.Ip = TxtDesc1.Text;
                _FrmPesada.Puerto = TxtPuerto1.Text;
                _FrmPesada.Test = "Si";
                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            if (CmbTipo2.Text == "COM (RS232)")
            {

                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Test = "SI",
                    BalTest = CmbNombre2.Text

                };

                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FrmPesadaIP _FrmPesada = new FrmPesadaIP
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.Ip = TxtDesc2.Text;
                _FrmPesada.Puerto = TxtPuerto2.Text;
                _FrmPesada.Test = "Si";
                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CmbTipo1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbTipo1.Text == "COM (RS232)")
            {
                CmbNombre1.Visible = true;
                TxtDesc1.Visible = false;
            }
            else
            {
                CmbNombre1.Visible = false;
                TxtDesc1.Visible = true;
            }
        }

        private void CmbTipo2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbTipo2.Text == "COM (RS232)")
            {
                CmbNombre2.Visible = true;
                TxtDesc2.Visible = false;
            }
            else
            {
                CmbNombre2.Visible = false;
                TxtDesc2.Visible = true;
            }
        }

        private void CmbTipo3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbTipo3.Text == "COM (RS232)")
            {
                CmbNombre3.Visible = true;
                TxtDesc3.Visible = false;
            }
            else
            {
                CmbNombre3.Visible = false;
                TxtDesc3.Visible = true;
            }
        }

        private void CmbTipo4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbTipo4.Text == "COM (RS232)")
            {
                CmbNombre4.Visible = true;
                TxtDesc4.Visible = false;
            }
            else
            {
                CmbNombre4.Visible = false;
                TxtDesc4.Visible = true;
            }
        }

        private void CmbTipo5_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbTipo5.Text == "COM (RS232)")
            {
                CmbNombre5.Visible = true;
                TxtDesc5.Visible = false;
            }
            else
            {
                CmbNombre5.Visible = false;
                TxtDesc5.Visible = true;
            }
        }

        private void CmbTipo6_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbTipo6.Text == "COM (RS232)")
            {
                CmbNombre6.Visible = true;
                TxtDesc6.Visible = false;
            }
            else
            {
                CmbNombre6.Visible = false;
                TxtDesc6.Visible = true;
            }
        }

        private void r3_CheckedChanged(object sender, EventArgs e)
        {
            if (r3.Checked)
            {
                r3.Text = "ON";
            }
            else
            {
                r3.Text = "OFF";
            }
        }

        private void r4_CheckedChanged(object sender, EventArgs e)
        {
            if (r4.Checked)
            {
                r4.Text = "ON";
            }
            else
            {
                r4.Text = "OFF";
            }
        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {
            if (r5.Checked)
            {
                r5.Text = "ON";
            }
            else
            {
                r5.Text = "OFF";
            }
        }

        private void BtnPrint3_Click(object sender, EventArgs e)
        {
            if (CmbTipo3.Text == "COM (RS232)")
            {

                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Test = "SI",
                    BalTest = CmbNombre3.Text

                };

                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FrmPesadaIP _FrmPesada = new FrmPesadaIP
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.Ip = TxtDesc3.Text;
                _FrmPesada.Puerto = TxtPuerto3.Text;
                _FrmPesada.Test = "Si";
                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrint4_Click(object sender, EventArgs e)
        {
            if (CmbTipo4.Text == "COM (RS232)")
            {

                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Test = "SI",
                    BalTest = CmbNombre4.Text

                };

                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FrmPesadaIP _FrmPesada = new FrmPesadaIP
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.Ip = TxtDesc4.Text;
                _FrmPesada.Puerto = TxtPuerto4.Text;
                _FrmPesada.Test = "Si";
                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrint5_Click(object sender, EventArgs e)
        {
            if (CmbTipo5.Text == "COM (RS232)")
            {

                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Test = "SI",
                    BalTest = CmbNombre5.Text

                };

                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FrmPesadaIP _FrmPesada = new FrmPesadaIP
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.Ip = TxtDesc5.Text;
                _FrmPesada.Puerto = TxtPuerto5.Text;
                _FrmPesada.Test = "Si";
                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrint6_Click(object sender, EventArgs e)
        {
            if (CmbTipo6.Text == "COM (RS232)")
            {

                FrmPesada _FrmPesada = new FrmPesada
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Test = "SI",
                    BalTest = CmbNombre6.Text

                };

                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FrmPesadaIP _FrmPesada = new FrmPesadaIP
                {
                    StartPosition = FormStartPosition.CenterScreen,

                };
                _FrmPesada.Ip = TxtDesc6.Text;
                _FrmPesada.Puerto = TxtPuerto6.Text;
                _FrmPesada.Test = "Si";
                _FrmPesada.ShowDialog();
                if (_FrmPesada.Pesotext != null)
                {
                    MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

    
 

