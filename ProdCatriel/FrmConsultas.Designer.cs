namespace Alberdi
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
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.PArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.PBalanceMP = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoAPlantaMPCárnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosProductivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despostadaCatrielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despostadaTercerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Pmaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Psalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajusteKgMprimaCárnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PArchivo,
            this.Pmaestros,
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
            this.PBalanceMP,
            this.ingresoAPlantaMPCárnicaToolStripMenuItem,
            this.procesosProductivosToolStripMenuItem,
            this.PStock,
            this.ajusteKgMprimaCárnicaToolStripMenuItem});
            this.PArchivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PArchivo.ForeColor = System.Drawing.Color.White;
            this.PArchivo.Image = global::Alberdi.Properties.Resources.Catriel;
            this.PArchivo.Name = "PArchivo";
            this.PArchivo.Size = new System.Drawing.Size(80, 24);
            this.PArchivo.Text = "&Catriel";
            // 
            // PBalanceMP
            // 
            this.PBalanceMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.PBalanceMP.ForeColor = System.Drawing.Color.White;
            this.PBalanceMP.Image = global::Alberdi.Properties.Resources._48px_Crystal_Clear_app_kchart;
            this.PBalanceMP.Name = "PBalanceMP";
            this.PBalanceMP.Size = new System.Drawing.Size(332, 24);
            this.PBalanceMP.Text = "Balance de masa de (M.Prima Cárnica)";
            this.PBalanceMP.Click += new System.EventHandler(this.PBalanceMP_Click);
            // 
            // ingresoAPlantaMPCárnicaToolStripMenuItem
            // 
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.Image = global::Alberdi.Properties.Resources.trans2;
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.Name = "ingresoAPlantaMPCárnicaToolStripMenuItem";
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.Size = new System.Drawing.Size(332, 24);
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.Text = "Ingreso A Planta (MP Cárnica)";
            this.ingresoAPlantaMPCárnicaToolStripMenuItem.Click += new System.EventHandler(this.ingresoAPlantaMPCárnicaToolStripMenuItem_Click);
            // 
            // procesosProductivosToolStripMenuItem
            // 
            this.procesosProductivosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.procesosProductivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despostadaCatrielToolStripMenuItem,
            this.despostadaTercerosToolStripMenuItem,
            this.otrosProcesosToolStripMenuItem});
            this.procesosProductivosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.procesosProductivosToolStripMenuItem.Image = global::Alberdi.Properties.Resources.macaroons_icon32;
            this.procesosProductivosToolStripMenuItem.Name = "procesosProductivosToolStripMenuItem";
            this.procesosProductivosToolStripMenuItem.Size = new System.Drawing.Size(332, 24);
            this.procesosProductivosToolStripMenuItem.Text = "Procesos Productivos";
            this.procesosProductivosToolStripMenuItem.Click += new System.EventHandler(this.procesosProductivosToolStripMenuItem_Click);
            // 
            // despostadaCatrielToolStripMenuItem
            // 
            this.despostadaCatrielToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.despostadaCatrielToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.despostadaCatrielToolStripMenuItem.Image = global::Alberdi.Properties.Resources.ham_icon32;
            this.despostadaCatrielToolStripMenuItem.Name = "despostadaCatrielToolStripMenuItem";
            this.despostadaCatrielToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.despostadaCatrielToolStripMenuItem.Text = "Despostada Catriel";
            this.despostadaCatrielToolStripMenuItem.Click += new System.EventHandler(this.despostadaCatrielToolStripMenuItem_Click);
            // 
            // despostadaTercerosToolStripMenuItem
            // 
            this.despostadaTercerosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.despostadaTercerosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.despostadaTercerosToolStripMenuItem.Image = global::Alberdi.Properties.Resources.ham_icon32;
            this.despostadaTercerosToolStripMenuItem.Name = "despostadaTercerosToolStripMenuItem";
            this.despostadaTercerosToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.despostadaTercerosToolStripMenuItem.Text = "Despostada terceros";
            // 
            // otrosProcesosToolStripMenuItem
            // 
            this.otrosProcesosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.otrosProcesosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.otrosProcesosToolStripMenuItem.Image = global::Alberdi.Properties.Resources.macaroons_icon32;
            this.otrosProcesosToolStripMenuItem.Name = "otrosProcesosToolStripMenuItem";
            this.otrosProcesosToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.otrosProcesosToolStripMenuItem.Text = "Otros Procesos";
            this.otrosProcesosToolStripMenuItem.Click += new System.EventHandler(this.otrosProcesosToolStripMenuItem_Click);
            // 
            // PStock
            // 
            this.PStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.PStock.ForeColor = System.Drawing.Color.White;
            this.PStock.Image = global::Alberdi.Properties.Resources.stock;
            this.PStock.Name = "PStock";
            this.PStock.Size = new System.Drawing.Size(332, 24);
            this.PStock.Text = "&Cuenta Corriente (MP Cárnica)";
            this.PStock.Click += new System.EventHandler(this.PStock_Click);
            // 
            // Pmaestros
            // 
            this.Pmaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.Pmaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem});
            this.Pmaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pmaestros.ForeColor = System.Drawing.Color.White;
            this.Pmaestros.Image = global::Alberdi.Properties.Resources.Alberdi2;
            this.Pmaestros.Name = "Pmaestros";
            this.Pmaestros.Size = new System.Drawing.Size(80, 24);
            this.Pmaestros.Text = "&Alberdi";
            // 
            // consumidoporPeriodoNOCarnicosToolStripMenuItem
            // 
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.Image = global::Alberdi.Properties.Resources.btnBuscar;
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.Name = "consumidoporPeriodoNOCarnicosToolStripMenuItem";
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.Text = "Consumido por Periodo (NO Carnicos)";
            this.consumidoporPeriodoNOCarnicosToolStripMenuItem.Click += new System.EventHandler(this.consumidoporPeriodoNOCarnicosToolStripMenuItem_Click);
            // 
            // Psalir
            // 
            this.Psalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psalir.ForeColor = System.Drawing.Color.White;
            this.Psalir.Image = global::Alberdi.Properties.Resources.icons8_shutdown_30;
            this.Psalir.Name = "Psalir";
            this.Psalir.Size = new System.Drawing.Size(65, 24);
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 20;
            // 
            // ajusteKgMprimaCárnicaToolStripMenuItem
            // 
            this.ajusteKgMprimaCárnicaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.ajusteKgMprimaCárnicaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajusteKgMprimaCárnicaToolStripMenuItem.Image = global::Alberdi.Properties.Resources.icons8_check_file_48;
            this.ajusteKgMprimaCárnicaToolStripMenuItem.Name = "ajusteKgMprimaCárnicaToolStripMenuItem";
            this.ajusteKgMprimaCárnicaToolStripMenuItem.Size = new System.Drawing.Size(362, 24);
            this.ajusteKgMprimaCárnicaToolStripMenuItem.Text = "Ajuste por Diferencia Kg (M.prima Cárnica)";
            this.ajusteKgMprimaCárnicaToolStripMenuItem.Click += new System.EventHandler(this.ajusteKgMprimaCárnicaToolStripMenuItem_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuForm);
            this.Name = "FrmConsultas";
            this.Text = "Consultas";
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem Pmaestros;
        private System.Windows.Forms.ToolStripMenuItem Psalir;
        private System.Windows.Forms.ToolStripMenuItem PArchivo;
        private System.Windows.Forms.ToolStripMenuItem PBalanceMP;
        private System.Windows.Forms.ToolStripMenuItem PStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ingresoAPlantaMPCárnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosProductivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despostadaCatrielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despostadaTercerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumidoporPeriodoNOCarnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteKgMprimaCárnicaToolStripMenuItem;
    }
}