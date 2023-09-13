using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Parallel_Library___ContinueWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Continue işlemi => elimizde bir görev, task var.
            // Bu task bittiği zaman, kendisinden sonraki bir göreve devam etsin komutu veriyor.
            // Görevler zinciri oluşturmayı sağlayan bir yapı.

            /*
             * tsk bir görev. Bu görev MyTask() metodunu çalıştırır.
             * Bu bittikten sonra da, tsk'nın ContinueWith(ContTask) metodu ile devam etmesi gerekiyor.
             */

            Task tsk = new Task(MyTask);
            Task taskContinue = tsk.ContinueWith(ContTask);

            // tsk'nin bitmesini bekliyor taskContinue; başlamak için.

            tsk.Start();
            taskContinue.Wait();

            // ana task dispose edilir ve taskContinue disose edilir.

            tsk.Dispose();
            taskContinue.Dispose();

            Console.WriteLine("Main thread bitti.");

            Console.ReadLine();
        }

        static void MyTask()
        {
            Console.WriteLine("MyTask() başladı");

            for(int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("MyTask() count : " + count);
            }
            Console.WriteLine("MyTask() tamamlandı.");
        }

        static void ContTask(Task t)
        {
            Console.WriteLine("Devam etme işlemi başladı.");

            for(int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Continuation count is " + count);
            }
            Console.WriteLine("Devam etme işlemi bitti.");
        }
    }
}
