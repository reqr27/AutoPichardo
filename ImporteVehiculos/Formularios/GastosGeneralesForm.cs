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
    public partial class GastosGeneralesForm : Form
    {
        public bool evento = false;
        public int idEvento = 0;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public GastosGeneralesForm()
        {
            InitializeComponent();
        }

        private void GastosGeneralesForm_Load(object sender, EventArgs e)
        {
            LlenarDtgGastos();
        }

        public void LlenarDtgGastos()
        {
            DataTable dt = new DataTable();
            gastos_dtg.DataSource = null;

            dt = P.ObtenerGastos();
            gastos_dtg.DataSource = dt;

        }

        public void resetCampos()
        {
            cancelarEditar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            descripcionGasto_txt.Text = "";
            tipoGasto_cbox.SelectedIndex = -1;
           
            estadoGasto_chbox.Checked = true;
            guardarGasto_btn.Text = "Guardar";
            guardarGasto_btn.Image = Properties.Resources.disquete;
        }

        private void guardarGasto_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                RegistrarGasto();
            }
            else
            {
                ActualizarGasto();
            }
        }

        public void RegistrarGasto()
        {
            string[] valores = { descripcionGasto_txt.Text, tipoGasto_cbox.Text, };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos son necesarios son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Descripcion = descripcionGasto_txt.Text;
                P.Tipo = tipoGasto_cbox.Text;
                P.Estado = estadoGasto_chbox.Checked;

                string respuesta = P.RegistrarGastos();
                if (respuesta == "1")
                {
                    MessageBox.Show("Gasto fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgGastos();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Gasto  ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Gasto no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarGasto()
        {
            string[] valores = { descripcionGasto_txt.Text, tipoGasto_cbox.Text, };

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos son necesarios son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Id = idEvento;
                P.Descripcion = descripcionGasto_txt.Text;
                P.Tipo = tipoGasto_cbox.Text;
                P.Estado = estadoGasto_chbox.Checked;

                string respuesta = P.ActualizarGastos();
                if (respuesta == "1")
                {
                    MessageBox.Show("Gasto fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgGastos();
                }
               
                else
                {
                    MessageBox.Show("Gasto no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void gastos_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarEditar_btn.Enabled = true;
            evento = true;


            guardarGasto_btn.Text = "Actualizar";
            guardarGasto_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(gastos_dtg.CurrentRow.Cells[0].Value.ToString());
            descripcionGasto_txt.Text = gastos_dtg.CurrentRow.Cells[1].Value.ToString();
            tipoGasto_cbox.Text = gastos_dtg.CurrentRow.Cells[2].Value.ToString();
            
            estadoGasto_chbox.Checked = Convert.ToBoolean(gastos_dtg.CurrentRow.Cells[3].Value);
        }
    }
}
