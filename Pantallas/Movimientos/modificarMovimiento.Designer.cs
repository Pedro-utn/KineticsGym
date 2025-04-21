namespace PrototipoGym.Pantallas.Movimientos
{
    partial class modificarMovimiento
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medioLb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.modificarFechaBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.tranferenciaTb = new System.Windows.Forms.RadioButton();
            this.efectivoCb = new System.Windows.Forms.RadioButton();
            this.importeTb = new System.Windows.Forms.TextBox();
            this.fechaTb = new System.Windows.Forms.TextBox();
            this.clienteTb = new System.Windows.Forms.TextBox();
            this.tipoMovimientoTb = new System.Windows.Forms.TextBox();
            this.numeroMovimientoTb = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Movimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de movimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe:";
            // 
            // medioLb
            // 
            this.medioLb.AutoSize = true;
            this.medioLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medioLb.Location = new System.Drawing.Point(234, 487);
            this.medioLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medioLb.Name = "medioLb";
            this.medioLb.Size = new System.Drawing.Size(87, 29);
            this.medioLb.TabIndex = 5;
            this.medioLb.Text = "Medio:";
            this.medioLb.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Movimiento:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // calendario
            // 
            this.calendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.Location = new System.Drawing.Point(829, 295);
            this.calendario.Margin = new System.Windows.Forms.Padding(7);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 17;
            this.calendario.Visible = false;
            // 
            // modificarFechaBtn
            // 
            this.modificarFechaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarFechaBtn.Location = new System.Drawing.Point(829, 354);
            this.modificarFechaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modificarFechaBtn.Name = "modificarFechaBtn";
            this.modificarFechaBtn.Size = new System.Drawing.Size(194, 35);
            this.modificarFechaBtn.TabIndex = 18;
            this.modificarFechaBtn.Text = "Cambiar Fecha";
            this.modificarFechaBtn.UseVisualStyleBackColor = true;
            this.modificarFechaBtn.Click += new System.EventHandler(this.modificarFechaBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modificarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.modificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.ForeColor = System.Drawing.Color.Black;
            this.modificarBtn.Location = new System.Drawing.Point(935, 576);
            this.modificarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(142, 39);
            this.modificarBtn.TabIndex = 19;
            this.modificarBtn.Text = "Modificar Cliente";
            this.modificarBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // tranferenciaTb
            // 
            this.tranferenciaTb.AutoSize = true;
            this.tranferenciaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranferenciaTb.Location = new System.Drawing.Point(570, 483);
            this.tranferenciaTb.Margin = new System.Windows.Forms.Padding(2);
            this.tranferenciaTb.Name = "tranferenciaTb";
            this.tranferenciaTb.Size = new System.Drawing.Size(167, 33);
            this.tranferenciaTb.TabIndex = 15;
            this.tranferenciaTb.TabStop = true;
            this.tranferenciaTb.Text = "Tranferencia";
            this.tranferenciaTb.UseVisualStyleBackColor = true;
            this.tranferenciaTb.Visible = false;
            this.tranferenciaTb.CheckedChanged += new System.EventHandler(this.tranferenciaTb_CheckedChanged);
            // 
            // efectivoCb
            // 
            this.efectivoCb.AutoSize = true;
            this.efectivoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoCb.Location = new System.Drawing.Point(413, 483);
            this.efectivoCb.Margin = new System.Windows.Forms.Padding(2);
            this.efectivoCb.Name = "efectivoCb";
            this.efectivoCb.Size = new System.Drawing.Size(116, 33);
            this.efectivoCb.TabIndex = 14;
            this.efectivoCb.TabStop = true;
            this.efectivoCb.Text = "Efectivo";
            this.efectivoCb.UseVisualStyleBackColor = true;
            this.efectivoCb.Visible = false;
            this.efectivoCb.CheckedChanged += new System.EventHandler(this.efectivoCb_CheckedChanged);
            // 
            // importeTb
            // 
            this.importeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTb.Location = new System.Drawing.Point(393, 416);
            this.importeTb.Margin = new System.Windows.Forms.Padding(2);
            this.importeTb.Name = "importeTb";
            this.importeTb.Size = new System.Drawing.Size(355, 35);
            this.importeTb.TabIndex = 13;
            // 
            // fechaTb
            // 
            this.fechaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaTb.Location = new System.Drawing.Point(393, 351);
            this.fechaTb.Margin = new System.Windows.Forms.Padding(2);
            this.fechaTb.Name = "fechaTb";
            this.fechaTb.Size = new System.Drawing.Size(355, 35);
            this.fechaTb.TabIndex = 8;
            // 
            // clienteTb
            // 
            this.clienteTb.BackColor = System.Drawing.Color.LightGray;
            this.clienteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteTb.Location = new System.Drawing.Point(393, 285);
            this.clienteTb.Margin = new System.Windows.Forms.Padding(2);
            this.clienteTb.Name = "clienteTb";
            this.clienteTb.Size = new System.Drawing.Size(355, 35);
            this.clienteTb.TabIndex = 11;
            // 
            // tipoMovimientoTb
            // 
            this.tipoMovimientoTb.BackColor = System.Drawing.Color.LightGray;
            this.tipoMovimientoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoMovimientoTb.Location = new System.Drawing.Point(393, 221);
            this.tipoMovimientoTb.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMovimientoTb.Name = "tipoMovimientoTb";
            this.tipoMovimientoTb.Size = new System.Drawing.Size(355, 35);
            this.tipoMovimientoTb.TabIndex = 9;
            // 
            // numeroMovimientoTb
            // 
            this.numeroMovimientoTb.BackColor = System.Drawing.Color.LightGray;
            this.numeroMovimientoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroMovimientoTb.Location = new System.Drawing.Point(393, 161);
            this.numeroMovimientoTb.Margin = new System.Windows.Forms.Padding(2);
            this.numeroMovimientoTb.Name = "numeroMovimientoTb";
            this.numeroMovimientoTb.Size = new System.Drawing.Size(355, 35);
            this.numeroMovimientoTb.TabIndex = 12;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelarBtn.BackColor = System.Drawing.Color.Red;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarBtn.Location = new System.Drawing.Point(70, 574);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(146, 39);
            this.cancelarBtn.TabIndex = 20;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // modificarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 658);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.modificarFechaBtn);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.tranferenciaTb);
            this.Controls.Add(this.efectivoCb);
            this.Controls.Add(this.importeTb);
            this.Controls.Add(this.numeroMovimientoTb);
            this.Controls.Add(this.clienteTb);
            this.Controls.Add(this.tipoMovimientoTb);
            this.Controls.Add(this.fechaTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.medioLb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modificarMovimiento";
            this.Text = "modificarMovimiento";
            this.Load += new System.EventHandler(this.modificarMovimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label medioLb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button modificarFechaBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.RadioButton tranferenciaTb;
        private System.Windows.Forms.RadioButton efectivoCb;
        private System.Windows.Forms.TextBox importeTb;
        private System.Windows.Forms.TextBox fechaTb;
        private System.Windows.Forms.TextBox clienteTb;
        private System.Windows.Forms.TextBox tipoMovimientoTb;
        private System.Windows.Forms.TextBox numeroMovimientoTb;
        private System.Windows.Forms.Button cancelarBtn;
    }
}