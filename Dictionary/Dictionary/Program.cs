using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary

            // Key - value => plaka - şehir

            Dictionary<int, string> plakalar = new Dictionary<int, string>();

            plakalar.Add(41, "Kocaeli");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(53, "Rize");

            Dictionary<int, string> sayilar = new Dictionary<int, string>()
            {
                {1, "Bir"},
                {2, "İki"},
                {3, "Üç"}
            };

            Console.WriteLine(plakalar[41]);
            if(plakalar.ContainsKey(34) ) {
                Console.WriteLine(plakalar[34]);
            }

            foreach(var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " " + plaka.Value);
            }

            // update
            sayilar[1] = "one";
            //sayilar.Remove(1);
            //sayilar.Clear();

            Console.WriteLine(sayilar[1]);
        }
    }
}
