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
    public partial class ProcesosForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public ProcesosForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ProcesosForm_Load(object sender, EventArgs e)
        {
            
        }

        private void importar_btn_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["ImporteForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                ImporteForm formImporte = new ImporteForm();
                formImporte.Show();
            }

            
        }

        private void compras_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["NuevoVehiculoForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                NuevoVehiculoForm frm = new NuevoVehiculoForm();
                frm.Show();
            }
        }

        private void facturacion_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["VenderForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                VenderForm frm = new VenderForm();
                frm.Show();
            }
        }

        private void cuentasPagar_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["CuentasPagarForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                CuentasPagarForm frm = new CuentasPagarForm();
                frm.Show();
            }
        }

        private void cuentasCobrar_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["CuentasCobrarForm"];
            if (fc != null)
            {
                fc.BringToFront();
                fc.WindowState = FormWindowState.Normal;
            }
            else
            {
                CuentasCobrarForm frm = new CuentasCobrarForm();
                frm.Show();
            }
        }

        public void Permisos()
        {
            bool permiso;
            permiso = GF.ValidarPermisoTransaccion("COMPRAS");
            if (!permiso)
            {
                compras_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("FACTURACION");
            if (!permiso)
            {
                facturacion_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("IMPORTAR VEHICULOS");
            if (!permiso)
            {
                compras_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CUENTAS COBRAR");
            if (!permiso)
            {
                cuentasCobrar_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CUENTAS PAGAR");
            if (!permiso)
            {
                cuentasPagar_btn.Enabled = false;
            }

        }

        private void ProcesosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.OpenForms["FormVentanaPrincipal"].WindowState = FormWindowState.Normal;
                Application.OpenForms["FormVentanaPrincipal"].BringToFront();
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
