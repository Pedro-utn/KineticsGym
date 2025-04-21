namespace PrototipoGym.Pantallas.Buscar
{
    partial class BuscarTipoMov
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
            this.tipoMovTb = new System.Windows.Forms.TextBox();
            this.tipoMovDataGrid = new System.Windows.Forms.DataGridView();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoMovTb
            // 
            this.tipoMovTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoMovTb.Location = new System.Drawing.Point(4, 2);
            this.tipoMovTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoMovTb.Name = "tipoMovTb";
            this.tipoMovTb.Size = new System.Drawing.Size(368, 35);
            this.tipoMovTb.TabIndex = 0;
            // 
            // tipoMovDataGrid
            // 
            this.tipoMovDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipoMovDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoMovDataGrid.Location = new System.Drawing.Point(4, 94);
            this.tipoMovDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoMovDataGrid.Name = "tipoMovDataGrid";
            this.tipoMovDataGrid.RowHeadersWidth = 51;
            this.tipoMovDataGrid.RowTemplate.Height = 24;
            this.tipoMovDataGrid.Size = new System.Drawing.Size(780, 417);
            this.tipoMovDataGrid.TabIndex = 1;
            this.tipoMovDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tipoMovDataGrid_CellContentClick);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(474, 3);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(126, 33);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.seleccionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarBtn.Location = new System.Drawing.Point(623, 2);
            this.seleccionarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(153, 33);
            this.seleccionarBtn.TabIndex = 3;
            this.seleccionarBtn.Text = "Seleccionar";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click_1);
            // 
            // BuscarTipoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 521);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.tipoMovDataGrid);
            this.Controls.Add(this.tipoMovTb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscarTipoMov";
            this.Text = "BuscarTipoMov";
            this.Load += new System.EventHandler(this.BuscarTipoMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tipoMovTb;
        private System.Windows.Forms.DataGridView tipoMovDataGrid;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button seleccionarBtn;
    }
}