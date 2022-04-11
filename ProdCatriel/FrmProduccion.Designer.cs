namespace LOSCALVOS
{
    partial class FrmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduccion));
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.marchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.PProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.PAlmacenes = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PTrabajos = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraPesaje = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.PUMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionDeDispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marchivo,
            this.PTrabajos,
            this.mReportes,
            this.mConfiguracion,
            this.Psalir});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(800, 32);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
            // 
            // marchivo
            // 
            this.marchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.marchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PProductos,
            this.PAlmacenes,
            this.toolStripMenuItem2});
            this.marchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marchivo.ForeColor = System.Drawing.Color.White;
            this.marchivo.Image = global::LOSCALVOS.Properties.Resources.Archivero1;
            this.marchivo.Name = "marchivo";
            this.marchivo.Size = new System.Drawing.Size(102, 28);
            this.marchivo.Text = "&Archivo";
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.PProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PProductos.ForeColor = System.Drawing.Color.White;
            this.PProductos.Image = global::LOSCALVOS.Properties.Resources.ProductosB;
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(256, 28);
            this.PProductos.Text = "&Productos";
            this.PProductos.Click += new System.EventHandler(this.PProductos_Click);
            // 
            // PAlmacenes
            // 
            this.PAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.PAlmacenes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenesToolStripMenuItem,
            this.tipoDeAlmacenToolStripMenuItem});
            this.PAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAlmacenes.ForeColor = System.Drawing.Color.White;
            this.PAlmacenes.Image = global::LOSCALVOS.Properties.Resources.AlmacenBC;
            this.PAlmacenes.Name = "PAlmacenes";
            this.PAlmacenes.Size = new System.Drawing.Size(256, 28);
            this.PAlmacenes.Text = "&Almacenes";
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.almacenesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.almacenesToolStripMenuItem.Image = global::LOSCALVOS.Properties.Resources.AlmacenBC;
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.almacenesToolStripMenuItem.Text = "&Almacenes";
            this.almacenesToolStripMenuItem.Click += new System.EventHandler(this.almacenesToolStripMenuItem_Click);
            // 
            // tipoDeAlmacenToolStripMenuItem
            // 
            this.tipoDeAlmacenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.tipoDeAlmacenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tipoDeAlmacenToolStripMenuItem.Image = global::LOSCALVOS.Properties.Resources.Perfiles_32;
            this.tipoDeAlmacenToolStripMenuItem.Name = "tipoDeAlmacenToolStripMenuItem";
            this.tipoDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.tipoDeAlmacenToolStripMenuItem.Text = "&Tipo de Almacen";
            this.tipoDeAlmacenToolStripMenuItem.Click += new System.EventHandler(this.TipoDeAlmacenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(256, 28);
            this.toolStripMenuItem2.Text = "&Sectores productivos";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.TipoProductoItem_Click);
            // 
            // PTrabajos
            // 
            this.PTrabajos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarraPesaje,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.PTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTrabajos.ForeColor = System.Drawing.Color.White;
            this.PTrabajos.Image = global::LOSCALVOS.Properties.Resources.Trabajos_trz;
            this.PTrabajos.Name = "PTrabajos";
            this.PTrabajos.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.PTrabajos.Size = new System.Drawing.Size(111, 28);
            this.PTrabajos.Text = "&Trabajos";
            // 
            // BarraPesaje
            // 
            this.BarraPesaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.BarraPesaje.ForeColor = System.Drawing.Color.White;
            this.BarraPesaje.Image = global::LOSCALVOS.Properties.Resources.calendariook;
            this.BarraPesaje.Name = "BarraPesaje";
            this.BarraPesaje.Size = new System.Drawing.Size(271, 28);
            this.BarraPesaje.Text = "Control De Producción";
            this.BarraPesaje.Click += new System.EventHandler(this.BarraPesaje_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Image = global::LOSCALVOS.Properties.Resources.IngresoLote;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(271, 28);
            this.toolStripMenuItem3.Text = "Ingreso a Cámara";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Image = global::LOSCALVOS.Properties.Resources.edit__32;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(271, 28);
            this.toolStripMenuItem4.Text = "Salida A Expedición";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // mReportes
            // 
            this.mReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReportes.ForeColor = System.Drawing.Color.White;
            this.mReportes.Image = global::LOSCALVOS.Properties.Resources.imprimir32;
            this.mReportes.Name = "mReportes";
            this.mReportes.Size = new System.Drawing.Size(114, 28);
            this.mReportes.Text = "Reportes";
            this.mReportes.Click += new System.EventHandler(this.mReportes_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::LOSCALVOS.Properties.Resources.calendariook;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(271, 28);
            this.toolStripMenuItem1.Text = "Control De Producción";
            // 
            // mConfiguracion
            // 
            this.mConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PUMedida,
            this.configuracionDeDispositivosToolStripMenuItem});
            this.mConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mConfiguracion.ForeColor = System.Drawing.Color.White;
            this.mConfiguracion.Image = global::LOSCALVOS.Properties.Resources.Procesos;
            this.mConfiguracion.Name = "mConfiguracion";
            this.mConfiguracion.Size = new System.Drawing.Size(155, 28);
            this.mConfiguracion.Text = "Configuracion";
            // 
            // PUMedida
            // 
            this.PUMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.PUMedida.ForeColor = System.Drawing.Color.White;
            this.PUMedida.Name = "PUMedida";
            this.PUMedida.Size = new System.Drawing.Size(325, 28);
            this.PUMedida.Text = "&Unidad De Medida";
            this.PUMedida.Click += new System.EventHandler(this.PUMedida_Click);
            // 
            // configuracionDeDispositivosToolStripMenuItem
            // 
            this.configuracionDeDispositivosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.configuracionDeDispositivosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuracionDeDispositivosToolStripMenuItem.Name = "configuracionDeDispositivosToolStripMenuItem";
            this.configuracionDeDispositivosToolStripMenuItem.Size = new System.Drawing.Size(325, 28);
            this.configuracionDeDispositivosToolStripMenuItem.Text = "&Configuracion de dispositivos";
            // 
            // Psalir
            // 
            this.Psalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psalir.ForeColor = System.Drawing.Color.White;
            this.Psalir.Image = global::LOSCALVOS.Properties.Resources.cancel;
            this.Psalir.Name = "Psalir";
            this.Psalir.Size = new System.Drawing.Size(74, 28);
            this.Psalir.Text = "Salir";
            this.Psalir.Click += new System.EventHandler(this.Psalir_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 418);
            this.panel1.TabIndex = 21;
            // 
            // FrmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduccion";
            this.Text = "FrmProduccion";
            this.Load += new System.EventHandler(this.FrmProduccion_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem marchivo;
        private System.Windows.Forms.ToolStripMenuItem PTrabajos;
        private System.Windows.Forms.ToolStripMenuItem mConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem mReportes;
        private System.Windows.Forms.ToolStripMenuItem Psalir;
        private System.Windows.Forms.ToolStripMenuItem PProductos;
        private System.Windows.Forms.ToolStripMenuItem PAlmacenes;
        private System.Windows.Forms.ToolStripMenuItem PUMedida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionDeDispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BarraPesaje;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}