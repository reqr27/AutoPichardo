namespace ImporteVehiculos.Formularios
{
    partial class AgregarComponentesGastosVehiculoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarComponentesGastosVehiculoForm));
            this.descripcion_cb = new System.Windows.Forms.ComboBox();
            this.descripcion_lbl = new System.Windows.Forms.Label();
            this.tasa_lbl = new System.Windows.Forms.LinkLabel();
            this.usdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.rdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.precio_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taller_lbl = new System.Windows.Forms.Label();
            this.taller_cb = new System.Windows.Forms.ComboBox();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.nuevo_lnklbl = new System.Windows.Forms.LinkLabel();
            this.agregarTaller_lnklbl = new System.Windows.Forms.LinkLabel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pagos_dtg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_txt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tipoPago_cb = new System.Windows.Forms.ComboBox();
            this.agregarPago_btn = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.notaPago_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombreForm_lbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.restante_USD_lbl = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.totalUSD_lbl = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.restante_RD_lbl = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.totalRD_lbl = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.precioUsd_lbl = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.precioRd_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha_dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pagos_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcion_cb
            // 
            this.descripcion_cb.DropDownHeight = 180;
            this.descripcion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcion_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_cb.FormattingEnabled = true;
            this.descripcion_cb.IntegralHeight = false;
            this.descripcion_cb.Location = new System.Drawing.Point(156, 52);
            this.descripcion_cb.Name = "descripcion_cb";
            this.descripcion_cb.Size = new System.Drawing.Size(301, 22);
            this.descripcion_cb.TabIndex = 5;
            this.descripcion_cb.SelectedIndexChanged += new System.EventHandler(this.descripcion_cb_SelectedIndexChanged);
            // 
            // descripcion_lbl
            // 
            this.descripcion_lbl.AutoSize = true;
            this.descripcion_lbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_lbl.Location = new System.Drawing.Point(8, 59);
            this.descripcion_lbl.Name = "descripcion_lbl";
            this.descripcion_lbl.Size = new System.Drawing.Size(24, 14);
            this.descripcion_lbl.TabIndex = 26;
            this.descripcion_lbl.Text = "lbl";
            // 
            // tasa_lbl
            // 
            this.tasa_lbl.AutoSize = true;
            this.tasa_lbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasa_lbl.Location = new System.Drawing.Point(153, 128);
            this.tasa_lbl.Name = "tasa_lbl";
            this.tasa_lbl.Size = new System.Drawing.Size(84, 14);
            this.tasa_lbl.TabIndex = 31;
            this.tasa_lbl.TabStop = true;
            this.tasa_lbl.Text = "1.00 USD$ ->";
            this.tasa_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tasa_lbl_LinkClicked);
            // 
            // usdDinero_radiobtn
            // 
            this.usdDinero_radiobtn.AutoSize = true;
            this.usdDinero_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdDinero_radiobtn.Location = new System.Drawing.Point(83, 126);
            this.usdDinero_radiobtn.Name = "usdDinero_radiobtn";
            this.usdDinero_radiobtn.Size = new System.Drawing.Size(56, 18);
            this.usdDinero_radiobtn.TabIndex = 28;
            this.usdDinero_radiobtn.Text = "USD$";
            this.usdDinero_radiobtn.UseVisualStyleBackColor = true;
            // 
            // rdDinero_radiobtn
            // 
            this.rdDinero_radiobtn.AutoSize = true;
            this.rdDinero_radiobtn.Checked = true;
            this.rdDinero_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDinero_radiobtn.Location = new System.Drawing.Point(12, 126);
            this.rdDinero_radiobtn.Name = "rdDinero_radiobtn";
            this.rdDinero_radiobtn.Size = new System.Drawing.Size(50, 18);
            this.rdDinero_radiobtn.TabIndex = 30;
            this.rdDinero_radiobtn.TabStop = true;
            this.rdDinero_radiobtn.Tag = "4";
            this.rdDinero_radiobtn.Text = "RD$";
            this.rdDinero_radiobtn.UseVisualStyleBackColor = true;
            this.rdDinero_radiobtn.CheckedChanged += new System.EventHandler(this.rdDinero_radiobtn_CheckedChanged);
            // 
            // precio_txt
            // 
            this.precio_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_txt.Location = new System.Drawing.Point(156, 153);
            this.precio_txt.Name = "precio_txt";
            this.precio_txt.Size = new System.Drawing.Size(101, 20);
            this.precio_txt.TabIndex = 29;
            this.precio_txt.TextChanged += new System.EventHandler(this.precio_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "PRECIO TOTAL:";
            // 
            // taller_lbl
            // 
            this.taller_lbl.AutoSize = true;
            this.taller_lbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taller_lbl.Location = new System.Drawing.Point(9, 93);
            this.taller_lbl.Name = "taller_lbl";
            this.taller_lbl.Size = new System.Drawing.Size(132, 14);
            this.taller_lbl.TabIndex = 33;
            this.taller_lbl.Text = "TALLER/REPUESTO:";
            // 
            // taller_cb
            // 
            this.taller_cb.DropDownHeight = 180;
            this.taller_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taller_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taller_cb.FormattingEnabled = true;
            this.taller_cb.IntegralHeight = false;
            this.taller_cb.Location = new System.Drawing.Point(156, 86);
            this.taller_cb.Name = "taller_cb";
            this.taller_cb.Size = new System.Drawing.Size(301, 22);
            this.taller_cb.TabIndex = 34;
            // 
            // guardar_btn
            // 
            this.guardar_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardar_btn.Location = new System.Drawing.Point(410, 353);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(118, 47);
            this.guardar_btn.TabIndex = 32;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // nuevo_lnklbl
            // 
            this.nuevo_lnklbl.AutoSize = true;
            this.nuevo_lnklbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_lnklbl.Location = new System.Drawing.Point(463, 59);
            this.nuevo_lnklbl.Name = "nuevo_lnklbl";
            this.nuevo_lnklbl.Size = new System.Drawing.Size(45, 15);
            this.nuevo_lnklbl.TabIndex = 35;
            this.nuevo_lnklbl.TabStop = true;
            this.nuevo_lnklbl.Text = "Añadir";
            this.nuevo_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nuevo_lnklbl_LinkClicked);
            // 
            // agregarTaller_lnklbl
            // 
            this.agregarTaller_lnklbl.AutoSize = true;
            this.agregarTaller_lnklbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarTaller_lnklbl.Location = new System.Drawing.Point(463, 93);
            this.agregarTaller_lnklbl.Name = "agregarTaller_lnklbl";
            this.agregarTaller_lnklbl.Size = new System.Drawing.Size(45, 15);
            this.agregarTaller_lnklbl.TabIndex = 36;
            this.agregarTaller_lnklbl.TabStop = true;
            this.agregarTaller_lnklbl.Text = "Añadir";
            this.agregarTaller_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agregarTaller_lnklbl_LinkClicked);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 184);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 14);
            this.label23.TabIndex = 134;
            this.label23.Text = "FORMA PAGO: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(9, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 14);
            this.label24.TabIndex = 131;
            this.label24.Text = "MONTO:";
            // 
            // pagos_dtg
            // 
            this.pagos_dtg.AllowUserToAddRows = false;
            this.pagos_dtg.AllowUserToDeleteRows = false;
            this.pagos_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.pagos_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.pagos_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagos_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn5});
            this.pagos_dtg.Location = new System.Drawing.Point(8, 314);
            this.pagos_dtg.MultiSelect = false;
            this.pagos_dtg.Name = "pagos_dtg";
            this.pagos_dtg.ReadOnly = true;
            this.pagos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pagos_dtg.Size = new System.Drawing.Size(348, 111);
            this.pagos_dtg.TabIndex = 139;
            this.pagos_dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagos_dtg_CellClick);
            this.pagos_dtg.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.pagos_dtg_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo de Pago";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 88;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "VALOR ($RD)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 91;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "VALOR ($USD)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 97;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DETALLES";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "ELIMINAR";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Width = 83;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "idTipoPAgo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 87;
            // 
            // monto_txt
            // 
            this.monto_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto_txt.Location = new System.Drawing.Point(156, 213);
            this.monto_txt.Name = "monto_txt";
            this.monto_txt.Size = new System.Drawing.Size(150, 20);
            this.monto_txt.TabIndex = 132;
            this.monto_txt.TextChanged += new System.EventHandler(this.monto_txt_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 297);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 14);
            this.label25.TabIndex = 138;
            this.label25.Text = "LISTADO PAGOS";
            // 
            // tipoPago_cb
            // 
            this.tipoPago_cb.DropDownHeight = 180;
            this.tipoPago_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPago_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPago_cb.FormattingEnabled = true;
            this.tipoPago_cb.IntegralHeight = false;
            this.tipoPago_cb.Location = new System.Drawing.Point(156, 179);
            this.tipoPago_cb.Name = "tipoPago_cb";
            this.tipoPago_cb.Size = new System.Drawing.Size(246, 22);
            this.tipoPago_cb.TabIndex = 133;
            // 
            // agregarPago_btn
            // 
            this.agregarPago_btn.FlatAppearance.BorderSize = 0;
            this.agregarPago_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.agregarPago_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregarPago_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarPago_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarPago_btn.Image = global::ImporteVehiculos.Properties.Resources.circulo_de_suma;
            this.agregarPago_btn.Location = new System.Drawing.Point(298, 255);
            this.agregarPago_btn.Name = "agregarPago_btn";
            this.agregarPago_btn.Size = new System.Drawing.Size(58, 42);
            this.agregarPago_btn.TabIndex = 137;
            this.agregarPago_btn.UseVisualStyleBackColor = true;
            this.agregarPago_btn.Click += new System.EventHandler(this.agregarPago_btn_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(9, 237);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 14);
            this.label26.TabIndex = 135;
            this.label26.Text = "NOTA PAGO:";
            // 
            // notaPago_txt
            // 
            this.notaPago_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaPago_txt.Location = new System.Drawing.Point(9, 255);
            this.notaPago_txt.Multiline = true;
            this.notaPago_txt.Name = "notaPago_txt";
            this.notaPago_txt.Size = new System.Drawing.Size(256, 36);
            this.notaPago_txt.TabIndex = 136;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.nombreForm_lbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 46);
            this.panel3.TabIndex = 140;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(520, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 31;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(551, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombreForm_lbl
            // 
            this.nombreForm_lbl.AutoSize = true;
            this.nombreForm_lbl.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreForm_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.nombreForm_lbl.Location = new System.Drawing.Point(12, 9);
            this.nombreForm_lbl.Name = "nombreForm_lbl";
            this.nombreForm_lbl.Size = new System.Drawing.Size(68, 24);
            this.nombreForm_lbl.TabIndex = 28;
            this.nombreForm_lbl.Text = "Form";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.label39);
            this.panel7.Controls.Add(this.label40);
            this.panel7.Controls.Add(this.restante_USD_lbl);
            this.panel7.Controls.Add(this.label42);
            this.panel7.Controls.Add(this.totalUSD_lbl);
            this.panel7.Controls.Add(this.label44);
            this.panel7.Controls.Add(this.label45);
            this.panel7.Controls.Add(this.restante_RD_lbl);
            this.panel7.Controls.Add(this.label47);
            this.panel7.Controls.Add(this.totalRD_lbl);
            this.panel7.Controls.Add(this.label49);
            this.panel7.Controls.Add(this.precioUsd_lbl);
            this.panel7.Controls.Add(this.label51);
            this.panel7.Controls.Add(this.precioRd_lbl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 432);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(593, 112);
            this.panel7.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(457, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "________________";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label38.Location = new System.Drawing.Point(457, 37);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(11, 13);
            this.label38.TabIndex = 94;
            this.label38.Text = "-";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label39.Location = new System.Drawing.Point(164, 37);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(11, 13);
            this.label39.TabIndex = 93;
            this.label39.Text = "-";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label40.Location = new System.Drawing.Point(299, 87);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(118, 13);
            this.label40.TabIndex = 90;
            this.label40.Text = "RESTANTE($USD):";
            // 
            // restante_USD_lbl
            // 
            this.restante_USD_lbl.AutoSize = true;
            this.restante_USD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_USD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restante_USD_lbl.Location = new System.Drawing.Point(476, 87);
            this.restante_USD_lbl.Name = "restante_USD_lbl";
            this.restante_USD_lbl.Size = new System.Drawing.Size(21, 13);
            this.restante_USD_lbl.TabIndex = 91;
            this.restante_USD_lbl.Text = "pv";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label42.Location = new System.Drawing.Point(299, 42);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(86, 13);
            this.label42.TabIndex = 88;
            this.label42.Text = "PAGO($USD):";
            // 
            // totalUSD_lbl
            // 
            this.totalUSD_lbl.AutoSize = true;
            this.totalUSD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUSD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.totalUSD_lbl.Location = new System.Drawing.Point(476, 42);
            this.totalUSD_lbl.Name = "totalUSD_lbl";
            this.totalUSD_lbl.Size = new System.Drawing.Size(21, 13);
            this.totalUSD_lbl.TabIndex = 89;
            this.totalUSD_lbl.Text = "pv";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label44.Location = new System.Drawing.Point(164, 62);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(119, 13);
            this.label44.TabIndex = 87;
            this.label44.Text = "________________";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label45.Location = new System.Drawing.Point(11, 87);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(110, 13);
            this.label45.TabIndex = 85;
            this.label45.Text = "RESTANTE($RD):";
            // 
            // restante_RD_lbl
            // 
            this.restante_RD_lbl.AutoSize = true;
            this.restante_RD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_RD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restante_RD_lbl.Location = new System.Drawing.Point(181, 87);
            this.restante_RD_lbl.Name = "restante_RD_lbl";
            this.restante_RD_lbl.Size = new System.Drawing.Size(21, 13);
            this.restante_RD_lbl.TabIndex = 86;
            this.restante_RD_lbl.Text = "pv";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label47.Location = new System.Drawing.Point(11, 42);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(78, 13);
            this.label47.TabIndex = 83;
            this.label47.Text = "PAGO($RD):";
            // 
            // totalRD_lbl
            // 
            this.totalRD_lbl.AutoSize = true;
            this.totalRD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.totalRD_lbl.Location = new System.Drawing.Point(184, 42);
            this.totalRD_lbl.Name = "totalRD_lbl";
            this.totalRD_lbl.Size = new System.Drawing.Size(21, 13);
            this.totalRD_lbl.TabIndex = 84;
            this.totalRD_lbl.Text = "pv";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label49.Location = new System.Drawing.Point(11, 12);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(160, 13);
            this.label49.TabIndex = 79;
            this.label49.Text = "PRECIO TRASPASO($RD):";
            // 
            // precioUsd_lbl
            // 
            this.precioUsd_lbl.AutoSize = true;
            this.precioUsd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioUsd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.precioUsd_lbl.Location = new System.Drawing.Point(476, 12);
            this.precioUsd_lbl.Name = "precioUsd_lbl";
            this.precioUsd_lbl.Size = new System.Drawing.Size(21, 13);
            this.precioUsd_lbl.TabIndex = 82;
            this.precioUsd_lbl.Text = "pv";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label51.Location = new System.Drawing.Point(299, 12);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(168, 13);
            this.label51.TabIndex = 80;
            this.label51.Text = "PRECIO TRASPASO($USD):";
            // 
            // precioRd_lbl
            // 
            this.precioRd_lbl.AutoSize = true;
            this.precioRd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioRd_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.precioRd_lbl.Location = new System.Drawing.Point(184, 12);
            this.precioRd_lbl.Name = "precioRd_lbl";
            this.precioRd_lbl.Size = new System.Drawing.Size(21, 13);
            this.precioRd_lbl.TabIndex = 81;
            this.precioRd_lbl.Text = "pv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(295, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 14);
            this.label8.TabIndex = 143;
            this.label8.Text = "FECHA:";
            // 
            // fecha_dtp
            // 
            this.fecha_dtp.CustomFormat = "dd/MM/yyyy";
            this.fecha_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_dtp.Location = new System.Drawing.Point(356, 150);
            this.fecha_dtp.Name = "fecha_dtp";
            this.fecha_dtp.Size = new System.Drawing.Size(97, 20);
            this.fecha_dtp.TabIndex = 142;
            // 
            // AgregarComponentesGastosVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 544);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fecha_dtp);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.pagos_dtg);
            this.Controls.Add(this.monto_txt);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tipoPago_cb);
            this.Controls.Add(this.agregarPago_btn);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.notaPago_txt);
            this.Controls.Add(this.agregarTaller_lnklbl);
            this.Controls.Add(this.nuevo_lnklbl);
            this.Controls.Add(this.taller_cb);
            this.Controls.Add(this.taller_lbl);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.tasa_lbl);
            this.Controls.Add(this.usdDinero_radiobtn);
            this.Controls.Add(this.rdDinero_radiobtn);
            this.Controls.Add(this.precio_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion_lbl);
            this.Controls.Add(this.descripcion_cb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarComponentesGastosVehiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgregarComponentesGastosVehiculoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagos_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox descripcion_cb;
        private System.Windows.Forms.Label descripcion_lbl;
        private System.Windows.Forms.LinkLabel tasa_lbl;
        private System.Windows.Forms.RadioButton usdDinero_radiobtn;
        private System.Windows.Forms.RadioButton rdDinero_radiobtn;
        private System.Windows.Forms.TextBox precio_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Label taller_lbl;
        private System.Windows.Forms.ComboBox taller_cb;
        private System.Windows.Forms.LinkLabel nuevo_lnklbl;
        private System.Windows.Forms.LinkLabel agregarTaller_lnklbl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView pagos_dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox monto_txt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox tipoPago_cb;
        private System.Windows.Forms.Button agregarPago_btn;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox notaPago_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nombreForm_lbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label restante_USD_lbl;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label totalUSD_lbl;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label restante_RD_lbl;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label totalRD_lbl;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label precioUsd_lbl;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label precioRd_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha_dtp;
    }
}