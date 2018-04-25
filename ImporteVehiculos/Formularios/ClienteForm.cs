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
using System.Security;
using System.IO;
using System.Text.RegularExpressions;

namespace ImporteVehiculos.Formularios
{
    public partial class ClienteForm : Form
    {
        public bool fillCombo = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        List<String> imgsList = new List<String>();
        public bool evento = false;
        public int idEvento = 0;
        Procedimientos P = new Procedimientos();
        GlobalFunctions GF = new GlobalFunctions();
        int count = 0;
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            LLenarPaisesCB();
            LlenarDtgClientes();
            resetCampos();

            this.openFileDialog1.Filter =
           "Images (*.BMP;*.JPG;*.GIF;*.png)|*.BMP;*.JPG;*.GIF;*.PNG|" +
           "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            //                   ^  ^  ^  ^  ^  ^  ^

            this.openFileDialog1.Title = "Buscar Imágenes";
        }

        public void LLenarPaisesCB()
        {
            pais_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerPaisesActivos();
            pais_cb.DataSource = dt;
            pais_cb.DisplayMember = "PAIS";
            pais_cb.ValueMember = "ID";
            pais_cb.SelectedIndex = -1;
            fillCombo = true;

        }

        public void LLenarCiudadCB()
        {
            ciudad_cb.DataSource = null;
            DataTable dt = new DataTable();
            P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
            dt = P.ObtenerCiudadesActivos();
            ciudad_cb.DataSource = dt;
            ciudad_cb.DisplayMember = "CIUDAD";
            ciudad_cb.ValueMember = "ID";
            ciudad_cb.SelectedIndex = -1;
            

        }

        public void LlenarDtgClientes()
        {
            DataTable dt = new DataTable();
            cliente_dtg.DataSource = null;

            dt = P.ObtenerClientes();
            cliente_dtg.DataSource = dt;

        }

        public void resetCampos()
        {
            pais_cb.SelectedIndex = -1;
            ciudad_cb.DataSource = null;
            cancelarEditar_btn.Enabled = false;
            evento = false;
            idEvento = 0;
            cliente_txt.Text = "";
            rncCedula_txt.Text = "";
            telefono1_txt.Text = "";
            direccion_txt.Text = "";
            estadoCliente_chbox.Checked = true;
            guardarCliente_btn.Text = "Guardar";
            guardarCliente_btn.Image = Properties.Resources.disquete;
        }

        private void guardarCliente_btn_Click(object sender, EventArgs e)
        {
            if (!evento)
            {
                RegistrarCliente();
            }
            else
            {
                ActualizarCliente();
            }
        }

        public void RegistrarCliente()
        {
            string errors = "";
            string[] valores = { cliente_txt.Text, rncCedula_txt.Text, direccion_txt.Text, telefono1_txt.Text};

            string msj = GF.ValidarCampoString(valores);

            if (msj != "OK")
            {
                MessageBox.Show("Campo Cliente y RNC/CEDULA son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Cliente = cliente_txt.Text;
                P.CedulaRNC = rncCedula_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Estado = estadoCliente_chbox.Checked;
                P.Direccion = direccion_txt.Text;
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.IdCiudad = Convert.ToInt32(ciudad_cb.SelectedValue);

                string respuesta = P.RegistrarCliente();
                if (respuesta == "1")
                {
                    //MessageBox.Show("Cliente fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var img1 in imgsList)
                    {
                        byte[] img = null;
                        FileStream fs = new FileStream(img1, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        P.Img = img;
                        string msj2 = P.InsertarImagenCliente();
                        if(msj2 == "0")
                        {
                            errors += img1 + "\n";
                        }

                    }
                    imgsList.Clear();
                    if(errors == "")
                    {
                        MessageBox.Show("Cliente fue Registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudieron guardar las siguientes imágenes: \n" + errors, Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    RemoveAllPhotos();
                    resetCampos();
                    LlenarDtgClientes();


                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Cliente ya se encuentra registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Cliente no pudo ser registrado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void ActualizarCliente()
        {
            string errors = "";
            string[] valores = { cliente_txt.Text, rncCedula_txt.Text, telefono1_txt.Text, direccion_txt.Text, pais_cb.Text, ciudad_cb.Text};

            string msj = GF.ValidarCampoString(valores);
            if (msj != "OK")
            {
                MessageBox.Show("Todos los campos son necesarios", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                P.Id = idEvento;
                P.Cliente = cliente_txt.Text;
                P.CedulaRNC = rncCedula_txt.Text;
                P.Telefono1 = telefono1_txt.Text;
                P.Estado = estadoCliente_chbox.Checked;
                P.Direccion = direccion_txt.Text;
                P.IdPais = Convert.ToInt32(pais_cb.SelectedValue);
                P.IdCiudad = Convert.ToInt32(ciudad_cb.SelectedValue);


                string respuesta = P.ActualizarCliente();
                if (respuesta == "1")
                {
                    //MessageBox.Show("Cliente fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    foreach (var img1 in imgsList)
                    {
                        byte[] img = null;
                        FileStream fs = new FileStream(img1, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        P.Img = img;
                        P.Id = idEvento;
                        string msj2 = P.ActualizarImagenCliente();
                        if (msj2 == "0")
                        {
                            errors += img1 + "\n";
                        }

                    }
                    imgsList.Clear();
                    if (errors == "")
                    {
                        resetCampos();
                        LlenarDtgClientes();
                        MessageBox.Show("Cliente fue Actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        
                        MessageBox.Show("No se pudieron guardar las siguientes imágenes: \n" + errors, Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    RemoveAllPhotos();
                   
                }

                else
                {
                    MessageBox.Show("Cliente no pudo ser actualizado!", Program.Gtitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            resetCampos();
            RemoveAllPhotos();
        }

        private void cliente_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cancelarEditar_btn.Enabled = true;
            evento = true;
            guardarCliente_btn.Text = "Actualizar";
            guardarCliente_btn.Image = Properties.Resources.rotacion;
            idEvento = Convert.ToInt32(cliente_dtg.CurrentRow.Cells[0].Value.ToString());
            cliente_txt.Text = cliente_dtg.CurrentRow.Cells[1].Value.ToString();
            rncCedula_txt.Text = cliente_dtg.CurrentRow.Cells[2].Value.ToString();
            direccion_txt.Text = cliente_dtg.CurrentRow.Cells[3].Value.ToString();
            telefono1_txt.Text = cliente_dtg.CurrentRow.Cells[4].Value.ToString();
            pais_cb.Text = cliente_dtg.CurrentRow.Cells[5].Value.ToString();
            ciudad_cb.Text = cliente_dtg.CurrentRow.Cells[6].Value.ToString();

            estadoCliente_chbox.Checked = Convert.ToBoolean(cliente_dtg.CurrentRow.Cells[7].Value);
            loadImgsFromDB();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarImagenes(List<string> listArray)
        {

            foreach (String file in listArray)
            {

                count++;
                imgsList.Add(file);
                // Create a PictureBox.
                try
                {

                    Button newButton = new Button();
                    newButton.Size = new Size(30, 30);
                    newButton.Image = Properties.Resources.delete;
                    newButton.FlatStyle = FlatStyle.Flat;

                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.Click += new EventHandler(newButton_click);
                    newButton.Tag = "dynpb" + count.ToString();

                    flowLayoutPanel1.Controls.Add(newButton);

                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(420, 220);
                    pb.Tag = "dynpb" + count.ToString();
                    pb.Image = loadedImage;

                    flowLayoutPanel1.Controls.Add(pb);

                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
        }

        protected void newButton_click(object sender, EventArgs e)
        {
           
            
            Button button = sender as Button;
            int index = Convert.ToInt32(Regex.Replace(button.Tag.ToString(), "[^0-9 _]", "")) - 1;
            imgsList.RemoveAt(index);
            if (evento == false)
            {
                foreach (PictureBox pic_box in flowLayoutPanel1.Controls.OfType<PictureBox>())
                {
                    if (pic_box.Tag != null && pic_box.Tag.ToString() == button.Tag.ToString())
                    {
                        pic_box.Dispose();
                    }
                }

                foreach (Button but in flowLayoutPanel1.Controls.OfType<Button>())
                {
                    if (but.Tag != null && but.Tag.ToString() == button.Tag.ToString())
                    {
                        but.Dispose();
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Eliminar foto de Base de Datos", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    P.Id = Convert.ToInt16(button.Tag.ToString());
                    P.EliminarImagen();
                    loadImgsFromDB();
                }

            }

        }

        public void RemoveAllPhotos()
        {
            List<Control> listControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();
            List<Control> listControls2 = flowLayoutPanel2.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in listControls2)
            {
                flowLayoutPanel2.Controls.Remove(control);
                control.Dispose();
            }
        }

        public void loadImgsFromDB()
        {
            RemoveAllPhotos();
            DataTable dt = new DataTable();
            P.Id = idEvento;
            dt = P.ObtenerImagenesCliente();
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                byte[] imgshow = (byte[])(dt.Rows[i][1]);
                MemoryStream Ms = new MemoryStream(imgshow);

                try
                {

                    Button newButton = new Button();
                    newButton.Size = new Size(30, 30);
                    newButton.Image = Properties.Resources.delete;
                    newButton.FlatStyle = FlatStyle.Flat;

                    newButton.FlatAppearance.BorderSize = 0;
                    newButton.Click += new EventHandler(newButton_click);
                    newButton.Tag = (dt.Rows[i][0]).ToString();

                    flowLayoutPanel2.Controls.Add(newButton);

                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromStream(Ms);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(420, 220);
                    pb.Tag = (dt.Rows[i][0]).ToString();
                    //pb.Height = loadedImage.Height;
                    //pb.Width = loadedImage.Width;
                    pb.Image = loadedImage;

                    flowLayoutPanel2.Controls.Add(pb);

                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }

            }

        }

        private void agregarImg_btn_Click(object sender, EventArgs e)
        {
            List<String> imgsList1 = new List<String>();

            try
            {

                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        imgsList1.Add(file);
                    }

                    CargarImagenes(imgsList1);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pais_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pais_cb.SelectedIndex != -1 && fillCombo)
            {
                LLenarCiudadCB();

            }
        }
    }
}
