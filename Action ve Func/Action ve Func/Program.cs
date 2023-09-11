using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_ve_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action ve func birer delegate'dir ve bu amaçla kullanılır. 

            /* Action 
             * 
             * Action, geriye değer döndürmeyen (void) metotlar için kullanılır.
             * Delegate'in geriye değer dönmeyen .NET Framework sınıfı versiyonudur.
             * 
             * Action'ın generic bir yapısı vardır yani başlangıçta siz bir tip belirlersiniz ve ona göre çalışır.
             * Action ve Func dil özelliği değildir; framework'de olan bir özelliktir.
             */

            Action<int, string> action = new Action<int, string>(KullaniciBilgi);

            // Biz burada action'ı kullanırken aslında o arka planda KullanıcıBilgiisimli metodu işaret etti, temsil etti onu kullandı.


            // Func

            // Geriye değer dönebilen Action versiyonudur. Ya da delegate versiyonudur.

            Func<DateTime, double> func = new Func<DateTime, double>(GetUserAgeAtTime);
            double dateDiff = func(new DateTime(2000, 02, 29));
            Console.WriteLine(dateDiff + " gündür yaşıyorsunuz. İnsan bilir ne yaşadığını..");


            Console.ReadLine();
        }

        static void KullaniciBilgi(int kullaniciId, string adSyoyad)
        {
            Console.WriteLine("Kullanıcı Id : " + kullaniciId);
            Console.WriteLine("Ad Soyad : " + adSyoyad);
        }

        static double GetUserAgeAtTime(DateTime birthDate)
        {
            return (DateTime.Now - birthDate).TotalDays;
        }
    }
}
