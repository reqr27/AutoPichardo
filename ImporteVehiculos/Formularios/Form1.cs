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



namespace ImporteVehiculos
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                usuario_txt.Text = Properties.Settings.Default.usuario;
                login_panel.Location = new Point(this.ClientSize.Width / 2 - login_panel.Size.Width / 2, this.ClientSize.Height / 2 - login_panel.Size.Height / 2);
                login_panel.Anchor = AnchorStyles.None;
                if ((Properties.Settings.Default.usuario != ""))
                {
                    this.ActiveControl = password_txt;
                }
                P.LLenarTablas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        public void IniciarSesion()
        {
            P.Usuario = usuario_txt.Text;
            P.Clave = password_txt.Text;
            int idUsuario = Convert.ToInt32(P.Login());
            if (idUsuario != 0)
            {
                Properties.Settings.Default.usuario = usuario_txt.Text;
                Properties.Settings.Default.Save();
                Program.GidUsuario = idUsuario;
                Program.Gusuario = usuario_txt.Text;
                this.Hide();

                ImporteVehiculos.Formularios.FormVentanaPrincipal form = new Formularios.FormVentanaPrincipal();
                form.Show();

                
            }
            else
            {
                MessageBox.Show("Clave o usuario no coinciden", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                password_txt.Text = "";
            }
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
