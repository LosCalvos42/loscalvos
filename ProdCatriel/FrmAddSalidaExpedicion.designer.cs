namespace LOSCALVOS
{
    partial class FrmAddSalidaExpedicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSalidaExpedicion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCodbar = new System.Windows.Forms.Panel();
            this.PanelEtiqueta = new System.Windows.Forms.Panel();
            this.LblCamaraOrigen = new System.Windows.Forms.Label();
            this.LblFechaPro = new System.Windows.Forms.Label();
            this.LblLote = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTara = new System.Windows.Forms.Label();
            this.LblBarcod = new System.Windows.Forms.Label();
            this.LblBruto = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblVto = new System.Windows.Forms.Label();
            this.LblKilos = new System.Windows.Forms.Label();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelEtiqueta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 17);
            this.panel1.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(406, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Salida A Expedición";
            // 
            // TxtCodBar
            // 
            this.TxtCodBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.TxtCodBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.TxtCodBar.Location = new System.Drawing.Point(378, 34);
            this.TxtCodBar.Name = "TxtCodBar";
            this.TxtCodBar.Size = new System.Drawing.Size(303, 29);
            this.TxtCodBar.TabIndex = 77;
            this.TxtCodBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(232, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "Cod. de Barras:";
            // 
            // panelCodbar
            // 
            this.panelCodbar.Location = new System.Drawing.Point(8, 190);
            this.panelCodbar.Name = "panelCodbar";
            this.panelCodbar.Size = new System.Drawing.Size(259, 56);
            this.panelCodbar.TabIndex = 0;
            // 
            // PanelEtiqueta
            // 
            this.PanelEtiqueta.BackColor = System.Drawing.Color.White;
            this.PanelEtiqueta.Controls.Add(this.LblCamaraOrigen);
            this.PanelEtiqueta.Controls.Add(this.LblFechaPro);
            this.PanelEtiqueta.Controls.Add(this.LblLote);
            this.PanelEtiqueta.Controls.Add(this.LblCantidad);
            this.PanelEtiqueta.Controls.Add(this.LblTara);
            this.PanelEtiqueta.Controls.Add(this.panelCodbar);
            this.PanelEtiqueta.Controls.Add(this.LblBarcod);
            this.PanelEtiqueta.Controls.Add(this.LblBruto);
            this.PanelEtiqueta.Controls.Add(this.LblProducto);
            this.PanelEtiqueta.Controls.Add(this.LblVto);
            this.PanelEtiqueta.Controls.Add(this.LblKilos);
            this.PanelEtiqueta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelEtiqueta.Location = new System.Drawing.Point(19, 78);
            this.PanelEtiqueta.Name = "PanelEtiqueta";
            this.PanelEtiqueta.Size = new System.Drawing.Size(454, 272);
            this.PanelEtiqueta.TabIndex = 131;
            // 
            // LblCamaraOrigen
            // 
            this.LblCamaraOrigen.AutoSize = true;
            this.LblCamaraOrigen.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCamaraOrigen.Location = new System.Drawing.Point(3, 0);
            this.LblCamaraOrigen.Name = "LblCamaraOrigen";
            this.LblCamaraOrigen.Size = new System.Drawing.Size(0, 26);
            this.LblCamaraOrigen.TabIndex = 57;
            // 
            // LblFechaPro
            // 
            this.LblFechaPro.AutoSize = true;
            this.LblFechaPro.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaPro.Location = new System.Drawing.Point(272, 220);
            this.LblFechaPro.Name = "LblFechaPro";
            this.LblFechaPro.Size = new System.Drawing.Size(176, 26);
            this.LblFechaPro.TabIndex = 56;
            this.LblFechaPro.Text = "Fecha: 01/01/2022";
            // 
            // LblLote
            // 
            this.LblLote.AutoSize = true;
            this.LblLote.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLote.Location = new System.Drawing.Point(271, 194);
            this.LblLote.Name = "LblLote";
            this.LblLote.Size = new System.Drawing.Size(110, 26);
            this.LblLote.TabIndex = 55;
            this.LblLote.Text = "Lote: 090H2";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(118, 128);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(130, 38);
            this.LblCantidad.TabIndex = 54;
            this.LblCantidad.Text = "Cant: 126";
            // 
            // LblTara
            // 
            this.LblTara.AutoSize = true;
            this.LblTara.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTara.Location = new System.Drawing.Point(4, 144);
            this.LblTara.Name = "LblTara";
            this.LblTara.Size = new System.Drawing.Size(93, 22);
            this.LblTara.TabIndex = 53;
            this.LblTara.Text = "Tara: 31,00";
            // 
            // LblBarcod
            // 
            this.LblBarcod.AutoSize = true;
            this.LblBarcod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarcod.Location = new System.Drawing.Point(48, 241);
            this.LblBarcod.Name = "LblBarcod";
            this.LblBarcod.Size = new System.Drawing.Size(186, 22);
            this.LblBarcod.TabIndex = 52;
            this.LblBarcod.Text = "4222091000028795";
            // 
            // LblBruto
            // 
            this.LblBruto.AutoSize = true;
            this.LblBruto.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBruto.Location = new System.Drawing.Point(4, 115);
            this.LblBruto.Name = "LblBruto";
            this.LblBruto.Size = new System.Drawing.Size(108, 22);
            this.LblBruto.TabIndex = 51;
            this.LblBruto.Text = "Bruto: 421,00";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(1, 70);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(414, 41);
            this.LblProducto.TabIndex = 50;
            this.LblProducto.Text = "116 - SALCHICHON C/JAMON";
            // 
            // LblVto
            // 
            this.LblVto.AutoSize = true;
            this.LblVto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVto.Location = new System.Drawing.Point(133, 45);
            this.LblVto.Name = "LblVto";
            this.LblVto.Size = new System.Drawing.Size(201, 29);
            this.LblVto.TabIndex = 49;
            this.LblVto.Text = "VTO.: 01/08/2022";
            // 
            // LblKilos
            // 
            this.LblKilos.AutoSize = true;
            this.LblKilos.Font = new System.Drawing.Font("Bernard MT Condensed", 24F);
            this.LblKilos.Location = new System.Drawing.Point(267, 128);
            this.LblKilos.Name = "LblKilos";
            this.LblKilos.Size = new System.Drawing.Size(144, 38);
            this.LblKilos.TabIndex = 48;
            this.LblKilos.Text = "386,00 kg";
            // 
            // TxtInfo
            // 
            this.TxtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.TxtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo.Location = new System.Drawing.Point(479, 78);
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(454, 272);
            this.TxtInfo.TabIndex = 132;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::LOSCALVOS.Properties.Resources.cancel1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(814, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "&Salir";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // FrmAddSalidaExpedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(941, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.PanelEtiqueta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddSalidaExpedicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALIDA A EXPEDICION";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.panel1.ResumeLayout(false);
            this.PanelEtiqueta.ResumeLayout(false);
            this.PanelEtiqueta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCodBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCodbar;
        private System.Windows.Forms.Panel PanelEtiqueta;
        private System.Windows.Forms.Label LblFechaPro;
        private System.Windows.Forms.Label LblLote;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblTara;
        private System.Windows.Forms.Label LblBarcod;
        private System.Windows.Forms.Label LblBruto;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblVto;
        private System.Windows.Forms.Label LblKilos;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Label LblCamaraOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}