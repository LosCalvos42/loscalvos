namespace Alberdi
{
    partial class frmSelecHJamon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecHJamon));
            this.dtgpro = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOJAMON_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpro)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgpro
            // 
            this.dtgpro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtgpro.AllowUserToAddRows = false;
            this.dtgpro.AllowUserToDeleteRows = false;
            this.dtgpro.AllowUserToResizeColumns = false;
            this.dtgpro.AllowUserToResizeRows = false;
            this.dtgpro.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtgpro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgpro.CausesValidation = false;
            this.dtgpro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgpro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgpro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fch,
            this.lote,
            this.TIPOJAMON_ID,
            this.peso,
            this.estado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgpro.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgpro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgpro.EnableHeadersVisualStyles = false;
            this.dtgpro.GridColor = System.Drawing.Color.LightGray;
            this.dtgpro.Location = new System.Drawing.Point(40, 60);
            this.dtgpro.MultiSelect = false;
            this.dtgpro.Name = "dtgpro";
            this.dtgpro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgpro.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgpro.RowHeadersWidth = 15;
            this.dtgpro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgpro.Size = new System.Drawing.Size(463, 275);
            this.dtgpro.TabIndex = 41;
            this.dtgpro.DoubleClick += new System.EventHandler(this.dtgpro_DoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // fch
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fch.DefaultCellStyle = dataGridViewCellStyle2;
            this.fch.HeaderText = "fecha";
            this.fch.Name = "fch";
            // 
            // lote
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.lote.DefaultCellStyle = dataGridViewCellStyle3;
            this.lote.HeaderText = "N° Proceso";
            this.lote.Name = "lote";
            this.lote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lote.Width = 110;
            // 
            // TIPOJAMON_ID
            // 
            this.TIPOJAMON_ID.HeaderText = "T_ID";
            this.TIPOJAMON_ID.Name = "TIPOJAMON_ID";
            this.TIPOJAMON_ID.Visible = false;
            // 
            // peso
            // 
            this.peso.HeaderText = "T. de Jamón";
            this.peso.Name = "peso";
            this.peso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.peso.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(36, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Fecha:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblfecha.Location = new System.Drawing.Point(104, 29);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(89, 19);
            this.lblfecha.TabIndex = 43;
            this.lblfecha.Text = "18/12/2017";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Red;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.Location = new System.Drawing.Point(422, 349);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(81, 30);
            this.Salir.TabIndex = 44;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // frmSelecHJamon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 391);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgpro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelecHJamon";
            this.Text = "Procesos por Fecha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelecHJamon_FormClosed);
            this.Load += new System.EventHandler(this.frmSelecHJamon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgpro;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fch;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOJAMON_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button Salir;
    }
}