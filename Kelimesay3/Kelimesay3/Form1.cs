using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelimesay3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //girilen cümledeki kelimeleri say
            String cumle;
            cumle = textBox1.Text;
            String[] dizi = cumle.Split(' ');
            textBox2.Text = dizi.Length.ToString();
        }
    }
}
