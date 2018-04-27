namespace ImporteVehiculos.Formularios
{
    partial class TalleresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalleresForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.talleres_dtg = new System.Windows.Forms.DataGridView();
            this.taller_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoTaller_chbox = new System.Windows.Forms.CheckBox();
            this.guardarTaller_btn = new System.Windows.Forms.Button();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono1_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telefono2_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talleres_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelarEditar_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 38);
            this.panel1.TabIndex = 25;
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
            // talleres_dtg
            // 
            this.talleres_dtg.AllowUserToAddRows = false;
            this.talleres_dtg.AllowUserToDeleteRows = false;
            this.talleres_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.talleres_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.talleres_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.talleres_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talleres_dtg.Location = new System.Drawing.Point(12, 152);
            this.talleres_dtg.MultiSelect = false;
            this.talleres_dtg.Name = "talleres_dtg";
            this.talleres_dtg.ReadOnly = true;
            this.talleres_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.talleres_dtg.Size = new System.Drawing.Size(465, 259);
            this.talleres_dtg.TabIndex = 24;
            this.talleres_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.talleres_dtg_CellDoubleClick);
            // 
            // taller_txt
            // 
            this.taller_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taller_txt.Location = new System.Drawing.Point(162, 16);
            this.taller_txt.Name = "taller_txt";
            this.taller_txt.Size = new System.Drawing.Size(315, 22);
            this.taller_txt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "TALLER O TIENDA:";
            // 
            // estadoTaller_chbox
            // 
            this.estadoTaller_chbox.AutoSize = true;
            this.estadoTaller_chbox.Checked = true;
            this.estadoTaller_chbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estadoTaller_chbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTaller_chbox.Location = new System.Drawing.Point(15, 117);
            this.estadoTaller_chbox.Name = "estadoTaller_chbox";
            this.estadoTaller_chbox.Size = new System.Drawing.Size(119, 29);
            this.estadoTaller_chbox.TabIndex = 21;
            this.estadoTaller_chbox.Text = "Habilitar";
            this.estadoTaller_chbox.UseVisualStyleBackColor = true;
            // 
            // guardarTaller_btn
            // 
            this.guardarTaller_btn.BackColor = System.Drawing.Color.IndianRed;
            this.guardarTaller_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarTaller_btn.Image = global::ImporteVehiculos.Properties.Resources.disquete;
            this.guardarTaller_btn.Location = new System.Drawing.Point(305, 100);
            this.guardarTaller_btn.Name = "guardarTaller_btn";
            this.guardarTaller_btn.Size = new System.Drawing.Size(172, 46);
            this.guardarTaller_btn.TabIndex = 22;
            this.guardarTaller_btn.Text = "GUARDAR";
            this.guardarTaller_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarTaller_btn.UseVisualStyleBackColor = false;
            this.guardarTaller_btn.Click += new System.EventHandler(this.guardarTaller_btn_Click);
            // 
            // direccion_txt
            // 
            this.direccion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_txt.Location = new System.Drawing.Point(162, 44);
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(315, 22);
            this.direccion_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "DIRECCION:";
            // 
            // telefono1_txt
            // 
            this.telefono1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1_txt.Location = new System.Drawing.Point(115, 72);
            this.telefono1_txt.Name = "telefono1_txt";
            this.telefono1_txt.Size = new System.Drawing.Size(103, 22);
            this.telefono1_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "TELEFONO 1:";
            // 
            // telefono2_txt
            // 
            this.telefono2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono2_txt.Location = new System.Drawing.Point(374, 72);
            this.telefono2_txt.Name = "telefono2_txt";
            this.telefono2_txt.Size = new System.Drawing.Size(103, 22);
            this.telefono2_txt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "TELEFONO 2:";
            // 
            // TalleresForm
            // 
            this.AcceptButton = this.guardarTaller_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(502, 463);
            this.Controls.Add(this.telefono2_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono1_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.talleres_dtg);
            this.Controls.Add(this.taller_txt);
            this.Controls.Add(this.guardarTaller_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estadoTaller_chbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TalleresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talleres & Repuestos";
            this.Load += new System.EventHandler(this.TalleresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talleres_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView talleres_dtg;
        private System.Windows.Forms.TextBox taller_txt;
        private System.Windows.Forms.Button guardarTaller_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoTaller_chbox;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefono1_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefono2_txt;
        private System.Windows.Forms.Label label4;
    }
}