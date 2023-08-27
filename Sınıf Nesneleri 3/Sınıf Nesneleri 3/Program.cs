using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Nesneleri_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            var result = acc.GetAccount(3);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
