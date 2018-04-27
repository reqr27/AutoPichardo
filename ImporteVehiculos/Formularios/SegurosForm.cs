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
    public partial class SegurosForm : Form
    {

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

        public SegurosForm()
        {
            InitializeComponent();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void SegurosForm_Load(object sender, EventArgs e)
        {
            LlenarDtgSeguros();
            agregar_btn.NotifyDefault(false);
            seguro_txt.Focus();

        }

        public void LlenarDtgSeguros()
        {
            paises_dtg.DataSource = null;

            DataTable dt = new DataTable();
            dt = P.ObtenerTodosSeguros();
            paises_dtg.DataSource = dt;

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
            cancelar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            estadoPais_chbox.Checked = true;
            seguro_txt.Text = "";
            telefono_txt.Text = "";
            agregar_btn.Text = "Registrar";
            agregar_btn.Image = Properties.Resources.disquete;
            seguro_txt.Focus();
        }

        private void paises_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelar_btn.Enabled = true;
            evento = true;
            agregar_btn.Text = "Actualizar";
            agregar_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(paises_dtg.CurrentRow.Cells[0].Value.ToString());
            seguro_txt.Text = paises_dtg.CurrentRow.Cells[1].Value.ToString();
            telefono_txt.Text = paises_dtg.CurrentRow.Cells[2].Value.ToString();
            estadoPais_chbox.Checked = Convert.ToBoolean(paises_dtg.CurrentRow.Cells[3].Value.ToString());

        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarSeguro();
            }
            else
            {
                ActualizarSeguro();
            }
        }

        public void registrarSeguro()
        {
            string[] valores = { seguro_txt.Text,telefono_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.Estado = estadoPais_chbox.Checked;
                P.Nombre = seguro_txt.Text;
                P.Telefono1 = telefono_txt.Text;

                string respuesta = P.RegistrarSeguro();
                if (respuesta == "1")
                {
                    MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgSeguros();
                }
                else
                {
                    MessageBox.Show("Error registrando!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarSeguro()
        {
            string[] valores = { seguro_txt.Text,telefono_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.Id = idEvento;
                P.Estado = estadoPais_chbox.Checked;
                P.Nombre = seguro_txt.Text;
                P.Telefono1 = telefono_txt.Text;

                string respuesta = P.ActualizarSeguro();
                if (respuesta == "1")
                {
                    MessageBox.Show(" Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgSeguros();
                }
                else
                {
                    MessageBox.Show("Error actualizando!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
