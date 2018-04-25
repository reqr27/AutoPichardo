namespace ImporteVehiculos.Formularios
{
    partial class ReportesVentana
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesVentana));
            this.desde_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.hasta_dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estado_cb = new System.Windows.Forms.ComboBox();
            this.propietario_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoTransaccion_cb = new System.Windows.Forms.ComboBox();
            this.usdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.rdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.reportes_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.vin_text = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.vehiculos_dtg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.repGeneral_btn = new System.Windows.Forms.Button();
            this.reporte_btn = new System.Windows.Forms.Button();
            this.repIndividual_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // desde_dtp
            // 
            this.desde_dtp.CustomFormat = "dd/MM/yyyy";
            this.desde_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde_dtp.Location = new System.Drawing.Point(98, 42);
            this.desde_dtp.Name = "desde_dtp";
            this.desde_dtp.Size = new System.Drawing.Size(95, 20);
            this.desde_dtp.TabIndex = 52;
            this.desde_dtp.ValueChanged += new System.EventHandler(this.desde_dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Desde:";
            // 
            // hasta_dtp
            // 
            this.hasta_dtp.CustomFormat = "dd/MM/yyyy";
            this.hasta_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hasta_dtp.Location = new System.Drawing.Point(98, 68);
            this.hasta_dtp.Name = "hasta_dtp";
            this.hasta_dtp.Size = new System.Drawing.Size(95, 20);
            this.hasta_dtp.TabIndex = 54;
            this.hasta_dtp.ValueChanged += new System.EventHandler(this.hasta_dtp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(382, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Estado:";
            this.label3.Visible = false;
            // 
            // estado_cb
            // 
            this.estado_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_cb.FormattingEnabled = true;
            this.estado_cb.Items.AddRange(new object[] {
            "En Proceso",
            "Terminado",
            "Vendido"});
            this.estado_cb.Location = new System.Drawing.Point(488, 31);
            this.estado_cb.Name = "estado_cb";
            this.estado_cb.Size = new System.Drawing.Size(137, 23);
            this.estado_cb.TabIndex = 58;
            this.estado_cb.Visible = false;
            this.estado_cb.SelectedIndexChanged += new System.EventHandler(this.estado_cb_SelectedIndexChanged);
            // 
            // propietario_cb
            // 
            this.propietario_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propietario_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propietario_cb.FormattingEnabled = true;
            this.propietario_cb.Items.AddRange(new object[] {
            "En Proceso",
            "Terminado",
            "Vendido"});
            this.propietario_cb.Location = new System.Drawing.Point(488, 56);
            this.propietario_cb.Name = "propietario_cb";
            this.propietario_cb.Size = new System.Drawing.Size(137, 23);
            this.propietario_cb.TabIndex = 62;
            this.propietario_cb.Visible = false;
            this.propietario_cb.SelectedIndexChanged += new System.EventHandler(this.propietario_cb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(382, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Propietario:";
            this.label5.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.vin_text);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 153);
            this.panel3.TabIndex = 88;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tipoTransaccion_cb);
            this.panel2.Controls.Add(this.usdDinero_radiobtn);
            this.panel2.Controls.Add(this.rdDinero_radiobtn);
            this.panel2.Controls.Add(this.reportes_cb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.reset_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buscar_btn);
            this.panel2.Controls.Add(this.estado_cb);
            this.panel2.Controls.Add(this.desde_dtp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.propietario_cb);
            this.panel2.Controls.Add(this.hasta_dtp);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 117);
            this.panel2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(382, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 112;
            this.label6.Text = "TRANSACCION: ";
            this.label6.Visible = false;
            // 
            // tipoTransaccion_cb
            // 
            this.tipoTransaccion_cb.DropDownHeight = 180;
            this.tipoTransaccion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoTransaccion_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTransaccion_cb.FormattingEnabled = true;
            this.tipoTransaccion_cb.IntegralHeight = false;
            this.tipoTransaccion_cb.Items.AddRange(new object[] {
            "EFECTIVO",
            "VEHICULO RECIBIDO"});
            this.tipoTransaccion_cb.Location = new System.Drawing.Point(489, 85);
            this.tipoTransaccion_cb.Name = "tipoTransaccion_cb";
            this.tipoTransaccion_cb.Size = new System.Drawing.Size(136, 23);
            this.tipoTransaccion_cb.TabIndex = 111;
            this.tipoTransaccion_cb.Visible = false;
            this.tipoTransaccion_cb.SelectionChangeCommitted += new System.EventHandler(this.tipoTransaccion_cb_SelectionChangeCommitted);
            // 
            // usdDinero_radiobtn
            // 
            this.usdDinero_radiobtn.AutoSize = true;
            this.usdDinero_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdDinero_radiobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.usdDinero_radiobtn.Location = new System.Drawing.Point(456, 8);
            this.usdDinero_radiobtn.Name = "usdDinero_radiobtn";
            this.usdDinero_radiobtn.Size = new System.Drawing.Size(57, 19);
            this.usdDinero_radiobtn.TabIndex = 109;
            this.usdDinero_radiobtn.Text = "USD$";
            this.usdDinero_radiobtn.UseVisualStyleBackColor = true;
            this.usdDinero_radiobtn.Visible = false;
            // 
            // rdDinero_radiobtn
            // 
            this.rdDinero_radiobtn.AutoSize = true;
            this.rdDinero_radiobtn.Checked = true;
            this.rdDinero_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDinero_radiobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.rdDinero_radiobtn.Location = new System.Drawing.Point(385, 8);
            this.rdDinero_radiobtn.Name = "rdDinero_radiobtn";
            this.rdDinero_radiobtn.Size = new System.Drawing.Size(49, 19);
            this.rdDinero_radiobtn.TabIndex = 110;
            this.rdDinero_radiobtn.TabStop = true;
            this.rdDinero_radiobtn.Tag = "4";
            this.rdDinero_radiobtn.Text = "RD$";
            this.rdDinero_radiobtn.UseVisualStyleBackColor = true;
            this.rdDinero_radiobtn.Visible = false;
            this.rdDinero_radiobtn.CheckedChanged += new System.EventHandler(this.rdDinero_radiobtn_CheckedChanged);
            // 
            // reportes_cb
            // 
            this.reportes_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportes_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportes_cb.FormattingEnabled = true;
            this.reportes_cb.Items.AddRange(new object[] {
            "Vehículos Comprados",
            "Vehículos Inventario",
            "Vehículos Vendidos",
            "Historial Facturas",
            "Cuentas por Pagar",
            "Cuentas por Cobrar",
            "Reporte Resultados",
            "Reporte de Efectivo",
            "Historial Recibos Cobros"});
            this.reportes_cb.Location = new System.Drawing.Point(98, 8);
            this.reportes_cb.Name = "reportes_cb";
            this.reportes_cb.Size = new System.Drawing.Size(244, 23);
            this.reportes_cb.TabIndex = 64;
            this.reportes_cb.SelectedIndexChanged += new System.EventHandler(this.reportes_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Reporte:";
            // 
            // reset_btn
            // 
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.reset_btn.Image = global::ImporteVehiculos.Properties.Resources.ajustes1;
            this.reset_btn.Location = new System.Drawing.Point(779, 3);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(99, 96);
            this.reset_btn.TabIndex = 56;
            this.reset_btn.Text = "Reset Filtros";
            this.reset_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Visible = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // buscar_btn
            // 
            this.buscar_btn.FlatAppearance.BorderSize = 0;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buscar_btn.Image = global::ImporteVehiculos.Properties.Resources.icono_de_lupa;
            this.buscar_btn.Location = new System.Drawing.Point(668, 2);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(98, 98);
            this.buscar_btn.TabIndex = 56;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // vin_text
            // 
            this.vin_text.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vin_text.Location = new System.Drawing.Point(504, 7);
            this.vin_text.Name = "vin_text";
            this.vin_text.Size = new System.Drawing.Size(137, 23);
            this.vin_text.TabIndex = 66;
            this.vin_text.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(817, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 31;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label.Location = new System.Drawing.Point(419, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 15);
            this.label.TabIndex = 65;
            this.label.Text = "VIN:";
            this.label.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(849, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "REPORTES\r\n";
            // 
            // vehiculos_dtg
            // 
            this.vehiculos_dtg.AllowUserToAddRows = false;
            this.vehiculos_dtg.AllowUserToDeleteRows = false;
            this.vehiculos_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.vehiculos_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehiculos_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vehiculos_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vehiculos_dtg.DefaultCellStyle = dataGridViewCellStyle2;
            this.vehiculos_dtg.Location = new System.Drawing.Point(15, 159);
            this.vehiculos_dtg.MultiSelect = false;
            this.vehiculos_dtg.Name = "vehiculos_dtg";
            this.vehiculos_dtg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehiculos_dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vehiculos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiculos_dtg.Size = new System.Drawing.Size(856, 296);
            this.vehiculos_dtg.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.repGeneral_btn);
            this.panel1.Controls.Add(this.reporte_btn);
            this.panel1.Controls.Add(this.repIndividual_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 100);
            this.panel1.TabIndex = 90;
            // 
            // repGeneral_btn
            // 
            this.repGeneral_btn.FlatAppearance.BorderSize = 0;
            this.repGeneral_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repGeneral_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repGeneral_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.repGeneral_btn.Image = global::ImporteVehiculos.Properties.Resources.mundo_en_red__1_;
            this.repGeneral_btn.Location = new System.Drawing.Point(224, 3);
            this.repGeneral_btn.Name = "repGeneral_btn";
            this.repGeneral_btn.Size = new System.Drawing.Size(118, 85);
            this.repGeneral_btn.TabIndex = 63;
            this.repGeneral_btn.Text = "Reporte General";
            this.repGeneral_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.repGeneral_btn.UseVisualStyleBackColor = true;
            this.repGeneral_btn.Visible = false;
            this.repGeneral_btn.Click += new System.EventHandler(this.repGeneral_btn_Click);
            // 
            // reporte_btn
            // 
            this.reporte_btn.FlatAppearance.BorderSize = 0;
            this.reporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporte_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.reporte_btn.Image = global::ImporteVehiculos.Properties.Resources.reportar1;
            this.reporte_btn.Location = new System.Drawing.Point(742, 3);
            this.reporte_btn.Name = "reporte_btn";
            this.reporte_btn.Size = new System.Drawing.Size(127, 94);
            this.reporte_btn.TabIndex = 64;
            this.reporte_btn.Text = "Crear Reporte";
            this.reporte_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.reporte_btn.UseVisualStyleBackColor = true;
            this.reporte_btn.Click += new System.EventHandler(this.reporte_btn_Click);
            // 
            // repIndividual_btn
            // 
            this.repIndividual_btn.FlatAppearance.BorderSize = 0;
            this.repIndividual_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repIndividual_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repIndividual_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.repIndividual_btn.Image = global::ImporteVehiculos.Properties.Resources.icon1;
            this.repIndividual_btn.Location = new System.Drawing.Point(365, 3);
            this.repIndividual_btn.Name = "repIndividual_btn";
            this.repIndividual_btn.Size = new System.Drawing.Size(118, 85);
            this.repIndividual_btn.TabIndex = 64;
            this.repIndividual_btn.Text = "Reporte Detallado Vehículo";
            this.repIndividual_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.repIndividual_btn.UseVisualStyleBackColor = true;
            this.repIndividual_btn.Visible = false;
            this.repIndividual_btn.Click += new System.EventHandler(this.repIndividual_btn_Click);
            // 
            // ReportesVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vehiculos_dtg);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportesVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportesVentana_FormClosed);
            this.Load += new System.EventHandler(this.ReportesVentana_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker desde_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hasta_dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estado_cb;
        private System.Windows.Forms.ComboBox propietario_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.ComboBox reportes_cb;
        private System.Windows.Forms.Button repGeneral_btn;
        private System.Windows.Forms.Button repIndividual_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView vehiculos_dtg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reporte_btn;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.TextBox vin_text;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton usdDinero_radiobtn;
        private System.Windows.Forms.RadioButton rdDinero_radiobtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoTransaccion_cb;
    }
}