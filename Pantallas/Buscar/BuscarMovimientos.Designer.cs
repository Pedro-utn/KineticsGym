namespace PrototipoGym.Pantallas.Buscar
{
    partial class BuscarMovimientos
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
            this.movimientosDataGrid = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // movimientosDataGrid
            // 
            this.movimientosDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.movimientosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movimientosDataGrid.Location = new System.Drawing.Point(10, 63);
            this.movimientosDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movimientosDataGrid.Name = "movimientosDataGrid";
            this.movimientosDataGrid.RowHeadersWidth = 51;
            this.movimientosDataGrid.RowTemplate.Height = 24;
            this.movimientosDataGrid.Size = new System.Drawing.Size(566, 317);
            this.movimientosDataGrid.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(10, 2);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(341, 35);
            this.txtBusqueda.TabIndex = 1;
            // 
            // BuscarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 389);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.movimientosDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscarMovimientos";
            this.Text = "BuscarMovimientos";
            this.Load += new System.EventHandler(this.BuscarMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimientosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movimientosDataGrid;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}