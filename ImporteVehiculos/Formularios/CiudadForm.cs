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
    public partial class CiudadForm : Form
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

        public CiudadForm()
        {
            InitializeComponent();
        }

        private void CiudadForm_Load(object sender, EventArgs e)
        {
            
            LLenarPaisesCB();
            pais_cb.Focus();
            agregar_btn.NotifyDefault(false);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
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

        public void LlenarDtgCiudad()
        {
            ciudades_dtg.DataSource = null;
            P.IdPais = Convert.ToInt32(pais_cb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            dt = P.ObtenerTodosCiudades();
            ciudades_dtg.DataSource = dt;

        }

        private void pais_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pais_cb.SelectedIndex != -1 && fillCombo)
            {
                LlenarDtgCiudad();

            }
        }

        public void resetCampos()
        {
            cancelar_btn.Enabled = false;
            estadoCiudad_chbox.Checked = true;
            ciudad_txt.Text = "";
            pais_cb.Enabled = true;
            idEvento = 0;
            evento = false;
            agregar_btn.Text = "Registrar";
            agregar_btn.Image = Properties.Resources.disquete;
            pais_cb.Focus();
            
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarCiudad();
            }
            else
            {
                ActualizarCiudad();
            }
        }

        public void registrarCiudad()
        {
            string[] valores = { ciudad_txt.Text, pais_cb.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.EstadoCiudad= estadoCiudad_chbox.Checked;
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.Ciudad = ciudad_txt.Text;

                string respuesta = P.RegistrarCiudad();
                if (respuesta == "1")
                {
                    MessageBox.Show("Ciudad fue Registrada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgCiudad();
                }
                else
                {
                    MessageBox.Show("Ciudad no pudo ser registrada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarCiudad()
        {
            string[] valores = { ciudad_txt.Text, pais_cb.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdCiudad = idEvento;
                P.EstadoCiudad = estadoCiudad_chbox.Checked;
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.Ciudad = ciudad_txt.Text;

                string respuesta = P.ActualizarCiudad();
                if (respuesta == "1")
                {
                    MessageBox.Show("Ciudad fue Actualizada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgCiudad();
                }
                else
                {
                    MessageBox.Show("Ciudad no pudo ser actualizada!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ciudades_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pais_cb.Enabled = false;
            cancelar_btn.Enabled = true;
            evento = true;
            agregar_btn.Text = "Actualizar";
            agregar_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(ciudades_dtg.CurrentRow.Cells[0].Value.ToString());
            ciudad_txt.Text =ciudades_dtg.CurrentRow.Cells[1].Value.ToString();
            estadoCiudad_chbox.Checked = Convert.ToBoolean(ciudades_dtg.CurrentRow.Cells[2].Value.ToString());

        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void pais_cb_DropDown(object sender, EventArgs e)
        {
            LLenarPaisesCB();
        }
    }
}
