using System.Windows.Forms;
using System;
using System.Drawing.Text;

namespace PrototipoGym.Pantallas
{
    partial class GenerarPlanes
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
            this.nombreLb = new System.Windows.Forms.Label();
            this.descripcionLb = new System.Windows.Forms.Label();
            this.generarPlanBtn = new System.Windows.Forms.Button();
            this.nombrePlanTb = new System.Windows.Forms.TextBox();
            this.descripcionTb = new System.Windows.Forms.TextBox();
            this.cuotaLb = new System.Windows.Forms.Label();
            this.cuotaTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idPlanLb = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLb
            // 
            this.nombreLb.AutoSize = true;
            this.nombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLb.Location = new System.Drawing.Point(134, 128);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(123, 25);
            this.nombreLb.TabIndex = 0;
            this.nombreLb.Text = "Nombre plan";
            // 
            // descripcionLb
            // 
            this.descripcionLb.AutoSize = true;
            this.descripcionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLb.Location = new System.Drawing.Point(134, 270);
            this.descripcionLb.Name = "descripcionLb";
            this.descripcionLb.Size = new System.Drawing.Size(114, 25);
            this.descripcionLb.TabIndex = 1;
            this.descripcionLb.Text = "Descripcion";
            // 
            // generarPlanBtn
            // 
            this.generarPlanBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.generarPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarPlanBtn.Location = new System.Drawing.Point(642, 389);
            this.generarPlanBtn.Name = "generarPlanBtn";
            this.generarPlanBtn.Size = new System.Drawing.Size(109, 33);
            this.generarPlanBtn.TabIndex = 2;
            this.generarPlanBtn.Text = "Generar";
            this.generarPlanBtn.UseVisualStyleBackColor = false;
            this.generarPlanBtn.Click += new System.EventHandler(this.generarPlanBtn_Click);
            // 
            // nombrePlanTb
            // 
            this.nombrePlanTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePlanTb.Location = new System.Drawing.Point(306, 123);
            this.nombrePlanTb.Name = "nombrePlanTb";
            this.nombrePlanTb.Size = new System.Drawing.Size(191, 30);
            this.nombrePlanTb.TabIndex = 3;
            // 
            // descripcionTb
            // 
            this.descripcionTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTb.Location = new System.Drawing.Point(306, 270);
            this.descripcionTb.Multiline = true;
            this.descripcionTb.Name = "descripcionTb";
            this.descripcionTb.Size = new System.Drawing.Size(191, 74);
            this.descripcionTb.TabIndex = 5;
            this.descripcionTb.TextChanged += new System.EventHandler(this.descripcionTb_TextChanged);
            // 
            // cuotaLb
            // 
            this.cuotaLb.AutoSize = true;
            this.cuotaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaLb.Location = new System.Drawing.Point(119, 198);
            this.cuotaLb.Name = "cuotaLb";
            this.cuotaLb.Size = new System.Drawing.Size(138, 25);
            this.cuotaLb.TabIndex = 6;
            this.cuotaLb.Text = "Valor de cuota";
            // 
            // cuotaTb
            // 
            this.cuotaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaTb.Location = new System.Drawing.Point(306, 198);
            this.cuotaTb.Name = "cuotaTb";
            this.cuotaTb.Size = new System.Drawing.Size(191, 30);
            this.cuotaTb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Generador de plan";
            // 
            // idPlanLb
            // 
            this.idPlanLb.AutoSize = true;
            this.idPlanLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPlanLb.Location = new System.Drawing.Point(558, 128);
            this.idPlanLb.Name = "idPlanLb";
            this.idPlanLb.Size = new System.Drawing.Size(114, 25);
            this.idPlanLb.TabIndex = 10;
            this.idPlanLb.Text = "Nro de Plan";
            this.idPlanLb.Click += new System.EventHandler(this.idPlanLb_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(47, 389);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(105, 33);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // GenerarPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.idPlanLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuotaTb);
            this.Controls.Add(this.cuotaLb);
            this.Controls.Add(this.descripcionTb);
            this.Controls.Add(this.nombrePlanTb);
            this.Controls.Add(this.generarPlanBtn);
            this.Controls.Add(this.descripcionLb);
            this.Controls.Add(this.nombreLb);
            this.Name = "GenerarPlanes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GenerarPlanes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void descripcionTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.Label descripcionLb;
        private System.Windows.Forms.Button generarPlanBtn;
        private System.Windows.Forms.TextBox nombrePlanTb;
        private System.Windows.Forms.TextBox descripcionTb;
        private System.Windows.Forms.Label cuotaLb;
        private System.Windows.Forms.TextBox cuotaTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idPlanLb;
        private Button cancelarBtn;
    }
}