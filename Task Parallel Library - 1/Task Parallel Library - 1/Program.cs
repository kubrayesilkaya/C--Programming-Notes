using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Parallel_Library___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parallel Programming : TPL

            /* 
             * Birden fazla işlemciniz olduğu durumlarda paralel programlama söz konusu olabilir.
             * Çünkü birden fazla işlemcinin bir işi yapabilmesi için o işi parçalara ayırmasını sağlayarak daha hızlı bir şekilde daha 
             * performanslı yapması üzerine kurulu bir programlama tekniğidir.
             * 
             * Paralel Programlama, birden fazla işlemcinin bulunduğu donanımlarda yazılımın gücünü daha etkili bir şekilde kullanabilmek için
             * belli iş süreçlerini, işlemcilerin farklı işlemcilere dağıtarak onların aynı anda yapılabilmesini sağlar.
             */

            /*
             * .NET Framework'deki TPL (Task Parallel Library)'de neler yapılabilir?
             * 
             * Yeni görevler oluşturmak, bu görevleri başlatmak, duraklatmak ve sonlandırmak mümkündür.
             * Bir görevin bittiği yerden başka bir görevi başlatmak mümkündür.
             * Başarıyla yerine getirilen görevlerin sonucunda değerler döndürmek mümkündür.
             * Bir görev kendi içinde alt görevler başlatabilir.
             * Görevler aynı veya farklı thread'ler tarafından yerine getirilebilirler.
             */

            Console.WriteLine("Main thread başladı.");

            Task tsk = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Görev Bşaladı.");

                for (int count = 0; count < 10; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Task count is " + count);
                }
            });

            Console.WriteLine("Durum : " + tsk.Status.ToString());

            // tsk bitene kadar beklet
            tsk.Wait();

            Console.WriteLine("Durum : " + tsk.Status.ToString());

            // tsk'yı Dispose et
            tsk.Dispose();

            Console.WriteLine("Main thread bitt.");

            Console.ReadLine();
        }
    }
}
