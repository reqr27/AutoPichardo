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
    public partial class ImporteForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool evento = false;
        public int idEvento = 0;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public ImporteForm()
        {
            InitializeComponent();
        }

        private void ImporteForm_Load(object sender, EventArgs e)
        {
            habilitar_btn.Enabled = false;
            desde_dtp.Value = DateTime.Now.Date.AddYears(-1);
            hasta_dtp.Value = DateTime.Now.Date;
            LlenarDtgVehiculos();
            Permisos();
            CalcularTotal();
        }

        public void LlenarDtgVehiculos()
        {
            DataTable dt = new DataTable();
            vehiculos_dtg.DataSource = null;
            P.Desde = Convert.ToDateTime(desde_dtp.Value);
            P.Hasta = Convert.ToDateTime(hasta_dtp.Value);
            if (proceso_radioBtn.Checked)
            {
                P.Tipo = "proceso";
                dt = P.ObtenerVehiculos();
                vehiculos_dtg.DataSource = dt;
            }
            
            else if (terminados_radioBtn.Checked)
            {
                P.Tipo = "terminado";
                dt = P.ObtenerVehiculos();
                vehiculos_dtg.DataSource = dt;
            }

            else if (deshabilitados_radiobtn.Checked)
            {
                P.Tipo = "deshabilitado";
                dt = P.ObtenerVehiculos();
                vehiculos_dtg.DataSource = dt;
            }
            else
            {
                P.Tipo = "vendido";
                dt = P.ObtenerVehiculos();
                vehiculos_dtg.DataSource = dt;
                vehiculos_dtg.Columns[13].Visible = false;
                //IdentificarPagadoNoPagado();
            }
            vehiculos_dtg.Columns[5].DefaultCellStyle.Format = "N2";
            vehiculos_dtg.Columns[6].DefaultCellStyle.Format = "N2";
            vehiculos_dtg.Columns[7].DefaultCellStyle.Format = "N2";
            vehiculos_dtg.Columns[8].DefaultCellStyle.Format = "N2";

        }

        private void nuevoVehiculo_btn_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["NuevoVehiculoForm"];

            if (fc != null)
            {
                fc.BringToFront();
                
            }
            else
            {
                NuevoVehiculoForm form = new NuevoVehiculoForm();
                form.ShowDialog();
                proceso_radioBtn.Checked = true;
                LlenarDtgVehiculos();
            }
            
           
        }

        private void proceso_radioBtn_CheckedChanged(object sender, EventArgs e)
        {

            LlenarDtgVehiculos();
            CalcularTotal();
            if (vendidos_radioBtn.Checked)
            {
                habilitar_btn.Enabled = false;
                deshabilitar_btn.Enabled = false;
                leyenda_panel.Visible = true;
                verDetalles_btn.Enabled = true;
                //editar_btn.Enabled = false;
            }
            else if (deshabilitados_radiobtn.Checked)
            {
                verDetalles_btn.Enabled = false;
                deshabilitar_btn.Enabled = false;
                //editar_btn.Enabled = false;
                habilitar_btn.Enabled = true;
                leyenda_panel.Visible = false;
            }
            else
            {
                habilitar_btn.Enabled = false;
                deshabilitar_btn.Enabled = true;
                //editar_btn.Enabled = true;
                verDetalles_btn.Enabled = true;
                leyenda_panel.Visible = false;
            }
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            LlenarDtgVehiculos();
        }

        public void IdentificarPagadoNoPagado()
        {
            if (vendidos_radioBtn.Checked)
            {
                foreach (DataGridViewRow row in vehiculos_dtg.Rows)
                    if (!Convert.ToBoolean(row.Cells[13].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
            }
            
        }

        private void deshabilitar_btn_Click(object sender, EventArgs e)
        {
            DeshabilitarVehiculo();
        }

        public void DeshabilitarVehiculo()
        {
            if(vehiculos_dtg.Rows.Count > 0)
            {
                P.Id = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value);


                string respuesta = P.DeshabilitarVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Vehículo fue Deshabilitado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDtgVehiculos();

                }

                else
                {
                    MessageBox.Show("Vehículo no pudo ser deshabilitado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        public void HabilitarVehiculo()
        {
            if(vehiculos_dtg.Rows.Count > 0)
            {
                P.Id = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value);


                string respuesta = P.HabilitarVehiculo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Vehículo fue Habilitado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDtgVehiculos();

                }

                else
                {
                    MessageBox.Show("Vehículo no pudo ser Habilitado", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }


        private void habilitar_btn_Click(object sender, EventArgs e)
        {
            HabilitarVehiculo();
        }

        private void verDetalles_btn_Click(object sender, EventArgs e)
        {
            if(vehiculos_dtg.Rows.Count > 0)
            {
                Program.GidVehiculo =Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value);
                DetallesForm form = new DetallesForm();
                form.ShowDialog();
                LlenarDtgVehiculos();
                //IdentificarPagadoNoPagado();
                CalcularTotal();
            }
        }

        public void Permisos()
        {
            bool permiso = GF.ValidarPermisoTransaccion("DESHABILITAR VEHICULOS");
            if (!permiso)
            {
                deshabilitar_btn.Enabled = false;
            }
        }

        private void vehiculos_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.GidVehiculo = Convert.ToInt32(vehiculos_dtg.CurrentRow.Cells[0].Value);
            DetallesForm form = new DetallesForm();
            form.ShowDialog();
            LlenarDtgVehiculos();
            CalcularTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void CalcularTotal()
        {
            double totalRD = 0;
            double totalUSD = 0;
            if (vehiculos_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in vehiculos_dtg.Rows)
                {
                    totalRD += Convert.ToDouble(row.Cells[5].Value);
                    totalUSD += Convert.ToDouble(row.Cells[6].Value);


                }
                totalRD_lbl.Text = totalRD.ToString("N2");
                totalUSD_lbl.Text = totalUSD.ToString("N2");



            }
            else
            {
                totalRD_lbl.Text = "0.00";
                totalUSD_lbl.Text = "0.00";

            }

            
        }

        private void hasta_dtp_ValueChanged(object sender, EventArgs e)
        {
            if (hasta_dtp.Value > DateTime.Now.Date)
            {
                hasta_dtp.Value = DateTime.Now.Date;
            }
            LlenarDtgVehiculos();
        }

        private void ImporteForm_FormClosed(object sender, FormClosedEventArgs e)
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
