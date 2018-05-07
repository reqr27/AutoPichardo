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
    public partial class AgregarComponentesGastosVehiculoForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        double precioRD;
        double precioUSD;
        int idTransaccion;
        bool ComboFill = false;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public AgregarComponentesGastosVehiculoForm()
        {
            InitializeComponent();
        }

        private void AgregarComponentesGastosVehiculoForm_Load(object sender, EventArgs e)
        {
            precioRd_lbl.Text = precioRD.ToString("N2");
            precioUsd_lbl.Text = precioUSD.ToString("N2");
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            FieldStatus(false);
            LLenarVehiculoCB();
            CalcularTotal();
            CalcularTotalServicios();
            LlenarTallerCb();
            LLenarTipoPagoCb();
            LlenarGastosReparacionCb();
            //CargarVentana();
            Permisos();
            idTransaccion = 6;
            vehiculos_cb.Focus();
            guardar_btn.NotifyDefault(false);
        }

        public void clearFields()
        {

            tipoPago_cb.SelectedIndex = 0;
            notaPago_txt.Text = "";
            precioRd_lbl.Text = "0.00";
            precioUsd_lbl.Text = "0.00";
            pagos_dtg.Rows.Clear();
            restante_RD_lbl.Text = "0.00";
            restante_USD_lbl.Text = "0.00";
            totalRD_lbl.Text = "0.00";
            totalUSD_lbl.Text = "0.00";
            servicios_dtg.Rows.Clear();
            servicioTotalRD_lbl.Text = "0.00";
            servicioTotalUSD_lbl.Text = "0.00";
            precio_txt.Text = "";
            numeroFactura_txt.Text = "";
            nota_factura_txt.Text = "";
            montoServicio_txt.Text = "";
            vehiculos_cb.Focus();
        }

        public void LLenarTipoPagoCb()
        {
            tipoPago_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTiposPagosSinVehiculo();
            tipoPago_cb.DataSource = dt;
            tipoPago_cb.DisplayMember = "TIPOPAGO";
            tipoPago_cb.ValueMember = "ID";
            tipoPago_cb.SelectedIndex = 0;


        }

        public void LLenarVehiculoCB()
        {
            vehiculos_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerVehiculosNoFacturados();
            vehiculos_cb.DataSource = dt;
            vehiculos_cb.DisplayMember = "VEHICULO";
            vehiculos_cb.ValueMember = "ID";
           vehiculos_cb.SelectedIndex = -1;

            if(dt.Rows.Count == 0)
            {
                mantenimiento_radiobtn.Enabled = false;
                piezas_radiobtn.Enabled = false;
                otros_radiobtn.Enabled = false;

                agregarServicio_btn.Enabled = false;
            }


        }

        public void CargarVentana()
        {
            if (Program.Gventana == "componentes")
            {
                nombreForm_lbl.Text = "PIEZAS Y REPUESTOS";
                idTransaccion = 5;
                //taller_cb.Visible = true;
                //taller_lbl.Visible = true;
                //descripcion_lbl.Text = "PIEZAS Y REPUESTOS";
                LlenarComponenteCb();
            }
            else if (Program.Gventana == "reparacion")
            {
                idTransaccion = 6;
                //descripcion_lbl.Text = "GASTOS REPARACION:";
                //nombreForm_lbl.Text = "GASTOS REPARACION";
                LlenarGastosReparacionCb();
                //taller_cb.Visible = true;
                //taller_lbl.Visible = true;
                //agregarTaller_lnklbl.Visible = true;

            }

            else
            {

                //idTransaccion = 7;
                //descripcion_lbl.Text = "OTROS GASTOS:";
                //nombreForm_lbl.Text = "OTROS GASTOS";
                LlenarGastosAduanalesCb();
            }
        }

        public void LlenarComponenteCb()
        {
            descripcion_cb.DataSource = null;
            DataTable dt = new DataTable();
            P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
            dt = P.ObtenerCompoentesVehiculoFabricanteModeloAño();
            descripcion_cb.DataSource = dt;
            descripcion_cb.DisplayMember = "COMPONENTES";
            descripcion_cb.ValueMember = "ID";
            descripcion_cb.SelectedIndex = -1;
            ComboFill = true;
        }

        public void LlenarGastosReparacionCb()
        {
            descripcion_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerGastosReparacionActivos();
            descripcion_cb.DataSource = dt;
            descripcion_cb.DisplayMember = "DESCRIPCION";
            descripcion_cb.ValueMember = "ID";
            descripcion_cb.SelectedIndex = -1;

        }

        public void LlenarGastosAduanalesCb()
        {
            descripcion_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerGastosAduanalesActivos();
            descripcion_cb.DataSource = dt;
            descripcion_cb.DisplayMember = "DESCRIPCION";
            descripcion_cb.ValueMember = "ID";
            descripcion_cb.SelectedIndex = -1;

        }

        public void LlenarTallerCb()
        {
            taller_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTalleresActivos();
            taller_cb.DataSource = dt;
            taller_cb.DisplayMember = "TALLER";
            taller_cb.ValueMember = "ID";
            taller_cb.SelectedIndex = -1;

        }

        public void GuardarGastosReparacion()
        {
            string[] valores = { descripcion_cb.Text };
            string[] numeros = { precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);
                P.IdTaller = Convert.ToInt32(taller_cb.SelectedValue);
                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.AsignarGastoReparacionVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Gasto Reparación fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Gasto Reparación ya existe para este vehículo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Gasto Reparación no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void GuardarComponentes()
        {
            string[] valores = { descripcion_cb.Text };
            string[] numeros = { precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);

                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.AsignarComponenteVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Componente fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Componente ya existe para este vehículo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Componente no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void GuardarGastosAduanales()
        {
            string[] valores = { descripcion_cb.Text };
            string[] numeros = { precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);

                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.AsignarGastoAduanalVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Gasto Aduanal fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Gasto Aduanal ya existe para este vehículo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Gasto Aduanal no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pagos_dtg.Rows.Count > 0)
                {

                    if (servicios_dtg.Rows.Count > 0)
                    {
                        if ((Convert.ToDouble(restante_RD_lbl.Text) == 0 || Convert.ToDouble(restante_USD_lbl.Text) == 0))
                        {
                            if(servicioTotalRD_lbl.Text == totalRD_lbl.Text && servicioTotalUSD_lbl.Text == totalUSD_lbl.Text)
                            {
                                AgregarFactura();
                            }
                            else
                            {
                                MessageBox.Show("Total detalles de factura debe ser igual al monto total de la factura", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                        else
                        {
                            MessageBox.Show("Montos restantes deben ser igual a cero", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Agregar Detalles de Factura", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }
                else
                {
                    MessageBox.Show("Agregar Detalles de Pagos Factura", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }
        public void LlenarPrecioTxt()
        {
            if (descripcion_cb.Text != "System.Data.DataRowView" && descripcion_cb.SelectedIndex != -1)
            {

                DataTable dt = new DataTable();
                P.Id = Convert.ToInt32(descripcion_cb.SelectedValue);
                dt = P.ObtenerPrecioCompoenteSeleccionado();
                if (rdDinero_radiobtn.Checked)
                {
                    montoServicio_txt.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
                }
                else
                {
                    montoServicio_txt.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
                }
            }

        }

        private void descripcion_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void rdDinero_radiobtn_CheckedChanged(object sender, EventArgs e)
        {

            if (piezas_radiobtn.Checked && descripcion_cb.SelectedIndex != -1)
            {

                if (ComboFill)
                {
                    LlenarPrecioTxt();
                }
            }
            CalcularPrecio();
        }

        private void tasa_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DolaresForm form = new DolaresForm();
            form.ShowDialog();
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = "";
            tasa_lbl.Text = "1.00 $USD = " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");

        }

        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR TALLER");
            if (!permiso)
            {
                //agregarTaller_lnklbl.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("CREAR GASTOS");
            if (!permiso)
            {
                //nuevo_lnklbl.Enabled = false;
            }
        }

        private void nuevo_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComboFill = false;
            if (Program.Gventana == "componentes")
            {
                PiezasRepuestosForm form = new PiezasRepuestosForm();
                form.ShowDialog();

                LlenarComponenteCb();
            }
            else if (Program.Gventana == "reparacion")
            {
                GastosGeneralesForm form = new GastosGeneralesForm();
                form.ShowDialog();
                LlenarGastosReparacionCb();

            }
            else
            {
                GastosGeneralesForm form = new GastosGeneralesForm();
                form.ShowDialog();
                LlenarGastosAduanalesCb();
            }
        }

        private void agregarTaller_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ComboFill = false;
            TalleresForm form = new TalleresForm();
            form.ShowDialog();
            LlenarTallerCb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void FieldStatus(bool estado)
        {
            if (estado)
            {
                tipoPago_cb.Enabled = true;
                monto_txt.Enabled = true;
                notaPago_txt.Enabled = true;
                agregarPago_btn.Enabled = true;
                //rdDineroTraspaso_radiobtn.Enabled = true;
                //usdDineroTraspaso_radiobtn.Enabled = true;
            }
            else
            {
                tipoPago_cb.Enabled = false;
                monto_txt.Enabled = false;
                notaPago_txt.Enabled = false;
                agregarPago_btn.Enabled = false;
                //rdDineroTraspaso_radiobtn.Enabled = false;
                //usdDineroTraspaso_radiobtn.Enabled = false;
            }
        }



        public void CalcularTotal()
        {
            double totalRD = 0;
            double totalUSD = 0;
            if (pagos_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in pagos_dtg.Rows)
                {
                    totalRD += Convert.ToDouble(row.Cells[1].Value);
                    totalUSD += Convert.ToDouble(row.Cells[2].Value);


                }
                totalRD_lbl.Text = totalRD.ToString("N2");
                totalUSD_lbl.Text = totalUSD.ToString("N2");



            }
            else
            {
                totalRD_lbl.Text = "0.00";
                totalUSD_lbl.Text = "0.00";

            }

            restante_RD_lbl.Text = (precioRD - Convert.ToDouble(totalRD_lbl.Text)).ToString("N2");
            restante_USD_lbl.Text = (precioUSD - Convert.ToDouble(totalUSD_lbl.Text)).ToString("N2");
        }

        public void CalcularPrecio()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            try
            {
                if (rdDinero_radiobtn.Checked)
                {
                    precioRD = Convert.ToDouble(precio_txt.Text);
                    precioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);

                }
                else if (usdDinero_radiobtn.Checked)
                {
                    precioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    precioUSD = Convert.ToDouble(precio_txt.Text);


                }
                precioRd_lbl.Text = precioRD.ToString("N2");
                precioUsd_lbl.Text = precioUSD.ToString("N2");
                CalcularTotal();
            }
            catch
            {

            }

        }



        private void agregarPago_btn_Click(object sender, EventArgs e)
        {
            string[] valores = { tipoPago_cb.Text };
            string[] numeros = { monto_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Seleccione Tipo de Pago", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Campo Monto solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AgregarPagosDtg();
            }
        }

        public void AgregarPagosDtg()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            bool add = true;
            double cantidadAgregar;
            double precioTotal;
            if (rdDinero_radiobtn.Checked)
            {
                cantidadAgregar = Convert.ToDouble(monto_txt.Text);
                double totalAgregado = Convert.ToDouble(totalRD_lbl.Text);
                precioTotal = Convert.ToDouble(precioRd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {

                    foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                        {
                            row1.Cells[1].Value = cantidadAgregar + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {
                        pagos_dtg.Rows.Add();

                        int row = pagos_dtg.Rows.Count;
                        pagos_dtg.Rows[row - 1].Cells[0].Value = tipoPago_cb.Text;
                        pagos_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar;
                        pagos_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        pagos_dtg.Rows[row - 1].Cells[3].Value = notaPago_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;
                    }

                    CalcularTotal();
                    monto_txt.Text = "";
                    notaPago_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del traspaso", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                cantidadAgregar = Convert.ToDouble(monto_txt.Text);
                double totalAgregado = Convert.ToDouble(totalUSD_lbl.Text);
                precioTotal = Convert.ToDouble(precioUsd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {
                    foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                        {
                            row1.Cells[1].Value = (cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {

                        pagos_dtg.Rows.Add();
                        int row = pagos_dtg.Rows.Count;
                        pagos_dtg.Rows[row - 1].Cells[0].Value = tipoPago_cb.Text;
                        pagos_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        pagos_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar;
                        pagos_dtg.Rows[row - 1].Cells[3].Value = notaPago_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;

                    }
                    CalcularTotal();
                    monto_txt.Text = "";
                    notaPago_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del traspaso", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void precio_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(precio_txt.Text);



            }
            catch
            {

                if (precio_txt.Text.Length > 1)
                {
                    precio_txt.Text = precio_txt.Text.Remove(precio_txt.Text.Length - 1);
                    precio_txt.SelectionStart = precio_txt.Text.Length;
                }
                else
                {
                    precio_txt.Text = "";
                }

            }

            if (precio_txt.Text.Length > 0)
            {
                CalcularPrecio();
                FieldStatus(true);
                if (Convert.ToDouble(restante_RD_lbl.Text) < 0 || Convert.ToDouble(restante_USD_lbl.Text) < 0)
                {
                    pagos_dtg.Rows.Clear();
                    CalcularTotal();
                    CalcularPrecio();

                }
            }
            else
            {
                FieldStatus(false);
                precioRd_lbl.Text = "0.00";
                precioUsd_lbl.Text = "0.00";
                pagos_dtg.Rows.Clear();
                restante_RD_lbl.Text = "0.00";
                restante_USD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
                totalUSD_lbl.Text = "0.00";
            }
        }

        private void monto_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(monto_txt.Text);



            }
            catch
            {

                if (monto_txt.Text.Length > 1)
                {
                    monto_txt.Text = monto_txt.Text.Remove(monto_txt.Text.Length - 1);
                    monto_txt.SelectionStart = monto_txt.Text.Length;
                }
                else
                {
                    monto_txt.Text = "";
                }

            }
        }

        private void pagos_dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == pagos_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == pagos_dtg.Columns["dataGridViewButtonColumn1"].Index)
            {
                var image = Properties.Resources.deshabilitado1; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void pagos_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == pagos_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == pagos_dtg.Columns["dataGridViewButtonColumn1"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                pagos_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }

        public bool InsertarFacturaServicios()
        {
            bool result = false;
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();

            P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
            P.Fecha = fecha_dtp.Value;
            P.Nota = nota_factura_txt.Text;
            if (rdDinero_radiobtn.Checked)
            {
                P.MontoRD = Convert.ToDouble(precio_txt.Text);
                P.MontoUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
            }
            else
            {
                P.MontoRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                P.MontoUSD = Convert.ToDouble(precio_txt.Text);
            }
            
            P.NumeroFactura = numeroFactura_txt.Text;
            P.IdSuplidor = Convert.ToInt32(taller_cb.SelectedValue);
            string msj = P.InsertarFacturaServicios();
            if(msj == "1")
            {
                result = true;
            }
            else if (msj == "2")
            {
                MessageBox.Show("Número de factura ya existe para el suplidor elegido", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }


        public bool InsertarDetalle()
        {
            int error = 0;
            bool result = false;
            foreach (DataGridViewRow row in pagos_dtg.Rows)
            {


                P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                P.Fecha = fecha_dtp.Value;
                P.Nota = row.Cells[3].Value.ToString();
                P.IdTipoPago = Convert.ToInt32(row.Cells[5].Value);
                P.MontoRD = Convert.ToDouble(row.Cells[1].Value); // pago rd
                P.MontoUSD = Convert.ToDouble(row.Cells[2].Value); // pago usd
                P.IdTransaccion = idTransaccion;
                P.IdSuplidor = Convert.ToInt32(taller_cb.SelectedValue);


                string respuesta = P.InsertarDetalleTransaccionGastos();

                if (respuesta != "1")
                {
                    error++;
                }
            }

            if (error == 0)
            {
                result = true;
            }

            return result;

        }

        public bool RegistrarGastos()
        {
            int error = 0;
            bool result = false;
            string msj = "";
            foreach (DataGridViewRow row in servicios_dtg.Rows)
            {

                P.Id = Convert.ToInt32(row.Cells[6].Value);
                P.Fecha = fecha_dtp.Value;
                P.IdSuplidor = Convert.ToInt32(taller_cb.SelectedValue);
                P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                P.PrecioRD = Convert.ToDouble(row.Cells[2].Value);
                P.PrecioUSD = Convert.ToDouble(row.Cells[3].Value); 
                P.IdTransaccion = Convert.ToInt32(row.Cells[5].Value);
                P.Cantidad = Convert.ToInt32(row.Cells[0].Value);
                msj = P.InsertarGastosVehiculo();
                if (msj != "1")
                {
                    error++;
                }
            }
            if (error == 0)
            {
                result = true;
            }
            return result;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mantenimiento_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mantenimiento_radiobtn.Checked)
            {
                cantidad_txtNum.Value = 1;
                idTransaccion = 6;
                LlenarGastosReparacionCb();
            }
            else if (piezas_radiobtn.Checked)
            {
                cantidad_txtNum.Value = 1;
                idTransaccion = 5;
                LlenarComponenteCb();
            }
            else
            {
                cantidad_txtNum.Value = 1;
                idTransaccion = 7;
                LlenarGastosAduanalesCb();
            }
        }

        private void vehiculos_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // ELIMINAR PIEZA VEHICULO DEL GRID
        }

        private void descripcion_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (piezas_radiobtn.Checked && descripcion_cb.SelectedIndex != -1)
            {

                if (ComboFill)
                {
                    LlenarPrecioTxt();
                }
            }
        }

        private void agregarServicio_btn_Click(object sender, EventArgs e)
        {
            string[] valores = { descripcion_cb.Text };
            string[] numeros = { montoServicio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Seleccione Servicio o Pieza", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Campo Monto solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AgregarServiciosDtg();
            }
        }

        public void AgregarServiciosDtg()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            bool add = true;
            double cantidadAgregar;
            
            if (rdDinero_radiobtn.Checked)
            {
                cantidadAgregar = Convert.ToDouble(montoServicio_txt.Text);


                foreach (DataGridViewRow row1 in servicios_dtg.Rows)
                {
                    //if (row1.Cells[1].Value.ToString() == tipoPago_cb.Text)
                    //{
                    //    row1.Cells[1].Value = cantidadAgregar + Convert.ToDouble(row1.Cells[1].Value);
                    //    row1.Cells[2].Value = (cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[2].Value);
                    //    add = false;
                    //}


                }
                if (add)
                {
                    servicios_dtg.Rows.Add();

                    int row = servicios_dtg.Rows.Count;
                    servicios_dtg.Rows[row - 1].Cells[0].Value = cantidad_txtNum.Value.ToString();
                    servicios_dtg.Rows[row - 1].Cells[1].Value = descripcion_cb.Text;
                    servicios_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar * Convert.ToDouble(cantidad_txtNum.Value);
                    servicios_dtg.Rows[row - 1].Cells[3].Value = (cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"])) * Convert.ToDouble(cantidad_txtNum.Value);
                    servicios_dtg.Rows[row - 1].Cells[5].Value = idTransaccion.ToString();

                    servicios_dtg.Rows[row - 1].Cells[6].Value = Convert.ToInt32(descripcion_cb.SelectedValue);
                }

                CalcularTotalServicios();
                montoServicio_txt.Text = "";
                cantidad_txtNum.Value = 1; ;



            }
            else
            {
                cantidadAgregar = Convert.ToDouble(monto_txt.Text);

                foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                {
                    //if (row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                    //{
                    //    row1.Cells[1].Value = (cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[1].Value);
                    //    row1.Cells[2].Value = (cantidadAgregar) + Convert.ToDouble(row1.Cells[2].Value);
                    //    add = false;
                    //}


                }
                if (add)
                {
                    //Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    servicios_dtg.Rows.Add();

                    int row = servicios_dtg.Rows.Count;
                    servicios_dtg.Rows[row - 1].Cells[0].Value = cantidad_txtNum.Value.ToString();
                    servicios_dtg.Rows[row - 1].Cells[1].Value = descripcion_cb.Text;
                    servicios_dtg.Rows[row - 1].Cells[2].Value = (cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"])) * Convert.ToDouble(cantidad_txtNum.Value);
                    servicios_dtg.Rows[row - 1].Cells[3].Value = cantidadAgregar * Convert.ToDouble(cantidad_txtNum.Value);
                    servicios_dtg.Rows[row - 1].Cells[5].Value = idTransaccion.ToString();

                    servicios_dtg.Rows[row - 1].Cells[6].Value = Convert.ToInt32(descripcion_cb.SelectedValue);

                }
                CalcularTotalServicios();
                montoServicio_txt.Text = "";
                cantidad_txtNum.Value = 1; ;


            }
        }

        private void servicios_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == servicios_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == servicios_dtg.Columns["dataGridViewButtonColumn2"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                servicios_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotalServicios();
            }
        }

        public void CalcularTotalServicios()
        {
            double totalRD = 0;
            double totalUSD = 0;
            if (servicios_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in servicios_dtg.Rows)
                {
                    totalRD += Convert.ToDouble(row.Cells[2].Value);
                    totalUSD += Convert.ToDouble(row.Cells[3].Value);


                }
                servicioTotalRD_lbl.Text = totalRD.ToString("N2");
                servicioTotalUSD_lbl.Text = totalUSD.ToString("N2");



            }
            else
            {
                servicioTotalRD_lbl.Text = "0.00";
                servicioTotalUSD_lbl.Text = "0.00";

            }


        }

        public void AgregarFactura()
        {
            string[] valores = { taller_cb.Text, vehiculos_cb.Text }; //seguro_cb.Text, seguro_cb.Text 
            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                if (InsertarFacturaServicios())
                {
                    if (InsertarDetalle())
                    {
                        if (RegistrarGastos())
                        {
                            MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Gasto no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Gasto no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("No se pudo insertar Factura!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void vehiculos_cb_DropDown(object sender, EventArgs e)
        {
            LLenarVehiculoCB();
        }

        private void taller_cb_DropDown(object sender, EventArgs e)
        {
            LlenarTallerCb();
        }

        private void descripcion_cb_DropDown(object sender, EventArgs e)
        {
            if (mantenimiento_radiobtn.Checked)
            {
                LlenarGastosReparacionCb();
            }
            else if (piezas_radiobtn.Checked)
            {
                LlenarComponenteCb();
            }
            else
            {
                LlenarGastosAduanalesCb();
            }
        }
    } 
}
