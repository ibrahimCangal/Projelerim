using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alanhesapla2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double sayi, sonuc;
            sayi = Convert.ToDouble(textBox1.Text);
            sonuc = sayi * sayi;
            textBox2.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double sayi, sonuc;
            sayi = Convert.ToDouble(textBox3.Text);
            sonuc =Math.PI*sayi * sayi;
            textBox4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double taban,yukseklik, sonuc;
            taban = Convert.ToDouble(textBox5.Text);
            yukseklik = Convert.ToDouble(textBox6.Text);
            sonuc = (taban * yukseklik) / 2;
            textBox7.Text = sonuc.ToString();
        }
    }
}
