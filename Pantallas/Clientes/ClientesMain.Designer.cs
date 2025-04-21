namespace PrototipoGym.Pantallas
{
    partial class Clientes
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
            this.buscarClientePanel = new System.Windows.Forms.Panel();
            this.volverBtn = new System.Windows.Forms.Button();
            this.nuevoClienteBtn = new System.Windows.Forms.Button();
            this.mostrarCuentaBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generarCuotaBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarClientePanel
            // 
            this.buscarClientePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarClientePanel.Location = new System.Drawing.Point(2, 69);
            this.buscarClientePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscarClientePanel.Name = "buscarClientePanel";
            this.buscarClientePanel.Size = new System.Drawing.Size(1268, 674);
            this.buscarClientePanel.TabIndex = 0;
            this.buscarClientePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // volverBtn
            // 
            this.volverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volverBtn.BackColor = System.Drawing.Color.Red;
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.volverBtn.Location = new System.Drawing.Point(2, 783);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(144, 60);
            this.volverBtn.TabIndex = 1;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // nuevoClienteBtn
            // 
            this.nuevoClienteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nuevoClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoClienteBtn.Location = new System.Drawing.Point(2, 43);
            this.nuevoClienteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nuevoClienteBtn.Name = "nuevoClienteBtn";
            this.nuevoClienteBtn.Size = new System.Drawing.Size(161, 82);
            this.nuevoClienteBtn.TabIndex = 2;
            this.nuevoClienteBtn.Text = "Nuevo Cliente";
            this.nuevoClienteBtn.UseVisualStyleBackColor = true;
            this.nuevoClienteBtn.Click += new System.EventHandler(this.nuevoClienteBtn_Click);
            // 
            // mostrarCuentaBtn
            // 
            this.mostrarCuentaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mostrarCuentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarCuentaBtn.Location = new System.Drawing.Point(2, 543);
            this.mostrarCuentaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostrarCuentaBtn.Name = "mostrarCuentaBtn";
            this.mostrarCuentaBtn.Size = new System.Drawing.Size(161, 89);
            this.mostrarCuentaBtn.TabIndex = 2;
            this.mostrarCuentaBtn.Text = "Mostrar Cuenta";
            this.mostrarCuentaBtn.UseVisualStyleBackColor = true;
            this.mostrarCuentaBtn.Click += new System.EventHandler(this.mostrarCuentaBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.Location = new System.Drawing.Point(2, 207);
            this.modificarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(161, 89);
            this.modificarBtn.TabIndex = 4;
            this.modificarBtn.Text = "Modificar Cliente";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes";
            // 
            // generarCuotaBtn
            // 
            this.generarCuotaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generarCuotaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarCuotaBtn.Location = new System.Drawing.Point(2, 376);
            this.generarCuotaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generarCuotaBtn.Name = "generarCuotaBtn";
            this.generarCuotaBtn.Size = new System.Drawing.Size(161, 87);
            this.generarCuotaBtn.TabIndex = 6;
            this.generarCuotaBtn.Text = "Generar Cuota";
            this.generarCuotaBtn.UseVisualStyleBackColor = true;
            this.generarCuotaBtn.Click += new System.EventHandler(this.generarCuotaBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.14969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.85031F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.volverBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buscarClientePanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.047338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.35503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71598F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1443, 845);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nuevoClienteBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mostrarCuentaBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.generarCuotaBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.modificarBtn, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1275, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(165, 672);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 845);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buscarClientePanel;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button nuevoClienteBtn;
        private System.Windows.Forms.Button mostrarCuentaBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarCuotaBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}