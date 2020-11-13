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
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.GrupoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoProductoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FamiliaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrupoFamiliaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriaPorPesomenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriaPorMermaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PAlmacenes = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PTrabajos = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraPesaje = new System.Windows.Forms.ToolStripMenuItem();
            this.mReportes = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marchivo,
            this.PTrabajos,
            this.mReportes,
            this.mConfiguracion,
            this.Psalir});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(800, 28);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
            // 
            // marchivo
            // 
            this.marchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.marchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PProductos,
            this.PAlmacenes,
            this.procesosToolStripMenuItem});
            this.marchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marchivo.ForeColor = System.Drawing.Color.White;
            this.marchivo.Image = global::LOSCALVOS.Properties.Resources.Archivero1;
            this.marchivo.Name = "marchivo";
            this.marchivo.Size = new System.Drawing.Size(89, 24);
            this.marchivo.Text = "&Archivo";
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.PProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Productos,
            this.GrupoItem,
            this.TipoProductoItem,
            this.FamiliaItem,
            this.GrupoFamiliaItem,
            this.CategoriaPorPesomenuItem,
            this.CategoriaPorMermaMenuItem});
            this.PProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PProductos.ForeColor = System.Drawing.Color.White;
            this.PProductos.Image = global::LOSCALVOS.Properties.Resources.ProductosB;
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(180, 24);
            this.PProductos.Text = "&Productos";
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.Image = global::LOSCALVOS.Properties.Resources.ProductosB;
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(227, 24);
            this.Productos.Text = "&Productos";
            this.Productos.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // GrupoItem
            // 
            this.GrupoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.GrupoItem.ForeColor = System.Drawing.Color.White;
            this.GrupoItem.Image = global::LOSCALVOS.Properties.Resources.grupos;
            this.GrupoItem.Name = "GrupoItem";
            this.GrupoItem.Size = new System.Drawing.Size(227, 24);
            this.GrupoItem.Text = "&Grupo";
            this.GrupoItem.Click += new System.EventHandler(this.GrupoItem_Click);
            // 
            // TipoProductoItem
            // 
            this.TipoProductoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.TipoProductoItem.ForeColor = System.Drawing.Color.White;
            this.TipoProductoItem.Image = global::LOSCALVOS.Properties.Resources.alta32;
            this.TipoProductoItem.Name = "TipoProductoItem";
            this.TipoProductoItem.Size = new System.Drawing.Size(227, 24);
            this.TipoProductoItem.Text = "&Tipo de Productos";
            this.TipoProductoItem.Click += new System.EventHandler(this.TipoProductoItem_Click);
            // 
            // FamiliaItem
            // 
            this.FamiliaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.FamiliaItem.ForeColor = System.Drawing.Color.White;
            this.FamiliaItem.Image = global::LOSCALVOS.Properties.Resources.family_32;
            this.FamiliaItem.Name = "FamiliaItem";
            this.FamiliaItem.Size = new System.Drawing.Size(227, 24);
            this.FamiliaItem.Text = "&Familia";
            this.FamiliaItem.Click += new System.EventHandler(this.FamiliaItem_Click);
            // 
            // GrupoFamiliaItem
            // 
            this.GrupoFamiliaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.GrupoFamiliaItem.ForeColor = System.Drawing.Color.White;
            this.GrupoFamiliaItem.Image = global::LOSCALVOS.Properties.Resources.familia;
            this.GrupoFamiliaItem.Name = "GrupoFamiliaItem";
            this.GrupoFamiliaItem.Size = new System.Drawing.Size(227, 24);
            this.GrupoFamiliaItem.Text = "&Grupo Familia";
            this.GrupoFamiliaItem.Click += new System.EventHandler(this.GrupoFamiliaItem_Click);
            // 
            // CategoriaPorPesomenuItem
            // 
            this.CategoriaPorPesomenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.CategoriaPorPesomenuItem.ForeColor = System.Drawing.Color.White;
            this.CategoriaPorPesomenuItem.Image = global::LOSCALVOS.Properties.Resources.KG;
            this.CategoriaPorPesomenuItem.Name = "CategoriaPorPesomenuItem";
            this.CategoriaPorPesomenuItem.Size = new System.Drawing.Size(227, 24);
            this.CategoriaPorPesomenuItem.Text = "&Categoria por Peso";
            this.CategoriaPorPesomenuItem.Click += new System.EventHandler(this.CategoriaPorPesomenuItem_Click);
            // 
            // CategoriaPorMermaMenuItem
            // 
            this.CategoriaPorMermaMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CategoriaPorMermaMenuItem.ForeColor = System.Drawing.Color.White;
            this.CategoriaPorMermaMenuItem.Image = global::LOSCALVOS.Properties.Resources.merma;
            this.CategoriaPorMermaMenuItem.Name = "CategoriaPorMermaMenuItem";
            this.CategoriaPorMermaMenuItem.Size = new System.Drawing.Size(227, 24);
            this.CategoriaPorMermaMenuItem.Text = "&Categoria por Merma";
            this.CategoriaPorMermaMenuItem.Click += new System.EventHandler(this.CategoriaPorMermaMenuItem_Click);
            // 
            // PAlmacenes
            // 
            this.PAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.PAlmacenes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenesToolStripMenuItem,
            this.tipoDeAlmacenToolStripMenuItem});
            this.PAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAlmacenes.ForeColor = System.Drawing.Color.White;
            this.PAlmacenes.Image = global::LOSCALVOS.Properties.Resources.AlmacenBC;
            this.PAlmacenes.Name = "PAlmacenes";
            this.PAlmacenes.Size = new System.Drawing.Size(180, 24);
            this.PAlmacenes.Text = "&Almacenes";
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.almacenesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.almacenesToolStripMenuItem.Image = global::LOSCALVOS.Properties.Resources.AlmacenBC;
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.almacenesToolStripMenuItem.Text = "&Almacenes";
            this.almacenesToolStripMenuItem.Click += new System.EventHandler(this.almacenesToolStripMenuItem_Click);
            // 
            // tipoDeAlmacenToolStripMenuItem
            // 
            this.tipoDeAlmacenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.tipoDeAlmacenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tipoDeAlmacenToolStripMenuItem.Image = global::LOSCALVOS.Properties.Resources.Perfiles_32;
            this.tipoDeAlmacenToolStripMenuItem.Name = "tipoDeAlmacenToolStripMenuItem";
            this.tipoDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.tipoDeAlmacenToolStripMenuItem.Text = "&Tipo de Almacen";
            this.tipoDeAlmacenToolStripMenuItem.Click += new System.EventHandler(this.TipoDeAlmacenToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem1});
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.procesosToolStripMenuItem.Image = global::LOSCALVOS.Properties.Resources.Procesos;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.procesosToolStripMenuItem.Text = "&Procesos";
            // 
            // procesosToolStripMenuItem1
            // 
            this.procesosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.procesosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.procesosToolStripMenuItem1.Image = global::LOSCALVOS.Properties.Resources.Procesos;
            this.procesosToolStripMenuItem1.Name = "procesosToolStripMenuItem1";
            this.procesosToolStripMenuItem1.Size = new System.Drawing.Size(240, 24);
            this.procesosToolStripMenuItem1.Text = "&Definición de Procesos";
            this.procesosToolStripMenuItem1.Click += new System.EventHandler(this.procesosToolStripMenuItem1_Click);
            // 
            // PTrabajos
            // 
            this.PTrabajos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BarraPesaje});
            this.PTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTrabajos.ForeColor = System.Drawing.Color.White;
            this.PTrabajos.Image = global::LOSCALVOS.Properties.Resources.Trabajos_trz;
            this.PTrabajos.Name = "PTrabajos";
            this.PTrabajos.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.PTrabajos.Size = new System.Drawing.Size(98, 24);
            this.PTrabajos.Text = "&Trabajos";
            // 
            // BarraPesaje
            // 
            this.BarraPesaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.BarraPesaje.ForeColor = System.Drawing.Color.White;
            this.BarraPesaje.Image = global::LOSCALVOS.Properties.Resources.calendariook;
            this.BarraPesaje.Name = "BarraPesaje";
            this.BarraPesaje.Size = new System.Drawing.Size(237, 24);
            this.BarraPesaje.Text = "Control De Producción";
            // 
            // mReportes
            // 
            this.mReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReportes.ForeColor = System.Drawing.Color.White;
            this.mReportes.Image = global::LOSCALVOS.Properties.Resources.imprimir32;
            this.mReportes.Name = "mReportes";
            this.mReportes.Size = new System.Drawing.Size(103, 24);
            this.mReportes.Text = "Reportes";
            this.mReportes.Click += new System.EventHandler(this.mReportes_Click);
            // 
            // mConfiguracion
            // 
            this.mConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PUMedida,
            this.configuracionDeDispositivosToolStripMenuItem});
            this.mConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mConfiguracion.ForeColor = System.Drawing.Color.White;
            this.mConfiguracion.Image = global::LOSCALVOS.Properties.Resources.Procesos;
            this.mConfiguracion.Name = "mConfiguracion";
            this.mConfiguracion.Size = new System.Drawing.Size(135, 24);
            this.mConfiguracion.Text = "Configuracion";
            // 
            // PUMedida
            // 
            this.PUMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.PUMedida.ForeColor = System.Drawing.Color.White;
            this.PUMedida.Name = "PUMedida";
            this.PUMedida.Size = new System.Drawing.Size(283, 24);
            this.PUMedida.Text = "&Unidad De Medida";
            this.PUMedida.Click += new System.EventHandler(this.PUMedida_Click);
            // 
            // configuracionDeDispositivosToolStripMenuItem
            // 
            this.configuracionDeDispositivosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.configuracionDeDispositivosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuracionDeDispositivosToolStripMenuItem.Name = "configuracionDeDispositivosToolStripMenuItem";
            this.configuracionDeDispositivosToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.configuracionDeDispositivosToolStripMenuItem.Text = "&Configuracion de dispositivos";
            // 
            // Psalir
            // 
            this.Psalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psalir.ForeColor = System.Drawing.Color.White;
            this.Psalir.Image = global::LOSCALVOS.Properties.Resources.cancel;
            this.Psalir.Name = "Psalir";
            this.Psalir.Size = new System.Drawing.Size(68, 24);
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
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
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem TipoProductoItem;
        private System.Windows.Forms.ToolStripMenuItem GrupoItem;
        private System.Windows.Forms.ToolStripMenuItem FamiliaItem;
        private System.Windows.Forms.ToolStripMenuItem GrupoFamiliaItem;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriaPorPesomenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriaPorMermaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuracionDeDispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BarraPesaje;
    }
}