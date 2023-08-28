using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encryption encry = new Encryption();             
            //encry.Encrypt("abc");
            //encry.Decrypt("38u38r8ıofjsfa");

            Console.WriteLine(Encryption.Encrypt("asada"));
            Console.WriteLine(Encryption.Decrypt("3yomnoyin"));

            // static, bir nesne örneğine ihtiyaç duymadan, bir sınıf içerisindeki nesnelere erişmeyi sağlar.

            // static class üzerinden bir instance üretilemez.


            Kullanici k1 = new Kullanici();
            Kullanici k2 = new Kullanici();
            Kullanici k3 = new Kullanici();
            Kullanici k4 = new Kullanici();
            Kullanici k5 = new Kullanici();

            Console.WriteLine(k1.GetId());
            Console.WriteLine(k5.GetId());

            Console.ReadLine();
        }
    }
}
