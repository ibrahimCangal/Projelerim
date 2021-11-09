using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renklisiyahbeyaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap ConvertToGrayscale(Bitmap source)
        {
            Bitmap bm = new Bitmap(source.Width, source.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    int luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    bm.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return bm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
           bmp= ConvertToGrayscale(bmp);
            pictureBox2.Image = bmp;
        }
    }
}
