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

namespace TRAZAAR
{
    public partial class FrmAddLote : Form
    {
        public FrmAddLote()
        {
            InitializeComponent();
        }

        public string NroSector { get; set; }
        public string Lote { get; set; }
        public string Fecha { get; set; }
        public Int32 OT { get; set; }
        public string CodProd { get; set; }
        public int Unicades { get; set; }
        public decimal kg { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public DataTable DtLoteDetalle { get; set;}
        public DataTable DtItems { get; set; }
        int bandera = 0;
        private void FrmAddLote_Load(object sender, EventArgs e)
        { 
            Inicio();
        }
        private void limpiarObjetos()
        {
            LblTitulo.Text = Titulo;
            TxtObs.Text = "";
            LblLote.Text = Lote;
        }
        private void Inicio()
        {          
            limpiarObjetos();
        }

        private String[] AddLote()
        {

            this.Cursor = Cursors.AppStarting;
            ClsManejador M = new ClsManejador();
            string[] msj;
            List<ClsParametros> lst = new List<ClsParametros>();
            try
            {
                // LOTEH 
                lst.Add(new ClsParametros("@TIPO", "NUEVO"));
                lst.Add(new ClsParametros("@NC_SECTOR", NroSector));
                lst.Add(new ClsParametros("@LOTE", Lote));
                lst.Add(new ClsParametros("@FECHA", Fecha));
                lst.Add(new ClsParametros("@OT", OT));
                lst.Add(new ClsParametros("@CODPROD", CodProd));
                lst.Add(new ClsParametros("@UNI", Unicades));
                lst.Add(new ClsParametros("@KG", kg));
                lst.Add(new ClsParametros("@OBS",TxtObs.Text));
                lst.Add(new ClsParametros("@USR_ID", Program.IDUSER));
                //LOTEI 
                lst.Add(new ClsParametros("@LOTEITEM",DtItems, SqlDbType.Structured, ParameterDirection.Input));
                //LOTEDETALLE
                lst.Add(new ClsParametros("@LOTEDETALLE", DtLoteDetalle, SqlDbType.Structured, ParameterDirection.Input));
                lst.Add(new ClsParametros("@Resultado", "", SqlDbType.VarChar, ParameterDirection.Output,18));
                lst.Add(new ClsParametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 300));
                M.ExecuteSqlTransaction("sp_AddLote", lst);
                msj = new string[2];
                msj[0] = lst[13].Valor.ToString();
                msj[1] = lst[12].Valor.ToString();

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
                msj[0] = "Hubo un Error al Guardar los Datos." +"\n" + "Mensage: " +ex.Message + "\n" +"\n" + "No se Guardo ningún Cambio.";
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
            if (MessageBox.Show("¿Confirma que desea Ingresar el Lote?", "Confirmación.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bandera = 0;
                string[] msg = AddLote();

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
                    MessageBox.Show(msg[0], "TRAZAAR.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

    
 

