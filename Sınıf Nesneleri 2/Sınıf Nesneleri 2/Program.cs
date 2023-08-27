using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Nesneleri_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sınıflar

            Kutu k = new Kutu();
            //k.uzunluk = -100;
            //Console.WriteLine(k.uzunluk);

            k.SetUzunluk(-100);
            Console.WriteLine(k.GetUzunluk());

            k.Genislik = -30;
            Console.WriteLine(k.Genislik);

            Console.ReadLine();
        }
    }
}
