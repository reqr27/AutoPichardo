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
    public partial class PiezasRepuestosForm : Form
    {
        public bool evento = false;
        public int idEvento = 0;
        public bool fillCombo = false;
        public bool fillModeloCombo = false;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public PiezasRepuestosForm()
        {
            InitializeComponent();
        }

        private void PiezasRepuestosForm_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            LlenarAñoCb();
            LLenarFabricanteCb();
            Permisos();
            pieza_txt.Focus();
            guardarComponente_btn.NotifyDefault(false);
        }
        public void Permisos()
        {

            bool permiso = GF.ValidarPermisoTransaccion("TASA CAMBIO");
            if (!permiso)
            {
                tasa_lbl.Enabled = false;
            }
        }
        public void ResetCampos()
        {
            evento = false;
            pieza_txt.Text = "";
            rdDinero_radiobtn.Checked = true;
            precio_txt.Text = "";
            fabricante_cbox.Enabled = true;
            modelo_cb.Enabled = true;
            año_cb.Enabled = true;
            guardarComponente_btn.Text = "Guardar";
            guardarComponente_btn.Image = Properties.Resources.disquete;
            cancelarEditar_btn.Enabled = false;
            pieza_txt.Focus();
        }

        public void LlenarDtgComponentes()
        {
            DataTable dt = new DataTable();
            Componentes_dtg.DataSource = null;
            P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue);
            P.IdModelo = Convert.ToInt32(modelo_cb.SelectedValue);
            P.Año = Convert.ToInt32(año_cb.Text);
            dt = P.ObtenerComponentes();
            Componentes_dtg.DataSource = dt;
            Componentes_dtg.Columns[1].DefaultCellStyle.Format = "N2";
            Componentes_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            Componentes_dtg.Columns[4].Visible = false;
        }

        public void LlenarAñoCb()
        {
            List<String> years = new List<String>();
            years = GF.GetArrayofYears();
            año_cb.DataSource = null;
            foreach (var year in years)
            {
                año_cb.Items.Add(year);
            }
            var selectedYear = DateTime.Now.Year - 5;
            año_cb.Text = selectedYear.ToString();
        }

        public void LLenarFabricanteCb()
        {
            fabricante_cbox.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerFabricantesActivos();
            fabricante_cbox.DataSource = dt;
            fabricante_cbox.DisplayMember = "FABRICANTE";
            fabricante_cbox.ValueMember = "ID";
            fabricante_cbox.SelectedIndex = -1;
            fillCombo = true;
            
        }

        public void LLenarModeloCb()
        {
            if (fillCombo)
            {
                modelo_cb.DataSource = null;
                DataTable dt = new DataTable();
                P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue);
                dt = P.ObtenerModelosFabricanteActivos();
                modelo_cb.DataSource = dt;
                modelo_cb.DisplayMember = "MODELO";
                modelo_cb.ValueMember = "ID";
                modelo_cb.SelectedIndex = -1;
                fillModeloCombo = true;
            }
            

        }

        private void fabricante_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(fabricante_cbox.SelectedIndex != -1 && fillCombo)
            {
                modelo_cb.Enabled = true;
                LLenarModeloCb();

            }
            

        }

        private void modelo_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(modelo_cb.SelectedIndex != -1 && fillModeloCombo)
            {
                LlenarDtgComponentes();
            }
        }

        public void RegistrarComponente()
        {
            string[] valores = { fabricante_cbox.Text, modelo_cb.Text, año_cb.Text, pieza_txt.Text };
            string[] numeros = { año_cb.Text, precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Campos Año y Precio solo permiten números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.IdFabricante = Convert.ToInt32(fabricante_cbox.SelectedValue);
                P.IdModelo = Convert.ToInt32(modelo_cb.SelectedValue);
                P.Año = Convert.ToInt32(año_cb.Text);
                P.Componente = pieza_txt.Text;
                P.Estado = estadoComponente_chbox.Checked;
                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text)/ Convert.ToDouble(Properties.Settings.Default.tasaDolar) ;
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.RegistrarComponente();
                if (respuesta == "1")
                {
                    MessageBox.Show("Componente fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetCampos();
                    LlenarDtgComponentes();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Componente ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Componente no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarComponente()
        {
            string[] valores = { fabricante_cbox.Text, modelo_cb.Text, año_cb.Text, pieza_txt.Text };
            string[] numeros = { año_cb.Text, precio_txt.Text };
            string msj = GF.ValidarCampoString(valores);
            string msj1 = GF.ValidarCampoNumerico(numeros);
            if (msj != "OK")
            {
                MessageBox.Show("Todos los Campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msj1 != "OK")
            {
                MessageBox.Show("Campos Año y Precio solo permiten números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                P.Id = idEvento;
                P.Componente = pieza_txt.Text;
                P.Estado = estadoComponente_chbox.Checked;
                if (rdDinero_radiobtn.Checked)
                {
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text) / Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                else
                {
                    P.PrecioUSD = Convert.ToDouble(precio_txt.Text);
                    P.PrecioRD = Convert.ToDouble(precio_txt.Text) * Convert.ToDouble(Properties.Settings.Default.tasaDolar);
                }
                string respuesta = P.ActualizarComponente();
                if (respuesta == "1")
                {
                    MessageBox.Show("Componente fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetCampos();
                    LlenarDtgComponentes();
                }
               
                else
                {
                    MessageBox.Show("Componente no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Componentes_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarEditar_btn.Enabled = true;
            evento = true;
            idEvento = Convert.ToInt32(Componentes_dtg.CurrentRow.Cells[4].Value.ToString());
            fabricante_cbox.Enabled = false;
            modelo_cb.Enabled = false;
            año_cb.Enabled = false;
            rdDinero_radiobtn.Checked = true;
            guardarComponente_btn.Text = "Actualizar";
            guardarComponente_btn.Image = Properties.Resources.rotacion;
            pieza_txt.Text = Componentes_dtg.CurrentRow.Cells[0].Value.ToString();
            precio_txt.Text = Componentes_dtg.CurrentRow.Cells[1].Value.ToString();
            estadoComponente_chbox.Checked = Convert.ToBoolean(Componentes_dtg.CurrentRow.Cells[3].Value);
            
        }

        private void guardarComponente_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                RegistrarComponente();
            }
            else
            {
                ActualizarComponente();
            }
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            ResetCampos();
        }

        private void año_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDtgComponentes();
        }

        private void tasa_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DolaresForm form = new DolaresForm();
            form.ShowDialog();
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = "";
            tasa_lbl.Text = "1.00 $USD = " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2") + "$RD";
        }

        private void fabricante_cbox_DropDown(object sender, EventArgs e)
        {
            LLenarFabricanteCb();
        }

        private void modelo_cb_DropDown(object sender, EventArgs e)
        {
            LLenarModeloCb();
        }
    }
}
