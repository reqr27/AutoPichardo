namespace ImporteVehiculos.Formularios
{
    partial class SuplidoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuplidoresForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.suplidores_dtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefono1_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rncCedula_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.suplidor_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ciudad_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pais_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.estado_chbox = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplidores_dtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 44);
            this.panel3.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(409, 3);
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
            this.button2.Location = new System.Drawing.Point(441, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "SUPLIDORES";
            // 
            // suplidores_dtg
            // 
            this.suplidores_dtg.AllowUserToAddRows = false;
            this.suplidores_dtg.AllowUserToDeleteRows = false;
            this.suplidores_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.suplidores_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.suplidores_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suplidores_dtg.Location = new System.Drawing.Point(12, 292);
            this.suplidores_dtg.MultiSelect = false;
            this.suplidores_dtg.Name = "suplidores_dtg";
            this.suplidores_dtg.ReadOnly = true;
            this.suplidores_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suplidores_dtg.Size = new System.Drawing.Size(447, 176);
            this.suplidores_dtg.TabIndex = 78;
            this.suplidores_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ubicaciones_dtg_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.agregar_btn);
            this.panel2.Controls.Add(this.cancelar_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 75);
            this.panel2.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Doble Click Campo Para Actualizar!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // agregar_btn
            // 
            this.agregar_btn.FlatAppearance.BorderSize = 0;
            this.agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.agregar_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.agregar_btn.Location = new System.Drawing.Point(264, 5);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(101, 67);
            this.agregar_btn.TabIndex = 33;
            this.agregar_btn.Text = "Registrar";
            this.agregar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Enabled = false;
            this.cancelar_btn.FlatAppearance.BorderSize = 0;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cancelar_btn.Image = global::ImporteVehiculos.Properties.Resources.close__1_;
            this.cancelar_btn.Location = new System.Drawing.Point(360, 5);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(107, 67);
            this.cancelar_btn.TabIndex = 36;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // direccion_txt
            // 
            this.direccion_txt.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_txt.Location = new System.Drawing.Point(152, 191);
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(262, 23);
            this.direccion_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "DIRECCION:";
            // 
            // telefono1_txt
            // 
            this.telefono1_txt.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1_txt.Location = new System.Drawing.Point(152, 225);
            this.telefono1_txt.Name = "telefono1_txt";
            this.telefono1_txt.Size = new System.Drawing.Size(160, 23);
            this.telefono1_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "TELEFONO:";
            // 
            // rncCedula_txt
            // 
            this.rncCedula_txt.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rncCedula_txt.Location = new System.Drawing.Point(152, 93);
            this.rncCedula_txt.Name = "rncCedula_txt";
            this.rncCedula_txt.Size = new System.Drawing.Size(262, 23);
            this.rncCedula_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "RNC/CEDULA:";
            // 
            // suplidor_txt
            // 
            this.suplidor_txt.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplidor_txt.Location = new System.Drawing.Point(152, 60);
            this.suplidor_txt.Name = "suplidor_txt";
            this.suplidor_txt.Size = new System.Drawing.Size(262, 23);
            this.suplidor_txt.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 89;
            this.label6.Text = "SUPLIDOR:";
            // 
            // ciudad_cb
            // 
            this.ciudad_cb.DropDownHeight = 180;
            this.ciudad_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudad_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciudad_cb.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad_cb.FormattingEnabled = true;
            this.ciudad_cb.IntegralHeight = false;
            this.ciudad_cb.Location = new System.Drawing.Point(152, 156);
            this.ciudad_cb.Name = "ciudad_cb";
            this.ciudad_cb.Size = new System.Drawing.Size(262, 24);
            this.ciudad_cb.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 97;
            this.label7.Text = "CIUDAD:";
            // 
            // pais_cb
            // 
            this.pais_cb.DropDownHeight = 180;
            this.pais_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pais_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pais_cb.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais_cb.FormattingEnabled = true;
            this.pais_cb.IntegralHeight = false;
            this.pais_cb.Location = new System.Drawing.Point(152, 123);
            this.pais_cb.Name = "pais_cb";
            this.pais_cb.Size = new System.Drawing.Size(262, 24);
            this.pais_cb.TabIndex = 2;
            this.pais_cb.SelectedIndexChanged += new System.EventHandler(this.pais_cb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 94;
            this.label9.Text = "PAIS:";
            // 
            // estado_chbox
            // 
            this.estado_chbox.AutoSize = true;
            this.estado_chbox.Checked = true;
            this.estado_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estado_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_chbox.Location = new System.Drawing.Point(15, 266);
            this.estado_chbox.Name = "estado_chbox";
            this.estado_chbox.Size = new System.Drawing.Size(88, 20);
            this.estado_chbox.TabIndex = 6;
            this.estado_chbox.Text = "Habilitar";
            this.estado_chbox.UseVisualStyleBackColor = true;
            // 
            // SuplidoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(474, 549);
            this.Controls.Add(this.estado_chbox);
            this.Controls.Add(this.ciudad_cb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pais_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono1_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rncCedula_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suplidor_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.suplidores_dtg);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuplidoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplidores";
            this.Load += new System.EventHandler(this.SuplidoresForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SuplidoresForm_MouseDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplidores_dtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView suplidores_dtg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefono1_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rncCedula_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox suplidor_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ciudad_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox pais_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox estado_chbox;
    }
}