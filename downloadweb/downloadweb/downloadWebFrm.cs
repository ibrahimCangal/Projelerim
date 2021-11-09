using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downloadweb
{
    public partial class downloadWebFrm : Form
    {
        public downloadWebFrm()
        {
            InitializeComponent();
        }

        public String webDownload(String url)
        {
            try
            {
                WebClient wc = new WebClient();
                String sonuc = wc.DownloadString(new Uri(url));
                return sonuc;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return null;
        }

       async void webDownloadAsenkron(String []url)
        {
            try
            {
                foreach (var ws in url)
                {
                    WebClient wc = new WebClient();
                    durumlbl.Text = ws;
                    String sonuc="";
                    try
                    {
                        sonuc = await wc.DownloadStringTaskAsync(new Uri("http://" + ws));
                    }
                    catch (Exception)
                    {

                       
                    }
                   
                    File.WriteAllText(ws+".txt", sonuc);
                }
                
            }
            catch (Exception)
            {
                //MessageBox.Show(err.Message);
            }          
        }

        async Task<String> webDownloadAsenkron(String url)
        {
            try
            {
                WebClient wc = new WebClient();                
                String sonuc =await wc.DownloadStringTaskAsync(new Uri(url));
                return sonuc;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return null;
        }

        private void indirBtn_Click(object sender, EventArgs e)
        {
            String s;
            s = webDownload(urltxt.Text);
            htmlrtb.Text = s;
        }

        private void topluindirbtn_Click(object sender, EventArgs e)
        {
            String[] dizi = urllerrtb.Text.Split('\n');
            webDownloadAsenkron(dizi);
        }
    }
}
