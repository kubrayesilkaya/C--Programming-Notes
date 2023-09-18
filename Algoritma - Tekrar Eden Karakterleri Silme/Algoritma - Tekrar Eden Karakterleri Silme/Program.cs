using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma___Tekrar_Eden_Karakterleri_Silme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma : Tekrar Eden Karakterleri Silme

            var result1 = RemoveDuplicateCharacters("Melek");
            var resul2 = RemoveDuplicateCharacters("Umut");

            Console.WriteLine(result1);
            Console.WriteLine(resul2);

            Console.ReadLine();
        }

        static string RemoveDuplicateCharacters(string input)
        {
            string data = "", result = "";

            foreach(var val in input)
            {
                if (data.IndexOf(val) == -1)
                {
                    data += val;
                    result += val;
                }
            }
            return result;
        }
    }
}
