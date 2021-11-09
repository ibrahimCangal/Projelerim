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

namespace csvokuyaz
{
    public partial class csvfrm : Form
    {
        public csvfrm()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("kayit.csv") == false)
            {
                StreamWriter sw = new StreamWriter("kayit.csv",true);
                sw.WriteLine("Numara,Ad Soyad,Bölüm");
                sw.WriteLine(numaratxt.Text+","+adsoyadtxt.Text+","+bolumtxt.Text);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("kayit.csv", true);
                sw.WriteLine(numaratxt.Text + "," + adsoyadtxt.Text + "," + bolumtxt.Text);
                sw.Close();
            }

        }

        private void okubtn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("kayit.csv");
            while(sr.EndOfStream==false)
            {
                String satir = sr.ReadLine();
                verilerlst.Items.Add(satir);
            }
            sr.Close();
        }

        private void getirbtn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("kayit.csv");
            int satirnumara = int.Parse(satirnumaratxt.Text);
            int satirsayac = 0;
            while (sr.EndOfStream == false)
            {
                String satir = sr.ReadLine();
                if(satirsayac==satirnumara)
                {
                    String[] satirdizi = satir.Split(',');
                    gnumaratxt.Text = satirdizi[0];
                    gadsoyadtxt.Text = satirdizi[1];
                    gbolumtxt.Text = satirdizi[2];
                }
                satirsayac++;
            }
            sr.Close();
        }
    }
}
