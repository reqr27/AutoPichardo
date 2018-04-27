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
    public partial class NuevoVehiculoForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool fillCombo = false;
        
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        double precioCompraRd = 0;
        double precioCompraUsd = 0;
        public NuevoVehiculoForm()
        {
            InitializeComponent();
        }

        private void NuevoVehiculoForm_Load(object sender, EventArgs e)
        {
            precioCompraRd_lbl.Text = precioCompraRd.ToString("N2");
            precioCompraUSD_lbl.Text = precioCompraUsd.ToString("N2");
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " +  (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            LLenarTipoPagoCb();
            LlenarAñoCb();
            LLenarFabricanteCb();
            LLenarModeloCb();
            LLenarPropietarioCb();
            LLenarColoresCb();
            LLenarSuplidorCb();
            LLenarUbicacionCb();
            CalcularTotal();
            FieldStatus(false);
            Permisos();
            fabricante_cbox.Focus();
            guardar_btn.NotifyDefault(false);

        }

        public void LlenarAñoCb()
        {
            List<String> years = new List<String>();
            years = GF.GetArrayofYears();
            año_cb.DataSource = null;
            foreach (var year in years)
            {
                año_cb.Items.Add(year);
            }
            var selectedYear = DateTime.Now.Year - 5;
            año_cb.Text = selectedYear.ToString();
        }

        public void LLenarColoresCb()
        {
            color_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerColoresActivos();
            color_cb.DataSource = dt;
            color_cb.DisplayMember = "COLOR";
            color_cb.ValueMember = "ID";
            color_cb.SelectedIndex = -1;
           

        }

        public void LLenarSuplidorCb()
        {
            suplidor_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerSuplidoresActivos();
            suplidor_cb.DataSource = dt;
            suplidor_cb.DisplayMember = "SUPLIDOR";
            suplidor_cb.ValueMember = "ID";
            suplidor_cb.SelectedIndex = -1;


        }

        public void LLenarUbicacionCb()
        {
            ubicacion_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerUbicacionesActivos();
            ubicacion_cb.DataSource = dt;
            ubicacion_cb.DisplayMember = "LUGAR";
            ubicacion_cb.ValueMember = "ID";
            ubicacion_cb.SelectedIndex = -1;


        }

        public void LLenarFabricanteCb()
        {
            fabricante_cbox.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerFabricantesActivos();
            fabricante_cbox.DataSource = dt;
            fabricante_cbox.DisplayMember = "FABRICANTE";
            fabricante_cbox.ValueMember = "ID";
            fabricante_cbox.SelectedIndex = -1;
            fillCombo = true;

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


        public void LLenarModeloCb()
        {
            if (fillCombo)
            {
                modelo_cb.DataSource = null;
                DataTable dt = new DataTable();
                P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue);
                dt = P.ObtenerModelosFabricanteActivos();
                modelo_cb.DataSource = dt;
                modelo_cb.DisplayMember = "MODELO";
                modelo_cb.ValueMember = "ID";
                modelo_cb.SelectedIndex = -1;
                
            }
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

        private void fabricante_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fabricante_cbox.SelectedIndex != -1 && fillCombo)
            {
                modelo_cb.Enabled = true;
                LLenarModeloCb();

            }
        }

        public void RegistrarVehiculo()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            string[] valores = { fabricante_cbox.Text, modelo_cb.Text, año_cb.Text,  color_cb.Text,vin_txt.Text, placa_txt.Text, matricula_txt.Text, millaje_txt.Text, fuerzaMotriz_txt.Text, suplidor_cb.Text, propietario_cb.Text, ubicacion_cb.Text, nota_txt.Text };
            string[] numeros = { año_cb.Text, precio_txt.Text, precioVentaEstimado_txt.Text};
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos de Texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio, Ganancia y Año solo permiten números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue);
                P.IdModelo = Convert.ToInt32(modelo_cb.SelectedValue);
                P.Año = Convert.ToInt32(año_cb.Text);
                P.Nota = nota_txt.Text;
                P.IdPropietario = Convert.ToInt32(propietario_cb.SelectedValue);
                P.Vin = vin_txt.Text;
                P.Fecha = fecha_dtp.Value;
                P.Color = color_cb.Text;
                P.Ubicacion = ubicacion_cb.Text;
                P.ActoVenta = acto_venta_chbox.Checked;
                P.CedulaVendedor = cedula_chbox.Checked;
                P.MatriculaOriginal = mat_chbox.Checked;
                P.IdUbicacion = Convert.ToInt32(ubicacion_cb.SelectedValue);
                P.IdSuplidor = Convert.ToInt32(suplidor_cb.SelectedValue);
                P.Millaje = millaje_txt.Text;
                P.FuerzaMotriz = fuerzaMotriz_txt.Text;
                P.NumeroMatricula = matricula_txt.Text;
                P.Placa = placa_txt.Text;
                

                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                }

                if (rdDinero_radiobtn3.Checked)
                {
                    P.PrecioVentaEstimadoRD = Convert.ToDouble(precioVentaEstimado_txt.Text);
                    P.PrecioVentaEstimadoUSD = Convert.ToDouble(precioVentaEstimado_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                }
                else
                {
                    P.PrecioVentaEstimadoUSD = Convert.ToDouble(precioVentaEstimado_txt.Text);
                    P.PrecioVentaEstimadoRD = Convert.ToDouble(precioVentaEstimado_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                }

                string respuesta = P.RegistrarVehiculo();
                if (respuesta == "1")
                {
                    RegistrarPagos();
                    
                }
                
                else
                {
                    
                    MessageBox.Show("Compra no pudo ser registrada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrar_btn_Click(object sender, EventArgs e)
        {
            ResetFields(); 
        }

        public void ResetFields()
        {
            precioVentaEstimado_txt.Text = "";
            placa_txt.Text = "";
            suplidor_cb.SelectedIndex = -1;
            ubicacion_cb.SelectedIndex = -1;
            matricula_txt.Text = "";
            fuerzaMotriz_txt.Text = "";
            color_cb.SelectedIndex = -1;
            millaje_txt.Text = "";

            fabricante_cbox.SelectedIndex = -1;
            modelo_cb.SelectedIndex = -1;
            año_cb.Text = "2013";
            color_cb.Text = "";
            vin_txt.Text = "";
            precio_txt.Text = "";
            propietario_cb.SelectedIndex = -1;
            mat_chbox.Checked = false;
            acto_venta_chbox.Checked = false;
            cedula_chbox.Checked = false;
            pagos_dtg.Rows.Clear();
            pago_txt.Text = "";
            tipoPago_cb.SelectedIndex = 0;
            precioCompraRd_lbl.Text = "0.00";
            precioCompraUSD_lbl.Text = "0.00";
            pagos_dtg.Rows.Clear();
            restante_RD_lbl.Text = "0.00";
            restante_USD_lbl.Text = "0.00";
            totalRD_lbl.Text = "0.00";
            totalUSD_lbl.Text = "0.00";
            nota_txt.Text = "";
            ubicacion_cb.Text = "";
            fabricante_cbox.Focus();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        public void AgregarPagosDtg()
        {
            bool add = true;
            double cantidadAgregar;
            double precioTotal;
            if (rdDinero_radiobtn.Checked)
            {
                cantidadAgregar = Convert.ToDouble(pago_txt.Text);
                double totalAgregado = Convert.ToDouble(totalRD_lbl.Text);
                precioTotal = Convert.ToDouble(precioCompraRd_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {
                    foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                        {
                            row1.Cells[1].Value = cantidadAgregar + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar / Convert.ToDouble(Properties.Settings.Default.tasaDolar)) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {
                        pagos_dtg.Rows.Add();

                        int row = pagos_dtg.Rows.Count;
                        pagos_dtg.Rows[row - 1].Cells[0].Value = tipoPago_cb.Text;
                        pagos_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar;
                        pagos_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                        pagos_dtg.Rows[row - 1].Cells[3].Value = detalle_pago_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;
                    }
                    CalcularTotal();
                    pago_txt.Text = "";
                    detalle_pago_txt.Text = "";

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
                precioTotal = Convert.ToDouble(precioCompraUSD_lbl.Text);
                if ((cantidadAgregar <= precioTotal) && (cantidadAgregar + totalAgregado) <= precioTotal)
                {
                    foreach (DataGridViewRow row1 in pagos_dtg.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == tipoPago_cb.Text)
                        {
                            row1.Cells[1].Value = (cantidadAgregar * Convert.ToDouble(Properties.Settings.Default.tasaDolar)) + Convert.ToDouble(row1.Cells[1].Value);
                            row1.Cells[2].Value = (cantidadAgregar) + Convert.ToDouble(row1.Cells[2].Value);
                            add = false;
                        }


                    }
                    if (add)
                    {

                        pagos_dtg.Rows.Add();
                        int row = pagos_dtg.Rows.Count;
                        pagos_dtg.Rows[row - 1].Cells[0].Value = tipoPago_cb.Text;
                        pagos_dtg.Rows[row - 1].Cells[1].Value = cantidadAgregar * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                        pagos_dtg.Rows[row - 1].Cells[2].Value = cantidadAgregar;
                        pagos_dtg.Rows[row - 1].Cells[3].Value = detalle_pago_txt.Text;

                        pagos_dtg.Rows[row - 1].Cells[5].Value = tipoPago_cb.SelectedValue;

                    }
                    CalcularTotal();
                    pago_txt.Text = "";
                    detalle_pago_txt.Text = "";

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

            restante_RD_lbl.Text = (precioCompraRd - Convert.ToDouble(totalRD_lbl.Text)).ToString("N2");
            restante_USD_lbl.Text = (precioCompraUsd - Convert.ToDouble(totalUSD_lbl.Text)).ToString("N2");
        }

        private void rdDinero_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        public void FieldStatus(bool estado)
        {
            if (estado)
            {
                tipoPago_cb.Enabled = true;
                pago_txt.Enabled = true;
                detalle_pago_txt.Enabled = true;
                agregar_btn.Enabled = true;
                usdDinero_radiobtn2.Enabled = true;
                rdDinero_radiobtn2.Enabled = true;
            }
            else
            {
                tipoPago_cb.Enabled = false;
                pago_txt.Enabled = false;
                detalle_pago_txt.Enabled = false;
                agregar_btn.Enabled = false;
                usdDinero_radiobtn2.Enabled = false;
                rdDinero_radiobtn2.Enabled = false;
            }
        }
        public void CalcularPrecio()
        {
            try
            {
                 if (rdDinero_radiobtn.Checked)
            {
                precioCompraRd = Convert.ToDouble(precio_txt.Text);
                precioCompraUsd = Convert.ToDouble(precio_txt.Text) / Properties.Settings.Default.tasaDolar;
                precioCompraRd_lbl.Text = precioCompraRd.ToString("N2");
                precioCompraUSD_lbl.Text = precioCompraUsd.ToString("N2");
                CalcularTotal();
            }
            else if(usdDinero_radiobtn.Checked)
            {
                precioCompraRd = Convert.ToDouble(precio_txt.Text) * Properties.Settings.Default.tasaDolar;
                precioCompraUsd = Convert.ToDouble(precio_txt.Text);
                precioCompraRd_lbl.Text = precioCompraRd.ToString("N2");
                precioCompraUSD_lbl.Text = precioCompraUsd.ToString("N2");
                CalcularTotal();

            }
            }

            catch
            {

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
                 
                if (precio_txt.Text.Length > 0)
                {
                    precio_txt.Text = precio_txt.Text.Remove(precio_txt.Text.Length - 1);
                    precio_txt.SelectionStart = precio_txt.Text.Length;
                }
                else
                {
                    precio_txt.Text = "";
                }
                
            }

            if(precio_txt.Text.Length > 0)
            {
                CalcularPrecio();
                FieldStatus(true);
                if(Convert.ToDouble(restante_RD_lbl.Text) < 0 || Convert.ToDouble(restante_USD_lbl.Text) < 0)
                {
                    pagos_dtg.Rows.Clear();
                    CalcularTotal();
                    CalcularPrecio();
                    
                }
            }
            else
            {
                FieldStatus(false);
                precioCompraRd_lbl.Text = "0.00";
                precioCompraUSD_lbl.Text = "0.00";
                pagos_dtg.Rows.Clear();
                restante_RD_lbl.Text = "0.00";
                restante_USD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
                totalRD_lbl.Text = "0.00";
            }
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

        private void guardar_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (pagos_dtg.Rows.Count > 0)
                {
                    if (Convert.ToDouble(restante_RD_lbl.Text) == 0 || Convert.ToDouble(restante_USD_lbl.Text) == 0)
                    {
                        RegistrarVehiculo();
                    }
                    else
                    {
                        MessageBox.Show("El monto restante debe ser igual a cero", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Agregar Metodo de Pago", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        public void RegistrarPagos()
        {
            int error = 0;
            foreach (DataGridViewRow row in pagos_dtg.Rows)
            {


                P.IdVehiculo = 0;
                P.Fecha = fecha_dtp.Value;
                P.Nota = row.Cells[3].Value.ToString();
                P.IdTipoPago = Convert.ToInt32(row.Cells[5].Value);
                P.MontoRD = Convert.ToDouble(row.Cells[1].Value); // pago rd
                P.MontoUSD = Convert.ToDouble(row.Cells[2].Value); // pago usd
                P.IdTransaccion = 2; //Compras


                string respuesta = P.InsertarDetalleTransaccionCompras();
                
                if (respuesta != "1")
                {
                    error++;
                }
            }

            if(error > 0)
            {
                P.BorrarCompraYDetallePagoVehiculo();
                MessageBox.Show("Compra no pudo ser registrada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResetFields();
                MessageBox.Show("Compra fue Registrada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
              

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

        private void tipoPago_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tipoPago_cb.SelectedIndex == 1)
            {
                pago_txt.Text = precio_txt.Text;
            }
        }

        private void fecha_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (fecha_dtp.Value > DateTime.Now.Date)
            {
                fecha_dtp.Value = DateTime.Now.Date;
            }
            
        }

        private void NuevoVehiculoForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void fabricante_cbox_DropDown(object sender, EventArgs e)
        {
            LLenarFabricanteCb();
        }

        private void modelo_cb_DropDown(object sender, EventArgs e)
        {
            LLenarModeloCb();
        }

        private void color_cb_DropDown(object sender, EventArgs e)
        {
            LLenarColoresCb();
        }

        private void suplidor_cb_DropDown(object sender, EventArgs e)
        {
            LLenarSuplidorCb();
        }

        private void propietario_cb_DropDown(object sender, EventArgs e)
        {
            LLenarPropietarioCb();
        }

        private void ubicacion_cb_DropDown(object sender, EventArgs e)
        {
            LLenarUbicacionCb();
        }
    }
}
