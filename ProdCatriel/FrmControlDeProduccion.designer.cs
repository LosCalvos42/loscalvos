namespace LOSCALVOS
{
    partial class FrmControlDeProduccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlDeProduccion));
            this.label5 = new System.Windows.Forms.Label();
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mnuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.meliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdProceso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdSector = new System.Windows.Forms.ComboBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKBruto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtkNeto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTara = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbAlmacen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChekFUni = new System.Windows.Forms.CheckBox();
            this.ChekManual = new System.Windows.Forms.CheckBox();
            this.ChekFTara = new System.Windows.Forms.CheckBox();
            this.BtnBalanzaAceptar = new System.Windows.Forms.Button();
            this.ChekFLote = new System.Windows.Forms.CheckBox();
            this.DtProduccion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codbar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChekFprod = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.TxtCodProd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscarProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(4, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 127;
            this.label5.Text = "Producto:";
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuevo,
            this.mmodificar,
            this.meliminar,
            this.mimprimir,
            this.salirToolStripMenuItem});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(1028, 26);
            this.menuForm.TabIndex = 130;
            this.menuForm.Text = "Menu";
            // 
            // mnuevo
            // 
            this.mnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuevo.ForeColor = System.Drawing.Color.White;
            this.mnuevo.Image = global::LOSCALVOS.Properties.Resources.alta32;
            this.mnuevo.Name = "mnuevo";
            this.mnuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mnuevo.Size = new System.Drawing.Size(79, 22);
            this.mnuevo.Text = "Nuevo";
            // 
            // mmodificar
            // 
            this.mmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmodificar.ForeColor = System.Drawing.Color.White;
            this.mmodificar.Image = global::LOSCALVOS.Properties.Resources.modificar32;
            this.mmodificar.Name = "mmodificar";
            this.mmodificar.Size = new System.Drawing.Size(97, 22);
            this.mmodificar.Text = "Modificar";
            this.mmodificar.Visible = false;
            // 
            // meliminar
            // 
            this.meliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meliminar.ForeColor = System.Drawing.Color.White;
            this.meliminar.Image = global::LOSCALVOS.Properties.Resources.eliminar32;
            this.meliminar.Name = "meliminar";
            this.meliminar.Size = new System.Drawing.Size(89, 22);
            this.meliminar.Text = "Eliminar";
            this.meliminar.Click += new System.EventHandler(this.meliminar_Click);
            // 
            // mimprimir
            // 
            this.mimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mimprimir.ForeColor = System.Drawing.Color.White;
            this.mimprimir.Image = global::LOSCALVOS.Properties.Resources.imprimir32;
            this.mimprimir.Name = "mimprimir";
            this.mimprimir.Size = new System.Drawing.Size(89, 22);
            this.mimprimir.Text = "Imprimir";
            this.mimprimir.Click += new System.EventHandler(this.mimprimir_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::LOSCALVOS.Properties.Resources.icons8_shutdown_30;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(4, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 131;
            this.label1.Text = "Lote:";
            // 
            // TxtLote
            // 
            this.TxtLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.TxtLote.Location = new System.Drawing.Point(5, 342);
            this.TxtLote.Name = "TxtLote";
            this.TxtLote.Size = new System.Drawing.Size(326, 22);
            this.TxtLote.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(4, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 134;
            this.label2.Text = "Proceso:";
            // 
            // CmdProceso
            // 
            this.CmdProceso.Enabled = false;
            this.CmdProceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.CmdProceso.FormattingEnabled = true;
            this.CmdProceso.Location = new System.Drawing.Point(4, 240);
            this.CmdProceso.Name = "CmdProceso";
            this.CmdProceso.Size = new System.Drawing.Size(348, 24);
            this.CmdProceso.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 136;
            this.label4.Text = "Sertor:";
            // 
            // CmdSector
            // 
            this.CmdSector.Enabled = false;
            this.CmdSector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.CmdSector.FormattingEnabled = true;
            this.CmdSector.Location = new System.Drawing.Point(4, 139);
            this.CmdSector.Name = "CmdSector";
            this.CmdSector.Size = new System.Drawing.Size(348, 24);
            this.CmdSector.TabIndex = 135;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.TxtCantidad.Location = new System.Drawing.Point(8, 78);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(51, 24);
            this.TxtCantidad.TabIndex = 137;
            this.TxtCantidad.Text = "0";
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 138;
            this.label6.Text = "Uni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(70, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 140;
            this.label7.Text = "KG Bruto";
            // 
            // TxtKBruto
            // 
            this.TxtKBruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKBruto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.TxtKBruto.Location = new System.Drawing.Point(66, 78);
            this.TxtKBruto.Name = "TxtKBruto";
            this.TxtKBruto.Size = new System.Drawing.Size(87, 24);
            this.TxtKBruto.TabIndex = 139;
            this.TxtKBruto.Text = "0";
            this.TxtKBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtKBruto.Click += new System.EventHandler(this.TxtKBruto_Click);
            this.TxtKBruto.TextChanged += new System.EventHandler(this.TxtKBruto_TextChanged);
            this.TxtKBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKBruto_KeyPress);
            this.TxtKBruto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKBruto_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(256, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 142;
            this.label8.Text = "KG Neto";
            // 
            // TxtkNeto
            // 
            this.TxtkNeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtkNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtkNeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.TxtkNeto.Location = new System.Drawing.Point(252, 78);
            this.TxtkNeto.Name = "TxtkNeto";
            this.TxtkNeto.ReadOnly = true;
            this.TxtkNeto.Size = new System.Drawing.Size(87, 24);
            this.TxtkNeto.TabIndex = 141;
            this.TxtkNeto.Text = "0";
            this.TxtkNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(168, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 144;
            this.label9.Text = "Tara";
            // 
            // TxtTara
            // 
            this.TxtTara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.TxtTara.Location = new System.Drawing.Point(159, 78);
            this.TxtTara.Name = "TxtTara";
            this.TxtTara.Size = new System.Drawing.Size(87, 24);
            this.TxtTara.TabIndex = 143;
            this.TxtTara.Text = "0";
            this.TxtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTara.Click += new System.EventHandler(this.TxtTara_Click);
            this.TxtTara.TextChanged += new System.EventHandler(this.TxtTara_TextChanged);
            this.TxtTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTara_KeyPress);
            this.TxtTara.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTara_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.label10.Location = new System.Drawing.Point(4, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 146;
            this.label10.Text = "Almacen:";
            // 
            // CmbAlmacen
            // 
            this.CmbAlmacen.Enabled = false;
            this.CmbAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.CmbAlmacen.FormattingEnabled = true;
            this.CmbAlmacen.Location = new System.Drawing.Point(4, 187);
            this.CmbAlmacen.Name = "CmbAlmacen";
            this.CmbAlmacen.Size = new System.Drawing.Size(348, 24);
            this.CmbAlmacen.TabIndex = 145;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.groupBox1.Controls.Add(this.ChekFUni);
            this.groupBox1.Controls.Add(this.ChekManual);
            this.groupBox1.Controls.Add(this.ChekFTara);
            this.groupBox1.Controls.Add(this.BtnBalanzaAceptar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtKBruto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.TxtkNeto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtTara);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 160);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BALANZA";
            // 
            // ChekFUni
            // 
            this.ChekFUni.AutoSize = true;
            this.ChekFUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChekFUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChekFUni.Location = new System.Drawing.Point(46, 54);
            this.ChekFUni.Name = "ChekFUni";
            this.ChekFUni.Size = new System.Drawing.Size(12, 11);
            this.ChekFUni.TabIndex = 152;
            this.ChekFUni.UseVisualStyleBackColor = true;
            this.ChekFUni.CheckedChanged += new System.EventHandler(this.ChekFUni_CheckedChanged);
            // 
            // ChekManual
            // 
            this.ChekManual.AutoSize = true;
            this.ChekManual.Location = new System.Drawing.Point(282, 14);
            this.ChekManual.Name = "ChekManual";
            this.ChekManual.Size = new System.Drawing.Size(61, 17);
            this.ChekManual.TabIndex = 151;
            this.ChekManual.Text = "Manual";
            this.ChekManual.UseVisualStyleBackColor = true;
            // 
            // ChekFTara
            // 
            this.ChekFTara.AutoSize = true;
            this.ChekFTara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChekFTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChekFTara.Location = new System.Drawing.Point(216, 55);
            this.ChekFTara.Name = "ChekFTara";
            this.ChekFTara.Size = new System.Drawing.Size(12, 11);
            this.ChekFTara.TabIndex = 150;
            this.ChekFTara.UseVisualStyleBackColor = true;
            this.ChekFTara.CheckedChanged += new System.EventHandler(this.ChekFTara_CheckedChanged);
            // 
            // BtnBalanzaAceptar
            // 
            this.BtnBalanzaAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBalanzaAceptar.BackColor = System.Drawing.Color.White;
            this.BtnBalanzaAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBalanzaAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBalanzaAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.BtnBalanzaAceptar.Image = global::LOSCALVOS.Properties.Resources.aceptarBlanco;
            this.BtnBalanzaAceptar.Location = new System.Drawing.Point(95, 126);
            this.BtnBalanzaAceptar.Name = "BtnBalanzaAceptar";
            this.BtnBalanzaAceptar.Size = new System.Drawing.Size(157, 28);
            this.BtnBalanzaAceptar.TabIndex = 148;
            this.BtnBalanzaAceptar.Text = "&Aceptar";
            this.BtnBalanzaAceptar.UseVisualStyleBackColor = false;
            this.BtnBalanzaAceptar.Click += new System.EventHandler(this.BtnBalanzaAceptar_Click);
            // 
            // ChekFLote
            // 
            this.ChekFLote.AutoSize = true;
            this.ChekFLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChekFLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.ChekFLote.Location = new System.Drawing.Point(337, 348);
            this.ChekFLote.Name = "ChekFLote";
            this.ChekFLote.Size = new System.Drawing.Size(15, 14);
            this.ChekFLote.TabIndex = 151;
            this.ChekFLote.UseVisualStyleBackColor = true;
            // 
            // DtProduccion
            // 
            this.DtProduccion.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.DtProduccion.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.DtProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtProduccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtProduccion.Location = new System.Drawing.Point(4, 83);
            this.DtProduccion.Name = "DtProduccion";
            this.DtProduccion.Size = new System.Drawing.Size(144, 29);
            this.DtProduccion.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(4, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 153;
            this.label3.Text = "Fecha de Producción";
            // 
            // Dgprincipal
            // 
            this.Dgprincipal.AllowUserToAddRows = false;
            this.Dgprincipal.AllowUserToDeleteRows = false;
            this.Dgprincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.Dgprincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgprincipal.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Dgprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgprincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linea,
            this.Lote,
            this.Fecha,
            this.Hora,
            this.blanco,
            this.barra,
            this.Kilos,
            this.categoria,
            this.codbar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(358, 29);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.RowHeadersWidth = 25;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgprincipal.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(670, 669);
            this.Dgprincipal.TabIndex = 154;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "ID";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Visible = false;
            this.Linea.Width = 50;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "COD";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Width = 60;
            // 
            // Fecha
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fecha.HeaderText = "DESCRIPCION";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 180;
            // 
            // Hora
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Hora.DefaultCellStyle = dataGridViewCellStyle4;
            this.Hora.HeaderText = "  LOTE";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 70;
            // 
            // blanco
            // 
            this.blanco.HeaderText = "UNI";
            this.blanco.Name = "blanco";
            this.blanco.ReadOnly = true;
            this.blanco.Width = 50;
            // 
            // barra
            // 
            this.barra.HeaderText = "BRUTO";
            this.barra.Name = "barra";
            this.barra.ReadOnly = true;
            this.barra.Width = 60;
            // 
            // Kilos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Kilos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Kilos.HeaderText = "TARA";
            this.Kilos.Name = "Kilos";
            this.Kilos.ReadOnly = true;
            this.Kilos.Width = 50;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "NETO";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 60;
            // 
            // codbar
            // 
            this.codbar.HeaderText = "CODBAR";
            this.codbar.Name = "codbar";
            this.codbar.ReadOnly = true;
            this.codbar.Width = 120;
            // 
            // ChekFprod
            // 
            this.ChekFprod.AutoSize = true;
            this.ChekFprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChekFprod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.ChekFprod.Location = new System.Drawing.Point(337, 298);
            this.ChekFprod.Name = "ChekFprod";
            this.ChekFprod.Size = new System.Drawing.Size(15, 14);
            this.ChekFprod.TabIndex = 155;
            this.ChekFprod.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtBuscar);
            this.panel1.Location = new System.Drawing.Point(4, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 24);
            this.panel1.TabIndex = 156;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.LavenderBlush;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtBuscar.Location = new System.Drawing.Point(0, 0);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.ReadOnly = true;
            this.TxtBuscar.Size = new System.Drawing.Size(303, 24);
            this.TxtBuscar.TabIndex = 10;
            // 
            // TxtCodProd
            // 
            this.TxtCodProd.Location = new System.Drawing.Point(79, 269);
            this.TxtCodProd.Name = "TxtCodProd";
            this.TxtCodProd.Size = new System.Drawing.Size(100, 20);
            this.TxtCodProd.TabIndex = 157;
            this.TxtCodProd.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::LOSCALVOS.Properties.Resources.search_30;
            this.button1.Location = new System.Drawing.Point(151, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 129;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscarProd
            // 
            this.BtnBuscarProd.AccessibleName = "";
            this.BtnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.BtnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProd.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProd.Image = global::LOSCALVOS.Properties.Resources.search_30;
            this.BtnBuscarProd.Location = new System.Drawing.Point(308, 292);
            this.BtnBuscarProd.Name = "BtnBuscarProd";
            this.BtnBuscarProd.Size = new System.Drawing.Size(23, 23);
            this.BtnBuscarProd.TabIndex = 158;
            this.BtnBuscarProd.Tag = "";
            this.BtnBuscarProd.UseVisualStyleBackColor = false;
            this.BtnBuscarProd.Click += new System.EventHandler(this.BtnBuscarProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(19)))), ((int)(((byte)(76)))));
            this.pictureBox1.Image = global::LOSCALVOS.Properties.Resources.utilidades;
            this.pictureBox1.Location = new System.Drawing.Point(977, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FrmControlDeProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuscarProd);
            this.Controls.Add(this.TxtCodProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChekFprod);
            this.Controls.Add(this.Dgprincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtProduccion);
            this.Controls.Add(this.ChekFLote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbAlmacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdProceso);
            this.Controls.Add(this.TxtLote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControlDeProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarItem";
            this.Load += new System.EventHandler(this.FrmAddGrupoFamilia_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem mnuevo;
        private System.Windows.Forms.ToolStripMenuItem mmodificar;
        private System.Windows.Forms.ToolStripMenuItem meliminar;
        private System.Windows.Forms.ToolStripMenuItem mimprimir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmdProceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmdSector;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKBruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtkNeto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbAlmacen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChekManual;
        private System.Windows.Forms.CheckBox ChekFTara;
        private System.Windows.Forms.Button BtnBalanzaAceptar;
        private System.Windows.Forms.CheckBox ChekFLote;
        private System.Windows.Forms.DateTimePicker DtProduccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn blanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codbar;
        private System.Windows.Forms.CheckBox ChekFUni;
        private System.Windows.Forms.CheckBox ChekFprod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TextBox TxtCodProd;
        private System.Windows.Forms.Button BtnBuscarProd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}