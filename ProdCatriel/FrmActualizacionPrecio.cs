using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmActualizacionPrecio : Form
    {
        public FrmActualizacionPrecio()
        {
            InitializeComponent();
        }
      
        public string Filtro { get; set; }
       
        public string accion = "";
       
       
        private void FrmListados_Load(object sender, EventArgs e)
        {
            Filtro = "";
            this.Text = "SP_ConsultaDeStock";  // nombre del SP
            Dgprincipal.CellClick += Dgprincipal_CellClick;
            Dgprincipal.CellValidating += Dgprincipal_CellValidating;
            Dgprincipal.CellEndEdit += Dgprincipal_CellEndEdit;
            LLENAR();

        }
        private void Dgprincipal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Si la columna editada es la de precio manual (columna 6)
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                var cell = Dgprincipal.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (decimal.TryParse(cell.Value?.ToString(), out decimal precioManual))
                {
                    // Formatear el número con separadores de miles y coma decimal
                    cell.Value = precioManual.ToString("N2", new System.Globalization.CultureInfo("es-AR"));

                    // Cambiar color a naranja
                    cell.Style.BackColor = Color.FromArgb(244, 154, 0); ;
                    cell.Style.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cell.Value = ""; // o podés dejar el valor anterior si querés
                }
            }
        }

        private void Dgprincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 3)
                {
                    var row = Dgprincipal.Rows[e.RowIndex];
                    //object valorUltimoPrecio = row.Cells[2].Value;
                    object valorUltimoPrecio = e.ColumnIndex == 5 ? row.Cells[4].Value : row.Cells[2].Value;
                    if (valorUltimoPrecio != DBNull.Value && decimal.TryParse(valorUltimoPrecio.ToString(), out decimal precio))
                    {
                        row.Cells[6].Value = precio.ToString("N2");
                        Color color = e.ColumnIndex == 5 ? Color.FromArgb(94, 218, 95) : Color.FromArgb(239, 54, 39);
                        row.Cells[6].Style.BackColor = color;
                        row.Cells[6].Style.ForeColor = Color.Black;
                    }
                }
            }
           
        }
        private void Permisos()
        {
            if (Program.perfil == 5)
            {
                //mnuevo.Enabled = false;
                //mmodificar.Enabled = false;
                //meliminar.Enabled = false;
            }
        }
        
        private void LLENAR()
        {
            Dgprincipal.DataSource = null;
            progressBar.Visible = true;
            pictureBox1.Visible = true;
            LblPorcentaje.Visible = true;
            System.Threading.Thread thread =
            new System.Threading.Thread(new System.Threading.ThreadStart(loadTable));
            thread.Start();
            progressBar.Style = ProgressBarStyle.Marquee;
        }


        private void loadTable()
        {
            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@Tipo",1));
                setDataSource(dt = M.Listado("SP_ActualizacionDePrecios", lst));    //SP del reporte
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        internal delegate void SetDataSourceDelegate(DataTable table);
        private void setDataSource(DataTable table)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), table);
            }
            else
            {
                progressBar.Visible = false;
                pictureBox1.Visible = false;
                LblPorcentaje.Visible = false;
                Dgprincipal.DataSource = table;

                AgregarBotones();

                EstadoGrilla();
                Dgprincipal.ClearSelection();
            }
        }


        private void AgregarBotones()
        {
            for (int i = Dgprincipal.Columns.Count - 1; i >= 0; i--)
            {
                if (Dgprincipal.Columns[i] is DataGridViewButtonColumn &&
                    (Dgprincipal.Columns[i].Name == "btnPasarUltCompra" || Dgprincipal.Columns[i].Name == "btnPasarUltPrecio"))
                {
                    Dgprincipal.Columns.RemoveAt(i);
                }
            }

            DataGridViewButtonColumn btnCompra = new DataGridViewButtonColumn
            {
                Name = "btnPasarUltCompra",
                HeaderText = "PASAR PRECIO",
                Text = "---->",
                UseColumnTextForButtonValue = true
            };
            btnCompra.DefaultCellStyle.BackColor = Color.Red;
            btnCompra.DefaultCellStyle.ForeColor = Color.White;
            Dgprincipal.Columns.Insert(3, btnCompra); 
            DataGridViewButtonColumn btnPrecio = new DataGridViewButtonColumn
            {
                Name = "btnPasarUltPrecio",
                HeaderText = "PASAR PRECIO",
                Text = "---->",
                UseColumnTextForButtonValue = true
            };
            btnPrecio.DefaultCellStyle.BackColor = Color.Green;
            btnPrecio.DefaultCellStyle.ForeColor = Color.White;
            Dgprincipal.Columns.Insert(5, btnPrecio);
        }
        private void EstadoGrilla()
        {

            Dgprincipal.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgprincipal.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgprincipal.Columns[2].DefaultCellStyle.Format = "N2";
            Dgprincipal.Columns[4].DefaultCellStyle.Format = "N2";
            Dgprincipal.Columns[6].DefaultCellStyle.Format = "N2";
            using (Font font = new Font(
                    Dgprincipal.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Underline))
            {
                Dgprincipal.Columns[7].DefaultCellStyle.Font = font;
                Dgprincipal.Columns[7].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);
            }

            foreach (DataGridViewColumn col in Dgprincipal.Columns)
            {
                col.ReadOnly = true;
            }
            Dgprincipal.Columns[6].ReadOnly = false;

        }

        private void Dgprincipal_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == 4)
            //{
            //    if (!decimal.TryParse(e.FormattedValue.ToString(), out _))
            //    {
            //        MessageBox.Show("Ingrese un valor numérico válido para el precio.");
            //        e.Cancel = true;
            //    }
            //}
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgprincipal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.ColumnIndex == 7)
            {
                FrmHistorialDePrecios _FrmHistorialDePrecios = new FrmHistorialDePrecios
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    producto =int.Parse(Dgprincipal.Rows[e.RowIndex].Cells[0].Value.ToString())
                };

                _FrmHistorialDePrecios.ShowDialog();
            }
        }

        private Cursor curAnterior = null;
        private void Dgprincipal_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                    this.Dgprincipal.Cursor = Cursors.Hand;
            }
            else
            {
                this.Dgprincipal.Cursor = curAnterior;
            }
            
        }

        private void mimprimir_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            for (int i = 0; i < Dgprincipal.Rows.Count; i++)
            {
                if (Dgprincipal.Rows[i].Cells[6].Value.ToString() == "")
                {
                    MessageBox.Show("hay datos de precios sin valores","REVISAR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    bandera = true;
                    return;
                }
            }

            if (!bandera)
            {
                if (MessageBox.Show("¿Confirma que desea Modificar El Registro?", "Modificar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClsManejador M = new ClsManejador();

                    List<ClsParametros> lst = new List<ClsParametros>();
                    try
                    {
                        for (int i = 0; i <= Dgprincipal.Rows.Count - 1; i++)
                        {
                            lst.Clear();
                            lst.Add(new ClsParametros("@Tipo", 2));
                            lst.Add(new ClsParametros("@prod", Convert.ToInt32(Dgprincipal.Rows[i].Cells[0].Value.ToString())));
                            lst.Add(new ClsParametros("@precio", Convert.ToDouble(Dgprincipal.Rows[i].Cells[6].Value.ToString())));
                            M.EjecutarSP("SP_ActualizacionDePrecios", ref lst);
                        }
                        MessageBox.Show("Precios actualizados correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LLENAR();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }

        }
    }
}
