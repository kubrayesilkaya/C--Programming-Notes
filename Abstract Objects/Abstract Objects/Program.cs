using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstarct Class

            // Abstract olarak işaretlenen sınıf içerisindeki abstract metotların içeriğini, miras alınan sınıf doldurmak zorundadır.

            /* Eğer bir abstarct class kalıtım alınıyorsa, o abstract class'taki tüm abstarct metotlar, kalıtım alan sınıflar
             * tarafından implement edilmeli ve override ile metot gövdesi oluşturulmaslıdır. 
             */

            /* Abstarct işlemi virtual override'ın zornulu halidir.
             * 
             * Virtual override : Bir base sınıftan miras alınan sınıfın içerisindeki bir metodu ezme yetkisi verne, içeriğini değiştirme, override etme yetkisi vermektir.
             *                    Virtual override'da bu opsiyonel iken; abstact'ta zorunlu bir durumdur.
             * 
             */
            
            Muhendis muh = new Muhendis();
            Console.WriteLine(muh.GetSalary());

            Console.ReadLine();
        }
    }
}
