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
    public partial class FrmAddDispositivo : Form
    {
        public FrmAddDispositivo()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }

        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {
            Tipo = this.Text.Split()[0];
            
            TxtSerialNumber.Text = Program.SerialPC;
            TxtHostName.Text = Program.HostName;
            Inicio();
        }

        
        private void limpiarObjetos()
        {
            TxtSerialNumber.Text = "";
            TxtHostName.Text = "";
        }
        private void Inicio()
        {
            Cargarcombo("SECTOR", CmbSector, "");

            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"SELECT DISPOSITIVO_SECTOR" +
                            " FROM [DISPOSITIVOS] " +
                            " WHERE DISPOSITIVO_NROSERIE = '" + TxtSerialNumber.Text + "' " +
                            " AND DISPOSITIVO_NOMBRE= '" + TxtHostName.Text + "'";
            dt = M.lisquery(ssql);

            if (dt.Rows.Count > 0)
            {
                CmbSector.SelectedValue = dt.Rows[0][0].ToString();
            }
        }
        private void Cargarcombo(string combo, ComboBox _combo, string filtro)
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@combo", combo));
                lst.Add(new ClsParametros("@filtro", filtro));
                dt = M.Listado("sp_CargaCombos", lst);
                _combo.DataSource = dt;
                _combo.DisplayMember = "NOMBRE";
                _combo.ValueMember = "CODIGO";
                DataRow topItem = dt.NewRow();
                topItem[1] = 1;
                topItem[2] = "-Select-";

                dt.Rows.InsertAt(topItem, 0);
                _combo.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                throw ex;
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
            if (CmbSector.SelectedIndex == 0)
            {
                MessageBox.Show("Hay Datos Sin completar (Sector)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbSector.Focus();
                return false;
            }
            return true;
        }
        private void Abm()
        {
            try
            {
                string Tipodispositivo;

                if (RPc.Checked)
                {
                    Tipodispositivo = "PC";
                }
                else
                {
                    Tipodispositivo = "PDA";
                }
                ClsManejador M = new ClsManejador();
                DataTable dt = new DataTable();
                string ssql = @"SELECT * "+
                                " FROM [DISPOSITIVOS] "+
                                " WHERE DISPOSITIVO_NROSERIE = '"+TxtSerialNumber.Text+ "' " +
                                " AND DISPOSITIVO_NOMBRE= '"+TxtHostName.Text+"'";
                dt = M.lisquery(ssql);

                if (dt.Rows.Count>0)
                {
                    M.Ejecutarquery("UPDATE [DISPOSITIVOS]  " +
                    "SET DISPOSITIVO_TIPO= '" + Tipodispositivo + "', DISPOSITIVO_NROSERIE ='" + TxtSerialNumber.Text + "', DISPOSITIVO_NOMBRE='" + TxtHostName.Text + "',DISPOSITIVO_DEBAJA='N',DISPOSITIVO_SECTOR='" + CmbSector.SelectedValue + "' WHERE DISPOSITIVO_ID="+ dt.Rows[0][0].ToString());
                }

                else
                {
                    M.Ejecutarquery("INSERT [DISPOSITIVOS]  " +
                    "(DISPOSITIVO_TIPO, DISPOSITIVO_NROSERIE, DISPOSITIVO_NOMBRE,DISPOSITIVO_DEBAJA,DISPOSITIVO_SECTOR) " +
                    "VALUES( '" + Tipodispositivo + "','" + TxtSerialNumber.Text + "','" + TxtHostName.Text + "','N','" + CmbSector.SelectedValue + "')");
                }
                MessageBox.Show("Los Datos se Guardaron Correctamente", "Dispositivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();

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
            //this.cl;
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
    }
}

    
 

