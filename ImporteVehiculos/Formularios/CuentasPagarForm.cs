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
    public partial class CuentasPagarForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();

        public CuentasPagarForm()
        {
            InitializeComponent();
        }

        private void CuentasPagarForm_Load(object sender, EventArgs e)
        {
            verDetalles_btn.NotifyDefault(false);
            LlenarTipoTransaccionCB();
            desde_dtp.Value = DateTime.Now.AddMonths(-1);
            LlenarDtgCuentasPagar();
            CalcularTotal();
            propietario_txt.Focus();
        }

        public void LlenarTipoTransaccionCB()
        {
            tipoTransaccion_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTipoTransaccionCP();
            tipoTransaccion_cb.DataSource = dt;
            tipoTransaccion_cb.DisplayMember = "TRANSACCION";
            tipoTransaccion_cb.ValueMember = "ID";
            tipoTransaccion_cb.SelectedIndex = 0;
        }
        public void LlenarDtgCuentasPagar()
        {
            DataTable dt = new DataTable();
           
            P.Propietario = propietario_txt.Text;
            P.Desde = desde_dtp.Value;
            P.Hasta = hasta_dtp.Value;
            P.IdTransaccion = Convert.ToInt32(tipoTransaccion_cb.SelectedValue);
            dt = P.ObtenerCuentasPorPagar();
            cuentasPagar_dtg.DataSource = dt;
            //cuentasPagar_dtg.Columns[0].Visible = false;
            if(dt.Rows.Count > 0)
            {
                cuentasPagar_dtg.Columns[7].DefaultCellStyle.Format = "N2";
                cuentasPagar_dtg.Columns[8].DefaultCellStyle.Format = "N2";
            }
            
            

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void propietario_txt_TextChanged(object sender, EventArgs e)
        {
            LlenarDtgCuentasPagar();
            CalcularTotal();
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            LlenarDtgCuentasPagar();
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            double pendienteRD = 0;
            double pendienteUSD = 0;
            if (cuentasPagar_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in cuentasPagar_dtg.Rows)
                {
                    pendienteRD += Convert.ToDouble(row.Cells[7].Value);
                    pendienteUSD += Convert.ToDouble(row.Cells[8].Value);



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
            if(cuentasPagar_dtg.Rows.Count > 0)
            {
                Program.GidCP = Convert.ToInt32(cuentasPagar_dtg.CurrentRow.Cells[10].Value);
                Program.Gtransaccion = cuentasPagar_dtg.CurrentRow.Cells[2].Value.ToString();
                Program.GidVehiculo = Convert.ToInt32(cuentasPagar_dtg.CurrentRow.Cells[0].Value);
                Program.GnumeroFactura = cuentasPagar_dtg.CurrentRow.Cells[3].Value.ToString();
                PagosCuentasPagarForm frm = new PagosCuentasPagarForm();
                frm.ShowDialog();
                LlenarDtgCuentasPagar();
                CalcularTotal();
            }
            
        }

        private void cuentasPagar_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cuentasPagar_dtg.Rows.Count > 0)
            {
                Program.GidCP = Convert.ToInt32(cuentasPagar_dtg.CurrentRow.Cells[10].Value);
                Program.Gtransaccion = cuentasPagar_dtg.CurrentRow.Cells[2].Value.ToString();
                Program.GidVehiculo = Convert.ToInt32(cuentasPagar_dtg.CurrentRow.Cells[0].Value);
                Program.GnumeroFactura = cuentasPagar_dtg.CurrentRow.Cells[3].Value.ToString();
                PagosCuentasPagarForm frm = new PagosCuentasPagarForm();
                frm.ShowDialog();
                LlenarDtgCuentasPagar();
                CalcularTotal();
            }
        }

        private void hasta_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (hasta_dtp.Value > DateTime.Now.Date)
            {
                hasta_dtp.Value = DateTime.Now.Date;
            }
            LlenarDtgCuentasPagar();
        }

        private void tipoTransaccion_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDtgCuentasPagar();
            CalcularTotal();
        }

        private void CuentasPagarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.OpenForms["ProcesosForm"].WindowState = FormWindowState.Normal;
                Application.OpenForms["ProcesosForm"].BringToFront();
            }
            catch (Exception)
            {

                
            }

            
        }
    }
}
