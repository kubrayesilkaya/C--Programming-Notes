using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Random_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random

            Random rnd = new Random();

            //var rnd = new Random(); // Random yerine var ile de oluşturulabilir.

            int sayi1 = rnd.Next(100);

            int sayi2 = rnd.Next(50, 100);

            Console.WriteLine(sayi1);

            //***********************************************************************

            string[] takimlar = {"Beşiktaş", "Galatasaray", "Fenerbahçe", "Trabzon"};

            var rnd2 = new Random();

            int sayi = rnd2.Next(0,4); // min katılıyor fakat max katılmıyor (0,1,2,3)

            Console.WriteLine(sayi);

            Console.WriteLine(takimlar[sayi]);
        }
    }
}
