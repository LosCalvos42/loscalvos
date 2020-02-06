using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAZAAR
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer
            {
                Interval = 4500
            };
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        public String GetInfo(string Comando)
        {
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " +Comando);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            string result = proc.StandardOutput.ReadToEnd();
            return RemoveSpecialCharacters(result);
        }

        private string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, @"[^0-9A-Za-z]", "", RegexOptions.None);
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            Program.HostName = GetInfo("hostname");
            Program.SerialPC =GetInfo("wmic bios get serialnumber").Replace("SerialNumber", ""); 
            tmr.Stop();
            FrmMenu _FrmMenu = new FrmMenu();
            this.Hide();
            _FrmMenu.ShowDialog();
            //this.Close();
            System.Environment.Exit(0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
