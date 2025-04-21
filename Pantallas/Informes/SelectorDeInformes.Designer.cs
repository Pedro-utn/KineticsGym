namespace PrototipoGym.Pantallas
{
    partial class SelectorDeInformes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cajaDiariaCb = new System.Windows.Forms.RadioButton();
            this.clientesActivosCb = new System.Windows.Forms.RadioButton();
            this.saldosClientesCb = new System.Windows.Forms.RadioButton();
            this.resumenCuentaCb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hastaLb = new System.Windows.Forms.Label();
            this.hastaDtp = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diaLb = new System.Windows.Forms.Label();
            this.mesDtp = new System.Windows.Forms.DateTimePicker();
            this.desdeDtp = new System.Windows.Forms.DateTimePicker();
            this.mesLb = new System.Windows.Forms.Label();
            this.diaDtp = new System.Windows.Forms.DateTimePicker();
            this.desdeLb = new System.Windows.Forms.Label();
            this.clienteLb = new System.Windows.Forms.Label();
            this.seleccionarClienteBtn = new System.Windows.Forms.Button();
            this.diaCb = new System.Windows.Forms.RadioButton();
            this.desdeHastaCb = new System.Windows.Forms.RadioButton();
            this.mesCb = new System.Windows.Forms.RadioButton();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cajaDiariaCb);
            this.groupBox1.Controls.Add(this.clientesActivosCb);
            this.groupBox1.Controls.Add(this.saldosClientesCb);
            this.groupBox1.Controls.Add(this.resumenCuentaCb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1017, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de reporte";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cajaDiariaCb
            // 
            this.cajaDiariaCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cajaDiariaCb.AutoSize = true;
            this.cajaDiariaCb.Location = new System.Drawing.Point(410, 52);
            this.cajaDiariaCb.Margin = new System.Windows.Forms.Padding(2);
            this.cajaDiariaCb.Name = "cajaDiariaCb";
            this.cajaDiariaCb.Size = new System.Drawing.Size(149, 33);
            this.cajaDiariaCb.TabIndex = 3;
            this.cajaDiariaCb.TabStop = true;
            this.cajaDiariaCb.Text = "Caja Diaria";
            this.cajaDiariaCb.UseVisualStyleBackColor = true;
            this.cajaDiariaCb.CheckedChanged += new System.EventHandler(this.cajaDiariaCb_CheckedChanged);
            // 
            // clientesActivosCb
            // 
            this.clientesActivosCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientesActivosCb.AutoSize = true;
            this.clientesActivosCb.Location = new System.Drawing.Point(410, 123);
            this.clientesActivosCb.Margin = new System.Windows.Forms.Padding(2);
            this.clientesActivosCb.Name = "clientesActivosCb";
            this.clientesActivosCb.Size = new System.Drawing.Size(201, 33);
            this.clientesActivosCb.TabIndex = 2;
            this.clientesActivosCb.TabStop = true;
            this.clientesActivosCb.Text = "Clientes Activos";
            this.clientesActivosCb.UseVisualStyleBackColor = true;
            this.clientesActivosCb.Visible = false;
            this.clientesActivosCb.CheckedChanged += new System.EventHandler(this.clientesActivosCb_CheckedChanged);
            // 
            // saldosClientesCb
            // 
            this.saldosClientesCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saldosClientesCb.AutoSize = true;
            this.saldosClientesCb.Location = new System.Drawing.Point(34, 123);
            this.saldosClientesCb.Margin = new System.Windows.Forms.Padding(2);
            this.saldosClientesCb.Name = "saldosClientesCb";
            this.saldosClientesCb.Size = new System.Drawing.Size(234, 33);
            this.saldosClientesCb.TabIndex = 1;
            this.saldosClientesCb.TabStop = true;
            this.saldosClientesCb.Text = "Saldos de Clientes";
            this.saldosClientesCb.UseVisualStyleBackColor = true;
            this.saldosClientesCb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // resumenCuentaCb
            // 
            this.resumenCuentaCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resumenCuentaCb.AutoSize = true;
            this.resumenCuentaCb.Location = new System.Drawing.Point(36, 58);
            this.resumenCuentaCb.Margin = new System.Windows.Forms.Padding(2);
            this.resumenCuentaCb.Name = "resumenCuentaCb";
            this.resumenCuentaCb.Size = new System.Drawing.Size(245, 33);
            this.resumenCuentaCb.TabIndex = 0;
            this.resumenCuentaCb.Text = "Resumen de cuenta";
            this.resumenCuentaCb.UseVisualStyleBackColor = true;
            this.resumenCuentaCb.CheckedChanged += new System.EventHandler(this.resumenCuentaCb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 253);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1017, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00336F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.64166F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.243F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.clienteLb, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.seleccionarClienteBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.diaCb, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.desdeHastaCb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mesCb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nombreTb, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(62, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(893, 182);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hastaLb);
            this.panel1.Controls.Add(this.hastaDtp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(262, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 56);
            this.panel1.TabIndex = 19;
            // 
            // hastaLb
            // 
            this.hastaLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hastaLb.Location = new System.Drawing.Point(67, 6);
            this.hastaLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hastaLb.Name = "hastaLb";
            this.hastaLb.Size = new System.Drawing.Size(86, 33);
            this.hastaLb.TabIndex = 3;
            this.hastaLb.Text = "Hasta:";
            this.hastaLb.Visible = false;
            // 
            // hastaDtp
            // 
            this.hastaDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hastaDtp.CustomFormat = "  dd / MM / yy";
            this.hastaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hastaDtp.Location = new System.Drawing.Point(172, 2);
            this.hastaDtp.Margin = new System.Windows.Forms.Padding(2);
            this.hastaDtp.Name = "hastaDtp";
            this.hastaDtp.Size = new System.Drawing.Size(172, 35);
            this.hastaDtp.TabIndex = 1;
            this.hastaDtp.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diaLb);
            this.panel2.Controls.Add(this.mesDtp);
            this.panel2.Controls.Add(this.desdeDtp);
            this.panel2.Controls.Add(this.mesLb);
            this.panel2.Controls.Add(this.diaDtp);
            this.panel2.Controls.Add(this.desdeLb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 56);
            this.panel2.TabIndex = 18;
            // 
            // diaLb
            // 
            this.diaLb.AutoSize = true;
            this.diaLb.Location = new System.Drawing.Point(2, 6);
            this.diaLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diaLb.Name = "diaLb";
            this.diaLb.Size = new System.Drawing.Size(55, 29);
            this.diaLb.TabIndex = 9;
            this.diaLb.Text = "Dia:";
            this.diaLb.Visible = false;
            // 
            // mesDtp
            // 
            this.mesDtp.CustomFormat = " MM / yy";
            this.mesDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mesDtp.Location = new System.Drawing.Point(100, 2);
            this.mesDtp.Margin = new System.Windows.Forms.Padding(2);
            this.mesDtp.Name = "mesDtp";
            this.mesDtp.Size = new System.Drawing.Size(97, 35);
            this.mesDtp.TabIndex = 5;
            this.mesDtp.Visible = false;
            // 
            // desdeDtp
            // 
            this.desdeDtp.CustomFormat = " dd / MM / yy";
            this.desdeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdeDtp.Location = new System.Drawing.Point(100, 2);
            this.desdeDtp.Margin = new System.Windows.Forms.Padding(2);
            this.desdeDtp.Name = "desdeDtp";
            this.desdeDtp.Size = new System.Drawing.Size(146, 35);
            this.desdeDtp.TabIndex = 0;
            this.desdeDtp.Visible = false;
            // 
            // mesLb
            // 
            this.mesLb.AutoSize = true;
            this.mesLb.Location = new System.Drawing.Point(-2, 6);
            this.mesLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mesLb.Name = "mesLb";
            this.mesLb.Size = new System.Drawing.Size(59, 29);
            this.mesLb.TabIndex = 4;
            this.mesLb.Text = "Mes";
            this.mesLb.Visible = false;
            // 
            // diaDtp
            // 
            this.diaDtp.CustomFormat = " dd / MM / yy";
            this.diaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.diaDtp.Location = new System.Drawing.Point(100, 1);
            this.diaDtp.Margin = new System.Windows.Forms.Padding(2);
            this.diaDtp.Name = "diaDtp";
            this.diaDtp.Size = new System.Drawing.Size(142, 35);
            this.diaDtp.TabIndex = 10;
            this.diaDtp.Visible = false;
            // 
            // desdeLb
            // 
            this.desdeLb.AutoSize = true;
            this.desdeLb.Location = new System.Drawing.Point(-2, 6);
            this.desdeLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desdeLb.Name = "desdeLb";
            this.desdeLb.Size = new System.Drawing.Size(90, 29);
            this.desdeLb.TabIndex = 2;
            this.desdeLb.Text = "Desde:";
            this.desdeLb.Visible = false;
            // 
            // clienteLb
            // 
            this.clienteLb.AutoSize = true;
            this.clienteLb.Location = new System.Drawing.Point(2, 0);
            this.clienteLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clienteLb.Name = "clienteLb";
            this.clienteLb.Size = new System.Drawing.Size(95, 29);
            this.clienteLb.TabIndex = 12;
            this.clienteLb.Text = "Cliente:";
            this.clienteLb.Visible = false;
            // 
            // seleccionarClienteBtn
            // 
            this.seleccionarClienteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seleccionarClienteBtn.Location = new System.Drawing.Point(672, 2);
            this.seleccionarClienteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.seleccionarClienteBtn.Name = "seleccionarClienteBtn";
            this.seleccionarClienteBtn.Size = new System.Drawing.Size(162, 34);
            this.seleccionarClienteBtn.TabIndex = 11;
            this.seleccionarClienteBtn.Text = "Seleccionar";
            this.seleccionarClienteBtn.UseVisualStyleBackColor = true;
            this.seleccionarClienteBtn.Visible = false;
            this.seleccionarClienteBtn.Click += new System.EventHandler(this.seleccionarClienteBtn_Click);
            // 
            // diaCb
            // 
            this.diaCb.AutoSize = true;
            this.diaCb.Location = new System.Drawing.Point(615, 62);
            this.diaCb.Margin = new System.Windows.Forms.Padding(2);
            this.diaCb.Name = "diaCb";
            this.diaCb.Size = new System.Drawing.Size(67, 33);
            this.diaCb.TabIndex = 8;
            this.diaCb.TabStop = true;
            this.diaCb.Text = "Dia";
            this.diaCb.UseVisualStyleBackColor = true;
            this.diaCb.Visible = false;
            this.diaCb.CheckedChanged += new System.EventHandler(this.diaCb_CheckedChanged);
            // 
            // desdeHastaCb
            // 
            this.desdeHastaCb.AutoSize = true;
            this.desdeHastaCb.Location = new System.Drawing.Point(2, 62);
            this.desdeHastaCb.Margin = new System.Windows.Forms.Padding(2);
            this.desdeHastaCb.Name = "desdeHastaCb";
            this.desdeHastaCb.Size = new System.Drawing.Size(170, 33);
            this.desdeHastaCb.TabIndex = 6;
            this.desdeHastaCb.TabStop = true;
            this.desdeHastaCb.Text = "Desde/Hasta";
            this.desdeHastaCb.UseVisualStyleBackColor = true;
            this.desdeHastaCb.Visible = false;
            this.desdeHastaCb.CheckedChanged += new System.EventHandler(this.desdeHastaCb_CheckedChanged);
            // 
            // mesCb
            // 
            this.mesCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesCb.AutoSize = true;
            this.mesCb.Location = new System.Drawing.Point(397, 62);
            this.mesCb.Margin = new System.Windows.Forms.Padding(2);
            this.mesCb.Name = "mesCb";
            this.mesCb.Size = new System.Drawing.Size(77, 33);
            this.mesCb.TabIndex = 7;
            this.mesCb.TabStop = true;
            this.mesCb.Text = "Mes";
            this.mesCb.UseVisualStyleBackColor = true;
            this.mesCb.Visible = false;
            this.mesCb.CheckedChanged += new System.EventHandler(this.mesCb_CheckedChanged);
            // 
            // nombreTb
            // 
            this.nombreTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTb.Location = new System.Drawing.Point(261, 2);
            this.nombreTb.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(350, 35);
            this.nombreTb.TabIndex = 14;
            this.nombreTb.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 502);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // SelectorDeInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1021, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectorDeInformes";
            this.Text = "SelectorDeInformes";
            this.Load += new System.EventHandler(this.SelectorDeInformes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton resumenCuentaCb;
        private System.Windows.Forms.RadioButton saldosClientesCb;
        private System.Windows.Forms.RadioButton mesCb;
        private System.Windows.Forms.RadioButton desdeHastaCb;
        private System.Windows.Forms.RadioButton diaCb;
        private System.Windows.Forms.Label clienteLb;
        private System.Windows.Forms.Button seleccionarClienteBtn;
        private System.Windows.Forms.RadioButton clientesActivosCb;
        private System.Windows.Forms.RadioButton cajaDiariaCb;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label diaLb;
        private System.Windows.Forms.DateTimePicker mesDtp;
        private System.Windows.Forms.DateTimePicker desdeDtp;
        private System.Windows.Forms.Label mesLb;
        private System.Windows.Forms.DateTimePicker diaDtp;
        private System.Windows.Forms.Label desdeLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hastaLb;
        private System.Windows.Forms.DateTimePicker hastaDtp;
    }
}