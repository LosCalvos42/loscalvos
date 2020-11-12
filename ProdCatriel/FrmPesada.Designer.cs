namespace TRAZAAR
{
    partial class FrmPesada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesada));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblKg = new System.Windows.Forms.Label();
            this.lblespe = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PicGIF = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.ReceivedBytesThreshold = 2;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblKg
            // 
            this.lblKg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.Black;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblKg.Location = new System.Drawing.Point(30, 13);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(0, 46);
            this.lblKg.TabIndex = 20;
            this.lblKg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblespe
            // 
            this.lblespe.AutoSize = true;
            this.lblespe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblespe.ForeColor = System.Drawing.Color.Firebrick;
            this.lblespe.Location = new System.Drawing.Point(18, 55);
            this.lblespe.Name = "lblespe";
            this.lblespe.Size = new System.Drawing.Size(209, 20);
            this.lblespe.TabIndex = 44;
            this.lblespe.Text = "Esperando Datos de la balanza...";
            this.lblespe.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblespe);
            this.groupBox5.Controls.Add(this.PicGIF);
            this.groupBox5.Controls.Add(this.lblKg);
            this.groupBox5.Location = new System.Drawing.Point(24, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 77);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            // 
            // PicGIF
            // 
            this.PicGIF.Image = global::TRAZAAR.Properties.Resources.gargando4;
            this.PicGIF.Location = new System.Drawing.Point(97, 17);
            this.PicGIF.Name = "PicGIF";
            this.PicGIF.Size = new System.Drawing.Size(45, 38);
            this.PicGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicGIF.TabIndex = 138;
            this.PicGIF.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(192, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 44;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPesada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(304, 103);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPesada";
            this.Text = "Balanza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSelecJamon_FormClosing);
            this.Load += new System.EventHandler(this.FrmSelecJamon_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblespe;
        private System.Windows.Forms.PictureBox PicGIF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}