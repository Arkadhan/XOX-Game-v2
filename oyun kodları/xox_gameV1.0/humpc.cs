using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox_gameV1._0
{
    public partial class humpc : Form
    {

        Random uret = new Random();
        bool sira;
        int[,] oyun = new int[3, 3];
        int sat = 5, sut = 5;
        

        List<Point> bosPozisyonlar = new List<Point>();
        public humpc()
        {
            InitializeComponent();
        }


        private void humpc_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            pBwin.Visible = false;
            sira = true;
            timer1.Enabled = true;
            xoxTimeBar1.RedValue = 5;
            


            for (int i = 0; i <= 2; i++)
            {

                for (int j = 0; j <= 2; j++)
                {
                    oyun[i, j] = 5;

                    bosPozisyonlar.Add(new Point(i, j));
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void yarat()
        {
            sira = false;          
            Point nokta;
            bool buldum = false;

            

            do
            {
                int rasgele = uret.Next(0, bosPozisyonlar.Count - 1);

                nokta = bosPozisyonlar[rasgele];

                sat = nokta.X;

                sut = nokta.Y;

                buldum = oyun[sat, sut] == 5;

                if (!buldum)
                    bosPozisyonlar.Remove(nokta);

            } while (!buldum);



            if (buldum)
                bosPozisyonlar.Remove(nokta);
            else
            {
                MessageBox.Show("Oynayacak yer yok!");
                return;
            }


            if (sat == 0 && sut == 0)
            {
                b11.Text = "0";
                b11.Enabled = false;
                oyun[0, 0] = 0;
                sira = true;
                kontrol();
            }

            else if (sat == 0 && sut == 1)
            {
                b12.Text = "0";
                b12.Enabled = false;
                oyun[0, 1] = 0;
                sira = true;
                kontrol();
            }
            else if (sat == 0 && sut == 2)
            {
                b13.Text = "0";
                b13.Enabled = false;
                oyun[0, 2] = 0;
                sira = true;
                kontrol();
            }
            else if (sat == 1 && sut == 0)
            {
                b21.Text = "0";
                b21.Enabled = false;
                oyun[1, 0] = 0;
                sira = true;
                kontrol();

            }
            else if (sat == 1 && sut == 1)
            {
                b22.Text = "0";
                b22.Enabled = false;
                oyun[1, 1] = 0;
                sira = true;
                kontrol();
            }
            else if (sat == 1 && sut == 2)
            {
                b23.Text = "0";
                b23.Enabled = false;
                oyun[1, 2] = 0;
                sira = true;
                kontrol();
            }
            else if (sat == 2 && sut == 0)
            {
                b31.Text = "0";
                b31.Enabled = false;
                oyun[2, 0] = 0;
                sira = true;
                kontrol();
            }
            else if (sat == 2 && sut == 1)
            {
                b32.Text = "0";
                b32.Enabled = false;
                oyun[2, 1] = 0;
                sira = true;
                kontrol();
            }
            else if (sat == 2 && sut == 2)
            {
                b33.Text = "0";
                b33.Enabled = false;
                oyun[2, 2] = 0;
                sira = true;
                kontrol();

            }



        }




        private void berabere()
        {
            int sayac = 0;
            for (int i = 0; i <= 2; i++)
            {

                for (int j = 0; j <= 2; j++)
                {

                    if (oyun[i, j] != 5)
                        sayac++;
                }
                if (sayac == 9)
                    MessageBox.Show("Berabere kaldınız. Oyunu tekra başlatın.");

            }

        }


        private void youwin(bool sureBittiMi=false)
        {
            timer1.Enabled = false;
            b11.Visible = false;
            b12.Visible = false;
            b13.Visible = false;
            b21.Visible = false;
            b22.Visible = false;
            b23.Visible = false;
            b31.Visible = false;
            b32.Visible = false;
            b33.Visible = false;
            pBwin.Visible = true;

            if(sureBittiMi)
            {
                if(sira)
                    lblsira.Text = "PC Kazandı!";
                else lblsira.Text = "Kazandın! Tebrikler.";
            }
            else
            {
                if (!sira)
                    lblsira.Text = "PC Kazandı!";
                else lblsira.Text = "Kazandın! Tebrikler.";
            }
           






        }


        private void b11_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b11.Text = "X";
                b11.Enabled = false;
                sira = false;
                oyun[0, 0] = 1;


                if (!kontrol())
                    yarat();

               
            }

        }


        private void b12_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b12.Text = "X";
                b12.Enabled = false;
                sira = false;
                oyun[0, 1] = 1;

                if (!kontrol())
                    yarat();
            }

        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b13.Text = "X";
                b13.Enabled = false;
                sira = false;
                oyun[0, 2] = 1;

                if (!kontrol())
                    yarat();
            }

        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b21.Text = "X";
                b21.Enabled = false;
                sira = false;
                oyun[1, 0] = 1;

                if (!kontrol())
                    yarat();
            }

        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b22.Text = "X";
                b22.Enabled = false;
                sira = false;
                oyun[1, 1] = 1;

                if (!kontrol())
                    yarat();
            }

        }

        private void b23_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b23.Text = "X";
                b23.Enabled = false;
                sira = false;
                oyun[1, 2] = 1;

                if (!kontrol())
                    yarat();
            }


        }

        private void b31_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b31.Text = "X";
                b31.Enabled = false;
                sira = false;
                oyun[2, 0] = 1;

                if (!kontrol())
                    yarat();
            }

        }

        private void b32_Click(object sender, EventArgs e)
        {
            if (sira)
            {

                b32.Text = "X";
                b32.Enabled = false;
                sira = false;
                oyun[2, 1] = 1;

                if (!kontrol())
                    yarat();
            }
        }

        private void b33_Click(object sender, EventArgs e)
        {

            if (sira)
            {

                b33.Text = "X";
                b33.Enabled = false;
                sira = false;
                oyun[2, 2] = 1;

                if (!kontrol())
                    yarat();
            }
        }

        private void humpc_FormClosed(object sender, FormClosedEventArgs e)
        {
            baslangic.BaslangicFormu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sira)
            {
                xoxTimeBar1.RedValue--;


                if (xoxTimeBar1.RedValue <= 0)
                {
                    youwin(true);
                }
            }
            else
            {
                xoxTimeBar1.BlueValue--;

                if (xoxTimeBar1.BlueValue <= 0)
                {
                    youwin(true);
                }
            }

        }

        private bool kontrol()
        {
            int say = 0;
            for (int i = 0; i <= 2; i++)
            {

                for (int j = 0; j <= 2; j++)
                {
                    if (oyun[i, j] != 5)
                        say++;

                }
            }





            if ((oyun[0, 0] == 1 && oyun[0, 1] == 1 && oyun[0, 2] == 1) ||
            (oyun[0, 0] == 1 && oyun[1, 0] == 1 && oyun[2, 0] == 1) ||
            (oyun[0, 0] == 1 && oyun[1, 1] == 1 && oyun[2, 2] == 1) ||
            (oyun[0, 1] == 1 && oyun[1, 1] == 1 && oyun[2, 1] == 1) ||
           (oyun[0, 2] == 1 && oyun[1, 1] == 1 && oyun[2, 0] == 1) ||

          (oyun[0, 2] == 1 && oyun[1, 2] == 1 && oyun[2, 2] == 1) ||

 (oyun[1, 0] == 1 && oyun[1, 1] == 1 && oyun[1, 2] == 1) ||

 (oyun[2, 0] == 1 && oyun[2, 1] == 1 && oyun[2, 2] == 1) ||


 (oyun[0, 0] == 0 && oyun[0, 1] == 0 && oyun[0, 2] == 0) ||


(oyun[0, 0] == 0 && oyun[1, 0] == 0 && oyun[2, 0] == 0) ||
 (oyun[0, 0] == 0 && oyun[1, 1] == 0 && oyun[2, 2] == 0) ||
(oyun[0, 1] == 0 && oyun[1, 1] == 0 && oyun[2, 1] == 0) ||

(oyun[0, 2] == 0 && oyun[1, 1] == 0 && oyun[2, 0] == 0) ||

(oyun[0, 2] == 0 && oyun[1, 2] == 0 && oyun[2, 2] == 0) ||

(oyun[1, 0] == 0 && oyun[1, 1] == 0 && oyun[1, 2] == 0) ||

(oyun[2, 0] == 0 && oyun[2, 1] == 0 && oyun[2, 2] == 0))
                youwin();
            else
                berabere();



            if (say == 9) return true;

            else return false;




        }
    }
}
