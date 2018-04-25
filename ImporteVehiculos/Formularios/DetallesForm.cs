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
    public partial class DetallesForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        bool pagado;
        string tipoEstado;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        int idVehiculo = Program.GidVehiculo;
        public DetallesForm()
        {
            InitializeComponent();
        }

        private void DetallesForm_Load(object sender, EventArgs e)
        {
            ObtenerDetallesVehiculo();
            LLenarDtgComponentes();
            LLenarDtgGastos();
            LLenarDtgAduanales();
            CalcularTotales();
            Permisos();
        }
        public void LLenarDtgComponentes()
        {

            DataTable dt = new DataTable();
            Componentes_dtg.DataSource = null;
            P.IdVehiculo = idVehiculo;
            dt = P.ObtenerComponentesVehiculoEspecifico();
            Componentes_dtg.DataSource = dt;
            Componentes_dtg.Columns[1].DefaultCellStyle.Format = "N2";
            Componentes_dtg.Columns[2].DefaultCellStyle.Format = "N2";
        }

        public void LLenarDtgGastos()
        {

            DataTable dt = new DataTable();
            gastos_dtg.DataSource = null;
            P.IdVehiculo = idVehiculo;
            dt = P.ObtenerGastosReparacionVehiculoEspecifico();
            gastos_dtg.DataSource = dt;
            gastos_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            gastos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
        }

        public void LLenarDtgAduanales()
        {

            DataTable dt = new DataTable();
            gastosAduanales_dtg.DataSource = null;
            P.IdVehiculo = idVehiculo;
            dt = P.ObtenerGastosAduanalesVehiculoEspecifico();
            gastosAduanales_dtg.DataSource = dt;
            gastosAduanales_dtg.Columns[1].DefaultCellStyle.Format = "N2";
            gastosAduanales_dtg.Columns[2].DefaultCellStyle.Format = "N2";
        }
        public void ObtenerDetallesVehiculo()
        {
            DataTable dt = new DataTable();

            P.Id = idVehiculo;
            dt = P.ObtenerVehiculoEspecifico();
            vehiculo_lbl.Text = dt.Rows[0]["FABRICANTE"].ToString() +" "+ dt.Rows[0]["MODELO"].ToString() + " " + dt.Rows[0]["AÑO"].ToString() + " " + dt.Rows[0]["COLOR"].ToString();
            Program.GnombreVehiculo = vehiculo_lbl.Text;
            detalles_lbl.Text = dt.Rows[0]["DETALLES"].ToString();
            propietario_lbl.Text = dt.Rows[0]["PROPIETARIO"].ToString();
            fechaImporte_lbl.Text = dt.Rows[0]["FECHA COMPRADO"].ToString();
            precioRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
            precioUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
            vin_lbl.Text = dt.Rows[0]["VIN"].ToString();
            bool terminado = Convert.ToBoolean(dt.Rows[0]["TERMINADO"]);
            bool vendido = Convert.ToBoolean(dt.Rows[0]["VENDIDO"]);
            pagado = Convert.ToBoolean(dt.Rows[0]["PAGADO"]);
            ubicacion_lbl.Text = dt.Rows[0]["UBICACION"].ToString();
            matricula_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["MATRICULA ORIGINAL"]);
            cedula_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["CEDULA VENDEDOR"]);
            acto_venta_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["ACTO VENTA"]);
            estimadoRD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ESTIMADO RD"])).ToString("#,###.00");
            estimadoUSD_lbl.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ESTIMADO USD"])).ToString("#,###.00");

            if (!terminado)
            {
                VehiculoProceso();
            }

            else if (terminado && !vendido)
            {
                VehiculoTerminado();
            }
            else
            {
                actualizar_btn.Enabled = false;
                VehiculoVendido();
            }



        }

        public void VehiculoProceso()
        {
            finalizarVenderProceso_btn.Text = "Marcar Terminado";
            finalizarVenderProceso_btn.Image = Properties.Resources.icon__2_;
            tipoEstado = "terminar";
            estado_lbl.Text = "En Proceso";
        }
        public void VehiculoTerminado()
        {
            //finalizarVenderProceso_btn.Text = "Marcar Vendido";
            //finalizarVenderProceso_btn.Image = Properties.Resources.personas_comerciando;
            //tipoEstado = "vender";
            finalizarVenderProceso_btn.Visible = false;
            estado_lbl.Text = "Terminado";
        }

        public void VehiculoVendido()
        {
            finalizarVenderProceso_btn.Text = "Marcar En Proceso";
            finalizarVenderProceso_btn.Image = Properties.Resources.icon__3_;
            tipoEstado = "en proceso";
            estado_lbl.Text = "Vendido";
            finalizarVenderProceso_btn.Hide();
            //agregarComponente_btn.Enabled = false;
            //agregarGastos_btn.Enabled = false;
            //agregarGastosAduana_btn.Enabled = false;
            //eliminarComponente_btn.Enabled = false;
            //eliminarGastos_btn.Enabled = false;
            //eliminarGastoAduana_btn.Enabled = false;
            
            pagos_btn.Visible = true;
            
            if (pagado)
            {
                
                pagos_btn.Text = "Ver Pagos";
            }
            else
            {
                
                pagos_btn.Text = "Pagar";
            }
            ObtenerTotalPagado();
            


        }

        private void agregarComponente_btn_Click(object sender, EventArgs e)
        {
            Program.GidVehiculo2 = idVehiculo;
            Program.Gventana = "componentes";
            AbrirVentanaAgregarComponentesGastos();
        }

        private void agregarGastos_btn_Click(object sender, EventArgs e)
        {
            Program.GidVehiculo2 = idVehiculo;
            Program.Gventana = "reparacion";
            AbrirVentanaAgregarComponentesGastos();
        }

        public void AbrirVentanaAgregarComponentesGastos()
        {
            AgregarComponentesGastosVehiculoForm form = new AgregarComponentesGastosVehiculoForm();
            if (Program.Gventana == "componentes")
            {

                form.Text = "Agregar Piezas y Repuestos";
            }
            else
            {
                form.Text = "Agregar Gastos Generales";
            }
            form.ShowDialog();
            LLenarDtgComponentes();
            LLenarDtgGastos();
            LLenarDtgAduanales();
            CalcularTotales();
        }

        public void CalcularTotales()
        {
            double gastoAdu_sub_totalRD = 0;
            double gastoAdu_sub_totalUSD = 0;

            double gastoRep_sub_totalRD = 0;
            double gastoRep_sub_totalUSD = 0;

            double componente_sub_totalRD = 0;
            double componente_sub_totalUSD = 0;

            double totalRD = 0;
            double totalUSD = 0;
            if (Componentes_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Componentes_dtg.Rows)
                {
                   componente_sub_totalRD += Convert.ToDouble(row.Cells[1].Value);
                   componente_sub_totalUSD+= Convert.ToDouble(row.Cells[2].Value);

                }
                subTotalCompRD_lbl.Text = componente_sub_totalRD.ToString("N2");
                subTotalCompUSD_lbl.Text = componente_sub_totalUSD.ToString("N2");
            }
            else
            {
                subTotalCompRD_lbl.Text = "0.00";
                subTotalCompUSD_lbl.Text = "0.00";
            }

            if (gastos_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gastos_dtg.Rows)
                {
                    gastoRep_sub_totalRD += Convert.ToDouble(row.Cells[2].Value);
                    gastoRep_sub_totalUSD += Convert.ToDouble(row.Cells[3].Value);

                }
                subTotalGastoRD_lbl.Text = gastoRep_sub_totalRD.ToString("N2");
                subTotalGastoUSD_lbl.Text = gastoRep_sub_totalUSD.ToString("N2");
            }
            else
            {
                subTotalGastoRD_lbl.Text = "0.00";
                subTotalGastoUSD_lbl.Text = "0.00";
            }

            if (gastosAduanales_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gastosAduanales_dtg.Rows)
                {
                    gastoAdu_sub_totalRD += Convert.ToDouble(row.Cells[2].Value);
                    gastoAdu_sub_totalUSD += Convert.ToDouble(row.Cells[3].Value);

                }
                subTotalAduanaRD_lbl.Text = gastoAdu_sub_totalRD.ToString("N2");
                subTotalAduanaUSD_lbl.Text = gastoAdu_sub_totalUSD.ToString("N2");
            }
            else
            {
                subTotalAduanaRD_lbl.Text = "0.00";
                subTotalAduanaUSD_lbl.Text = "0.00";
            }



            totalRD = componente_sub_totalRD + gastoRep_sub_totalRD + gastoAdu_sub_totalRD;
            totalUSD = componente_sub_totalUSD + gastoRep_sub_totalUSD + gastoAdu_sub_totalUSD;

            totalRD_lbl.Text = totalRD.ToString("N2");
            totalUSD_lbl.Text = totalUSD.ToString("N2");

            RD_costo_total_lbl.Text = (Convert.ToDouble(totalRD_lbl.Text) + Convert.ToDouble(precioRD_lbl.Text)).ToString("N2");
            USD_costo_total_lbl.Text = (Convert.ToDouble(totalUSD_lbl.Text) + Convert.ToDouble(precioUSD_lbl.Text)).ToString("N2");

            double precioSinGananciaRD = totalRD + Convert.ToDouble(precioRD_lbl.Text);
            double precioSinGananciaUSD = totalUSD + Convert.ToDouble(precioUSD_lbl.Text);
            

        }
        public void updateBtn()
        {
            //if(tipoEstado == "vender")
            //{
            //    VehiculoVendido();
            //}
            if (tipoEstado == "terminar")
            {
                VehiculoTerminado();
            }
            else
            {
                VehiculoProceso();
            }
        }

        private void finalizarVenderProceso_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                P.IdVehiculo = idVehiculo;
                P.Tipo = tipoEstado;
                if (tipoEstado != "vender")
                {
                    string msj = P.CambiarEstadosVehiculo();
                    if (msj == "1")
                    {
                        MessageBox.Show("Estado del vehículo fue sido actualizado correctamente", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateBtn();
                        ObtenerDetallesVehiculo();
                    }
                    else
                    {
                        MessageBox.Show("Estado del vehículo no pudo ser actualizado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenerDetallesVehiculo();
                    }
                }
                else
                {
                    VenderForm form = new VenderForm();
                    form.ShowDialog();
                    ObtenerDetallesVehiculo();
                    //string msj = P.CambiarEstadosVehiculo();
                    //if (msj == "1")
                    //{
                    //    MessageBox.Show("Estado del vehículo fue sido actualizado correctamente", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    updateBtn();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Estado del vehículo no pudo ser actualizado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //}
                    //P.IdVehiculo = idVehiculo;
                    //string msj = P.InsertarFactura();
                    //if(msj == "1")
                    //{
                    //    Program.GidVehiculoRpt = idVehiculo;
                    //    Program.Greporte = "Factura Venta Vehículo";
                    //    ReportesForm form1 = new ReportesForm();
                    //    form1.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No se pudo crear factura del vehículo vendido", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //}

                }
            }
            
            
        }

        private void eliminarGastos_btn_Click(object sender, EventArgs e)
        {
            if(gastos_dtg.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar? Esta Acción Elimina Cuenta por Pagar si Existe", Program.Gtitulo, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    P.Id = Convert.ToInt32(gastos_dtg.CurrentRow.Cells[4].Value);
                    P.IdVehiculo = idVehiculo;
                    string msj = P.EliminarGastoReparacionVehiculo();
                    if (msj == "1")
                    {
                        MessageBox.Show("Gasto Reparación Eliminado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LLenarDtgGastos();
                        CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("Gasto Reparación no pudo ser eliminado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
                
            }
            
        }

        private void eliminarComponente_btn_Click(object sender, EventArgs e)
        {
            if (Componentes_dtg.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar? Esta Acción Elimina cuenta por Pagar si Existe", Program.Gtitulo, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    P.Id = Convert.ToInt32(Componentes_dtg.CurrentRow.Cells[3].Value);
                    P.IdVehiculo = idVehiculo;
                    string msj = P.EliminarComponenteVehiculo();
                    if (msj == "1")
                    {
                        MessageBox.Show("Pieza o repuesto Eliminado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LLenarDtgGastos();
                        CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("Pieza o repuesto no pudo ser eliminado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                    
            }
            LLenarDtgComponentes();
            LLenarDtgGastos();
            LLenarDtgAduanales();
            CalcularTotales();
        }

        private void pagos_btn_Click(object sender, EventArgs e)
        {
           PagosCuentasPagarForm form = new PagosCuentasPagarForm();
            form.ShowDialog();
            ObtenerDetallesVehiculo();

        }

        private void agregarGastosAduana_btn_Click(object sender, EventArgs e)
        {
            Program.GidVehiculo2 = idVehiculo;
            Program.Gventana = "aduanas";
            AbrirVentanaAgregarComponentesGastos();
        }

        private void eliminarGastoAduana_btn_Click(object sender, EventArgs e)
        {
            if (gastosAduanales_dtg.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar? Esta Acción Elimina cuenta por Pagar si Existe", Program.Gtitulo, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    P.Id = Convert.ToInt32(gastosAduanales_dtg.CurrentRow.Cells[4].Value);
                    P.IdVehiculo = idVehiculo;
                    string msj = P.EliminarGastoAduanalVehiculo();
                    if (msj == "1")
                    {
                        MessageBox.Show("Eliminado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LLenarDtgAduanales();
                        CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("No se Pudo eliminar Registro!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
        }

        public void Permisos()
        {
            bool permiso = GF.ValidarPermisoTransaccion("AGREGAR PIEZAS A VEHICULO");
            if (!permiso)
            {
                agregarComponente_btn.Enabled = false;
                eliminarComponente_btn.Enabled = false;
            }

            permiso = GF.ValidarPermisoTransaccion("AGREGAR GASTO A VEHICULO");
            if (!permiso)
            {
                agregarGastosAduana_btn.Enabled = false;
                agregarGastos_btn.Enabled = false;

                eliminarGastoAduana_btn.Enabled = false;
                eliminarGastos_btn.Enabled = false;

            }

            permiso = GF.ValidarPermisoTransaccion("CAMBIAR ESTADO VEHICULOS");
            if (!permiso)
            {
                finalizarVenderProceso_btn.Enabled = false;
                

            }

            permiso = GF.ValidarPermisoTransaccion("MODIFICAR VEHICULO");
            if (!permiso)
            {

                actualizar_btn.Enabled = false;

            }
        }

        private void actualizar_btn_Click(object sender, EventArgs e)
        {
            Program.VerDetalles = false;
            ModificarVehiculoForm form = new ModificarVehiculoForm();
            form.ShowDialog();
            ObtenerDetallesVehiculo();
            LLenarDtgComponentes();
            LLenarDtgGastos();
            LLenarDtgAduanales();
            CalcularTotales();
            Permisos();
        }

        public void ObtenerTotalPagado()
        {
            DataTable dt = new DataTable();
            P.IdVehiculo = idVehiculo;
            dt = P.ObtenerPagosVehiculo();
            double pagoRD = 0;
            double pagoUSD = 0;
            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pagoRD += Convert.ToDouble(dt.Rows[i]["PAGO($RD)"]);
                    pagoUSD += Convert.ToDouble(dt.Rows[i]["PAGO($USD)"]);
                }
                //pagadoRD_lbl.Text = pagoRD.ToString("N2");
                //pagadoUSD_lbl.Text = pagoUSD.ToString("N2");
               
            }
            else
            {
                //pagadoRD_lbl.Text = "0.00";
                //pagadoUSD_lbl.Text = "0.00";
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Componentes_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.VerDetalles = true;
            
            ModificarVehiculoForm form = new ModificarVehiculoForm();
            form.ShowDialog();
            ObtenerDetallesVehiculo();
            LLenarDtgComponentes();
            LLenarDtgGastos();
            LLenarDtgAduanales();
            CalcularTotales();
            Permisos();
        }
    }
}
