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


namespace TRAZAAR
{
    public partial class FrmImpresoras : Form
    {
        public FrmImpresoras()
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
            Inicio();
            TxtSerialNumber.Text = Program.SerialPC;
            TxtHostName.Text = Program.HostName;
            getImpresoraPorDefecto();
        }

        public  string getImpresoraPorDefecto()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                CmbNombre1.Items.Add(settings.PrinterName);
                CmbNombre2.Items.Add(settings.PrinterName);
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
        private void limpiarObjetos()
        {
            TxtSerialNumber.Text = "";
            TxtHostName.Text = "";
        }
        private void Inicio()
        {

            ClsManejador M = new ClsManejador();
            DataTable dt = new DataTable();
            string ssql = @"select DISPIMPRESORA_nro, DISPIMPRESORA_NOMBRE,DISPIMPRESORA_TIPO,DISPIMPRESORA_ESTADO FROM[TRAZAARDB].[dbo].[DISPIMPRESORAS] I " +
                                  "INNER JOIN[TRAZAARDB].[dbo].[DISPOSITIVOS] D ON D.DISPOSITIVO_ID = I.DISPOSITIVO_ID " +
                                  "WHERE D.DISPOSITIVO_NROSERIE = '" + Program.SerialPC + "' " +
                                  "AND D.DISPOSITIVO_NOMBRE = '" + Program.HostName + "'";
                                  //"AND I.DISPIMPRESORA_ESTADO = 'ON'";
            dt = M.lisquery(ssql);

            if (dt.Rows.Count >0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 1)
                    {
                        CmbNombre1.Text = dt.Rows[i][1].ToString();
                        CmbTipo1.SelectedItem = dt.Rows[i][2].ToString();
                        if (dt.Rows[i][3].ToString() == "ON")
                        {
                            r1.Checked = true;
                        }
                        else
                        {

                            r1.Checked = false;
                        }
                    }
                    if (Convert.ToInt32(dt.Rows[i][0].ToString()) == 2)
                    {
                        CmbNombre2.Text = dt.Rows[i][1].ToString();
                        CmbTipo2.SelectedItem = dt.Rows[i][2].ToString();
                        if (dt.Rows[i][3].ToString() == "ON")
                        {
                            r2.Checked = true;
                        }
                        else
                        {
                            r2.Checked = false;
                        }
                    }
                    
                }
            }  
        }
        private void TestPrint(int Nro)
        {
            string NombreImpresora = "";

            if (Nro == 1)
            {
                NombreImpresora= CmbNombre1.Text;
            }
            if (Nro == 2)
            {
                NombreImpresora = CmbNombre2.Text;
            }

            if (NombreImpresora != "")
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(Pr_PrintPage);
                // Especifica que impresora se utilizara!!
                pd.PrinterSettings.PrinterName = NombreImpresora;
                PageSettings pa = new PageSettings();
                pa.Margins = new Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 350, 190);
                pd.DefaultPageSettings.PaperSize = ps;
                pd.Print();
            }else
            {
                return;
            }
            
        }

        //funcion que se encarga de imprimir
        private void Pr_PrintPage(Object sender, PrintPageEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 12, FontStyle.Bold))//Formato
                using (Font fkg = new Font("Impact", 20))//Formato
                using (Font fing = new Font("Britannic Bold", 25))//Formato
                using (Font ffch = new Font("Arial", 12, FontStyle.Bold))//Formato

                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    string caption = "test test test test test test";//string.Format("{0}", DGIP.CurrentRow.Cells[0].Value.ToString());//PRODUCTO
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 5, 10);//posicion del texto

                    caption = string.Format("{0}", "F. De Elaboración: " + DateTime.Now.ToString("dd/MM/yyyy"));//FECHA
                    g.DrawString(caption, ffch, System.Drawing.Brushes.Black, 5, 33);

                    caption = string.Format("{0}", "TEST DE IMPRESION");// DGIP.CurrentRow.Cells[1].Value.ToString());//INGREDIENTE
                    g.DrawString(caption, fing, System.Drawing.Brushes.Black, 5, 55);

                    decimal kg = 1500;//Convert.ToDecimal(DGIP.CurrentRow.Cells[3].Value.ToString());
                    
                    caption = string.Format("{0}", kg.ToString("N3") + " Kg."); //KILOS
                    g.DrawString(caption, fkg, System.Drawing.Brushes.Black, 205, 100);

                    caption = string.Format("{0}", "F.Ven: " + DateTime.Now.ToString("dd/MM/yyyy"));//BOLSA
                    g.DrawString(caption, ffch, System.Drawing.Brushes.Black, 205, 158);

                    caption = string.Format("{0}", "TEST");//CODIGO
                    g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 30, 170);
                    //Codigo.IncludeLabel = true;
                    //Codigo.LabelFont = new Font("Arial", 15, FontStyle.Bold);
                    g.DrawImage(Codigo.Encode(BarcodeLib.TYPE.CODE128, "TEST", Color.Black, Color.White, 200, 40), -6, 130);//CODBAR
                }
            }
        }

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
                                " FROM [TRAZAARDB].[dbo].[DISPOSITIVOS] "+
                                " WHERE DISPOSITIVO_NROSERIE = '"+TxtSerialNumber.Text+ "' " +
                                " AND DISPOSITIVO_NOMBRE= '"+TxtHostName.Text+"'";
                dt = M.lisquery(ssql);

                if (dt.Rows.Count==0)
                {
                    M.Ejecutarquery("INSERT [TRAZAARDB].[dbo].[DISPOSITIVOS]  " +
                    "(DISPOSITIVO_TIPO, DISPOSITIVO_NROSERIE, DISPOSITIVO_NOMBRE,DISPOSITIVO_DEBAJA) " +
                    "VALUES( '"+Tipodispositivo+"','"+TxtSerialNumber.Text+"','"+TxtHostName.Text+"','N')");
                }

               ssql = @"SELECT DISPOSITIVO_ID "+
                        "FROM [TRAZAARDB].[dbo].[DISPOSITIVOS] " +
                        "WHERE DISPOSITIVO_NROSERIE ='" + TxtSerialNumber.Text + "' " +
                        "AND DISPOSITIVO_NOMBRE='" + TxtHostName.Text+"'";
                dt = M.lisquery(ssql);

                if (dt.Rows.Count == 1)
                {
                    int DispositivoID = Convert.ToInt32(dt.Rows[0][0].ToString());

                    M.Ejecutarquery("DELETE [TRAZAARDB].[dbo].[DISPIMPRESORAS]  " +
                    "WHERE DISPOSITIVO_ID= " + DispositivoID);

                    if (CmbNombre1.Text != "")
                    {
                        M.Ejecutarquery("INSERT [TRAZAARDB].[dbo].[DISPIMPRESORAS]  " +
                        "(DISPOSITIVO_ID, DISPIMPRESORA_NRO, DISPIMPRESORA_NOMBRE,DISPIMPRESORA_TIPO,DISPIMPRESORA_ESTADO) " +
                        "VALUES( " + DispositivoID + "," + 1 + ",'" + CmbNombre1.Text + "','" + CmbTipo1.Text + "','" + r1.Text + "')");
                    }
                    if (CmbNombre2.Text != "")
                    {
                        M.Ejecutarquery("INSERT [TRAZAARDB].[dbo].[DISPIMPRESORAS]  " +
                        "(DISPOSITIVO_ID, DISPIMPRESORA_NRO, DISPIMPRESORA_NOMBRE,DISPIMPRESORA_TIPO,DISPIMPRESORA_ESTADO) " +
                        "VALUES( " + DispositivoID + "," + 2 + ",'" + CmbNombre2.Text + "','" + CmbTipo2.Text + "','" + r2.Text + "')");
                    }
                    
                    ssql = @"SELECT DISPIMPRESORA_NOMBRE "+
                        "FROM [TRAZAARDB].[dbo].[DISPIMPRESORAS] " +
                        "WHERE DISPOSITIVO_ID=" + DispositivoID +
                        " AND DISPIMPRESORA_ESTADO='ON'";
                    dt = M.lisquery(ssql);

                    if (dt.Rows.Count == 1)
                    {
                        Program.IMPRESORAETIQUETA = dt.Rows[0][0].ToString();
                        MessageBox.Show("Los Datos se Guardaron Correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    { 
                        MessageBox.Show("NO Hay Impresoras configuradas para este Dispositivo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Error al Intentar Modificar, consulte con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                r1.Text = "ON";
            }
            else
            {
                r1.Text = "OFF";
            }
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {

            if (r2.Checked)
            {
                r2.Text = "ON";
            }
            else
            {
                r2.Text = "OFF";
            }
        }

        private void BtnPrint1_Click(object sender, EventArgs e)
        {
            TestPrint(1);
        }

        private void BtnPrint2_Click(object sender, EventArgs e)
        {
            TestPrint(2);
        }
    }
}

    
 

