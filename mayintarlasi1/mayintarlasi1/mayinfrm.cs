using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi1
{
    public partial class mayinfrm : Form
    {
        int[,] mt;
        public mayinfrm()
        {
            InitializeComponent();
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            int mayinsayisi;
            if (mayinsayitxt.Text != "")
            {
                mayinsayisi = int.Parse(mayinsayitxt.Text);
                button1.BackgroundImage = null;
                button2.BackgroundImage = null;
                button3.BackgroundImage = null;
                button4.BackgroundImage = null;
                button5.BackgroundImage = null;
                button6.BackgroundImage = null;
                button7.BackgroundImage = null;
                button8.BackgroundImage = null;
                button9.BackgroundImage = null;
                mt = new int[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        mt[i, j] = 0;
                    }
                }

                Random r = new Random();
                for (int i = 0; i < mayinsayisi; i++)
                {
                    mt[r.Next(3), r.Next(3)] = 1;
                }
                durumlbl.Text = "OYUN BAŞLADI!";
            }
            else
            {
                MessageBox.Show("Mayın Sayısını Belirleyiniz");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mt[0,0]==0)
            {
                button1.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mt[0, 1] == 0)
            {
                button2.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mt[0, 2] == 0)
            {
                button3.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mt[1, 0] == 0)
            {
                button4.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mt[1, 1] == 0)
            {
                button5.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mt[1, 2] == 0)
            {
                button6.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mt[2, 0] == 0)
            {
                button7.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mt[2, 1] == 0)
            {
                button8.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mt[2, 2] == 0)
            {
                button9.BackgroundImage = Image.FromFile("safe.png");
            }
            else
            {
                button1.BackgroundImage = Image.FromFile("bombp.png");
                button2.BackgroundImage = Image.FromFile("bombp.png");
                button3.BackgroundImage = Image.FromFile("bombp.png");
                button4.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button5.BackgroundImage = Image.FromFile("bombp.png");
                button6.BackgroundImage = Image.FromFile("bombp.png");
                button7.BackgroundImage = Image.FromFile("bombp.png");
                button8.BackgroundImage = Image.FromFile("bombp.png");
                button9.BackgroundImage = Image.FromFile("bombp.png");
            }
        }
    }
}
