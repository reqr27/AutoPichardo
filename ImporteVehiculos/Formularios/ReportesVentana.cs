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
    public partial class ReportesVentana : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        public ReportesVentana()
        {
            InitializeComponent();
        }

        public void LLenarPropietarioCb()
        {
            propietario_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerPropietarios();
            propietario_cb.DataSource = dt;
            propietario_cb.DisplayMember = "PROPIETARIO";
            propietario_cb.ValueMember = "ID";
            propietario_cb.SelectedIndex = -1;


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

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            LlenarDtg();
            UpdateButtons();
        }

        private void ReportesVentana_Load(object sender, EventArgs e)
        {
            desde_dtp.Value = DateTime.Now.AddMonths(-1);
            LLenarPropietarioCb();
            LlenarTipoTransaccionCB();
            estado_cb.SelectedIndex = 0;
            LlenarDtg();
            UpdateButtons();
        }
        public void UpdateButtons()
        {
            if(vehiculos_dtg.Rows.Count > 0)
            {
                repGeneral_btn.Enabled = true;
                repIndividual_btn.Enabled = true;

            }
            else
            {
                repGeneral_btn.Enabled = false;
                repIndividual_btn.Enabled = false;
            }
        }

        public void LlenarDtg()
        {
            DataTable dt = new DataTable();
            vehiculos_dtg.DataSource = null;
            P.Desde = Convert.ToDateTime(desde_dtp.Value);
            P.Hasta = Convert.ToDateTime(hasta_dtp.Value);

            if(reportes_cb.Text == "Vehículos Comprados")
            {
                dt = P.ObtenerDatosReporteVehículosComprados();
                vehiculos_dtg.DataSource = dt;
                vehiculos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "N2";
            }
            else if (reportes_cb.Text == "Vehículos Inventario")
            {
                dt = P.ObtenerDatosReporteVehículosInventario();
                vehiculos_dtg.DataSource = dt;
                vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[6].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[6].DefaultCellStyle.Format = "N2";
            }

            else if (reportes_cb.Text == "Vehículos Vendidos")
            {
                dt = P.ObtenerDatosReporteVehículosVendidos();
                vehiculos_dtg.DataSource = dt;
                vehiculos_dtg.Columns[2].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
            }
            else if(reportes_cb.Text == "Historial Facturas")
            {
                P.Desde = Convert.ToDateTime(desde_dtp.Value);
                P.Hasta = Convert.ToDateTime(hasta_dtp.Value);
                dt = P.ObtenerFacturas();
                vehiculos_dtg.DataSource = dt;
                //facturas_dtg.Columns[0].Visible = false;
                vehiculos_dtg.Columns[1].DefaultCellStyle.Format = "D7";
                vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[6].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[7].DefaultCellStyle.Format = "N2";
            }

            else if (reportes_cb.Text == "Cuentas por Pagar")
            {
                P.IdTransaccion = Convert.ToInt32(tipoTransaccion_cb.SelectedValue);
                P.Desde = Convert.ToDateTime(desde_dtp.Value);
                P.Hasta = Convert.ToDateTime(hasta_dtp.Value);
                P.Propietario = "";
                
                dt = P.ObtenerCuentasPorPagar();
                vehiculos_dtg.DataSource = dt;
                //facturas_dtg.Columns[0].Visible = false;
                vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[6].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[7].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[8].DefaultCellStyle.Format = "N2";
            }

            else if (reportes_cb.Text == "Cuentas por Cobrar")
            {
                //P.Desde = Convert.ToDateTime(desde_dtp.Value);
                //P.Hasta = Convert.ToDateTime(hasta_dtp.Value);
                P.Cliente = "";
                dt = P.ObtenerCuentasPorCobrar();
                vehiculos_dtg.DataSource = dt;
                //facturas_dtg.Columns[0].Visible = false;
                vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[6].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[7].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[8].DefaultCellStyle.Format = "N2";
            }

            else if (reportes_cb.Text == "Reporte Resultados")
            {
                if (rdDinero_radiobtn.Checked)
                {
                    dt = P.ObtenerDatosReporteResultadoRD();
                    vehiculos_dtg.DataSource = dt;
                }
                else
                {
                    dt = P.ObtenerDatosReporteResultadoUSD();
                    vehiculos_dtg.DataSource = dt;
                }
                
                //vehiculos_dtg.Columns[2].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "N2";
                //vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
            }

            else if (reportes_cb.Text == "Reporte de Efectivo")
            {
                //P.Desde = Convert.ToDateTime(desde_dtp.Value);
                //P.Hasta = Convert.ToDateTime(hasta_dtp.Value);
                P.Cliente = "";
                dt = P.ObtenerEfectivoCobrado();
                vehiculos_dtg.DataSource = dt;
                //facturas_dtg.Columns[0].Visible = false;
                vehiculos_dtg.Columns[2].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                
            }

            else if (reportes_cb.Text == "Historial Recibos Cobros")
            {
                //P.Desde = Convert.ToDateTime(desde_dtp.Value);
                //P.Hasta = Convert.ToDateTime(hasta_dtp.Value);
                P.Cliente = "";
                dt = P.ObtenerRecibosCobros();
                vehiculos_dtg.DataSource = dt;
                vehiculos_dtg.Columns[1].DefaultCellStyle.Format = "D7";
                vehiculos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "N2";
                vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "D7";

            }

            //if (propietario_cb.SelectedIndex == -1)
            //{
            //    P.Id = 0;
            //}
            //else
            //{
            //    P.Id = Convert.ToInt32(propietario_cb.SelectedValue);
            //}



            //if (estado_cb.SelectedIndex == 0)
            //{

            //    dt = P.ObtenerDatosReporteProceso();
            //    vehiculos_dtg.DataSource = dt;
            //    vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";

            //}

            //else if (estado_cb.SelectedIndex == 1)
            //{

            //    dt = P.ObtenerDatosReporteTerminado();
            //    vehiculos_dtg.DataSource = dt;
            //}

            //else 
            //{

            //    dt = P.ObtenerDatosReporteVendido();
            //    vehiculos_dtg.DataSource = dt;
            //    vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
            //}

        }

        private void repGeneral_btn_Click(object sender, EventArgs e)
        {
            Program.Gdesde = desde_dtp.Value;
            Program.Ghasta = hasta_dtp.Value;
            Program.Gpropietario = propietario_cb.Text;
            if (propietario_cb.SelectedIndex == -1)
            {
                Program.GidPropietario = 0;
            }
            else
            {
                Program.GidPropietario = Convert.ToInt32(propietario_cb.SelectedValue);
            }

            if (estado_cb.SelectedIndex == 0)
            {
                Program.Greporte = "general proceso";
               
            }

            else if (estado_cb.SelectedIndex == 1)
            {
                Program.Greporte = "general terminados";
               
            }
            else
            {
                Program.Greporte = "general vendidos";
            }

            ReportesForm form = new ReportesForm();
            form.Show();
        }

        private void repIndividual_btn_Click(object sender, EventArgs e)
        {
            Program.GidVehiculoRpt = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value.ToString());
            if (estado_cb.SelectedIndex == 0)
            {
                Program.Greporte = "En Proceso";

            }

            else if (estado_cb.SelectedIndex == 1)
            {
                Program.Greporte = "Terminado";

            }
            else
            {
                Program.Greporte = "Vendido";
            }
            
            ReportesForm form = new ReportesForm();
            form.Show();
        }

        private void estado_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            repGeneral_btn.Enabled = false;
            repIndividual_btn.Enabled = false;
        }

        private void propietario_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            repGeneral_btn.Enabled = false;
            repIndividual_btn.Enabled = false;
        }

        private void desde_dtp_ValueChanged(object sender, EventArgs e)
        {
            
            repGeneral_btn.Enabled = false;
            repIndividual_btn.Enabled = false;
            LlenarDtg();
        }

        private void hasta_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (hasta_dtp.Value > DateTime.Now.Date)
            {
                hasta_dtp.Value = DateTime.Now.Date;
            }
            LlenarDtg();
            repGeneral_btn.Enabled = false;
            repIndividual_btn.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void reset_btn_Click(object sender, EventArgs e)
        {
            propietario_cb.SelectedIndex = -1;
            LlenarDtg();
        }

        private void reporte_btn_Click(object sender, EventArgs e)
        {
            Program.Gdesde = desde_dtp.Value;
            Program.Ghasta = hasta_dtp.Value;

            if(reportes_cb.Text == "Vehículos Comprados")
            {
                Program.Greporte = "Reporte Vehículos Comprados";
                ReportesForm form1 = new ReportesForm();
                form1.Show();
            }

            else if (reportes_cb.Text == "Vehículos Inventario")
            {
                Program.Greporte = "Reporte Vehículos en Inventario";
                ReportesForm form1 = new ReportesForm();
                form1.Show();
            }

            else if (reportes_cb.Text == "Vehículos Vendidos")
            {
                Program.Greporte = "Reporte Vehículos Vendidos";
                ReportesForm form1 = new ReportesForm();
                form1.Show();
            }

            else if (reportes_cb.Text == "Historial Facturas")
            {
                if(vehiculos_dtg.Rows.Count > 0)
                {
                    Program.GidVehiculoRpt = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value);
                    Program.Greporte = "Factura Venta Vehículo";
                    ReportesForm form1 = new ReportesForm();
                    form1.Show();
                }
                
            }

            else if (reportes_cb.Text == "Cuentas por Pagar")
            {
                if (vehiculos_dtg.Rows.Count > 0)
                {
                    Program.GidTransaccionRpt = Convert.ToInt32(tipoTransaccion_cb.SelectedValue);
                    Program.Greporte = "Cuentas por Pagar";
                    ReportesForm form1 = new ReportesForm();
                    form1.Show();
                }

            }

            else if (reportes_cb.Text == "Cuentas por Cobrar")
            {
                if (vehiculos_dtg.Rows.Count > 0)
                {

                    Program.Greporte = "Cuentas por Cobrar";
                    ReportesForm form1 = new ReportesForm();
                    form1.Show();
                }

            }

            else if (reportes_cb.Text == "Reporte Resultados")
            {
                if (vehiculos_dtg.Rows.Count > 0)
                {
                    if (rdDinero_radiobtn.Checked)
                    {
                        Program.Greporte = "Reporte de Resultados ($RD)";
                    }
                    else
                    {
                        Program.Greporte = "Reporte de Resultados ($USD)";
                    }
                   
                    ReportesForm form1 = new ReportesForm();
                    form1.Show();
                }   

            }

            else if (reportes_cb.Text == "Reporte de Efectivo")
            {
                if (vehiculos_dtg.Rows.Count > 0)
                {

                    Program.Greporte = "Reporte Efectivo Cobrado";
                    ReportesForm form1 = new ReportesForm();
                    form1.Show();
                }

            }

            else if (reportes_cb.Text == "Historial Recibos Cobros")
            {
                if (vehiculos_dtg.Rows.Count > 0)
                {
                    Program.GidCCRpt = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[5].Value);
                    Program.GidVehiculoRpt = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value);
                    Program.Greporte = "Recibo de Pago";
                    Program.GtipoRecibo = "Historial Recibo";
                    Program.GnumeroRecibo = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[1].Value);
                    ReportesForm form1 = new ReportesForm();
                    form1.Show();
                }

            }

        }

        private void reportes_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDtg();
            filtrosReporte();
        }

        public void filtrosReporte()
        {
            if(reportes_cb.Text =="Reporte Resultados")
            {
                rdDinero_radiobtn.Visible = true;
                usdDinero_radiobtn.Visible = true;
            }
            else
            {
                rdDinero_radiobtn.Visible = false;
                usdDinero_radiobtn.Visible = false;
            }

            if (reportes_cb.Text == "Cuentas por Pagar")
            {
               label6.Visible = true;
               tipoTransaccion_cb.Visible = true;
            }
            else
            {
                label6.Visible = false;
                tipoTransaccion_cb.Visible = false;
            }


        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void rdDinero_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            LlenarDtg();
        }

        private void tipoTransaccion_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDtg();
            filtrosReporte();
        }

        private void ReportesVentana_FormClosed(object sender, FormClosedEventArgs e)
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
