namespace TRAZAAR
{
    partial class FrmProductos
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
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mnuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.meliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pBuscar = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.menuForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuevo,
            this.mmodificar,
            this.meliminar,
            this.mimprimir,
            this.salirToolStripMenuItem});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(1021, 26);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
            // 
            // mnuevo
            // 
            this.mnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuevo.ForeColor = System.Drawing.Color.White;
            this.mnuevo.Image = global::TRAZAAR.Properties.Resources.icons8_add_folder_64;
            this.mnuevo.Name = "mnuevo";
            this.mnuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mnuevo.Size = new System.Drawing.Size(79, 22);
            this.mnuevo.Text = "Nuevo";
            // 
            // mmodificar
            // 
            this.mmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmodificar.ForeColor = System.Drawing.Color.White;
            this.mmodificar.Image = global::TRAZAAR.Properties.Resources.icons8_pencil_drawing_96;
            this.mmodificar.Name = "mmodificar";
            this.mmodificar.Size = new System.Drawing.Size(97, 22);
            this.mmodificar.Text = "Modificar";
            // 
            // meliminar
            // 
            this.meliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meliminar.ForeColor = System.Drawing.Color.White;
            this.meliminar.Image = global::TRAZAAR.Properties.Resources.icons8_delete_file_128;
            this.meliminar.Name = "meliminar";
            this.meliminar.Size = new System.Drawing.Size(89, 22);
            this.meliminar.Text = "Eliminar";
            // 
            // mimprimir
            // 
            this.mimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mimprimir.ForeColor = System.Drawing.Color.White;
            this.mimprimir.Image = global::TRAZAAR.Properties.Resources.icons8_print_48;
            this.mimprimir.Name = "mimprimir";
            this.mimprimir.Size = new System.Drawing.Size(89, 22);
            this.mimprimir.Text = "Imprimir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.icons8_shutdown_30;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.pBuscar);
            this.panel1.Location = new System.Drawing.Point(64, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 24);
            this.panel1.TabIndex = 17;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBuscar.Location = new System.Drawing.Point(-1, -1);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(391, 24);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Image = global::TRAZAAR.Properties.Resources.search_32;
            this.pBuscar.Location = new System.Drawing.Point(390, -2);
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
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(11, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 16);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar:";
            // 
            // Dgprincipal
            // 
            this.Dgprincipal.AllowUserToAddRows = false;
            this.Dgprincipal.AllowUserToDeleteRows = false;
            this.Dgprincipal.AllowUserToResizeColumns = false;
            this.Dgprincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgprincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgprincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgprincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(12, 89);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(997, 507);
            this.Dgprincipal.TabIndex = 30;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 608);
            this.Controls.Add(this.Dgprincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.menuForm);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem mnuevo;
        private System.Windows.Forms.ToolStripMenuItem mmodificar;
        private System.Windows.Forms.ToolStripMenuItem meliminar;
        private System.Windows.Forms.ToolStripMenuItem mimprimir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView Dgprincipal;
    }
}