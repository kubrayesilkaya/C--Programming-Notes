using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IkiBoyut iki = new IkiBoyut();
            iki.Genislik = 10;
            iki.Yukseklik = 20;
            iki.Goster();

            Console.WriteLine("*********************");

            Ucgen uc = new Ucgen();
            uc.Genislik = 20;
            uc.Yukseklik = 30;
            uc.Stil = "Üçgen";
            uc.StilGoster();
            uc.Goster();
            Console.WriteLine("Alan : " + uc.AlanHesapla());

            Console.ReadLine();
        }
    }
}
