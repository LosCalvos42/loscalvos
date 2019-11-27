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
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PArchivo,
            this.Psalir});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(800, 28);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
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
            // PArchivo
            // 
            this.PArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios});
            this.PArchivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PArchivo.ForeColor = System.Drawing.Color.White;
            this.PArchivo.Image = global::TRAZAAR.Properties.Resources.icons8_check_file_48;
            this.PArchivo.Name = "PArchivo";
            this.PArchivo.Size = new System.Drawing.Size(87, 24);
            this.PArchivo.Text = "&Archivo";
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Image = global::TRAZAAR.Properties.Resources.admin;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(180, 24);
            this.Usuarios.Text = "&Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
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
    }
}