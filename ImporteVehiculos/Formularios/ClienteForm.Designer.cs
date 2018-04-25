namespace ImporteVehiculos.Formularios
{
    partial class ClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteForm));
            this.telefono1_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rncCedula_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cliente_dtg = new System.Windows.Forms.DataGridView();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoCliente_chbox = new System.Windows.Forms.CheckBox();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ciudad_cb = new System.Windows.Forms.ComboBox();
            this.pais_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.agregarImg_btn = new System.Windows.Forms.Button();
            this.guardarCliente_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // telefono1_txt
            // 
            this.telefono1_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1_txt.Location = new System.Drawing.Point(165, 219);
            this.telefono1_txt.Name = "telefono1_txt";
            this.telefono1_txt.Size = new System.Drawing.Size(262, 22);
            this.telefono1_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 42;
            this.label2.Text = "TELEFONO 1:";
            // 
            // rncCedula_txt
            // 
            this.rncCedula_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rncCedula_txt.Location = new System.Drawing.Point(165, 84);
            this.rncCedula_txt.Name = "rncCedula_txt";
            this.rncCedula_txt.Size = new System.Drawing.Size(262, 22);
            this.rncCedula_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "LICENCIA/CEDULA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doble Click en campo deseado para Actualizar!";
            // 
            // cliente_dtg
            // 
            this.cliente_dtg.AllowUserToAddRows = false;
            this.cliente_dtg.AllowUserToDeleteRows = false;
            this.cliente_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.cliente_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cliente_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cliente_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_dtg.Location = new System.Drawing.Point(27, 342);
            this.cliente_dtg.MultiSelect = false;
            this.cliente_dtg.Name = "cliente_dtg";
            this.cliente_dtg.ReadOnly = true;
            this.cliente_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cliente_dtg.Size = new System.Drawing.Size(389, 231);
            this.cliente_dtg.TabIndex = 39;
            this.cliente_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cliente_dtg_CellDoubleClick);
            // 
            // cliente_txt
            // 
            this.cliente_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_txt.Location = new System.Drawing.Point(165, 53);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(262, 22);
            this.cliente_txt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 38;
            this.label3.Text = "CLIENTE:";
            // 
            // estadoCliente_chbox
            // 
            this.estadoCliente_chbox.AutoSize = true;
            this.estadoCliente_chbox.Checked = true;
            this.estadoCliente_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoCliente_chbox.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCliente_chbox.Location = new System.Drawing.Point(29, 266);
            this.estadoCliente_chbox.Name = "estadoCliente_chbox";
            this.estadoCliente_chbox.Size = new System.Drawing.Size(84, 18);
            this.estadoCliente_chbox.TabIndex = 6;
            this.estadoCliente_chbox.Text = "Habilitar";
            this.estadoCliente_chbox.UseVisualStyleBackColor = true;
            // 
            // direccion_txt
            // 
            this.direccion_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_txt.Location = new System.Drawing.Point(165, 185);
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(262, 22);
            this.direccion_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 44;
            this.label4.Text = "DIRECCION:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 44);
            this.panel3.TabIndex = 48;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimize__1_1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(908, 3);
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
            this.button2.Location = new System.Drawing.Point(940, 3);
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
            this.label11.Size = new System.Drawing.Size(123, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "CLIENTES";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(461, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 242);
            this.flowLayoutPanel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cancelarEditar_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 39);
            this.panel2.TabIndex = 50;
            // 
            // cancelarEditar_btn
            // 
            this.cancelarEditar_btn.Enabled = false;
            this.cancelarEditar_btn.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.cancelarEditar_btn.Location = new System.Drawing.Point(744, 5);
            this.cancelarEditar_btn.Name = "cancelarEditar_btn";
            this.cancelarEditar_btn.Size = new System.Drawing.Size(118, 28);
            this.cancelarEditar_btn.TabIndex = 1;
            this.cancelarEditar_btn.Text = "Cancelar Editar";
            this.cancelarEditar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarEditar_btn.UseVisualStyleBackColor = true;
            this.cancelarEditar_btn.Click += new System.EventHandler(this.cancelarEditar_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 51;
            this.label5.Text = "Agregar Fotos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 52;
            this.label7.Text = "CIUDAD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fotos Existentes";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(461, 342);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(446, 231);
            this.flowLayoutPanel2.TabIndex = 56;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ciudad_cb
            // 
            this.ciudad_cb.DropDownHeight = 180;
            this.ciudad_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudad_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciudad_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad_cb.FormattingEnabled = true;
            this.ciudad_cb.IntegralHeight = false;
            this.ciudad_cb.Location = new System.Drawing.Point(165, 149);
            this.ciudad_cb.Name = "ciudad_cb";
            this.ciudad_cb.Size = new System.Drawing.Size(262, 22);
            this.ciudad_cb.TabIndex = 3;
            // 
            // pais_cb
            // 
            this.pais_cb.DropDownHeight = 180;
            this.pais_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pais_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pais_cb.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pais_cb.FormattingEnabled = true;
            this.pais_cb.IntegralHeight = false;
            this.pais_cb.Location = new System.Drawing.Point(165, 117);
            this.pais_cb.Name = "pais_cb";
            this.pais_cb.Size = new System.Drawing.Size(262, 22);
            this.pais_cb.TabIndex = 2;
            this.pais_cb.SelectedIndexChanged += new System.EventHandler(this.pais_cb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 14);
            this.label9.TabIndex = 59;
            this.label9.Text = "PAIS:";
            // 
            // agregarImg_btn
            // 
            this.agregarImg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.agregarImg_btn.FlatAppearance.BorderSize = 0;
            this.agregarImg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarImg_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarImg_btn.Image = global::ImporteVehiculos.Properties.Resources.circulo_de_suma;
            this.agregarImg_btn.Location = new System.Drawing.Point(916, 133);
            this.agregarImg_btn.Name = "agregarImg_btn";
            this.agregarImg_btn.Size = new System.Drawing.Size(44, 45);
            this.agregarImg_btn.TabIndex = 55;
            this.agregarImg_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.agregarImg_btn.UseVisualStyleBackColor = false;
            this.agregarImg_btn.Click += new System.EventHandler(this.agregarImg_btn_Click);
            // 
            // guardarCliente_btn
            // 
            this.guardarCliente_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.guardarCliente_btn.FlatAppearance.BorderSize = 0;
            this.guardarCliente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarCliente_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarCliente_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarCliente_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarCliente_btn.Location = new System.Drawing.Point(154, 279);
            this.guardarCliente_btn.Name = "guardarCliente_btn";
            this.guardarCliente_btn.Size = new System.Drawing.Size(142, 57);
            this.guardarCliente_btn.TabIndex = 7;
            this.guardarCliente_btn.Text = "GUARDAR";
            this.guardarCliente_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarCliente_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarCliente_btn.UseVisualStyleBackColor = false;
            this.guardarCliente_btn.Click += new System.EventHandler(this.guardarCliente_btn_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(972, 629);
            this.Controls.Add(this.pais_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ciudad_cb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.agregarImg_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono1_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rncCedula_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cliente_dtg);
            this.Controls.Add(this.cliente_txt);
            this.Controls.Add(this.guardarCliente_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoCliente_chbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox telefono1_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rncCedula_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView cliente_dtg;
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.Button guardarCliente_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoCliente_chbox;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button agregarImg_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox ciudad_cb;
        private System.Windows.Forms.ComboBox pais_cb;
        private System.Windows.Forms.Label label9;
    }
}