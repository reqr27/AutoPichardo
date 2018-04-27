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
    public partial class UbicacionForm : Form
    {

        public bool fillCombo;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        bool evento = false;
        int idEvento = 0;
        GlobalFunctions GF = new GlobalFunctions();
        Procedimientos P = new Procedimientos();
        public UbicacionForm()
        {
            InitializeComponent();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void LLenarPaisesCB()
        {
            pais_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerPaisesActivos();
            pais_cb.DataSource = dt;
            pais_cb.DisplayMember = "PAIS";
            pais_cb.ValueMember = "ID";
            pais_cb.SelectedIndex = -1;
            fillCombo = true;

        }

        public void LLenarCiudadCB()
        {
            ciudad_cb.DataSource = null;
            DataTable dt = new DataTable();
            P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
            dt = P.ObtenerCiudadesActivos();
            ciudad_cb.DataSource = dt;
            ciudad_cb.DisplayMember = "CIUDAD";
            ciudad_cb.ValueMember = "ID";
            ciudad_cb.SelectedIndex = -1;


        }

        public void LlenarDtgUbicaciones()
        {
            DataTable dt = new DataTable();
            ubicaciones_dtg.DataSource = null;

            dt = P.ObtenerTodosUbicaciones();
            ubicaciones_dtg.DataSource = dt;

        }

        private void pais_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pais_cb.SelectedIndex != -1 && fillCombo)
            {
                LLenarCiudadCB();

            }
        }

        private void UbicacionForm_Load(object sender, EventArgs e)
        {
            LLenarPaisesCB();
            LlenarDtgUbicaciones();
            agregar_btn.NotifyDefault(false);
            pais_cb.Focus();
        }


        public void resetCampos()
        {
            ciudad_cb.DataSource = null;
            pais_cb.SelectedIndex = -1;
            cancelar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            estadoUbicacion_chbox.Checked = true;
            lugar_txt.Text = "";
            agregar_btn.Text = "Registrar";
            agregar_btn.Image = Properties.Resources.disquete;
            pais_cb.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ubicaciones_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelar_btn.Enabled = true;
            evento = true;
            agregar_btn.Text = "Actualizar";
            agregar_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(ubicaciones_dtg.CurrentRow.Cells[0].Value.ToString());
            pais_cb.Text = ubicaciones_dtg.CurrentRow.Cells[1].Value.ToString();
            ciudad_cb.Text = ubicaciones_dtg.CurrentRow.Cells[2].Value.ToString();
            lugar_txt.Text = ubicaciones_dtg.CurrentRow.Cells[3].Value.ToString();
            estadoUbicacion_chbox.Checked = Convert.ToBoolean(ubicaciones_dtg.CurrentRow.Cells[4].Value.ToString());
            
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarUbicacion();
            }
            else
            {
                ActualizarUbicacion();
            }
        }

        public void registrarUbicacion()
        {
            string[] valores = { lugar_txt.Text, ciudad_cb.Text, pais_cb.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.EstadoUbicacion = estadoUbicacion_chbox.Checked;
                P.Ubicacion = lugar_txt.Text;
                P.IdCiudad = Convert.ToInt32(ciudad_cb.SelectedValue);
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);


                string respuesta = P.RegistrarUbicacion();
                if (respuesta == "1")
                {
                    MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgUbicaciones();
                }
                else
                {
                    MessageBox.Show("Error registrando!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarUbicacion()
        {
            string[] valores = { lugar_txt.Text, pais_cb.Text, ciudad_cb.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.EstadoUbicacion = estadoUbicacion_chbox.Checked;
                P.Ubicacion = lugar_txt.Text;
                P.IdCiudad = Convert.ToInt32(ciudad_cb.SelectedValue);
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.IdUbicacion = idEvento;

                string respuesta = P.ActualizarUbicacion();
                if (respuesta == "1")
                {
                    MessageBox.Show("Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgUbicaciones();
                }
                else
                {
                    MessageBox.Show("Error actualizando!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void pais_cb_DropDown(object sender, EventArgs e)
        {
            LLenarPaisesCB();
        }

        private void ciudad_cb_DropDown(object sender, EventArgs e)
        {
            LLenarCiudadCB();
        }
    }
}
