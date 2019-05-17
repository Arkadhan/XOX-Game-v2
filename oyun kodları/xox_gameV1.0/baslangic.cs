using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox_gameV1._0
{
    public partial class baslangic : Form
    {
        static Form basFormu;
        public static Form BaslangicFormu
        {
            get
            {
                return basFormu;
            }
        }

        public baslangic()
        {
            InitializeComponent();
            basFormu = this;
        }

        private void loadi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            humhum frm1 = new humhum();

            frm1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();

            humpc frm1 = new humpc();

            frm1.Show();
        }

        private void baslangic_Load(object sender, EventArgs e)
        {

        }
    }
}
