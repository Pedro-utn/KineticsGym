namespace PrototipoGym.Pantallas
{
    partial class BuscarCliente
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
            this.buscarClienteTb = new System.Windows.Forms.TextBox();
            this.clientesDataGrid = new System.Windows.Forms.DataGridView();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarClienteTb
            // 
            this.buscarClienteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarClienteTb.Location = new System.Drawing.Point(0, 1);
            this.buscarClienteTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscarClienteTb.Name = "buscarClienteTb";
            this.buscarClienteTb.Size = new System.Drawing.Size(373, 35);
            this.buscarClienteTb.TabIndex = 0;
            // 
            // clientesDataGrid
            // 
            this.clientesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGrid.Location = new System.Drawing.Point(0, 64);
            this.clientesDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientesDataGrid.Name = "clientesDataGrid";
            this.clientesDataGrid.RowHeadersWidth = 51;
            this.clientesDataGrid.RowTemplate.Height = 24;
            this.clientesDataGrid.Size = new System.Drawing.Size(945, 512);
            this.clientesDataGrid.TabIndex = 1;
            this.clientesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGrid_CellContentClick);
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.seleccionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seleccionarBtn.Location = new System.Drawing.Point(789, 2);
            this.seleccionarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(155, 37);
            this.seleccionarBtn.TabIndex = 2;
            this.seleccionarBtn.Text = "Seleccionar";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click_1);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(612, 2);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(122, 38);
            this.cancelarBtn.TabIndex = 3;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 575);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.clientesDataGrid);
            this.Controls.Add(this.buscarClienteTb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscarClienteTb;
        private System.Windows.Forms.DataGridView clientesDataGrid;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}