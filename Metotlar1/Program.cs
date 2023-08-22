using System;

namespace Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar

            // Metotlar sınıf içerisinde yer alırlar ve metodun dışında tanımlanırlar. Metot içinde metot tanımlaması olmaz.

            var result = Topla(5,4);

            Yaz(result.ToString());

            Yaz("Merhaba!");
            //Bosluk();
            Bosluk(5);
            Yaz("Merhaba");

            var sonuc = GetAccountName(5);
            Yaz(sonuc);

            var sonucVal = IsValid("ayse.guzelhotmail.com");
            Yaz(sonucVal.ToString()); 

            var sonucVal2 = IsValid("ayse.guzel@hotmail.com");
            Yaz(sonucVal2.ToString());

            Beklet();

        }

        static bool IsValid(string email)
        {
            bool IsValid = default(bool);

            if (email.Contains("@"))
            {
                IsValid = true;
            }
            return IsValid;

            // @ işareti yok ise zaten default'da false olacağı için; tekrar bir else kısmı yazmamıza gerek yok.
        }

        static string GetAccountName(int accountID)
        {
            string accountName = string.Empty;
            switch (accountID)
            {
                case 1:
                    accountName = "Ali";
                    break;
                case 2:
                    accountName = "Ayşe";
                    break;
                case 5:
                    accountName = "Muhammed";
                    break;
                default:
                    accountName = "Unknown";
                    break;
            }
            return accountName;
        }

        static void Bosluk()
        {
            Console.WriteLine(Environment.NewLine);
        }

        static void Bosluk(int bosSatirSayisi)
        {
            for(int i = 0; i < bosSatirSayisi; i++)
            {
                Console.WriteLine();
            }
        }

        static int Topla(int sayi1, int sayi2)
        {
            // int sonuc = sayi1 + sayi2;
            // return sonuc;

            return sayi1 + sayi2;
        }

        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static void Beklet()
        {
            Console.ReadLine();
        }
    }
}
