using System;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sonuc = EnBuyuk(1, 2, 3, 4, 5, 6, 7,8, 9, 10);
            Yaz(sonuc.ToString());
            
            Yaz(Rastgele().ToString());

            //Opsiyonel
            KullaniciEkle("Ali", "Bulut"); // kullanıcı aktifliği varsayılan olarak true
            KullaniciEkle("Ayşe", "Güneş", false); // fakat istenilirse gönderilebilir

            //Named Parameters
            KullaniciEkle(ad:"Gül", soyad:"Özhan", aktifMi:true, cinsiyet: true);

            // Düzenli görünüm için aşağı satıra da atılabilir:
            KullaniciEkle(ad: "Lale",
                          soyad: "Çiçek",
                          aktifMi: true,
                          cinsiyet: true);
            //Artık isimlendirilmiş olduğu için sırası önemli değil, çünkü zaten nereye gittiği belli. 
            KullaniciEkle(cinsiyet: true,
                          ad: "Deniz",
                          soyad: "Çiçek",
                          aktifMi: true
                          );

        }

        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        static int EnBuyuk(int a, int b)
        {
            if(a > b)
                return a;
            return b; //return a olmadıysa zaten büyük değildir demek; o zaman b yi dönecektir.
        }

        static int EnBuyuk(int a, int b, int c)
        {
            return EnBuyuk(EnBuyuk(a, b), c); //ilk parametre (a,b) den büyük olan; ikinci paramtre c.
        }

        static int EnBuyuk(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        static int Rastgele()
        {
            Random rnd = new Random();
            return rnd.Next(1000, int.MaxValue);
        }

        // Opsiyonel Parametreler

        //  Opsiyonel parametreler; parametrelerin en sağında yer almadılır. (birden fazla olabilir, sağda olmalılar.)

        // static void KullaniciEkle(string ad, string soyad, bool aktifMi = true, bool cinsiyet = true) // kullanıcı sisteme girdiğinde varsayılan olarak true. 
        // {
        //     Yaz("Ad : " + "\nSoyad : " + soyad + "\nAktif : " + aktifMi);
        // }

        // isimlendirilmiş Parametreler (Named Parameters)

        static void KullaniciEkle(string ad, string soyad, bool aktifMi = true, bool cinsiyet = true)
        {
            Yaz("Ad : " + ad + "\nSoyad : " + soyad + "\nAktif : " + aktifMi);
        }


    }
}
