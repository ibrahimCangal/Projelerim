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

namespace dosyaislem4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("d:\\sss.txt", true);
            for(int i=0;i<=1000;i++)
            {
                sw.WriteLine(i.ToString());
            }
            sw.Close();
            MessageBox.Show("Tamamlandı");
        }
    }
}
