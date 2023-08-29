using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual___Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Miras alınan sınıf içerisindeki bir metodun içeriğini ezerek, override ederk değiştirme işlemi.

            /* Virtual keyword'ü override edileilir anlamına gelir. Eğer bir nesnede,metotta virtual yazıyorsa, ezerek, içeriği değiştirilerek kullanılabilir;
             * yazmıyorsa bunu yapamazsınız. 
             */

            Calisan isci = new Calisan();
            isci.Ad = "Yoona";
            isci.Soyad = "Sun";
            Console.WriteLine(isci.ToString());
            Console.WriteLine("Maaş : " + isci.MaasHesapla());

            Muhendis muhendis = new Muhendis();
            muhendis.Ad = "Kübra";
            muhendis.Soyad = "Yeşilkaya";
            Console.WriteLine(muhendis.ToString());
            Console.WriteLine("Maaş : " + muhendis.MaasHesapla());


            Console.ReadLine();
            
        }
    }
}
