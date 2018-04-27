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
    public partial class TalleresForm : Form
    {
        public bool evento = false;
        public int idEvento = 0;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public TalleresForm()
        {
            InitializeComponent();
        }

        public void LlenarDtgTalleres()
        {
            DataTable dt = new DataTable();
            talleres_dtg.DataSource = null;
            
            dt = P.ObtenerTalleres();
            talleres_dtg.DataSource = dt;
            
        }

        public void resetCampos()
        {
            cancelarEditar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            taller_txt.Text = "";
            direccion_txt.Text = "";
            telefono1_txt.Text = "";
            telefono2_txt.Text = "";
            estadoTaller_chbox.Checked = true;
            guardarTaller_btn.Text = "Guardar";
            guardarTaller_btn.Image = Properties.Resources.disquete;
            taller_txt.Focus();
        }
        private void guardarTaller_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                RegistrarTaller();
            }
            else
            {
                ActualizarTaller();
            }
        }

        public void RegistrarTaller()
        {
            string[] valores = { taller_txt.Text, direccion_txt.Text, };
            
            string msj = GF.ValidarCampoString(valores);
           
            if (msj != "OK")
            {
                MessageBox.Show("Campo Taller y Dirección son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                P.Taller = taller_txt.Text;
                P.Direccion = direccion_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Telefono2 = telefono2_txt.Text;
                P.Estado = estadoTaller_chbox.Checked;
               
                string respuesta = P.RegistrarTaller();
                if (respuesta == "1")
                {
                    MessageBox.Show("Taller o tienda fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgTalleres();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Taller o tienda ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Taller o tienda no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarTaller()
        {
            string[] valores = { taller_txt.Text, direccion_txt.Text, };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Campo Taller y Dirección son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Id = idEvento;
                P.Taller = taller_txt.Text;
                P.Direccion = direccion_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Telefono2 = telefono2_txt.Text;
                P.Estado = estadoTaller_chbox.Checked;

                string respuesta = P.ActualizarTaller();
                if (respuesta == "1")
                {
                    MessageBox.Show("Taller o tienda fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgTalleres();
                }
                
                else
                {
                    MessageBox.Show("Taller o tienda no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void TalleresForm_Load(object sender, EventArgs e)
        {

            LlenarDtgTalleres();
            resetCampos();
            guardarTaller_btn.NotifyDefault(false);

        }

        private void talleres_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarEditar_btn.Enabled = true;
            evento = true;
           
            
            guardarTaller_btn.Text = "Actualizar";
            guardarTaller_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(talleres_dtg.CurrentRow.Cells[0].Value.ToString());
            taller_txt.Text = talleres_dtg.CurrentRow.Cells[1].Value.ToString();
            direccion_txt.Text = talleres_dtg.CurrentRow.Cells[2].Value.ToString();
            telefono1_txt.Text = talleres_dtg.CurrentRow.Cells[3].Value.ToString();
            telefono2_txt.Text = talleres_dtg.CurrentRow.Cells[4].Value.ToString();
            estadoTaller_chbox.Checked = Convert.ToBoolean(talleres_dtg.CurrentRow.Cells[5].Value);
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }
    }
}
