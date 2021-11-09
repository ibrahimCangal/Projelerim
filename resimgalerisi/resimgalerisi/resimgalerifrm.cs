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

namespace resimgalerisi
{
    public partial class resimgalerifrm : Form
    {
        ImageList il;
        String[] dizinler;
        int konum;
        public resimgalerifrm()
        {
            InitializeComponent();
        }

        public void resimyukle()
        {           
            dizinler = Directory.GetFiles("Resimlerim\\", "*.jpg", SearchOption.AllDirectories);
            il = new ImageList();
            il.ImageSize = new Size(100, 100);
            il.ColorDepth = ColorDepth.Depth24Bit;
            for (int i = 0; i < dizinler.Length; i++)
            {
                il.Images.Add(Image.FromFile(dizinler[i]));
            }
            resimlerlv.View = View.LargeIcon;
            resimlerlv.LargeImageList = il;
            for (int i = 0; i < dizinler.Length; i++)
            {
                resimlerlv.Items.Add("", i);
            }
            solabtn.Enabled = true;
            sagabtn.Enabled = true;
            otomatikchk.Enabled = true;
        }
        private void resimacbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            galeripb.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void farklikaydetbtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            galeripb.Image.Save(saveFileDialog1.FileName);
        }

        private void iceriaktarbtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            
            dizinler = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg", SearchOption.AllDirectories);
            for (int i = 0; i < dizinler.Length; i++)
            {
                File.Copy(dizinler[i], "Resimlerim\\" + Path.GetFileName(dizinler[i]));
            }
            resimyukle();
        }

        private void resimlerlv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
           
        }

        private void resimlerlv_Click(object sender, EventArgs e)
        {
            galeripb.Image = Image.FromFile(dizinler[resimlerlv.FocusedItem.Index]);
            konum = resimlerlv.FocusedItem.Index;
        }

        private void solabtn_Click(object sender, EventArgs e)
        {
            if (konum >= 1)
            {
                konum--;
                galeripb.Image = Image.FromFile(dizinler[konum]);
            }
        }

        private void sagabtn_Click(object sender, EventArgs e)
        {
            if (konum < dizinler.Length-1)
            {
                konum++;
                galeripb.Image = Image.FromFile(dizinler[konum]);
            }
        }

        private void resimgalerifrm_Load(object sender, EventArgs e)
        {
            resimyukle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            galeripb.Image = Image.FromFile(dizinler[r.Next(dizinler.Length)]);
        }

        private void otomatikchk_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value)*1000;
            if(otomatikchk.Checked==true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
