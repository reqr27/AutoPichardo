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
    public partial class CcCpAntiguasForm : Form
    {
        public bool comboFill = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();

        public CcCpAntiguasForm()
        {
            InitializeComponent();
        }

        private void CcCpAntiguasForm_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(pageCP);
            DataTable dt1 = new DataTable();
            dt1 = P.ObtenerTasaDolarYFecha();
            tasa_lbl.Text = tasa_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");
            tasa2_lbl.Text = tasa2_lbl.Text + " " + (Convert.ToDouble(dt1.Rows[0]["TASA"])).ToString("N2");

            LlenarAñoCb();
            LLenarColoresCb();
            LLenarFabricanteCb();
            LlenarDtgClientes();
            LLenarSegurosCb();
            seguroCC_cb.Enabled = false;
            duracionCC_numtxt.Enabled = false;
            descripcionCP_cb.Enabled = false;
            duracionCP_numtxt.Enabled = false;


        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void LLenarSegurosCb()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                seguroCC_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerSegurosActivos();
                seguroCC_cb.DataSource = dt;
                seguroCC_cb.DisplayMember = "SEGURO";
                seguroCC_cb.ValueMember = "ID";
                if (dt.Rows.Count > 0)
                {
                    seguroCC_cb.SelectedIndex = 0;
                }
            }
        }

        public void LlenarAñoCb()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                List<String> years = new List<String>();
                years = GF.GetArrayofYears();
                añoCC_cb.DataSource = null;
                foreach (var year in years)
                {
                    añoCC_cb.Items.Add(year);
                }
                var selectedYear = DateTime.Now.Year - 5;
                añoCC_cb.Text = selectedYear.ToString();
            }
            else
            {
                List<String> years = new List<String>();
                years = GF.GetArrayofYears();
                añoCP_cb.DataSource = null;
                foreach (var year in years)
                {
                    añoCP_cb.Items.Add(year);
                }
                var selectedYear = DateTime.Now.Year - 5;
                añoCP_cb.Text = selectedYear.ToString();
            }
            

            
        }

        public void LLenarColoresCb()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                colorCC_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerColoresActivos();
                colorCC_cb.DataSource = dt;
                colorCC_cb.DisplayMember = "COLOR";
                colorCC_cb.ValueMember = "ID";
                colorCC_cb.SelectedIndex = -1;
            }

            else
            {
                colorCP_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerColoresActivos();
                colorCP_cb.DataSource = dt;
                colorCP_cb.DisplayMember = "COLOR";
                colorCP_cb.ValueMember = "ID";
                colorCP_cb.SelectedIndex = -1;
            }
                


        }

        public void LLenarSuplidorCb()
        {
            //suplidor_cb.DataSource = null;
            //DataTable dt = new DataTable();
            //dt = P.ObtenerSuplidoresActivos();
            //suplidor_cb.DataSource = dt;
            //suplidor_cb.DisplayMember = "SUPLIDOR";
            //suplidor_cb.ValueMember = "ID";
            //suplidor_cb.SelectedIndex = -1;


        }

        public void LLenarFabricanteCb()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                modeloCC_cb.DataSource = null;
                fabricanteCC_cbox.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerFabricantesActivos();
                fabricanteCC_cbox.DataSource = dt;
                fabricanteCC_cbox.DisplayMember = "FABRICANTE";
                fabricanteCC_cbox.ValueMember = "ID";
                fabricanteCC_cbox.SelectedIndex = -1;
                
            }

            else
            {
                modeloCP_cb.DataSource = null;
                fabricanteCP_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerFabricantesActivos();
                fabricanteCP_cb.DataSource = dt;
                fabricanteCP_cb.DisplayMember = "FABRICANTE";
                fabricanteCP_cb.ValueMember = "ID";
                fabricanteCP_cb.SelectedIndex = -1;
                
            }
            

        }

        public void LLenarModeloCb()
        {

            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                modeloCC_cb.DataSource = null;
                DataTable dt = new DataTable();
                P.IdFabricante = Convert.ToInt32(fabricanteCC_cbox.SelectedValue);
                dt = P.ObtenerModelosFabricanteActivos();
                modeloCC_cb.DataSource = dt;
                modeloCC_cb.DisplayMember = "MODELO";
                modeloCC_cb.ValueMember = "ID";
                //modeloCC_cb.SelectedIndex = -1;
            }
            else
            {
                modeloCP_cb.DataSource = null;
                DataTable dt = new DataTable();
                P.IdFabricante = Convert.ToInt32(fabricanteCP_cb.SelectedValue);
                dt = P.ObtenerModelosFabricanteActivos();
                modeloCP_cb.DataSource = dt;
                modeloCP_cb.DisplayMember = "MODELO";
                modeloCP_cb.ValueMember = "ID";
               // modeloCC_cb.SelectedIndex = -1;
            }
                

            
        }

        public void LlenarDtgClientes()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                DataTable dt = new DataTable();
                dt = P.ObtenerClientesActivos();
                clienteCC_cb.DataSource = null;

                clienteCC_cb.DataSource = dt;
                clienteCC_cb.DisplayMember = "CLIENTE";
                clienteCC_cb.ValueMember = "ID";
                clienteCC_cb.SelectedIndex = -1;
            }

            else
            {
                if (compra_radiobtn.Checked)
                {
                    descripcionCP_cb.Enabled = false;
                    duracionCP_numtxt.Enabled = false;
                    clienteCP_cb.DataSource = null;
                    DataTable dt = new DataTable();
                    dt = P.ObtenerSuplidoresActivos();
                    clienteCP_cb.DataSource = dt;
                    clienteCP_cb.DisplayMember = "SUPLIDOR";
                    clienteCP_cb.ValueMember = "ID";
                    clienteCP_cb.SelectedIndex = -1;
                }
                else if (seguroCP_radiobtn.Checked)
                {
                    descripcionCP_cb.Enabled = false;
                    duracionCP_numtxt.Enabled = true;
                    clienteCP_cb.DataSource = null;
                    DataTable dt = new DataTable();
                    dt = P.ObtenerSegurosActivos();
                    clienteCP_cb.DataSource = dt;
                    clienteCP_cb.DisplayMember = "SEGURO";
                    clienteCP_cb.ValueMember = "ID";
                    if (dt.Rows.Count > 0)
                    {
                        clienteCP_cb.SelectedIndex = 0;
                    }
                }
                else
                {
                    descripcionCP_cb.Enabled = true;
                    duracionCP_numtxt.Enabled = false;
                    clienteCP_cb.DataSource = null;
                    DataTable dt = new DataTable();
                    dt = P.ObtenerTalleresActivos();
                    clienteCP_cb.DataSource = dt;
                    clienteCP_cb.DisplayMember = "TALLER";
                    clienteCP_cb.ValueMember = "ID";
                    clienteCP_cb.SelectedIndex = -1;
                }
                
            }
                


        }

        private void fabricante_cbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
                modeloCC_cb.Enabled = true;
                LLenarModeloCb();

            
        }

        private void fabricanteCP_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modeloCP_cb.Enabled = true;
            LLenarModeloCb();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarAñoCb();
            LLenarColoresCb();
            LLenarFabricanteCb();
            LlenarDtgClientes();
            LLenarSegurosCb();
            
        }

        public void LlenarComponenteCb()
        {
            descripcionCP_cb.DataSource = null;
            DataTable dt = new DataTable();
            P.IdVehiculo = Program.GidVehiculo;
            dt = P.ObtenerCompoentesVehiculoFabricanteModeloAño();
            descripcionCP_cb.DataSource = dt;
            descripcionCP_cb.DisplayMember = "COMPONENTES";
            descripcionCP_cb.ValueMember = "ID";
            descripcionCP_cb.SelectedIndex = -1;
            
        }

        public void LlenarGastosReparacionCb()
        {
            descripcionCP_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerGastosReparacionActivos();
            descripcionCP_cb.DataSource = dt;
            descripcionCP_cb.DisplayMember = "DESCRIPCION";
            descripcionCP_cb.ValueMember = "ID";
            descripcionCP_cb.SelectedIndex = -1;

        }

        public void LlenarGastosAduanalesCb()
        {
            descripcionCP_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerGastosAduanalesActivos();
            descripcionCP_cb.DataSource = dt;
            descripcionCP_cb.DisplayMember = "DESCRIPCION";
            descripcionCP_cb.ValueMember = "ID";
            descripcionCP_cb.SelectedIndex = -1;

        }

        private void compra_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (compra_radiobtn.Checked)
            {
               
                duracionCP_numtxt.Enabled = false;
                descripcionCP_cb.Enabled = false;
                clienteCP_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerSuplidoresActivos();
                clienteCP_cb.DataSource = dt;
                clienteCP_cb.DisplayMember = "SUPLIDOR";
                clienteCP_cb.ValueMember = "ID";
                //clienteCP_cb.SelectedIndex = -1;
            }
            else if(seguroCP_radiobtn.Checked)
            {
                
                duracionCP_numtxt.Enabled = true;
                descripcionCP_cb.Enabled = false;
                clienteCP_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerSegurosActivos();
                clienteCP_cb.DataSource = dt;
                clienteCP_cb.DisplayMember = "SEGURO";
                clienteCP_cb.ValueMember = "ID";
                
            }
            else //mecanica - piezas - otros
            {
                descripcionCP_cb.Enabled = true;
                duracionCP_numtxt.Enabled = false;
                clienteCP_cb.DataSource = null;
                DataTable dt = new DataTable();
                dt = P.ObtenerTalleresActivos();
                clienteCP_cb.DataSource = dt;
                clienteCP_cb.DisplayMember = "TALLER";
                clienteCP_cb.ValueMember = "ID";
                //clienteCP_cb.SelectedIndex = -1;
                if (mecanicaCP_radiobtn.Checked)
                {
                    LlenarGastosReparacionCb();
                }
                else if (piezasCP_radiobtn.Checked)
                {
                    LlenarComponenteCb();
                }
                else if (otrosCP_radiobtn.Checked)
                {
                    LlenarGastosAduanalesCb();
                }
            }
            
        }

        private void ventaCC_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ventaCC_radiobtn.Checked)
            {
                seguroCC_cb.Enabled = false;
                duracionCC_numtxt.Enabled = false;
            }
            else if (traspasoCC_radiobtn.Checked)
            {
                seguroCC_cb.Enabled = false;
                duracionCC_numtxt.Enabled = false;
            }
            else if (seguroCC_radiobtn.Checked)
            {
                seguroCC_cb.Enabled = true;
                duracionCC_numtxt.Enabled = true;
            }
        }

        private void registrarCC_btn_Click(object sender, EventArgs e)
        {
            RegistrarCC();
        }
        public int getIdTransaccion(string cuenta)
        {
            int idTransaccion = 0;

            if(cuenta == "COBRAR")
            {
                if (ventaCC_radiobtn.Checked)
                {
                    idTransaccion = 1;
                }
                else if (traspasoCC_radiobtn.Checked)
                {
                    idTransaccion = 3;
                }
                else // seguro
                {
                    idTransaccion = 4;
                }
            }
            else
            {
                if (compra_radiobtn.Checked)
                {
                    idTransaccion = 2;
                }
                else if (seguroCP_radiobtn.Checked)
                {
                    idTransaccion = 4;
                }
                else if (mecanicaCP_radiobtn.Checked)
                {
                    idTransaccion = 6;
                }
                else if (piezasCP_radiobtn.Checked)
                {
                    idTransaccion = 5;
                }

                else // otros
                {
                    idTransaccion = 7;
                }
            }

            return idTransaccion;
        }

        public void ResetFields()
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["pageCC"])//your specific tabname
            {
                
                modeloCC_cb.DataSource = null;
                modeloCC_cb.Enabled = false;
                fabricanteCC_cbox.SelectedIndex = -1;
                colorCC_cb.SelectedIndex = -1;
                chasisCC_txt.Text = "";
                seguroCC_cb.SelectedIndex = -1;
                colorCC_cb.SelectedIndex = -1;
                clienteCC_cb.SelectedIndex = -1;
                montoCC_txt.Text = "";
                rdDineroCC_radiobtn.Checked = true;
                notaCC_txt.Text = "";
            }
            else
            {
                modeloCP_cb.DataSource = null;
                modeloCP_cb.Enabled = false;
                fabricanteCP_cb.SelectedIndex = -1;
                colorCP_cb.SelectedIndex = -1;
                chasisCP_txt.Text = "";
                
                colorCP_cb.SelectedIndex = -1;
                clienteCP_cb.SelectedIndex = -1;
                montoCP_txt.Text = "";
                rdDineroCP_radiobtn.Checked = true;
                descripcionCP_cb.SelectedIndex = -1;
                notaCP_txt.Text = "";
            }
        }

        public void RegistrarCC()
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataTable dt1 = new DataTable();
                dt1 = P.ObtenerTasaDolarYFecha();
                string msj;
                string msj2;
                if (ventaCC_radiobtn.Checked || traspasoCC_radiobtn.Checked)
                {
                    string[] valores = { clienteCC_cb.Text, fabricanteCC_cbox.Text, modeloCC_cb.Text, colorCC_cb.Text, añoCC_cb.Text, clienteCC_cb.Text, notaCC_txt.Text};
                    string[] numeros = { montoCC_txt.Text };
                    msj = GF.ValidarCampoString(valores);
                    msj2 = GF.ValidarCampoNumerico(numeros);
                }
                else  //seguro
                {
                    string[] valores = { clienteCC_cb.Text, fabricanteCC_cbox.Text, modeloCC_cb.Text, colorCC_cb.Text, añoCC_cb.Text, clienteCC_cb.Text, notaCC_txt.Text,seguroCC_cb.Text};
                    string[] numeros = { montoCC_txt.Text, duracionCC_numtxt.Value.ToString() };
                    msj = GF.ValidarCampoString(valores);
                    msj2 = GF.ValidarCampoNumerico(numeros);
                }
                

                if (msj != "OK")
                {
                    MessageBox.Show("Todos los Campos son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (msj2 != "OK")
                {
                    MessageBox.Show("Campo Monto solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    P.Tipo = "COBRAR";
                    P.IdCliente = Convert.ToInt32(clienteCC_cb.SelectedValue);
                    P.IdTransaccion = getIdTransaccion("COBRAR");
                    P.Id = 0; // idgasto
                    if (rdDineroCC_radiobtn.Checked)
                    {
                        P.MontoRD = Convert.ToDouble(montoCC_txt.Text);
                        P.MontoUSD = Convert.ToDouble(montoCC_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    }
                    else
                    {
                        P.MontoUSD = Convert.ToDouble(montoCC_txt.Text);
                        P.MontoRD = Convert.ToDouble(montoCC_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    }
                    P.Fecha = fechaCC_dtp.Value;
                    P.Nota = notaCC_txt.Text;
                    string resultado = P.RegistrarCPCCAntigua();
                    if(resultado == "1")
                    {
                        P.Tipo = "COBRAR";
                        P.IdFabricante = Convert.ToInt32(fabricanteCC_cbox.SelectedValue);
                        P.IdModelo = Convert.ToInt32(modeloCC_cb.SelectedValue);
                        P.Año = Convert.ToInt32(añoCC_cb.Text);
                        P.Color = colorCC_cb.Text;
                        P.Vin = chasisCC_txt.Text;
                        P.IdSeguro = Convert.ToInt32(seguroCC_cb.SelectedValue);
                        P.Duracion = Convert.ToInt32(duracionCC_numtxt.Value);
                        resultado = P.RegistrarDetallesCPCCAntigua();
                        if(resultado == "1")
                        {
                            MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetFields();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo completar esta acción", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar esta acción", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        public void RegistrarCP()
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea realizar esta acción?", Program.Gtitulo, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataTable dt1 = new DataTable();
                dt1 = P.ObtenerTasaDolarYFecha();
                string msj;
                string msj2;
                int idSeguro;
                if (compra_radiobtn.Checked )
                {
                    idSeguro = 0;
                    string[] valores = { clienteCP_cb.Text, fabricanteCP_cb.Text, modeloCP_cb.Text, colorCP_cb.Text, añoCP_cb.Text, clienteCP_cb.Text, notaCP_txt.Text };
                    string[] numeros = { montoCP_txt.Text };
                    msj = GF.ValidarCampoString(valores);
                    msj2 = GF.ValidarCampoNumerico(numeros);
                }

                else if (seguroCP_radiobtn.Checked)
                {
                    idSeguro = Convert.ToInt32(clienteCC_cb.SelectedValue);
                    string[] valores = { clienteCP_cb.Text, fabricanteCP_cb.Text, modeloCP_cb.Text, colorCP_cb.Text, añoCP_cb.Text, clienteCP_cb.Text, notaCP_txt.Text};
                    string[] numeros = { montoCP_txt.Text, duracionCP_numtxt.Text};
                    msj = GF.ValidarCampoString(valores);
                    msj2 = GF.ValidarCampoNumerico(numeros);
                }

                else  //mecanica, piezas, otras
                {
                    idSeguro = 0;
                    string[] valores = { clienteCP_cb.Text, fabricanteCP_cb.Text, modeloCP_cb.Text, colorCP_cb.Text, añoCC_cb.Text, clienteCP_cb.Text, notaCP_txt.Text, descripcionCP_cb.Text };
                    string[] numeros = { montoCP_txt.Text};
                    msj = GF.ValidarCampoString(valores);
                    msj2 = GF.ValidarCampoNumerico(numeros);
                }


                if (msj != "OK")
                {
                    MessageBox.Show("Todos los Campos habilitados son necesarios.", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (msj2 != "OK")
                {
                    MessageBox.Show("Campo Monto solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    P.Tipo = "PAGAR";
                    P.IdCliente = Convert.ToInt32(clienteCP_cb.SelectedValue);
                    P.IdTransaccion = getIdTransaccion("PAGAR");
                    P.Id = Convert.ToInt32(descripcionCP_cb.SelectedValue); // idgasto
                    if (rdDineroCP_radiobtn.Checked)
                    {
                        P.MontoRD = Convert.ToDouble(montoCP_txt.Text);
                        P.MontoUSD = Convert.ToDouble(montoCP_txt.Text) / Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    }
                    else
                    {
                        P.MontoUSD = Convert.ToDouble(montoCP_txt.Text);
                        P.MontoRD = Convert.ToDouble(montoCP_txt.Text) * Convert.ToDouble(dt1.Rows[0]["TASA"]);
                    }
                    P.Fecha = fechaCP_dtp.Value;
                    P.Nota = notaCP_txt.Text;
                    string resultado = P.RegistrarCPCCAntigua();
                    if (resultado == "1")
                    {
                        P.Tipo = "PAGAR";
                        P.IdFabricante = Convert.ToInt32(fabricanteCP_cb.SelectedValue);
                        P.IdModelo = Convert.ToInt32(modeloCP_cb.SelectedValue);
                        P.Año = Convert.ToInt32(añoCP_cb.Text);
                        P.Color = colorCP_cb.Text;
                        P.Vin = chasisCP_txt.Text;
                        P.IdSeguro = idSeguro;
                        P.Duracion = Convert.ToInt32(duracionCP_numtxt.Value);
                        
                        resultado = P.RegistrarDetallesCPCCAntigua();
                        if (resultado == "1")
                        {
                            MessageBox.Show("Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetFields();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo completar esta acción", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar esta acción", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void registrarCP_btn_Click(object sender, EventArgs e)
        {
            RegistrarCP();
        }

        private void descripcionCP_cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (piezasCP_radiobtn.Checked)
            {
                
                LlenarPrecioTxt();
                
            }
        }

        public void LlenarPrecioTxt()
        {
            if (descripcionCP_cb.Text != "System.Data.DataRowView")
            {

                DataTable dt = new DataTable();
                P.Id = Convert.ToInt32(descripcionCP_cb.SelectedValue);
                dt = P.ObtenerPrecioCompoenteSeleccionado();
                if (rdDineroCP_radiobtn.Checked)
                {
                    montoCP_txt.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($RD)"])).ToString("#,###.00");
                }
                else
                {
                    montoCP_txt.Text = (Convert.ToDouble(dt.Rows[0]["PRECIO ($USD)"])).ToString("#,###.00");
                }
            }

        }
    }
}
