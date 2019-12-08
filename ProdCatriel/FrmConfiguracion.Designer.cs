namespace TRAZAAR
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.PArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pmaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.PProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.PAlmacenes = new System.Windows.Forms.ToolStripMenuItem();
            this.PFamilias = new System.Windows.Forms.ToolStripMenuItem();
            this.Precursos = new System.Windows.Forms.ToolStripMenuItem();
            this.PMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.PTRecurso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PArchivo,
            this.produccionToolStripMenuItem,
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
            this.Usuarios});
            this.PArchivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PArchivo.ForeColor = System.Drawing.Color.White;
            //this.PArchivo.Image = global::TRAZAAR.Properties.Resources.Configuracion;
            this.PArchivo.Name = "PArchivo";
            this.PArchivo.Size = new System.Drawing.Size(89, 24);
            this.PArchivo.Text = "&Sistema";
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.perfilDeUsuariosToolStripMenuItem});
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            //this.Usuarios.Image = global::TRAZAAR.Properties.Resources.Configuracion;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(180, 24);
            this.Usuarios.Text = "&Permisos";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            //this.usuariosToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.user;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // perfilDeUsuariosToolStripMenuItem
            // 
            this.perfilDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.perfilDeUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
           //this.perfilDeUsuariosToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.clienteBlanco;
            this.perfilDeUsuariosToolStripMenuItem.Name = "perfilDeUsuariosToolStripMenuItem";
            this.perfilDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.perfilDeUsuariosToolStripMenuItem.Text = "&Perfil De Usuarios";
            this.perfilDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.perfilDeUsuariosToolStripMenuItem_Click);
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pmaestros});
            this.produccionToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.produccionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            //this.produccionToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.produccion;
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.produccionToolStripMenuItem.Text = "&Producción";
            // 
            // Psalir
            // 
            this.Psalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psalir.ForeColor = System.Drawing.Color.White;
            //this.Psalir.Image = global::TRAZAAR.Properties.Resources.icons8_shutdown_30;
            this.Psalir.Name = "Psalir";
            this.Psalir.Size = new System.Drawing.Size(65, 24);
            this.Psalir.Text = "Salir";
            this.Psalir.Click += new System.EventHandler(this.Psalir_Click);
            // 
            // lblNombrePantalla
            // 
            this.lblNombrePantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombrePantalla.AutoSize = true;
            this.lblNombrePantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.lblNombrePantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePantalla.ForeColor = System.Drawing.Color.White;
            this.lblNombrePantalla.Location = new System.Drawing.Point(669, 5);
            this.lblNombrePantalla.Name = "lblNombrePantalla";
            this.lblNombrePantalla.Size = new System.Drawing.Size(113, 18);
            this.lblNombrePantalla.TabIndex = 4;
            this.lblNombrePantalla.Text = "Configuración";
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
            this.panel1.TabIndex = 18;
            // 
            // Pmaestros
            // 
            this.Pmaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Pmaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PProductos,
            this.PAlmacenes,
            this.PFamilias,
            this.Precursos,
            this.PMarcas,
            this.PTRecurso});
            this.Pmaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pmaestros.ForeColor = System.Drawing.Color.White;
            //this.Pmaestros.Image = global::TRAZAAR.Properties.Resources.icons8_paste_special_30;
            this.Pmaestros.Name = "Pmaestros";
            this.Pmaestros.Size = new System.Drawing.Size(180, 22);
            this.Pmaestros.Text = "Maestros";
            // 
            // PProductos
            // 
            this.PProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PProductos.ForeColor = System.Drawing.Color.White;
            //this.PProductos.Image = global::TRAZAAR.Properties.Resources.icons8_shopping_basket_48;
            this.PProductos.Name = "PProductos";
            this.PProductos.Size = new System.Drawing.Size(197, 22);
            this.PProductos.Text = "&Productos";
            this.PProductos.Click += new System.EventHandler(this.PProductos_Click);
            // 
            // PAlmacenes
            // 
            this.PAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PAlmacenes.ForeColor = System.Drawing.Color.White;
            this.PAlmacenes.Name = "PAlmacenes";
            this.PAlmacenes.Size = new System.Drawing.Size(197, 22);
            this.PAlmacenes.Text = "&Almacenes";
            // 
            // PFamilias
            // 
            this.PFamilias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PFamilias.ForeColor = System.Drawing.Color.White;
            this.PFamilias.Name = "PFamilias";
            this.PFamilias.Size = new System.Drawing.Size(197, 22);
            this.PFamilias.Text = "&Familias";
            // 
            // Precursos
            // 
            this.Precursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Precursos.ForeColor = System.Drawing.Color.White;
            this.Precursos.Name = "Precursos";
            this.Precursos.Size = new System.Drawing.Size(197, 22);
            this.Precursos.Text = "&Recursos";
            // 
            // PMarcas
            // 
            this.PMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PMarcas.ForeColor = System.Drawing.Color.White;
            this.PMarcas.Name = "PMarcas";
            this.PMarcas.Size = new System.Drawing.Size(197, 22);
            this.PMarcas.Text = "&Marcas";
            // 
            // PTRecurso
            // 
            this.PTRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.PTRecurso.ForeColor = System.Drawing.Color.White;
            this.PTRecurso.Name = "PTRecurso";
            this.PTRecurso.Size = new System.Drawing.Size(197, 22);
            this.PTRecurso.Text = "&Tipo De Recursos";
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombrePantalla);
            this.Controls.Add(this.menuForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfiguracion";
            this.Text = "Configuración";
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem Psalir;
        private System.Windows.Forms.ToolStripMenuItem PArchivo;
        private System.Windows.Forms.Label lblNombrePantalla;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Pmaestros;
        private System.Windows.Forms.ToolStripMenuItem PProductos;
        private System.Windows.Forms.ToolStripMenuItem PAlmacenes;
        private System.Windows.Forms.ToolStripMenuItem PFamilias;
        private System.Windows.Forms.ToolStripMenuItem Precursos;
        private System.Windows.Forms.ToolStripMenuItem PMarcas;
        private System.Windows.Forms.ToolStripMenuItem PTRecurso;
    }
}