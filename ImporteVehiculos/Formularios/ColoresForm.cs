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
    public partial class ColoresForm : Form
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

        public ColoresForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ColoresForm_Load(object sender, EventArgs e)
        {
            LlenarDtgColor();
            agregar_btn.NotifyDefault(false);
            color_txt.Focus();
        }

        public void LlenarDtgColor()
        {
            colores_dtg.DataSource = null;

            DataTable dt = new DataTable();
            dt = P.ObtenerTodosColores();
            colores_dtg.DataSource = dt;

        }

        public void resetCampos()
        {
            cancelar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            estadoColor_chbox.Checked = true;
            color_txt.Text = "";
            agregar_btn.Text = "Registrar";
            agregar_btn.Image = Properties.Resources.disquete;
            color_txt.Focus();
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarColor();
            }
            else
            {
                ActualizarColor();
            }
        }

        public void registrarColor()
        {
            string[] valores = { color_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.EstadoColor = estadoColor_chbox.Checked;
                P.Color = color_txt.Text;

                string respuesta = P.RegistrarColor();
                if (respuesta == "1")
                {
                    MessageBox.Show("Color fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgColor();
                }
                else
                {
                    MessageBox.Show("Color no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarColor()
        {
            string[] valores = { color_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdColor = idEvento;
                P.EstadoColor = estadoColor_chbox.Checked;
                P.Color = color_txt.Text;

                string respuesta = P.ActualizarColor();
                if (respuesta == "1")
                {
                    MessageBox.Show("Color fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgColor();
                }
                else
                {
                    MessageBox.Show("Color no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void colores_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelar_btn.Enabled = true;
            evento = true;
            agregar_btn.Text = "Actualizar";
            agregar_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(colores_dtg.CurrentRow.Cells[0].Value.ToString());
            color_txt.Text = colores_dtg.CurrentRow.Cells[1].Value.ToString();
            estadoColor_chbox.Checked = Convert.ToBoolean(colores_dtg.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
