using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_ve_Hata_Yönetimi_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception
            // System.FormatException
            // System.DivideByZeroException
            // System.NullReferenceException

            Console.WriteLine("1.sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            var sonuc = sayi1 / sayi2;

            Urun urun = null;
            Console.WriteLine(urun.UrunAdi);

            // Exception Handling
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
    }
}
