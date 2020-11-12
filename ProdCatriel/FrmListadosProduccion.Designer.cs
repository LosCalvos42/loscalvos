namespace TRAZAAR
{
    partial class FrmListadosProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadosProduccion));
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mnuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mrealizar = new System.Windows.Forms.ToolStripMenuItem();
            this.meliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.LblTituloListado = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.Reliminados = new System.Windows.Forms.RadioButton();
            this.Ractivos = new System.Windows.Forms.RadioButton();
            this.DtDeste = new System.Windows.Forms.DateTimePicker();
            this.DtHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuevo,
            this.mmodificar,
            this.mrealizar,
            this.meliminar,
            this.mimprimir,
            this.salirToolStripMenuItem});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(927, 26);
            this.menuForm.TabIndex = 36;
            this.menuForm.Text = "Menu";
            // 
            // mnuevo
            // 
            this.mnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuevo.ForeColor = System.Drawing.Color.White;
            this.mnuevo.Image = global::TRAZAAR.Properties.Resources.alta32;
            this.mnuevo.Name = "mnuevo";
            this.mnuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mnuevo.Size = new System.Drawing.Size(79, 22);
            this.mnuevo.Text = "Nuevo";
            this.mnuevo.Click += new System.EventHandler(this.mnuevo_Click);
            // 
            // mmodificar
            // 
            this.mmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmodificar.ForeColor = System.Drawing.Color.White;
            this.mmodificar.Image = global::TRAZAAR.Properties.Resources.modificar32;
            this.mmodificar.Name = "mmodificar";
            this.mmodificar.Size = new System.Drawing.Size(97, 22);
            this.mmodificar.Text = "Modificar";
            this.mmodificar.Click += new System.EventHandler(this.mmodificar_Click);
            // 
            // mrealizar
            // 
            this.mrealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mrealizar.ForeColor = System.Drawing.Color.White;
            this.mrealizar.Name = "mrealizar";
            this.mrealizar.Size = new System.Drawing.Size(132, 22);
            this.mrealizar.Text = "&Realizar Trabajo ";
            this.mrealizar.Click += new System.EventHandler(this.mrealizar_Click);
            // 
            // meliminar
            // 
            this.meliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meliminar.ForeColor = System.Drawing.Color.White;
            this.meliminar.Image = global::TRAZAAR.Properties.Resources.eliminar32;
            this.meliminar.Name = "meliminar";
            this.meliminar.Size = new System.Drawing.Size(89, 22);
            this.meliminar.Text = "Eliminar";
            this.meliminar.Click += new System.EventHandler(this.meliminar_Click);
            // 
            // mimprimir
            // 
            this.mimprimir.Enabled = false;
            this.mimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mimprimir.ForeColor = System.Drawing.Color.White;
            this.mimprimir.Image = global::TRAZAAR.Properties.Resources.imprimir32;
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
            // Dgprincipal
            // 
            this.Dgprincipal.AllowUserToAddRows = false;
            this.Dgprincipal.AllowUserToDeleteRows = false;
            this.Dgprincipal.AllowUserToResizeRows = false;
            this.Dgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgprincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Dgprincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgprincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(6, 126);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(915, 312);
            this.Dgprincipal.TabIndex = 43;
            this.Dgprincipal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgprincipal_CellContentDoubleClick);
            // 
            // LblTituloListado
            // 
            this.LblTituloListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloListado.AutoSize = true;
            this.LblTituloListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.LblTituloListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloListado.ForeColor = System.Drawing.Color.White;
            this.LblTituloListado.Location = new System.Drawing.Point(645, 0);
            this.LblTituloListado.Name = "LblTituloListado";
            this.LblTituloListado.Size = new System.Drawing.Size(69, 24);
            this.LblTituloListado.TabIndex = 44;
            this.LblTituloListado.Text = "Listado";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(4, 114);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(425, 5);
            this.progressBar.TabIndex = 45;
            this.progressBar.Value = 100;
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.LblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.LblPorcentaje.Location = new System.Drawing.Point(433, 106);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(70, 15);
            this.LblPorcentaje.TabIndex = 81;
            this.LblPorcentaje.Text = "Cargando...";
            // 
            // Reliminados
            // 
            this.Reliminados.AutoSize = true;
            this.Reliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Reliminados.Location = new System.Drawing.Point(350, 50);
            this.Reliminados.Name = "Reliminados";
            this.Reliminados.Size = new System.Drawing.Size(74, 17);
            this.Reliminados.TabIndex = 83;
            this.Reliminados.Text = "Eliminados";
            this.Reliminados.UseVisualStyleBackColor = true;
            this.Reliminados.CheckedChanged += new System.EventHandler(this.Reliminados_CheckedChanged);
            // 
            // Ractivos
            // 
            this.Ractivos.AutoSize = true;
            this.Ractivos.Checked = true;
            this.Ractivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ractivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Ractivos.Location = new System.Drawing.Point(255, 50);
            this.Ractivos.Name = "Ractivos";
            this.Ractivos.Size = new System.Drawing.Size(59, 17);
            this.Ractivos.TabIndex = 84;
            this.Ractivos.TabStop = true;
            this.Ractivos.Text = "Activos";
            this.Ractivos.UseVisualStyleBackColor = true;
            this.Ractivos.CheckedChanged += new System.EventHandler(this.Ractivos_CheckedChanged);
            // 
            // DtDeste
            // 
            this.DtDeste.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDeste.Location = new System.Drawing.Point(136, 35);
            this.DtDeste.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtDeste.Name = "DtDeste";
            this.DtDeste.Size = new System.Drawing.Size(79, 20);
            this.DtDeste.TabIndex = 85;
            // 
            // DtHasta
            // 
            this.DtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtHasta.Location = new System.Drawing.Point(136, 61);
            this.DtHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtHasta.Name = "DtHasta";
            this.DtHasta.Size = new System.Drawing.Size(79, 20);
            this.DtHasta.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 87;
            this.label1.Text = "F. Prod Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "F. Prod Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleName = "";
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::TRAZAAR.Properties.Resources.icons8_search_property_22__3_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(436, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.TabIndex = 89;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TRAZAAR.Properties.Resources.gargando4;
            this.pictureBox1.Location = new System.Drawing.Point(385, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListadosProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtHasta);
            this.Controls.Add(this.DtDeste);
            this.Controls.Add(this.Ractivos);
            this.Controls.Add(this.Reliminados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblPorcentaje);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.LblTituloListado);
            this.Controls.Add(this.Dgprincipal);
            this.Controls.Add(this.menuForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadosProduccion";
            this.Text = "Listados";
            this.Load += new System.EventHandler(this.FrmListados_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.Label LblTituloListado;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label LblPorcentaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Reliminados;
        private System.Windows.Forms.RadioButton Ractivos;
        private System.Windows.Forms.DateTimePicker DtDeste;
        private System.Windows.Forms.DateTimePicker DtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem mrealizar;
    }
}