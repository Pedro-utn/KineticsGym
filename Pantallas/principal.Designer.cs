namespace KinecticGym.Pantallas
{
    partial class principal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clienteNuevoCb = new System.Windows.Forms.CheckBox();
            this.modificarClienteCb = new System.Windows.Forms.CheckBox();
            this.limpiarPantalla = new System.Windows.Forms.Button();
            this.resumenCuentaBtn = new System.Windows.Forms.Button();
            this.pagoPanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.registrarPagoBtn = new System.Windows.Forms.Button();
            this.descuentoTb = new System.Windows.Forms.TextBox();
            this.transferenciaTb = new System.Windows.Forms.TextBox();
            this.descuentoLb = new System.Windows.Forms.Label();
            this.efectivoTb = new System.Windows.Forms.TextBox();
            this.transferenciaLb = new System.Windows.Forms.Label();
            this.efectivoLb = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.planPanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cuotaTb = new System.Windows.Forms.TextBox();
            this.cuotaLb = new System.Windows.Forms.Label();
            this.planLb = new System.Windows.Forms.Label();
            this.comboBoxPlanes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.registrarClienteBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.clientePanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nombreLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonoLb = new System.Windows.Forms.Label();
            this.estadoLb = new System.Windows.Forms.Label();
            this.nombreTb = new System.Windows.Forms.TextBox();
            this.buscarClienteBtn = new System.Windows.Forms.Button();
            this.telefonoTb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.bajaCb = new System.Windows.Forms.RadioButton();
            this.altaCb = new System.Windows.Forms.RadioButton();
            this.saldoTb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pagoPanel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.planPanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.clientePanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteNuevoCb
            // 
            this.clienteNuevoCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clienteNuevoCb.AutoSize = true;
            this.clienteNuevoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteNuevoCb.Location = new System.Drawing.Point(2, 53);
            this.clienteNuevoCb.Margin = new System.Windows.Forms.Padding(2);
            this.clienteNuevoCb.Name = "clienteNuevoCb";
            this.clienteNuevoCb.Size = new System.Drawing.Size(207, 41);
            this.clienteNuevoCb.TabIndex = 0;
            this.clienteNuevoCb.Text = "Nuevo Cliente";
            this.clienteNuevoCb.UseVisualStyleBackColor = true;
            this.clienteNuevoCb.CheckedChanged += new System.EventHandler(this.clienteNuevoCb_CheckedChanged);
            // 
            // modificarClienteCb
            // 
            this.modificarClienteCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modificarClienteCb.AutoSize = true;
            this.modificarClienteCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarClienteCb.Location = new System.Drawing.Point(2, 196);
            this.modificarClienteCb.Margin = new System.Windows.Forms.Padding(2);
            this.modificarClienteCb.Name = "modificarClienteCb";
            this.modificarClienteCb.Size = new System.Drawing.Size(207, 41);
            this.modificarClienteCb.TabIndex = 15;
            this.modificarClienteCb.Text = "Modificar Cliente";
            this.modificarClienteCb.UseVisualStyleBackColor = true;
            this.modificarClienteCb.CheckedChanged += new System.EventHandler(this.modificarClienteCb_CheckedChanged);
            // 
            // limpiarPantalla
            // 
            this.limpiarPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.limpiarPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarPantalla.Location = new System.Drawing.Point(32, 379);
            this.limpiarPantalla.Margin = new System.Windows.Forms.Padding(2);
            this.limpiarPantalla.Name = "limpiarPantalla";
            this.limpiarPantalla.Size = new System.Drawing.Size(166, 84);
            this.limpiarPantalla.TabIndex = 21;
            this.limpiarPantalla.Text = "Limpiar Pantalla";
            this.limpiarPantalla.UseVisualStyleBackColor = true;
            this.limpiarPantalla.Click += new System.EventHandler(this.limpiarPantalla_Click);
            // 
            // resumenCuentaBtn
            // 
            this.resumenCuentaBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resumenCuentaBtn.AutoSize = true;
            this.resumenCuentaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumenCuentaBtn.Location = new System.Drawing.Point(1091, 333);
            this.resumenCuentaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resumenCuentaBtn.Name = "resumenCuentaBtn";
            this.resumenCuentaBtn.Size = new System.Drawing.Size(171, 98);
            this.resumenCuentaBtn.TabIndex = 18;
            this.resumenCuentaBtn.Text = "Resumen de Cuenta";
            this.resumenCuentaBtn.UseVisualStyleBackColor = true;
            this.resumenCuentaBtn.Click += new System.EventHandler(this.resumenCuentaBtn_Click);
            // 
            // pagoPanel
            // 
            this.pagoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagoPanel.Controls.Add(this.tableLayoutPanel7);
            this.pagoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoPanel.Location = new System.Drawing.Point(265, 467);
            this.pagoPanel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.pagoPanel.Name = "pagoPanel";
            this.pagoPanel.Padding = new System.Windows.Forms.Padding(2);
            this.pagoPanel.Size = new System.Drawing.Size(804, 222);
            this.pagoPanel.TabIndex = 13;
            this.pagoPanel.TabStop = false;
            this.pagoPanel.Text = "Pago";
            this.pagoPanel.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.59249F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4443F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96461F));
            this.tableLayoutPanel7.Controls.Add(this.registrarPagoBtn, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.descuentoTb, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.transferenciaTb, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.descuentoLb, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.efectivoTb, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.transferenciaLb, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.efectivoLb, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(29, 49);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(20, 10, 10, 20);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(763, 162);
            this.tableLayoutPanel7.TabIndex = 22;
            // 
            // registrarPagoBtn
            // 
            this.registrarPagoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrarPagoBtn.AutoSize = true;
            this.registrarPagoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarPagoBtn.Location = new System.Drawing.Point(543, 56);
            this.registrarPagoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registrarPagoBtn.Name = "registrarPagoBtn";
            this.registrarPagoBtn.Size = new System.Drawing.Size(218, 47);
            this.registrarPagoBtn.TabIndex = 17;
            this.registrarPagoBtn.Text = "Registrar Pago";
            this.registrarPagoBtn.UseVisualStyleBackColor = true;
            this.registrarPagoBtn.Click += new System.EventHandler(this.registrarPagoBtn_Click_1);
            // 
            // descuentoTb
            // 
            this.descuentoTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descuentoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoTb.Location = new System.Drawing.Point(182, 110);
            this.descuentoTb.Margin = new System.Windows.Forms.Padding(2);
            this.descuentoTb.Name = "descuentoTb";
            this.descuentoTb.Size = new System.Drawing.Size(357, 44);
            this.descuentoTb.TabIndex = 21;
            // 
            // transferenciaTb
            // 
            this.transferenciaTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transferenciaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferenciaTb.Location = new System.Drawing.Point(182, 56);
            this.transferenciaTb.Margin = new System.Windows.Forms.Padding(2);
            this.transferenciaTb.Name = "transferenciaTb";
            this.transferenciaTb.Size = new System.Drawing.Size(357, 44);
            this.transferenciaTb.TabIndex = 20;
            // 
            // descuentoLb
            // 
            this.descuentoLb.AutoSize = true;
            this.descuentoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoLb.Location = new System.Drawing.Point(2, 108);
            this.descuentoLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descuentoLb.Name = "descuentoLb";
            this.descuentoLb.Size = new System.Drawing.Size(169, 54);
            this.descuentoLb.TabIndex = 1;
            this.descuentoLb.Text = "Descuento:";
            // 
            // efectivoTb
            // 
            this.efectivoTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.efectivoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoTb.Location = new System.Drawing.Point(182, 2);
            this.efectivoTb.Margin = new System.Windows.Forms.Padding(2);
            this.efectivoTb.Name = "efectivoTb";
            this.efectivoTb.Size = new System.Drawing.Size(357, 44);
            this.efectivoTb.TabIndex = 15;
            // 
            // transferenciaLb
            // 
            this.transferenciaLb.AutoSize = true;
            this.transferenciaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferenciaLb.Location = new System.Drawing.Point(2, 54);
            this.transferenciaLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transferenciaLb.Name = "transferenciaLb";
            this.transferenciaLb.Size = new System.Drawing.Size(172, 54);
            this.transferenciaLb.TabIndex = 19;
            this.transferenciaLb.Text = "Transferencia:";
            // 
            // efectivoLb
            // 
            this.efectivoLb.AutoSize = true;
            this.efectivoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoLb.Location = new System.Drawing.Point(2, 0);
            this.efectivoLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.efectivoLb.Name = "efectivoLb";
            this.efectivoLb.Size = new System.Drawing.Size(138, 37);
            this.efectivoLb.TabIndex = 18;
            this.efectivoLb.Text = "Efectivo:";
            // 
            // volverBtn
            // 
            this.volverBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.volverBtn.AutoSize = true;
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.Location = new System.Drawing.Point(2, 116);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(163, 78);
            this.volverBtn.TabIndex = 19;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.42301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.39546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.07285F));
            this.tableLayoutPanel1.Controls.Add(this.planPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pagoPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.clientePanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.resumenCuentaBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.limpiarPantalla, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 10, 20, 10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.58443F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.37592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.03965F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1284, 701);
            this.tableLayoutPanel1.TabIndex = 18;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // planPanel
            // 
            this.planPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planPanel.Controls.Add(this.tableLayoutPanel6);
            this.planPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planPanel.Location = new System.Drawing.Point(265, 301);
            this.planPanel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.planPanel.Name = "planPanel";
            this.planPanel.Padding = new System.Windows.Forms.Padding(2);
            this.planPanel.Size = new System.Drawing.Size(804, 162);
            this.planPanel.TabIndex = 17;
            this.planPanel.TabStop = false;
            this.planPanel.Text = "Plan de Cliente";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.45844F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.79356F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.61941F));
            this.tableLayoutPanel6.Controls.Add(this.cuotaTb, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.cuotaLb, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.planLb, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.comboBoxPlanes, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(29, 41);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(746, 104);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // cuotaTb
            // 
            this.cuotaTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuotaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaTb.Location = new System.Drawing.Point(177, 54);
            this.cuotaTb.Margin = new System.Windows.Forms.Padding(2);
            this.cuotaTb.Name = "cuotaTb";
            this.cuotaTb.Size = new System.Drawing.Size(360, 44);
            this.cuotaTb.TabIndex = 10;
            // 
            // cuotaLb
            // 
            this.cuotaLb.AutoSize = true;
            this.cuotaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaLb.Location = new System.Drawing.Point(2, 52);
            this.cuotaLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cuotaLb.Name = "cuotaLb";
            this.cuotaLb.Size = new System.Drawing.Size(112, 37);
            this.cuotaLb.TabIndex = 4;
            this.cuotaLb.Text = "Cuota:";
            // 
            // planLb
            // 
            this.planLb.AutoSize = true;
            this.planLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planLb.Location = new System.Drawing.Point(2, 0);
            this.planLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.planLb.Name = "planLb";
            this.planLb.Size = new System.Drawing.Size(90, 37);
            this.planLb.TabIndex = 3;
            this.planLb.Text = "Plan:";
            // 
            // comboBoxPlanes
            // 
            this.comboBoxPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPlanes.FormattingEnabled = true;
            this.comboBoxPlanes.Location = new System.Drawing.Point(178, 3);
            this.comboBoxPlanes.Name = "comboBoxPlanes";
            this.comboBoxPlanes.Size = new System.Drawing.Size(358, 45);
            this.comboBoxPlanes.TabIndex = 18;
            this.comboBoxPlanes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlanes_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.modificarClienteCb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.clienteNuevoCb, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 12);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22772F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.77228F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 285);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.registrarClienteBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.modificarBtn, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1091, 12);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.61922F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.38078F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(171, 285);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // registrarClienteBtn
            // 
            this.registrarClienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registrarClienteBtn.AutoSize = true;
            this.registrarClienteBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.registrarClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarClienteBtn.Location = new System.Drawing.Point(2, 2);
            this.registrarClienteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registrarClienteBtn.Name = "registrarClienteBtn";
            this.registrarClienteBtn.Size = new System.Drawing.Size(167, 92);
            this.registrarClienteBtn.TabIndex = 20;
            this.registrarClienteBtn.Text = "Registrar cliente";
            this.registrarClienteBtn.UseVisualStyleBackColor = false;
            this.registrarClienteBtn.Click += new System.EventHandler(this.registrarClienteBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modificarBtn.AutoSize = true;
            this.modificarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBtn.Location = new System.Drawing.Point(2, 160);
            this.modificarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(167, 96);
            this.modificarBtn.TabIndex = 21;
            this.modificarBtn.Text = "Modificar Cliente";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click_1);
            // 
            // clientePanel
            // 
            this.clientePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientePanel.Controls.Add(this.tableLayoutPanel5);
            this.clientePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientePanel.Location = new System.Drawing.Point(265, 12);
            this.clientePanel.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.clientePanel.Name = "clientePanel";
            this.clientePanel.Padding = new System.Windows.Forms.Padding(2);
            this.clientePanel.Size = new System.Drawing.Size(804, 285);
            this.clientePanel.TabIndex = 12;
            this.clientePanel.TabStop = false;
            this.clientePanel.Text = "Cliente Seleccionado";
            this.clientePanel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.3871F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.11828F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31541F));
            this.tableLayoutPanel5.Controls.Add(this.nombreLb, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.telefonoLb, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.estadoLb, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.nombreTb, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buscarClienteBtn, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.telefonoTb, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.saldoTb, 1, 2);
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(29, 46);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(746, 216);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // nombreLb
            // 
            this.nombreLb.AutoSize = true;
            this.nombreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLb.Location = new System.Drawing.Point(2, 0);
            this.nombreLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(124, 37);
            this.nombreLb.TabIndex = 1;
            this.nombreLb.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saldo:";
            // 
            // telefonoLb
            // 
            this.telefonoLb.AutoSize = true;
            this.telefonoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLb.Location = new System.Drawing.Point(2, 54);
            this.telefonoLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telefonoLb.Name = "telefonoLb";
            this.telefonoLb.Size = new System.Drawing.Size(150, 37);
            this.telefonoLb.TabIndex = 2;
            this.telefonoLb.Text = "Telefono:";
            // 
            // estadoLb
            // 
            this.estadoLb.AutoSize = true;
            this.estadoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoLb.Location = new System.Drawing.Point(2, 162);
            this.estadoLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estadoLb.Name = "estadoLb";
            this.estadoLb.Size = new System.Drawing.Size(126, 37);
            this.estadoLb.TabIndex = 14;
            this.estadoLb.Text = "Estado:";
            // 
            // nombreTb
            // 
            this.nombreTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTb.Location = new System.Drawing.Point(176, 2);
            this.nombreTb.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTb.Name = "nombreTb";
            this.nombreTb.Size = new System.Drawing.Size(355, 44);
            this.nombreTb.TabIndex = 7;
            // 
            // buscarClienteBtn
            // 
            this.buscarClienteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarClienteBtn.AutoSize = true;
            this.buscarClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarClienteBtn.Location = new System.Drawing.Point(551, 2);
            this.buscarClienteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buscarClienteBtn.Name = "buscarClienteBtn";
            this.buscarClienteBtn.Size = new System.Drawing.Size(193, 47);
            this.buscarClienteBtn.TabIndex = 12;
            this.buscarClienteBtn.Text = "Seleccionar";
            this.buscarClienteBtn.UseVisualStyleBackColor = true;
            this.buscarClienteBtn.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // telefonoTb
            // 
            this.telefonoTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telefonoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTb.Location = new System.Drawing.Point(176, 56);
            this.telefonoTb.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoTb.Name = "telefonoTb";
            this.telefonoTb.Size = new System.Drawing.Size(355, 44);
            this.telefonoTb.TabIndex = 9;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.bajaCb, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.altaCb, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(177, 165);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(353, 48);
            this.tableLayoutPanel8.TabIndex = 17;
            // 
            // bajaCb
            // 
            this.bajaCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bajaCb.AutoSize = true;
            this.bajaCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajaCb.Location = new System.Drawing.Point(252, 2);
            this.bajaCb.Margin = new System.Windows.Forms.Padding(2);
            this.bajaCb.Name = "bajaCb";
            this.bajaCb.Size = new System.Drawing.Size(99, 41);
            this.bajaCb.TabIndex = 16;
            this.bajaCb.TabStop = true;
            this.bajaCb.Text = "Baja";
            this.bajaCb.UseVisualStyleBackColor = true;
            this.bajaCb.CheckedChanged += new System.EventHandler(this.bajaCb_CheckedChanged);
            // 
            // altaCb
            // 
            this.altaCb.AutoSize = true;
            this.altaCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaCb.Location = new System.Drawing.Point(2, 2);
            this.altaCb.Margin = new System.Windows.Forms.Padding(2);
            this.altaCb.Name = "altaCb";
            this.altaCb.Size = new System.Drawing.Size(91, 41);
            this.altaCb.TabIndex = 15;
            this.altaCb.TabStop = true;
            this.altaCb.Text = "Alta";
            this.altaCb.UseVisualStyleBackColor = true;
            this.altaCb.CheckedChanged += new System.EventHandler(this.altaCb_CheckedChanged);
            // 
            // saldoTb
            // 
            this.saldoTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saldoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoTb.Location = new System.Drawing.Point(176, 110);
            this.saldoTb.Margin = new System.Windows.Forms.Padding(2);
            this.saldoTb.Name = "saldoTb";
            this.saldoTb.Size = new System.Drawing.Size(355, 44);
            this.saldoTb.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.volverBtn, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(33, 468);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 220);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.pagoPanel.ResumeLayout(false);
            this.pagoPanel.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.planPanel.ResumeLayout(false);
            this.planPanel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.clientePanel.ResumeLayout(false);
            this.clientePanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox clienteNuevoCb;
        private System.Windows.Forms.CheckBox modificarClienteCb;
        private System.Windows.Forms.Button limpiarPantalla;
        private System.Windows.Forms.Button resumenCuentaBtn;
        private System.Windows.Forms.GroupBox pagoPanel;
        private System.Windows.Forms.TextBox descuentoTb;
        private System.Windows.Forms.TextBox transferenciaTb;
        private System.Windows.Forms.Label transferenciaLb;
        private System.Windows.Forms.Label efectivoLb;
        private System.Windows.Forms.TextBox efectivoTb;
        private System.Windows.Forms.Button registrarPagoBtn;
        private System.Windows.Forms.Label descuentoLb;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox planPanel;
        private System.Windows.Forms.Label cuotaLb;
        private System.Windows.Forms.Label planLb;
        private System.Windows.Forms.TextBox cuotaTb;
        private System.Windows.Forms.RadioButton bajaCb;
        private System.Windows.Forms.RadioButton altaCb;
        private System.Windows.Forms.Label estadoLb;
        private System.Windows.Forms.Button buscarClienteBtn;
        private System.Windows.Forms.TextBox saldoTb;
        private System.Windows.Forms.Label nombreLb;
        private System.Windows.Forms.Label telefonoLb;
        private System.Windows.Forms.TextBox telefonoTb;
        private System.Windows.Forms.TextBox nombreTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button registrarClienteBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox clientePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBoxPlanes;
    }
}