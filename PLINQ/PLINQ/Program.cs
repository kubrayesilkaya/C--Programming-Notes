using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PLINQ

            Console.WriteLine("Main thread başladı.");

            int[] data = new int[100000000];

            for(int i = 0; i < data.Length; i++)
                data[i] = i;

            data[1000] = -1;
            data[14000] = -2;
            data[15000] = -3;
            data[676000] = -4;
            data[8024540] = -5;
            data[9908000] = -6;
            data[676100] = -7;
            data[8024440] = -8;
            data[9902300] = -9;

            var result = from val in data.AsParallel().AsOrdered()
                         where val < 0
                         select val;

            foreach(var val in result)
            {
                Console.WriteLine(val + " ");
            }

            Console.WriteLine("Main thread bitti.");
            
            Console.ReadLine();
        }
    }
}
