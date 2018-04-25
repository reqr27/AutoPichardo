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
    public partial class PagosCuentasPagarForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        int idVehiculo = Program.GidVehiculo;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();

        int idCP = Program.GidCP;
        string transaccion = Program.Gtransaccion;
        int idTransaccion;
        public PagosCuentasPagarForm()
        {
            InitializeComponent();
        }

        private void PagosForm_Load(object sender, EventArgs e)
        {
            CargarVentana();
            cp_lbl.Text = "# CP: " + idCP.ToString("0000000");
            LLenarTipoPagoCb();
            LlenarDtgPagosCredito();
            ObtenerDetalleCuentaPagar();
            LlenarDtgDetallesCompra();
            CalcularTotales();
            
            Permisos();
            
        }

        public void CargarVentana()
        {
            if (transaccion == "COMPRA")
            {
                idTransaccion = 2;
            }

            else if (transaccion == "SEGURO")
            {
                idTransaccion = 4;
            }

            else if (transaccion == "PIEZAS")
            {
                idTransaccion = 5;
            }

            else if (transaccion == "TALLER MECANICO")
            {
                idTransaccion = 6;
            }
            else //OTROS
            {
                idTransaccion = 7;
            }
        }

        public void clearFields()
        {
            pago_txt.Text = "";
            nota_txt.Text = "";
        }

        public void ObtenerDetalleCuentaPagar()
        {
            if(idTransaccion == 2)//Compras
            {
                Compras();
            }

            else if (idTransaccion == 4)//Seguros
            {
                Seguros();
            }

            else if(idTransaccion == 5)
            {
                Piezas();
            }
            else
            {
                Gastos();
            }



        }

        public void Compras()
        {
            DataTable dt = new DataTable();

            P.Id = idVehiculo;
            P.IdTransaccion = idTransaccion;
            dt = P.ObtenerDetallesCuentaPagar();
            vehiculo_lbl.Text ="Compra de --> " + dt.Rows[0]["VEHICULO"].ToString();
            chasis_lbl.Text = dt.Rows[0]["CHASIS"].ToString();
            fechaCompra_lbl.Text = dt.Rows[0]["FECHA COMPRADO"].ToString();
            cedula_lbl.Text = dt.Rows[0]["CEDULA"].ToString();

            dias_lbl.Text = dt.Rows[0]["DIAS VIGENTE"].ToString();
            telefono_lbl.Text = dt.Rows[0]["TEL"].ToString();
            propietario_lbl.Text = dt.Rows[0]["PROPIETARIO"].ToString();
            suplidor_lbl.Text = "Información Suplidor";

            precioCompraRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            precioCompraUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            creditoRd_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            creditoUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            direccion_lbl.Text = dt.Rows[0]["PAIS"].ToString() + ", " + dt.Rows[0]["CIUDAD"].ToString() +", " + dt.Rows[0]["DIRECCION"].ToString(); 
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");


        }

        public void Seguros()
        {
            DataTable dt = new DataTable();

            P.Id = idVehiculo;
            dt = P.ObtenerDetallesCuentaPagar();
            vehiculo_lbl.Text = "Compra de --> Seguro Para" + dt.Rows[0]["VEHICULO"].ToString();
            chasis_lbl.Text = dt.Rows[0]["CHASIS"].ToString();
            fechaCompra_lbl.Text = dt.Rows[0]["FECHA COMPRADO"].ToString();
            cedula_lbl.Text = dt.Rows[0]["CEDULA"].ToString();

            suplidor_lbl.Text = "Información de la Aseguradora";
            telefono_lbl.Text = dt.Rows[0]["SEGURO TEL"].ToString();
            propietario_lbl.Text = dt.Rows[0]["SEGURO NOMBRE"].ToString();
            label17.Visible = false;
            cedula_lbl.Visible = false;
            label20.Visible = false;
            direccion_lbl.Visible = false;
           
            precioCompraRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO SEGURO RD"])).ToString("#,###.00");
            precioCompraUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO SEGURO USD"])).ToString("#,###.00");

            direccion_lbl.Text = dt.Rows[0]["DIRECCION"].ToString();



            P.Id = idCP;
            dt = P.ObtenerTotalPagarCredito();
            creditoRd_lbl.Text = Convert.ToDouble(dt.Rows[0]["CREDITO RD"]).ToString("N2");
            creditoUSD_lbl.Text = Convert.ToDouble(dt.Rows[0]["CREDITO USD"]).ToString("N2");
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");


        }

        public void Piezas()
        {
            DataTable dt = new DataTable();

            P.Id = idVehiculo;
            P.IdTransaccion = idTransaccion;
            dt = P.ObtenerDetallesCuentaPagar();
            vehiculo_lbl.Text = "Compra de --> " + " " + dt.Rows[0]["PIEZA"].ToString() + " Para " + dt.Rows[0]["VEHICULO"].ToString();
            chasis_lbl.Text = dt.Rows[0]["CHASIS"].ToString();
            fechaCompra_lbl.Text = dt.Rows[0]["FECHA COMPRADO"].ToString();
            //cedula_lbl.Text = dt.Rows[0]["CEDULA"].ToString();
            label17.Visible = false;
            cedula_lbl.Visible = false;
            dias_lbl.Text = dt.Rows[0]["DIAS VIGENTE"].ToString();
            telefono_lbl.Text = dt.Rows[0]["TEL"].ToString();
            propietario_lbl.Text = dt.Rows[0]["PROPIETARIO"].ToString();
            suplidor_lbl.Text = "Información Tienda o Repuesto";

            precioCompraRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            precioCompraUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            creditoRd_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            creditoUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            direccion_lbl.Text =  dt.Rows[0]["DIRECCION"].ToString();
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");


        }

        public void Gastos()
        {
            DataTable dt = new DataTable();

            P.Id = idVehiculo;
            P.IdTransaccion = idTransaccion;
            dt = P.ObtenerDetallesCuentaPagar();
            vehiculo_lbl.Text = dt.Rows[0]["GASTO"].ToString() + " --> " + dt.Rows[0]["VEHICULO"].ToString();
            chasis_lbl.Text = dt.Rows[0]["CHASIS"].ToString();
            fechaCompra_lbl.Text = dt.Rows[0]["FECHA COMPRADO"].ToString();
            //cedula_lbl.Text = dt.Rows[0]["CEDULA"].ToString();
            label17.Visible = false;
            cedula_lbl.Visible = false;
            dias_lbl.Text = dt.Rows[0]["DIAS VIGENTE"].ToString();
            telefono_lbl.Text = dt.Rows[0]["TEL"].ToString();
            propietario_lbl.Text = dt.Rows[0]["PROPIETARIO"].ToString();
            suplidor_lbl.Text = "Información Taller";

            precioCompraRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            precioCompraUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            creditoRd_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            creditoUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            direccion_lbl.Text = dt.Rows[0]["DIRECCION"].ToString();
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
        public void LlenarDtgDetallesCompra()
        {
            DataTable dt = new DataTable();
            detalleCompra_dtg.DataSource = null;
            P.IdVehiculo = idVehiculo;
            P.Id = idTransaccion;
            dt = P.ObtenerPagosVehiculo();
            detalleCompra_dtg.DataSource = dt;
            //detalleCompra_dtg.Columns[0].Visible = false;
            detalleCompra_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            detalleCompra_dtg.Columns[3].DefaultCellStyle.Format = "N2";
            //detalleCompra_dtg.Enabled = false;

        }

        public void LlenarDtgPagosCredito()
        {
            DataTable dt = new DataTable();
            pagos_dtg.DataSource = null;
            P.Id = idCP;
            dt = P.ObtenerPagosCreditoVehiculo();
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
            if(Convert.ToDouble(restante_RD_lbl.Text) <= 0 || Convert.ToDouble(restante_USD_lbl.Text) <= 0)
            {
                guardar_btn.Enabled = false;
            }
        }

        public void AgregarPagos()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();

            string[] valores = { tipoPago_cb.Text};
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
                    P.Id = idCP;
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
                    string respuesta = P.RegistrarPagoCreditoCuentaPagar();
                    if (respuesta == "1")
                    {
                        MessageBox.Show("Pago Agregado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        LlenarDtgPagosCredito();
                        CalcularTotales();



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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            if (fecha_dtp.Value > DateTime.Now.Date)
            {
                fecha_dtp.Value = DateTime.Now.Date;
            }

        }

        public bool validarPago()
        {
            bool result = true;
            if (rdDinero_radiobtn.Checked)
            {
                if (Convert.ToDouble(pago_txt.Text) > Convert.ToDouble(restante_RD_lbl.Text))
                {
                    result = false;
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
    }
}
