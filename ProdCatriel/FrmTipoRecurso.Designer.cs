namespace TRAZAAR
{
    partial class FrmTipoRecurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mmodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.meliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabFrm = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Informacion = new System.Windows.Forms.TabControl();
            this.DgArt = new System.Windows.Forms.DataGridView();
            this.menuForm.SuspendLayout();
            this.tabFrm.SuspendLayout();
            this.Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgArt)).BeginInit();
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
            this.menuForm.Size = new System.Drawing.Size(800, 26);
            this.menuForm.TabIndex = 1;
            this.menuForm.Text = "Menu";
            // 
            // mmodificar
            // 
            this.mmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmodificar.ForeColor = System.Drawing.Color.White;
            this.mmodificar.Image = global::TRAZAAR.Properties.Resources.icons8_pencil_drawing_96;
            this.mmodificar.Name = "mmodificar";
            this.mmodificar.Size = new System.Drawing.Size(97, 22);
            this.mmodificar.Text = "Modificar";
            this.mmodificar.Click += new System.EventHandler(this.mmodificar_Click);
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
            this.mnuevo.Click += new System.EventHandler(this.mnuevo_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tabFrm
            // 
            this.tabFrm.Controls.Add(this.textBox3);
            this.tabFrm.Controls.Add(this.radioButton3);
            this.tabFrm.Controls.Add(this.radioButton2);
            this.tabFrm.Controls.Add(this.radioButton1);
            this.tabFrm.Controls.Add(this.textBox2);
            this.tabFrm.Controls.Add(this.textBox1);
            this.tabFrm.Location = new System.Drawing.Point(4, 22);
            this.tabFrm.Name = "tabFrm";
            this.tabFrm.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrm.Size = new System.Drawing.Size(741, 178);
            this.tabFrm.TabIndex = 0;
            this.tabFrm.Text = "Informacion";
            this.tabFrm.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 92);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(542, 80);
            this.textBox3.TabIndex = 8;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(612, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(378, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(155, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.tabFrm);
            this.Informacion.Location = new System.Drawing.Point(25, 336);
            this.Informacion.Name = "Informacion";
            this.Informacion.SelectedIndex = 0;
            this.Informacion.Size = new System.Drawing.Size(749, 204);
            this.Informacion.TabIndex = 4;
            // 
            // DgArt
            // 
            this.DgArt.AllowUserToAddRows = false;
            this.DgArt.AllowUserToDeleteRows = false;
            this.DgArt.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.DgArt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgArt.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgArt.Location = new System.Drawing.Point(29, 44);
            this.DgArt.Name = "DgArt";
            this.DgArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgArt.Size = new System.Drawing.Size(741, 259);
            this.DgArt.TabIndex = 5;
            // 
            // FrmTipoRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.DgArt);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.menuForm);
            this.Name = "FrmTipoRecurso";
            this.Text = "FrmTipoRecurso";
            this.Load += new System.EventHandler(this.FrmTipoRecurso_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.tabFrm.ResumeLayout(false);
            this.tabFrm.PerformLayout();
            this.Informacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgArt)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabFrm;
        private System.Windows.Forms.TabControl Informacion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView DgArt;
    }
}