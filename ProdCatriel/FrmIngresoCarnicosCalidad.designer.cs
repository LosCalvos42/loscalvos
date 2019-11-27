namespace TRAZAAR
{
    partial class FrmIngresoCarnicosCalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoCarnicosCalidad));
            this.Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.Rnocumple = new System.Windows.Forms.RadioButton();
            this.Rcumple = new System.Windows.Forms.RadioButton();
            this.LblRemito = new System.Windows.Forms.Label();
            this.lblOC = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtRutainforme = new System.Windows.Forms.TextBox();
            this.pBuscar = new System.Windows.Forms.PictureBox();
            this.GbInforme = new System.Windows.Forms.GroupBox();
            this.Opinforme = new System.Windows.Forms.OpenFileDialog();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).BeginInit();
            this.GbInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.LightCoral;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.Location = new System.Drawing.Point(547, 7);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(76, 33);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Cerrar  X";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(23, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Observaciones:";
            // 
            // txtdetalle
            // 
            this.txtdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalle.Location = new System.Drawing.Point(20, 176);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdetalle.Size = new System.Drawing.Size(603, 156);
            this.txtdetalle.TabIndex = 53;
            // 
            // Rnocumple
            // 
            this.Rnocumple.AutoSize = true;
            this.Rnocumple.Location = new System.Drawing.Point(375, 356);
            this.Rnocumple.Name = "Rnocumple";
            this.Rnocumple.Size = new System.Drawing.Size(178, 17);
            this.Rnocumple.TabIndex = 55;
            this.Rnocumple.Text = "NO CUMPLE ESPECIFICACIÓN";
            this.Rnocumple.UseVisualStyleBackColor = true;
            this.Rnocumple.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rcumple
            // 
            this.Rcumple.AutoSize = true;
            this.Rcumple.Location = new System.Drawing.Point(133, 356);
            this.Rcumple.Name = "Rcumple";
            this.Rcumple.Size = new System.Drawing.Size(162, 17);
            this.Rcumple.TabIndex = 56;
            this.Rcumple.Text = "CUMPLE ESPECIFICACIÓN:";
            this.Rcumple.UseVisualStyleBackColor = true;
            this.Rcumple.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LblRemito
            // 
            this.LblRemito.AutoSize = true;
            this.LblRemito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.LblRemito.Location = new System.Drawing.Point(84, 38);
            this.LblRemito.Name = "LblRemito";
            this.LblRemito.Size = new System.Drawing.Size(127, 16);
            this.LblRemito.TabIndex = 52;
            this.LblRemito.Text = "Rmito: 1234-123456";
            // 
            // lblOC
            // 
            this.lblOC.AutoSize = true;
            this.lblOC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblOC.Location = new System.Drawing.Point(79, 15);
            this.lblOC.Name = "lblOC";
            this.lblOC.Size = new System.Drawing.Size(90, 16);
            this.lblOC.TabIndex = 57;
            this.lblOC.Text = "OCEX 121231";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.LblProducto.Location = new System.Drawing.Point(100, 61);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(178, 16);
            this.LblProducto.TabIndex = 58;
            this.LblProducto.Text = "Producto: 1221- jamoncnsjf";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblProveedor.Location = new System.Drawing.Point(109, 87);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(74, 16);
            this.lblProveedor.TabIndex = 59;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobs.Location = new System.Drawing.Point(20, 398);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtobs.Size = new System.Drawing.Size(603, 144);
            this.txtobs.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Detalle:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(222, 549);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(86, 32);
            this.BtnAceptar.TabIndex = 62;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(325, 548);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 32);
            this.BtnCancelar.TabIndex = 63;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "TIPO N°:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(17, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "REMITO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(17, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "PRODUCTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(17, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "PROVEEDOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(27, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::TRAZAAR.Properties.Resources.pdf32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(521, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 68;
            this.button1.Text = "&Informe ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtRutainforme
            // 
            this.TxtRutainforme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRutainforme.Location = new System.Drawing.Point(6, 16);
            this.TxtRutainforme.Name = "TxtRutainforme";
            this.TxtRutainforme.Size = new System.Drawing.Size(445, 22);
            this.TxtRutainforme.TabIndex = 69;
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Image = global::TRAZAAR.Properties.Resources.search_32;
            this.pBuscar.Location = new System.Drawing.Point(463, 13);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(26, 25);
            this.pBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBuscar.TabIndex = 70;
            this.pBuscar.TabStop = false;
            this.pBuscar.Click += new System.EventHandler(this.pBuscar_Click);
            // 
            // GbInforme
            // 
            this.GbInforme.Controls.Add(this.pBuscar);
            this.GbInforme.Controls.Add(this.TxtRutainforme);
            this.GbInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.GbInforme.Location = new System.Drawing.Point(20, 106);
            this.GbInforme.Name = "GbInforme";
            this.GbInforme.Size = new System.Drawing.Size(495, 44);
            this.GbInforme.TabIndex = 71;
            this.GbInforme.TabStop = false;
            this.GbInforme.Text = "Informe:";
            // 
            // Opinforme
            // 
            this.Opinforme.FileName = "openFileDialog1";
            // 
            // FrmIngresoCarnicosCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(635, 584);
            this.Controls.Add(this.GbInforme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.lblOC);
            this.Controls.Add(this.Rcumple);
            this.Controls.Add(this.Rnocumple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.LblRemito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresoCarnicosCalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ctrl. de Calidad";
            this.Load += new System.EventHandler(this.DetalleCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).EndInit();
            this.GbInforme.ResumeLayout(false);
            this.GbInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.RadioButton Rnocumple;
        private System.Windows.Forms.RadioButton Rcumple;
        private System.Windows.Forms.Label LblRemito;
        private System.Windows.Forms.Label lblOC;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtRutainforme;
        private System.Windows.Forms.PictureBox pBuscar;
        private System.Windows.Forms.GroupBox GbInforme;
        private System.Windows.Forms.OpenFileDialog Opinforme;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
    }
}