namespace PrototipoGym.Pantallas
{
    partial class RegistrarClienteForm
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
            this.RegistrarNuevoClienteBtn = new System.Windows.Forms.Button();
            this.telefonoTb = new System.Windows.Forms.TextBox();
            this.planTb = new System.Windows.Forms.TextBox();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.nombreLb = new System.Windows.Forms.Label();
            this.planLb = new System.Windows.Forms.Label();
            this.telefonoLb = new System.Windows.Forms.Label();
            this.titulo2Lb = new System.Windows.Forms.Label();
            this.idLb = new System.Windows.Forms.Label();
            this.buscarPlanBtn = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrarNuevoClienteBtn
            // 
            this.RegistrarNuevoClienteBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.RegistrarNuevoClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarNuevoClienteBtn.Location = new System.Drawing.Point(606, 423);
            this.RegistrarNuevoClienteBtn.Name = "RegistrarNuevoClienteBtn";
            this.RegistrarNuevoClienteBtn.Size = new System.Drawing.Size(191, 33);
            this.RegistrarNuevoClienteBtn.TabIndex = 0;
            this.RegistrarNuevoClienteBtn.Text = "Registrar nuevo cliente";
            this.RegistrarNuevoClienteBtn.UseVisualStyleBackColor = false;
            this.RegistrarNuevoClienteBtn.Click += new System.EventHandler(this.RegistrarNuevoClienteBtn_Click);
            // 
            // telefonoTb
            // 
            this.telefonoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTb.Location = new System.Drawing.Point(276, 229);
            this.telefonoTb.Name = "telefonoTb";
            this.telefonoTb.Size = new System.Drawing.Size(225, 30);
            this.telefonoTb.TabIndex = 1;
            // 
            // planTb
            // 
            this.planTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planTb.Location = new System.Drawing.Point(276, 311);
            this.planTb.Name = "planTb";
            this.planTb.Size = new System.Drawing.Size(225, 30);
            this.planTb.TabIndex = 3;
            // 
            // nombreTb
            // 
            this.nombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTb.Location = new System.Drawing.Point(276, 148);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(225, 30);
            this.nombreTb.TabIndex = 5;
            // 
            // nombreLb
            // 
            this.nombreLb.AutoSize = true;
            this.nombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLb.Location = new System.Drawing.Point(130, 149);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(81, 25);
            this.nombreLb.TabIndex = 6;
            this.nombreLb.Text = "Nombre";
            this.nombreLb.Click += new System.EventHandler(this.nombreLb_Click);
            // 
            // planLb
            // 
            this.planLb.AutoSize = true;
            this.planLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planLb.Location = new System.Drawing.Point(160, 316);
            this.planLb.Name = "planLb";
            this.planLb.Size = new System.Drawing.Size(51, 25);
            this.planLb.TabIndex = 8;
            this.planLb.Text = "Plan";
            // 
            // telefonoLb
            // 
            this.telefonoLb.AutoSize = true;
            this.telefonoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLb.Location = new System.Drawing.Point(122, 234);
            this.telefonoLb.Name = "telefonoLb";
            this.telefonoLb.Size = new System.Drawing.Size(89, 25);
            this.telefonoLb.TabIndex = 9;
            this.telefonoLb.Text = "Telefono";
            // 
            // titulo2Lb
            // 
            this.titulo2Lb.AutoSize = true;
            this.titulo2Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo2Lb.Location = new System.Drawing.Point(211, 35);
            this.titulo2Lb.Name = "titulo2Lb";
            this.titulo2Lb.Size = new System.Drawing.Size(365, 39);
            this.titulo2Lb.TabIndex = 11;
            this.titulo2Lb.Text = "Registrar cliente nuevo";
            // 
            // idLb
            // 
            this.idLb.AutoSize = true;
            this.idLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLb.Location = new System.Drawing.Point(564, 147);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(130, 27);
            this.idLb.TabIndex = 13;
            this.idLb.Text = "Identificador: ";
            this.idLb.Click += new System.EventHandler(this.idLb_Click);
            // 
            // buscarPlanBtn
            // 
            this.buscarPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarPlanBtn.Location = new System.Drawing.Point(564, 310);
            this.buscarPlanBtn.Name = "buscarPlanBtn";
            this.buscarPlanBtn.Size = new System.Drawing.Size(130, 31);
            this.buscarPlanBtn.TabIndex = 15;
            this.buscarPlanBtn.Text = "Buscar Plan";
            this.buscarPlanBtn.UseVisualStyleBackColor = true;
            this.buscarPlanBtn.Click += new System.EventHandler(this.buscarPlanBtn_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(30, 423);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(99, 39);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Cancelar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegistrarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 495);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.buscarPlanBtn);
            this.Controls.Add(this.idLb);
            this.Controls.Add(this.titulo2Lb);
            this.Controls.Add(this.telefonoLb);
            this.Controls.Add(this.planLb);
            this.Controls.Add(this.nombreLb);
            this.Controls.Add(this.nombreTb);
            this.Controls.Add(this.planTb);
            this.Controls.Add(this.telefonoTb);
            this.Controls.Add(this.RegistrarNuevoClienteBtn);
            this.Name = "RegistrarClienteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrarClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrarNuevoClienteBtn;
        private System.Windows.Forms.TextBox telefonoTb;
        private System.Windows.Forms.TextBox planTb;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.Label planLb;
        private System.Windows.Forms.Label telefonoLb;
        private System.Windows.Forms.Label titulo2Lb;
        private System.Windows.Forms.Label idLb;
        private System.Windows.Forms.Button buscarPlanBtn;
        private System.Windows.Forms.Button btnRegresar;
    }
}