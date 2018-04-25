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
using System.Security;
using System.IO;
using System.Text.RegularExpressions;

namespace ImporteVehiculos.Formularios
{
    public partial class VenderForm : Form
    {
        List<String> imgsList = new List<String>();
        int count = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        double precioVentaRD = 0;
        double precioVentaUSD = 0;
        double precioTraspasoRD = 0;
        double precioTraspasoUSD = 0;
        double precioSeguroRD = 0;
        double precioSeguroUSD = 0;
        public VenderForm()
        {
            InitializeComponent();
        }

        public void clearFields()
        {
            
            LLenarVehiculosCb();
            costoRD_txt.Text = "";
            chasis_txt.Text = "";
            precio_txt.Text = "";
            cliente_cb.Text = "";
            pago_txt.Text = "";
            tipoPago_cb.SelectedIndex = 0;
            nota_txt.Text = "";
            precioVentaRd_lbl.Text = "0.00";
            precioVentaUSD_lbl.Text = "0.00";
            pagos_dtg.Rows.Clear();
            restante_RD_lbl.Text = "0.00";
            restante_USD_lbl.Text = "0.00";
            totalRD_lbl.Text = "0.00";
            totalRD_lbl.Text = "0.00";

            precioTraspaso_txt.Text = "";
            montoTraspaso_txt.Text = "";
            notaPagoTraspaso_txt.Text = "";
            tipoPagoTraspaso_cb.SelectedIndex = 0;
            precioTraspasoRd_lbl.Text = "0.00";
            precioTraspasoUsd_lbl.Text = "0.00";
            pagosTraspaso_dtg.Rows.Clear();
            restanteTraspaso_RD_lbl.Text = "0.00";
            restanteTraspaso_USD_lbl.Text = "0.00";
            totalTraspasoRD_lbl.Text = "0.00";
            totalTraspasoRD_lbl.Text = "0.00";

            //precioSeguro_txt.Text = "";
            //montoSeguros_txt.Text = "";
            //notaPagoSeguros_txt.Text = "";
            //tipoPagoSeguros_cb.SelectedIndex = 0;
            //precioSeguroRd_lbl.Text = "0.00";
            //precioSeguroUsd_lbl.Text = "0.00";
            //seguros_dtg.Rows.Clear();
            //restanteSeguro_RD_lbl.Text = "0.00";
            //restanteSeguro_USD_lbl.Text = "0.00";
            //totalSeguroRD_lbl.Text = "0.00";
            //totalSeguroRD_lbl.Text = "0.00";



        }

        private void VenderForm_Load(object sender, EventArgs e)
        {
            notaVenta_txt.MaxLength = 290;
            tabControl1.TabPages.Remove(tabPage4); // esconder tab seguros
           
            duracion_seguro.Maximum = Int32.MaxValue;
            duracion_seguro.Value = 365;
            this.openFileDialog1.Filter =
          "Images (*.BMP;*.JPG;*.GIF;*.png)|*.BMP;*.JPG;*.GIF;*.PNG|" +
          "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Buscar Imágenes";

            FieldStatus(false);
            FieldStatusTraspaso(false);
            FieldStatusSeguro(false);
            CalcularTotal();
            CalcularTotalTraspaso();
            //CalcularTotalSeguros();
            LlenarDtgClientes();
            tipoPago_cb.SelectedIndex = -1;
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            precioVentaRd_lbl.Text = precioVentaRD.ToString("N2");
            precioVentaUSD_lbl.Text = precioVentaUSD.ToString("N2");
            precioTraspasoRd_lbl.Text = precioTraspasoRD.ToString("N2");
            precioTraspasoUsd_lbl.Text = precioTraspasoUSD.ToString("N2");
            precioSeguroRd_lbl.Text = precioSeguroRD.ToString("N2");
            precioSeguroUsd_lbl.Text = precioSeguroUSD.ToString("N2");
            LLenarVehiculosCb();
            LLenarTipoPagoCb();
            LLenarTipoPagoCbTraspaso();
           // LLenarTipoPagoCbSeguros();
           // LLenarSegurosCb();
            Permisos();
        }
        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }
        }
        public void LlenarDtgClientes()
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerClientesActivos();
            cliente_cb.DataSource = null;

            cliente_cb.DataSource = dt;
            cliente_cb.DisplayMember = "CLIENTE";
            cliente_cb.ValueMember = "ID";
            cliente_cb.SelectedIndex = -1;


        }

        public void LLenarTipoPagoCb()
        {
            tipoPago_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTiposPagos();
            tipoPago_cb.DataSource = dt;
            tipoPago_cb.DisplayMember = "TIPOPAGO";
            tipoPago_cb.ValueMember = "ID";
            tipoPago_cb.SelectedIndex = 0;


        }

        public void LLenarSegurosCb()
        {
            seguro_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerSegurosActivos();
            seguro_cb.DataSource = dt;
            seguro_cb.DisplayMember = "SEGURO";
            seguro_cb.ValueMember = "ID";
            if (dt.Rows.Count > 0)
            {
                seguro_cb.SelectedIndex = 0;
            }
            


        }

        public void LLenarTipoPagoCbTraspaso()
        {
            tipoPagoTraspaso_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTiposPagosSinVehiculo();
            tipoPagoTraspaso_cb.DataSource = dt;
            tipoPagoTraspaso_cb.DisplayMember = "TIPOPAGO";
            tipoPagoTraspaso_cb.ValueMember = "ID";
            tipoPagoTraspaso_cb.SelectedIndex = 0;



        }

        public void LLenarTipoPagoCbSeguros()
        {
            tipoPagoSeguros_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTiposPagosSinVehiculo();
            tipoPagoSeguros_cb.DataSource = dt;
            tipoPagoSeguros_cb.DisplayMember = "TIPOPAGO";
            tipoPagoSeguros_cb.ValueMember = "ID";
            tipoPagoSeguros_cb.SelectedIndex = 0;



        }

        public void LLenarVehiculosCb()
        {
            vehiculos_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerVehiculosParaFacturar();
            vehiculos_cb.DataSource = dt;
            vehiculos_cb.DisplayMember = "VEHICULO";
            vehiculos_cb.ValueMember = "ID";
            vehiculos_cb.SelectedIndex = -1;


        }

        public void CambiarPago()
        {
            if (rdDinero_radiobtn.Checked)
            {
                pago_txt.Text = precioVentaRD.ToString("N2");
            }
            else
            {
                pago_txt.Text = precioVentaUSD.ToString("N2");
            }

        }

        private void rdDinero_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CambiarPago();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pagos_dtg.Rows.Count > 0 && pagosTraspaso_dtg.Rows.Count > 0) //&& seguros_dtg.Rows.Count > 0
                {
                    if ((Convert.ToDouble(restante_RD_lbl.Text) == 0 || Convert.ToDouble(restante_USD_lbl.Text) == 0) && (Convert.ToDouble(restanteTraspaso_RD_lbl.Text) == 0 || Convert.ToDouble(restanteTraspaso_USD_lbl.Text) == 0)) //&& (Convert.ToDouble(restanteSeguro_RD_lbl.Text) == 0 || Convert.ToDouble(restanteSeguro_USD_lbl.Text) == 0)
                    {
                        VenderVehiculo();
                    }
                    else
                    {
                        MessageBox.Show("Montos restantes deben ser igual a cero", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Agregar Detalles de Pagos Cada Categoría", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void VenderVehiculo()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            
            string[] valores = { cliente_cb.Text}; //seguro_cb.Text, seguro_cb.Text 
            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pagos_dtg.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregarse algún tipo de pago con un monto", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (InsertarFactura())
                {
                    if (InsertarDetalleVenta())
                    {
                        if (InsertarDetalleTraspaso())
                        {
                            if (true) //InsertarDetalleSeguro()
                            {
                                if (MarcarVehiculoVendio())
                                {
                                    InsertarImagenes();
                                    RemoveAllPhotos();
                                    GenerarFactura();
                                    clearFields();
                                }
                                else
                                {
                                    BorrarRegistrosBD();
                                }
                            }

                            else
                            {
                                BorrarRegistrosBD();
                            }
                        }

                        else
                        {
                            BorrarRegistrosBD();
                        }
                    }
                    else
                    {
                        BorrarRegistrosBD();
                    }
                }
                else
                {
                    BorrarRegistrosBD();
                }
            }
        }

        public void BorrarRegistrosBD()
        {
            P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
            P.BorrarVentaYDetallePagoVehiculo();
            MessageBox.Show("No se pudo facturar el vehículo", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public bool InsertarDetalleVenta()
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
                P.IdTransaccion = 1; //Venta
                

                string respuesta = P.InsertarDetalleTransaccionFacturacion();
                if (respuesta != "1")
                {
                    error++;

                }
            }
            if(error == 0)
            {
                result = true;
            }

            return result;

        }

        public bool InsertarDetalleTraspaso()
        {
            int error = 0;
            bool result = false;
            foreach (DataGridViewRow row in pagosTraspaso_dtg.Rows)
            {
                P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                P.Fecha = fecha_dtp.Value;
                P.Nota = row.Cells[3].Value.ToString();
                P.IdTipoPago = Convert.ToInt32(row.Cells[5].Value);
                P.MontoRD = Convert.ToDouble(row.Cells[1].Value); // pago rd
                P.MontoUSD = Convert.ToDouble(row.Cells[2].Value); // pago usd
                P.IdTransaccion = 3; //Traspaso


                string respuesta = P.InsertarDetalleTransaccionFacturacion();
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

        public bool InsertarDetalleSeguro()
        {
            int error = 0;
            bool result = false;
            foreach (DataGridViewRow row in seguros_dtg.Rows)
            {
                P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                P.Fecha = fecha_dtp.Value;
                P.Nota = row.Cells[3].Value.ToString();
                P.IdTipoPago = Convert.ToInt32(row.Cells[5].Value);
                P.MontoRD = Convert.ToDouble(row.Cells[1].Value); // pago rd
                P.MontoUSD = Convert.ToDouble(row.Cells[2].Value); // pago usd
                P.IdTransaccion = 4; //Seguros


                string respuesta = P.InsertarDetalleTransaccionFacturacion();
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

        public bool InsertarFactura()
        {
            bool result = false;
            P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
            P.Fecha = fecha_dtp.Value;
            P.IdCliente = Convert.ToInt32(cliente_cb.SelectedValue);
            P.Nota = nota_txt.Text;
            string msj = P.InsertarFactura();
            if(msj == "1")
            {
                result = true;
            }
            return result;
        }

        public bool MarcarVehiculoVendio()
        {
            bool result = false;
            P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
            P.Fecha = fecha_dtp.Value;
            P.IdCliente = Convert.ToInt32(cliente_cb.SelectedValue);
            P.Duracion = Convert.ToInt32(duracion_seguro.Value);
            P.IdSeguro = Convert.ToInt32(seguro_cb.SelectedValue);
            P.IdCliente = Convert.ToInt32(cliente_cb.SelectedValue);
            P.PrecioVentaRD = precioVentaRD;
            P.PrecioVentaUSD = precioVentaUSD;
            P.PrecioTraspasoRD = precioTraspasoRD;
            P.PrecioTraspasoUSD = precioTraspasoUSD;
            P.PrecioSeguroRD = precioSeguroRD;
            P.PrecioSeguroUSD = precioSeguroUSD;
            string msj = P.VenderVehiculo();
            if (msj == "1")
            {
                result = true;
            }
            return result;
        }

        public void InsertarImagenTraspaso()
        {
            string errors = "";
            foreach (var img1 in imgsList)
            {
                byte[] img = null;
                FileStream fs = new FileStream(img1, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                P.Img = img;
                string msj2 = P.InsertarImagenTraspaso();
                if (msj2 == "0")
                {
                    errors += img1 + "\n";
                }

            }
            if(errors != "")
            {
                MessageBox.Show("No se pudieron guardar las siguientes imágenes: \n" + errors, Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            imgsList.Clear();
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



        private void agregar_btn_Click(object sender, EventArgs e)
        {
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
                cantidadAgregar = Convert.ToDouble(pago_txt.Text);
                double totalAgregado = Convert.ToDouble(totalRD_lbl.Text);
                precioTotal = Convert.ToDouble(precioVentaRd_lbl.Text);
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
                        pagos_dtg.Rows[row - 1].Cells[3].Value = nota_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;
                    }

                    CalcularTotal();
                    pago_txt.Text = "";
                    nota_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del Vehículo", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                cantidadAgregar = Convert.ToDouble(pago_txt.Text);
                double totalAgregado = Convert.ToDouble(totalUSD_lbl.Text);
                precioTotal = Convert.ToDouble(precioVentaUSD_lbl.Text);
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
                        pagos_dtg.Rows[row - 1].Cells[3].Value = nota_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;

                    }
                    CalcularTotal();
                    pago_txt.Text = "";
                    nota_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del Vehículo", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            restante_RD_lbl.Text = (precioVentaRD - Convert.ToDouble(totalRD_lbl.Text)).ToString("N2");
            restante_USD_lbl.Text = (precioVentaUSD - Convert.ToDouble(totalUSD_lbl.Text)).ToString("N2");
        }

        public void addDeleteButton()
        {
            //var deleteButton = new DataGridViewButtonColumn();
            //deleteButton.Name = "dataGridViewDeleteButton";
            //deleteButton.HeaderText = "ELIMINAR";

            ////deleteButton.UseColumnTextForButtonValue = true;
            //this.pagos_dtg.Columns.Add(deleteButton);

        }

        public void RemoveAllPhotos()
        {
            List<Control> listControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();
            
            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

            
        }

        private void pagos_dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == pagos_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == pagos_dtg.Columns["dataGridViewDeleteButton"].Index)
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
            if (e.ColumnIndex == pagos_dtg.Columns["dataGridViewDeleteButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                pagos_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        private void vehiculos_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (vehiculos_cb.Text != "")
            {
                int idVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                P.Id = idVehiculo;
                DataTable dt = new DataTable();
                dt = P.ObtenerCostoChasisVehiculo();
                costoRD_txt.Text = Convert.ToDouble(dt.Rows[0]["COSTORD"]).ToString("N2");
                costoUSD_txt.Text = Convert.ToDouble(dt.Rows[0]["COSTOUSD"]).ToString("N2");
                precioEstimadoVentaRD_txt.Text = Convert.ToDouble(dt.Rows[0]["PRECIO VENTA ESTIMADO RD"]).ToString("N2");
                precioEstimadoVentaUSD_txt.Text = Convert.ToDouble(dt.Rows[0]["PRECIO VENTA ESTIMADO USD"]).ToString("N2");
                chasis_txt.Text = dt.Rows[0]["VIN"].ToString();
            }
            else
            {
                costoRD_txt.Text = "";
                costoUSD_txt.Text = "";
                chasis_txt.Text = "";
                precioEstimadoVentaRD_txt.Text = "";
                precioEstimadoVentaUSD_txt.Text = "";
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
                precioVentaRd_lbl.Text = "0.00";
                precioVentaUSD_lbl.Text = "0.00";
                pagos_dtg.Rows.Clear();
                restante_RD_lbl.Text = "0.00";
                restante_USD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
            }
        }

        public void CalcularPrecio()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            try
            {
                if (radioBtnRD_precio.Checked)
                {
                    precioVentaRD = Convert.ToDouble(precio_txt.Text);
                    precioVentaUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);

                }
                else if (radioBtnUSD_precio.Checked)
                {
                    precioVentaRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    precioVentaUSD = Convert.ToDouble(precio_txt.Text);


                }
                precioVentaRd_lbl.Text = precioVentaRD.ToString("N2");
                precioVentaUSD_lbl.Text = precioVentaUSD.ToString("N2");
                CalcularTotal();
            }
            catch
            {

            }

        }

        public void FieldStatus(bool estado)
        {
            if (estado)
            {
                tipoPago_cb.Enabled = true;
                pago_txt.Enabled = true;
                nota_txt.Enabled = true;
                agregar_btn.Enabled = true;
                rdDinero_radiobtn.Enabled = true;
                usdDinero_radiobtn.Enabled = true;
            }
            else
            {
                tipoPago_cb.Enabled = false;
                pago_txt.Enabled = false;
                nota_txt.Enabled = false;
                agregar_btn.Enabled = false;
                rdDinero_radiobtn.Enabled = false;
                usdDinero_radiobtn.Enabled = false;
            }
        }

        public void FieldStatusTraspaso(bool estado)
        {
            if (estado)
            {
                tipoPagoTraspaso_cb.Enabled = true;
                montoTraspaso_txt.Enabled = true;
                notaPagoTraspaso_txt.Enabled = true;
                agregarPagoTraspaso_btn.Enabled = true;
                //rdDineroTraspaso_radiobtn.Enabled = true;
                //usdDineroTraspaso_radiobtn.Enabled = true;
            }
            else
            {
                tipoPagoTraspaso_cb.Enabled = false;
                montoTraspaso_txt.Enabled = false;
                notaPagoTraspaso_txt.Enabled = false;
                agregarPagoTraspaso_btn.Enabled = false;
                //rdDineroTraspaso_radiobtn.Enabled = false;
                //usdDineroTraspaso_radiobtn.Enabled = false;
            }
        }

        private void radioBtnRD_precio_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
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

        public void GenerarFactura()
        {
            int idVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);


            Program.GidVehiculoRpt = idVehiculo;
            Program.Greporte = "Factura Venta Vehículo";
            ReportesForm form1 = new ReportesForm();
            form1.Show();

        }

        private void fecha_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (fecha_dtp.Value > DateTime.Now.Date)
            {
                fecha_dtp.Value = DateTime.Now.Date;
            }
        }

        private void agregarImg_btn_Click(object sender, EventArgs e)
        {
            List<String> imgsList1 = new List<String>();

            try
            {

                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        imgsList1.Add(file);
                    }

                    CargarImagenes(imgsList1);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarImagenes(List<string> listArray)
        {

            foreach (String file in listArray)
            {

                count++;
                imgsList.Add(file);
                // Create a PictureBox.
                try
                {

                    Button newButton = new Button();
                    newButton.Size = new Size(30, 30);
                    newButton.Image = Properties.Resources.delete;
                    newButton.FlatStyle = FlatStyle.Flat;

                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.Click += new EventHandler(newButton_click);
                    newButton.Tag = "dynpb" + count.ToString();

                    flowLayoutPanel1.Controls.Add(newButton);

                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(420, 220);
                    pb.Tag = "dynpb" + count.ToString();
                    pb.Image = loadedImage;

                    flowLayoutPanel1.Controls.Add(pb);

                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
        }

        protected void newButton_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int index = Convert.ToInt32(Regex.Replace(button.Tag.ToString(), "[^0-9 _]", "")) - 1;
            imgsList.RemoveAt(index);

            foreach (PictureBox pic_box in flowLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (pic_box.Tag != null && pic_box.Tag.ToString() == button.Tag.ToString())
                {
                    pic_box.Dispose();
                }
            }

            foreach (Button but in flowLayoutPanel1.Controls.OfType<Button>())
            {
                if (but.Tag != null && but.Tag.ToString() == button.Tag.ToString())
                {
                    but.Dispose();
                }
            }
            
        }

        private void agregarPagoTraspaso_btn_Click(object sender, EventArgs e)
        {
            string[] valores = { tipoPagoTraspaso_cb.Text };
            string[] numeros = { montoTraspaso_txt.Text };
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
                AgregarPagosTraspasoDtg();
            }
        }

        public void AgregarPagosTraspasoDtg()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            bool add = true;
            double cantidadAgregar;
            double precioTotal;
            if (rdDineroTraspaso_radiobtn.Checked)
            {
                cantidadAgregar = Convert.ToDouble(montoTraspaso_txt.Text);
                double totalAgregado = Convert.ToDouble(totalTraspasoRD_lbl.Text);
                precioTotal = Convert.ToDouble(precioTraspasoRd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {

                    foreach (DataGridViewRow row1 in pagosTraspaso_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPagoTraspaso_cb.Text)
                        {
                            row1.Cells[1].Value = cantidadAgregar + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {
                        pagosTraspaso_dtg.Rows.Add();

                        int row = pagosTraspaso_dtg.Rows.Count;
                        pagosTraspaso_dtg.Rows[row - 1].Cells[0].Value = tipoPagoTraspaso_cb.Text;
                        pagosTraspaso_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar;
                        pagosTraspaso_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        pagosTraspaso_dtg.Rows[row - 1].Cells[3].Value = notaPagoTraspaso_txt.Text;

                        pagosTraspaso_dtg.Rows[row - 1].Cells[5].Value = tipoPagoTraspaso_cb.SelectedValue;
                    }

                    CalcularTotalTraspaso();
                    montoTraspaso_txt.Text = "";
                    notaPagoTraspaso_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del traspaso", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                cantidadAgregar = Convert.ToDouble(montoTraspaso_txt.Text);
                double totalAgregado = Convert.ToDouble(totalTraspasoUSD_lbl.Text);
                precioTotal = Convert.ToDouble(precioTraspasoUsd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {
                    foreach (DataGridViewRow row1 in pagosTraspaso_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPagoTraspaso_cb.Text)
                        {
                            row1.Cells[1].Value = (cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {

                        pagosTraspaso_dtg.Rows.Add();
                        int row = pagosTraspaso_dtg.Rows.Count;
                        pagosTraspaso_dtg.Rows[row - 1].Cells[0].Value = tipoPagoTraspaso_cb.Text;
                        pagosTraspaso_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        pagosTraspaso_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar;
                        pagosTraspaso_dtg.Rows[row - 1].Cells[3].Value = notaPagoTraspaso_txt.Text;

                        pagosTraspaso_dtg.Rows[row - 1].Cells[5].Value = tipoPagoTraspaso_cb.SelectedValue;

                    }
                    CalcularTotalTraspaso();
                    montoTraspaso_txt.Text = "";
                    notaPagoTraspaso_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del traspaso", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void montoTraspaso_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(montoTraspaso_txt.Text);



            }
            catch
            {

                if (montoTraspaso_txt.Text.Length > 1)
                {
                    montoTraspaso_txt.Text = montoTraspaso_txt.Text.Remove(montoTraspaso_txt.Text.Length - 1);
                    montoTraspaso_txt.SelectionStart = montoTraspaso_txt.Text.Length;
                }
                else
                {
                    montoTraspaso_txt.Text = "";
                }

            }
        }

        private void rdDineroTraspaso_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecioTraspaso();
        }

        public void CalcularPrecioTraspaso()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            try
            {
                if (rdDineroTraspaso_radiobtn.Checked)
                {
                    precioTraspasoRD = Convert.ToDouble(precioTraspaso_txt.Text);
                    precioTraspasoUSD = Convert.ToDouble(precioTraspaso_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);

                }
                else if (usdDineroTraspaso_radiobtn.Checked)
                {
                    precioTraspasoRD = Convert.ToDouble(precioTraspaso_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    precioTraspasoUSD = Convert.ToDouble(precioTraspaso_txt.Text);


                }
                precioTraspasoRd_lbl.Text = precioTraspasoRD.ToString("N2");
                precioTraspasoUsd_lbl.Text = precioTraspasoUSD.ToString("N2");
                CalcularTotalTraspaso();
            }
            catch
            {

            }

        }

        public void CalcularTotalTraspaso()
        {
            double totalRD = 0;
            double totalUSD = 0;
            if (pagosTraspaso_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in pagosTraspaso_dtg.Rows)
                {
                    totalRD += Convert.ToDouble(row.Cells[1].Value);
                    totalUSD += Convert.ToDouble(row.Cells[2].Value);


                }
                totalTraspasoRD_lbl.Text = totalRD.ToString("N2");
                totalTraspasoUSD_lbl.Text = totalUSD.ToString("N2");



            }
            else
            {
                totalTraspasoRD_lbl.Text = "0.00";
                totalTraspasoUSD_lbl.Text = "0.00";

            }

            restanteTraspaso_RD_lbl.Text = (precioTraspasoRD - Convert.ToDouble(totalTraspasoRD_lbl.Text)).ToString("N2");
            restanteTraspaso_USD_lbl.Text = (precioTraspasoUSD - Convert.ToDouble(totalTraspasoUSD_lbl.Text)).ToString("N2");
        }

        private void precioTraspaso_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(precioTraspaso_txt.Text);



            }
            catch
            {

                if (precioTraspaso_txt.Text.Length > 1)
                {
                    precioTraspaso_txt.Text = precioTraspaso_txt.Text.Remove(precioTraspaso_txt.Text.Length - 1);
                    precioTraspaso_txt.SelectionStart = precioTraspaso_txt.Text.Length;
                }
                else
                {
                    precioTraspaso_txt.Text = "";
                }

            }

            if (precioTraspaso_txt.Text.Length > 0)
            {
                CalcularPrecioTraspaso();
                FieldStatusTraspaso(true);
                if (Convert.ToDouble(restanteTraspaso_RD_lbl.Text) < 0 || Convert.ToDouble(restanteTraspaso_USD_lbl.Text) < 0)
                {
                    pagosTraspaso_dtg.Rows.Clear();
                    CalcularTotalTraspaso();
                    CalcularPrecioTraspaso();

                }
            }
            else
            {
                FieldStatusTraspaso(false);
                precioTraspasoRd_lbl.Text = "0.00";
                precioTraspasoUsd_lbl.Text = "0.00";
                pagosTraspaso_dtg.Rows.Clear();
                restanteTraspaso_RD_lbl.Text = "0.00";
                restanteTraspaso_USD_lbl.Text = "0.00";
                totalTraspasoRD_lbl.Text = "0.00";
                totalTraspasoUSD_lbl.Text = "0.00";
            }
        }

        private void pagosTraspaso_dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == pagosTraspaso_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == pagosTraspaso_dtg.Columns["dataGridViewButtonColumn1"].Index)
            {
                var image = Properties.Resources.deshabilitado1; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void pagosTraspaso_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == pagosTraspaso_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == pagosTraspaso_dtg.Columns["dataGridViewButtonColumn1"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                pagosTraspaso_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotalTraspaso();
            }
        }

        private void rdDineroSeguros_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecioSeguro();
        }

        public void CalcularPrecioSeguro()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            try
            {
                if (rdDineroSeguros_radiobtn.Checked)
                {
                    precioSeguroRD = Convert.ToDouble(precioSeguro_txt.Text);
                    precioSeguroUSD = Convert.ToDouble(precioSeguro_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);

                }
                else if (usdDineroSeguros_radiobtn.Checked)
                {
                    precioSeguroRD = Convert.ToDouble(precioSeguro_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    precioSeguroUSD = Convert.ToDouble(precioSeguro_txt.Text);


                }
                precioSeguroRd_lbl.Text = precioSeguroRD.ToString("N2");
                precioSeguroUsd_lbl.Text = precioSeguroUSD.ToString("N2");
                CalcularTotalSeguros();
            }
            catch
            {

            }

        }

        private void precioSeguro_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(precioSeguro_txt.Text);



            }
            catch
            {

                if (precioSeguro_txt.Text.Length > 1)
                {
                    precioSeguro_txt.Text = precioSeguro_txt.Text.Remove(precioSeguro_txt.Text.Length - 1);
                    precioSeguro_txt.SelectionStart = precioSeguro_txt.Text.Length;
                }
                else
                {
                    precioSeguro_txt.Text = "";
                }

            }

            if (precioSeguro_txt.Text.Length > 0)
            {
                CalcularPrecioSeguro();
                FieldStatusSeguro(true);
                if (Convert.ToDouble(restanteSeguro_RD_lbl.Text) < 0 || Convert.ToDouble(restanteSeguro_USD_lbl.Text) < 0)
                {
                    seguros_dtg.Rows.Clear();
                    CalcularTotalSeguros();
                    CalcularPrecioSeguro();

                }
            }
            else
            {
                FieldStatusSeguro(false);
                precioSeguroRd_lbl.Text = "0.00";
                precioSeguroUsd_lbl.Text = "0.00";
                seguros_dtg.Rows.Clear();
                restanteSeguro_RD_lbl.Text = "0.00";
                restanteSeguro_USD_lbl.Text = "0.00";
                totalSeguroRD_lbl.Text = "0.00";
                totalSeguroUSD_lbl.Text = "0.00";
            }
        }

        private void agregarPagosSeguros_btn_Click(object sender, EventArgs e)
        {
            string[] valores = { tipoPagoSeguros_cb.Text };
            string[] numeros = { montoSeguros_txt.Text };
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
                AgregarPagosSegurosDtg();
            }
        }

        public void AgregarPagosSegurosDtg()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            bool add = true;
            double cantidadAgregar;
            double precioTotal;
            if (rdDineroSeguros_radiobtn.Checked)
            {
                cantidadAgregar = Convert.ToDouble(montoSeguros_txt.Text);
                double totalAgregado = Convert.ToDouble(totalSeguroRD_lbl.Text);
                precioTotal = Convert.ToDouble(precioSeguroRd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {

                    foreach (DataGridViewRow row1 in seguros_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPagoSeguros_cb.Text)
                        {
                            row1.Cells[1].Value = cantidadAgregar + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {
                        seguros_dtg.Rows.Add();

                        int row = seguros_dtg.Rows.Count;
                        seguros_dtg.Rows[row - 1].Cells[0].Value = tipoPagoSeguros_cb.Text;
                        seguros_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar;
                        seguros_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        seguros_dtg.Rows[row - 1].Cells[3].Value = notaPagoSeguros_txt.Text;

                        seguros_dtg.Rows[row - 1].Cells[5].Value = tipoPagoSeguros_cb.SelectedValue;
                    }

                    CalcularTotalSeguros();
                    montoSeguros_txt.Text = "";
                    notaPagoSeguros_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del seguro", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                cantidadAgregar = Convert.ToDouble(montoSeguros_txt.Text);
                double totalAgregado = Convert.ToDouble(totalSeguroUSD_lbl.Text);
                precioTotal = Convert.ToDouble(precioSeguroUsd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {
                    foreach (DataGridViewRow row1 in seguros_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPagoSeguros_cb.Text)
                        {
                            row1.Cells[1].Value = (cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"])) + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {

                        seguros_dtg.Rows.Add();
                        int row = seguros_dtg.Rows.Count;
                        seguros_dtg.Rows[row - 1].Cells[0].Value = tipoPagoSeguros_cb.Text;
                        seguros_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                        seguros_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar;
                        seguros_dtg.Rows[row - 1].Cells[3].Value = notaPagoSeguros_txt.Text;

                        seguros_dtg.Rows[row - 1].Cells[5].Value = tipoPagoSeguros_cb.SelectedValue;

                    }
                    CalcularTotalSeguros();
                    montoSeguros_txt.Text = "";
                    notaPagoSeguros_txt.Text = "";

                }
                else
                {
                    MessageBox.Show("La cantidad digitada supera el precio total del Seguro", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CalcularTotalSeguros()
        {
            double totalRD = 0;
            double totalUSD = 0;
            if (seguros_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in seguros_dtg.Rows)
                {
                    totalRD += Convert.ToDouble(row.Cells[1].Value);
                    totalUSD += Convert.ToDouble(row.Cells[2].Value);


                }
                totalSeguroRD_lbl.Text = totalRD.ToString("N2");
                totalSeguroUSD_lbl.Text = totalUSD.ToString("N2");



            }
            else
            {
                totalSeguroRD_lbl.Text = "0.00";
                totalSeguroUSD_lbl.Text = "0.00";

            }

            restanteSeguro_RD_lbl.Text = (precioSeguroRD - Convert.ToDouble(totalSeguroRD_lbl.Text)).ToString("N2");
            restanteSeguro_USD_lbl.Text = (precioSeguroUSD - Convert.ToDouble(totalSeguroUSD_lbl.Text)).ToString("N2");
        }

        public void FieldStatusSeguro(bool estado)
        {
            if (estado)
            {
                tipoPagoSeguros_cb.Enabled = true;
                montoSeguros_txt.Enabled = true;
                notaPagoSeguros_txt.Enabled = true;
                agregarPagosSeguros_btn.Enabled = true;
                
            }
            else
            {
                tipoPagoSeguros_cb.Enabled = false;
                montoSeguros_txt.Enabled = false;
                notaPagoSeguros_txt.Enabled = false;
                agregarPagosSeguros_btn.Enabled = false;

            }
        }

        private void seguros_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == seguros_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == seguros_dtg.Columns["dataGridViewButtonColumn2"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                seguros_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotalSeguros();
            }
        }

        private void seguros_dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == seguros_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == seguros_dtg.Columns["dataGridViewButtonColumn2"].Index)
            {
                var image = Properties.Resources.deshabilitado1; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void montoSeguros_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(montoSeguros_txt.Text);



            }
            catch
            {

                if (montoSeguros_txt.Text.Length > 1)
                {
                    montoSeguros_txt.Text = montoSeguros_txt.Text.Remove(montoSeguros_txt.Text.Length - 1);
                    montoSeguros_txt.SelectionStart = montoSeguros_txt.Text.Length;
                }
                else
                {
                    montoSeguros_txt.Text = "";
                }

            }
        }

        public void InsertarImagenes()
        {
            string errors = "";
            foreach (var img1 in imgsList)
            {
                byte[] img = null;
                FileStream fs = new FileStream(img1, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                P.Img = img;
                P.IdVehiculo = Convert.ToInt32(vehiculos_cb.SelectedValue);
                string msj2 = P.InsertarImagenTraspaso();
                if (msj2 == "0")
                {
                    errors += img1 + "\n";
                }

            }
            imgsList.Clear();
            if (errors == "")
            {
                MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudieron guardar las siguientes imágenes: \n" + errors, Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void VenderForm_FormClosed(object sender, FormClosedEventArgs e)
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
