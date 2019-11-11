namespace Alberdi
{
    partial class FrmReporteProcesosDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblProceso = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgEntrada = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.LblDescOt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNroOT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblLote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.LightCoral;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.Location = new System.Drawing.Point(1088, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(77, 34);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Cerrar  X";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha:";
            // 
            // LblProceso
            // 
            this.LblProceso.AutoSize = true;
            this.LblProceso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProceso.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblProceso.Location = new System.Drawing.Point(382, 30);
            this.LblProceso.Name = "LblProceso";
            this.LblProceso.Size = new System.Drawing.Size(36, 16);
            this.LblProceso.TabIndex = 34;
            this.LblProceso.Text = "Tipo:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblFecha.Location = new System.Drawing.Point(62, 30);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(48, 16);
            this.LblFecha.TabIndex = 35;
            this.LblFecha.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label7.Location = new System.Drawing.Point(313, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Proceso:";
            // 
            // DgEntrada
            // 
            this.DgEntrada.AllowUserToAddRows = false;
            this.DgEntrada.AllowUserToDeleteRows = false;
            this.DgEntrada.AllowUserToResizeColumns = false;
            this.DgEntrada.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.DgEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgEntrada.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.DgEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgEntrada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgEntrada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgEntrada.ColumnHeadersHeight = 18;
            this.DgEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.desc,
            this.Lote,
            this.Entrada,
            this.Salida});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgEntrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgEntrada.EnableHeadersVisualStyles = false;
            this.DgEntrada.Location = new System.Drawing.Point(14, 107);
            this.DgEntrada.Name = "DgEntrada";
            this.DgEntrada.ReadOnly = true;
            this.DgEntrada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgEntrada.RowHeadersVisible = false;
            this.DgEntrada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgEntrada.Size = new System.Drawing.Size(699, 458);
            this.DgEntrada.TabIndex = 42;
            this.DgEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEntrada_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 83;
            // 
            // desc
            // 
            this.desc.HeaderText = "DESCRIPCION";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 370;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "LOTE";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // Entrada
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Entrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.Entrada.HeaderText = "ENTRADA";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            this.Entrada.Width = 60;
            // 
            // Salida
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Salida.DefaultCellStyle = dataGridViewCellStyle4;
            this.Salida.HeaderText = "SALIDA";
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            this.Salida.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Location = new System.Drawing.Point(142, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Descripción OT:";
            // 
            // LblDescOt
            // 
            this.LblDescOt.AutoSize = true;
            this.LblDescOt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescOt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblDescOt.Location = new System.Drawing.Point(249, 58);
            this.LblDescOt.Name = "LblDescOt";
            this.LblDescOt.Size = new System.Drawing.Size(64, 16);
            this.LblDescOt.TabIndex = 44;
            this.LblDescOt.Text = "10004545";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(11, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "N° OT:";
            // 
            // lblNroOT
            // 
            this.lblNroOT.AutoSize = true;
            this.lblNroOT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroOT.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNroOT.Location = new System.Drawing.Point(55, 58);
            this.lblNroOT.Name = "lblNroOT";
            this.lblNroOT.Size = new System.Drawing.Size(36, 16);
            this.lblNroOT.TabIndex = 48;
            this.lblNroOT.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label6.Location = new System.Drawing.Point(128, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Lote:";
            // 
            // LblLote
            // 
            this.LblLote.AutoSize = true;
            this.LblLote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLote.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblLote.Location = new System.Drawing.Point(166, 30);
            this.LblLote.Name = "LblLote";
            this.LblLote.Size = new System.Drawing.Size(36, 16);
            this.LblLote.TabIndex = 50;
            this.LblLote.Text = "Tipo:";
            // 
            // FrmReporteProcesosDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1177, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblLote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNroOT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDescOt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblProceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReporteProcesosDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle De Procesos";
            this.Load += new System.EventHandler(this.DetalleCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblProceso;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblDescOt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNroOT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
    }
}