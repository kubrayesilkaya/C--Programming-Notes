using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multithread uygulamalarda ana thread (main thread) sonlansa bile diğer threatlarin bitmesini bekleyecektir uygulama. 
            // Aksi halde main thread ending yazdıktan sonra bu işlemin tamamlanması gerekirdi,
            // yani uygulamanın bitmiş olması gerekiyordu, diğer thread'lere çalışma izmi vermezdi.

            Console.WriteLine("Main thread starting.");

            IsParcacigi isci = new IsParcacigi("Child 1");
            Thread newThrd = new Thread(isci.Run);
            newThrd.Start();

            do
            {
                Console.Write(".");
                Thread.Sleep(100);
            } while (isci.Count != 10);

            Console.WriteLine("Main thread ending.");

            Console.ReadLine();
        }
    }

    class IsParcacigi
    {
        public int Count;
        public Thread Thrd;

        public IsParcacigi(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        public void Run()
        {
            Console.WriteLine(Thrd.Name + " starting");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);
                Count++;
            } while (Count <= 10);
            Console.WriteLine(Thrd.Name + "terminating.");
        }

    }
}
