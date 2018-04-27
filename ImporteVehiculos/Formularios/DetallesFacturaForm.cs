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
    public partial class DetallesFacturaForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();

        public DetallesFacturaForm()
        {
            InitializeComponent();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LLenarDtgDetallesFacturas()
        {
            
            
                DataTable dt = new DataTable();
                detalleFactura_dtg.DataSource = null;
                P.Id = Program.GidFacturaServicio;
                dt = P.ObtenerFacturasDetallesServicios();
                detalleFactura_dtg.DataSource = dt;
                detalleFactura_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                detalleFactura_dtg.Columns[4].DefaultCellStyle.Format = "N2";
            

        }

        private void DetallesFacturaForm_Load(object sender, EventArgs e)
        {
            LLenarDtgDetallesFacturas();
        }
    }
}
