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
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.PArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.PRecepcion = new System.Windows.Forms.ToolStripMenuItem();
            this.PStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Pmaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.PProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.PTRecurso = new System.Windows.Forms.ToolStripMenuItem();
            this.PAlmacenes = new System.Windows.Forms.ToolStripMenuItem();
            this.PFamilias = new System.Windows.Forms.ToolStripMenuItem();
            this.PMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Precursos = new System.Windows.Forms.ToolStripMenuItem();
            this.PProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.PDProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.POdTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.PSOTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.Pparametros = new System.Windows.Forms.ToolStripMenuItem();
            this.PUMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.PReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PArchivo,
            this.Pmaestros,
            this.PProcesos,
            this.Pparametros,
            this.PReportes,
            this.Psalir});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(800, 28);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
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
            this.PArchivo.Size = new System.Drawing.Size(87, 24);
            this.PArchivo.Text = "&Archivo";
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
            // Pmaestros
            // 
            this.Pmaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Pmaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PProductos,
            this.PTRecurso,
            this.PAlmacenes,
            this.PFamilias,
            this.PMarcas,
            this.Precursos});
            this.Pmaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pmaestros.ForeColor = System.Drawing.Color.White;
            this.Pmaestros.Image = global::TRAZAAR.Properties.Resources.icons8_paste_special_30;
            this.Pmaestros.Name = "Pmaestros";
            this.Pmaestros.Size = new System.Drawing.Size(99, 24);
            this.Pmaestros.Text = "Maestros";
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PProductos.ForeColor = System.Drawing.Color.White;
            this.PProductos.Image = global::TRAZAAR.Properties.Resources.icons8_shopping_basket_48;
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(197, 22);
            this.PProductos.Text = "Productos";
            this.PProductos.Click += new System.EventHandler(this.PProductos_Click);
            // 
            // PTRecurso
            // 
            this.PTRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PTRecurso.ForeColor = System.Drawing.Color.White;
            this.PTRecurso.Name = "PTRecurso";
            this.PTRecurso.Size = new System.Drawing.Size(197, 22);
            this.PTRecurso.Text = "&Tipo De Recursos";
            this.PTRecurso.Click += new System.EventHandler(this.PTRecurso_Click);
            // 
            // PAlmacenes
            // 
            this.PAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PAlmacenes.ForeColor = System.Drawing.Color.White;
            this.PAlmacenes.Name = "PAlmacenes";
            this.PAlmacenes.Size = new System.Drawing.Size(197, 22);
            this.PAlmacenes.Text = "&Almacenes";
            this.PAlmacenes.Click += new System.EventHandler(this.PAlmacenes_Click);
            // 
            // PFamilias
            // 
            this.PFamilias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PFamilias.ForeColor = System.Drawing.Color.White;
            this.PFamilias.Name = "PFamilias";
            this.PFamilias.Size = new System.Drawing.Size(197, 22);
            this.PFamilias.Text = "&Familias";
            this.PFamilias.Click += new System.EventHandler(this.PFamilias_Click);
            // 
            // PMarcas
            // 
            this.PMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PMarcas.ForeColor = System.Drawing.Color.White;
            this.PMarcas.Name = "PMarcas";
            this.PMarcas.Size = new System.Drawing.Size(197, 22);
            this.PMarcas.Text = "&Marcas";
            this.PMarcas.Click += new System.EventHandler(this.PMarcas_Click);
            // 
            // Precursos
            // 
            this.Precursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Precursos.ForeColor = System.Drawing.Color.White;
            this.Precursos.Name = "Precursos";
            this.Precursos.Size = new System.Drawing.Size(197, 22);
            this.Precursos.Text = "&Recursos";
            this.Precursos.Click += new System.EventHandler(this.Precursos_Click);
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
            this.Controls.Add(this.menuForm);
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
        private System.Windows.Forms.ToolStripMenuItem PTRecurso;
        private System.Windows.Forms.ToolStripMenuItem PAlmacenes;
        private System.Windows.Forms.ToolStripMenuItem PFamilias;
        private System.Windows.Forms.ToolStripMenuItem PMarcas;
        private System.Windows.Forms.ToolStripMenuItem Precursos;
        private System.Windows.Forms.ToolStripMenuItem PDProcesos;
        private System.Windows.Forms.ToolStripMenuItem POdTrabajo;
        private System.Windows.Forms.ToolStripMenuItem PSOTrabajo;
        private System.Windows.Forms.ToolStripMenuItem PUMedida;
        private System.Windows.Forms.ToolStripMenuItem PArchivo;
        private System.Windows.Forms.ToolStripMenuItem PRecepcion;
        private System.Windows.Forms.ToolStripMenuItem PStock;
    }
}