namespace PrototipoGym.Pantallas
{
    partial class GenerarTipoMovimiento
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
            this.detalleLb = new System.Windows.Forms.Label();
            this.tipoLbl = new System.Windows.Forms.Label();
            this.detalleTb = new System.Windows.Forms.TextBox();
            this.debeCheckBox = new System.Windows.Forms.CheckBox();
            this.reditoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrarMovmientoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detalleLb
            // 
            this.detalleLb.AutoSize = true;
            this.detalleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleLb.Location = new System.Drawing.Point(102, 123);
            this.detalleLb.Name = "detalleLb";
            this.detalleLb.Size = new System.Drawing.Size(78, 25);
            this.detalleLb.TabIndex = 0;
            this.detalleLb.Text = "Detalle:";
            // 
            // tipoLbl
            // 
            this.tipoLbl.AutoSize = true;
            this.tipoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLbl.Location = new System.Drawing.Point(102, 200);
            this.tipoLbl.Name = "tipoLbl";
            this.tipoLbl.Size = new System.Drawing.Size(57, 25);
            this.tipoLbl.TabIndex = 1;
            this.tipoLbl.Text = "Tipo:";
            // 
            // detalleTb
            // 
            this.detalleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleTb.Location = new System.Drawing.Point(214, 118);
            this.detalleTb.Name = "detalleTb";
            this.detalleTb.Size = new System.Drawing.Size(230, 30);
            this.detalleTb.TabIndex = 3;
            // 
            // debeCheckBox
            // 
            this.debeCheckBox.AutoSize = true;
            this.debeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debeCheckBox.Location = new System.Drawing.Point(214, 200);
            this.debeCheckBox.Name = "debeCheckBox";
            this.debeCheckBox.Size = new System.Drawing.Size(81, 29);
            this.debeCheckBox.TabIndex = 4;
            this.debeCheckBox.Text = "Debe";
            this.debeCheckBox.UseVisualStyleBackColor = true;
            this.debeCheckBox.CheckedChanged += new System.EventHandler(this.debeCheckBox_CheckedChanged);
            // 
            // reditoCheckBox
            // 
            this.reditoCheckBox.AutoSize = true;
            this.reditoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reditoCheckBox.Location = new System.Drawing.Point(355, 200);
            this.reditoCheckBox.Name = "reditoCheckBox";
            this.reditoCheckBox.Size = new System.Drawing.Size(89, 29);
            this.reditoCheckBox.TabIndex = 5;
            this.reditoCheckBox.Text = "Redito";
            this.reditoCheckBox.UseVisualStyleBackColor = true;
            this.reditoCheckBox.CheckedChanged += new System.EventHandler(this.reditoCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificador: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registrarMovmientoBtn
            // 
            this.registrarMovmientoBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.registrarMovmientoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarMovmientoBtn.Location = new System.Drawing.Point(511, 304);
            this.registrarMovmientoBtn.Name = "registrarMovmientoBtn";
            this.registrarMovmientoBtn.Size = new System.Drawing.Size(122, 41);
            this.registrarMovmientoBtn.TabIndex = 7;
            this.registrarMovmientoBtn.Text = "Registrar";
            this.registrarMovmientoBtn.UseVisualStyleBackColor = false;
            this.registrarMovmientoBtn.Click += new System.EventHandler(this.registrarMovmientoBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Generar Tipo de Movimiento";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(40, 304);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(106, 41);
            this.cancelarBtn.TabIndex = 9;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // GenerarTipoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 365);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrarMovmientoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reditoCheckBox);
            this.Controls.Add(this.debeCheckBox);
            this.Controls.Add(this.detalleTb);
            this.Controls.Add(this.tipoLbl);
            this.Controls.Add(this.detalleLb);
            this.Name = "GenerarTipoMovimiento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GenerarTipoMovimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detalleLb;
        private System.Windows.Forms.Label tipoLbl;
        private System.Windows.Forms.TextBox detalleTb;
        private System.Windows.Forms.CheckBox debeCheckBox;
        private System.Windows.Forms.CheckBox reditoCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrarMovmientoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelarBtn;
    }
}