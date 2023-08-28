using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance (Kalıtım / Miras)

            A a = new A();
            a.PropA = 3;

            B b = new B();
            b.PropB = 5;
            b.PropA = 8;

            C c = new C();
            c.PropC = 1;

            Console.ReadLine();
            
        }
    }

    class A          // Base (Temel Sınıf)
    {
        public int PropA { get; set; }
    }

    class B : A     // Derived, türemiş sınıf
    {
        public int PropB { get; set; }
    }

    class C : B
    {
        public int PropC { get; set; }
    }
}
