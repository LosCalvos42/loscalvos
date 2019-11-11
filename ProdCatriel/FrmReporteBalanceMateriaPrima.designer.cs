namespace Alberdi
{
    partial class FrmReporteBalanceMateriaPrima
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteBalanceMateriaPrima));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuForm = new System.Windows.Forms.MenuStrip();
            this.mnuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.meliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRDesde = new System.Windows.Forms.DateTimePicker();
            this.dtRHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarF = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngresosEgresos = new System.Windows.Forms.TextBox();
            this.txtStockF = new System.Windows.Forms.TextBox();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDife = new System.Windows.Forms.TextBox();
            this.print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RMovimiento = new System.Windows.Forms.RadioButton();
            this.RProducto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuForm
            // 
            this.menuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.menuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuevo,
            this.mmodificar,
            this.meliminar,
            this.mimprimir,
            this.salirToolStripMenuItem});
            this.menuForm.Location = new System.Drawing.Point(0, 0);
            this.menuForm.Name = "menuForm";
            this.menuForm.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuForm.Size = new System.Drawing.Size(1059, 26);
            this.menuForm.TabIndex = 3;
            this.menuForm.Text = "Menu";
            // 
            // mnuevo
            // 
            this.mnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuevo.ForeColor = System.Drawing.Color.White;
            this.mnuevo.Image = global::Alberdi.Properties.Resources.icons8_add_folder_64;
            this.mnuevo.Name = "mnuevo";
            this.mnuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mnuevo.Size = new System.Drawing.Size(79, 22);
            this.mnuevo.Text = "Nuevo";
            this.mnuevo.Click += new System.EventHandler(this.mnuevo_Click);
            // 
            // mmodificar
            // 
            this.mmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmodificar.ForeColor = System.Drawing.Color.White;
            this.mmodificar.Image = global::Alberdi.Properties.Resources.icons8_pencil_drawing_96;
            this.mmodificar.Name = "mmodificar";
            this.mmodificar.Size = new System.Drawing.Size(97, 22);
            this.mmodificar.Text = "Modificar";
            this.mmodificar.Click += new System.EventHandler(this.mmodificar_Click);
            // 
            // meliminar
            // 
            this.meliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meliminar.ForeColor = System.Drawing.Color.White;
            this.meliminar.Image = global::Alberdi.Properties.Resources.icons8_delete_file_128;
            this.meliminar.Name = "meliminar";
            this.meliminar.Size = new System.Drawing.Size(89, 22);
            this.meliminar.Text = "Eliminar";
            // 
            // mimprimir
            // 
            this.mimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mimprimir.ForeColor = System.Drawing.Color.White;
            this.mimprimir.Image = global::Alberdi.Properties.Resources.icons8_print_48;
            this.mimprimir.Name = "mimprimir";
            this.mimprimir.Size = new System.Drawing.Size(89, 22);
            this.mimprimir.Text = "Imprimir";
            this.mimprimir.Click += new System.EventHandler(this.mimprimir_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::Alberdi.Properties.Resources.icons8_shutdown_30;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Dgprincipal
            // 
            this.Dgprincipal.AllowUserToAddRows = false;
            this.Dgprincipal.AllowUserToDeleteRows = false;
            this.Dgprincipal.AllowUserToResizeColumns = false;
            this.Dgprincipal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dgprincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgprincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgprincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dgprincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgprincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupo,
            this.stockInicial,
            this.ingresos,
            this.egresos,
            this.stockf});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(160, 121);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(538, 141);
            this.Dgprincipal.TabIndex = 41;
            this.Dgprincipal.Sorted += new System.EventHandler(this.Dgprincipal_Sorted);
            this.Dgprincipal.DoubleClick += new System.EventHandler(this.Dgprincipal_DoubleClick);
            // 
            // grupo
            // 
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            this.grupo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stockInicial
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.stockInicial.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockInicial.HeaderText = "Stock Inicial";
            this.stockInicial.Name = "stockInicial";
            this.stockInicial.ReadOnly = true;
            this.stockInicial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stockInicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ingresos
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.ingresos.DefaultCellStyle = dataGridViewCellStyle4;
            this.ingresos.HeaderText = "Ingresos";
            this.ingresos.Name = "ingresos";
            this.ingresos.ReadOnly = true;
            this.ingresos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ingresos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ingresos.Width = 80;
            // 
            // egresos
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.egresos.DefaultCellStyle = dataGridViewCellStyle5;
            this.egresos.HeaderText = "Egresos";
            this.egresos.Name = "egresos";
            this.egresos.ReadOnly = true;
            this.egresos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.egresos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.egresos.Width = 80;
            // 
            // stockf
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.stockf.DefaultCellStyle = dataGridViewCellStyle6;
            this.stockf.HeaderText = "Stock Final";
            this.stockf.Name = "stockf";
            this.stockf.ReadOnly = true;
            this.stockf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stockf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stockf.Width = 155;
            // 
            // dtRDesde
            // 
            this.dtRDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRDesde.Location = new System.Drawing.Point(159, 40);
            this.dtRDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRDesde.Name = "dtRDesde";
            this.dtRDesde.Size = new System.Drawing.Size(122, 22);
            this.dtRDesde.TabIndex = 44;
            // 
            // dtRHasta
            // 
            this.dtRHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRHasta.Location = new System.Drawing.Point(307, 40);
            this.dtRHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtRHasta.Name = "dtRHasta";
            this.dtRHasta.Size = new System.Drawing.Size(122, 22);
            this.dtRHasta.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(156, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(304, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Hasta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarF);
            this.groupBox1.Controls.Add(this.dtRHasta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtRDesde);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 77);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Por Periodo";
            // 
            // btnBuscarF
            // 
            this.btnBuscarF.AccessibleName = "";
            this.btnBuscarF.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarF.Image = global::Alberdi.Properties.Resources.search_32;
            this.btnBuscarF.Location = new System.Drawing.Point(454, 40);
            this.btnBuscarF.Name = "btnBuscarF";
            this.btnBuscarF.Size = new System.Drawing.Size(25, 24);
            this.btnBuscarF.TabIndex = 96;
            this.btnBuscarF.Tag = "";
            this.btnBuscarF.UseVisualStyleBackColor = false;
            this.btnBuscarF.Click += new System.EventHandler(this.btnBuscarF_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.lbl2.Location = new System.Drawing.Point(353, 278);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(141, 16);
            this.lbl2.TabIndex = 98;
            this.lbl2.Text = "Stock Fin Del Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(154, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "S.Inicial + Ingresos - Egresos:";
            // 
            // txtIngresosEgresos
            // 
            this.txtIngresosEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.txtIngresosEgresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresosEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresosEgresos.Location = new System.Drawing.Point(239, 297);
            this.txtIngresosEgresos.Name = "txtIngresosEgresos";
            this.txtIngresosEgresos.ReadOnly = true;
            this.txtIngresosEgresos.Size = new System.Drawing.Size(98, 19);
            this.txtIngresosEgresos.TabIndex = 129;
            this.txtIngresosEgresos.TabStop = false;
            this.txtIngresosEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStockF
            // 
            this.txtStockF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.txtStockF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockF.Location = new System.Drawing.Point(356, 297);
            this.txtStockF.Name = "txtStockF";
            this.txtStockF.ReadOnly = true;
            this.txtStockF.Size = new System.Drawing.Size(97, 19);
            this.txtStockF.TabIndex = 130;
            this.txtStockF.TabStop = false;
            this.txtStockF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.txtDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiferencia.Location = new System.Drawing.Point(357, 334);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.ReadOnly = true;
            this.txtDiferencia.Size = new System.Drawing.Size(78, 19);
            this.txtDiferencia.TabIndex = 131;
            this.txtDiferencia.TabStop = false;
            this.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(167, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 134;
            this.label2.Text = "Diferencia:";
            // 
            // txtDife
            // 
            this.txtDife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.txtDife.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDife.Location = new System.Drawing.Point(239, 334);
            this.txtDife.Name = "txtDife";
            this.txtDife.ReadOnly = true;
            this.txtDife.Size = new System.Drawing.Size(98, 19);
            this.txtDife.TabIndex = 133;
            this.txtDife.TabStop = false;
            this.txtDife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // print
            // 
            this.print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.print.BackColor = System.Drawing.Color.GhostWhite;
            this.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.Lime;
            this.print.Image = ((System.Drawing.Image)(resources.GetObject("print.Image")));
            this.print.Location = new System.Drawing.Point(996, 469);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(51, 53);
            this.print.TabIndex = 135;
            this.print.UseVisualStyleBackColor = false;
            this.print.Visible = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(996, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 53);
            this.button1.TabIndex = 136;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(594, 278);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(347, 193);
            this.chart1.TabIndex = 139;
            this.chart1.Text = "chart1";
            // 
            // RMovimiento
            // 
            this.RMovimiento.AutoSize = true;
            this.RMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.RMovimiento.Location = new System.Drawing.Point(13, 66);
            this.RMovimiento.Name = "RMovimiento";
            this.RMovimiento.Size = new System.Drawing.Size(94, 20);
            this.RMovimiento.TabIndex = 141;
            this.RMovimiento.Text = "Movimiento";
            this.RMovimiento.UseVisualStyleBackColor = true;
            // 
            // RProducto
            // 
            this.RProducto.AutoSize = true;
            this.RProducto.Checked = true;
            this.RProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.RProducto.Location = new System.Drawing.Point(13, 30);
            this.RProducto.Name = "RProducto";
            this.RProducto.Size = new System.Drawing.Size(79, 20);
            this.RProducto.TabIndex = 140;
            this.RProducto.TabStop = true;
            this.RProducto.Text = "Producto";
            this.RProducto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RMovimiento);
            this.groupBox2.Controls.Add(this.RProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.groupBox2.Location = new System.Drawing.Point(707, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 112);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar detalle Ingresos/egresos";
            // 
            // FrmReporteBalanceMateriaPrima
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1059, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDife);
            this.Controls.Add(this.txtDiferencia);
            this.Controls.Add(this.txtStockF);
            this.Controls.Add(this.txtIngresosEgresos);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgprincipal);
            this.Controls.Add(this.menuForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReporteBalanceMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM-Muestras";
            this.Activated += new System.EventHandler(this.FrmCargaDeMuestras_Activated);
            this.Load += new System.EventHandler(this.FrmCargaDeMuestras_Load);
            this.menuForm.ResumeLayout(false);
            this.menuForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuForm;
        private System.Windows.Forms.ToolStripMenuItem mnuevo;
        private System.Windows.Forms.ToolStripMenuItem mmodificar;
        private System.Windows.Forms.ToolStripMenuItem meliminar;
        private System.Windows.Forms.ToolStripMenuItem mimprimir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.DateTimePicker dtRDesde;
        private System.Windows.Forms.DateTimePicker dtRHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarF;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngresosEgresos;
        private System.Windows.Forms.TextBox txtStockF;
        private System.Windows.Forms.TextBox txtDiferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDife;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockf;
        private System.Windows.Forms.RadioButton RMovimiento;
        private System.Windows.Forms.RadioButton RProducto;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}