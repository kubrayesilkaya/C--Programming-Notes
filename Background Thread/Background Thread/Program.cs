using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Background_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Background Thread (Arka Plan İş Parçacığı)

            /* Normal thread, örneğin main thread'de : Bir tane main thread var iken (bu varsayılan olarak kullamılan bir thread), 
               siz başka bir işlem yaptırmak için bir tane daha oluşturduğunuzda, main thread çalışırken kendi işi bitse bile,
               diğer thread'in işinin itmesini bekler yani onu durdurmaz.Main thread bittiğinde diğer thread çalışmasına devam eder;
               o da kendi işini bitirdikten sonra uygulama genel olarak bitmiş olur.

               Background thread'lerde durum böyle değildir. Siz önemsiz olarak gördüğünüz thread'leri background thread'lere atarsanız;
               Main thread var ve devam ediyor iken, onun işi bittiği zaman, backround thread'leri otomatik olarak kendisi kapatır; 
               bunu CLR (Common language runtime) gerçekleştirir.
            */

            Thread myThread = new Thread(CalisacakMetot);
            myThread.IsBackground = true;
            myThread.Start();

            // Ana Thread (Main Thread) 'in görevi başladı
            Thread.Sleep(2000);
            Console.WriteLine("Ana thread sona erdi.");
            // Ana Thread (Main Thread) 'in görevi bitti

            /* IsBackgorund true olması : Ana thread'in işi bittiği anda, yani 2 saniye bekleyip ana thread sona erdiği ve ekrana yazdıktan
             * sonra, main thread kapansın ve kapanırken de arka plan olarak işaretlenmiş olan bütün threadleri sonlandır; (onlar çok da önemli
             * değildi zaten demek.)
             */

            /*
             * IsBackground'u kaldırırsak, bu normal bir thread olur. Yani main thread bitse bile, diğer threadler önemli; onları da bekliyor,
             * uygulama kapanmıyor. Ana thread bitse bile diğer tüm thread'leri bekleyecektir.
             */
        }

        static void CalisacakMetot()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("İşlem " + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("CalisacakMetod() thread'i sona erdi!");
            Console.ReadLine();
        }
    }
}
