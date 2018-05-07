using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialKeyGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            int totalSumSerial = 0;
            int rInt1 = 0;
            int rInt2 = 0;
            if (full_radiobtn.Checked)
            {
                totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
                Random r = new Random();
                rInt1 = r.Next(0, 9999); //for ints
                rInt2 = r.Next(0, 9999); //for ints
                if (rInt1 + rInt2 > totalSumSerial)
                {
                    while (rInt1 + rInt2 > totalSumSerial)
                    {
                        rInt2 = r.Next(0, 9999); //for ints
                    }
                }
            }
            else //trial
            {
                totalSumSerial = 5000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
                Random r = new Random();
                rInt1 = r.Next(0, 9999); //for ints
                rInt2 = r.Next(0, 9999); //for ints
                if (rInt1 + rInt2 > totalSumSerial)
                {
                    while (rInt1 + rInt2 > totalSumSerial)
                    {
                        rInt2 = r.Next(0, 9999); //for ints
                    }
                }

            }
            

            int rInt3 = totalSumSerial - rInt1 - rInt2;
            txt1.Text = rInt1.ToString("D4");
            textBox1.Text = rInt2.ToString("D4");
            textBox2.Text = rInt3.ToString("D4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
