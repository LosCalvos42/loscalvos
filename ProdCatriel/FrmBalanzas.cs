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
            string ssql = @"select DISPBALANZAS_nro, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO FROM DISPBALANZAS I " +
                                  "INNER JOIN DISPOSITIVOS  D ON D.DISPOSITIVO_ID = I.DISPOSITIVO_ID " +
                                  "WHERE D.DISPOSITIVO_NROSERIE = '" + Program.SerialPC + "' " +
                                  "AND D.DISPOSITIVO_NOMBRE = '" + Program.HostName + "'";
                                  //"AND I.DISPIMPRESORA_ESTADO = 'ON'";
            dt = M.lisquery(ssql);

            if (dt.Rows.Count >0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 1)
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
                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 2)
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
                string ssql = @"SELECT * "+
                                " FROM DISPOSITIVOS "+
                                " WHERE DISPOSITIVO_NROSERIE = '"+TxtSerialNumber.Text+ "' " +
                                " AND DISPOSITIVO_NOMBRE= '"+TxtHostName.Text+"'";
                dt = M.lisquery(ssql);

                //if (dt.Rows.Count==0)
                //{
                //    M.Ejecutarquery("INSERT [LOSCALVOSDB].[dbo].[DISPOSITIVOS]  " +
                //    "(DISPOSITIVO_TIPO, DISPOSITIVO_NROSERIE, DISPOSITIVO_NOMBRE,DISPOSITIVO_DEBAJA) " +
                //    "VALUES( '"+Tipodispositivo+"','"+TxtSerialNumber.Text+"','"+TxtHostName.Text+"','N')");
                //}

               ssql = @"SELECT DISPOSITIVO_ID "+
                        "FROM [DISPOSITIVOS] " +
                        "WHERE DISPOSITIVO_NROSERIE ='" + TxtSerialNumber.Text + "' " +
                        "AND DISPOSITIVO_NOMBRE='" + TxtHostName.Text+"'";
                dt = M.lisquery(ssql);

                if (dt.Rows.Count == 1)
                {
                    int DispositivoID = Convert.ToInt32(dt.Rows[0][0].ToString());

                    M.Ejecutarquery("DELETE [DISPBALANZAS]  " +
                    "WHERE DISPOSITIVO_ID= " + DispositivoID);

                    if (CmbNombre1.Text != "")
                    {
                        M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                        "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                        "VALUES( " + DispositivoID + "," + 1 + ",'" + CmbNombre1.Text + "','" + CmbTipo1.Text + "','" + r1.Text + "')");
                    }
                    if (CmbNombre2.Text != "")
                    {
                        M.Ejecutarquery("INSERT [DISPBALANZAS]  " +
                        "(DISPOSITIVO_ID, DISPBALANZAS_NRO, DISPBALANZAS_NOMBRE,DISPBALANZAS_TIPO,DISPBALANZAS_ESTADO) " +
                        "VALUES( " + DispositivoID + "," + 2 + ",'" + CmbNombre2.Text + "','" + CmbTipo2.Text + "','" + r2.Text + "')");
                    }
                    
                    ssql = @"SELECT DISPBALANZAS_NOMBRE " +
                        "FROM [DISPBALANZAS] " +
                        "WHERE DISPOSITIVO_ID=" + DispositivoID +
                        " AND DISPBALANZAS_ESTADO='ON'";
                    dt = M.lisquery(ssql);

                    if (dt.Rows.Count == 1)
                    {
                        Program.BALANZA = dt.Rows[0][0].ToString();
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
            FrmPesada _FrmPesada = new FrmPesada
            {
                StartPosition = FormStartPosition.CenterScreen,

            };
            _FrmPesada.ShowDialog();
            if (_FrmPesada.Pesotext !=null)
            {
                MessageBox.Show("Peso detectado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Intentar obtener Peso. Probar otro puerto o consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            FrmPesada _FrmPesada = new FrmPesada
            {
                StartPosition = FormStartPosition.CenterScreen,

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

        private void CmbTipo1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CmbTipo1.Text== "COM (RS232)")
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
    }
}

    
 

