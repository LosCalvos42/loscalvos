namespace Alberdi
{
    partial class ControlBuscar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbPor = new System.Windows.Forms.ComboBox();
            this.lblPor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pBuscar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(24, 11);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // cmbPor
            // 
            this.cmbPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPor.FormattingEnabled = true;
            this.cmbPor.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Tipo"});
            this.cmbPor.Location = new System.Drawing.Point(577, 6);
            this.cmbPor.Name = "cmbPor";
            this.cmbPor.Size = new System.Drawing.Size(151, 24);
            this.cmbPor.TabIndex = 2;
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor.Location = new System.Drawing.Point(539, 11);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(32, 16);
            this.lblPor.TabIndex = 3;
            this.lblPor.Text = "Por:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.pBuscar);
            this.panel1.Location = new System.Drawing.Point(77, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 24);
            this.panel1.TabIndex = 9;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBuscar.Location = new System.Drawing.Point(1, 1);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(385, 17);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Image = global::Alberdi.Properties.Resources.search_32;
            this.pBuscar.Location = new System.Drawing.Point(391, -2);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(26, 25);
            this.pBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBuscar.TabIndex = 2;
            this.pBuscar.TabStop = false;
            this.pBuscar.Click += new System.EventHandler(this.pBuscar_Click);
            this.pBuscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBuscar_MouseDown);
            this.pBuscar.MouseLeave += new System.EventHandler(this.pBuscar_MouseLeave);
            this.pBuscar.MouseHover += new System.EventHandler(this.pBuscar_MouseHover);
            this.pBuscar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBuscar_MouseUp);
            // 
            // ControlBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.cmbPor);
            this.Controls.Add(this.lblBuscar);
            this.Name = "ControlBuscar";
            this.Size = new System.Drawing.Size(765, 39);
            this.Load += new System.EventHandler(this.ControlBuscar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbPor;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}
