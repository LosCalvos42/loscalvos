using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSCALVOS
{
    public partial class FrmAddProcesoAutomatico : Form
    {
        public FrmAddProcesoAutomatico()
        {
            InitializeComponent();
        }

        public string CodProceso { get; set; }
        public string Lote { get; set; }
        public DateTime FechaProcesoAnterior { get; set; }
        public Int32 OT { get; set; }
        public string CodProd { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        int bandera = 0;


        private void FrmAddLote_Load(object sender, EventArgs e)
        { 
            Inicio();
        }
        private void limpiarObjetos()
        {

            LblTitulo.Text = Titulo;
            LblLote.Text = Lote;
        }
        private void Inicio()
        {
            
            limpiarObjetos();

        }

        private String[] AddSalazon()
        {
            this.Cursor = Cursors.AppStarting;
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                lst.Add(new ClsParametros("@TIPO", Tipo));
                lst.Add(new ClsParametros("@LOTE", Lote));
                lst.Add(new ClsParametros("@FECHA", DtProduccion.Value.ToString("yyyyMMdd")));
                lst.Add(new ClsParametros("@USR_ID", Program.IDUSER));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output, 18));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.ExecuteSqlTransaction("sp_AddSalazon", lst);
                msj = new string[2];
                msj[0] = lst[5].Valor.ToString();
                msj[1] = lst[4].Valor.ToString();

                while (bandera == 0)
                {
                    if (panel3.Width < 425)
                    {
                        panel3.Width = panel3.Width + 3;
                        Thread.Sleep(10);
                    }
                    else
                    {
                        bandera = 1;
                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                msj = new string[2];
                msj[1] = "0";
                msj[0] = "Hubo un Error al Guardar los Datos." + "\n" + "Mensage: " + ex.Message + "\n" + "\n" + "No se Guardo ningún Cambio.";
            }
            return msj;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.cl;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (DtProduccion.Value.Date<FechaProcesoAnterior )
            {
                MessageBox.Show("La fecha ingresada, NO puede ser inferior a la fecha del proceso anterior", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DtProduccion.Focus();
                return;
            }
            if (DtProduccion.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha ingresada, NO puede ser superior a la fecha actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DtProduccion.Focus();
                return;
            }



            if (Tipo == "1SAL")
            {
                if (MessageBox.Show("¿Confirma que desea Iniciar el Proceso?", "Confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bandera = 0;
                    string[] msg = AddSalazon();

                    if (msg[1] == "Exist")
                    {

                        MessageBox.Show(msg[0], "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                        return;

                    }
                    else if (msg[1] == "0")
                    {

                        MessageBox.Show(msg[0], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Cancel;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(msg[0], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

            if (Tipo == "2SAL")
            {
                if (MessageBox.Show("¿Confirma que desea Iniciar el Proceso?", "Confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bandera = 0;
                    string[] msg = AddSalazon();

                    if (msg[1] == "Exist")
                    {

                        MessageBox.Show(msg[0], "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                        return;

                    }
                    else if (msg[1] == "0")
                    {

                        MessageBox.Show(msg[0], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Cancel;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(msg[0], "LOSCALVOS.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }



        }
    }
}

    
 

