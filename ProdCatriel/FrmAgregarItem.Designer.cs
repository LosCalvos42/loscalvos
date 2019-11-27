namespace TRAZAAR
{
    partial class FrmAgregarItem
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pBuscar2 = new System.Windows.Forms.PictureBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMasMP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(81, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 35;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantiDetalle_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantiDetalle_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.pBuscar2);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 24);
            this.panel1.TabIndex = 34;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCodigo.Location = new System.Drawing.Point(1, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(175, 17);
            this.txtCodigo.TabIndex = 10;
            // 
            // pBuscar2
            // 
            this.pBuscar2.BackColor = System.Drawing.Color.Transparent;
            this.pBuscar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBuscar2.Image = global::TRAZAAR.Properties.Resources.search_32;
            this.pBuscar2.Location = new System.Drawing.Point(178, 0);
            this.pBuscar2.Name = "pBuscar2";
            this.pBuscar2.Size = new System.Drawing.Size(26, 24);
            this.pBuscar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBuscar2.TabIndex = 2;
            this.pBuscar2.TabStop = false;
            this.pBuscar2.Click += new System.EventHandler(this.pBuscar2_Click);
            this.pBuscar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBuscar2_MouseDown);
            this.pBuscar2.MouseLeave += new System.EventHandler(this.pBuscar2_MouseLeave);
            this.pBuscar2.MouseHover += new System.EventHandler(this.pBuscar2_MouseHover);
            this.pBuscar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBuscar2_MouseUp);
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(14, 83);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.ReadOnly = true;
            this.txtDescrip.Size = new System.Drawing.Size(537, 15);
            this.txtDescrip.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cantidad:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.lblCodigo.Location = new System.Drawing.Point(9, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 16);
            this.lblCodigo.TabIndex = 31;
            this.lblCodigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = " Descripción";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::TRAZAAR.Properties.Resources.cancel1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(287, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMasMP
            // 
            this.btnMasMP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMasMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnMasMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasMP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMP.ForeColor = System.Drawing.Color.White;
            this.btnMasMP.Image = global::TRAZAAR.Properties.Resources.aceptarBlanco;
            this.btnMasMP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasMP.Location = new System.Drawing.Point(184, 152);
            this.btnMasMP.Name = "btnMasMP";
            this.btnMasMP.Size = new System.Drawing.Size(97, 28);
            this.btnMasMP.TabIndex = 75;
            this.btnMasMP.Text = "&Aceptar";
            this.btnMasMP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasMP.UseVisualStyleBackColor = false;
            this.btnMasMP.Click += new System.EventHandler(this.btnMasMP_Click);
            // 
            // FrmAgregarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 192);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMasMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAgregarItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pBuscar2;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasMP;
        private System.Windows.Forms.Button btnCancel;
    }
}