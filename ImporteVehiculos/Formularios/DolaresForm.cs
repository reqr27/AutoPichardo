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
    public partial class DolaresForm : Form
    {
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        public DolaresForm()
        {
            InitializeComponent();
        }

        private void DolaresForm_Load(object sender, EventArgs e)
        {
            guardar_btn.NotifyDefault(false);
            DataTable dt = new DataTable();
            dt = P.ObtenerTasaDolarYFecha();
            tasa_txt.Focus();

            tasa_txt.Text = (Convert.ToDouble(dt.Rows[0]["TASA"])).ToString("N2");
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            
            string[] numeros = {tasa_txt.Text };
            
            string msj1 = GF.ValidarCampoNumerico(numeros);


            if (msj1 != "OK")
            {
                MessageBox.Show("Tasa Dolar solo permite números", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                P.ValorDolar = Convert.ToDouble(tasa_txt.Text);
                string msj = P.ActualizarTasaDolar();
                if(msj == "1")
                {
                    MessageBox.Show("Tasa Dolar ha sido actualizada", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tasa Dolar no pudo ser actualizada", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
