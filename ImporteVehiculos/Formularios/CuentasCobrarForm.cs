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
    public partial class CuentasCobrarForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public CuentasCobrarForm()
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

        private void CuentasCobrarForm_Load(object sender, EventArgs e)
        {
            desde_dtp.Value = DateTime.Now.AddMonths(-1);
            LlenarDtgCuentasCobrar();
            CalcularTotal();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void LlenarDtgCuentasCobrar()
        {
            DataTable dt = new DataTable();

            P.Cliente = cliente_txt.Text;
            P.Desde = desde_dtp.Value;
            P.Hasta = hasta_dtp.Value;
            dt = P.ObtenerCuentasPorCobrar();
            cuentasCobrar_dtg.DataSource = dt;
            //cuentasCobrar_dtg.Columns[0].Visible = false;
            cuentasCobrar_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            cuentasCobrar_dtg.Columns[3].DefaultCellStyle.Format = "N2";
           

            

        }

        public void CalcularTotal()
        {
           
            double pendienteRD = 0;
            double pendienteUSD = 0;
            if (cuentasCobrar_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in cuentasCobrar_dtg.Rows)
                {
                    pendienteRD += Convert.ToDouble(row.Cells[6].Value);
                    pendienteUSD += Convert.ToDouble(row.Cells[7].Value);
                    


                }
                restante_RD_lbl.Text = (pendienteRD).ToString("N2");
                restante_USD_lbl.Text = (pendienteUSD).ToString("N2");

                


            }
            else
            {
                restante_RD_lbl.Text = "0.00";
                restante_USD_lbl.Text = "0.00";

            }

           

        }

        private void verDetalles_btn_Click(object sender, EventArgs e)
        {
            if (cuentasCobrar_dtg.Rows.Count > 0)
            {
                Program.GidCC = Convert.ToInt32(cuentasCobrar_dtg.CurrentRow.Cells[9].Value);
                Program.Gtransaccion = cuentasCobrar_dtg.CurrentRow.Cells[2].Value.ToString();
                Program.GidVehiculo = Convert.ToInt32(cuentasCobrar_dtg.CurrentRow.Cells[0].Value);
                CobrosCuentasCobrarForm frm = new CobrosCuentasCobrarForm();
                frm.ShowDialog();
                LlenarDtgCuentasCobrar();
                CalcularTotal();
            }
        }

        private void desde_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (hasta_dtp.Value > DateTime.Now.Date)
            {
                hasta_dtp.Value = DateTime.Now.Date;
            }
            LlenarDtgCuentasCobrar();
        }

        private void cliente_txt_TextChanged(object sender, EventArgs e)
        {
            LlenarDtgCuentasCobrar();
            CalcularTotal();
        }

        private void cuentasCobrar_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cuentasCobrar_dtg.Rows.Count > 0)
            {
                Program.GidCC = Convert.ToInt32(cuentasCobrar_dtg.CurrentRow.Cells[9].Value);
                Program.Gtransaccion = cuentasCobrar_dtg.CurrentRow.Cells[2].Value.ToString();
                Program.GidVehiculo = Convert.ToInt32(cuentasCobrar_dtg.CurrentRow.Cells[0].Value);
                CobrosCuentasCobrarForm frm = new CobrosCuentasCobrarForm();
                frm.ShowDialog();
                LlenarDtgCuentasCobrar();
                CalcularTotal();
            }
        }

        private void CuentasCobrarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.OpenForms["ProcesosForm"].WindowState = FormWindowState.Normal;
                Application.OpenForms["ProcesosForm"].BringToFront();
            }
            catch
            {

            }
            
        }
    }
}
