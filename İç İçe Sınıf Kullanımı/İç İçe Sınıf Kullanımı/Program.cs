using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İç_İçe_Sınıf_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.PropA = 4;

            A.B b = new A.B();
            b.PropB = 5;

            Console.ReadLine();
        }
    }

    class A
    {
        public int PropA { get; set; }

        public A()
        {
            Console.WriteLine("A sınıfı");
        }

        public class B
        {
            public int PropB { get; set; }

            public B()
            {
                Console.WriteLine("B sınıfı");
            }
        }
    }
}
