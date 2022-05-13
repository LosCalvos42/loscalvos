namespace LOSCALVOS
{
    partial class FrmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIngSal = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUSeguimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMConsultaExpedicion = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mReportes,
            this.Psalir});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(800, 26);
            this.menuForm.TabIndex = 2;
            this.menuForm.Text = "Menu";
            // 
            // mReportes
            // 
            this.mReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuIngSal,
            this.MENUSeguimiento,
            this.toolStripMenuItem1,
            this.BtnMConsultaExpedicion});
            this.mReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReportes.ForeColor = System.Drawing.Color.White;
            this.mReportes.Image = global::LOSCALVOS.Properties.Resources.imprimir32;
            this.mReportes.Name = "mReportes";
            this.mReportes.Size = new System.Drawing.Size(112, 22);
            this.mReportes.Text = "Producción";
            // 
            // MenuIngSal
            // 
            this.MenuIngSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.MenuIngSal.ForeColor = System.Drawing.Color.White;
            this.MenuIngSal.Image = global::LOSCALVOS.Properties.Resources.IngresoLote;
            this.MenuIngSal.Name = "MenuIngSal";
            this.MenuIngSal.Size = new System.Drawing.Size(231, 22);
            this.MenuIngSal.Text = "&Produccion";
            this.MenuIngSal.Click += new System.EventHandler(this.MenuIngSal_Click);
            // 
            // MENUSeguimiento
            // 
            this.MENUSeguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.MENUSeguimiento.ForeColor = System.Drawing.Color.White;
            this.MENUSeguimiento.Image = global::LOSCALVOS.Properties.Resources.IngresoLote;
            this.MENUSeguimiento.Name = "MENUSeguimiento";
            this.MENUSeguimiento.Size = new System.Drawing.Size(231, 22);
            this.MENUSeguimiento.Text = "&Seguimiento CodBar";
            this.MENUSeguimiento.Click += new System.EventHandler(this.MENUSeguimiento_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::LOSCALVOS.Properties.Resources.produccion;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem1.Text = "&Consulta de Stock";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BtnMConsultaExpedicion
            // 
            this.BtnMConsultaExpedicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.BtnMConsultaExpedicion.ForeColor = System.Drawing.Color.White;
            this.BtnMConsultaExpedicion.Image = global::LOSCALVOS.Properties.Resources.venta;
            this.BtnMConsultaExpedicion.Name = "BtnMConsultaExpedicion";
            this.BtnMConsultaExpedicion.Size = new System.Drawing.Size(231, 22);
            this.BtnMConsultaExpedicion.Text = "&Consulta de Expedicion";
            this.BtnMConsultaExpedicion.Click += new System.EventHandler(this.BtnMConsultaExpedicion_Click);
            // 
            // Psalir
            // 
            this.Psalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psalir.ForeColor = System.Drawing.Color.White;
            this.Psalir.Image = global::LOSCALVOS.Properties.Resources.icons8_shutdown_30;
            this.Psalir.Name = "Psalir";
            this.Psalir.Size = new System.Drawing.Size(65, 22);
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
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 424);
            this.panel1.TabIndex = 20;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultas";
            this.Text = "Consultas";
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem Psalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mReportes;
        private System.Windows.Forms.ToolStripMenuItem MenuIngSal;
        private System.Windows.Forms.ToolStripMenuItem MENUSeguimiento;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BtnMConsultaExpedicion;
    }
}