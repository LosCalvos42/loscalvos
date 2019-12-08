namespace TRAZAAR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pmaestros = new System.Windows.Forms.ToolStripMenuItem();
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
            this.PProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.PDProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.POdTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.PSOTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.Pparametros = new System.Windows.Forms.ToolStripMenuItem();
            this.PUMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.PReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.PArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.PRecepcion = new System.Windows.Forms.ToolStripMenuItem();
            this.PStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pmaestros,
            this.PProcesos,
            this.Pparametros,
            this.PReportes,
            this.PArchivo,
            this.Psalir});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(800, 28);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 21;
            // 
            // Pmaestros
            // 
            this.Pmaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Pmaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PProductos,
            this.PAlmacenes});
            this.Pmaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pmaestros.ForeColor = System.Drawing.Color.White;
            this.Pmaestros.Image = global::TRAZAAR.Properties.Resources.Archivero1;
            this.Pmaestros.Name = "Pmaestros";
            this.Pmaestros.Size = new System.Drawing.Size(85, 24);
            this.Pmaestros.Text = "&Archivo";
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Productos,
            this.GrupoItem,
            this.TipoProductoItem,
            this.FamiliaItem,
            this.GrupoFamiliaItem,
            this.CategoriaPorPesomenuItem,
            this.CategoriaPorMermaMenuItem});
            this.PProductos.ForeColor = System.Drawing.Color.White;
            this.PProductos.Image = global::TRAZAAR.Properties.Resources.ProductosB;
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(180, 22);
            this.PProductos.Text = "&Productos";
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.Image = global::TRAZAAR.Properties.Resources.ProductosB;
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(217, 22);
            this.Productos.Text = "&Productos";
            this.Productos.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // GrupoItem
            // 
            this.GrupoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.GrupoItem.ForeColor = System.Drawing.Color.White;
            this.GrupoItem.Image = global::TRAZAAR.Properties.Resources.grupos;
            this.GrupoItem.Name = "GrupoItem";
            this.GrupoItem.Size = new System.Drawing.Size(217, 22);
            this.GrupoItem.Text = "&Grupo";
            this.GrupoItem.Click += new System.EventHandler(this.GrupoItem_Click);
            // 
            // TipoProductoItem
            // 
            this.TipoProductoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.TipoProductoItem.ForeColor = System.Drawing.Color.White;
            this.TipoProductoItem.Image = global::TRAZAAR.Properties.Resources.alta32;
            this.TipoProductoItem.Name = "TipoProductoItem";
            this.TipoProductoItem.Size = new System.Drawing.Size(217, 22);
            this.TipoProductoItem.Text = "&Tipo de Productos";
            this.TipoProductoItem.Click += new System.EventHandler(this.TipoProductoItem_Click);
            // 
            // FamiliaItem
            // 
            this.FamiliaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.FamiliaItem.ForeColor = System.Drawing.Color.White;
            this.FamiliaItem.Image = global::TRAZAAR.Properties.Resources.family_32;
            this.FamiliaItem.Name = "FamiliaItem";
            this.FamiliaItem.Size = new System.Drawing.Size(217, 22);
            this.FamiliaItem.Text = "&Familia";
            this.FamiliaItem.Click += new System.EventHandler(this.FamiliaItem_Click);
            // 
            // GrupoFamiliaItem
            // 
            this.GrupoFamiliaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.GrupoFamiliaItem.ForeColor = System.Drawing.Color.White;
            this.GrupoFamiliaItem.Image = global::TRAZAAR.Properties.Resources.familia;
            this.GrupoFamiliaItem.Name = "GrupoFamiliaItem";
            this.GrupoFamiliaItem.Size = new System.Drawing.Size(217, 22);
            this.GrupoFamiliaItem.Text = "&Grupo Familia";
            this.GrupoFamiliaItem.Click += new System.EventHandler(this.GrupoFamiliaItem_Click);
            // 
            // CategoriaPorPesomenuItem
            // 
            this.CategoriaPorPesomenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CategoriaPorPesomenuItem.ForeColor = System.Drawing.Color.White;
            this.CategoriaPorPesomenuItem.Image = global::TRAZAAR.Properties.Resources.KG;
            this.CategoriaPorPesomenuItem.Name = "CategoriaPorPesomenuItem";
            this.CategoriaPorPesomenuItem.Size = new System.Drawing.Size(217, 22);
            this.CategoriaPorPesomenuItem.Text = "&Categoria por Peso";
            this.CategoriaPorPesomenuItem.Click += new System.EventHandler(this.CategoriaPorPesomenuItem_Click);
            // 
            // CategoriaPorMermaMenuItem
            // 
            this.CategoriaPorMermaMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CategoriaPorMermaMenuItem.ForeColor = System.Drawing.Color.White;
            this.CategoriaPorMermaMenuItem.Image = global::TRAZAAR.Properties.Resources.merma;
            this.CategoriaPorMermaMenuItem.Name = "CategoriaPorMermaMenuItem";
            this.CategoriaPorMermaMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CategoriaPorMermaMenuItem.Text = "&Categoria por Merma";
            this.CategoriaPorMermaMenuItem.Click += new System.EventHandler(this.CategoriaPorMermaMenuItem_Click);
            // 
            // PAlmacenes
            // 
            this.PAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PAlmacenes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenesToolStripMenuItem,
            this.tipoDeAlmacenToolStripMenuItem});
            this.PAlmacenes.ForeColor = System.Drawing.Color.White;
            this.PAlmacenes.Image = global::TRAZAAR.Properties.Resources.AlmacenBC;
            this.PAlmacenes.Name = "PAlmacenes";
            this.PAlmacenes.Size = new System.Drawing.Size(180, 22);
            this.PAlmacenes.Text = "&Almacenes";
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.almacenesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.almacenesToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.AlmacenBC;
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.almacenesToolStripMenuItem.Text = "&Almacenes";
            this.almacenesToolStripMenuItem.Click += new System.EventHandler(this.almacenesToolStripMenuItem_Click);
            // 
            // tipoDeAlmacenToolStripMenuItem
            // 
            this.tipoDeAlmacenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.tipoDeAlmacenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tipoDeAlmacenToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.Perfiles_32;
            this.tipoDeAlmacenToolStripMenuItem.Name = "tipoDeAlmacenToolStripMenuItem";
            this.tipoDeAlmacenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tipoDeAlmacenToolStripMenuItem.Text = "&Tipo de Almacen";
            this.tipoDeAlmacenToolStripMenuItem.Click += new System.EventHandler(this.TipoDeAlmacenToolStripMenuItem_Click);
            // 
            // PProcesos
            // 
            this.PProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PDProcesos,
            this.POdTrabajo,
            this.PSOTrabajo});
            this.PProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PProcesos.ForeColor = System.Drawing.Color.White;
            this.PProcesos.Image = global::TRAZAAR.Properties.Resources.icons8_maintenance_16;
            this.PProcesos.Name = "PProcesos";
            this.PProcesos.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.PProcesos.Size = new System.Drawing.Size(101, 24);
            this.PProcesos.Text = "&Procesos";
            // 
            // PDProcesos
            // 
            this.PDProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PDProcesos.ForeColor = System.Drawing.Color.White;
            this.PDProcesos.Name = "PDProcesos";
            this.PDProcesos.Size = new System.Drawing.Size(268, 22);
            this.PDProcesos.Text = "&Definicion De Procesos";
            this.PDProcesos.Click += new System.EventHandler(this.PDProcesos_Click);
            // 
            // POdTrabajo
            // 
            this.POdTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.POdTrabajo.ForeColor = System.Drawing.Color.White;
            this.POdTrabajo.Name = "POdTrabajo";
            this.POdTrabajo.Size = new System.Drawing.Size(268, 22);
            this.POdTrabajo.Text = "&Ord. De Trabajo";
            this.POdTrabajo.Click += new System.EventHandler(this.POdTrabajo_Click);
            // 
            // PSOTrabajo
            // 
            this.PSOTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PSOTrabajo.ForeColor = System.Drawing.Color.White;
            this.PSOTrabajo.Name = "PSOTrabajo";
            this.PSOTrabajo.Size = new System.Drawing.Size(268, 22);
            this.PSOTrabajo.Text = "&Seguimiento De Ord. Trabajo";
            this.PSOTrabajo.Click += new System.EventHandler(this.PSOTrabajo_Click);
            // 
            // Pparametros
            // 
            this.Pparametros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PUMedida});
            this.Pparametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pparametros.ForeColor = System.Drawing.Color.White;
            this.Pparametros.Image = global::TRAZAAR.Properties.Resources.icons8_adjust_48;
            this.Pparametros.Name = "Pparametros";
            this.Pparametros.Size = new System.Drawing.Size(114, 24);
            this.Pparametros.Text = "Parametros";
            // 
            // PUMedida
            // 
            this.PUMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PUMedida.ForeColor = System.Drawing.Color.White;
            this.PUMedida.Name = "PUMedida";
            this.PUMedida.Size = new System.Drawing.Size(197, 22);
            this.PUMedida.Text = "&Unidad De Medida";
            this.PUMedida.Click += new System.EventHandler(this.PUMedida_Click);
            // 
            // PReportes
            // 
            this.PReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PReportes.ForeColor = System.Drawing.Color.White;
            this.PReportes.Image = global::TRAZAAR.Properties.Resources.icons8_print_48;
            this.PReportes.Name = "PReportes";
            this.PReportes.Size = new System.Drawing.Size(97, 24);
            this.PReportes.Text = "Reportes";
            // 
            // PArchivo
            // 
            this.PArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PRecepcion,
            this.PStock});
            this.PArchivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PArchivo.ForeColor = System.Drawing.Color.White;
            this.PArchivo.Image = global::TRAZAAR.Properties.Resources.icons8_check_file_48;
            this.PArchivo.Name = "PArchivo";
            this.PArchivo.Size = new System.Drawing.Size(76, 24);
            this.PArchivo.Text = "&varios";
            // 
            // PRecepcion
            // 
            this.PRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PRecepcion.ForeColor = System.Drawing.Color.White;
            this.PRecepcion.Image = global::TRAZAAR.Properties.Resources.mercaderia;
            this.PRecepcion.Name = "PRecepcion";
            this.PRecepcion.Size = new System.Drawing.Size(247, 24);
            this.PRecepcion.Text = "&Recepcion de Mercaderia";
            this.PRecepcion.Click += new System.EventHandler(this.PRecepcion_Click);
            // 
            // PStock
            // 
            this.PStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PStock.ForeColor = System.Drawing.Color.White;
            this.PStock.Image = global::TRAZAAR.Properties.Resources.stock;
            this.PStock.Name = "PStock";
            this.PStock.Size = new System.Drawing.Size(247, 24);
            this.PStock.Text = "&Stock";
            this.PStock.Click += new System.EventHandler(this.PStock_Click);
            // 
            // Psalir
            // 
            this.Psalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psalir.ForeColor = System.Drawing.Color.White;
            this.Psalir.Image = global::TRAZAAR.Properties.Resources.icons8_shutdown_30;
            this.Psalir.Name = "Psalir";
            this.Psalir.Size = new System.Drawing.Size(65, 24);
            this.Psalir.Text = "Salir";
            this.Psalir.Click += new System.EventHandler(this.Psalir_Click);
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
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem Pmaestros;
        private System.Windows.Forms.ToolStripMenuItem PProcesos;
        private System.Windows.Forms.ToolStripMenuItem Pparametros;
        private System.Windows.Forms.ToolStripMenuItem PReportes;
        private System.Windows.Forms.ToolStripMenuItem Psalir;
        private System.Windows.Forms.ToolStripMenuItem PProductos;
        private System.Windows.Forms.ToolStripMenuItem PAlmacenes;
        private System.Windows.Forms.ToolStripMenuItem PDProcesos;
        private System.Windows.Forms.ToolStripMenuItem POdTrabajo;
        private System.Windows.Forms.ToolStripMenuItem PSOTrabajo;
        private System.Windows.Forms.ToolStripMenuItem PUMedida;
        private System.Windows.Forms.ToolStripMenuItem PArchivo;
        private System.Windows.Forms.ToolStripMenuItem PRecepcion;
        private System.Windows.Forms.ToolStripMenuItem PStock;
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
    }
}