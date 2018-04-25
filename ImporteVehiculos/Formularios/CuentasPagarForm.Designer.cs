namespace ImporteVehiculos.Formularios
{
    partial class CuentasPagarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentasPagarForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoTransaccion_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hasta_dtp = new System.Windows.Forms.DateTimePicker();
            this.desde_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.propietario_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.verDetalles_btn = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cuentasPagar_dtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.restante_USD_lbl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.restante_RD_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasPagar_dtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 129);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tipoTransaccion_cb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.hasta_dtp);
            this.panel3.Controls.Add(this.desde_dtp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.propietario_txt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.verDetalles_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 84);
            this.panel3.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(209, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 103;
            this.label4.Text = "TRANSACCION: ";
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
            this.tipoTransaccion_cb.Location = new System.Drawing.Point(316, 16);
            this.tipoTransaccion_cb.Name = "tipoTransaccion_cb";
            this.tipoTransaccion_cb.Size = new System.Drawing.Size(207, 23);
            this.tipoTransaccion_cb.TabIndex = 102;
            this.tipoTransaccion_cb.SelectionChangeCommitted += new System.EventHandler(this.tipoTransaccion_cb_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Hasta:";
            // 
            // hasta_dtp
            // 
            this.hasta_dtp.CustomFormat = "dd/MM/yyyy";
            this.hasta_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hasta_dtp.Location = new System.Drawing.Point(59, 50);
            this.hasta_dtp.Name = "hasta_dtp";
            this.hasta_dtp.Size = new System.Drawing.Size(102, 20);
            this.hasta_dtp.TabIndex = 59;
            this.hasta_dtp.ValueChanged += new System.EventHandler(this.hasta_dtp_ValueChanged);
            // 
            // desde_dtp
            // 
            this.desde_dtp.CustomFormat = "dd/MM/yyyy";
            this.desde_dtp.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde_dtp.Location = new System.Drawing.Point(59, 20);
            this.desde_dtp.Name = "desde_dtp";
            this.desde_dtp.Size = new System.Drawing.Size(102, 20);
            this.desde_dtp.TabIndex = 57;
            this.desde_dtp.ValueChanged += new System.EventHandler(this.hasta_dtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Desde:";
            // 
            // propietario_txt
            // 
            this.propietario_txt.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propietario_txt.Location = new System.Drawing.Point(316, 47);
            this.propietario_txt.Name = "propietario_txt";
            this.propietario_txt.Size = new System.Drawing.Size(207, 20);
            this.propietario_txt.TabIndex = 51;
            this.propietario_txt.TextChanged += new System.EventHandler(this.propietario_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(209, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "PAGAR A:";
            // 
            // verDetalles_btn
            // 
            this.verDetalles_btn.FlatAppearance.BorderSize = 0;
            this.verDetalles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verDetalles_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verDetalles_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.verDetalles_btn.Image = global::ImporteVehiculos.Properties.Resources.portapapeles;
            this.verDetalles_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verDetalles_btn.Location = new System.Drawing.Point(570, 3);
            this.verDetalles_btn.Name = "verDetalles_btn";
            this.verDetalles_btn.Size = new System.Drawing.Size(92, 53);
            this.verDetalles_btn.TabIndex = 50;
            this.verDetalles_btn.Text = "Ver Detalles";
            this.verDetalles_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.verDetalles_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.verDetalles_btn.UseVisualStyleBackColor = true;
            this.verDetalles_btn.Click += new System.EventHandler(this.verDetalles_btn_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(3, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(256, 24);
            this.label27.TabIndex = 38;
            this.label27.Text = "CUENTAS POR PAGAR";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(602, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 37;
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
            this.button2.Location = new System.Drawing.Point(634, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 36;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cuentasPagar_dtg
            // 
            this.cuentasPagar_dtg.AllowUserToAddRows = false;
            this.cuentasPagar_dtg.AllowUserToDeleteRows = false;
            this.cuentasPagar_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.cuentasPagar_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cuentasPagar_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cuentasPagar_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuentasPagar_dtg.Location = new System.Drawing.Point(15, 153);
            this.cuentasPagar_dtg.MultiSelect = false;
            this.cuentasPagar_dtg.Name = "cuentasPagar_dtg";
            this.cuentasPagar_dtg.ReadOnly = true;
            this.cuentasPagar_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cuentasPagar_dtg.Size = new System.Drawing.Size(629, 255);
            this.cuentasPagar_dtg.TabIndex = 41;
            this.cuentasPagar_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuentasPagar_dtg_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.restante_USD_lbl);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.restante_RD_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 41);
            this.panel2.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label18.Location = new System.Drawing.Point(407, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 13);
            this.label18.TabIndex = 123;
            this.label18.Text = "PENDIENTE($USD):";
            // 
            // restante_USD_lbl
            // 
            this.restante_USD_lbl.AutoSize = true;
            this.restante_USD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_USD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restante_USD_lbl.Location = new System.Drawing.Point(536, 13);
            this.restante_USD_lbl.Name = "restante_USD_lbl";
            this.restante_USD_lbl.Size = new System.Drawing.Size(21, 13);
            this.restante_USD_lbl.TabIndex = 124;
            this.restante_USD_lbl.Text = "pv";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label21.Location = new System.Drawing.Point(56, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 118;
            this.label21.Text = "PENDIENTE($RD):";
            // 
            // restante_RD_lbl
            // 
            this.restante_RD_lbl.AutoSize = true;
            this.restante_RD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante_RD_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restante_RD_lbl.Location = new System.Drawing.Point(177, 13);
            this.restante_RD_lbl.Name = "restante_RD_lbl";
            this.restante_RD_lbl.Size = new System.Drawing.Size(21, 13);
            this.restante_RD_lbl.TabIndex = 119;
            this.restante_RD_lbl.Text = "pv";
            // 
            // CuentasPagarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cuentasPagar_dtg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CuentasPagarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUENTAS POR PAGAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CuentasPagarForm_FormClosed);
            this.Load += new System.EventHandler(this.CuentasPagarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasPagar_dtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cuentasPagar_dtg;
        private System.Windows.Forms.TextBox propietario_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button verDetalles_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hasta_dtp;
        private System.Windows.Forms.DateTimePicker desde_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label restante_USD_lbl;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label restante_RD_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoTransaccion_cb;
    }
}