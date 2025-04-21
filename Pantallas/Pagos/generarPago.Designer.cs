namespace KinecticGym.Pantallas.Pagos
{
    partial class generarPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteTb = new System.Windows.Forms.TextBox();
            this.montoTb = new System.Windows.Forms.TextBox();
            this.descuentoTb = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.efectivoCb = new System.Windows.Forms.RadioButton();
            this.tranferenciaCb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forma de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descuento";
            // 
            // clienteTb
            // 
            this.clienteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteTb.Location = new System.Drawing.Point(346, 154);
            this.clienteTb.Name = "clienteTb";
            this.clienteTb.Size = new System.Drawing.Size(180, 30);
            this.clienteTb.TabIndex = 5;
            // 
            // montoTb
            // 
            this.montoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTb.Location = new System.Drawing.Point(346, 217);
            this.montoTb.Name = "montoTb";
            this.montoTb.Size = new System.Drawing.Size(180, 30);
            this.montoTb.TabIndex = 6;
            // 
            // descuentoTb
            // 
            this.descuentoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoTb.Location = new System.Drawing.Point(346, 280);
            this.descuentoTb.Name = "descuentoTb";
            this.descuentoTb.Size = new System.Drawing.Size(180, 30);
            this.descuentoTb.TabIndex = 7;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBtn.Location = new System.Drawing.Point(614, 154);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(92, 33);
            this.buscarBtn.TabIndex = 8;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // registrarBtn
            // 
            this.registrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.Location = new System.Drawing.Point(724, 444);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(113, 33);
            this.registrarBtn.TabIndex = 9;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.UseVisualStyleBackColor = true;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.Location = new System.Drawing.Point(42, 444);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(105, 33);
            this.cancelarBtn.TabIndex = 10;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // efectivoCb
            // 
            this.efectivoCb.AutoSize = true;
            this.efectivoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoCb.Location = new System.Drawing.Point(312, 356);
            this.efectivoCb.Name = "efectivoCb";
            this.efectivoCb.Size = new System.Drawing.Size(102, 29);
            this.efectivoCb.TabIndex = 11;
            this.efectivoCb.TabStop = true;
            this.efectivoCb.Text = "Efectivo";
            this.efectivoCb.UseVisualStyleBackColor = true;
            this.efectivoCb.CheckedChanged += new System.EventHandler(this.efectivoCb_CheckedChanged);
            // 
            // tranferenciaCb
            // 
            this.tranferenciaCb.AutoSize = true;
            this.tranferenciaCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranferenciaCb.Location = new System.Drawing.Point(451, 356);
            this.tranferenciaCb.Name = "tranferenciaCb";
            this.tranferenciaCb.Size = new System.Drawing.Size(143, 29);
            this.tranferenciaCb.TabIndex = 12;
            this.tranferenciaCb.TabStop = true;
            this.tranferenciaCb.Text = "Tranferencia";
            this.tranferenciaCb.UseVisualStyleBackColor = true;
            this.tranferenciaCb.CheckedChanged += new System.EventHandler(this.tranferenciaCb_CheckedChanged);
            // 
            // generarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 505);
            this.Controls.Add(this.tranferenciaCb);
            this.Controls.Add(this.efectivoCb);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.descuentoTb);
            this.Controls.Add(this.montoTb);
            this.Controls.Add(this.clienteTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "generarPago";
            this.Text = "generarPago";
            this.Load += new System.EventHandler(this.generarPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clienteTb;
        private System.Windows.Forms.TextBox montoTb;
        private System.Windows.Forms.TextBox descuentoTb;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.RadioButton efectivoCb;
        private System.Windows.Forms.RadioButton tranferenciaCb;
    }
}