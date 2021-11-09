using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mp3calar
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wplayer.URL = textBox1.Text;
            wplayer.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }
    }
}
