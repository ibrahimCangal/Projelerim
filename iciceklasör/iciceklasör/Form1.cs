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

namespace iciceklasör
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "c:\\users\\omer\\desktop\\a";
            Directory.CreateDirectory(s);
            s = s + "\\a";
            for (int i=0;i<1000000;i++)
            {                
                Directory.CreateDirectory(s+i);                
            }
        }
    }
}
