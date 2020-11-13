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
    public partial class FrmOrdenesProduccion : Form
    {
        public FrmOrdenesProduccion()
        {
            InitializeComponent();
        }

        private void menuForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void refreshEtiqueta()
        {
            
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel=true;
            Codigo.LabelFont = new Font("Arial", 7, FontStyle.Regular);
            panelCodbar.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, "06701800194534", Color.Black, Color.White, 121, 40);
            
            //Codigo.IncludeLabel = true;
            
           panelCodbar.BackgroundImageLayout = ImageLayout.None;
                panelCodbar.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);


        }

        private void FrmOrdenesProduccion_Load(object sender, EventArgs e)
        {
            refreshEtiqueta();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
