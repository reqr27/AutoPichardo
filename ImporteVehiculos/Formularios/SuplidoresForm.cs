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
    public partial class SuplidoresForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        bool fillCombo = false;
        bool evento = false;
        int idEvento = 0;
        GlobalFunctions GF = new GlobalFunctions();
        Procedimientos P = new Procedimientos();

        public SuplidoresForm()
        {
            InitializeComponent();
        }

        private void SuplidoresForm_Load(object sender, EventArgs e)
        {
            LLenarPaisesCB();
            LlenarDtgSuplidores();

        }

        private void SuplidoresForm_MouseDown(object sender, MouseEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void resetCampos()
        {
            suplidor_txt.Text = "";
            ciudad_cb.DataSource = null;
            pais_cb.SelectedIndex = -1;
            cancelar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            estado_chbox.Checked = true;
            direccion_txt.Text = "";
            rncCedula_txt.Text = "";
            telefono1_txt.Text = "";
            agregar_btn.Text = "Registrar";
            agregar_btn.Image = Properties.Resources.disquete;
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

        public void LlenarDtgSuplidores()
        {
            DataTable dt = new DataTable();
            suplidores_dtg.DataSource = null;

            dt = P.ObtenerTodosSuplidores();
            suplidores_dtg.DataSource = dt;

        }

        private void pais_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pais_cb.SelectedIndex != -1 && fillCombo)
            {
                LLenarCiudadCB();

            }
        }

        private void ubicaciones_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelar_btn.Enabled = true;
            evento = true;
            agregar_btn.Text = "Actualizar";
            agregar_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(suplidores_dtg.CurrentRow.Cells[0].Value.ToString());
            suplidor_txt.Text = suplidores_dtg.CurrentRow.Cells[1].Value.ToString();
            rncCedula_txt.Text = suplidores_dtg.CurrentRow.Cells[2].Value.ToString();
            pais_cb.Text = suplidores_dtg.CurrentRow.Cells[3].Value.ToString();
            ciudad_cb.Text = suplidores_dtg.CurrentRow.Cells[4].Value.ToString();
            direccion_txt.Text = suplidores_dtg.CurrentRow.Cells[5].Value.ToString();
            telefono1_txt.Text = suplidores_dtg.CurrentRow.Cells[6].Value.ToString();
            estado_chbox.Checked = Convert.ToBoolean(suplidores_dtg.CurrentRow.Cells[7].Value.ToString());

        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarSuplidor();
            }
            else
            {
                ActualizarSuplidor();
            }
        }

        public void registrarSuplidor()
        {
            string[] valores = { suplidor_txt.Text, rncCedula_txt.Text,ciudad_cb.Text, pais_cb.Text, direccion_txt.Text, telefono1_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.Suplidor = suplidor_txt.Text;
                P.CedulaRNC = rncCedula_txt.Text;
                P.IdCiudad = Convert.ToInt32(ciudad_cb.SelectedValue);
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.Direccion = direccion_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.EstadoSuplidor = estado_chbox.Checked;


                string respuesta = P.RegistrarSuplidor();
                if (respuesta == "1")
                {
                    MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgSuplidores();
                }
                else
                {
                    MessageBox.Show("Error registrando!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarSuplidor()
        {
            string[] valores = { suplidor_txt.Text, rncCedula_txt.Text, ciudad_cb.Text, pais_cb.Text, direccion_txt.Text, telefono1_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.Suplidor = suplidor_txt.Text;
                P.CedulaRNC = rncCedula_txt.Text;
                P.IdCiudad = Convert.ToInt32(ciudad_cb.SelectedValue);
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.Direccion = direccion_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.EstadoSuplidor = estado_chbox.Checked;
                P.Id = idEvento;

                string respuesta = P.ActualizarSuplidor();
                if (respuesta == "1")
                {
                    MessageBox.Show("Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgSuplidores();
                }
                else
                {
                    MessageBox.Show("Error actualizando!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }
    }
}
