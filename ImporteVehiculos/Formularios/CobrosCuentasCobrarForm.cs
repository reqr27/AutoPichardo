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
    public partial class CobrosCuentasCobrarForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        int idVehiculo = Program.GidVehiculo;
        string transaccion = Program.Gtransaccion;
        int idCC = Program.GidCC;
        int idTransaccion;
        public int idCliente = 0;
        
         public CobrosCuentasCobrarForm()
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CobrosCuentasCobrarForm_Load(object sender, EventArgs e)
        {
            if (Program.GnuevaCC) // cuenta nueva
            {
                if (transaccion == "VENTA")
                {
                    idTransaccion = 1;
                    traspasoImg_btn.Visible = false;
                }
                else if (transaccion == "TRASPASO")
                {
                    idTransaccion = 3;
                }

                else if (transaccion == "SEGURO")
                {
                    idTransaccion = 4;
                    traspasoImg_btn.Visible = false;

                }



                ObtenerDetalleCuentaCobrar();
                LlenarDtgDetallesVenta();

            }
            else // Cuenta antigua
            {
                detalleVenta_dtg.Visible = false;
                label19.Visible = false;
                label21.Visible = false;
                precioVentaRD_lbl.Visible = false;
                precioVentaUSD_lbl.Visible = false;
                if (transaccion == "VENTA")
                {
                    idTransaccion = 1;
                    traspasoImg_btn.Visible = false;
                }
                else if (transaccion == "TRASPASO")
                {
                    idTransaccion = 3;
                    traspasoImg_btn.Visible = false;
                }

                else if (transaccion == "SEGURO")
                {
                    idTransaccion = 4;
                    traspasoImg_btn.Visible = false;

                }
                ObtenerDetalleCuentaCobrarAntigua();

            }

            cc_lbl.Text = "# CC: " + idCC.ToString("0000000");
            LLenarTipoPagoCb();
            LlenarDtgCobrosCredito();
            CalcularTotales();

            Permisos();
            guardar_btn.NotifyDefault(false);
            pago_txt.Focus();

        }

        public void clearFields()
        {
            pago_txt.Text = "";
            nota_txt.Text = "";
            pago_txt.Focus();
        }

        public void ObtenerDetalleCuentaCobrarAntigua()
        {
            DataTable dt = new DataTable();

            P.Id = idCC;
            dt = P.ObtenerDetallesCuentaCobrarAntigua();
            notaVenta_txt.Text = dt.Rows[0]["NOTA"].ToString();
            idCliente = Convert.ToInt32(dt.Rows[0]["IDCLIENTE"].ToString());
            vehiculo_lbl.Text = dt.Rows[0]["VEHICULO"].ToString();
            chasis_lbl.Text = dt.Rows[0]["CHASIS"].ToString();
            fechaCompra_lbl.Text = dt.Rows[0]["FECHA"].ToString();
            cedula_lbl.Text = dt.Rows[0]["CEDULA"].ToString();
            cliente_lbl.Text = dt.Rows[0]["CLIENTE"].ToString();
            dias_lbl.Text = dt.Rows[0]["DIAS VIGENTE"].ToString();
            if (transaccion == "VENTA")
            {

                transaccion_lbl.Text = "VENTA";
                //precioVentaRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
                //precioVentaUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");

            }
            else if (transaccion == "TRASPASO")
            {

                transaccion_lbl.Text = "TRASPASO";
                //precioVentaRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO TRASPASO RD"])).ToString("#,###.00");
                //precioVentaUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO TRASPASO USD"])).ToString("#,###.00");

            }

            else if (transaccion == "SEGURO")
            {
                transaccion_lbl.Text = "SEGURO";
                label19.Visible = true;
                label21.Visible = true;
                label19.Text = dt.Rows[0]["SEGURO"].ToString();
                label21.Text = "Duración(dias): " + dt.Rows[0]["DURACION"].ToString();
                //precioVentaRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO SEGURO RD"])).ToString("#,###.00");
                //precioVentaUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO SEGURO USD"])).ToString("#,###.00");

            }

            direccion_lbl.Text = dt.Rows[0]["DIRECCION"].ToString();
            telefono_lbl.Text = dt.Rows[0]["TEL"].ToString();

            creditoRd_lbl.Text = Convert.ToDouble(dt.Rows[0]["CREDITO RD"]).ToString("N2");
            creditoUSD_lbl.Text = Convert.ToDouble(dt.Rows[0]["CREDITO USD"]).ToString("N2");

            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");

        }

        public void ObtenerDetalleCuentaCobrar()
        {
            DataTable dt = new DataTable();

            P.Id = idVehiculo;
            dt = P.ObtenerDetallesCuentaCobrar();
            idCliente = Convert.ToInt32(dt.Rows[0]["IDCLIENTE"].ToString());
            vehiculo_lbl.Text = dt.Rows[0]["VEHICULO"].ToString();
            chasis_lbl.Text = dt.Rows[0]["CHASIS"].ToString();
            fechaCompra_lbl.Text = dt.Rows[0]["FECHA VENTA"].ToString();
            cedula_lbl.Text = dt.Rows[0]["CEDULA"].ToString();
            cliente_lbl.Text = dt.Rows[0]["CLIENTE"].ToString();
            dias_lbl.Text = dt.Rows[0]["DIAS VIGENTE"].ToString();
            if(transaccion == "VENTA")
            {
                
                transaccion_lbl.Text = "VENTA";
                precioVentaRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
                precioVentaUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");

            }
            else if (transaccion == "TRASPASO")
            {
                
                transaccion_lbl.Text = "TRASPASO";
                precioVentaRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO TRASPASO RD"])).ToString("#,###.00");
                precioVentaUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO TRASPASO USD"])).ToString("#,###.00");

            }

            else if (transaccion == "SEGURO")
            {
                transaccion_lbl.Text = "SEGURO";
                precioVentaRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO SEGURO RD"])).ToString("#,###.00");
                precioVentaUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO SEGURO USD"])).ToString("#,###.00");

            }

            direccion_lbl.Text = dt.Rows[0]["DIRECCION"].ToString();
            telefono_lbl.Text = dt.Rows[0]["TEL"].ToString();

            P.Id = idCC;
            dt = P.ObtenerTotalCobrarCredito();
            creditoRd_lbl.Text = Convert.ToDouble(dt.Rows[0]["CREDITO RD"]).ToString("N2");
            creditoUSD_lbl.Text = Convert.ToDouble(dt.Rows[0]["CREDITO USD"]).ToString("N2");

            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");

        }
        public void LLenarTipoPagoCb()
        {
            tipoPago_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTiposPagosSinCredito();
            tipoPago_cb.DataSource = dt;
            tipoPago_cb.DisplayMember = "TIPOPAGO";
            tipoPago_cb.ValueMember = "ID";
            tipoPago_cb.SelectedIndex = 0;



        }

        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }
        }
        public void LlenarDtgDetallesVenta()
        {
            DataTable dt = new DataTable();
            detalleVenta_dtg.DataSource = null;
            P.IdVehiculo = idVehiculo;
            P.Id = idTransaccion;
            dt = P.ObtenerCobrosVehiculo();
            detalleVenta_dtg.DataSource = dt;
            detalleVenta_dtg.Columns[0].Visible = false;
            detalleVenta_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            detalleVenta_dtg.Columns[3].DefaultCellStyle.Format = "N2";
            //detalleCompra_dtg.Enabled = false;

        }

        public void LlenarDtgCobrosCredito()
        {
            DataTable dt = new DataTable();
            pagos_dtg.DataSource = null;
            P.Id = idCC;
            dt = P.ObtenerCobrosCreditoVehiculo();
            pagos_dtg.DataSource = dt;
            pagos_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            pagos_dtg.Columns[3].DefaultCellStyle.Format = "N2";


        }

        public void CalcularTotales()
        {

            double totalPagadoRD = 0;
            double totalPagadoUSD = 0;

            if (pagos_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in pagos_dtg.Rows)
                {
                    totalPagadoRD += Convert.ToDouble(row.Cells[2].Value);
                    totalPagadoUSD += Convert.ToDouble(row.Cells[3].Value);

                }
                totalRD_lbl.Text = totalPagadoRD.ToString("N2");
                totalUSD_lbl.Text = totalPagadoUSD.ToString("N2");
            }
            else
            {
                totalRD_lbl.Text = "0.00";
                totalUSD_lbl.Text = "0.00";
            }

            restante_RD_lbl.Text = (Convert.ToDouble(creditoRd_lbl.Text) - Convert.ToDouble(totalRD_lbl.Text)).ToString("N2");
            restante_USD_lbl.Text = (Convert.ToDouble(creditoUSD_lbl.Text) - Convert.ToDouble(totalUSD_lbl.Text)).ToString("N2");
            if (Convert.ToDouble(restante_RD_lbl.Text) <= 0 || Convert.ToDouble(restante_USD_lbl.Text) <= 0)
            {
                guardar_btn.Enabled = false;
            }
        }

        public void AgregarPagos()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            string[] valores = { tipoPago_cb.Text };
            string[] numeros = { pago_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Seleccione Tipo de Pago", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Campo Pago solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (validarPago())
                {
                    P.Id = idCC;
                    P.IdVehiculo = idVehiculo;
                    P.Descripcion = nota_txt.Text.ToString();
                    P.Fecha = fecha_dtp.Value;
                    P.IdTipoPago = Convert.ToInt32(tipoPago_cb.SelectedValue);
                    if (rdDinero_radiobtn.Checked)
                    {
                        P.PrecioRD = Convert.ToDouble(pago_txt.Text);
                        P.PrecioUSD = Convert.ToDouble(pago_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    }
                    else
                    {
                        P.PrecioUSD = Convert.ToDouble(pago_txt.Text);
                        P.PrecioRD = Convert.ToDouble(pago_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    }
                    string respuesta = P.RegistrarPagoCreditoCuentaCobrar();
                    if (respuesta == "1")
                    {
                        MessageBox.Show("Pago Agregado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        LlenarDtgCobrosCredito();
                        CalcularTotales();

                        GenerarRecibo();
                        
         
                    }

                    else
                    {
                        MessageBox.Show("Pago no pudo ser agregado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Pago a realizar sobrepasa el total pendiente!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        public void GenerarRecibo()
        {
            if(transaccion == "VENTA")
            {
                Program.GnumeroRecibo = 0;
                Program.GtipoRecibo = "Recibo";
                Program.Greporte = "Recibo de Pago";
                Program.GidVehiculoRpt = idVehiculo;
                Program.GidCCRpt = idCC;
            }

            else if (transaccion == "TRASPASO")
            {
                Program.GnumeroRecibo = 0;
                Program.GtipoRecibo = "Recibo";
                Program.Greporte = "Recibo de Pago Traspaso";
                Program.GidVehiculoRpt = idVehiculo;
                Program.GidCCRpt = idCC;
            }

            else if (transaccion == "SEGURO")
            {
                Program.GnumeroRecibo = 0;
                Program.GtipoRecibo = "Recibo";
                Program.Greporte = "Recibo de Pago Seguro";
                Program.GidVehiculoRpt = idVehiculo;
                Program.GidCCRpt = idCC;
            }


            ReportesForm form1 = new ReportesForm();
            form1.Show();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AgregarPagos();
            }
        }

        private void tasa_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DolaresForm form = new DolaresForm();
            form.ShowDialog();
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = "";
            tasa_lbl.Text = "1.00 $USD = " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2") + "$RD";
        }

        private void pago_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(pago_txt.Text);



            }
            catch
            {

                if (pago_txt.Text.Length > 1)
                {
                    pago_txt.Text = pago_txt.Text.Remove(pago_txt.Text.Length - 1);
                    pago_txt.SelectionStart = pago_txt.Text.Length;
                }
                else
                {
                    pago_txt.Text = "";
                }

            }
        }

        private void fecha_dtp_ValueChanged(object sender, EventArgs e)
        {
            if(fecha_dtp.Value > DateTime.Now.Date)
            {
                fecha_dtp.Value = DateTime.Now.Date;
            }
        }

        public bool validarPago()
        {
            bool result = true;
            if (rdDinero_radiobtn.Checked)
            {
                if(Convert.ToDouble(pago_txt.Text) > Convert.ToDouble(restante_RD_lbl.Text))
                {
                    result = false ;
                }
                
            }
            else
            {
                if (Convert.ToDouble(pago_txt.Text) > Convert.ToDouble(restante_USD_lbl.Text))
                {
                    result = false;
                }
            }
            return result;

        }

        private void traspasoImg_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Gventana = "TRASPASO";
            Program.Gid = idCliente;
            Program.GidVehiculo = idVehiculo;
            MostrarImagenForm frm = new MostrarImagenForm();
            frm.Show();

        }

        private void clienteImg_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.Gventana = "CLIENTE";
            Program.Gid = idCliente;
            Program.GidVehiculo = idVehiculo;
            MostrarImagenForm frm = new MostrarImagenForm();
            frm.Show();
        }
    }
}
