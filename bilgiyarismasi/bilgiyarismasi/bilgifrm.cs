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
using System.Collections;

namespace bilgiyarismasi
{
    public partial class bilgifrm : Form
    {
        String[] sorular;
        String[] soru;
        int sorusirasi = 0;
        int skor = 0;
        public bilgifrm()
        {
            InitializeComponent();
        }

        private void yeniyarismabtn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("sorular.txt");
            ArrayList al = new ArrayList();
            while(sr.EndOfStream==false)
            {
                String satir = sr.ReadLine();
                al.Add(satir);
            }
            sr.Close();
            int sorusayi = int.Parse(sorusayitxt.Text);
            Random r = new Random();
            sorular = new String[sorusayi];
            for(int i=0;i<sorusayi;i++)
            {
                int rsayi = r.Next(al.Count);
                sorular[i] = al[rsayi].ToString();
                al.RemoveAt(rsayi);
            }
            cevaplist.Items.Clear();
            soru = sorular[0].Split(';');
            sorurtb.Text = soru[0];
            cevaplist.Items.Add(soru[1]);
            cevaplist.Items.Add(soru[2]);
            cevaplist.Items.Add(soru[3]);
            cevaplist.Items.Add(soru[4]);
            sorusirasi = 1;
            skor = 0;
            skorlbl.Text = skor.ToString();
            sonuclbl.Text = "";
            joker1btn.Enabled = true;
        }

        private void cevaplabtn_Click(object sender, EventArgs e)
        {
            if (sorusirasi <= int.Parse(sorusayitxt.Text))
            {
                String cevap = cevaplist.SelectedIndex.ToString();
                if (cevap == soru[5])
                {
                    sonuclbl.ForeColor = Color.Green;
                    sonuclbl.Text = "Doğru Cevap";
                    skor++;
                    skorlbl.Text = skor.ToString();
                }
                else
                {
                    sonuclbl.ForeColor = Color.Red;
                    sonuclbl.Text = "Yanlış Cevap";
                    skor--;
                    skorlbl.Text = skor.ToString();
                }
                if (sorusirasi < int.Parse(sorusayitxt.Text))
                {
                    cevaplist.Items.Clear();
                    soru = sorular[sorusirasi].Split(';');
                    sorurtb.Text = soru[0];
                    cevaplist.Items.Add(soru[1]);
                    cevaplist.Items.Add(soru[2]);
                    cevaplist.Items.Add(soru[3]);
                    cevaplist.Items.Add(soru[4]);
                }
            }
            else
            {
                MessageBox.Show("Yarışma Tamamlandı");
            }
            sorusirasi++;
        }

        private void joker1btn_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add("0");
            al.Add("1");
            al.Add("2");
            al.Add("3");
            al.Remove(soru[5]);
            Random r = new Random();
            int s = r.Next(al.Count);
            int s1 = Convert.ToInt32(al[s]);
            al.RemoveAt(s);
            s = r.Next(al.Count);
            int s2 = Convert.ToInt32(al[s]);
            cevaplist.Items[s1] = "XXX";
            cevaplist.Items[s2] = "XXX";
            joker1btn.Enabled = false;
        }
    }
}
