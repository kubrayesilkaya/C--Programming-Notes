using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sealed Classes (Mühürlü Sınıf)

            // Sealed bir sınıfı mühürler ve o sınıftan miras alınmasını engeller.

            // Başına sealed yazılan class'tan miras alınamaz.

            B b = new B();
            // b.PropA = 1; // yapılamaz, çünkü a'dan miras alınamaz, a sealed class olması nedeni ile.
            b.PropB = 3;

            Console.ReadLine();
        }

        sealed class A
        {
            public int PropA { get; set; }
        }

        class B // : A // hata verir, a'dan miras alınamaz çünkü sealed class!
        {
            public int PropB { get; set;}
        }
    }
}
