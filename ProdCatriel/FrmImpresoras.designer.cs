namespace TRAZAAR
{
    partial class FrmImpresoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpresoras));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RPda = new System.Windows.Forms.RadioButton();
            this.RPc = new System.Windows.Forms.RadioButton();
            this.CmbNombre1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.CmbNombre2 = new System.Windows.Forms.ComboBox();
            this.CmbTipo1 = new System.Windows.Forms.ComboBox();
            this.CmbTipo2 = new System.Windows.Forms.ComboBox();
            this.BtnPrint1 = new System.Windows.Forms.Button();
            this.BtnPrint2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::TRAZAAR.Properties.Resources.cancel1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(309, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "&Salir";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = global::TRAZAAR.Properties.Resources.aceptarBlanco;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(200, 235);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 28);
            this.btnAceptar.TabIndex = 75;
            this.btnAceptar.Text = "&Guardar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 18);
            this.panel1.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(224, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 16);
            this.label10.TabIndex = 100;
            this.label10.Text = "Impresoras de Etiquetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Nombre:";
            // 
            // TxtHostName
            // 
            this.TxtHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.TxtHostName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHostName.Location = new System.Drawing.Point(102, 80);
            this.TxtHostName.Name = "TxtHostName";
            this.TxtHostName.Size = new System.Drawing.Size(453, 22);
            this.TxtHostName.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 108;
            this.label1.Text = "Nro. Serie:";
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.TxtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerialNumber.Location = new System.Drawing.Point(102, 52);
            this.TxtSerialNumber.MaxLength = 10;
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.Size = new System.Drawing.Size(453, 22);
            this.TxtSerialNumber.TabIndex = 107;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RPda);
            this.groupBox1.Controls.Add(this.RPc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtSerialNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtHostName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 111);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Terminal:";
            // 
            // RPda
            // 
            this.RPda.AutoSize = true;
            this.RPda.Location = new System.Drawing.Point(177, 24);
            this.RPda.Name = "RPda";
            this.RPda.Size = new System.Drawing.Size(56, 22);
            this.RPda.TabIndex = 112;
            this.RPda.Text = "PDA";
            this.RPda.UseVisualStyleBackColor = true;
            // 
            // RPc
            // 
            this.RPc.AutoSize = true;
            this.RPc.Checked = true;
            this.RPc.Location = new System.Drawing.Point(102, 24);
            this.RPc.Name = "RPc";
            this.RPc.Size = new System.Drawing.Size(47, 22);
            this.RPc.TabIndex = 111;
            this.RPc.TabStop = true;
            this.RPc.Text = "PC";
            this.RPc.UseVisualStyleBackColor = true;
            // 
            // CmbNombre1
            // 
            this.CmbNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNombre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CmbNombre1.FormattingEnabled = true;
            this.CmbNombre1.Location = new System.Drawing.Point(62, 163);
            this.CmbNombre1.Name = "CmbNombre1";
            this.CmbNombre1.Size = new System.Drawing.Size(150, 24);
            this.CmbNombre1.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(59, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 117;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(217, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Tipo:";
            // 
            // r1
            // 
            this.r1.Appearance = System.Windows.Forms.Appearance.Button;
            this.r1.AutoSize = true;
            this.r1.BackColor = System.Drawing.Color.Gainsboro;
            this.r1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.r1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.r1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.ForeColor = System.Drawing.Color.White;
            this.r1.Location = new System.Drawing.Point(518, 163);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(42, 25);
            this.r1.TabIndex = 120;
            this.r1.TabStop = true;
            this.r1.Text = "OFF";
            this.r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.r1.UseVisualStyleBackColor = false;
            this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // r2
            // 
            this.r2.Appearance = System.Windows.Forms.Appearance.Button;
            this.r2.AutoSize = true;
            this.r2.BackColor = System.Drawing.Color.Gainsboro;
            this.r2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.r2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.White;
            this.r2.Location = new System.Drawing.Point(518, 192);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(42, 25);
            this.r2.TabIndex = 124;
            this.r2.TabStop = true;
            this.r2.Text = "OFF";
            this.r2.UseVisualStyleBackColor = false;
            this.r2.CheckedChanged += new System.EventHandler(this.r2_CheckedChanged);
            // 
            // CmbNombre2
            // 
            this.CmbNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNombre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CmbNombre2.FormattingEnabled = true;
            this.CmbNombre2.Location = new System.Drawing.Point(62, 192);
            this.CmbNombre2.Name = "CmbNombre2";
            this.CmbNombre2.Size = new System.Drawing.Size(150, 24);
            this.CmbNombre2.TabIndex = 121;
            this.CmbNombre2.SelectedIndexChanged += new System.EventHandler(this.CmbNombre2_SelectedIndexChanged);
            // 
            // CmbTipo1
            // 
            this.CmbTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CmbTipo1.FormattingEnabled = true;
            this.CmbTipo1.Items.AddRange(new object[] {
            "TERMICA - PL/ETIQUETAS",
            "LASER - PL/NORMAL"});
            this.CmbTipo1.Location = new System.Drawing.Point(220, 163);
            this.CmbTipo1.Name = "CmbTipo1";
            this.CmbTipo1.Size = new System.Drawing.Size(227, 24);
            this.CmbTipo1.TabIndex = 137;
            // 
            // CmbTipo2
            // 
            this.CmbTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.CmbTipo2.FormattingEnabled = true;
            this.CmbTipo2.Items.AddRange(new object[] {
            "TERMICA - PL/ETIQUETAS",
            "LASER - PL/NORMAL"});
            this.CmbTipo2.Location = new System.Drawing.Point(220, 192);
            this.CmbTipo2.Name = "CmbTipo2";
            this.CmbTipo2.Size = new System.Drawing.Size(227, 24);
            this.CmbTipo2.TabIndex = 138;
            // 
            // BtnPrint1
            // 
            this.BtnPrint1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPrint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.BtnPrint1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrint1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint1.ForeColor = System.Drawing.Color.White;
            this.BtnPrint1.Image = global::TRAZAAR.Properties.Resources.imprimir32;
            this.BtnPrint1.Location = new System.Drawing.Point(455, 163);
            this.BtnPrint1.Name = "BtnPrint1";
            this.BtnPrint1.Size = new System.Drawing.Size(55, 24);
            this.BtnPrint1.TabIndex = 141;
            this.BtnPrint1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint1.UseVisualStyleBackColor = false;
            this.BtnPrint1.Click += new System.EventHandler(this.BtnPrint1_Click);
            // 
            // BtnPrint2
            // 
            this.BtnPrint2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPrint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(59)))), ((int)(((byte)(135)))));
            this.BtnPrint2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrint2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint2.ForeColor = System.Drawing.Color.White;
            this.BtnPrint2.Image = global::TRAZAAR.Properties.Resources.imprimir32;
            this.BtnPrint2.Location = new System.Drawing.Point(455, 192);
            this.BtnPrint2.Name = "BtnPrint2";
            this.BtnPrint2.Size = new System.Drawing.Size(55, 24);
            this.BtnPrint2.TabIndex = 142;
            this.BtnPrint2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint2.UseVisualStyleBackColor = false;
            this.BtnPrint2.Click += new System.EventHandler(this.BtnPrint2_Click);
            // 
            // FrmImpresoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 265);
            this.Controls.Add(this.BtnPrint2);
            this.Controls.Add(this.BtnPrint1);
            this.Controls.Add(this.CmbTipo2);
            this.Controls.Add(this.CmbTipo1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.CmbNombre2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbNombre1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImpresoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarItem";
            this.Load += new System.EventHandler(this.FrmAddGrupoFamilia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbNombre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.ComboBox CmbNombre2;
        private System.Windows.Forms.ComboBox CmbTipo1;
        private System.Windows.Forms.ComboBox CmbTipo2;
        private System.Windows.Forms.Button BtnPrint1;
        private System.Windows.Forms.Button BtnPrint2;
        private System.Windows.Forms.RadioButton RPda;
        private System.Windows.Forms.RadioButton RPc;
    }
}