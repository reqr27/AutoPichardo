using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImporteVehiculos.Classes;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace ImporteVehiculos.Formularios
{
    public partial class FormVentanaPrincipal : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        GlobalFunctions GF = new GlobalFunctions();
        Procedimientos P = new Procedimientos();
        public FormVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FormVentanaPrincipal_Load(object sender, EventArgs e)
        {
            validarActivado();
            label1.Text = Program.Gtitulo;
            Permisos();
            timer1.Start();
            timer3.Start();
            usuario_lbl.Text = "Usuario: " + Program.Gusuario + "       ID:" + Program.GidUsuario.ToString();
            ActualizarHoraFecha();
            
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(0, 150, this.Width, this.Height);
            //Region region = new Region(path);
            //this.Region = region;
        }


        private void tasaDolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DolaresForm form = new DolaresForm();
            form.ShowDialog();
        }


        public void Permisos()
        {
            bool permiso = GF.ValidarPermisoTransaccion("CREAR USUARIOS");

            permiso = GF.ValidarPermisoTransaccion("REPORTES");
            if (!permiso)
            {
                reportes_btn.Enabled = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            ActualizarHoraFecha();
            validarActivado();
            timer1.Start();
        }
        public void ActualizarHoraFecha()
        {
            fecha_lbl.Text = DateTime.Now.Hour.ToString("00")+ ":"+ DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") +" " +DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

        }



        private void reportes_btn_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["ReportesVentana"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                ReportesVentana form = new ReportesVentana();
                form.Show();
            }

            
        }

        private void FormVentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Hide();

                //Form1 form = new Form1();
                //form.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["ConfiguracionForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                ConfiguracionForm frm = new ConfiguracionForm();
                frm.Show();
            }

            
        }

        private void cerrarSesion_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ProcesosForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                ProcesosForm frm = new ProcesosForm();
                frm.Show();
            }
        }

        private void FormVentanaPrincipal_Shown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerTasaDolarYFecha();
            string lastDate = dt.Rows[0]["FACTUALIZADO"].ToString();
            string now = DateTime.Now.Date.ToString("dd/MM/yyyy");
            bool permiso = GF.ValidarPermisoTransaccion("ACTUALIZAR TASA DIARIO");

            if (permiso && ((DateTime.ParseExact(lastDate, "dd/MM/yyyy", CultureInfo.InvariantCulture) < DateTime.ParseExact(now, "dd/MM/yyyy", CultureInfo.InvariantCulture))))
            {
                
                DolaresForm form = new DolaresForm();
                form.ShowDialog();
            }
           
        }

        public void validarActivado()
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerDiasActivo();
           
            string dias = dt.Rows[0]["DIAS"].ToString();
            
           

            string mensaje = P.RevisarSoftwareActivado();
            if(mensaje == "1")
            {
                activar_btn.Visible = false;
                
                activado_lbl.Visible = true;
                activado_lbl.Text = "VERSION DE PRUEBA - DIAS RESTANTES: " + dias;
                button1.Enabled = true;
                button4.Enabled = true;
                reportes_btn.Enabled = true;
            }

            else
            {
                if(dias == "1")
                {
                    activado_lbl.Text = "VERSION DE PRUEBA - DIAS RESTANTES: 0";
                }
                activar_btn.Visible = true;
                activado_lbl.Visible = true;
                button1.Enabled = false;
                button4.Enabled = false;
                reportes_btn.Enabled = false;

                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                foreach (Form f in openForms)
                {
                    
                    if (f.Name != "FormVentanaPrincipal" && f.Name != "Form1" && f.Name != "ActivationForm")
                        f.Close();
                }
            }
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            ActivationForm frm = new ActivationForm();
            frm.ShowDialog();
            validarActivado();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            validarActivado();
            timer3.Start();
        }
    }
}
