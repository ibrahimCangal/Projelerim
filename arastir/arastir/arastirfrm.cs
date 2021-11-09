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

namespace arastir
{
    public partial class arastirfrm : Form
    {
        public arastirfrm()
        {
            InitializeComponent();
        }

        public bool kontrol(String dizin)
        {            
            if (dizin.Contains("$RECYCLE.BIN") ==true|| dizin.Contains("$Recycle.Bin")|| dizin.Contains("Documents and Settings") || dizin.Contains("MSOCache"))
            {                
                return true; 
            }
            else
            if (dizin.Contains("System Volume Information") == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ara(String dizin)
        {

            String[] klasorler = Directory.GetDirectories(dizin);
            for (int j = 0; j < klasorler.Length; j++)
            {
                if (kontrol(klasorler[j]) == false)
                {
                    String[] dizinler = Directory.GetFiles(klasorler[j], "*.txt", SearchOption.AllDirectories);


                    for (int i = 0; i < dizinler.Length; i++)
                    {
                        StreamReader sr = new StreamReader(dizinler[i]);
                        int sayac = 0;
                        while (sr.EndOfStream == false)
                        {
                            String satir = sr.ReadLine();
                            if (satir.Contains(aranantxt.Text))
                            {
                                sonuclist.Items.Add(dizinler[i] + "----" + sayac + ". satırda bulundu");
                            }
                            sayac++;
                        }
                        sr.Close();
                        String dosyaadi = Path.GetFileName(dizinler[i]);
                        if (dosyaadi.Contains(aranantxt.Text))
                        {
                            sonuclist.Items.Add(dizinler[i] + "----" + "Dosya Adında Bulundu");
                        }
                    }
                }
            }
            MessageBox.Show("Arama İşlemi Tamamlandı");            
        }


        private void dizinsecbtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            belirlidizintxt.Text = folderBrowserDialog1.SelectedPath;
        }

        private void tumsurucurd_CheckedChanged(object sender, EventArgs e)
        {
            dizinsecbtn.Enabled = false;
            belirlidizintxt.Enabled = false;
        }

        private void uygulamasurrd_CheckedChanged(object sender, EventArgs e)
        {
            dizinsecbtn.Enabled = false;
            belirlidizintxt.Enabled = false;
        }

        private void belirtilendizinrd_CheckedChanged(object sender, EventArgs e)
        {
            dizinsecbtn.Enabled = true;
            belirlidizintxt.Enabled = true;
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            if(tumsurucurd.Checked==true)
            {
                DriveInfo[] suruculer = DriveInfo.GetDrives();
                for(int i=0;i<suruculer.Length;i++)
                {
                    ara(suruculer[i].Name);
                }
            }
            else if(uygulamasurrd.Checked==true)
            {
                ara(Path.GetPathRoot(Application.StartupPath));
            }
            else if(belirtilendizinrd.Checked==true)
            {
                ara(belirlidizintxt.Text);
            }
            else
            {
                MessageBox.Show("Dizin Seçeneğini Belirleyiniz");
            }
        }
    }
}
