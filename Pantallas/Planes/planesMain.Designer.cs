namespace PrototipoGym.Pantallas.Planes
{
    partial class planesMain
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
            this.buscarPlanPanel = new System.Windows.Forms.Panel();
            this.nuevoPlanBtn = new System.Windows.Forms.Button();
            this.modificarPlanBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generarCuota = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarPlanPanel
            // 
            this.buscarPlanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscarPlanPanel.Location = new System.Drawing.Point(32, 80);
            this.buscarPlanPanel.Margin = new System.Windows.Forms.Padding(2, 2, 30, 2);
            this.buscarPlanPanel.Name = "buscarPlanPanel";
            this.buscarPlanPanel.Size = new System.Drawing.Size(1156, 658);
            this.buscarPlanPanel.TabIndex = 0;
            this.buscarPlanPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buscarPlanPanel_Paint);
            // 
            // nuevoPlanBtn
            // 
            this.nuevoPlanBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nuevoPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoPlanBtn.Location = new System.Drawing.Point(2, 58);
            this.nuevoPlanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nuevoPlanBtn.Name = "nuevoPlanBtn";
            this.nuevoPlanBtn.Size = new System.Drawing.Size(155, 102);
            this.nuevoPlanBtn.TabIndex = 1;
            this.nuevoPlanBtn.Text = "Nuevo Plan";
            this.nuevoPlanBtn.UseVisualStyleBackColor = true;
            this.nuevoPlanBtn.Click += new System.EventHandler(this.nuevoPlanBtn_Click);
            // 
            // modificarPlanBtn
            // 
            this.modificarPlanBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modificarPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarPlanBtn.Location = new System.Drawing.Point(2, 276);
            this.modificarPlanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modificarPlanBtn.Name = "modificarPlanBtn";
            this.modificarPlanBtn.Size = new System.Drawing.Size(155, 102);
            this.modificarPlanBtn.TabIndex = 2;
            this.modificarPlanBtn.Text = "Modificar Plan";
            this.modificarPlanBtn.UseVisualStyleBackColor = true;
            this.modificarPlanBtn.Click += new System.EventHandler(this.modificarPlanBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volverBtn.BackColor = System.Drawing.Color.Red;
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volverBtn.Location = new System.Drawing.Point(32, 773);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(142, 60);
            this.volverBtn.TabIndex = 3;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = false;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Planes";
            // 
            // generarCuota
            // 
            this.generarCuota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.generarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarCuota.Location = new System.Drawing.Point(2, 495);
            this.generarCuota.Margin = new System.Windows.Forms.Padding(2);
            this.generarCuota.Name = "generarCuota";
            this.generarCuota.Size = new System.Drawing.Size(155, 102);
            this.generarCuota.TabIndex = 6;
            this.generarCuota.Text = "Generar Cuota";
            this.generarCuota.UseVisualStyleBackColor = true;
            this.generarCuota.Click += new System.EventHandler(this.generarCuota_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.87249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12751F));
            this.tableLayoutPanel1.Controls.Add(this.buscarPlanPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.volverBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 10, 60, 10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.320726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.33283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34645F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1443, 845);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nuevoPlanBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.generarCuota, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.modificarPlanBtn, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1221, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(159, 656);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // planesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 845);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "planesMain";
            this.Text = "planesMain";
            this.Load += new System.EventHandler(this.planesMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buscarPlanPanel;
        private System.Windows.Forms.Button nuevoPlanBtn;
        private System.Windows.Forms.Button modificarPlanBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarCuota;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}