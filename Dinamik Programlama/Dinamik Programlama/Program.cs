using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamik_Programlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dinamik Programlama (Dynamic Programming)
            *  Dinamik Programlama, geliştirme aşamasında değil de runtime 'da üretilen nesneler için kullanılan bir terimdir.
            *  Yani geliştitirken, bir sınıf geliştirip, bunun nesne örneğini oluşturup,onun içerisindeki proporty, metot, bunlara erişme gibi
            *  yeteneklerden mahrum kalınan bir alandır.
            *  Tamamen runtime'da (proje çalışmaya başladığı anda) dinamik programlama nesneleri çalıştırılır ve yazılan koda göre aşamalı bir şekilde çalışmaya devam eder.
            */

            dynamic a = 5;
            Console.WriteLine(a);
            a = "AA";
            Console.WriteLine(a);

            // Oluşturacağımız nesne programın çalışma anında oluşacak ve o anda gerçekleşecek ve kurulmaya başlanacak.

            dynamic insan = new ExpandoObject();
            insan.Ad = "Kübra";
            insan.Soyad = "Yeşilkaya";

            Console.WriteLine(insan.Ad + " " + insan.Soyad); 
            // Bunların hiçbiri henüz yok. Program çalışmaya başladığında üretilecek, bunlara değerler atanacak ve sonra da okunacak.

            dynamic kisi = new ExpandoObject();
            kisi.Ad = "Kübra";
            kisi.Soyad = "Yeşilkaya";
            kisi.AdGoster = new Action(() =>
            {
                Console.WriteLine("Ad : " + kisi.Ad);
            });
            kisi.TekrarEt = new Func<string, string>(gelen =>
            {
                return gelen;
            });

            // Çalıştırma İşlemleri   
            kisi.AdGoster();

            dynamic sonuc = kisi.TekrarEt("Çoklu tekrar");
            Console.WriteLine("Gelen cevap : " + sonuc);


            foreach(dynamic user in GetList())
            {
                Console.WriteLine("{0} {1}", user.Ad, user.Soyad);
            }

            Console.ReadLine();
        }

        private static IEnumerable<dynamic> GetList()
        {
            var users = new List<User> { 
                new User() { ID = 3, FirstName = "Kübra", LastName = "Yeşilkaya" },
                new User() { ID = 3, FirstName = "Çiçek", LastName = "Mutlu" }
            };

            return from k in users
                   select new {Ad = k.FirstName, Soyad = k.LastName};
        }
    }

    class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
