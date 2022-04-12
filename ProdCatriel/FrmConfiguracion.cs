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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
            if (Program.perfil != 1)//administrador
            {
                MenuPermisos.Enabled = false;

            }
        }

        private void Psalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program._FrmConfiguracion = false;
            
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            //if (this.panel1.Controls.Count > 0)
            //    this.panel1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            //fh.FormBorderStyle = FormBorderStyle.None;
            //fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            fh.Parent.Controls.SetChildIndex(fh, 0);

            this.panel1.Tag = fh;
            //fh.MdiParent=this;
            fh.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmUser _FrmUser = new FrmUser();
            AbrirFormEnPanel(_FrmUser);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmUserPerfiles _FrmUserPerfiles = new FrmUserPerfiles();
            AbrirFormEnPanel(_FrmUserPerfiles);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckForIllegalCrossThreadCalls = false;
            FrmAgenda _FrmAgenda = new FrmAgenda();
            _FrmAgenda.StartPosition = FormStartPosition.CenterScreen;
            _FrmAgenda.WindowState = FormWindowState.Maximized;
            AbrirFormEnPanel(_FrmAgenda);//FrmAddRecepcionDeLotes
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            FrmAddUser _FrmAddUser = new FrmAddUser();
            _FrmAddUser.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddUser.Tipo = "CONSULTAR";
            _FrmAddUser.id = Program.IDUSER;
            _FrmAddUser.Tipo = "CAMBIOPASS";
            _FrmAddUser.ShowDialog();

        }
    }
}

