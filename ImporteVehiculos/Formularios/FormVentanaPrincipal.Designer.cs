namespace ImporteVehiculos.Formularios
{
    partial class FormVentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentanaPrincipal));
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasaDolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.activar_btn = new System.Windows.Forms.Button();
            this.activado_lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarSesion_btn = new System.Windows.Forms.Button();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.fecha_lbl = new System.Windows.Forms.Label();
            this.importar_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reportes_btn = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasaDolarToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración ";
            // 
            // tasaDolarToolStripMenuItem
            // 
            this.tasaDolarToolStripMenuItem.Name = "tasaDolarToolStripMenuItem";
            this.tasaDolarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tasaDolarToolStripMenuItem.Text = "Tasa Dolar";
            this.tasaDolarToolStripMenuItem.Click += new System.EventHandler(this.tasaDolarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.activar_btn);
            this.panel2.Controls.Add(this.activado_lbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 88);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // activar_btn
            // 
            this.activar_btn.FlatAppearance.BorderSize = 0;
            this.activar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activar_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activar_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.activar_btn.Image = global::ImporteVehiculos.Properties.Resources.key;
            this.activar_btn.Location = new System.Drawing.Point(11, 34);
            this.activar_btn.Name = "activar_btn";
            this.activar_btn.Size = new System.Drawing.Size(75, 49);
            this.activar_btn.TabIndex = 40;
            this.activar_btn.Text = "Activar";
            this.activar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.activar_btn.UseVisualStyleBackColor = true;
            this.activar_btn.Visible = false;
            this.activar_btn.Click += new System.EventHandler(this.activar_btn_Click);
            // 
            // activado_lbl
            // 
            this.activado_lbl.AutoSize = true;
            this.activado_lbl.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activado_lbl.ForeColor = System.Drawing.Color.Red;
            this.activado_lbl.Location = new System.Drawing.Point(12, 9);
            this.activado_lbl.Name = "activado_lbl";
            this.activado_lbl.Size = new System.Drawing.Size(410, 24);
            this.activado_lbl.TabIndex = 39;
            this.activado_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO!";
            this.activado_lbl.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ImporteVehiculos.Properties.Resources.cruzar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(803, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ImporteVehiculos.Properties.Resources.minimizar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(771, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.cerrarSesion_btn);
            this.panel1.Controls.Add(this.usuario_lbl);
            this.panel1.Controls.Add(this.fecha_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 72);
            this.panel1.TabIndex = 34;
            // 
            // cerrarSesion_btn
            // 
            this.cerrarSesion_btn.FlatAppearance.BorderSize = 0;
            this.cerrarSesion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cerrarSesion_btn.Image = global::ImporteVehiculos.Properties.Resources.salida;
            this.cerrarSesion_btn.Location = new System.Drawing.Point(705, 3);
            this.cerrarSesion_btn.Name = "cerrarSesion_btn";
            this.cerrarSesion_btn.Size = new System.Drawing.Size(112, 66);
            this.cerrarSesion_btn.TabIndex = 37;
            this.cerrarSesion_btn.Text = "Cerrar Sesión";
            this.cerrarSesion_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cerrarSesion_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cerrarSesion_btn.UseVisualStyleBackColor = true;
            this.cerrarSesion_btn.Click += new System.EventHandler(this.cerrarSesion_btn_Click);
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.usuario_lbl.Location = new System.Drawing.Point(384, 32);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(57, 20);
            this.usuario_lbl.TabIndex = 13;
            this.usuario_lbl.Text = "label2";
            // 
            // fecha_lbl
            // 
            this.fecha_lbl.AutoSize = true;
            this.fecha_lbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.fecha_lbl.Location = new System.Drawing.Point(55, 32);
            this.fecha_lbl.Name = "fecha_lbl";
            this.fecha_lbl.Size = new System.Drawing.Size(57, 20);
            this.fecha_lbl.TabIndex = 12;
            this.fecha_lbl.Text = "label2";
            // 
            // importar_btn
            // 
            this.importar_btn.Location = new System.Drawing.Point(0, 0);
            this.importar_btn.Name = "importar_btn";
            this.importar_btn.Size = new System.Drawing.Size(75, 23);
            this.importar_btn.TabIndex = 38;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = global::ImporteVehiculos.Properties.Resources.planificacion;
            this.button4.Location = new System.Drawing.Point(301, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 139);
            this.button4.TabIndex = 37;
            this.button4.Text = "PROCESOS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::ImporteVehiculos.Properties.Resources.ajustes__1_;
            this.button1.Location = new System.Drawing.Point(25, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 139);
            this.button1.TabIndex = 36;
            this.button1.Text = "CONFIGURACIONES";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportes_btn
            // 
            this.reportes_btn.FlatAppearance.BorderSize = 0;
            this.reportes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportes_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportes_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportes_btn.Image = global::ImporteVehiculos.Properties.Resources.laptop__1_;
            this.reportes_btn.Location = new System.Drawing.Point(567, 159);
            this.reportes_btn.Name = "reportes_btn";
            this.reportes_btn.Size = new System.Drawing.Size(204, 139);
            this.reportes_btn.TabIndex = 8;
            this.reportes_btn.Text = "REPORTES";
            this.reportes_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportes_btn.UseVisualStyleBackColor = true;
            this.reportes_btn.Click += new System.EventHandler(this.reportes_btn_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 3600;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FormVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(829, 468);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportes_btn);
            this.Controls.Add(this.importar_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormVentanaPrincipal_Load);
            this.Shown += new System.EventHandler(this.FormVentanaPrincipal_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasaDolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button importar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportes_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.Label fecha_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cerrarSesion_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button activar_btn;
        private System.Windows.Forms.Label activado_lbl;
        private System.Windows.Forms.Timer timer3;
    }
}