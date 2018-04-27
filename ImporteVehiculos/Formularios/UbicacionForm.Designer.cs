namespace ImporteVehiculos.Formularios
{
    partial class UbicacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbicacionForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.estadoUbicacion_chbox = new System.Windows.Forms.CheckBox();
            this.lugar_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ubicaciones_dtg = new System.Windows.Forms.DataGridView();
            this.pais_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ciudad_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicaciones_dtg)).BeginInit();
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
            this.panel3.Size = new System.Drawing.Size(476, 44);
            this.panel3.TabIndex = 50;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
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
            this.label11.Size = new System.Drawing.Size(166, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "UBICACIONES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.agregar_btn);
            this.panel2.Controls.Add(this.cancelar_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 75);
            this.panel2.TabIndex = 67;
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
            this.agregar_btn.Location = new System.Drawing.Point(253, 0);
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
            this.cancelar_btn.Location = new System.Drawing.Point(360, 0);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(107, 67);
            this.cancelar_btn.TabIndex = 36;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // estadoUbicacion_chbox
            // 
            this.estadoUbicacion_chbox.AutoSize = true;
            this.estadoUbicacion_chbox.Checked = true;
            this.estadoUbicacion_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoUbicacion_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoUbicacion_chbox.Location = new System.Drawing.Point(43, 140);
            this.estadoUbicacion_chbox.Name = "estadoUbicacion_chbox";
            this.estadoUbicacion_chbox.Size = new System.Drawing.Size(88, 20);
            this.estadoUbicacion_chbox.TabIndex = 73;
            this.estadoUbicacion_chbox.Text = "Habilitar";
            this.estadoUbicacion_chbox.UseVisualStyleBackColor = true;
            // 
            // lugar_txt
            // 
            this.lugar_txt.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar_txt.Location = new System.Drawing.Point(121, 114);
            this.lugar_txt.Name = "lugar_txt";
            this.lugar_txt.Size = new System.Drawing.Size(262, 23);
            this.lugar_txt.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "LUGAR:";
            // 
            // ubicaciones_dtg
            // 
            this.ubicaciones_dtg.AllowUserToAddRows = false;
            this.ubicaciones_dtg.AllowUserToDeleteRows = false;
            this.ubicaciones_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ubicaciones_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ubicaciones_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ubicaciones_dtg.Location = new System.Drawing.Point(43, 169);
            this.ubicaciones_dtg.MultiSelect = false;
            this.ubicaciones_dtg.Name = "ubicaciones_dtg";
            this.ubicaciones_dtg.ReadOnly = true;
            this.ubicaciones_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ubicaciones_dtg.Size = new System.Drawing.Size(381, 176);
            this.ubicaciones_dtg.TabIndex = 70;
            this.ubicaciones_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ubicaciones_dtg_CellDoubleClick);
            // 
            // pais_cb
            // 
            this.pais_cb.DropDownHeight = 180;
            this.pais_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pais_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pais_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais_cb.FormattingEnabled = true;
            this.pais_cb.IntegralHeight = false;
            this.pais_cb.Location = new System.Drawing.Point(121, 57);
            this.pais_cb.Name = "pais_cb";
            this.pais_cb.Size = new System.Drawing.Size(262, 22);
            this.pais_cb.TabIndex = 68;
            this.pais_cb.DropDown += new System.EventHandler(this.pais_cb_DropDown);
            this.pais_cb.SelectedIndexChanged += new System.EventHandler(this.pais_cb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "PAIS:";
            // 
            // ciudad_cb
            // 
            this.ciudad_cb.DropDownHeight = 180;
            this.ciudad_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudad_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciudad_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad_cb.FormattingEnabled = true;
            this.ciudad_cb.IntegralHeight = false;
            this.ciudad_cb.Location = new System.Drawing.Point(121, 86);
            this.ciudad_cb.Name = "ciudad_cb";
            this.ciudad_cb.Size = new System.Drawing.Size(262, 22);
            this.ciudad_cb.TabIndex = 74;
            this.ciudad_cb.DropDown += new System.EventHandler(this.ciudad_cb_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "CIUDAD:";
            // 
            // UbicacionForm
            // 
            this.AcceptButton = this.agregar_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(476, 432);
            this.Controls.Add(this.ciudad_cb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.estadoUbicacion_chbox);
            this.Controls.Add(this.lugar_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ubicaciones_dtg);
            this.Controls.Add(this.pais_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UbicacionForm";
            this.Text = "Ubicación";
            this.Load += new System.EventHandler(this.UbicacionForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicaciones_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.CheckBox estadoUbicacion_chbox;
        private System.Windows.Forms.TextBox lugar_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ubicaciones_dtg;
        private System.Windows.Forms.ComboBox pais_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ciudad_cb;
        private System.Windows.Forms.Label label7;
    }
}