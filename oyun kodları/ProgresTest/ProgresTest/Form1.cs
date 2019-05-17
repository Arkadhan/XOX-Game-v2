using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgresTest
{
    public partial class Form1 : Form
    {
        private bool oyuncu=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(oyuncu)
            xoxTimeBar1.RedValue--;
            else
                xoxTimeBar1.BlueValue--;
        }

        private void btnOyuncu1_Click(object sender, EventArgs e)
        {
            oyuncu = true;
        }

        private void btnOyuncu2_Click(object sender, EventArgs e)
        {
            oyuncu = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
                btnBaslat.Text = "Durdur";
            else btnBaslat.Text = "Başlat";
        }
    }
}
