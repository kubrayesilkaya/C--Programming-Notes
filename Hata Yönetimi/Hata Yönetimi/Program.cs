using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception
            // System.FormatException
            // System.DivideByZeroException
            // System.NullReferenceException

            try
            {
                Console.WriteLine("1.sayı: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.sayı: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                var sonuc = sayi1 / sayi2;

                Console.WriteLine(sonuc);
            }
            catch (FormatException)
            {
                Console.WriteLine("Sayısal bilgileri düzgün giriniz");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sayı 2, sıfır olmamalıdır.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu.");
                Console.WriteLine(ex.Message);
            }

            // Exception Handling
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
    }
}
