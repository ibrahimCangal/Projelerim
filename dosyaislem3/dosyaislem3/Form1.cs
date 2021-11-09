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

namespace dosyaislem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TEK SATIR OKUMA
            //StreamReader sread = new StreamReader(textBox2.Text);
            //String s = sread.ReadLine();
            //textBox1.Text = s;
            //sread.Close();

            //ÇOK SATIR OKUMA
            //StreamReader sread = new StreamReader(textBox2.Text);
            //String s = sread.ReadToEnd();
            //textBox1.Text = s;
            //sread.Close();

            //ÇOK SATIR OKUMA
            StreamReader sread = new StreamReader(textBox2.Text);
            while(sread.EndOfStream==false)
            {
                String s = sread.ReadLine();
                MessageBox.Show(s);
            }
            sread.Close();
        }
    }
}
