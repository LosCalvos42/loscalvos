using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        void tmr_Tick(object sender, EventArgs e)
        {
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
