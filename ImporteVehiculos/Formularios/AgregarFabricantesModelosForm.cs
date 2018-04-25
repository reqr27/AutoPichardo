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
    public partial class AgregarFabricantesModelosForm : Form
    {
        public int idEvento = 0;
        public bool evento = false;
        public bool comboFilled = false;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public AgregarFabricantesModelosForm()
        {
            InitializeComponent();
        }

        private void AgregarFabricantesModelosForm_Load(object sender, EventArgs e)
        {

            hidePanels();
            
            fabricantes_panel.Visible = true;
            LlenarDtgFabricantesModelos();
        }

        public void LlenarDtgFabricantesModelos()
        {
            
            if (fabricante_radiobtn.Checked)
            {
                DataTable dt = new DataTable();
                fabricantesModelos_dtg.DataSource = null;
                
                dt = P.ObtenerTodosFabricantes();
                fabricantesModelos_dtg.DataSource = dt;
            }
            else 
            {
                if (comboFilled && fabricante_cbox.SelectedIndex != -1)
                {
                    fabricantesModelos_dtg.DataSource = null;
                    DataTable dt = new DataTable();

                    P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue.ToString());
                    dt = P.ObtenerModelosFabricante();
                    fabricantesModelos_dtg.DataSource = dt;
                }
                



            }
            
            
            //vehiculos_dtg.Columns[4].DefaultCellStyle.Format = "/yyyy";
        }
        public void resetCampos()
        {
            if (fabricante_radiobtn.Checked)
            {
                fabricante_txt.Text = "";
                codigoFabricante_txt.Text = "";
                estadoFabricante_chbox.Checked = true;
                evento = false;
            }

            else
            {
                modelo_txt.Text = "";
                codigoModelo_txt.Text = "";
                estadoModelo_chbox.Checked = true;
                evento = false;
                fabricante_cbox.Enabled = true;
            }
        }
        public void hidePanels()
        {
            modelo_panel.Visible = false;
            fabricantes_panel.Visible = false;
        }
        private void fabricante_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            evento = false;
            idEvento = 0;
            resetCampos();
            resetButtons();
            if (fabricante_radiobtn.Checked)
            {
                
                comboFilled = false;
                fabricante_cbox.DataSource = null;
                LlenarDtgFabricantesModelos();
                hidePanels();
                fabricantes_panel.Visible = true;
               
            }
            else
            {
                fabricantesModelos_dtg.DataSource = null;
                hidePanels();
                modelo_panel.Visible = true;
                LLenarFabricanteCb();
                LlenarDtgFabricantesModelos();
            }
        }

        public void LLenarFabricanteCb()
        {
            fabricante_cbox.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerTodosFabricantes();
            fabricante_cbox.DataSource = dt;
            fabricante_cbox.DisplayMember = "FABRICANTE";
            fabricante_cbox.ValueMember = "ID";
            fabricante_cbox.SelectedIndex = -1;
            comboFilled = true;
            
        }

        private void fabricante_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilled)
            {
                LlenarDtgFabricantesModelos();
            }

            
        }

        private void guardarModelo_btn_Click(object sender, EventArgs e)
        {
            if (fabricante_radiobtn.Checked)
            {
                if (!evento)
                {
                    registrarFabricante();
                }
                else
                {
                    actualizarFabricante();
                }
                //MessageBox.Show("FABRICANTE");
            }
            else
            {
                if (!evento)
                {
                    registrarModelo();
                }
                else
                {
                    ActualizarModelo();
                }
                //MessageBox.Show("MODELO");
            }
        }

        public void registrarFabricante()
        {
            string[] valores = {fabricante_txt.Text, codigoFabricante_txt.Text};
            string msj = GF.ValidarCampoString(valores);
            if(msj == "OK")
            {
                string respuesta;
                P.Fabricante = fabricante_txt.Text;
                P.Codigo = codigoFabricante_txt.Text;
                P.Estado = estadoFabricante_chbox.Checked;
                respuesta = P.RegistrarFabricante();
                if (respuesta == "1")
                {
                    MessageBox.Show("Fabricante Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDtgFabricantesModelos();
                    resetCampos();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Revise que el codigo o fabricante no exista actualmente", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el Fabricante!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void registrarModelo()
        {
            string[] valores = { fabricante_cbox.Text, modelo_txt.Text, codigoModelo_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            if (msj == "OK")
            {
                string respuesta;
                P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue.ToString());
                P.Codigo = codigoModelo_txt.Text;
                P.Estado = estadoModelo_chbox.Checked;
                P.Modelo = modelo_txt.Text;
                respuesta = P.RegistrarModelo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Modelo Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDtgFabricantesModelos();
                    resetCampos();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Revise que el codigo o modelo no exista actualmente", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el Modelo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void actualizarFabricante()
        {
            string[] valores = { fabricante_txt.Text, codigoFabricante_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            if (msj == "OK")
            {
                string respuesta;
                P.Id = idEvento;
                P.Fabricante = fabricante_txt.Text;
                P.Codigo = codigoFabricante_txt.Text;
                P.Estado = estadoFabricante_chbox.Checked;
                respuesta = P.ActualizarFabricante();
                if (respuesta == "1")
                {
                    MessageBox.Show("Fabricante Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDtgFabricantesModelos();
                    resetCampos();
                    resetButtons();
                }
                
                else
                {
                    MessageBox.Show("No se pudo actualizar el Fabricante!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizarModelo()
        {
            string[] valores = { fabricante_cbox.Text, modelo_txt.Text, codigoModelo_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            if (msj == "OK")
            {
                string respuesta;
                P.Id = idEvento;
                P.Codigo = codigoModelo_txt.Text;
                P.Estado = estadoModelo_chbox.Checked;
                P.Modelo = modelo_txt.Text;
                respuesta = P.ActualizarModelo();
                if (respuesta == "1")
                {
                    MessageBox.Show("Modelo Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDtgFabricantesModelos();
                    resetCampos();
                    resetButtons();
                }
                
                else
                {
                    MessageBox.Show("No se pudo actualizar el Modelo!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fabricantesModelos_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            evento = true;
            cancelarEditar_btn.Enabled = true;
            
            if (fabricante_radiobtn.Checked)
            {
                guardarFabricante_btn.Text = "Actualizar";
                guardarFabricante_btn.Image = Properties.Resources.rotacion;
                fabricante_txt.Text = fabricantesModelos_dtg.CurrentRow.Cells[1].Value.ToString();
                codigoFabricante_txt.Text = fabricantesModelos_dtg.CurrentRow.Cells[2].Value.ToString();
                estadoFabricante_chbox.Checked = Convert.ToBoolean(fabricantesModelos_dtg.CurrentRow.Cells[3].Value);
                idEvento = Convert.ToInt32(fabricantesModelos_dtg.CurrentRow.Cells[0].Value);
            }
            else
            {
                fabricante_cbox.Enabled = false;
                guardarModelo_btn.Text = "Actualizar";
                guardarModelo_btn.Image = Properties.Resources.rotacion;
                modelo_txt.Text = fabricantesModelos_dtg.CurrentRow.Cells[1].Value.ToString();
                codigoModelo_txt.Text = fabricantesModelos_dtg.CurrentRow.Cells[2].Value.ToString();
                estadoModelo_chbox.Checked = Convert.ToBoolean(fabricantesModelos_dtg.CurrentRow.Cells[3].Value);
                idEvento = Convert.ToInt32(fabricantesModelos_dtg.CurrentRow.Cells[0].Value);
            }

        }
        public void resetButtons()
        {
            cancelarEditar_btn.Enabled = false;
            guardarFabricante_btn.Text = "Guardar";
            guardarFabricante_btn.Image = Properties.Resources.disquete;

            guardarModelo_btn.Text = "Guardar";
            guardarModelo_btn.Image = Properties.Resources.disquete;

        }
        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            
            evento = false;
            idEvento = 0;
            resetCampos();
            resetButtons();
        }
    }
}
