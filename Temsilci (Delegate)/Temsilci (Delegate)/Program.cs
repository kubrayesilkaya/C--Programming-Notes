using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temsilci__Delegate_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Temsilciler (delegate)
             * 
             * Temsilcilerin temel amacı, bir ya da birden fazla metodu temsil etmektir. Onları işaret eden birer pointer'dır.
             *
             */

            // Hesap delegate'ini kullanmak istiyorum, bu nedenle hesabın nesne örneğini üreteceğim.

            //Hesap hesap = Topla; // İsmi hesap olacak ve Topla adında bir metodu temsil edecek.
            //int sonuc = hesap(5, 4);

            //hesap = Carp; // Hesap isimli delegate'e çarp metodunu işaret etmesini söyledim.
            //Console.WriteLine("Çarp : " + hesap(5,4));

            // 2.yöntem: *****************************************************  

            //Hesap hesap = new Hesap(Topla); // Farklı bir nesne örneği oluşturarak,Nesne örneği oluşturma sırasında hesap delegate'ine topla metodunu gönderdim.
            //Console.WriteLine("Topla : " + hesap(5,4));
            //hesap = new Hesap(Cikar); // Hesap delegate'inin Cikar metodunu işaret etmesini istiyorum.
            //Console.WriteLine("Çıkar : " + hesap(5,4));

            // 3. yöntem: *****************************************************

            Hesap hesap = new Hesap(Topla);
            int sonuc = hesap.Invoke(4,4); 

            Console.WriteLine(sonuc);

            /* Delegate ile temsil edeceği metotların imzasının aynı olması gerekli. 
             * Hesap adındaki delegate int bir geri dönüşe sahip ve iki tane int parametre alıyor. 
             *  Diğer metotlar da hepsi iki tane integer parametre alır ve geri dönüş tipleri integer'dır. 
             */


            Console.ReadLine();
        }

        delegate int Hesap(int x, int y);
        //Sen delegate olarak şu metotları işaret edebilir olacaksın; yani temsil edebilme yeteneğin olacak.

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Cikar(int a, int b)
        {
            return a - b;
        }

        static int Carp(int a, int b)
        {
            return a * b;
        }

        static int Bol(int a, int b)
        {
            if(a > 0 && b > 0)
            {
                return a / b;
            }
            return 0;
        }
    }
}
