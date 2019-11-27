namespace TRAZAAR
{
    partial class FrmCarnicosDiferencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarnicosDiferencias));
            this.label6 = new System.Windows.Forms.Label();
            this.DgCC = new System.Windows.Forms.DataGridView();
            this.dtRHasta = new System.Windows.Forms.DateTimePicker();
            this.dtRDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarF = new System.Windows.Forms.Button();
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgCC)).BeginInit();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(31, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "PERIODO:";
            // 
            // DgCC
            // 
            this.DgCC.AllowUserToAddRows = false;
            this.DgCC.AllowUserToDeleteRows = false;
            this.DgCC.AllowUserToResizeColumns = false;
            this.DgCC.AllowUserToResizeRows = false;
            this.DgCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgCC.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.DgCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgCC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DgCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgCC.EnableHeadersVisualStyles = false;
            this.DgCC.Location = new System.Drawing.Point(13, 106);
            this.DgCC.Name = "DgCC";
            this.DgCC.ReadOnly = true;
            this.DgCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgCC.RowHeadersVisible = false;
            this.DgCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCC.Size = new System.Drawing.Size(710, 548);
            this.DgCC.TabIndex = 68;
            // 
            // dtRHasta
            // 
            this.dtRHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRHasta.Location = new System.Drawing.Point(225, 68);
            this.dtRHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRHasta.Name = "dtRHasta";
            this.dtRHasta.Size = new System.Drawing.Size(104, 20);
            this.dtRHasta.TabIndex = 2;
            // 
            // dtRDesde
            // 
            this.dtRDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRDesde.Location = new System.Drawing.Point(108, 68);
            this.dtRDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRDesde.Name = "dtRDesde";
            this.dtRDesde.Size = new System.Drawing.Size(102, 20);
            this.dtRDesde.TabIndex = 1;
            // 
            // btnBuscarF
            // 
            this.btnBuscarF.AccessibleName = "";
            this.btnBuscarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnBuscarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarF.ForeColor = System.Drawing.Color.White;
            this.btnBuscarF.Location = new System.Drawing.Point(345, 64);
            this.btnBuscarF.Name = "btnBuscarF";
            this.btnBuscarF.Size = new System.Drawing.Size(83, 24);
            this.btnBuscarF.TabIndex = 4;
            this.btnBuscarF.Tag = "";
            this.btnBuscarF.Text = "BUSCAR";
            this.btnBuscarF.UseVisualStyleBackColor = false;
            this.btnBuscarF.Click += new System.EventHandler(this.BtnBuscarF_Click);
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mimprimir,
            this.salirToolStripMenuItem});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(735, 26);
            this.menuForm.TabIndex = 100;
            this.menuForm.Text = "Menu";
            // 
            // mimprimir
            // 
            this.mimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mimprimir.ForeColor = System.Drawing.Color.White;
            this.mimprimir.Image = global::TRAZAAR.Properties.Resources.icons8_print_48;
            this.mimprimir.Name = "mimprimir";
            this.mimprimir.Size = new System.Drawing.Size(89, 22);
            this.mimprimir.Text = "Imprimir";
            this.mimprimir.Click += new System.EventHandler(this.Mimprimir_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.icons8_shutdown_30;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Procesos de ajuste por Diferrencia de peso (KG)";
            // 
            // FrmCarnicosDiferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(735, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuForm);
            this.Controls.Add(this.btnBuscarF);
            this.Controls.Add(this.dtRHasta);
            this.Controls.Add(this.dtRDesde);
            this.Controls.Add(this.DgCC);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarnicosDiferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes (MP Cármica)";
            this.Load += new System.EventHandler(this.DetalleCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCC)).EndInit();
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgCC;
        private System.Windows.Forms.DateTimePicker dtRHasta;
        private System.Windows.Forms.DateTimePicker dtRDesde;
        private System.Windows.Forms.Button btnBuscarF;
        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem mimprimir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}