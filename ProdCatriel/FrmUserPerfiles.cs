using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using logica;

namespace TRAZAAR
{
    public partial class FrmUserPerfiles : Form
    {
        User US = new User();
        ClsTipo C = new ClsTipo();
        public FrmUserPerfiles()
        {
            InitializeComponent();
        }
        public string accion = "";
        private void FrmUser_Load(object sender, EventArgs e)
        {

            this.Text = "Perfil De Usuario";
            //inicializar();
            LlenarGrid("Perfil","");
            Dgprincipal.ClearSelection();
        }

        private void LlenarGrid(string Combo, string Filtro)
        {

            Dgprincipal.DataSource = null; ;
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", Combo));
                lst.Add(new ClsParametros("@filtro", Filtro));
                //lst.Add(new ClsParametros("@hasta", dtHasta.Value.ToString("yyyyMMdd")));
                //lst.Add(new ClsParametros("@tipo", radioButton1.Checked));
                dt = M.Listado("sp_CargaCombos", lst);
                //Dgprincipal.DataSource = dt;
                //DgIngreso.AutoResizeColumns(Fill);
                Dgprincipal.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Dgprincipal.Rows.Add(dt.Rows[i][0]);
                    Dgprincipal.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    Dgprincipal.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    Dgprincipal.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    if (dt.Rows[i][3].ToString() == "N")
                    {
                        Dgprincipal.Rows[i].Cells[3].Value = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void inicializar()
        {

            LlenarGrid("PERFIL", "");
            Dgprincipal.ClearSelection();
        }

        private void mnuevo_Click(object sender, EventArgs e)
        {
            FrmAddUserPerfil _FrmAddUserPerfil = new FrmAddUserPerfil();
            _FrmAddUserPerfil.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddUserPerfil.Tipo = "NUEVO";
            _FrmAddUserPerfil.id = 0;
            _FrmAddUserPerfil.ShowDialog();
            inicializar();
        }

        private void FrmUser_Activated(object sender, EventArgs e)
        {
            
        }

        private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        {
            FrmAddUserPerfil _FrmAddUserPerfil = new FrmAddUserPerfil();
            _FrmAddUserPerfil.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddUserPerfil.Tipo = "CONSULTAR";
            _FrmAddUserPerfil.id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
            _FrmAddUserPerfil.Codigo = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
            _FrmAddUserPerfil.Nombre=Dgprincipal.CurrentRow.Cells[2].Value.ToString();

            bool acti = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells[3].Value);
            if (acti==true)
            {
                _FrmAddUserPerfil.Activo = "N";
            }
            else
            {
                _FrmAddUserPerfil.Activo = "S";
            }
            _FrmAddUserPerfil.ShowDialog();
            inicializar();
        }

        private void mmodificar_Click(object sender, EventArgs e)
        {

            if (Dgprincipal.SelectedRows.Count > 0)
            {
                FrmAddUserPerfil _FrmAddUserPerfil = new FrmAddUserPerfil();
                _FrmAddUserPerfil.StartPosition = FormStartPosition.CenterScreen;
                _FrmAddUserPerfil.Tipo = "MODIFICAR";
                _FrmAddUserPerfil.id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                _FrmAddUserPerfil.Codigo = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                _FrmAddUserPerfil.Nombre = Dgprincipal.CurrentRow.Cells[2].Value.ToString();

                bool acti = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells[3].Value);
                if (acti == true)
                {
                    _FrmAddUserPerfil.Activo = "N";
                }
                else
                {
                    _FrmAddUserPerfil.Activo = "S";
                }
                _FrmAddUserPerfil.ShowDialog();
                inicializar();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "TRAZAAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            inicializar();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meliminar_Click(object sender, EventArgs e)
        {
            if (Dgprincipal.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                string Nom = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show("¿Confirma que desea Desactivar el Perfil  " + (char)13 + Nom + "? ", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ClsManejador M = new ClsManejador();
                    M.Ejecutarquery(@"update PERFIL set PERFIL_DEBAJA= 'S' where PERFIL_ID=" + id);
                }

            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "TRAZAAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGrid("PERFIL", "");
        }

        private void Dgprincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgprincipal.SelectedRows.Count > 0)
            {
                FrmAddUserPerfil _FrmAddUserPerfil = new FrmAddUserPerfil();
                _FrmAddUserPerfil.StartPosition = FormStartPosition.CenterScreen;
                _FrmAddUserPerfil.Tipo = "CONSULTAR";
                _FrmAddUserPerfil.id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                _FrmAddUserPerfil.Codigo = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                _FrmAddUserPerfil.Nombre = Dgprincipal.CurrentRow.Cells[2].Value.ToString();

                bool acti = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells[3].Value);
                if (acti == true)
                {
                    _FrmAddUserPerfil.Activo = "N";
                }
                else
                {
                    _FrmAddUserPerfil.Activo = "S";
                }
                _FrmAddUserPerfil.ShowDialog();
                inicializar();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "TRAZAAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            inicializar();
        }
    }
}
        

        

        
 
