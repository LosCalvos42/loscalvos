using Datos;
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
    public partial class FrmLoteDetalle : Form
    {
        public FrmLoteDetalle()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public string Tipo { get; set; }
        public string Activo { get; set; }
        public string Listado { get; set; }
        public DataTable DtExcluidos { get; set; }

        private void FrmAddGrupoFamilia_Load(object sender, EventArgs e)
        {

            //Tipo = this.Text;
            Tipo = this.Text.Split()[0];
            //id = Convert.ToInt32(this.Text.Split()[2]);
            
            LblTitulo.Text = "Piezas Excluidas";
            Dgprincipal.Rows.Clear();
            Dgprincipal.DataSource = DtExcluidos;
            ColorGrid();
        }
        private void ColorGrid()
        {
            if (Dgprincipal.Rows.Count > 0)
            {

                for (int i = 0; i < Dgprincipal.Rows.Count; i++)
                {
                    if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "Codigo Repetido")
                    {
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                    }
                    if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "Error en campo Peso (KG)")
                    {
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "Fuera de Categoria")
                    {
                        Dgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                }
                Dgprincipal.ReadOnly = true;
                Dgprincipal.ClearSelection();
            }
        }
        

        private bool valido()
        {

           

            return true;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }

        private void Dgprincipal_Sorted(object sender, EventArgs e)
        {
            ColorGrid();
        }
    }
}

    
 

