using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma___Metni_Tersine_Çevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma : Metni Tersine Çevirme

            // Yağmur
            // ruğaY

            var result = Reverse("yağmur");
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static string Reverse(string data)
        {
            string result = "";

            for(int i = data.Length - 1; i >= 0; i--)
            {
                result += data[i];
            }

            return result;
        }
    }
}
