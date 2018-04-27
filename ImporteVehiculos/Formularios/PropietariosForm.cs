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
    public partial class PropietariosForm : Form
    {
        public bool evento = false;
        public int idEvento = 0;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();

        public PropietariosForm()
        {
            InitializeComponent();
        }

        private void PropietariosForm_Load(object sender, EventArgs e)
        {
            guardarPropietario_btn.NotifyDefault(false);
            LlenarDtgPropietarios();
            resetCampos();
            propietario_txt.Focus();
        }

        public void LlenarDtgPropietarios()
        {
            DataTable dt = new DataTable();
            propietario_dtg.DataSource = null;

            dt = P.ObtenerPropietarios();
            propietario_dtg.DataSource = dt;

        }

        public void resetCampos()
        {
            cancelarEditar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            propietario_txt.Text = "";
            telefono1_txt.Text = "";
            direccion_txt.Text = "";
            rncCedula_txt.Text = "";

            estadoPropietario_chbox.Checked = true;
            guardarPropietario_btn.Text = "Guardar";
            guardarPropietario_btn.Image = Properties.Resources.disquete;
            propietario_txt.Focus();
        }

        private void guardarPropietario_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                RegistrarPropietarios();
            }
            else
            {
                ActualizarPropietarios();
            }
        }

        public void RegistrarPropietarios()
        {
            string[] valores = { propietario_txt.Text, telefono1_txt.Text, direccion_txt.Text, rncCedula_txt.Text};

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Propietario = propietario_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Estado = estadoPropietario_chbox.Checked;
                P.CedulaRNC = rncCedula_txt.Text;
                P.Direccion = direccion_txt.Text;

                string respuesta = P.RegistrarPropietario();
                if (respuesta == "1")
                {
                    MessageBox.Show("Propietario fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgPropietarios();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Propietario ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Propietario no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarPropietarios()
        {
            string[] valores = { propietario_txt.Text, telefono1_txt.Text, direccion_txt.Text, rncCedula_txt.Text };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Id = idEvento;
                P.Propietario = propietario_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Estado = estadoPropietario_chbox.Checked;
                P.CedulaRNC = rncCedula_txt.Text;
                P.Direccion = direccion_txt.Text;

                string respuesta = P.ActualizarPropietario();
                if (respuesta == "1")
                {
                    MessageBox.Show("Propietario fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgPropietarios();
                }
               
                else
                {
                    MessageBox.Show("Propietario no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void propietario_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarEditar_btn.Enabled = true;
            evento = true;
            guardarPropietario_btn.Text = "Actualizar";
            guardarPropietario_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(propietario_dtg.CurrentRow.Cells[0].Value.ToString());
            propietario_txt.Text = propietario_dtg.CurrentRow.Cells[1].Value.ToString();
            rncCedula_txt.Text = propietario_dtg.CurrentRow.Cells[2].Value.ToString();
            direccion_txt.Text = propietario_dtg.CurrentRow.Cells[3].Value.ToString();
            telefono1_txt.Text = propietario_dtg.CurrentRow.Cells[4].Value.ToString();

            estadoPropietario_chbox.Checked = Convert.ToBoolean(propietario_dtg.CurrentRow.Cells[5].Value);
        }
    }
}
