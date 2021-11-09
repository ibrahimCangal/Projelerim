using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dosyaklasorislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bir dosyayı silmek
            File.Delete(textBox1.Text);          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bir dosyanın adını değiştirmek
            File.Move(textBox2.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bir klasör oluştur
            Directory.CreateDirectory(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Bir klasör sil
            Directory.Delete(textBox5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] dizi = Directory.GetFiles(textBox6.Text, "*.*", SearchOption.AllDirectories);
            for(int i=0;i<dizi.Length;i++)
            {
                listBox1.Items.Add(dizi[i]);         
            }

        }
    }
}
