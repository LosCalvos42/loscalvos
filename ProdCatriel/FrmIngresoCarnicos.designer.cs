namespace TRAZAAR
{
    partial class FrmIngresoCarnicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoCarnicos));
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtRDesde = new System.Windows.Forms.DateTimePicker();
            this.dtRHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbGrupo = new System.Windows.Forms.ComboBox();
            this.btnBuscarF = new System.Windows.Forms.Button();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.MenuCopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGProdOc = new System.Windows.Forms.DataGridView();
            this.menuForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            this.MenuCopyPaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProdOc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mimprimir,
            this.salirToolStripMenuItem});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(1262, 26);
            this.menuForm.TabIndex = 3;
            this.menuForm.Text = "Menu";
            // 
            // mimprimir
            // 
            this.mimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mimprimir.ForeColor = System.Drawing.Color.White;
            this.mimprimir.Image = global::TRAZAAR.Properties.Resources.icons8_print_48;
            this.mimprimir.Name = "mimprimir";
            this.mimprimir.Size = new System.Drawing.Size(89, 22);
            this.mimprimir.Text = "Imprimir";
            this.mimprimir.Click += new System.EventHandler(this.mimprimir_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::TRAZAAR.Properties.Resources.icons8_shutdown_30;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dtRDesde
            // 
            this.dtRDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRDesde.Location = new System.Drawing.Point(9, 35);
            this.dtRDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRDesde.Name = "dtRDesde";
            this.dtRDesde.Size = new System.Drawing.Size(102, 22);
            this.dtRDesde.TabIndex = 44;
            this.dtRDesde.ValueChanged += new System.EventHandler(this.dtRDesde_ValueChanged);
            // 
            // dtRHasta
            // 
            this.dtRHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRHasta.Location = new System.Drawing.Point(119, 35);
            this.dtRHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRHasta.Name = "dtRHasta";
            this.dtRHasta.Size = new System.Drawing.Size(104, 22);
            this.dtRHasta.TabIndex = 45;
            this.dtRHasta.ValueChanged += new System.EventHandler(this.dtRHasta_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Ingreso Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Ingreso Hasta:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.LblTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbGrupo);
            this.groupBox1.Controls.Add(this.btnBuscarF);
            this.groupBox1.Controls.Add(this.dtRHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtRDesde);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 71);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(958, 37);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(0, 18);
            this.LblTotal.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(575, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "Producto:";
            // 
            // CmbProducto
            // 
            this.CmbProducto.DropDownWidth = 300;
            this.CmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProducto.FormattingEnabled = true;
            this.CmbProducto.Location = new System.Drawing.Point(579, 34);
            this.CmbProducto.Name = "CmbProducto";
            this.CmbProducto.Size = new System.Drawing.Size(233, 23);
            this.CmbProducto.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(337, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Proveedor:";
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.DropDownWidth = 300;
            this.CmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProveedor.FormattingEnabled = true;
            this.CmbProveedor.Location = new System.Drawing.Point(340, 34);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Size = new System.Drawing.Size(233, 23);
            this.CmbProveedor.TabIndex = 99;
            this.CmbProveedor.SelectionChangeCommitted += new System.EventHandler(this.CmbProveedor_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(229, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Grupo:";
            // 
            // CmbGrupo
            // 
            this.CmbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGrupo.FormattingEnabled = true;
            this.CmbGrupo.Items.AddRange(new object[] {
            "CONGELADO",
            "FRESCO"});
            this.CmbGrupo.Location = new System.Drawing.Point(232, 34);
            this.CmbGrupo.Name = "CmbGrupo";
            this.CmbGrupo.Size = new System.Drawing.Size(102, 23);
            this.CmbGrupo.TabIndex = 97;
            this.CmbGrupo.SelectionChangeCommitted += new System.EventHandler(this.CmbGrupo_SelectionChangeCommitted);
            // 
            // btnBuscarF
            // 
            this.btnBuscarF.AccessibleName = "";
            this.btnBuscarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnBuscarF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarF.ForeColor = System.Drawing.Color.White;
            this.btnBuscarF.Image = global::TRAZAAR.Properties.Resources.icons8_search_property_22__3_;
            this.btnBuscarF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarF.Location = new System.Drawing.Point(818, 33);
            this.btnBuscarF.Name = "btnBuscarF";
            this.btnBuscarF.Size = new System.Drawing.Size(88, 24);
            this.btnBuscarF.TabIndex = 96;
            this.btnBuscarF.Tag = "";
            this.btnBuscarF.Text = "&Buscar";
            this.btnBuscarF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarF.UseVisualStyleBackColor = false;
            this.btnBuscarF.Click += new System.EventHandler(this.btnBuscarF_Click);
            // 
            // Dgprincipal
            // 
            this.Dgprincipal.AllowUserToAddRows = false;
            this.Dgprincipal.AllowUserToDeleteRows = false;
            this.Dgprincipal.AllowUserToResizeColumns = false;
            this.Dgprincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.Dgprincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgprincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgprincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgprincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgprincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgprincipal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.Dgprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgprincipal.ContextMenuStrip = this.MenuCopyPaste;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(3, 108);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(1184, 438);
            this.Dgprincipal.TabIndex = 41;
            this.Dgprincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgprincipal_CellContentClick);
            this.Dgprincipal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgprincipal_CellFormatting);
            this.Dgprincipal.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgprincipal_CellMouseMove);
            this.Dgprincipal.Sorted += new System.EventHandler(this.Dgprincipal_Sorted);
            // 
            // MenuCopyPaste
            // 
            this.MenuCopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.MenuCopyPaste.Name = "MenuCopyPaste";
            this.MenuCopyPaste.Size = new System.Drawing.Size(170, 26);
            this.MenuCopyPaste.Click += new System.EventHandler(this.MenuCopyPaste_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyToolStripMenuItem.Text = "&Copy            Ctl+C";
            // 
            // DGProdOc
            // 
            this.DGProdOc.AllowUserToAddRows = false;
            this.DGProdOc.AllowUserToDeleteRows = false;
            this.DGProdOc.AllowUserToResizeColumns = false;
            this.DGProdOc.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.DGProdOc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGProdOc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGProdOc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGProdOc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGProdOc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGProdOc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGProdOc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGProdOc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProdOc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGProdOc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGProdOc.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGProdOc.EnableHeadersVisualStyles = false;
            this.DGProdOc.Location = new System.Drawing.Point(1143, 108);
            this.DGProdOc.Name = "DGProdOc";
            this.DGProdOc.ReadOnly = true;
            this.DGProdOc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGProdOc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGProdOc.RowHeadersVisible = false;
            this.DGProdOc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGProdOc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGProdOc.Size = new System.Drawing.Size(107, 473);
            this.DGProdOc.TabIndex = 97;
            this.DGProdOc.Visible = false;
            // 
            // FrmIngresoCarnicos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 593);
            this.Controls.Add(this.Dgprincipal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuForm);
            this.Controls.Add(this.DGProdOc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIngresoCarnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso A Planta (MP Cárnica)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCargaDeMuestras_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.MenuCopyPaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGProdOc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem mimprimir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtRDesde;
        private System.Windows.Forms.DateTimePicker dtRHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbGrupo;
        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.DataGridView DGProdOc;
        private System.Windows.Forms.ContextMenuStrip MenuCopyPaste;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Label LblTotal;
    }
}