namespace ImporteVehiculos.Formularios
{
    partial class PiezasRepuestosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PiezasRepuestosForm));
            this.label5 = new System.Windows.Forms.Label();
            this.fabricante_cbox = new System.Windows.Forms.ComboBox();
            this.pieza_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoComponente_chbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Componentes_dtg = new System.Windows.Forms.DataGridView();
            this.modelo_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.precio_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.usdDinero_radiobtn = new System.Windows.Forms.RadioButton();
            this.año_cb = new System.Windows.Forms.ComboBox();
            this.tasa_lbl = new System.Windows.Forms.LinkLabel();
            this.guardarComponente_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Componentes_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "MODELO:";
            // 
            // fabricante_cbox
            // 
            this.fabricante_cbox.DropDownHeight = 180;
            this.fabricante_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricante_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricante_cbox.FormattingEnabled = true;
            this.fabricante_cbox.IntegralHeight = false;
            this.fabricante_cbox.Location = new System.Drawing.Point(12, 42);
            this.fabricante_cbox.Name = "fabricante_cbox";
            this.fabricante_cbox.Size = new System.Drawing.Size(276, 24);
            this.fabricante_cbox.TabIndex = 0;
            this.fabricante_cbox.DropDown += new System.EventHandler(this.fabricante_cbox_DropDown);
            this.fabricante_cbox.SelectedIndexChanged += new System.EventHandler(this.fabricante_cbox_SelectedIndexChanged);
            // 
            // pieza_txt
            // 
            this.pieza_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieza_txt.Location = new System.Drawing.Point(12, 135);
            this.pieza_txt.Name = "pieza_txt";
            this.pieza_txt.Size = new System.Drawing.Size(276, 22);
            this.pieza_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "PIEZA O REPUESTO:";
            // 
            // estadoComponente_chbox
            // 
            this.estadoComponente_chbox.AutoSize = true;
            this.estadoComponente_chbox.Checked = true;
            this.estadoComponente_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoComponente_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComponente_chbox.Location = new System.Drawing.Point(176, 206);
            this.estadoComponente_chbox.Name = "estadoComponente_chbox";
            this.estadoComponente_chbox.Size = new System.Drawing.Size(119, 29);
            this.estadoComponente_chbox.TabIndex = 7;
            this.estadoComponente_chbox.Text = "Habilitar";
            this.estadoComponente_chbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "FABRICANTE:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelarEditar_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(301, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 38);
            this.panel1.TabIndex = 19;
            // 
            // cancelarEditar_btn
            // 
            this.cancelarEditar_btn.Enabled = false;
            this.cancelarEditar_btn.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.cancelarEditar_btn.Location = new System.Drawing.Point(340, 3);
            this.cancelarEditar_btn.Name = "cancelarEditar_btn";
            this.cancelarEditar_btn.Size = new System.Drawing.Size(118, 28);
            this.cancelarEditar_btn.TabIndex = 1;
            this.cancelarEditar_btn.Text = "Cancelar Editar";
            this.cancelarEditar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarEditar_btn.UseVisualStyleBackColor = true;
            this.cancelarEditar_btn.Click += new System.EventHandler(this.cancelarEditar_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doble Click para Actualizar!";
            // 
            // Componentes_dtg
            // 
            this.Componentes_dtg.AllowUserToAddRows = false;
            this.Componentes_dtg.AllowUserToDeleteRows = false;
            this.Componentes_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Componentes_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Componentes_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Componentes_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Componentes_dtg.Location = new System.Drawing.Point(301, 53);
            this.Componentes_dtg.MultiSelect = false;
            this.Componentes_dtg.Name = "Componentes_dtg";
            this.Componentes_dtg.ReadOnly = true;
            this.Componentes_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Componentes_dtg.Size = new System.Drawing.Size(465, 259);
            this.Componentes_dtg.TabIndex = 18;
            this.Componentes_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Componentes_dtg_CellDoubleClick);
            // 
            // modelo_cb
            // 
            this.modelo_cb.DropDownHeight = 180;
            this.modelo_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelo_cb.Enabled = false;
            this.modelo_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_cb.FormattingEnabled = true;
            this.modelo_cb.IntegralHeight = false;
            this.modelo_cb.Location = new System.Drawing.Point(12, 89);
            this.modelo_cb.Name = "modelo_cb";
            this.modelo_cb.Size = new System.Drawing.Size(154, 24);
            this.modelo_cb.TabIndex = 1;
            this.modelo_cb.DropDown += new System.EventHandler(this.modelo_cb_DropDown);
            this.modelo_cb.SelectedIndexChanged += new System.EventHandler(this.modelo_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "AÑO:";
            // 
            // precio_txt
            // 
            this.precio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_txt.Location = new System.Drawing.Point(8, 211);
            this.precio_txt.Name = "precio_txt";
            this.precio_txt.Size = new System.Drawing.Size(101, 22);
            this.precio_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRECIO:";
            // 
            // rdDinero_radiobtn
            // 
            this.rdDinero_radiobtn.AutoSize = true;
            this.rdDinero_radiobtn.Checked = true;
            this.rdDinero_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDinero_radiobtn.Location = new System.Drawing.Point(10, 163);
            this.rdDinero_radiobtn.Name = "rdDinero_radiobtn";
            this.rdDinero_radiobtn.Size = new System.Drawing.Size(59, 22);
            this.rdDinero_radiobtn.TabIndex = 23;
            this.rdDinero_radiobtn.TabStop = true;
            this.rdDinero_radiobtn.Tag = "4";
            this.rdDinero_radiobtn.Text = "RD$";
            this.rdDinero_radiobtn.UseVisualStyleBackColor = true;
            // 
            // usdDinero_radiobtn
            // 
            this.usdDinero_radiobtn.AutoSize = true;
            this.usdDinero_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdDinero_radiobtn.Location = new System.Drawing.Point(81, 163);
            this.usdDinero_radiobtn.Name = "usdDinero_radiobtn";
            this.usdDinero_radiobtn.Size = new System.Drawing.Size(70, 22);
            this.usdDinero_radiobtn.TabIndex = 5;
            this.usdDinero_radiobtn.Text = "USD$";
            this.usdDinero_radiobtn.UseVisualStyleBackColor = true;
            // 
            // año_cb
            // 
            this.año_cb.DropDownHeight = 180;
            this.año_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.año_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año_cb.FormattingEnabled = true;
            this.año_cb.IntegralHeight = false;
            this.año_cb.Location = new System.Drawing.Point(189, 89);
            this.año_cb.Name = "año_cb";
            this.año_cb.Size = new System.Drawing.Size(96, 24);
            this.año_cb.TabIndex = 2;
            this.año_cb.SelectedIndexChanged += new System.EventHandler(this.año_cb_SelectedIndexChanged);
            // 
            // tasa_lbl
            // 
            this.tasa_lbl.AutoSize = true;
            this.tasa_lbl.Location = new System.Drawing.Point(157, 169);
            this.tasa_lbl.Name = "tasa_lbl";
            this.tasa_lbl.Size = new System.Drawing.Size(72, 13);
            this.tasa_lbl.TabIndex = 26;
            this.tasa_lbl.TabStop = true;
            this.tasa_lbl.Text = "1.00 USD$ ->";
            this.tasa_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tasa_lbl_LinkClicked);
            // 
            // guardarComponente_btn
            // 
            this.guardarComponente_btn.BackColor = System.Drawing.Color.IndianRed;
            this.guardarComponente_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarComponente_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarComponente_btn.Location = new System.Drawing.Point(57, 258);
            this.guardarComponente_btn.Name = "guardarComponente_btn";
            this.guardarComponente_btn.Size = new System.Drawing.Size(172, 54);
            this.guardarComponente_btn.TabIndex = 8;
            this.guardarComponente_btn.Text = "GUARDAR";
            this.guardarComponente_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarComponente_btn.UseVisualStyleBackColor = false;
            this.guardarComponente_btn.Click += new System.EventHandler(this.guardarComponente_btn_Click);
            // 
            // PiezasRepuestosForm
            // 
            this.AcceptButton = this.guardarComponente_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(778, 319);
            this.Controls.Add(this.tasa_lbl);
            this.Controls.Add(this.año_cb);
            this.Controls.Add(this.usdDinero_radiobtn);
            this.Controls.Add(this.rdDinero_radiobtn);
            this.Controls.Add(this.precio_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelo_cb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Componentes_dtg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fabricante_cbox);
            this.Controls.Add(this.pieza_txt);
            this.Controls.Add(this.guardarComponente_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoComponente_chbox);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PiezasRepuestosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Piezas & Repuestos";
            this.Load += new System.EventHandler(this.PiezasRepuestosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Componentes_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fabricante_cbox;
        private System.Windows.Forms.TextBox pieza_txt;
        private System.Windows.Forms.Button guardarComponente_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoComponente_chbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Componentes_dtg;
        private System.Windows.Forms.ComboBox modelo_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precio_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdDinero_radiobtn;
        private System.Windows.Forms.RadioButton usdDinero_radiobtn;
        private System.Windows.Forms.ComboBox año_cb;
        private System.Windows.Forms.LinkLabel tasa_lbl;
    }
}