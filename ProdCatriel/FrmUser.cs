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

namespace LOSCALVOS
{
    public partial class FrmUser : Form
    {
        User US = new User();
        ClsTipo C = new ClsTipo();
        public FrmUser()
        {
            InitializeComponent();
        }
        public string accion = "";
        private void FrmUser_Load(object sender, EventArgs e)
        {

            this.Text = "Usuarios";
            //inicializar();
            LlenarGrid("USER","");
            Dgprincipal.ClearSelection();
        }

        private void LlenarGrid(string Combo, string Filtro)
        {

            
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
                    Dgprincipal.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    Dgprincipal.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    Dgprincipal.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    Dgprincipal.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();

                    if (dt.Rows[i][7].ToString() == "N")
                    {
                        Dgprincipal.Rows[i].Cells[8].Value=true;
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

            LlenarGrid("USER", "");
            Dgprincipal.ClearSelection();
        }

        private void mnuevo_Click(object sender, EventArgs e)
        {
            FrmAddUser _FrmAddUser = new FrmAddUser();

            _FrmAddUser.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddUser.Tipo = "NUEVO";
            _FrmAddUser.id = 0;
            _FrmAddUser.ShowDialog();
            inicializar();
        }

        private void FrmUser_Activated(object sender, EventArgs e)
        {
            
        }

        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarGrid("user",txtBuscar.Text);
            Dgprincipal.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarGrid("User", txtBuscar.Text);
            Dgprincipal.ClearSelection();
        }

        //private void Dgprincipal_DoubleClick(object sender, EventArgs e)
        //{
        //    FrmAddUser _FrmAddUser = new FrmAddUser();
        //    _FrmAddUser.StartPosition = FormStartPosition.CenterScreen;
        //    _FrmAddUser.Tipo = "CONSULTAR";
        //    _FrmAddUser.id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
        //    _FrmAddUser.Nombre=Dgprincipal.CurrentRow.Cells[1].Value.ToString();
        //    _FrmAddUser.Apellido = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
        //    _FrmAddUser.Perfil = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[3].Value.ToString());
        //    _FrmAddUser.User = Dgprincipal.CurrentRow.Cells[5].Value.ToString();
        //    _FrmAddUser.Pass = Dgprincipal.CurrentRow.Cells[6].Value.ToString();

        //    bool acti = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells[8].Value);
        //    if (acti==true)
        //    {
        //        _FrmAddUser.Activo = "N";
        //    }
        //    else
        //    {
        //        _FrmAddUser.Activo = "S";
        //    }
        //    _FrmAddUser.ShowDialog();
        //    inicializar();
        //}

        private void mmodificar_Click(object sender, EventArgs e)
        {

            if (Dgprincipal.SelectedRows.Count > 0)
            {
                FrmAddUser _FrmAddUser = new FrmAddUser();
                _FrmAddUser.StartPosition = FormStartPosition.CenterScreen;
                _FrmAddUser.Tipo = "MODIFICAR";
                _FrmAddUser.id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
                _FrmAddUser.Nombre = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
                _FrmAddUser.Apellido = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
                _FrmAddUser.Perfil = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[3].Value.ToString());
                _FrmAddUser.User = Dgprincipal.CurrentRow.Cells[5].Value.ToString();
                _FrmAddUser.Pass = Dgprincipal.CurrentRow.Cells[6].Value.ToString();
                bool acti = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells[8].Value);
                if (acti == true)
                {
                    _FrmAddUser.Activo = "N";
                }
                else
                {
                    _FrmAddUser.Activo = "S";
                }
                _FrmAddUser.ShowDialog();
                inicializar();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string Nom = Dgprincipal.CurrentRow.Cells[5].Value.ToString();
                if (MessageBox.Show("¿Confirma que desea Desactivar al Usuario " + (char)13 + Nom + "? ", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ClsManejador M = new ClsManejador();
                    M.Ejecutarquery(@"update USR set USR_DEBAJA= 'S' where USR_ID=" + id);
                }

            }
            else
            {
                MessageBox.Show("Por Favor Seleccione Una Fila Para Operar.", "LOSCALVOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGrid("USER", "");
        }

        private void Dgprincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAddUser _FrmAddUser = new FrmAddUser();
            _FrmAddUser.StartPosition = FormStartPosition.CenterScreen;
            _FrmAddUser.Tipo = "CONSULTAR";
            _FrmAddUser.id = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[0].Value.ToString());
            _FrmAddUser.Nombre = Dgprincipal.CurrentRow.Cells[1].Value.ToString();
            _FrmAddUser.Apellido = Dgprincipal.CurrentRow.Cells[2].Value.ToString();
            _FrmAddUser.Perfil = Convert.ToInt32(Dgprincipal.CurrentRow.Cells[3].Value.ToString());
            _FrmAddUser.User = Dgprincipal.CurrentRow.Cells[5].Value.ToString();
            _FrmAddUser.Pass = Dgprincipal.CurrentRow.Cells[6].Value.ToString();

            bool acti = Convert.ToBoolean(Dgprincipal.CurrentRow.Cells[8].Value);
            if (acti == true)
            {
                _FrmAddUser.Activo = "N";
            }
            else
            {
                _FrmAddUser.Activo = "S";
            }
            _FrmAddUser.ShowDialog();
            inicializar();
        }
    }
}
        

        

        
 
