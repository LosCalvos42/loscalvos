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

using System.IO;
using System.Net;
using System.Net.Sockets;


namespace LOSCALVOS
{
    public partial class FrmPesadaIP : Form
    {
        
        public static int nropro;
        public static int idtipo;
        public static int flag;
        public static string estado_proc;
        public int ulnumerolote;
        public string Pesotext { get; set; }
        public decimal Pesodecimal { get; set; }
        public string Test{ get; set; }

        public string Ip { get; set; }
        public string Puerto { get; set; }
        //string es_nuevo; 
        //Clsproceso P = new Clsproceso();
        //ClsProcesoBatea b = new ClsProcesoBatea();
        //ClsTipoJamon C = new ClsTipoJamon();
        //ClsSJamones S = new ClsSJamones();
        public FrmPesadaIP()
        {
            InitializeComponent();
        }

        private void FrmSelecJamon_Load(object sender, EventArgs e)
        {
            this.Show();
            Control.CheckForIllegalCrossThreadCalls = true;
            lblespe.Visible = true;
            inicontroles();
            try 
            { 
                if (Test == "Si")
                {
                    pesarip(Ip, Convert.ToInt32(Puerto));
                    this.Close();
                }
                else { 
                    pesarip(Program.BALANZA, Convert.ToInt32(Program.BALANZAPUERTO));
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      
        public  void pesarip(string host, int port)
        {
            try
            {
                this.Refresh();
                int timeout = 5000;
                using (var _client = new TcpClient(host, port))

                using (var _netStream = _client.GetStream())
                {
                    _netStream.ReadTimeout = timeout;
                    byte[] recvData = new byte[256];
                    int bytes = _netStream.Read(recvData, 0, recvData.Length);
                    textBox1.Text = System.Text.Encoding.ASCII.GetString(recvData, 0, bytes);
                    string datorx = "";
                    datorx = System.Text.Encoding.ASCII.GetString(recvData, 0, bytes); ;
                    datorx = RemoveSpecialCharacters(datorx);
                    string[] words = datorx.Split('k');
                    decimal peso = 0;
                    peso = Convert.ToDecimal(words[0].ToString().Replace(".", ","));
                    lblKg.Text = Convert.ToString(peso.ToString().Replace(",", "."));
                    Pesotext = lblKg.Text;
                    Pesodecimal = peso;
                    lblKg.Text = lblKg.Text + "  KG.";
                    PicGIF.Visible = false;
                    lblespe.Visible = false;
                    lblKg.Visible = true;
                    _client.Close();
                    _netStream.Close();

                    //this.Close();
                };
                this.Refresh();
                System.Threading.Thread.Sleep(500);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            /// </summary>
        private void inicontroles()
        {
            this.Update();
            //serialPort1.Close();
            //serialPort1.Dispose();
            //serialPort1.PortName = "COM7";

            //if (serialPort1.IsOpen == true)
            //{
            //    serialPort1.Close();
            //}
        }
        
        private void Pesar()
        {
            serialPort1.PortName = Program.BALANZA;
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
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

                Pesar();
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                 lblespe.Visible = true;
        }
        //////////////////private void puertosDisponibles()
        ////////////////{
        ////////////////    foreach (string puertoDis in System.IO.Ports.SerialPort.GetPortNames())
        ////////////////    {
        ////////////////        cmbPuertos.Items.Add(puertoDis);
                
        ////////////////    }
        ////////////////}
        
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
                Pesotext = lblKg.Text;
                     Pesodecimal = peso;
                lblKg.Text = lblKg.Text + "  KG.";
                PicGIF.Visible = false;
                lblespe.Visible = false;
                lblKg.Visible = true;
                
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
            }
        }

        private string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, @"[^0-9A-Za-z.]", "", RegexOptions.None);
        }
        private void FrmSelecJamon_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Program._FrmSelecJamon = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos _FrmUser = new FrmProductos();
            _FrmUser.Parent = this.MdiParent;
            _FrmUser.Dock = DockStyle.Fill;
            
            _FrmUser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal peso = Convert.ToDecimal(textBox1.Text.ToString().Replace(".", ","));
            //Pesodecimal = peso;
            this.Close();
        }
    }
}
