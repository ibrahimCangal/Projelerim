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

namespace dosyaislem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox2.Text,true);
            //true parametresi eski dosyanın silinmemesini sağlar
            sw.WriteLine(textBox1.Text);
            //sw.Write ile yanyana yazılabilir.
            sw.Close();
        }
    }
}
