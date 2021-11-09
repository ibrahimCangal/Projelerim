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

namespace resimsifrele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dosyanın byte tabanlı okunması
            FileStream fs = new FileStream("resim.jpg", FileMode.Open);//dosyayı okuma modunda aç
            Byte[] bt = new Byte[fs.Length];//dosya boyutu kadar byte dizisi tanımla
            fs.Read(bt, 0, bt.Length);//dosyanın tamamını byte dizisine aktar
            fs.Close();

            Byte[] bt2 = new Byte[bt.Length];
            int s = bt.Length - 1;
            for(int i=0;i<bt.Length;i++)
            {
                bt2[i] = bt[s];
                s--;
            }



            //Dosyanın byte tabanlı yazılması
            FileStream fsyaz = new FileStream("c:\\users\\omer\\desktop\\resim_kopya.jpg", FileMode.Create);//Dosyayı oluştur
            fsyaz.Write(bt2, 0, bt2.Length);//veri yaz
            fsyaz.Close();
        }
    }
}
