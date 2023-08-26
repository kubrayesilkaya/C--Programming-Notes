using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Nesneleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutu k = new Kutu(5,6,7);

            Console.WriteLine(k.uzunluk);

            /* Sınıflarda constructor methods (yapıcı metotlar) isimli kavram vardır.
             * Yapıcı metot, oluşturulan sınıfın nesnelerini üretmek için oluşturulan bir metottur. 
             */
            
        }
    }
}
