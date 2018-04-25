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
    public partial class ModificarVehiculoForm : Form
    {
        public double PrecioCompraRD;
        public double PrecioCompraUSD;
        public double PrecioVentaEstimadoRD;
        public double PrecioVentaEstimadoUSD;
        public bool verDetalles = Program.VerDetalles;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool fillCombo = false;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public ModificarVehiculoForm()
        {
            InitializeComponent();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            ActualizarVehiculo();
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

        public void ActualizarVehiculo()
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            string[] valores = { propietario_cb.Text, vin_txt.Text, color_cb.Text, nota_txt.Text, ubicacion_cb.Text, millaje_txt.Text, fuerzaMotriz_txt.Text,
            placa_txt.Text, matricula_txt.Text,ubicacion_cb.Text, suplidor_cb.Text};
            string[] numeros = {año_cb.Text, precio_estimado_venta_txt.Text};
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Precio Estimado y Precio Compra sólo permiten números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdVehiculo = Program.GidVehiculo;
                P.Nota = nota_txt.Text;
                P.IdPropietario = Convert.ToInt32(propietario_cb.SelectedValue);
                P.Vin = vin_txt.Text;
               
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
                P.Año = Convert.ToInt32(año_cb.Text);
                P.Fecha = fecha_dtp.Value;

                if (radioBtnRD_precio.Checked)
                {
                    P.PrecioVentaEstimadoRD = Convert.ToDouble(precio_estimado_venta_txt.Text);
                    P.PrecioVentaEstimadoUSD = Convert.ToDouble(precio_estimado_venta_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                }
                else
                {
                    P.PrecioVentaEstimadoUSD = Convert.ToDouble(precio_estimado_venta_txt.Text);
                    P.PrecioVentaEstimadoRD = Convert.ToDouble(precio_estimado_venta_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                }


                string respuesta = P.ActualizarVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Vehículo fue Modificado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Vehículo no pudo ser Modificado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }
        }

        private void ModificarVehiculoForm_Load(object sender, EventArgs e)
        {
            LlenarDtgUbicacionesHist();
            Permisos();
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            LLenarPropietarioCb();
            LlenarAñoCb();
            LLenarSuplidorCb();
            LLenarUbicacionCb();
            LLenarColoresCb();
            ObtenerDetallesVehiculo();
            if (verDetalles)
            {
                VerTodosDetallesVentana();
            }

        }

        public void LlenarDtgUbicacionesHist()
        {
            DataTable dt = new DataTable();
            ubicacionesHist_dtg.DataSource = null;

            P.IdVehiculo = Program.GidVehiculo;
            dt = P.ObtenerHistorialUbicacion();
            ubicacionesHist_dtg.DataSource = dt;

        }

        public void VerTodosDetallesVentana()
        {
            this.Text = "DETALLES VEHICULO";
            label11.Text = "TODOS LOS DETALLES";
            //foreach (Control c in this.Controls)
            //{
            //    c.Enabled = false;
            //}
            EnableControls(button2);
            EnableControls(button3);
            guardar_btn.Visible = false;
            cancelar_btn.Visible = false;
            panel1.BackColor = ColorTranslator.FromHtml("#2980b9");
            panel2.BackColor = ColorTranslator.FromHtml("#2980b9");


        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
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

        public void ObtenerDetallesVehiculo()
        {
            DataTable dt = new DataTable();

            P.Id = Program.GidVehiculo;
            dt = P.ObtenerVehiculoEspecifico();
            vin_txt.Text = dt.Rows[0]["VIN"].ToString();
            color_cb.Text = dt.Rows[0]["COLOR"].ToString();
            nota_txt.Text = dt.Rows[0]["DETALLES"].ToString();
            propietario_cb.Text = dt.Rows[0]["PROPIETARIO"].ToString();
            ubicacion_cb.Text = dt.Rows[0]["UBICACION"].ToString();
            mat_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["MATRICULA ORIGINAL"]);
            cedula_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["CEDULA VENDEDOR"]);
            acto_venta_chbox.Checked = Convert.ToBoolean(dt.Rows[0]["ACTO VENTA"]);
            nombreV_lbl.Text = dt.Rows[0]["FABRICANTE"].ToString() + " " + dt.Rows[0]["MODELO"].ToString() + " " + dt.Rows[0]["AÑO"].ToString();
            placa_txt.Text = dt.Rows[0]["PLACA"].ToString();
            millaje_txt.Text = dt.Rows[0]["MILLAJE"].ToString();
            fuerzaMotriz_txt.Text = dt.Rows[0]["FUERZA MOTRIZ"].ToString();
            PrecioCompraRD = Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"].ToString());
            PrecioCompraUSD = Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"].ToString());
            PrecioVentaEstimadoRD = Convert.ToDouble(dt.Rows[0]["PRECIO ESTIMADO RD"].ToString());
            PrecioVentaEstimadoUSD = Convert.ToDouble(dt.Rows[0]["PRECIO ESTIMADO USD"].ToString());
            precio_estimado_venta_txt.Text = PrecioVentaEstimadoRD.ToString();
            matricula_txt.Text = dt.Rows[0]["NUMERO MATRICULA"].ToString();
            suplidor_cb.Text = dt.Rows[0]["SUPLIDOR"].ToString();
            año_cb.Text = dt.Rows[0]["AÑO"].ToString();



        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void radioBtnRD_precio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRD_precio.Checked)
            {
                precio_estimado_venta_txt.Text = PrecioVentaEstimadoRD.ToString();
            }
            else
            {
                precio_estimado_venta_txt.Text = PrecioVentaEstimadoUSD.ToString();
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
    }
}
