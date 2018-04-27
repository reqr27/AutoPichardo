namespace ImporteVehiculos.Formularios
{
    partial class ModificarVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarVehiculoForm));
            this.vin_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.propietario_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nota_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nombreV_lbl = new System.Windows.Forms.Label();
            this.acto_venta_chbox = new System.Windows.Forms.CheckBox();
            this.cedula_chbox = new System.Windows.Forms.CheckBox();
            this.mat_chbox = new System.Windows.Forms.CheckBox();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioBtnRD_precio = new System.Windows.Forms.RadioButton();
            this.radioBtnUSD_precio = new System.Windows.Forms.RadioButton();
            this.tasa_lbl = new System.Windows.Forms.LinkLabel();
            this.precio_estimado_venta_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.año_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.suplidor_cb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.color_cb = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.ubicacion_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matricula_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.placa_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fuerzaMotriz_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.millaje_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_dtp = new System.Windows.Forms.DateTimePicker();
            this.ubicacionesHist_dtg = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesHist_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // vin_txt
            // 
            this.vin_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vin_txt.Location = new System.Drawing.Point(3, 144);
            this.vin_txt.Name = "vin_txt";
            this.vin_txt.Size = new System.Drawing.Size(203, 20);
            this.vin_txt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "CHASIS:";
            // 
            // propietario_cb
            // 
            this.propietario_cb.DropDownHeight = 180;
            this.propietario_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propietario_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propietario_cb.FormattingEnabled = true;
            this.propietario_cb.IntegralHeight = false;
            this.propietario_cb.Location = new System.Drawing.Point(3, 184);
            this.propietario_cb.Name = "propietario_cb";
            this.propietario_cb.Size = new System.Drawing.Size(203, 22);
            this.propietario_cb.TabIndex = 5;
            this.propietario_cb.DropDown += new System.EventHandler(this.propietario_cb_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 14);
            this.label7.TabIndex = 47;
            this.label7.Text = "PROPIETARIO:";
            // 
            // nota_txt
            // 
            this.nota_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota_txt.Location = new System.Drawing.Point(541, 86);
            this.nota_txt.Multiline = true;
            this.nota_txt.Name = "nota_txt";
            this.nota_txt.Size = new System.Drawing.Size(330, 64);
            this.nota_txt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 14);
            this.label9.TabIndex = 51;
            this.label9.Text = "DETALLES VEHICULO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 62);
            this.panel1.TabIndex = 53;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(813, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 61;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(14, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "MODIFICAR VEHICULO";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(845, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 60;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.nombreV_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 46);
            this.panel2.TabIndex = 54;
            // 
            // nombreV_lbl
            // 
            this.nombreV_lbl.AutoSize = true;
            this.nombreV_lbl.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreV_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.nombreV_lbl.Location = new System.Drawing.Point(12, 13);
            this.nombreV_lbl.Name = "nombreV_lbl";
            this.nombreV_lbl.Size = new System.Drawing.Size(264, 24);
            this.nombreV_lbl.TabIndex = 28;
            this.nombreV_lbl.Text = "MODIFICAR VEHICULO";
            // 
            // acto_venta_chbox
            // 
            this.acto_venta_chbox.AutoSize = true;
            this.acto_venta_chbox.Location = new System.Drawing.Point(3, 228);
            this.acto_venta_chbox.Name = "acto_venta_chbox";
            this.acto_venta_chbox.Size = new System.Drawing.Size(94, 17);
            this.acto_venta_chbox.TabIndex = 14;
            this.acto_venta_chbox.Text = "Acto de Venta";
            this.acto_venta_chbox.UseVisualStyleBackColor = true;
            // 
            // cedula_chbox
            // 
            this.cedula_chbox.AutoSize = true;
            this.cedula_chbox.Location = new System.Drawing.Point(3, 251);
            this.cedula_chbox.Name = "cedula_chbox";
            this.cedula_chbox.Size = new System.Drawing.Size(108, 17);
            this.cedula_chbox.TabIndex = 15;
            this.cedula_chbox.Text = "Cédula Vendedor";
            this.cedula_chbox.UseVisualStyleBackColor = true;
            // 
            // mat_chbox
            // 
            this.mat_chbox.AutoSize = true;
            this.mat_chbox.Location = new System.Drawing.Point(3, 205);
            this.mat_chbox.Name = "mat_chbox";
            this.mat_chbox.Size = new System.Drawing.Size(109, 17);
            this.mat_chbox.TabIndex = 13;
            this.mat_chbox.Text = "Matrícula Original";
            this.mat_chbox.UseVisualStyleBackColor = true;
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.guardar_btn.FlatAppearance.BorderSize = 0;
            this.guardar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.guardar_btn.Image = global::ImporteVehiculos.Properties.Resources.un_par_de_flechas_cambiando_lugares;
            this.guardar_btn.Location = new System.Drawing.Point(541, 319);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(122, 56);
            this.guardar_btn.TabIndex = 17;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cancelar_btn.FlatAppearance.BorderSize = 0;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelar_btn.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.cancelar_btn.Location = new System.Drawing.Point(749, 319);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(122, 56);
            this.cancelar_btn.TabIndex = 18;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelar_btn.UseVisualStyleBackColor = false;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioBtnRD_precio);
            this.panel3.Controls.Add(this.radioBtnUSD_precio);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 24);
            this.panel3.TabIndex = 122;
            // 
            // radioBtnRD_precio
            // 
            this.radioBtnRD_precio.AutoSize = true;
            this.radioBtnRD_precio.Checked = true;
            this.radioBtnRD_precio.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRD_precio.Location = new System.Drawing.Point(3, 3);
            this.radioBtnRD_precio.Name = "radioBtnRD_precio";
            this.radioBtnRD_precio.Size = new System.Drawing.Size(49, 19);
            this.radioBtnRD_precio.TabIndex = 0;
            this.radioBtnRD_precio.TabStop = true;
            this.radioBtnRD_precio.Tag = "4";
            this.radioBtnRD_precio.Text = "RD$";
            this.radioBtnRD_precio.UseVisualStyleBackColor = true;
            this.radioBtnRD_precio.CheckedChanged += new System.EventHandler(this.radioBtnRD_precio_CheckedChanged);
            // 
            // radioBtnUSD_precio
            // 
            this.radioBtnUSD_precio.AutoSize = true;
            this.radioBtnUSD_precio.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUSD_precio.Location = new System.Drawing.Point(57, 3);
            this.radioBtnUSD_precio.Name = "radioBtnUSD_precio";
            this.radioBtnUSD_precio.Size = new System.Drawing.Size(57, 19);
            this.radioBtnUSD_precio.TabIndex = 1;
            this.radioBtnUSD_precio.Text = "USD$";
            this.radioBtnUSD_precio.UseVisualStyleBackColor = true;
            // 
            // tasa_lbl
            // 
            this.tasa_lbl.AutoSize = true;
            this.tasa_lbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasa_lbl.Location = new System.Drawing.Point(3, 30);
            this.tasa_lbl.Name = "tasa_lbl";
            this.tasa_lbl.Size = new System.Drawing.Size(83, 15);
            this.tasa_lbl.TabIndex = 121;
            this.tasa_lbl.TabStop = true;
            this.tasa_lbl.Text = "1.00 USD$ ->";
            this.tasa_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tasa_lbl_LinkClicked);
            // 
            // precio_estimado_venta_txt
            // 
            this.precio_estimado_venta_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_estimado_venta_txt.Location = new System.Drawing.Point(3, 62);
            this.precio_estimado_venta_txt.Name = "precio_estimado_venta_txt";
            this.precio_estimado_venta_txt.Size = new System.Drawing.Size(203, 20);
            this.precio_estimado_venta_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 14);
            this.label2.TabIndex = 123;
            this.label2.Text = "PRECIO ESTIMADO VENTA:";
            // 
            // año_cb
            // 
            this.año_cb.DropDownHeight = 180;
            this.año_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.año_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año_cb.FormattingEnabled = true;
            this.año_cb.IntegralHeight = false;
            this.año_cb.Location = new System.Drawing.Point(3, 102);
            this.año_cb.Name = "año_cb";
            this.año_cb.Size = new System.Drawing.Size(203, 22);
            this.año_cb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 126;
            this.label3.Text = "AÑO:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.tasa_lbl);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.precio_estimado_venta_txt);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.año_cb);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.vin_txt);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.propietario_cb);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.suplidor_cb);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.color_cb);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 302);
            this.flowLayoutPanel1.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 129;
            this.label5.Text = "SUPLIDOR:";
            // 
            // suplidor_cb
            // 
            this.suplidor_cb.DropDownHeight = 180;
            this.suplidor_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suplidor_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidor_cb.FormattingEnabled = true;
            this.suplidor_cb.IntegralHeight = false;
            this.suplidor_cb.Location = new System.Drawing.Point(3, 226);
            this.suplidor_cb.Name = "suplidor_cb";
            this.suplidor_cb.Size = new System.Drawing.Size(203, 22);
            this.suplidor_cb.TabIndex = 6;
            this.suplidor_cb.DropDown += new System.EventHandler(this.suplidor_cb_DropDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 14);
            this.label10.TabIndex = 130;
            this.label10.Text = "COLOR:";
            // 
            // color_cb
            // 
            this.color_cb.DropDownHeight = 180;
            this.color_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_cb.FormattingEnabled = true;
            this.color_cb.IntegralHeight = false;
            this.color_cb.Location = new System.Drawing.Point(3, 268);
            this.color_cb.Name = "color_cb";
            this.color_cb.Size = new System.Drawing.Size(203, 22);
            this.color_cb.TabIndex = 7;
            this.color_cb.DropDown += new System.EventHandler(this.color_cb_DropDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.ubicacion_cb);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.matricula_txt);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.placa_txt);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.fuerzaMotriz_txt);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.millaje_txt);
            this.flowLayoutPanel2.Controls.Add(this.mat_chbox);
            this.flowLayoutPanel2.Controls.Add(this.acto_venta_chbox);
            this.flowLayoutPanel2.Controls.Add(this.cedula_chbox);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(263, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(269, 302);
            this.flowLayoutPanel2.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 131;
            this.label12.Text = "UBICACION:";
            // 
            // ubicacion_cb
            // 
            this.ubicacion_cb.DropDownHeight = 180;
            this.ubicacion_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ubicacion_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacion_cb.FormattingEnabled = true;
            this.ubicacion_cb.IntegralHeight = false;
            this.ubicacion_cb.Location = new System.Drawing.Point(3, 17);
            this.ubicacion_cb.Name = "ubicacion_cb";
            this.ubicacion_cb.Size = new System.Drawing.Size(203, 22);
            this.ubicacion_cb.TabIndex = 8;
            this.ubicacion_cb.DropDown += new System.EventHandler(this.ubicacion_cb_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 14);
            this.label4.TabIndex = 134;
            this.label4.Text = "# MATRICULA:";
            // 
            // matricula_txt
            // 
            this.matricula_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula_txt.Location = new System.Drawing.Point(3, 59);
            this.matricula_txt.Name = "matricula_txt";
            this.matricula_txt.Size = new System.Drawing.Size(203, 20);
            this.matricula_txt.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 137;
            this.label8.Text = "PLACA:";
            // 
            // placa_txt
            // 
            this.placa_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa_txt.Location = new System.Drawing.Point(3, 99);
            this.placa_txt.Name = "placa_txt";
            this.placa_txt.Size = new System.Drawing.Size(203, 20);
            this.placa_txt.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 14);
            this.label13.TabIndex = 139;
            this.label13.Text = "FUERZA MOTRIZ:";
            // 
            // fuerzaMotriz_txt
            // 
            this.fuerzaMotriz_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuerzaMotriz_txt.Location = new System.Drawing.Point(3, 139);
            this.fuerzaMotriz_txt.Name = "fuerzaMotriz_txt";
            this.fuerzaMotriz_txt.Size = new System.Drawing.Size(203, 20);
            this.fuerzaMotriz_txt.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 14);
            this.label14.TabIndex = 141;
            this.label14.Text = "MILLAJE:";
            // 
            // millaje_txt
            // 
            this.millaje_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millaje_txt.Location = new System.Drawing.Point(3, 179);
            this.millaje_txt.Name = "millaje_txt";
            this.millaje_txt.Size = new System.Drawing.Size(203, 20);
            this.millaje_txt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "FECHA CAMBIO UBICACION:";
            // 
            // fecha_dtp
            // 
            this.fecha_dtp.CustomFormat = "dd/MM/yyyy";
            this.fecha_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_dtp.Location = new System.Drawing.Point(719, 157);
            this.fecha_dtp.Name = "fecha_dtp";
            this.fecha_dtp.Size = new System.Drawing.Size(105, 20);
            this.fecha_dtp.TabIndex = 130;
            // 
            // ubicacionesHist_dtg
            // 
            this.ubicacionesHist_dtg.AllowUserToAddRows = false;
            this.ubicacionesHist_dtg.AllowUserToDeleteRows = false;
            this.ubicacionesHist_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ubicacionesHist_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ubicacionesHist_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ubicacionesHist_dtg.Location = new System.Drawing.Point(541, 213);
            this.ubicacionesHist_dtg.MultiSelect = false;
            this.ubicacionesHist_dtg.Name = "ubicacionesHist_dtg";
            this.ubicacionesHist_dtg.ReadOnly = true;
            this.ubicacionesHist_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ubicacionesHist_dtg.Size = new System.Drawing.Size(330, 100);
            this.ubicacionesHist_dtg.TabIndex = 132;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(538, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 14);
            this.label15.TabIndex = 133;
            this.label15.Text = "HISTORIAL UBICACIONES";
            // 
            // ModificarVehiculoForm
            // 
            this.AcceptButton = this.guardar_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 424);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.fecha_dtp);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nota_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ubicacionesHist_dtg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificarVehiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Vehiculo";
            this.Load += new System.EventHandler(this.ModificarVehiculoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesHist_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vin_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox propietario_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.TextBox nota_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.CheckBox acto_venta_chbox;
        private System.Windows.Forms.CheckBox cedula_chbox;
        private System.Windows.Forms.CheckBox mat_chbox;
        private System.Windows.Forms.Label nombreV_lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioBtnRD_precio;
        private System.Windows.Forms.RadioButton radioBtnUSD_precio;
        private System.Windows.Forms.LinkLabel tasa_lbl;
        private System.Windows.Forms.TextBox precio_estimado_venta_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox año_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox color_cb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox matricula_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox suplidor_cb;
        private System.Windows.Forms.ComboBox ubicacion_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox placa_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox fuerzaMotriz_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox millaje_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_dtp;
        private System.Windows.Forms.DataGridView ubicacionesHist_dtg;
        private System.Windows.Forms.Label label15;
    }
}