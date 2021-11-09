using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            // okul otamasyon projesi
         
            string adSOYAD = "boş";
            string adSOYADgiriş;
            int tc =11111;
            int yaş =1;
            string eskiokul = "boş";
            int şifre = 1;
            int numara = 0000;
        aa:
            Console.WriteLine("Okul Kayıt Programına Hoşgeldiniz");
            Console.WriteLine("Lütfen Ne Yapmak İstediğinizi Seçiniz");
            Console.WriteLine("Kayıt Olmak İstiyorsanız (2) Tuşuna basınız");
            Console.WriteLine();
            Console.WriteLine("Giriş Yapmak İstiyorsanız (1) Tuşuna Basınız");
            Console.WriteLine();
           
            Console.WriteLine("Uygulamadan Çıkmak İsityorsanız Herhangi Bir Tuşa Basınız");
            int seçenek = Convert.ToInt32(Console.ReadLine());
            switch (seçenek)
            {
                case (1):
                bb:
                    Console.WriteLine();
                    Console.WriteLine("Lütfen  Adınızı ve Şifrenizi Giriniz");
                    Console.Write("Adınız Ve Soy Adınız = ");
                    adSOYADgiriş = Convert.ToString(Console.ReadLine());
                    Console.Write("Şifre = ");
                    int ŞifreGiriş = int.Parse(Console.ReadLine());


                    if (adSOYADgiriş == adSOYAD&&ŞifreGiriş == şifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Bilgileriniz:");
                        Console.WriteLine();

                        Console.WriteLine("T.C. Kimlik Numaranız = " + tc);
                        Console.WriteLine();
                        Console.WriteLine("Okul Numaranız = " + numara);
                        Console.WriteLine();
                        Console.WriteLine("Giriş Adınız = " + adSOYAD);
                        Console.WriteLine();
                        Console.WriteLine("Giriş Şifreniz = " + şifre);
                        Console.WriteLine();
                        Console.WriteLine( "Geldiği Okul = " + eskiokul);
                        Console.WriteLine();
                        Console.WriteLine("Yaşı = " + yaş);
                        Console.WriteLine("Okula Kayıt Olup Giriş Yaptığınız İçin Teşekkürler");
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("Developer MT" );
                        System.Threading.Thread.Sleep(8000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Giriş Başarısız");
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Lütfen Adınız Ve Soyadınızı Veya Şifrenizi Doğru girdiğinizden Emin Olun");
                        System.Threading.Thread.Sleep(500);
                        goto bb;


                        
                    }
                    break;
                case (2):
                    goto cc;
                    break;
                  default:
                    Console.WriteLine("Uygulama Kapanıyor");
                    System.Threading.Thread.Sleep(500);
                    Environment.Exit(0);
                    break;
            }
            cc:
            Console.WriteLine("Lütfen Kayıt İşlemini Başarılı Bir Şekilde Gerçekleştirmek İçin Bilgilerinizi Eksizsiz Giriniz");
            Console.WriteLine("Kayıta Başlamak İçin (0) Tuşuna Basınız");
            int Soru1 = int.Parse(Console.ReadLine());
            switch (Soru1)
            {
               
                case (0):
                    Console.WriteLine();
                    Console.WriteLine("Kayıt İşlemi Başladı");
                    Console.WriteLine("Lütfen Adınızı Ve Soy Adınızı Giriniz");
                    Console.WriteLine();
                    adSOYAD = Convert.ToString(Console.ReadLine());
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lütfen Yaşınızı Giriniz");
                    yaş = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lütfen T.C. Kimlik Numaranızı Giriniz");
                     tc  = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lütfen  Eski Okulunuzu Giriniz");
                    Console.WriteLine("Not: İlk Defa Kayıt Oluyorsanız İlk Kayıt Yazınız");
                    eskiokul = Convert.ToString(Console.ReadLine());
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lütfen Bekleyin... Yönlendiriliyorsunuz...");
                    System.Threading.Thread.Sleep(1000);

                    Random rastgele = new Random();
                     numara = rastgele.Next(0, 1000);
                    Random rastgele1 = new Random();
                     şifre = rastgele.Next(1000, 10000);
                    Console.WriteLine("Kayıt Başarılı !");

                    Console.WriteLine("Bilgileriniz:"); 

                    Console.WriteLine("Okul Numaranız = " + numara);
                    Console.WriteLine("Giriş Kullanıcı Adınız = " + adSOYAD);
                    Console.WriteLine("Giriş Şifreniz = " + şifre);
                    Console.WriteLine();
                    Console.WriteLine("Başa Yönlendiriliyorsunuz...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1000);
                    goto aa;
                    break;

                default:
                    Console.WriteLine("Okul Kayıt İşlemi İptal Edildi");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                   

            }
           
        }
    
    }
}
