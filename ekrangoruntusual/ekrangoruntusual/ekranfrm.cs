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

namespace ekrangoruntusual
{
    public partial class ekranfrm : Form
    {
        public ekranfrm()
        {
            InitializeComponent();
        }

        private void ekrangabtn_Click(object sender, EventArgs e)
        {
            Rectangle boyutlar = Screen.PrimaryScreen.Bounds;         
            Bitmap ekrangoruntusu = new Bitmap(boyutlar.Width, boyutlar.Height);
            Graphics g = Graphics.FromImage(ekrangoruntusu);
            g.CopyFromScreen(boyutlar.Left, boyutlar.Top, 0, 0, boyutlar.Size);
            ekrangorpb.Image = ekrangoruntusu;
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("\\EkranGoruntuleri\\" + DateTime.Now.ToString() + ".jpg");
            String dizin = "EkranGoruntuleri\\" + DateTime.Now.Ticks.ToString() + ".jpg";
            ekrangorpb.Image.Save(dizin);
            gecmislst.Items.Add(dizin);
        }

        private void gecmislst_Click(object sender, EventArgs e)
        {
            ekrangorpb.Image = Image.FromFile(gecmislst.Items[gecmislst.SelectedIndex].ToString());
        }

        private void ekranfrm_Load(object sender, EventArgs e)
        {
            String[] dosyalar = Directory.GetFiles("EkranGoruntuleri\\");
            for(int i=0;i<dosyalar.Length;i++)
            {
                gecmislst.Items.Add(dosyalar[i]);
            }
        }
    }
}
