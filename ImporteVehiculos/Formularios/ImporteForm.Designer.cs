namespace ImporteVehiculos.Formularios
{
    partial class ImporteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImporteForm));
            this.vehiculos_dtg = new System.Windows.Forms.DataGridView();
            this.proceso_radioBtn = new System.Windows.Forms.RadioButton();
            this.terminados_radioBtn = new System.Windows.Forms.RadioButton();
            this.vendidos_radioBtn = new System.Windows.Forms.RadioButton();
            this.desde_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasta_dtp = new System.Windows.Forms.DateTimePicker();
            this.deshabilitados_radiobtn = new System.Windows.Forms.RadioButton();
            this.rojo_panel = new System.Windows.Forms.Panel();
            this.nnPago_lbl = new System.Windows.Forms.Label();
            this.leyenda_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.habilitar_btn = new System.Windows.Forms.Button();
            this.nuevoVehiculo_btn = new System.Windows.Forms.Button();
            this.deshabilitar_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.verDetalles_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.totalUSD_lbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.totalRD_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dtg)).BeginInit();
            this.leyenda_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.vehiculos_dtg.Location = new System.Drawing.Point(12, 189);
            this.vehiculos_dtg.MultiSelect = false;
            this.vehiculos_dtg.Name = "vehiculos_dtg";
            this.vehiculos_dtg.ReadOnly = true;
            this.vehiculos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiculos_dtg.Size = new System.Drawing.Size(910, 261);
            this.vehiculos_dtg.TabIndex = 40;
            this.vehiculos_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiculos_dtg_CellDoubleClick);
            // 
            // proceso_radioBtn
            // 
            this.proceso_radioBtn.AutoSize = true;
            this.proceso_radioBtn.Checked = true;
            this.proceso_radioBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceso_radioBtn.Location = new System.Drawing.Point(14, 149);
            this.proceso_radioBtn.Name = "proceso_radioBtn";
            this.proceso_radioBtn.Size = new System.Drawing.Size(189, 23);
            this.proceso_radioBtn.TabIndex = 41;
            this.proceso_radioBtn.TabStop = true;
            this.proceso_radioBtn.Text = "Inventario en Proceso";
            this.proceso_radioBtn.UseVisualStyleBackColor = true;
            this.proceso_radioBtn.CheckedChanged += new System.EventHandler(this.proceso_radioBtn_CheckedChanged);
            // 
            // terminados_radioBtn
            // 
            this.terminados_radioBtn.AutoSize = true;
            this.terminados_radioBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminados_radioBtn.Location = new System.Drawing.Point(220, 149);
            this.terminados_radioBtn.Name = "terminados_radioBtn";
            this.terminados_radioBtn.Size = new System.Drawing.Size(185, 23);
            this.terminados_radioBtn.TabIndex = 42;
            this.terminados_radioBtn.Text = "Inventario terminado";
            this.terminados_radioBtn.UseVisualStyleBackColor = true;
            this.terminados_radioBtn.CheckedChanged += new System.EventHandler(this.proceso_radioBtn_CheckedChanged);
            // 
            // vendidos_radioBtn
            // 
            this.vendidos_radioBtn.AutoSize = true;
            this.vendidos_radioBtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendidos_radioBtn.Location = new System.Drawing.Point(460, 149);
            this.vendidos_radioBtn.Name = "vendidos_radioBtn";
            this.vendidos_radioBtn.Size = new System.Drawing.Size(96, 23);
            this.vendidos_radioBtn.TabIndex = 43;
            this.vendidos_radioBtn.Text = "Vendidos";
            this.vendidos_radioBtn.UseVisualStyleBackColor = true;
            this.vendidos_radioBtn.Visible = false;
            this.vendidos_radioBtn.CheckedChanged += new System.EventHandler(this.proceso_radioBtn_CheckedChanged);
            // 
            // desde_dtp
            // 
            this.desde_dtp.CustomFormat = "dd/MM/yyyy";
            this.desde_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde_dtp.Location = new System.Drawing.Point(56, 3);
            this.desde_dtp.Name = "desde_dtp";
            this.desde_dtp.Size = new System.Drawing.Size(102, 20);
            this.desde_dtp.TabIndex = 44;
            this.desde_dtp.ValueChanged += new System.EventHandler(this.hasta_dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hasta:";
            // 
            // hasta_dtp
            // 
            this.hasta_dtp.CustomFormat = "dd/MM/yyyy";
            this.hasta_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hasta_dtp.Location = new System.Drawing.Point(56, 33);
            this.hasta_dtp.Name = "hasta_dtp";
            this.hasta_dtp.Size = new System.Drawing.Size(102, 20);
            this.hasta_dtp.TabIndex = 46;
            this.hasta_dtp.ValueChanged += new System.EventHandler(this.hasta_dtp_ValueChanged);
            // 
            // deshabilitados_radiobtn
            // 
            this.deshabilitados_radiobtn.AutoSize = true;
            this.deshabilitados_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deshabilitados_radiobtn.Location = new System.Drawing.Point(562, 149);
            this.deshabilitados_radiobtn.Name = "deshabilitados_radiobtn";
            this.deshabilitados_radiobtn.Size = new System.Drawing.Size(138, 23);
            this.deshabilitados_radiobtn.TabIndex = 51;
            this.deshabilitados_radiobtn.Text = "Deshabilitados";
            this.deshabilitados_radiobtn.UseVisualStyleBackColor = true;
            this.deshabilitados_radiobtn.Visible = false;
            this.deshabilitados_radiobtn.CheckedChanged += new System.EventHandler(this.proceso_radioBtn_CheckedChanged);
            // 
            // rojo_panel
            // 
            this.rojo_panel.BackColor = System.Drawing.Color.Red;
            this.rojo_panel.Location = new System.Drawing.Point(3, 28);
            this.rojo_panel.Name = "rojo_panel";
            this.rojo_panel.Size = new System.Drawing.Size(23, 21);
            this.rojo_panel.TabIndex = 55;
            // 
            // nnPago_lbl
            // 
            this.nnPago_lbl.AutoSize = true;
            this.nnPago_lbl.Location = new System.Drawing.Point(33, 32);
            this.nnPago_lbl.Name = "nnPago_lbl";
            this.nnPago_lbl.Size = new System.Drawing.Size(76, 15);
            this.nnPago_lbl.TabIndex = 56;
            this.nnPago_lbl.Text = "Pago Parcial";
            // 
            // leyenda_panel
            // 
            this.leyenda_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leyenda_panel.Controls.Add(this.label4);
            this.leyenda_panel.Controls.Add(this.panel2);
            this.leyenda_panel.Controls.Add(this.label3);
            this.leyenda_panel.Controls.Add(this.rojo_panel);
            this.leyenda_panel.Controls.Add(this.nnPago_lbl);
            this.leyenda_panel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leyenda_panel.Location = new System.Drawing.Point(703, 123);
            this.leyenda_panel.Name = "leyenda_panel";
            this.leyenda_panel.Size = new System.Drawing.Size(219, 60);
            this.leyenda_panel.TabIndex = 57;
            this.leyenda_panel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Leyenda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(115, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 21);
            this.panel2.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 58;
            this.label3.Text = "Pago Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.habilitar_btn);
            this.panel1.Controls.Add(this.nuevoVehiculo_btn);
            this.panel1.Controls.Add(this.deshabilitar_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 117);
            this.panel1.TabIndex = 58;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // habilitar_btn
            // 
            this.habilitar_btn.FlatAppearance.BorderSize = 0;
            this.habilitar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habilitar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.habilitar_btn.Image = global::ImporteVehiculos.Properties.Resources.comprobado;
            this.habilitar_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.habilitar_btn.Location = new System.Drawing.Point(484, 3);
            this.habilitar_btn.Name = "habilitar_btn";
            this.habilitar_btn.Size = new System.Drawing.Size(127, 47);
            this.habilitar_btn.TabIndex = 54;
            this.habilitar_btn.Text = "Habilitar";
            this.habilitar_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.habilitar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.habilitar_btn.UseVisualStyleBackColor = true;
            this.habilitar_btn.Visible = false;
            this.habilitar_btn.Click += new System.EventHandler(this.habilitar_btn_Click);
            // 
            // nuevoVehiculo_btn
            // 
            this.nuevoVehiculo_btn.FlatAppearance.BorderSize = 0;
            this.nuevoVehiculo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoVehiculo_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoVehiculo_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.nuevoVehiculo_btn.Image = global::ImporteVehiculos.Properties.Resources.agregar_notas;
            this.nuevoVehiculo_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoVehiculo_btn.Location = new System.Drawing.Point(716, 3);
            this.nuevoVehiculo_btn.Name = "nuevoVehiculo_btn";
            this.nuevoVehiculo_btn.Size = new System.Drawing.Size(127, 44);
            this.nuevoVehiculo_btn.TabIndex = 48;
            this.nuevoVehiculo_btn.Text = "Nuevo Vehículo";
            this.nuevoVehiculo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.nuevoVehiculo_btn.UseVisualStyleBackColor = true;
            this.nuevoVehiculo_btn.Visible = false;
            this.nuevoVehiculo_btn.Click += new System.EventHandler(this.nuevoVehiculo_btn_Click);
            // 
            // deshabilitar_btn
            // 
            this.deshabilitar_btn.FlatAppearance.BorderSize = 0;
            this.deshabilitar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deshabilitar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.deshabilitar_btn.Image = global::ImporteVehiculos.Properties.Resources.deshabilitado;
            this.deshabilitar_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deshabilitar_btn.Location = new System.Drawing.Point(592, 3);
            this.deshabilitar_btn.Name = "deshabilitar_btn";
            this.deshabilitar_btn.Size = new System.Drawing.Size(127, 47);
            this.deshabilitar_btn.TabIndex = 53;
            this.deshabilitar_btn.Text = "Deshabilitar";
            this.deshabilitar_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deshabilitar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deshabilitar_btn.UseVisualStyleBackColor = true;
            this.deshabilitar_btn.Visible = false;
            this.deshabilitar_btn.Click += new System.EventHandler(this.deshabilitar_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.buscar_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.verDetalles_btn);
            this.panel3.Controls.Add(this.hasta_dtp);
            this.panel3.Controls.Add(this.desde_dtp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 56);
            this.panel3.TabIndex = 59;
            // 
            // buscar_btn
            // 
            this.buscar_btn.FlatAppearance.BorderSize = 0;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.buscar_btn.Image = global::ImporteVehiculos.Properties.Resources.lupa_para_buscar;
            this.buscar_btn.Location = new System.Drawing.Point(164, 5);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(75, 46);
            this.buscar_btn.TabIndex = 50;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // verDetalles_btn
            // 
            this.verDetalles_btn.FlatAppearance.BorderSize = 0;
            this.verDetalles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verDetalles_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verDetalles_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.verDetalles_btn.Image = global::ImporteVehiculos.Properties.Resources.portapapeles;
            this.verDetalles_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verDetalles_btn.Location = new System.Drawing.Point(245, 5);
            this.verDetalles_btn.Name = "verDetalles_btn";
            this.verDetalles_btn.Size = new System.Drawing.Size(92, 47);
            this.verDetalles_btn.TabIndex = 49;
            this.verDetalles_btn.Text = "Ver Detalles";
            this.verDetalles_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.verDetalles_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.verDetalles_btn.UseVisualStyleBackColor = true;
            this.verDetalles_btn.Click += new System.EventHandler(this.verDetalles_btn_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(873, 2);
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
            this.button2.Location = new System.Drawing.Point(905, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "INVENTARIO VEHICULOS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.totalUSD_lbl);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.totalRD_lbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 48);
            this.panel4.TabIndex = 59;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label19.Location = new System.Drawing.Point(520, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 19);
            this.label19.TabIndex = 113;
            this.label19.Text = "COSTO TOTAL($USD):";
            // 
            // totalUSD_lbl
            // 
            this.totalUSD_lbl.AutoSize = true;
            this.totalUSD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUSD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.totalUSD_lbl.Location = new System.Drawing.Point(737, 15);
            this.totalUSD_lbl.Name = "totalUSD_lbl";
            this.totalUSD_lbl.Size = new System.Drawing.Size(29, 19);
            this.totalUSD_lbl.TabIndex = 114;
            this.totalUSD_lbl.Text = "pv";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label22.Location = new System.Drawing.Point(35, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 19);
            this.label22.TabIndex = 111;
            this.label22.Text = "COSTO TOTAL($RD):";
            // 
            // totalRD_lbl
            // 
            this.totalRD_lbl.AutoSize = true;
            this.totalRD_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.totalRD_lbl.Location = new System.Drawing.Point(241, 15);
            this.totalRD_lbl.Name = "totalRD_lbl";
            this.totalRD_lbl.Size = new System.Drawing.Size(29, 19);
            this.totalRD_lbl.TabIndex = 112;
            this.totalRD_lbl.Text = "pv";
            // 
            // ImporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(934, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leyenda_panel);
            this.Controls.Add(this.deshabilitados_radiobtn);
            this.Controls.Add(this.vendidos_radioBtn);
            this.Controls.Add(this.terminados_radioBtn);
            this.Controls.Add(this.proceso_radioBtn);
            this.Controls.Add(this.vehiculos_dtg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImporteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Vehículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImporteForm_FormClosed);
            this.Load += new System.EventHandler(this.ImporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dtg)).EndInit();
            this.leyenda_panel.ResumeLayout(false);
            this.leyenda_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehiculos_dtg;
        private System.Windows.Forms.RadioButton proceso_radioBtn;
        private System.Windows.Forms.RadioButton terminados_radioBtn;
        private System.Windows.Forms.RadioButton vendidos_radioBtn;
        private System.Windows.Forms.DateTimePicker desde_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hasta_dtp;
        private System.Windows.Forms.Button nuevoVehiculo_btn;
        private System.Windows.Forms.Button verDetalles_btn;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.RadioButton deshabilitados_radiobtn;
        private System.Windows.Forms.Button deshabilitar_btn;
        private System.Windows.Forms.Button habilitar_btn;
        private System.Windows.Forms.Panel rojo_panel;
        private System.Windows.Forms.Label nnPago_lbl;
        private System.Windows.Forms.Panel leyenda_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label totalUSD_lbl;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label totalRD_lbl;
    }
}