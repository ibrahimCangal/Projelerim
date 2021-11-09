using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFHesapMak
{
    public partial class MainPage : ContentPage
    {
        Double sonuc,sayi1,sayi2;
        String islem = "";

        public MainPage()
        {
            InitializeComponent();
        }

        void temizle(Object sender,EventArgs e)
        {
            sonucLbl.Text = "";           
            islem = "";
        }
        void islemsec(Object sender, EventArgs e)
        {
            try
            {
                if (sonucLbl.Text != "" && islem == "")
                {
                    Button bt = (Button)sender;// Object olarak gelen butonu button türüne dönüştür.
                    islem = bt.Text;
                    sayi1 = Convert.ToDouble(sonucLbl.Text);
                    sonucLbl.Text = "";
                }
            }
            catch (Exception err)
            {

                sonucLbl.Text = err.Message;
            }
            
        }       
        void karekok(Object sender, EventArgs e)
        {
            try
            {
                if (sonucLbl.Text != "")
                {
                    sayi1 = Convert.ToDouble(sonucLbl.Text);
                    sonuc = Math.Sqrt(sayi1);
                    sonucLbl.Text = sonuc.ToString();
                }
            }
            catch (Exception err)
            {

                sonucLbl.Text = err.Message;
            }
           
        }
        void sayi(Object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (sonucLbl.Text == "İşlem Seçiniz")
            {
                sonucLbl.Text = "";
            }
            else
            {
                if (bt.Text == ",")
                {
                    if (sonucLbl.Text != "")
                    {
                        if (sonucLbl.Text.Contains(",") == false)
                        {
                            sonucLbl.Text = sonucLbl.Text + bt.Text;
                        }
                    }
                }
                else
                {
                    sonucLbl.Text = sonucLbl.Text + bt.Text;
                }
            }
        }
        void hesapla(Object sender, EventArgs e)
        {
            try
            {
                if (islem != "")
                {
                    sayi2 = Convert.ToDouble(sonucLbl.Text);
                    if (islem == "+")
                    {
                        sonuc = sayi1 + sayi2;
                    }
                    else if (islem == "-")
                    {
                        sonuc = sayi1 - sayi2;
                    }
                    else if (islem == "/")
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else if (islem == "X")
                    {
                        sonuc = sayi1 * sayi2;
                    }
                    else if (islem == "%")
                    {
                        sonuc = sayi1 * (sayi2 / 100);
                    }
                    sonucLbl.Text = sonuc.ToString();
                    islem = "";
                }
                else
                {
                    sonucLbl.Text = "İşlem Seçiniz";
                }
            }
            catch (Exception err)
            {
                sonucLbl.Text = err.Message;
               
            }
            
        }
    }
}
