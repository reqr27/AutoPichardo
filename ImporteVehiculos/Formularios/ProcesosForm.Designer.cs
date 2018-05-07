namespace ImporteVehiculos.Formularios
{
    partial class ProcesosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.servicios_btn = new System.Windows.Forms.Button();
            this.cuentasCobrar_btn = new System.Windows.Forms.Button();
            this.cuentasPagar_btn = new System.Windows.Forms.Button();
            this.facturacion_btn = new System.Windows.Forms.Button();
            this.compras_btn = new System.Windows.Forms.Button();
            this.importar_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 24);
            this.label27.TabIndex = 36;
            this.label27.Text = "PROCESOS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::ImporteVehiculos.Properties.Resources.accounting_book;
            this.button1.Location = new System.Drawing.Point(63, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 139);
            this.button1.TabIndex = 14;
            this.button1.Text = "AGREGAR CC/CP";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicios_btn
            // 
            this.servicios_btn.FlatAppearance.BorderSize = 0;
            this.servicios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicios_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicios_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.servicios_btn.Image = global::ImporteVehiculos.Properties.Resources.bill;
            this.servicios_btn.Location = new System.Drawing.Point(539, 217);
            this.servicios_btn.Name = "servicios_btn";
            this.servicios_btn.Size = new System.Drawing.Size(149, 139);
            this.servicios_btn.TabIndex = 13;
            this.servicios_btn.Text = "FACTURAS SERVICIOS";
            this.servicios_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.servicios_btn.UseVisualStyleBackColor = true;
            this.servicios_btn.Click += new System.EventHandler(this.servicios_btn_Click);
            // 
            // cuentasCobrar_btn
            // 
            this.cuentasCobrar_btn.FlatAppearance.BorderSize = 0;
            this.cuentasCobrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuentasCobrar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentasCobrar_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuentasCobrar_btn.Image = global::ImporteVehiculos.Properties.Resources.banco;
            this.cuentasCobrar_btn.Location = new System.Drawing.Point(307, 217);
            this.cuentasCobrar_btn.Name = "cuentasCobrar_btn";
            this.cuentasCobrar_btn.Size = new System.Drawing.Size(149, 139);
            this.cuentasCobrar_btn.TabIndex = 12;
            this.cuentasCobrar_btn.Text = "CUENTAS POR COBRAR";
            this.cuentasCobrar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cuentasCobrar_btn.UseVisualStyleBackColor = true;
            this.cuentasCobrar_btn.Click += new System.EventHandler(this.cuentasCobrar_btn_Click);
            // 
            // cuentasPagar_btn
            // 
            this.cuentasPagar_btn.FlatAppearance.BorderSize = 0;
            this.cuentasPagar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuentasPagar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentasPagar_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuentasPagar_btn.Image = global::ImporteVehiculos.Properties.Resources.proyecto_de_ley;
            this.cuentasPagar_btn.Location = new System.Drawing.Point(63, 217);
            this.cuentasPagar_btn.Name = "cuentasPagar_btn";
            this.cuentasPagar_btn.Size = new System.Drawing.Size(149, 139);
            this.cuentasPagar_btn.TabIndex = 11;
            this.cuentasPagar_btn.Text = "CUENTAS POR PAGAR";
            this.cuentasPagar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cuentasPagar_btn.UseVisualStyleBackColor = true;
            this.cuentasPagar_btn.Click += new System.EventHandler(this.cuentasPagar_btn_Click);
            // 
            // facturacion_btn
            // 
            this.facturacion_btn.FlatAppearance.BorderSize = 0;
            this.facturacion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturacion_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacion_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.facturacion_btn.Image = global::ImporteVehiculos.Properties.Resources.maquina_de_facturacion;
            this.facturacion_btn.Location = new System.Drawing.Point(550, 56);
            this.facturacion_btn.Name = "facturacion_btn";
            this.facturacion_btn.Size = new System.Drawing.Size(149, 139);
            this.facturacion_btn.TabIndex = 10;
            this.facturacion_btn.Text = "FACTURACION";
            this.facturacion_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.facturacion_btn.UseVisualStyleBackColor = true;
            this.facturacion_btn.Click += new System.EventHandler(this.facturacion_btn_Click);
            // 
            // compras_btn
            // 
            this.compras_btn.FlatAppearance.BorderSize = 0;
            this.compras_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compras_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.compras_btn.Image = global::ImporteVehiculos.Properties.Resources.carro;
            this.compras_btn.Location = new System.Drawing.Point(63, 56);
            this.compras_btn.Name = "compras_btn";
            this.compras_btn.Size = new System.Drawing.Size(149, 139);
            this.compras_btn.TabIndex = 9;
            this.compras_btn.Text = "COMPRAS";
            this.compras_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compras_btn.UseVisualStyleBackColor = true;
            this.compras_btn.Click += new System.EventHandler(this.compras_btn_Click);
            // 
            // importar_btn
            // 
            this.importar_btn.FlatAppearance.BorderSize = 0;
            this.importar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importar_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.importar_btn.Image = global::ImporteVehiculos.Properties.Resources.camion_de_reparto;
            this.importar_btn.Location = new System.Drawing.Point(307, 56);
            this.importar_btn.Name = "importar_btn";
            this.importar_btn.Size = new System.Drawing.Size(149, 139);
            this.importar_btn.TabIndex = 8;
            this.importar_btn.Text = "VEHICULOS";
            this.importar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.importar_btn.UseVisualStyleBackColor = true;
            this.importar_btn.Click += new System.EventHandler(this.importar_btn_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(662, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 35;
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
            this.button2.Location = new System.Drawing.Point(694, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 34;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProcesosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(726, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.servicios_btn);
            this.Controls.Add(this.cuentasCobrar_btn);
            this.Controls.Add(this.cuentasPagar_btn);
            this.Controls.Add(this.facturacion_btn);
            this.Controls.Add(this.compras_btn);
            this.Controls.Add(this.importar_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcesosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcesosForm_FormClosed);
            this.Load += new System.EventHandler(this.ProcesosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button importar_btn;
        private System.Windows.Forms.Button compras_btn;
        private System.Windows.Forms.Button facturacion_btn;
        private System.Windows.Forms.Button cuentasPagar_btn;
        private System.Windows.Forms.Button cuentasCobrar_btn;
        private System.Windows.Forms.Button servicios_btn;
        private System.Windows.Forms.Button button1;
    }
}