namespace ImporteVehiculos.Formularios
{
    partial class GastosGeneralesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GastosGeneralesForm));
            this.descripcionGasto_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gastos_dtg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoGasto_chbox = new System.Windows.Forms.CheckBox();
            this.guardarGasto_btn = new System.Windows.Forms.Button();
            this.tipoGasto_cbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastos_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionGasto_txt
            // 
            this.descripcionGasto_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionGasto_txt.Location = new System.Drawing.Point(145, 51);
            this.descripcionGasto_txt.Name = "descripcionGasto_txt";
            this.descripcionGasto_txt.Size = new System.Drawing.Size(332, 22);
            this.descripcionGasto_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "TIPO GASTO:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelarEditar_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 38);
            this.panel1.TabIndex = 40;
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
            // gastos_dtg
            // 
            this.gastos_dtg.AllowUserToAddRows = false;
            this.gastos_dtg.AllowUserToDeleteRows = false;
            this.gastos_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gastos_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gastos_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gastos_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gastos_dtg.Location = new System.Drawing.Point(12, 142);
            this.gastos_dtg.MultiSelect = false;
            this.gastos_dtg.Name = "gastos_dtg";
            this.gastos_dtg.ReadOnly = true;
            this.gastos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gastos_dtg.Size = new System.Drawing.Size(465, 259);
            this.gastos_dtg.TabIndex = 39;
            this.gastos_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gastos_dtg_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 38;
            // 
            // estadoGasto_chbox
            // 
            this.estadoGasto_chbox.AutoSize = true;
            this.estadoGasto_chbox.Checked = true;
            this.estadoGasto_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoGasto_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoGasto_chbox.Location = new System.Drawing.Point(15, 107);
            this.estadoGasto_chbox.Name = "estadoGasto_chbox";
            this.estadoGasto_chbox.Size = new System.Drawing.Size(119, 29);
            this.estadoGasto_chbox.TabIndex = 2;
            this.estadoGasto_chbox.Text = "Habilitar";
            this.estadoGasto_chbox.UseVisualStyleBackColor = true;
            // 
            // guardarGasto_btn
            // 
            this.guardarGasto_btn.BackColor = System.Drawing.Color.IndianRed;
            this.guardarGasto_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarGasto_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarGasto_btn.Location = new System.Drawing.Point(305, 90);
            this.guardarGasto_btn.Name = "guardarGasto_btn";
            this.guardarGasto_btn.Size = new System.Drawing.Size(172, 46);
            this.guardarGasto_btn.TabIndex = 3;
            this.guardarGasto_btn.Text = "GUARDAR";
            this.guardarGasto_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarGasto_btn.UseVisualStyleBackColor = false;
            this.guardarGasto_btn.Click += new System.EventHandler(this.guardarGasto_btn_Click);
            // 
            // tipoGasto_cbox
            // 
            this.tipoGasto_cbox.DropDownHeight = 180;
            this.tipoGasto_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoGasto_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoGasto_cbox.FormattingEnabled = true;
            this.tipoGasto_cbox.IntegralHeight = false;
            this.tipoGasto_cbox.Items.AddRange(new object[] {
            "OTROS GASTOS",
            "REPARACION"});
            this.tipoGasto_cbox.Location = new System.Drawing.Point(145, 9);
            this.tipoGasto_cbox.Name = "tipoGasto_cbox";
            this.tipoGasto_cbox.Size = new System.Drawing.Size(332, 26);
            this.tipoGasto_cbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "DESCRIPCION:";
            // 
            // GastosGeneralesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(500, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoGasto_cbox);
            this.Controls.Add(this.descripcionGasto_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gastos_dtg);
            this.Controls.Add(this.guardarGasto_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoGasto_chbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GastosGeneralesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos Generales";
            this.Load += new System.EventHandler(this.GastosGeneralesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastos_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descripcionGasto_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gastos_dtg;
        private System.Windows.Forms.Button guardarGasto_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoGasto_chbox;
        private System.Windows.Forms.ComboBox tipoGasto_cbox;
        private System.Windows.Forms.Label label2;
    }
}