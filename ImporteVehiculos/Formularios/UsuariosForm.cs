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
    public partial class UsuariosForm : Form
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
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            agregarEditarUsuario_btn.NotifyDefault(false);
            LlenarDtgUsuarios();
            nombre_txt.Focus();
        }

        public void LlenarDtgUsuarios()
        {
            usuarios_dtg.DataSource = null;
            
            DataTable dt = new DataTable();
            dt = P.ObtenerUsuarios();
            usuarios_dtg.DataSource = dt;
            //usuarios_dtg.Columns[4].Visible = false;
            //usuarios_dtg.Columns[5].Visible = false;
            //usuarios_dtg.Columns[6].Visible = false;
            //usuarios_dtg.Columns[7].Visible = false;
            //usuarios_dtg.Columns[8].Visible = false;
            //usuarios_dtg.Columns[9].Visible = false;
            //usuarios_dtg.Columns[10].Visible = false;
            //usuarios_dtg.Columns[11].Visible = false;
            //usuarios_dtg.Columns[12].Visible = false;
            //usuarios_dtg.Columns[13].Visible = false;
            //usuarios_dtg.Columns[14].Visible = false;
            //usuarios_dtg.Columns[15].Visible = false;
            usuarios_dtg.Columns[23].Visible = false;
        }

        private void agregarEditarUsuario_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                registrarUsuario();
            }
            else
            {
                ActualizarUsuario();
            }
        }
        public void resetCampos()
        {
            usuario_txt.Text = "";
            clave_txt.Text = "";
            nombre_txt.Text = "";
            confirmarClave_txt.Text = "";
            evento = false;
            cancelar_btn.Enabled = false;
            agregarEditarUsuario_btn.Image = Properties.Resources.rotacion;
            agregarEditarUsuario_btn.Text = "Registrar";
            idEvento = 0;
            nombre_txt.Focus();
        }
        public void registrarUsuario()
        {
            string[] valores = { nombre_txt.Text, usuario_txt.Text, clave_txt.Text, confirmarClave_txt.Text};
            bool confirmarClave = ConfirmarClaves();
            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!confirmarClave)
            {
                MessageBox.Show("Claves no coinciden", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                P.Usuario = usuario_txt.Text;
                P.Nombre = nombre_txt.Text;
                P.Clave = clave_txt.Text;
                P.TasaDolar = tasaDolar_chbx.Checked;
                P.CrearUsuario = crearUsuario_chbx.Checked;
                P.CrearFabricantesModelos = crearFabricantesModelos_chbx.Checked;
                P.CrearPiezasRepuestos = crearPiezasRepuestos_chbx.Checked;
                P.CrearTaller = crearTaller_chbx.Checked;
                P.CrearPropietarios = crearPropietarios_chbx.Checked;
                P.CrearCliente = crearClientes_chbx.Checked;
                P.CrearGastos = crearGastos_chbx.Checked;
                P.ImportarVehiculos = importarVehiculos_chbx.Checked;
                P.Compras = compras_chbx.Checked;
                P.CambiarEstadoVehiculos = cambiarEstadosVehiculos_chbx.Checked;
                P.AgregarGastos = agregarGasto_chbx.Checked;
                P.AgregarPiezas = agregarPiezas_chbx.Checked;
                P.Facturacion = facturacion_chbx.Checked;
                P.Reportes = reportes_chbox.Checked;
                P.EstadoUsuario = estado_chbx.Checked;
                P.ModificarVehiculo = modificarVehiculo_chbox.Checked;
                P.CuentasCobrar = cuentasCobrar_chbox.Checked;
                P.CuentasPagar = cuentasPagar_chbox.Checked;
                P.ActualizarTasaDiario = actualizarTasaDiario_chbox.Checked;
                P.CrearPais = paises_chbox.Checked;
                P.CrearCiudad = ciudades_chbox.Checked;
                P.CrearColor = colores_chbox.Checked;
                P.CrearSuplidor = suplidores_chbox.Checked;
                P.CrearUbicacion = ubicaciones_chbox.Checked;
                P.CrearSeguro = seguros_chbox.Checked;
                P.AgregarCCCPAntigua = agregarCCCP_chbox.Checked;
                string respuesta = P.RegistrarUsuario();
                if (respuesta == "1")
                {
                    MessageBox.Show("Usuario fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgUsuarios();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Usuario ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        public bool ConfirmarClaves()
        {
            bool respuesta = false;
            if(clave_txt.Text == confirmarClave_txt.Text)
            {
                respuesta = true;

            }
            return respuesta;
        }
        public void ActualizarUsuario()
        {
            string[] valores = { nombre_txt.Text, usuario_txt.Text, clave_txt.Text, confirmarClave_txt.Text };
            bool confirmarClave = ConfirmarClaves();
            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos de texto son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (!confirmarClave)
            {
                MessageBox.Show("Claves no coinciden", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                P.Id = idEvento;
                P.Usuario = usuario_txt.Text;
                P.Nombre = nombre_txt.Text;
                P.Clave = clave_txt.Text;
                P.TasaDolar = tasaDolar_chbx.Checked;
                P.CrearUsuario = crearUsuario_chbx.Checked;
                P.CrearFabricantesModelos = crearFabricantesModelos_chbx.Checked;
                P.CrearPiezasRepuestos = crearPiezasRepuestos_chbx.Checked;
                P.CrearTaller = crearTaller_chbx.Checked;
                P.CrearPropietarios = crearPropietarios_chbx.Checked;
                P.CrearCliente = crearClientes_chbx.Checked;
                P.CrearGastos = crearGastos_chbx.Checked;
                P.ImportarVehiculos = importarVehiculos_chbx.Checked;
                P.Compras = compras_chbx.Checked;
                P.CambiarEstadoVehiculos = cambiarEstadosVehiculos_chbx.Checked;
                P.AgregarGastos = agregarGasto_chbx.Checked;
                P.AgregarPiezas = agregarPiezas_chbx.Checked;
                P.Facturacion = facturacion_chbx.Checked;
                P.Reportes = reportes_chbox.Checked;
                P.EstadoUsuario = estado_chbx.Checked;
                P.ModificarVehiculo = modificarVehiculo_chbox.Checked;
                P.CuentasCobrar = cuentasCobrar_chbox.Checked;
                P.CuentasPagar = cuentasPagar_chbox.Checked;
                P.CrearPais = paises_chbox.Checked;
                P.CrearCiudad = ciudades_chbox.Checked;
                P.CrearColor = colores_chbox.Checked;
                P.CrearSuplidor = suplidores_chbox.Checked;
                P.CrearUbicacion = ubicaciones_chbox.Checked;
                P.ActualizarTasaDiario = actualizarTasaDiario_chbox.Checked;
                P.CrearSeguro = seguros_chbox.Checked;
                P.AgregarCCCPAntigua = agregarCCCP_chbox.Checked;
                string respuesta = P.ActualizarUsuario();

                if (respuesta == "1")
                {
                    MessageBox.Show("Usuario fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCampos();
                    LlenarDtgUsuarios();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Ya fue elegido ese nombre de usuario!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void usuarios_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelar_btn.Enabled = true;
            evento = true;
            agregarEditarUsuario_btn.Text = "Actualizar";
            agregarEditarUsuario_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(usuarios_dtg.CurrentRow.Cells[0].Value.ToString());
            usuario_txt.Text = usuarios_dtg.CurrentRow.Cells[1].Value.ToString();
            nombre_txt.Text = usuarios_dtg.CurrentRow.Cells[2].Value.ToString();
            tasaDolar_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[3].Value.ToString());
            crearUsuario_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[4].Value.ToString());
            crearFabricantesModelos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[5].Value.ToString());
            crearPiezasRepuestos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[6].Value.ToString());
            crearTaller_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[7].Value.ToString());
            crearPropietarios_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[8].Value.ToString());
            crearClientes_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[9].Value.ToString());
            crearGastos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[10].Value.ToString());
            importarVehiculos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[11].Value.ToString());
            compras_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[12].Value.ToString());
            cambiarEstadosVehiculos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[13].Value.ToString());
            agregarGasto_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[14].Value.ToString());
            agregarPiezas_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[15].Value.ToString());
            facturacion_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[16].Value.ToString());
            
            modificarVehiculo_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[17].Value.ToString());
            cuentasPagar_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[18].Value.ToString());
            cuentasCobrar_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[19].Value.ToString());
            reportes_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[20].Value.ToString());
            actualizarTasaDiario_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[21].Value.ToString());
            estado_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[22].Value.ToString());
            clave_txt.Text = usuarios_dtg.CurrentRow.Cells[23].Value.ToString();
            confirmarClave_txt.Text = usuarios_dtg.CurrentRow.Cells[23].Value.ToString();
            paises_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[24].Value.ToString());
            ciudades_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[25].Value.ToString());
            colores_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[26].Value.ToString());
            ubicaciones_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[27].Value.ToString());
            suplidores_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[28].Value.ToString());
            seguros_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[29].Value.ToString());
            agregarCCCP_chbox.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[30].Value.ToString());


            //estadoCliente_chbox.Checked = Convert.ToBoolean(cliente_dtg.CurrentRow.Cells[4].Value);
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
