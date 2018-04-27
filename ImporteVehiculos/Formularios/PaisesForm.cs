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
    public partial class PaisesForm : Form
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

        public PaisesForm()
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

        private void PaisesForm_Load(object sender, EventArgs e)
        {
            LlenarDtgPais();
        }

        public void LlenarDtgPais()
        {
            agregar_btn.NotifyDefault(false);
            paises_dtg.DataSource = null;

            DataTable dt = new DataTable();
            dt = P.ObtenerTodosPaises();
            paises_dtg.DataSource = dt;
            pais_txt.Focus();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void resetCampos()
        {
            cancelar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            estadoPais_chbox.Checked = true;
            pais_txt.Text = "";
            agregar_btn.Text = "Registrar";
            agregar_btn.Image = Properties.Resources.disquete;
            pais_txt.Focus();
        }

        private void paises_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelar_btn.Enabled = true;
            evento = true;
            agregar_btn.Text = "Actualizar";
            agregar_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(paises_dtg.CurrentRow.Cells[0].Value.ToString());
            pais_txt.Text = paises_dtg.CurrentRow.Cells[1].Value.ToString();
            estadoPais_chbox.Checked = Convert.ToBoolean(paises_dtg.CurrentRow.Cells[2].Value.ToString());

        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarPais();
            }
            else
            {
                ActualizarPais();
            }
        }

        public void registrarPais()
        {
            string[] valores = { pais_txt.Text};
           
            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.EstadoPais = estadoPais_chbox.Checked;
                P.Pais= pais_txt.Text;
                
                string respuesta = P.RegistrarPais();
                if (respuesta == "1")
                {
                    MessageBox.Show("País fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgPais();
                }
                else
                {
                    MessageBox.Show("País no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarPais()
        {
            string[] valores = { pais_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdPais = idEvento;
                P.EstadoPais = estadoPais_chbox.Checked;
                P.Pais = pais_txt.Text;

                string respuesta = P.ActualizarPais();
                if (respuesta == "1")
                {
                    MessageBox.Show("País fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgPais();
                }
                else
                {
                    MessageBox.Show("País no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }
    }
}
