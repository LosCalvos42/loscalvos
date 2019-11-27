namespace TRAZAAR
{
    partial class FrmGrillaBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgprincipal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(14, 40);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.ReadOnly = true;
            this.Dgprincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgprincipal.RowHeadersVisible = false;
            this.Dgprincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgprincipal.Size = new System.Drawing.Size(561, 320);
            this.Dgprincipal.TabIndex = 0;
            this.Dgprincipal.DoubleClick += new System.EventHandler(this.Dgprincipal_DoubleClick);
            this.Dgprincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgprincipal_KeyDown);
            this.Dgprincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgprincipal_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.pBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 24);
            this.panel1.TabIndex = 20;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBuscar.Location = new System.Drawing.Point(-1, -1);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(391, 24);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pBuscar
            // 
            this.pBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBuscar.Image = global::TRAZAAR.Properties.Resources.search_32;
            this.pBuscar.Location = new System.Drawing.Point(390, -2);
            this.pBuscar.Name = "pBuscar";
            this.pBuscar.Size = new System.Drawing.Size(26, 25);
            this.pBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBuscar.TabIndex = 2;
            this.pBuscar.TabStop = false;
            this.pBuscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBuscar_MouseDown);
            this.pBuscar.MouseLeave += new System.EventHandler(this.pBuscar_MouseLeave);
            this.pBuscar.MouseHover += new System.EventHandler(this.pBuscar_MouseHover);
            this.pBuscar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBuscar_MouseUp);
            // 
            // FrmGrillaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGrillaBuscar";
            this.Text = "FrmGrillaBuscar";
            this.Load += new System.EventHandler(this.FrmGrillaBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pBuscar;
    }
}