namespace PrototipoGym.Pantallas
{
    partial class BuscarPlan
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.planesDataGrid = new System.Windows.Forms.DataGridView();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(9, 0);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(354, 35);
            this.txtBusqueda.TabIndex = 0;
            // 
            // planesDataGrid
            // 
            this.planesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.planesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planesDataGrid.Location = new System.Drawing.Point(9, 63);
            this.planesDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planesDataGrid.Name = "planesDataGrid";
            this.planesDataGrid.RowHeadersWidth = 51;
            this.planesDataGrid.RowTemplate.Height = 24;
            this.planesDataGrid.Size = new System.Drawing.Size(1016, 491);
            this.planesDataGrid.TabIndex = 1;
            this.planesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planesDataGrid_CellContentClick);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(680, 0);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(128, 38);
            this.cancelarBtn.TabIndex = 2;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.seleccionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarBtn.Location = new System.Drawing.Point(872, 0);
            this.seleccionarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(155, 38);
            this.seleccionarBtn.TabIndex = 3;
            this.seleccionarBtn.Text = "Seleccionar";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click);
            // 
            // BuscarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 554);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.planesDataGrid);
            this.Controls.Add(this.txtBusqueda);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscarPlan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BuscarPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView planesDataGrid;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button seleccionarBtn;
    }
}