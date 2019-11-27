namespace TRAZAAR
{
    partial class FrmTwinsIngresoXproveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTwinsIngresoXproveedor));
            this.DTD = new System.Windows.Forms.DateTimePicker();
            this.DTH = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mprima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DTD
            // 
            this.DTD.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.DTD.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DTD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTD.Location = new System.Drawing.Point(169, 30);
            this.DTD.Name = "DTD";
            this.DTD.Size = new System.Drawing.Size(111, 23);
            this.DTD.TabIndex = 0;
            // 
            // DTH
            // 
            this.DTH.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.DTH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTH.Location = new System.Drawing.Point(169, 59);
            this.DTH.Name = "DTH";
            this.DTH.Size = new System.Drawing.Size(111, 23);
            this.DTH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(66, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.Location = new System.Drawing.Point(865, 397);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(81, 30);
            this.Salir.TabIndex = 73;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBuscar.Location = new System.Drawing.Point(315, 43);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(145, 26);
            this.cmdBuscar.TabIndex = 74;
            this.cmdBuscar.Text = "&Buscar";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // dgDatos
            // 
            this.dgDatos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDatos.CausesValidation = false;
            this.dgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prov,
            this.mprima,
            this.kg});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDatos.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgDatos.EnableHeadersVisualStyles = false;
            this.dgDatos.GridColor = System.Drawing.Color.LightGray;
            this.dgDatos.Location = new System.Drawing.Point(72, 98);
            this.dgDatos.MultiSelect = false;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowHeadersWidth = 15;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(707, 329);
            this.dgDatos.TabIndex = 75;
            // 
            // prov
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Format = "d";
            dataGridViewCellStyle26.NullValue = null;
            this.prov.DefaultCellStyle = dataGridViewCellStyle26;
            this.prov.HeaderText = "Proveedor";
            this.prov.Name = "prov";
            this.prov.Width = 300;
            // 
            // mprima
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mprima.DefaultCellStyle = dataGridViewCellStyle27;
            this.mprima.HeaderText = "MateriaPrima";
            this.mprima.Name = "mprima";
            this.mprima.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mprima.Width = 250;
            // 
            // kg
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kg.DefaultCellStyle = dataGridViewCellStyle28;
            this.kg.HeaderText = "Kg";
            this.kg.Name = "kg";
            this.kg.Width = 140;
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
            this.print.Location = new System.Drawing.Point(880, 338);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(51, 53);
            this.print.TabIndex = 77;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(72, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 13);
            this.progressBar1.TabIndex = 78;
            // 
            // FrmTwinsIngresoXproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(894, 459);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTH);
            this.Controls.Add(this.DTD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTwinsIngresoXproveedor";
            this.Text = "FrmTwinsIngresoXproveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FrmTwinsIngresoXproveedor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTD;
        private System.Windows.Forms.DateTimePicker DTH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn mprima;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}