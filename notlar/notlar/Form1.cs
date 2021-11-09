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

namespace notlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("kayit.txt", true);
            sw.WriteLine(textBox1.Text + " - " + textBox2.Text + " - " + textBox3.Text);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("kayit.txt");
            listBox1.Items.Clear();
            while(sr.EndOfStream==false)
            {
                String s = sr.ReadLine();
                listBox1.Items.Add(s);
            }
            sr.Close();
        }
    }
}
