using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metindeki_Kelime_Sayısını_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma : Metindeki Kelime Saysını Bulma

            var result = WordCount("Nefesten yumuşak yağan bu yağmur");

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static int WordCount(string data)
        {
            int result = 0;
            
            data = data.Trim();

            if(data == "")
            {
                return 0;
            }

            while( data.Contains("  ") )
            {
                data = data.Replace("  ", " ");
            }

            foreach( string d  in data.Split(' '))
            {
                result++;
            }

            return result;
        }
    }
}
