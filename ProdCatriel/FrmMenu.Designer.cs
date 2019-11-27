namespace TRAZAAR
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btnproduccion = new System.Windows.Forms.Button();
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.pnlempresa = new System.Windows.Forms.StatusBarPanel();
            this.pnlsistema = new System.Windows.Forms.StatusBarPanel();
            this.pnlserver = new System.Windows.Forms.StatusBarPanel();
            this.pnluser = new System.Windows.Forms.StatusBarPanel();
            this.lblNombresoft = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlserver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnluser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.panelMenu.Controls.Add(this.BtnConsultas);
            this.panelMenu.Controls.Add(this.BtnConfiguracion);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.pictureBox5);
            this.panelMenu.Controls.Add(this.pictureBox6);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.Btnproduccion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(160, 600);
            this.panelMenu.TabIndex = 13;
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.ForeColor = System.Drawing.Color.White;
            this.BtnConsultas.Image = global::TRAZAAR.Properties.Resources.reporte;
            this.BtnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.Location = new System.Drawing.Point(6, 126);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(150, 40);
            this.BtnConsultas.TabIndex = 15;
            this.BtnConsultas.Text = "   &Consultas";
            this.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracion.Image = global::TRAZAAR.Properties.Resources.Configuracion;
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.Location = new System.Drawing.Point(6, 172);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(150, 40);
            this.BtnConfiguracion.TabIndex = 14;
            this.BtnConfiguracion.Text = "   &Configuración";
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.lblNombresoft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 40);
            this.panel2.TabIndex = 13;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(114, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.pictureBox5.Location = new System.Drawing.Point(0, 310);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(2, 40);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.pictureBox6.Location = new System.Drawing.Point(0, 264);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(3, 40);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(0, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 40);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox4.Location = new System.Drawing.Point(0, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(3, 40);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(0, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 40);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btnproduccion
            // 
            this.Btnproduccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btnproduccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.Btnproduccion.FlatAppearance.BorderSize = 0;
            this.Btnproduccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btnproduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Btnproduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnproduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnproduccion.ForeColor = System.Drawing.Color.White;
            this.Btnproduccion.Image = global::TRAZAAR.Properties.Resources.produccion;
            this.Btnproduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnproduccion.Location = new System.Drawing.Point(6, 80);
            this.Btnproduccion.Name = "Btnproduccion";
            this.Btnproduccion.Size = new System.Drawing.Size(150, 40);
            this.Btnproduccion.TabIndex = 0;
            this.Btnproduccion.Text = "  &Producción";
            this.Btnproduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnproduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnproduccion.UseVisualStyleBackColor = true;
            this.Btnproduccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 573);
            this.panel1.TabIndex = 17;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.BarraTitulo.Controls.Add(this.statusBar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraTitulo.Location = new System.Drawing.Point(160, 573);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(912, 27);
            this.BarraTitulo.TabIndex = 14;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // statusBar
            // 
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusBar.Location = new System.Drawing.Point(0, 0);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.pnlempresa,
            this.pnlsistema,
            this.pnlserver,
            this.pnluser});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(912, 24);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 12;
            // 
            // pnlempresa
            // 
            this.pnlempresa.Icon = ((System.Drawing.Icon)(resources.GetObject("pnlempresa.Icon")));
            this.pnlempresa.Name = "pnlempresa";
            this.pnlempresa.Width = 50;
            // 
            // pnlsistema
            // 
            this.pnlsistema.Icon = ((System.Drawing.Icon)(resources.GetObject("pnlsistema.Icon")));
            this.pnlsistema.Name = "pnlsistema";
            // 
            // pnlserver
            // 
            this.pnlserver.Icon = ((System.Drawing.Icon)(resources.GetObject("pnlserver.Icon")));
            this.pnlserver.Name = "pnlserver";
            // 
            // pnluser
            // 
            this.pnluser.Icon = ((System.Drawing.Icon)(resources.GetObject("pnluser.Icon")));
            this.pnluser.Name = "pnluser";
            // 
            // lblNombresoft
            // 
            this.lblNombresoft.AutoSize = true;
            this.lblNombresoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresoft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblNombresoft.Location = new System.Drawing.Point(21, 15);
            this.lblNombresoft.Name = "lblNombresoft";
            this.lblNombresoft.Size = new System.Drawing.Size(79, 16);
            this.lblNombresoft.TabIndex = 13;
            this.lblNombresoft.Text = "TRAZAAR";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1072, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenu_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlserver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnluser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btnproduccion;
        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel pnlempresa;
        private System.Windows.Forms.StatusBarPanel pnlsistema;
        private System.Windows.Forms.StatusBarPanel pnlserver;
        private System.Windows.Forms.StatusBarPanel pnluser;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Label lblNombresoft;
    }
}