namespace TRAZAAR
{
    partial class FrmIngresoCarnicosTrazabilidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoCarnicosTrazabilidad));
            this.Salir = new System.Windows.Forms.Button();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPROBANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNumeroRemito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
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
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblproducto.Location = new System.Drawing.Point(86, 64);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(0, 16);
            this.lblproducto.TabIndex = 35;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblProveedor.Location = new System.Drawing.Point(91, 15);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(0, 16);
            this.lblProveedor.TabIndex = 37;
            // 
            // Dgprincipal
            // 
            this.Dgprincipal.AllowUserToAddRows = false;
            this.Dgprincipal.AllowUserToDeleteRows = false;
            this.Dgprincipal.AllowUserToResizeColumns = false;
            this.Dgprincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.Dgprincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgprincipal.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgprincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.ColumnHeadersHeight = 18;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgprincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.desc,
            this.IDMOV,
            this.DESTONO,
            this.NROOT,
            this.COMPROBANTE,
            this.KG});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(12, 141);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(611, 280);
            this.Dgprincipal.TabIndex = 42;
            this.Dgprincipal.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgprincipal_CellMouseClick);
            this.Dgprincipal.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgprincipal_CellMouseMove);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "FECHA";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // desc
            // 
            this.desc.HeaderText = "ESTADO";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.desc.Visible = false;
            // 
            // IDMOV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            this.IDMOV.DefaultCellStyle = dataGridViewCellStyle3;
            this.IDMOV.HeaderText = "IDMOV";
            this.IDMOV.Name = "IDMOV";
            this.IDMOV.ReadOnly = true;
            this.IDMOV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDMOV.Visible = false;
            // 
            // DESTONO
            // 
            this.DESTONO.HeaderText = "DESTINO";
            this.DESTONO.Name = "DESTONO";
            this.DESTONO.ReadOnly = true;
            this.DESTONO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESTONO.Width = 300;
            // 
            // NROOT
            // 
            this.NROOT.HeaderText = "NROOT";
            this.NROOT.Name = "NROOT";
            this.NROOT.ReadOnly = true;
            this.NROOT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NROOT.Visible = false;
            // 
            // COMPROBANTE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.COMPROBANTE.DefaultCellStyle = dataGridViewCellStyle4;
            this.COMPROBANTE.HeaderText = "REMITO/LOTE";
            this.COMPROBANTE.Name = "COMPROBANTE";
            this.COMPROBANTE.ReadOnly = true;
            this.COMPROBANTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COMPROBANTE.Width = 110;
            // 
            // KG
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.KG.DefaultCellStyle = dataGridViewCellStyle5;
            this.KG.HeaderText = "KG";
            this.KG.Name = "KG";
            this.KG.ReadOnly = true;
            this.KG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KG.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Total :";
            // 
            // LblNumeroRemito
            // 
            this.LblNumeroRemito.AutoSize = true;
            this.LblNumeroRemito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroRemito.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblNumeroRemito.Location = new System.Drawing.Point(80, 38);
            this.LblNumeroRemito.Name = "LblNumeroRemito";
            this.LblNumeroRemito.Size = new System.Drawing.Size(0, 16);
            this.LblNumeroRemito.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Detalle de Movimientos:";
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkg.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblkg.Location = new System.Drawing.Point(70, 89);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(0, 18);
            this.lblkg.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(17, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Remito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(159, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Disponible:";
            // 
            // LblDisponible
            // 
            this.LblDisponible.AutoSize = true;
            this.LblDisponible.BackColor = System.Drawing.Color.Gold;
            this.LblDisponible.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisponible.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblDisponible.Location = new System.Drawing.Point(236, 91);
            this.LblDisponible.Name = "LblDisponible";
            this.LblDisponible.Size = new System.Drawing.Size(0, 16);
            this.LblDisponible.TabIndex = 54;
            // 
            // FrmIngresoCarnicosTrazabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(635, 444);
            this.Controls.Add(this.LblDisponible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNumeroRemito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgprincipal);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresoCarnicosTrazabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento De Ingresos";
            this.Load += new System.EventHandler(this.DetalleCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label lblproducto;
        public System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNumeroRemito;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPROBANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDisponible;
    }
}