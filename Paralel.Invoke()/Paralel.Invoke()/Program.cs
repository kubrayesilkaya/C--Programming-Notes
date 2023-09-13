using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Paralel.Invoke__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parallel.Invoke() birden fazla metodu parametre olarak alır ve bunların hepsini paralel bir şekilde çalıştırır.

            Console.WriteLine("Main thread başladı.");

            Thread.Sleep(2000);

            Parallel.Invoke(My2, My1);

            Console.WriteLine("Main thread bitti.");

            Console.ReadLine();
        }

        static void My1()
        {
            Console.WriteLine("My1 başladı.");

            for(int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("My1 count is : " + count);
            }

            Console.WriteLine("My1 bitti.");
        }

        static void My2()
        {
            Console.WriteLine("My2 başladı.");

            for(int count = 0;count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("My2 count is : " + count);
            }

            Console.WriteLine("My2 bitti.");
        }
    }
}
