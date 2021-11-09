using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaIslemleri
{
    public partial class diFrm : Form
    {
        DosyaIslem di;
        public diFrm()
        {
            InitializeComponent();   
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dosyaLst.Items.Clear();
                di = new DosyaIslem();
                List<String> sonuc = di.ara(dizinTxt.Text, arananTxt.Text);
                if(sonuc!=null)
                {
                    for (int i = 0; i < sonuc.Count; i++)
                    {
                        dosyaLst.Items.Add(sonuc[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Sonuç Bulunamadı");
                }
            }
            catch (Exception err)
            {
                di.yaz(err.Message);                
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliIndexler = dosyaLst.SelectedIndices;//seçili olan indexlerin listesini verir
                
                if(seciliIndexler.Count>0)
                {                   
                    for (int i = 0; i < seciliIndexler.Count; i++)
                    {                       
                        di.sil(dosyaLst.Items[seciliIndexler[i]].ToString());                        
                    }
                    for (int i = 0; i < seciliIndexler.Count; i++)
                    {                       
                        dosyaLst.Items.RemoveAt(seciliIndexler[i]);
                    }

                } else
                {
                    MessageBox.Show("Listeden Dosya Seçiniz!");
                }


            }
            catch (Exception err)
            {
                di.yaz(err.Message);
            }
        }
    }
}
