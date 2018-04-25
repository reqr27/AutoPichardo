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

namespace ImporteVehiculos.Formularios
{
    public partial class MostrarImagenForm : Form
    {

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
        public string ventana = Program.Gventana;
        public int id = Program.Gid;
        public int idVehiculo = Program.GidVehiculo;
        public MostrarImagenForm()
        {
            InitializeComponent();
        }

       

        public void loadImgsFromDB()
        {
            //RemoveAllPhotos();
            DataTable dt = new DataTable();
            if(ventana == "CLIENTE")
            {
                P.Id = id;
                dt = P.ObtenerImagenesCliente();
                
            }
            else
            {
                P.Id = Program.GidVehiculo;
                dt = P.ObtenerImagenesTraspasos();
            }
           
            if(dt.Rows.Count > 0)
            {
                msj_lbl.Visible = false;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                byte[] imgshow = (byte[])(dt.Rows[i][1]);
                MemoryStream Ms = new MemoryStream(imgshow);

                try
                {

                    //Button newButton = new Button();
                    //newButton.Size = new Size(30, 30);
                    //newButton.Image = Properties.Resources.delete;
                    //newButton.FlatStyle = FlatStyle.Flat;

                    //newButton.FlatAppearance.BorderSize = 0;
                    //newButton.Click += new EventHandler(newButton_click);
                    //newButton.Tag = (dt.Rows[i][0]).ToString();

                    //flowLayoutPanel1.Controls.Add(newButton);

                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromStream(Ms);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(590, 300);
                    pb.Tag = (dt.Rows[i][0]).ToString();
                    //pb.Height = loadedImage.Height;
                    //pb.Width = loadedImage.Width;
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

            }

        }

        private void MostrarImagenForm_Load(object sender, EventArgs e)
        {
            loadImgsFromDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
