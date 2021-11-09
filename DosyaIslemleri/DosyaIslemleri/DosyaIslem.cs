using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DosyaIslemleri
{
    class DosyaIslem
    {
        //Sınıfımızın özellikleri
        //1. yaz isimli bir metoda sahip olsun.
        //yaz isimli metot uygulama içerisinde loglama amaçlı kullanılsın.
        //yaz isimli metot gönderilen her metni log.txt isimli bir dosyaya yazsın.
        //log.txt isimli dosyanın her zaman üzerine eklensin.Yani eski kayıtlar her zaman tutulsun.
        //eklediği log kayıtlarının her birine bilgisayarın ip adresini eklesin.
        //2. ara isimli bir metoda sahip olsun. 
        //bu metot gönderilen dizinde belirtilen bir dosya adını arasın.
        //aranan dosya adı tam adı olması gerekmesin.
        //eğer dosya varsa geriye bu dosya veya dosyaların dizinlerini döndürsün. 
        //Hiç birşey bulunanamışsa null geri döndürsün.
        //3. sil isimli bir metoda sahip olsun.
        //eğer 1 adet dosya adı ve dizini gönderilmişse onu silsin
        //eğer birden fazla dosya adı ve dizini gönderilmişse hepsini silsin.

        //bir metot veya değişkenin başına herhangi bir erişim belirteci yazılmazsa
        //o bileşen private(sınıf içine özel) olarak tanımlanır.
        private String ipAdres;
        public DosyaIslem()
        {
            String hostname = Dns.GetHostName();
            ipAdres = Dns.GetHostByName(hostname).AddressList[0].ToString();
        }

        public void yaz(String veri)
        {
            try
            {
                StreamWriter sw = new StreamWriter("log.txt", true);//true parametresi dosyayı üzerine yazma modunda açmamızı sağlar.Yoksa oluşturulur varsa üzerine yazılır.
                sw.WriteLine(ipAdres + ":" + DateTime.Now.ToString() + ":" + veri);
                sw.Close();
            }
            catch 
            {
              
            }
           
        }

        public List<String> ara(String dizin,String aranan)
        {
            try
            {
                List<String> sonuclar = new List<string>();
                String[] liste = Directory.GetFiles(dizin, "*.*", SearchOption.AllDirectories);
                //GetFiles metotdu 3 adet parametre alır ve geriye varsa dosya listesini döndürür
                //1. parametresi(dizin) hangi dizindeki dosyaların bir listesi olacağını belirler.
                //2. parametresi listeleyeceği dosyaların türünü belirler *.* tüm dosya türleri demektir.
                //3. parametresi alt dizinlerde arama yapılıp yapılmayacağını belirler.
                for (int i = 0; i < liste.Length; i++)
                {
                    String dosyaAdi = Path.GetFileName(liste[i]);
                    if (dosyaAdi.Contains(aranan) == true)
                    {
                        sonuclar.Add(liste[i]);
                    }
                }
                if (sonuclar.Count > 0)
                {
                    return sonuclar;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception err)
            {
                yaz(err.Message);
            }
            return null;
        }
        public void sil(String []dosya)
        {
            try
            {
                for (int i = 0; i < dosya.Length; i++)
                {
                    File.Delete(dosya[i]);
                }
            }
            catch (Exception err)
            {
                yaz(err.Message);
            }    
        }
        public void sil(String dosya)
        {
            try
            {               
                File.Delete(dosya);              
            }
            catch (Exception err)
            {
                yaz(err.Message);
            }
        }

    }
}
