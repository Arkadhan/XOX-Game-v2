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
    public partial class humhum : Form
    {
        bool sira;
        int[,] oyun = new int[3, 3];//Oyun için dizilerle bir tahta oluşturuldu

        public humhum()
        {
            InitializeComponent();
        }

        private void lblsira_Click(object sender, EventArgs e)
        {

        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b11.Text = "X";
                sira = false;
                oyun[0, 0] = 1;// tahtaya yaz
                

            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b11.Text = "0";
                sira = true;
                oyun[0, 0] = 0;// tahtaya yaz
            }
            b11.Enabled = false;
            kontrol();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b12.Text = "X";
                sira = false;
                oyun[0, 1] = 1;// tahtaya yaz

            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b12.Text = "0";
                sira = true;
                oyun[0, 1] = 0;// tahtaya yaz
            }
            b12.Enabled = false;
            kontrol();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b13.Text = "X";
                sira = false;
                oyun[0, 2] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b13.Text = "0";
                sira = true;
                oyun[0, 2] = 0;// tahtaya yaz
            }
            b13.Enabled = false;
            kontrol();
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b21.Text = "X";
                sira = false;
                oyun[1, 0] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b21.Text = "0";
                sira = true;
                oyun[1, 0] = 0;// tahtaya yaz
            }
            b21.Enabled = false;
            kontrol();

        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b22.Text = "X";
                sira = false;
                oyun[1, 1] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b22.Text = "0";
                sira = true;
                oyun[1, 1] = 0;// tahtaya yaz
            }
            b22.Enabled = false;
            kontrol();
        }
        private void b23_Click_1(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b23.Text = "X";
                sira = false;
                oyun[1, 2] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b23.Text = "0";
                sira = true;
                oyun[1, 2] = 0;// tahtaya yaz
            }
            b23.Enabled = false;
            kontrol();
        }
        private void b31_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b31.Text = "X";
                sira = false;
                oyun[2, 0] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b31.Text = "0";
                sira = true;
                oyun[2, 0] = 0;// tahtaya yaz
            }
            b31.Enabled = false;
            kontrol();

        }

        private void b32_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b32.Text = "X";
                sira = false;
                oyun[2, 1] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b32.Text = "0";
                sira = true;
                oyun[2, 1] = 0;// tahtaya yaz
            }
            b32.Enabled = false;
            kontrol();

        }

        private void b33_Click(object sender, EventArgs e)
        {
            if (sira)
            {
                lblsira.Text = "Sıra: 0 da";
                b33.Text = "X";
                sira = false;
                oyun[2, 2] = 1;// tahtaya yaz
            }
            else
            {
                lblsira.Text = "Sıra: X de";
                b33.Text = "0";
                sira = true;
                oyun[2, 2] = 0;// tahtaya yaz
            }
            b33.Enabled = false;
            kontrol();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            pBwin.Visible = false;
            sira = true;
            timer1.Enabled = true;
            xoxTimeBar1.RedValue = 5;



            for (int i = 0; i <= 2; i++) // Oyun tahta disinini tüm elemanlarına 5 değerini atadım
            {

                for (int j = 0; j <= 2; j++)
                {
                    oyun[i, j] = 5;
                }
            }
        }
        private void youwin() // Kazanma durumu 
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

            if (lblsira.Text == "Sıra: 0 da")
                lblsira.Text = "X Kazandı";
            else
                lblsira.Text = "0 Kazandı";
        }
        private void berabere() // Beraber kalma durumu
        {
            int sayac = 0;
            for (int i = 0; i <= 2; i++) // Tüm tahtayı kontrol ediyor
            {

                for (int j = 0; j <= 2; j++)
                {

                    if (oyun[i, j] != 5)
                        sayac++;
                }


                if (sayac == 9)
                {
                    if(xoxTimeBar1.RedValue>xoxTimeBar1.BlueValue)
                    {
                        lblsira.Text = "X Kazandı";
                    }
                    else if (xoxTimeBar1.RedValue < xoxTimeBar1.BlueValue)
                    {
                        lblsira.Text = "0 Kazandı";
                    }
                    else
                    {
                        lblsira.Text = "Berabere Kaldı!";
                    }
                }


            }
        }
        private bool kontrol() //Tahta dizisini kontrol ediyor. Kazanan varmı diye kontrol etme bölümü
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

            if ((oyun[0, 0] == 1 && oyun[0, 1] == 1 && oyun[0, 2] == 1) || //Tek Satırda kazanma durumu
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

        private void humhum_FormClosed(object sender, FormClosedEventArgs e)
        {
            baslangic.BaslangicFormu.Show();
        }

        private void xoxTimeBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sira)
            {
                xoxTimeBar1.RedValue--;


                if(xoxTimeBar1.RedValue<=0)
                {
                    youwin();
                }
            }
            else
            {
                xoxTimeBar1.BlueValue--;

                if (xoxTimeBar1.BlueValue <= 0)
                {
                    youwin();
                }
            }


    

        }
    }




}

