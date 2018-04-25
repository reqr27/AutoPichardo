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
namespace ImporteVehiculos.Formularios
{
    public partial class ConfiguracionForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public ConfiguracionForm()
        {
            InitializeComponent();
        }

        public void Permisos()
        {
            bool permiso = GF.ValidarPermisoTransaccion("CREAR USUARIOS");
            if (!permiso)
            {
                crearUsuarios_btn.Enabled = false;
            }
            permiso = GF.ValidarPermisoTransaccion("CREAR FABRICANTES/MODELOS");
            if (!permiso)
            {
                fabricantesModelos_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR PIEZAS/REPUESTOS");
            if (!permiso)
            {
                piezasRepuestos_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR TALLER");
            if (!permiso)
            {
                taller_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR PROPIETARIOS");
            if (!permiso)
            {
                propietarios_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR CLIENTES");
            if (!permiso)
            {
                clientes_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR GASTOS");
            if (!permiso)
            {
                gastos_btn.Enabled = false;
            }
            permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                dolares_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR PAISES");
            if (!permiso)
            {
                pais_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR CIUDADES");
            if (!permiso)
            {
                ciudades_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR COLORES");
            if (!permiso)
            {
                colores_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR SUPLIDORES");
            if (!permiso)
            {
                suplidores_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR UBICACIONES");
            if (!permiso)
            {
                ubicacion_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR SEGUROS");
            if (!permiso)
            {
                seguros_btn.Enabled = false;
            }
        }

        private void crearUsuarios_btn_Click(object sender, EventArgs e)
        {
            UsuariosForm form = new UsuariosForm();
            form.ShowDialog();
        }

        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            Permisos();
        }

        private void piezasRepuestos_btn_Click(object sender, EventArgs e)
        {
            PiezasRepuestosForm form = new PiezasRepuestosForm();
            form.ShowDialog();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clientes_btn_Click(object sender, EventArgs e)
        {
            ClienteForm form = new ClienteForm();
            form.ShowDialog();
        }

        private void gastos_btn_Click(object sender, EventArgs e)
        {
            GastosGeneralesForm form = new GastosGeneralesForm();
            form.ShowDialog();
        }

        private void propietarios_btn_Click(object sender, EventArgs e)
        {
            PropietariosForm form = new PropietariosForm();
            form.ShowDialog();
        }

        private void taller_btn_Click(object sender, EventArgs e)
        {
            TalleresForm form = new TalleresForm();
            form.ShowDialog();
        }

        private void fabricantesModelos_btn_Click(object sender, EventArgs e)
        {
            AgregarFabricantesModelosForm form = new AgregarFabricantesModelosForm();
            form.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dolares_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DolaresForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                DolaresForm frm = new DolaresForm();
                frm.Show();
            }
        }

        private void pais_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["PaisesForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                PaisesForm frm = new PaisesForm();
                frm.Show();
            }
        }

        private void ciudades_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["CiudadForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                CiudadForm frm = new CiudadForm();
                frm.Show();
            }
        }

        private void colores_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ColoresForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                ColoresForm frm = new ColoresForm();
                frm.Show();
            }
        }

        private void ubicacion_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["UbicacionForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                UbicacionForm frm = new UbicacionForm();
                frm.Show();
            }

        }

        private void suplidores_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["SuplidoresForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                SuplidoresForm frm = new SuplidoresForm();
                frm.Show();
            }
        }

        private void seguros_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["SegurosForm"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                SegurosForm frm = new SegurosForm();
                frm.Show();
            }
        }

        private void ConfiguracionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.OpenForms["FormVentanaPrincipal"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FormVentanaPrincipal"].BringToFront();
            }
            catch
            {

            }
           
        }
    }
}
