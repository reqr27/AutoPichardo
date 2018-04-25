namespace ImporteVehiculos.Formularios
{
    partial class ConfiguracionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.seguros_btn = new System.Windows.Forms.Button();
            this.suplidores_btn = new System.Windows.Forms.Button();
            this.ubicacion_btn = new System.Windows.Forms.Button();
            this.colores_btn = new System.Windows.Forms.Button();
            this.ciudades_btn = new System.Windows.Forms.Button();
            this.pais_btn = new System.Windows.Forms.Button();
            this.dolares_btn = new System.Windows.Forms.Button();
            this.propietarios_btn = new System.Windows.Forms.Button();
            this.gastos_btn = new System.Windows.Forms.Button();
            this.taller_btn = new System.Windows.Forms.Button();
            this.crearUsuarios_btn = new System.Windows.Forms.Button();
            this.clientes_btn = new System.Windows.Forms.Button();
            this.piezasRepuestos_btn = new System.Windows.Forms.Button();
            this.fabricantesModelos_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 48);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(818, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
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
            this.button2.Location = new System.Drawing.Point(850, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
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
            this.label27.Size = new System.Drawing.Size(164, 24);
            this.label27.TabIndex = 29;
            this.label27.Text = "Configuración";
            // 
            // seguros_btn
            // 
            this.seguros_btn.FlatAppearance.BorderSize = 0;
            this.seguros_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seguros_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguros_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seguros_btn.Image = global::ImporteVehiculos.Properties.Resources.insurance;
            this.seguros_btn.Location = new System.Drawing.Point(222, 508);
            this.seguros_btn.Name = "seguros_btn";
            this.seguros_btn.Size = new System.Drawing.Size(204, 139);
            this.seguros_btn.TabIndex = 20;
            this.seguros_btn.Text = "SEGUROS";
            this.seguros_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.seguros_btn.UseVisualStyleBackColor = true;
            this.seguros_btn.Click += new System.EventHandler(this.seguros_btn_Click);
            // 
            // suplidores_btn
            // 
            this.suplidores_btn.FlatAppearance.BorderSize = 0;
            this.suplidores_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suplidores_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidores_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suplidores_btn.Image = global::ImporteVehiculos.Properties.Resources.salesman;
            this.suplidores_btn.Location = new System.Drawing.Point(16, 505);
            this.suplidores_btn.Name = "suplidores_btn";
            this.suplidores_btn.Size = new System.Drawing.Size(204, 139);
            this.suplidores_btn.TabIndex = 19;
            this.suplidores_btn.Text = "SUPLIDORES";
            this.suplidores_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.suplidores_btn.UseVisualStyleBackColor = true;
            this.suplidores_btn.Click += new System.EventHandler(this.suplidores_btn_Click);
            // 
            // ubicacion_btn
            // 
            this.ubicacion_btn.FlatAppearance.BorderSize = 0;
            this.ubicacion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubicacion_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacion_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ubicacion_btn.Image = global::ImporteVehiculos.Properties.Resources.placeholder;
            this.ubicacion_btn.Location = new System.Drawing.Point(642, 363);
            this.ubicacion_btn.Name = "ubicacion_btn";
            this.ubicacion_btn.Size = new System.Drawing.Size(204, 139);
            this.ubicacion_btn.TabIndex = 18;
            this.ubicacion_btn.Text = "UBICACIONES";
            this.ubicacion_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ubicacion_btn.UseVisualStyleBackColor = true;
            this.ubicacion_btn.Click += new System.EventHandler(this.ubicacion_btn_Click);
            // 
            // colores_btn
            // 
            this.colores_btn.FlatAppearance.BorderSize = 0;
            this.colores_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colores_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colores_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colores_btn.Image = global::ImporteVehiculos.Properties.Resources.brush;
            this.colores_btn.Location = new System.Drawing.Point(432, 363);
            this.colores_btn.Name = "colores_btn";
            this.colores_btn.Size = new System.Drawing.Size(204, 139);
            this.colores_btn.TabIndex = 17;
            this.colores_btn.Text = "COLORES";
            this.colores_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.colores_btn.UseVisualStyleBackColor = true;
            this.colores_btn.Click += new System.EventHandler(this.colores_btn_Click);
            // 
            // ciudades_btn
            // 
            this.ciudades_btn.FlatAppearance.BorderSize = 0;
            this.ciudades_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciudades_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudades_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ciudades_btn.Image = global::ImporteVehiculos.Properties.Resources.bank;
            this.ciudades_btn.Location = new System.Drawing.Point(222, 363);
            this.ciudades_btn.Name = "ciudades_btn";
            this.ciudades_btn.Size = new System.Drawing.Size(204, 139);
            this.ciudades_btn.TabIndex = 16;
            this.ciudades_btn.Text = "CIUDADES";
            this.ciudades_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ciudades_btn.UseVisualStyleBackColor = true;
            this.ciudades_btn.Click += new System.EventHandler(this.ciudades_btn_Click);
            // 
            // pais_btn
            // 
            this.pais_btn.FlatAppearance.BorderSize = 0;
            this.pais_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pais_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pais_btn.Image = global::ImporteVehiculos.Properties.Resources.worldwide__1_;
            this.pais_btn.Location = new System.Drawing.Point(16, 363);
            this.pais_btn.Name = "pais_btn";
            this.pais_btn.Size = new System.Drawing.Size(204, 139);
            this.pais_btn.TabIndex = 15;
            this.pais_btn.Text = "PAISES";
            this.pais_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pais_btn.UseVisualStyleBackColor = true;
            this.pais_btn.Click += new System.EventHandler(this.pais_btn_Click);
            // 
            // dolares_btn
            // 
            this.dolares_btn.FlatAppearance.BorderSize = 0;
            this.dolares_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dolares_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolares_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dolares_btn.Image = global::ImporteVehiculos.Properties.Resources.billete;
            this.dolares_btn.Location = new System.Drawing.Point(642, 218);
            this.dolares_btn.Name = "dolares_btn";
            this.dolares_btn.Size = new System.Drawing.Size(204, 139);
            this.dolares_btn.TabIndex = 14;
            this.dolares_btn.Text = "TASA DOLARES";
            this.dolares_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dolares_btn.UseVisualStyleBackColor = true;
            this.dolares_btn.Click += new System.EventHandler(this.dolares_btn_Click);
            // 
            // propietarios_btn
            // 
            this.propietarios_btn.FlatAppearance.BorderSize = 0;
            this.propietarios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.propietarios_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propietarios_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.propietarios_btn.Image = global::ImporteVehiculos.Properties.Resources.icon__1_;
            this.propietarios_btn.Location = new System.Drawing.Point(222, 218);
            this.propietarios_btn.Name = "propietarios_btn";
            this.propietarios_btn.Size = new System.Drawing.Size(204, 139);
            this.propietarios_btn.TabIndex = 11;
            this.propietarios_btn.Text = "PROPIETARIOS";
            this.propietarios_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.propietarios_btn.UseVisualStyleBackColor = true;
            this.propietarios_btn.Click += new System.EventHandler(this.propietarios_btn_Click);
            // 
            // gastos_btn
            // 
            this.gastos_btn.FlatAppearance.BorderSize = 0;
            this.gastos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gastos_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gastos_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gastos_btn.Image = global::ImporteVehiculos.Properties.Resources.efectivo__1_;
            this.gastos_btn.Location = new System.Drawing.Point(432, 218);
            this.gastos_btn.Name = "gastos_btn";
            this.gastos_btn.Size = new System.Drawing.Size(204, 139);
            this.gastos_btn.TabIndex = 12;
            this.gastos_btn.Text = "GASTOS GENERALES";
            this.gastos_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gastos_btn.UseVisualStyleBackColor = true;
            this.gastos_btn.Click += new System.EventHandler(this.gastos_btn_Click);
            // 
            // taller_btn
            // 
            this.taller_btn.FlatAppearance.BorderSize = 0;
            this.taller_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taller_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taller_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taller_btn.Image = global::ImporteVehiculos.Properties.Resources.taller_mecanico_de_coches__1_;
            this.taller_btn.Location = new System.Drawing.Point(12, 218);
            this.taller_btn.Name = "taller_btn";
            this.taller_btn.Size = new System.Drawing.Size(204, 139);
            this.taller_btn.TabIndex = 10;
            this.taller_btn.Text = "TALLERES";
            this.taller_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.taller_btn.UseVisualStyleBackColor = true;
            this.taller_btn.Click += new System.EventHandler(this.taller_btn_Click);
            // 
            // crearUsuarios_btn
            // 
            this.crearUsuarios_btn.FlatAppearance.BorderSize = 0;
            this.crearUsuarios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearUsuarios_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearUsuarios_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crearUsuarios_btn.Image = global::ImporteVehiculos.Properties.Resources.agregar_usuario;
            this.crearUsuarios_btn.Location = new System.Drawing.Point(12, 73);
            this.crearUsuarios_btn.Name = "crearUsuarios_btn";
            this.crearUsuarios_btn.Size = new System.Drawing.Size(204, 139);
            this.crearUsuarios_btn.TabIndex = 6;
            this.crearUsuarios_btn.Text = "USUARIOS";
            this.crearUsuarios_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.crearUsuarios_btn.UseVisualStyleBackColor = true;
            this.crearUsuarios_btn.Click += new System.EventHandler(this.crearUsuarios_btn_Click);
            // 
            // clientes_btn
            // 
            this.clientes_btn.FlatAppearance.BorderSize = 0;
            this.clientes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientes_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clientes_btn.Image = global::ImporteVehiculos.Properties.Resources.servicio_al_cliente;
            this.clientes_btn.Location = new System.Drawing.Point(642, 73);
            this.clientes_btn.Name = "clientes_btn";
            this.clientes_btn.Size = new System.Drawing.Size(204, 139);
            this.clientes_btn.TabIndex = 9;
            this.clientes_btn.Text = "CLIENTES";
            this.clientes_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clientes_btn.UseVisualStyleBackColor = true;
            this.clientes_btn.Click += new System.EventHandler(this.clientes_btn_Click);
            // 
            // piezasRepuestos_btn
            // 
            this.piezasRepuestos_btn.FlatAppearance.BorderSize = 0;
            this.piezasRepuestos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piezasRepuestos_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piezasRepuestos_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.piezasRepuestos_btn.Image = global::ImporteVehiculos.Properties.Resources.shock_absorber__1_;
            this.piezasRepuestos_btn.Location = new System.Drawing.Point(432, 73);
            this.piezasRepuestos_btn.Name = "piezasRepuestos_btn";
            this.piezasRepuestos_btn.Size = new System.Drawing.Size(204, 139);
            this.piezasRepuestos_btn.TabIndex = 8;
            this.piezasRepuestos_btn.Text = "PIEZAS/REPUESTOS";
            this.piezasRepuestos_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.piezasRepuestos_btn.UseVisualStyleBackColor = true;
            this.piezasRepuestos_btn.Click += new System.EventHandler(this.piezasRepuestos_btn_Click);
            // 
            // fabricantesModelos_btn
            // 
            this.fabricantesModelos_btn.FlatAppearance.BorderSize = 0;
            this.fabricantesModelos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fabricantesModelos_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricantesModelos_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fabricantesModelos_btn.Image = global::ImporteVehiculos.Properties.Resources.carreras__2_;
            this.fabricantesModelos_btn.Location = new System.Drawing.Point(222, 73);
            this.fabricantesModelos_btn.Name = "fabricantesModelos_btn";
            this.fabricantesModelos_btn.Size = new System.Drawing.Size(204, 139);
            this.fabricantesModelos_btn.TabIndex = 7;
            this.fabricantesModelos_btn.Text = "MARCAS/MODELOS";
            this.fabricantesModelos_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fabricantesModelos_btn.UseVisualStyleBackColor = true;
            this.fabricantesModelos_btn.Click += new System.EventHandler(this.fabricantesModelos_btn_Click);
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(880, 656);
            this.Controls.Add(this.seguros_btn);
            this.Controls.Add(this.suplidores_btn);
            this.Controls.Add(this.ubicacion_btn);
            this.Controls.Add(this.colores_btn);
            this.Controls.Add(this.ciudades_btn);
            this.Controls.Add(this.pais_btn);
            this.Controls.Add(this.dolares_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propietarios_btn);
            this.Controls.Add(this.gastos_btn);
            this.Controls.Add(this.taller_btn);
            this.Controls.Add(this.crearUsuarios_btn);
            this.Controls.Add(this.clientes_btn);
            this.Controls.Add(this.piezasRepuestos_btn);
            this.Controls.Add(this.fabricantesModelos_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfiguracionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfiguracionForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfiguracionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearUsuarios_btn;
        private System.Windows.Forms.Button clientes_btn;
        private System.Windows.Forms.Button piezasRepuestos_btn;
        private System.Windows.Forms.Button fabricantesModelos_btn;
        private System.Windows.Forms.Button propietarios_btn;
        private System.Windows.Forms.Button gastos_btn;
        private System.Windows.Forms.Button taller_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dolares_btn;
        private System.Windows.Forms.Button pais_btn;
        private System.Windows.Forms.Button ciudades_btn;
        private System.Windows.Forms.Button colores_btn;
        private System.Windows.Forms.Button ubicacion_btn;
        private System.Windows.Forms.Button suplidores_btn;
        private System.Windows.Forms.Button seguros_btn;
    }
}