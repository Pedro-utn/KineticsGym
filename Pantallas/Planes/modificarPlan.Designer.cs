namespace PrototipoGym.Pantallas.Planes
{
    partial class modificarPlan
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
            this.cuotaLb = new System.Windows.Forms.Label();
            this.idLb = new System.Windows.Forms.Label();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.descripcionTb = new System.Windows.Forms.TextBox();
            this.cuotaTb = new System.Windows.Forms.TextBox();
            this.modificarPlanBtn = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activoCb = new System.Windows.Forms.RadioButton();
            this.inactivoCb = new System.Windows.Forms.RadioButton();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLb
            // 
            this.nombreLb.AutoSize = true;
            this.nombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLb.Location = new System.Drawing.Point(124, 102);
            this.nombreLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(65, 20);
            this.nombreLb.TabIndex = 0;
            this.nombreLb.Text = "Nombre";
            this.nombreLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // descripcionLb
            // 
            this.descripcionLb.AutoSize = true;
            this.descripcionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLb.Location = new System.Drawing.Point(124, 158);
            this.descripcionLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLb.Name = "descripcionLb";
            this.descripcionLb.Size = new System.Drawing.Size(92, 20);
            this.descripcionLb.TabIndex = 1;
            this.descripcionLb.Text = "Descripcion";
            // 
            // cuotaLb
            // 
            this.cuotaLb.AutoSize = true;
            this.cuotaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaLb.Location = new System.Drawing.Point(124, 241);
            this.cuotaLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cuotaLb.Name = "cuotaLb";
            this.cuotaLb.Size = new System.Drawing.Size(52, 20);
            this.cuotaLb.TabIndex = 2;
            this.cuotaLb.Text = "Cuota";
            this.cuotaLb.Click += new System.EventHandler(this.cuotaLb_Click);
            // 
            // idLb
            // 
            this.idLb.AutoSize = true;
            this.idLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLb.Location = new System.Drawing.Point(460, 104);
            this.idLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(95, 20);
            this.idLb.TabIndex = 3;
            this.idLb.Text = "Nro de Plan:";
            // 
            // nombreTb
            // 
            this.nombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTb.Location = new System.Drawing.Point(243, 102);
            this.nombreTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(159, 26);
            this.nombreTb.TabIndex = 4;
            // 
            // descripcionTb
            // 
            this.descripcionTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTb.Location = new System.Drawing.Point(243, 158);
            this.descripcionTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descripcionTb.Multiline = true;
            this.descripcionTb.Name = "descripcionTb";
            this.descripcionTb.Size = new System.Drawing.Size(159, 54);
            this.descripcionTb.TabIndex = 5;
            // 
            // cuotaTb
            // 
            this.cuotaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaTb.Location = new System.Drawing.Point(243, 239);
            this.cuotaTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuotaTb.Name = "cuotaTb";
            this.cuotaTb.Size = new System.Drawing.Size(159, 26);
            this.cuotaTb.TabIndex = 6;
            // 
            // modificarPlanBtn
            // 
            this.modificarPlanBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.modificarPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarPlanBtn.Location = new System.Drawing.Point(503, 382);
            this.modificarPlanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificarPlanBtn.Name = "modificarPlanBtn";
            this.modificarPlanBtn.Size = new System.Drawing.Size(94, 28);
            this.modificarPlanBtn.TabIndex = 7;
            this.modificarPlanBtn.Text = "Modificar Plan";
            this.modificarPlanBtn.UseVisualStyleBackColor = false;
            this.modificarPlanBtn.Click += new System.EventHandler(this.modificarPlanBtn_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(235, 27);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(185, 31);
            this.titulo.TabIndex = 8;
            this.titulo.Text = "Modificar Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estado";
            // 
            // activoCb
            // 
            this.activoCb.AutoSize = true;
            this.activoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCb.Location = new System.Drawing.Point(243, 290);
            this.activoCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activoCb.Name = "activoCb";
            this.activoCb.Size = new System.Drawing.Size(70, 24);
            this.activoCb.TabIndex = 10;
            this.activoCb.TabStop = true;
            this.activoCb.Text = "Activo";
            this.activoCb.UseVisualStyleBackColor = true;
            // 
            // inactivoCb
            // 
            this.inactivoCb.AutoSize = true;
            this.inactivoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivoCb.Location = new System.Drawing.Point(326, 290);
            this.inactivoCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inactivoCb.Name = "inactivoCb";
            this.inactivoCb.Size = new System.Drawing.Size(82, 24);
            this.inactivoCb.TabIndex = 11;
            this.inactivoCb.TabStop = true;
            this.inactivoCb.Text = "Inactivo";
            this.inactivoCb.UseVisualStyleBackColor = true;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(41, 382);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelarBtn.TabIndex = 12;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // modificarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 431);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.inactivoCb);
            this.Controls.Add(this.activoCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.modificarPlanBtn);
            this.Controls.Add(this.cuotaTb);
            this.Controls.Add(this.descripcionTb);
            this.Controls.Add(this.nombreTb);
            this.Controls.Add(this.idLb);
            this.Controls.Add(this.cuotaLb);
            this.Controls.Add(this.descripcionLb);
            this.Controls.Add(this.nombreLb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modificarPlan";
            this.Text = "modificarPlan";
            this.Load += new System.EventHandler(this.modificarPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.Label descripcionLb;
        private System.Windows.Forms.Label cuotaLb;
        private System.Windows.Forms.Label idLb;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.TextBox descripcionTb;
        private System.Windows.Forms.TextBox cuotaTb;
        private System.Windows.Forms.Button modificarPlanBtn;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton activoCb;
        private System.Windows.Forms.RadioButton inactivoCb;
        private System.Windows.Forms.Button cancelarBtn;
    }
}