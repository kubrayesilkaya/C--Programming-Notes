using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Parallel_Library___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paralle Programming : TPL

            /*
             * Neler Yapılabilir?
             * 
             * Yeni görevler oluşturmak, bu görevleri başlatmak, duraklatmak ve sonlandırmak mümkündür.
             * Bir görevin bittiği yerden başka bir görevi başlatmak mümkündür.
             * Başarıyla yerine getirilen görevlerin sonucunda değerler döndürmek mümkündür.    
             * Bir görev kendi içinde alt görevler başlatabilir.
             * Görevler aynı veya farklı thread'ler tarafından yerine getirilebilir.
             */

            Task tsk = new Task(MyTask);
            Thread t = Thread.CurrentThread;

            Console.WriteLine("Main Thread ID : " + t.ManagedThreadId);
            Console.WriteLine("ID : " + tsk.Id);

            tsk.Start();

            for(int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            tsk.Wait();

            Console.WriteLine("Main thread bitti.");

            Console.ReadLine();
        }

        static void MyTask()
        {
            Console.WriteLine("MyTask() başladı");
            Console.WriteLine("Current ID : " + Task.CurrentId);

            for(int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("MyTask() count : " + count);
            }
            Console.WriteLine("MyTask() tamamlandı.");
        }
    }
}
